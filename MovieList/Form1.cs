using Movie.DataLayer;
using Movie.DataLayer.Data;
using Movie.DataLayer.ExtentionMethodHelper;
using Movie.DataLayer.Methods;
using Movie.DataLayer.Repositories;
using Movie.ViewModel.ViewModel;
using System;
using System.Collections;
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
        List<RateMovieViewModel> result = new List<RateMovieViewModel>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
            using (UnitOfWork db = new UnitOfWork())
            {
                List<GetNameGenresViewModel> list = new List<GetNameGenresViewModel>();
                list.Add(new GetNameGenresViewModel()
                {
                    GenresId = 0,
                    GenresName = "انتخاب کنید"
                });
                list.AddRange(db.MovieList.GetNameGenres());
                checkedListGenresForFilter.DataSource = list;
                checkedListGenresForFilter.DisplayMember = "GenresName";
                checkedListGenresForFilter.ValueMember = "GenresId";

                foreach (var item in DataGridViewPages.PagesNumber())
                {
                    cmbSelectPage.Items.Add(item);
                }
                foreach (var item in DataGridViewPages.PageResult())
                {
                    cmbSelectResultShow.Items.Add(item);
                }
            }


        }

        private void dgvListMovie_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmComments frm = new frmComments();
            var MoviId = Convert.ToInt32(dgvListMovie.CurrentRow.Cells[0].Value.ToString());
            frm.MovieId = MoviId;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
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
                BindGrid();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }
        private void Filter()
        {
            result.Clear();
            int fromDateInputFromUser = 1;
            double rateInputFromUser = 0;
            int toDateInputFromUser = 10000;
            string directorName = null;
            string movieName = null;
            if (txtFilterByRate.Text != "")
            {

                rateInputFromUser = Convert.ToDouble(txtFilterByRate.Text);
            }
            if (fromDate.Text != "")
            {

                fromDateInputFromUser = Convert.ToInt32(fromDate.Text);
            }
            if (toDate.Text != "")
            {
                toDateInputFromUser = Convert.ToInt32(toDate.Text);

            }
            if (txtDirectorNameForFilter.Text != "")
            {
                directorName = txtDirectorNameForFilter.Text;
            }
            if (txtFilterByName.Text != "")
            {
                movieName = txtFilterByName.Text;
            }

            int idCheckeItem = 0;

            using (UnitOfWork db = new UnitOfWork())
            {

                foreach (var iditemchecked in checkedListGenresForFilter.CheckedItems)
                {
                    idCheckeItem = Convert.ToInt32(checkedListGenresForFilter.Items.IndexOf(iditemchecked).ToString());
                    result.AddRange(db.MovieList.FilterAndSortAndPaging
                     (1, 1000, movieName, directorName, fromDateInputFromUser, toDateInputFromUser, idCheckeItem, false, false, false, rateInputFromUser));
                }

                result = db.MovieList.FilterAndSortAndPaging
                  (1, 1000, movieName, directorName, fromDateInputFromUser, toDateInputFromUser, idCheckeItem, false, false, false, rateInputFromUser);
                if (cbSortByAverageRate.Checked)
                {
                    result = db.MovieList.FilterAndSortAndPaging
                 (1, 1000, movieName, directorName, fromDateInputFromUser, toDateInputFromUser, idCheckeItem, false, true, false, rateInputFromUser);
                }
                if (cbSortByDateProduction.Checked)
                {
                    result = db.MovieList.FilterAndSortAndPaging
                 (1, 1000, movieName, directorName, fromDateInputFromUser, toDateInputFromUser, idCheckeItem, true, false, false, rateInputFromUser);
                }
                if (cbSortByAverageRate.Checked && cbSortDescending.Checked)
                {
                    result = db.MovieList.FilterAndSortAndPaging
                (1, 1000, movieName, directorName, fromDateInputFromUser, toDateInputFromUser, idCheckeItem, false, true, true, rateInputFromUser);
                }
                if (cbSortByDateProduction.Checked && cbSortDescending.Checked)
                {
                    result = db.MovieList.FilterAndSortAndPaging
                 (1, 1000, movieName, directorName, fromDateInputFromUser, toDateInputFromUser, idCheckeItem, true, false, true, rateInputFromUser);
                }



                result = result.Distinct(new EqualityComparer()).ToList();
                dgvListMovie.DataSource = result;



            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            txtFilterByName.Text = "";
            txtFilterByRate.Text = "";
            fromDate.Text = "";
            toDate.Text = "";
        }

        private void listAllMovie_Click(object sender, EventArgs e)
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                dgvListMovie.AutoGenerateColumns = false;
                dgvListMovie.DataSource = db.MovieList.FilterAndSortAndPaging
                    ();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListMovie.CurrentRow == null)
            {
                MessageBox.Show("لطفا سطری را انتخاب کنید");
                return;
            }
            var MoviId = Convert.ToInt32(dgvListMovie.CurrentRow.Cells[0].Value.ToString());
            using (UnitOfWork db = new UnitOfWork())
            {
                string name = dgvListMovie.CurrentRow.Cells[1].Value.ToString();
                if (MessageBox.Show($"آیا از حذف فیلم {name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.MovieList.DeleteMovie(MoviId);
                    db.Save();
                }

            }
            BindGrid();
        }

        public void BindGrid()
        {

            int sizePage = Convert.ToInt32(cmbSelectResultShow.SelectedItem);
            int pageNumber = Convert.ToInt32(cmbSelectPage.SelectedItem);
            sizePage = DataGridViewPages.ResultController(sizePage);
            pageNumber = DataGridViewPages.PageNumberController(pageNumber);
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvListMovie.AutoGenerateColumns = false;
                dgvListMovie.DataSource = db.MovieList.FilterAndSortAndPaging
                    (pageNumber, sizePage);
            }
        }

        private void btnAddMovieToList_Click(object sender, EventArgs e)
        {
            frmAddOrEditMovie frm = new frmAddOrEditMovie();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void txtShowResultInPages_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

    }
}
