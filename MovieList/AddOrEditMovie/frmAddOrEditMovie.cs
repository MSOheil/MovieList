using Movie.DataLayer;
using Movie.DataLayer.Data;
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

                MovieModel EditMovie = new MovieModel()
                {
                    MovieName = txtMovieName.Text,
                    DirectorName = txtDirectorName.Text,
                    Generes = txtGenresName.Text,
                    DateProduction = Convert.ToDateTime(txtProductionDateMovie.Text),
                    AverageRat = int.Parse(txtRatMovie.Text),
                    MovieID = MovieId
                };
                using (UnitOfWork db = new UnitOfWork())
                {

                    db.MovieList.upDateMovie(EditMovie);
                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
            else
            {

                if (IsValid())
                {
                    MovieModel movie = new MovieModel()
                    {
                        MovieName = txtMovieName.Text,
                        DirectorName = txtDirectorName.Text,
                        Generes = txtGenresName.Text,
                        DateProduction = Convert.ToDateTime(txtProductionDateMovie.Text),
                        AverageRat = Convert.ToDouble(txtRatMovie.Text)
                    };
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.MovieList.insertMovie(movie);
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
            if (txtGenresName.Text == "")
            {
                MessageBox.Show("لطفا نام ژانر فیلم  را وارد کنید");
                return false;
            }
            if (txtDirectorName.Text == "")
            {
                MessageBox.Show("لطفا نام کارگردان فیلم را وارد کنید");
                return false;
            }
            if (txtRatMovie.Text == "")
            {
                MessageBox.Show("لطفا نام میانگین فیلم  را وارد کنید");
                return false;
            }
            return true;
        }

        private void frmAddOrEditMovie_Load(object sender, EventArgs e)
        {
            if (MovieId != 0)
            {
                this.Text = "ویرایش فیلم";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var movie = db.MovieList.findById(MovieId);
                    txtDirectorName.Text = movie.DirectorName;
                    txtGenresName.Text = movie.Generes;
                    txtMovieName.Text = movie.MovieName;
                    txtProductionDateMovie.Text = movie.DateProduction.ToString("yyyy/dd/MM");
                    txtRatMovie.Text = Convert.ToString(movie.AverageRat);
                }
            }
        }

    }
}
