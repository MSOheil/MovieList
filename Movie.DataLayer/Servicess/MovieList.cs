using Movie.DataLayer.Data;
using Movie.DataLayer.ExtentionMethodHelper;
using Movie.DataLayer.Repositories;
using Movie.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataLayer.Servicess
{
    public class MovieList : IMovieList
    {
        private MovieContext_DBEntities8 _db;

        public MovieList(MovieContext_DBEntities8 context)
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

        public List<RateMovieViewModel> GetAllMoveWithEndDate(int dateTime)
        {
            var movies = _db.MovieModels.Include(s => s.GenresToMovies).ToList();
            var genres = movies.Where(sd => sd.DateProduction <= dateTime);
            var vm = genres.Select(s => new RateMovieViewModel
            {
                DirectorName = s.DirectorName,
                GenresNamee = ConvertMembersListTOstring.ConvertListToString(s.GenresToMovies.Select(sd => sd.Genre.GenresName)),
                MovieId = s.MovieID,
                MovieNamee = s.MovieName,
                ProductionDate = s.DateProduction,
                MovieAverageRateByRateUsers = Math.Round(GetAverageRateMovie(s.MovieID), 2)
            });

            return vm.ToList();
        }

        public List<RateMovieViewModel> GetAllMoveWithStarttDate(int dateTime)
        {
            var movies = _db.MovieModels.Include(s => s.GenresToMovies).ToList();
            var genres = movies.Where(sd => sd.DateProduction >= dateTime);
            var vm = genres.Select(s => new RateMovieViewModel
            {
                DirectorName = s.DirectorName,
                GenresNamee = ConvertMembersListTOstring.ConvertListToString(s.GenresToMovies.Select(sd => sd.Genre.GenresName)),
                MovieId = s.MovieID,
                MovieNamee = s.MovieName,
                ProductionDate = s.DateProduction,
                MovieAverageRateByRateUsers = Math.Round(GetAverageRateMovie(s.MovieID), 2)
            });

            return vm.ToList();
        }

        public IEnumerable<MovieModel> GetAllWithDirectorName(int movieId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetMovieByGenresName(string genresName)
        {
            return _db.Genres.Where(am => am.GenresName.Contains(genresName)).ToList();
        }

        public IEnumerable<RateMovieViewModel> GetMovieByName(string movieName)
        {
            var movies = _db.MovieModels.Include(s => s.GenresToMovies).ToList();
            var genres = movies.Where(sd => sd.MovieName == movieName);
            var vm = genres.Select(s => new RateMovieViewModel
            {
                DirectorName = s.DirectorName,
                GenresNamee = ConvertMembersListTOstring.ConvertListToString(s.GenresToMovies.Select(sd => sd.Genre.GenresName)),
                MovieId = s.MovieID,
                MovieNamee = s.MovieName,
                ProductionDate = s.DateProduction,
                MovieAverageRateByRateUsers = Math.Round(GetAverageRateMovie(s.MovieID), 2)
            });

            return vm.ToList();
        }

        public double GetAverageRateMovie(int movieId)
        {
            RateMovieViewModel ave = new RateMovieViewModel();
            ave.MovieAverageRateByRateUsers = _db.CommentModels.Where(sa => sa.MovieId == movieId).Select(sd => sd.CommentRat).DefaultIfEmpty(0).Average();
            return ave.MovieAverageRateByRateUsers;
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

        public IEnumerable<MovieModel> SortedByDirectorName(string directorName)
        {
            return _db.MovieModels.OrderBy(sd => sd.DirectorName == directorName).ToList();
        }

        public IEnumerable<MovieModel> SortedByDirectorName()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> SortedByGenres(string genresName)
        {
            return _db.Genres.OrderBy(sa => sa.GenresName == genresName).ToList();
        }

        public List<RateMovieViewModel> SortedByProductionDateAscending()
        {
            var movies = _db.MovieModels.Include(s => s.GenresToMovies).ToList();
            var vm = movies.Select(s => new RateMovieViewModel
            {
                DirectorName = s.DirectorName,
                GenresNamee = ConvertMembersListTOstring.ConvertListToString(s.GenresToMovies.Select(sd => sd.Genre.GenresName)),
                MovieId = s.MovieID,
                MovieNamee = s.MovieName,
                ProductionDate = s.DateProduction,
                MovieAverageRateByRateUsers = Math.Round(GetAverageRateMovie(s.MovieID), 2)
            }).ToList();

            return vm.OrderBy(s=>s.ProductionDate).ToList();
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

        public List<RateMovieViewModel> SortedByProductionDateDecending()
        {
            var movies = _db.MovieModels.Include(s => s.GenresToMovies).ToList();
            var vm = movies.Select(s => new RateMovieViewModel
            {
                DirectorName = s.DirectorName,
                GenresNamee = ConvertMembersListTOstring.ConvertListToString(s.GenresToMovies.Select(sd => sd.Genre.GenresName)),
                MovieId = s.MovieID,
                MovieNamee = s.MovieName,
                ProductionDate = s.DateProduction,
                MovieAverageRateByRateUsers = Math.Round(GetAverageRateMovie(s.MovieID), 2)
            }).ToList();

            return vm.OrderByDescending(s => s.ProductionDate).ToList();
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

        public List<RateMovieViewModel> GetAllMovieByIdGenres(int genresId)
        {
            var movies = _db.MovieModels.Include(s => s.GenresToMovies).ToList(); 
            var genres = movies.Where(sd => sd.GenresToMovies.Any(s => s.GenresId == genresId));
            var vm = genres.Select(s => new RateMovieViewModel
            {
                DirectorName = s.DirectorName,
                GenresNamee = ConvertMembersListTOstring.ConvertListToString(s.GenresToMovies.Select(sd => sd.Genre.GenresName)),
                MovieId = s.MovieID,
                MovieNamee = s.MovieName,
                ProductionDate = s.DateProduction,
                MovieAverageRateByRateUsers = Math.Round(GetAverageRateMovie(s.MovieID), 2)
            });

            return vm.ToList();
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

        public IEnumerable<RateMovieViewModel> GetAllMovie()
        {

            var movies = _db.MovieModels.Include(s => s.GenresToMovies).ToList();
            var vm = movies.Select(s => new RateMovieViewModel
            {
                DirectorName = s.DirectorName,
                GenresNamee = ConvertMembersListTOstring.ConvertListToString(s.GenresToMovies.Select(sd => sd.Genre.GenresName)),
                MovieId = s.MovieID,
                MovieNamee = s.MovieName,
                ProductionDate = s.DateProduction,
                MovieAverageRateByRateUsers = Math.Round(GetAverageRateMovie(s.MovieID), 2)
            }).ToList();

            return vm;

        }

        public IEnumerable<int> GetAllGenresByMovieId(int movieId)
        {
            return _db.MovieModels.Where(sd => sd.MovieID == movieId)
                .SelectMany(sa => sa.GenresToMovies)
                .Select(ss => ss.Genre.GenresId).ToList();
        }

        public List<RateMovieViewModel> GetMovieByDirectorName(string directorName)
        {
            var movies = _db.MovieModels.Include(s => s.GenresToMovies).ToList();
            var genres = movies.Where(sd => sd.DirectorName == directorName);
            var vm = genres.Select(s => new RateMovieViewModel
            {
                DirectorName = s.DirectorName,
                GenresNamee = ConvertMembersListTOstring.ConvertListToString(s.GenresToMovies.Select(sd => sd.Genre.GenresName)),
                MovieId = s.MovieID,
                MovieNamee = s.MovieName,
                ProductionDate = s.DateProduction,
                MovieAverageRateByRateUsers = Math.Round(GetAverageRateMovie(s.MovieID), 2)
            });

            return vm.ToList();
        }

        public List<RateMovieViewModel> GetAllMovieByFilterRate(double rateInput)
        {
            var movies = _db.MovieModels.Include(s => s.GenresToMovies).ToList();
            var genres = movies.Where(sd => sd.CommentModels.Any(sa => sa.CommentRat >= rateInput));
            var vm = genres.Select(s => new RateMovieViewModel
            {
                DirectorName = s.DirectorName,
                GenresNamee = ConvertMembersListTOstring.ConvertListToString(s.GenresToMovies.Select(sd => sd.Genre.GenresName)),
                MovieId = s.MovieID,
                MovieNamee = s.MovieName,
                ProductionDate = s.DateProduction,
                MovieAverageRateByRateUsers = Math.Round(GetAverageRateMovie(s.MovieID), 2)
            });
            return vm.ToList();
        }

        public List<RateMovieViewModel> SortedByAverageRateAscending()
        {
            var movies = _db.MovieModels.Include(s => s.GenresToMovies).ToList();
            var vm = movies.Select(s => new RateMovieViewModel
            {
                DirectorName = s.DirectorName,
                GenresNamee = ConvertMembersListTOstring.ConvertListToString(s.GenresToMovies.Select(sd => sd.Genre.GenresName)),
                MovieId = s.MovieID,
                MovieNamee = s.MovieName,
                ProductionDate = s.DateProduction,
                MovieAverageRateByRateUsers = Math.Round(GetAverageRateMovie(s.MovieID), 2)
            }).ToList();

            return vm.OrderBy(s=>s.MovieAverageRateByRateUsers).ToList();
        }

        public List<RateMovieViewModel> SortedByAverageRateDescending()
        {
            var movies = _db.MovieModels.Include(s => s.GenresToMovies).ToList();
            var vm = movies.Select(s => new RateMovieViewModel
            {
                DirectorName = s.DirectorName,
                GenresNamee = ConvertMembersListTOstring.ConvertListToString(s.GenresToMovies.Select(sd => sd.Genre.GenresName)),
                MovieId = s.MovieID,
                MovieNamee = s.MovieName,
                ProductionDate = s.DateProduction,
                MovieAverageRateByRateUsers = Math.Round(GetAverageRateMovie(s.MovieID), 2),
            }).ToList();

            return vm.OrderByDescending(s => s.MovieAverageRateByRateUsers).ToList();
        }

        public List<string> FindNameGenresByIdGenres(int genresId)
        {
            var genreName = _db.Genres.Where(s => s.GenresId == genresId).Select(s => s.GenresName).ToList();
            return genreName.ToList();
        }
    }
}
