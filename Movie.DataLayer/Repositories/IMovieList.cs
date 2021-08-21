using Movie.ViewModel.Model;
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
        int GetAllMovie();
        List<RateMovieViewModel> FilterAndSortAndPaging
            (int pageNumber, int ResultPerPage , string movieName, string directorName, double averageRateInput, int fromDate, int toDate, int idGenres, bool sortDate, bool sortAverage, bool sortDescending);
        IEnumerable<CommentModel> GetCommentWithMoviId(int movieId);
        IEnumerable<GetNameGenresViewModel> GetNameGenres();
        IEnumerable<CommentViewModel> GetAllComment(int movieId);
        IEnumerable<Genre> GetMovieByGenresName(string genresName);
        List<int> GetAllGenresByMovieId(int movieId);





        bool InsertMovie(MovieModel movieModel);
        bool InsertComment(CommentModel comment);
        bool InsertGenres(GenresToMovie genresId);





        bool DeleteMovie(MovieModel movieModel);
        bool DeleteMovie(int movieId);
        bool DeleteGenresToMovie(GenresToMovie genrestomovie);





        List<int> FindeGenresToMovieId(int movieId);
        string FindNameById(int movieId);
        MovieModel FindById(int movieId);
        CommentModel FindByIdComment(int movieId);
        List<string> FindNameGenresByIdGenres(int genresId);




        bool UpDateMovie(MovieModel movie);
        bool UpdateGenres(GenresToMovie genre);

    }
}
