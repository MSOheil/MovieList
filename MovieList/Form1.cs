using Movie.DataLayer;
using Movie.DataLayer.Data;
using Movie.DataLayer.Repositories;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindGrid();
        }

        private void dgvListMovie_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmComments frm = new frmComments();
            var MoviId = Convert.ToInt32(dgvListMovie.CurrentRow.Cells[0].Value.ToString());
            frm.MovieId = MoviId;
            frm.ShowDialog();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            frmAddOrEditMovie frm = new frmAddOrEditMovie();
            if (dgvListMovie.CurrentRow != null)
            {
                var MoviId = Convert.ToInt32(dgvListMovie.CurrentRow.Cells[0].Value.ToString());
                frm.MovieId = MoviId;
            }
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                bindGrid();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filter();
        }
        private void filter()
        {
            DateTime? startDate;
            DateTime? endDate;
            using (UnitOfWork db = new UnitOfWork())
            {
                List<MovieModel> result = new List<MovieModel>();
                if (txtFilterByName.Text != "")
                {
                    result = db.MovieList.GetMovieByName(txtFilterByName.Text).ToList();
                }
                if (txtFilterByGeneres.Text != "")
                {
                    result = db.MovieList.GetMovieByGenresName(txtFilterByGeneres.Text).ToList();
                }
                if (fromDate.Text != "    /  /")
                {
                    startDate = Convert.ToDateTime(fromDate.Text);
                    result = db.MovieList.GetAllMoveWithStarttDate(startDate.Value);
                }
                if (toDate.Text != "    /  /")
                {
                    endDate = Convert.ToDateTime(toDate.Text);
                    result = db.MovieList.GetAllMoveWithEndDate(endDate.Value);
                }
                if (txtRat.Text != "")
                {
                    if (Convert.ToInt32(txtRat.Text) <= 5)
                    {
                        result = db.MovieList.GetAllWithLowRat(Convert.ToInt32(txtRat.Text)).ToList();
                    }
                    if (Convert.ToInt32(txtRat.Text) > 5)
                    {
                        result = db.MovieList.GetAllWithUpRat(Convert.ToInt32(txtRat.Text)).ToList();
                    }
                }
                dgvListMovie.DataSource = result;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilterByGeneres.Text = "";
            txtFilterByName.Text = "";
            txtRat.Text = "";
            fromDate.Text = "";
            toDate.Text = "";
        }

        private void listAllMovie_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvListMovie.DataSource = db.MovieList.GetAllMovie();

            }
        }



        private void sortByCheckBox_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                if (checkboxProduction.Checked)
                {
                    dgvListMovie.DataSource = db.MovieList.SortedByProductionDate();
                }
                if (checkBoxRat.Checked)
                {
                    dgvListMovie.DataSource = db.MovieList.SortedByAverageRat();

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var MoviId = Convert.ToInt32(dgvListMovie.CurrentRow.Cells[0].Value.ToString());
            using (UnitOfWork db = new UnitOfWork())
            {
                db.MovieList.DeleteMovie(MoviId);
                db.Save();

            }
            bindGrid();
        }
        public void bindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvListMovie.AutoGenerateColumns = false;
                dgvListMovie.DataSource = db.MovieList.GetAllMovie();
            }
        }
    }
}
