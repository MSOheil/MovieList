using Movie.DataLayer.Data;
using Movie.DataLayer.ExtentionMethodHelper;
using Movie.DataLayer.Repositories;
using Movie.ViewModel.Model;
using Movie.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataLayer.Servicess
{
    public class MovieRepository : IMovieListRepository
    {
        private MovieContext_DBEntities8 _db;

        public MovieRepository(MovieContext_DBEntities8 context)
        {
            _db = context;
        }

        public bool DeleteMovie(MovieModel movieModel)
        {
            try
            {
                _db.Entry(movieModel).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteMovie(int movieId)
        {
            try
            {

                var movie = FindById(movieId);
                DeleteMovie(movie);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public MovieModel FindById(int movieId)
        {
            return _db.MovieModels.Find(movieId);

        }

        public CommentModel FindByIdComment(int movieId)
        {
            return _db.CommentModels.Find(movieId);
        }

        public string FindNameById(int movieId)
        {
            return _db.MovieModels.Find(movieId).MovieName;
        }

        public IEnumerable<CommentViewModel> GetAllComment(int movieId)
        {
            return _db.CommentModels.Where(sa => sa.MovieId == movieId).Select(sc => new CommentViewModel
            {
                CommentUser = sc.CommentDescription,
                UserName = sc.CommentName,
                CommentRat = sc.CommentRat
            }).ToList();
        }
        public IEnumerable<Genre> GetMovieByGenresName(string genresName)
        {
            return _db.Genres.Where(am => am.GenresName.Contains(genresName)).ToList();
        }





        public bool InsertComment(CommentModel comment)
        {
            try
            {
                _db.CommentModels.Add(comment);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertMovie(MovieModel movieModel)
        {
            try
            {
                _db.MovieModels.Add(movieModel);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public bool UpDateMovie(MovieModel movie)
        {
            try
            {
                _db.Entry(movie).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }


        public IEnumerable<GetNameGenresViewModel> GetNameGenres()
        {
            return _db.Genres.Select(sa => new GetNameGenresViewModel
            {
                GenresId = sa.GenresId,
                GenresName = sa.GenresName
            }).ToList();
        }

        public IEnumerable<CommentModel> GetCommentWithMoviId(int movieId)
        {
            return _db.CommentModels.ToList();
        }



        public bool InsertGenres(GenresToMovie genresId)
        {
            try
            {
                _db.GenresToMovies.Add(genresId);
                return true;
            }
            catch
            {
                return false;

            }
        }





        public List<string> FindNameGenresByIdGenres(int genresId)
        {
            var genreName = _db.Genres.Where(s => s.GenresId == genresId).Select(s => s.GenresName).ToList();
            return genreName.ToList();
        }





        private double AverageRate(IEnumerable<double> rate)
        {
            var averageRateMovie = rate.AsQueryable().DefaultIfEmpty().Average();
            return Convert.ToDouble(averageRateMovie);
        }
        private IQueryable<MovieModel> PagingByTakeAndSkip(int pageNumber, int ResultPerPage, string movieName, string directorName, int fromDate, int toDate, int idGenres
            , bool sortDate, bool sortAverage, bool sortDescending, double filterByAverageRate = 0)
        {
            var movieFilterAndSorting = _db.MovieModels.AsNoTracking().AsQueryable();
            if (idGenres != 0)
            {
                movieFilterAndSorting = movieFilterAndSorting.Where(s => s.GenresToMovies.Any(a => a.GenresId == idGenres));
            }
            if (movieName != null)
            {
                movieFilterAndSorting = movieFilterAndSorting.Where(a => a.MovieName.Contains(movieName));
            }
            if (directorName != null)
            {
                movieFilterAndSorting = movieFilterAndSorting.Where(s => s.DirectorName.Contains(directorName));
            }
            if (fromDate != 1 && toDate != 10000)
            {
                movieFilterAndSorting = movieFilterAndSorting.Where(s => s.DateProduction >= fromDate && s.DateProduction <= toDate);
            }
            if (fromDate == 1 && toDate != 10000)
            {
                movieFilterAndSorting = movieFilterAndSorting.Where(s => s.DateProduction >= fromDate && s.DateProduction <= toDate);
            }
            if (fromDate != 1 && toDate == 10000)
            {
                movieFilterAndSorting = movieFilterAndSorting.Where(s => s.DateProduction >= fromDate && s.DateProduction <= toDate);
            }
            movieFilterAndSorting = movieFilterAndSorting.OrderBy(a => a.MovieID);
            if (sortDate == true)
            {
                movieFilterAndSorting = movieFilterAndSorting.OrderBy(a => a.DateProduction);
            }
            if (filterByAverageRate > 0)
            {
                movieFilterAndSorting = movieFilterAndSorting.AsEnumerable().Where(a => AverageRate(a.CommentModels.Select(s => s.CommentRat)) >= filterByAverageRate).AsQueryable();
            }
            if (sortDescending == true)
            {
                movieFilterAndSorting = movieFilterAndSorting.OrderByDescending(a => a.MovieID);
            }
            if (sortDate == true && sortDescending == true)
            {
                movieFilterAndSorting = movieFilterAndSorting.OrderByDescending(a => a.DateProduction);
            }
            if (sortAverage == true)
            {
                movieFilterAndSorting = movieFilterAndSorting.AsEnumerable().OrderBy(a => AverageRate(a.CommentModels.Select(s => s.CommentRat))).AsQueryable();
            }
            if (sortAverage == true && sortDescending == true)
            {
                movieFilterAndSorting = movieFilterAndSorting.AsEnumerable().OrderByDescending(a => AverageRate(a.CommentModels.Select(s => s.CommentRat).ToList())).AsQueryable();
            }
            return movieFilterAndSorting.Skip(ResultPerPage * (pageNumber - 1)).Take(ResultPerPage);
        }
        public List<RateMovieViewModel> FilterAndSortAndPaging(int pageNumber = 1, int ResultPerPage = 1000, string movieName = null, string directorName = null,
           int fromDate = 1, int toDate = 10000, int idGenres = 0, bool sortDate = false, bool sortAverage = false, bool sortDescending = false, double filterByAverageRate = 0)
        {
            var movie = PagingByTakeAndSkip(pageNumber, ResultPerPage, movieName, directorName, fromDate, toDate, idGenres, sortDate, sortAverage, sortDescending, filterByAverageRate);
            var vm = movie.AsEnumerable().Select(a => new RateMovieViewModel
            {
                DirectorName = a.DirectorName,
                GenresNamee = ConvertMembersListTOstring.ConvertListToString(a.GenresToMovies.Select(d => d.Genre.GenresName)),
                MovieAverageRateByRateUsers = AverageRate(a.CommentModels.Select(d => d.CommentRat).AsQueryable()),
                MovieId = a.MovieID,
                MovieNamee = a.MovieName,
                ProductionDate = a.DateProduction

            });
            return vm.ToList();
        }

        public int GetAllMovie()
        {
            return _db.MovieModels.Count();
        }

        public List<int> GetAllGenresByMovieId(int movieId)
        {
            var genresName = _db.GenresToMovies.Where(s => s.MovieId == movieId).Select(a => a.GenresId).ToList();
            return genresName;
        }

        public List<int> FindeGenresToMovieId(int movieId)
        {
            return _db.GenresToMovies.Where(a => a.MovieId == movieId).Select(a => a.GenresToMovieId).ToList();
        }

        public bool UpdateGenres(GenresToMovie genre)
        {
            try
            {
                _db.Entry(genre).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGenresToMovie(GenresToMovie genrestomovie)
        {
            try
            {
                _db.Entry(genrestomovie).State = EntityState.Deleted;
                return true;
            }
            catch
            {

                return false;
            }
        }


    }
}
