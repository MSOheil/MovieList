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
    public partial class frmComments : Form
    {
        public int MovieId = 0;
        public frmComments()
        {
            InitializeComponent();
        }

        private void frmComments_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                dgvComment.AutoGenerateColumns = false;
                dgvComment.DataSource = db.MovieList.getAllComment(MovieId);
            }
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            frmAddComment frm = new frmAddComment();
            frm.IdMovie = MovieId;
            frm.ShowDialog();
        }
    }
}
