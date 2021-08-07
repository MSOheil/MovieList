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
        List<MovieModel> getAllMoveWithStarttDate(DateTime parametr);
        List<MovieModel> getAllMoveWithEndDate(DateTime parametr);
        bool InsertMovie(MovieModel movieModel);
        bool InsertComment(CommentModel comment);
        bool DeleteMovie(MovieModel movieModel);
        bool DeleteMovie(int movieId);
        IEnumerable<MovieModel> sortedByAverageRat();
        IEnumerable<MovieModel> sortedByProductionDate();
        MovieModel findById(int movieId);
        List<int> getRat();
        CommentModel findByIdComment(int movieId);
        string findNameById(int movieId);
        List<CommentView> getAllComment(int movieId);
        IEnumerable<MovieModel> getAllMovie();

    }
}
