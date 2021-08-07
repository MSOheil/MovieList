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

        IEnumerable<MovieModel> GetMovieByName(string parametr);
        IEnumerable<MovieModel> GetMovieByGenresName(string parametr);
        IEnumerable<MovieModel> GetAllWithUpRat(int parametr);
        IEnumerable<MovieModel> GetAllWithLowRat(int parametr);
        IEnumerable<MovieModel> SortedByAverageRat();
        IEnumerable<MovieModel> SortedByProductionDate();
        IEnumerable<MovieModel> GetAllMovie();
        List<MovieModel> GetAllMoveWithStarttDate(DateTime parametr);
        List<MovieModel> GetAllMoveWithEndDate(DateTime parametr);
        List<double> GetRat();
        List<CommentView> GetAllComment(int movieId);
        bool InsertMovie(MovieModel movieModel);
        bool InsertComment(CommentModel comment);
        bool DeleteMovie(MovieModel movieModel);
        bool DeleteMovie(int movieId);
        bool UpDateMovie(MovieModel movie);
        string FindNameById(int movieId);
        MovieModel FindById(int movieId);
        CommentModel FindByIdComment(int movieId);

    }
}
