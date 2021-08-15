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
            int? startDate;
            int? endDate;
            using (UnitOfWork db = new UnitOfWork())
            {
                if (txtFilterByName.Text != "")
                {
                    result = db.MovieList.GetMovieByName(txtFilterByName.Text).Distinct().ToList();
                }


                if (checkedListGenresForFilter.CheckedItems.Count!= 0)
                {
                    var listMovieByFilterGenres = new List<RateMovieViewModel>();

                    foreach (var iditemchecked in checkedListGenresForFilter.CheckedItems)
                    {
                        var idCheckeItem = checkedListGenresForFilter.Items.IndexOf(iditemchecked).ToString();
                        var id = db.MovieList.FindNameGenresByIdGenres(Convert.ToInt32(idCheckeItem));
                        foreach (var nameGenres in id)
                        {
                            var movieFilterByGenres = FilterByIdGenres(nameGenres);

                            listMovieByFilterGenres.AddRange(movieFilterByGenres);
                        }
                    }
                    result = listMovieByFilterGenres.ToList();
                }
                if (fromDate.Text != "")
                {

                    startDate = Convert.ToInt32(fromDate.Text);
                    var resultMovie = FilterFromDate(startDate.Value);
                    result = resultMovie.ToList();
                }
                if (toDate.Text != "")
                {
                    endDate = Convert.ToInt32(toDate.Text);
                    var resultMovie = FilterToDate(endDate.Value);
                    result = resultMovie.ToList();
                }
                if (txtDirectorNameForFilter.Text != "")
                {
                    var resultMovie = FilterByDirectorName(txtDirectorNameForFilter.Text);
                    result = resultMovie.ToList();
                }
                if (txtFilterByRate.Text != "")
                {
                    var rateInput = Convert.ToInt32(txtFilterByRate.Text);
                    var resultMovie = FilterByRate(rateInput);
                    result = resultMovie.ToList();
                }
                dgvListMovie.DataSource = result.Distinct(new EqualityComparer()).ToList();

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

            int sizePage = Convert.ToInt32(cmbSelectResultShow.SelectedItem);
            int pageNumber = Convert.ToInt32(cmbSelectPage.SelectedItem);
            if (sizePage == 0)
            {
                sizePage += 5;
            }
            if (pageNumber == 1)
            {
                pageNumber -= 1;
            }
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvListMovie.AutoGenerateColumns = false;
                result = DataGridViewPages.ShowResultInPages(pageNumber, sizePage);
                dgvListMovie.DataSource = result;
            }
        }
        private void sortByCheckBox_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                if (checkboxProduction.Checked)
                {
                    if (result.Count == 0)
                    {
                        result = db.MovieList.SortedByProductionDateAscending();
                        dgvListMovie.DataSource = result;

                    }
                    else
                    {
                        result = result.OrderBy(s => s.ProductionDate).ToList();

                    }
                    if (checkBoxAscending.Checked)
                    {
                        result = result.OrderBy(s => s.ProductionDate).ToList();


                    }
                    if (checkBoxDecending.Checked)
                    {

                        result = result.OrderByDescending(s => s.ProductionDate).ToList();

                    }
                }
                if (checkBoxRat.Checked)
                {
                    if (result.Count == 0)
                    {
                        result = db.MovieList.SortedByAverageRateAscending();
                    }
                    else
                    {
                        result = result.OrderBy(s => s.ProductionDate).ToList();
                    }
                    if (checkBoxAscending.Checked)
                    {
                        if (result.Count == 0)
                        {
                            result = db.MovieList.SortedByAverageRateAscending();
                        }
                        else
                        {
                            result = result.OrderBy(s => s.ProductionDate).ToList();
                        }
                    }
                    if (checkBoxDecending.Checked)
                    {

                        if (result.Count == 0)
                        {
                            result = db.MovieList.SortedByAverageRateDescending();
                        }
                        else
                        {
                            result = result.OrderByDescending(s => s.ProductionDate).ToList();
                        }
                    }
                }

                dgvListMovie.DataSource = result;
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
            if (sizePage == 0)
            {
                sizePage += 5;
            }
            if (pageNumber == 1)
            {
                pageNumber -= 1;
            }
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvListMovie.AutoGenerateColumns = false;
                result = DataGridViewPages.ShowResultInPages(pageNumber, sizePage);
                dgvListMovie.DataSource = result;
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
        private List<RateMovieViewModel> FilterByIdGenres(string nameGenresForFilter)
        {


            var movie = result.Where(sd => sd.GenresNamee.Contains(nameGenresForFilter))
                .Select(s => new RateMovieViewModel
                {
                    MovieId = s.MovieId,
                    DirectorName = s.DirectorName,
                    GenresNamee = s.GenresNamee,
                    MovieAverageRateByRateUsers = s.MovieAverageRateByRateUsers,
                    MovieNamee = s.MovieNamee,
                    ProductionDate = s.ProductionDate
                }).ToList();
            return movie.ToList();
        }
        private List<RateMovieViewModel> FilterFromDate(int fromDate)
        {


            var movie = result.Where(sd => sd.ProductionDate >= fromDate)
                .Select(s => new RateMovieViewModel
                {
                    MovieId = s.MovieId,
                    DirectorName = s.DirectorName,
                    GenresNamee = s.GenresNamee,
                    MovieAverageRateByRateUsers = s.MovieAverageRateByRateUsers,
                    MovieNamee = s.MovieNamee,
                    ProductionDate = s.ProductionDate
                }).ToList();
            return movie.ToList();
        }
        private List<RateMovieViewModel> FilterToDate(int fromDate)
        {


            var movie = result.Where(sd => sd.ProductionDate <= fromDate)
                .Select(s => new RateMovieViewModel
                {
                    MovieId = s.MovieId,
                    DirectorName = s.DirectorName,
                    GenresNamee = s.GenresNamee,
                    MovieAverageRateByRateUsers = s.MovieAverageRateByRateUsers,
                    MovieNamee = s.MovieNamee,
                    ProductionDate = s.ProductionDate
                }).ToList();
            return movie.ToList();
        }
        private List<RateMovieViewModel> FilterByDirectorName(string directorName)
        {


            var movie = result.Where(sd => sd.DirectorName == directorName)
                .Select(s => new RateMovieViewModel
                {
                    MovieId = s.MovieId,
                    DirectorName = s.DirectorName,
                    GenresNamee = s.GenresNamee,
                    MovieAverageRateByRateUsers = s.MovieAverageRateByRateUsers,
                    MovieNamee = s.MovieNamee,
                    ProductionDate = s.ProductionDate
                }).ToList();
            return movie.ToList();
        }
        private List<RateMovieViewModel> FilterByRate(int rateInput)
        {


            var movie = result.Where(sd => sd.MovieAverageRateByRateUsers >= rateInput)
                .Select(s => new RateMovieViewModel
                {
                    MovieId = s.MovieId,
                    DirectorName = s.DirectorName,
                    GenresNamee = s.GenresNamee,
                    MovieAverageRateByRateUsers = s.MovieAverageRateByRateUsers,
                    MovieNamee = s.MovieNamee,
                    ProductionDate = s.ProductionDate
                }).ToList();
            return movie.ToList();
        }
    }
}
