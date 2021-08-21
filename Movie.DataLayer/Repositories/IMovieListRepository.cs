using Movie.ViewModel.Model;
using Movie.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.DataLayer.Repositories
{
    public interface IMovieListRepository
    {
        int GetAllMovie();
        List<RateMovieViewModel> FilterAndSortAndPaging
            (int pageNumber=1, int ResultPerPage =1000, string movieName=null, string directorName = null,
            int fromDate = 1, int toDate= 10000, int idGenres=0, bool sortDate =false, bool sortAverage=false, bool sortDescending=false,
            double filterByAverageRate = 0);
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
