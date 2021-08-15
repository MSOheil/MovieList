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
    public partial class frmComments : Form
    {
        public int MovieId = 0;

        public frmComments()
        {
            InitializeComponent();
        }

        private void frmComments_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            frmAddComment frm = new frmAddComment();
            frm.IdMovie = MovieId;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
            DialogResult = DialogResult.OK;
        }
        private void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvComment.AutoGenerateColumns = false;
                dgvComment.DataSource = db.MovieList.GetAllComment(MovieId);
                var comm = db.MovieList.GetAllComment(MovieId);
                if (comm.Count() != 0)
                {
                    var ave = db.MovieList.GetAverageRateMovie(MovieId);
                    txtMovieRate.Text = Convert.ToString(Math.Round(ave, 2));
                    RateMovieViewModel rate = new RateMovieViewModel();
                    rate.MovieAverageRateByRateUsers = Convert.ToDouble(Math.Round(ave, 2));
                }
            }
        }
    }
}
