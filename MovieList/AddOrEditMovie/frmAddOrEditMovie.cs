using Movie.DataLayer;
using Movie.DataLayer.Data;
using Movie.ViewModel.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieList
{
    public partial class frmAddOrEditMovie : Form
    {
        public int MovieId = 0;
        public frmAddOrEditMovie()
        {
            InitializeComponent();
        }
        private void btnInsertOrEdit_Click(object sender, EventArgs e)
        {

            if (MovieId > 0)
            {

                using (UnitOfWork db = new UnitOfWork())
                {
                    var genrestomovieid = 0;
                    foreach (var idgenres in db.MovieList.GetAllGenresByMovieId(MovieId))
                    {
                        foreach (var item in db.MovieList.FindeGenresToMovieId(MovieId))
                        {
                            genrestomovieid = item;
                            GenresToMovie genre = new GenresToMovie()
                            {
                                GenresId = idgenres,
                                MovieId = MovieId,
                                GenresToMovieId = genrestomovieid
                            };
                            db.MovieList.DeleteGenresToMovie(genre);
                        }
                    }

                    foreach (var ListBoxItem in checkedListGenresBySelectMovie.CheckedItems)
                    {
                        var id = Convert.ToInt32((checkedListGenresBySelectMovie.Items.IndexOf(ListBoxItem)).ToString());
                        GenresToMovie genres = new GenresToMovie()
                        {
                            GenresId = id,
                            MovieId = MovieId,
                            GenresToMovieId = genrestomovieid
                        };

                        db.MovieList.InsertGenres(genres);
                    }
                    MovieModel EditMovie = new MovieModel()
                    {
                        MovieName = txtMovieName.Text,
                        DirectorName = txtDirectorName.Text,
                        DateProduction = Convert.ToInt32(txtProductionDateMovie.Text),
                        MovieID = MovieId,
                    };

                    db.MovieList.UpDateMovie(EditMovie);
                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
            else
            {
                if (IsValid())
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var year = txtProductionDateMovie.Text;

                        MovieModel movie = new MovieModel()
                        {
                            MovieName = txtMovieName.Text,
                            DirectorName = txtDirectorName.Text,
                            DateProduction = Convert.ToInt32(txtProductionDateMovie.Text)
                        };
                        foreach (var ListBoxItem in checkedListGenresBySelectMovie.CheckedItems)
                        {
                            var id = Convert.ToInt32((checkedListGenresBySelectMovie.Items.IndexOf(ListBoxItem)).ToString());

                            GenresToMovie genre = new GenresToMovie()
                            {
                                GenresId = id,
                            };
                            db.MovieList.InsertGenres(genre);
                        }
                        db.MovieList.InsertMovie(movie);
                        db.Save();
                    }
                    DialogResult = DialogResult.OK;
                }
            }
        }
        private bool IsValid()
        {
            if (txtMovieName.Text == "")
            {
                MessageBox.Show("لطفا نام فیلم را وارد کنید");
                return false;
            }

            if (txtDirectorName.Text == "")
            {
                MessageBox.Show("لطفا نام کارگردان فیلم را وارد کنید");
                return false;
            }
            if (checkedListGenresBySelectMovie.Text == "")
            {
                MessageBox.Show("لطفا ژانر یا ژانر های  فیلم را وارد کنید");
                return false;
            }
            return true;
        }

        private void frmAddOrEditMovie_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<GetNameGenresViewModel> list = new List<GetNameGenresViewModel>();
                list.Add(new GetNameGenresViewModel()
                {
                    GenresId = 0,
                    GenresName = "انتخاب کنید"
                });
                list.AddRange(db.MovieList.GetNameGenres());
                checkedListGenresBySelectMovie.DataSource = list;
                checkedListGenresBySelectMovie.DisplayMember = "GenresName";
                checkedListGenresBySelectMovie.ValueMember = "GenresId";

            }
            if (MovieId != 0)
            {
                this.Text = "ویرایش فیلم";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var idexGenres = db.MovieList.GetAllGenresByMovieId(MovieId);
                    foreach (var item in idexGenres)
                    {
                        checkedListGenresBySelectMovie.SetItemChecked(item, true);
                    }
                    var movie = db.MovieList.FindById(MovieId);
                    txtDirectorName.Text = movie.DirectorName;
                    txtMovieName.Text = movie.MovieName;
                    txtProductionDateMovie.Text = movie.DateProduction.ToString();
                }
            }


        }


    }
}
