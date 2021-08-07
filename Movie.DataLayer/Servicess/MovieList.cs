using Movie.DataLayer.Data;
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
        private MovieContext_DBEntities3 _db;
        public MovieList(MovieContext_DBEntities3 context)
        {
            _db = context;
        }

        public bool deleteMovie(MovieModel movieModel)
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

        public bool deleteMovie(int movieId)
        {
            try
            {
                
                var movie = findById(movieId);
                deleteMovie(movie);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public MovieModel findById(int movieId)
        {
            return _db.MovieModels.Find(movieId);

        }

        public CommentModel findByIdComment(int movieId)
        {
            return _db.CommentModels.Find(movieId);
        }

        public string findNameById(int movieId)
        {
            return _db.MovieModels.Find(movieId).MovieName;
        }

        public List<CommentView> getAllComment(int movieId)
        {
            return _db.CommentModels.Where(sa => sa.MovieId == movieId).Select(sc => new CommentView
            {
                CommentUser = sc.CommentDescription,
                UserName = sc.CommentName,
                CommentRat=sc.CommentRat
            }).ToList();
        }

        public List<MovieModel> getAllMoveWithEndDate(DateTime parametr)
        {
            return _db.MovieModels.Where(dt => dt.DateProduction <= parametr).ToList();
        }

        public List<MovieModel> getAllMoveWithStarttDate(DateTime parametr)
        {
            return _db.MovieModels.Where(td => td.DateProduction >= parametr).ToList();
        }

        public IEnumerable<MovieModel> getAllMovie()
        {
            return _db.MovieModels.ToList();
        }

        public IEnumerable<MovieModel> getAllWithLowRat(int parametr)
        {
            return _db.MovieModels.Where(ra => ra.AverageRat <= parametr).ToList();
        }

        public IEnumerable<MovieModel> getAllWithUpRat(int parametr)
        {
            return _db.MovieModels.Where(ra => ra.AverageRat >= parametr).ToList();
        }

        public IEnumerable<MovieModel> getMovieByGenresName(string parametr)
        {
            return _db.MovieModels.Where(am => am.Generes == parametr).ToList();
        }

        public IEnumerable<MovieModel> getMovieByName(string parametr)
        {
            return _db.MovieModels.Where(mv => mv.MovieName == parametr).ToList();
        }

        public List<int> getRat()
        {
            return _db.MovieModels.Select(sa => sa.AverageRat).ToList();
        }

        public bool insertComment(CommentModel comment)
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

        public bool insertMovie(MovieModel movieModel)
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

        public IEnumerable<MovieModel> sortedByAverageRat()
        {
            return _db.MovieModels.OrderBy(sa => sa.AverageRat).ToList();
        }

        public IEnumerable<MovieModel> sortedByProductionDate()
        {
            return _db.MovieModels.OrderBy(sa => sa.DateProduction).ToList();
        }

        public bool upDateMovie(MovieModel movie)
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
    }
}
