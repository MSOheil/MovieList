using Movie.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataLayer.Repositories
{
   public interface IMovieList
    {

        IEnumerable<MovieModel> getMovieByName(string parametr);
        IEnumerable<MovieModel> getMovieByGenresName(string parametr);
        IEnumerable<MovieModel> getAllWithUpRat(int parametr);
        IEnumerable<MovieModel> getAllWithLowRat(int parametr);
        IEnumerable<MovieModel> sortedByAverageRat();
        IEnumerable<MovieModel> sortedByProductionDate();
        IEnumerable<MovieModel> getAllMovie();
        List<MovieModel> getAllMoveWithStarttDate(DateTime parametr);
        List<MovieModel> getAllMoveWithEndDate(DateTime parametr);
        List<int> getRat();
        List<CommentView> getAllComment(int movieId);
        bool insertMovie(MovieModel movieModel);
        bool insertComment(CommentModel comment);
        bool deleteMovie(MovieModel movieModel);
        bool deleteMovie(int movieId);
        bool upDateMovie(MovieModel movie);
        string findNameById(int movieId);
        MovieModel findById(int movieId);
        CommentModel findByIdComment(int movieId);

    }
}
