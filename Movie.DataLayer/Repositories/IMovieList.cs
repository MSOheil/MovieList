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

        List<RateMovieViewModel> SortedByProductionDateAscending();
        List<RateMovieViewModel> SortedByProductionDateDecending();
        List<RateMovieViewModel> SortedByAverageRateAscending();
        List<RateMovieViewModel> SortedByAverageRateDescending();




        IEnumerable<int> GetAllGenresByMovieId(int movieId);
        IEnumerable<RateMovieViewModel> GetAllMovie();
        List<RateMovieViewModel> GetAllMovieByIdGenres(int genresId);
        IEnumerable<CommentModel> GetCommentWithMoviId(int movieId);
        IEnumerable<GetNameGenresViewModel> GetNameGenres();
        IEnumerable<RateMovieViewModel> GetMovieByName(string movieName);
        double GetAverageRateMovie(int movieId);
        IEnumerable<CommentViewModel> GetAllComment(int movieId);
        IEnumerable<Genre> GetMovieByGenresName(string genresName);
        List<RateMovieViewModel> GetMovieByDirectorName(string directorName);






        bool InsertMovie(MovieModel movieModel);
        bool InsertComment(CommentModel comment);
        bool InsertGenres(GenresToMovie genresId);





        bool DeleteMovie(MovieModel movieModel);
        bool DeleteMovie(int movieId);





        string FindNameById(int movieId);
        MovieModel FindById(int movieId);
        CommentModel FindByIdComment(int movieId);
        List<string> FindNameGenresByIdGenres(int genresId);




        bool UpDateMovie(MovieModel movie);

    }
}
