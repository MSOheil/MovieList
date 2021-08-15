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
    public partial class frmAddComment : Form
    {
        public int IdMovie = 0;
        public frmAddComment()
        {
            InitializeComponent();
        }

        private void addCommentByUser_Click(object sender, EventArgs e)
        {
            if (isValidComment())
            {
                CommentModel comment = new CommentModel()
                {
                    CommentRat = Convert.ToDouble(txtUserRat.Text),
                    CommentName = txtUserName.Text,
                    CommentDescription = txtComment.Text,
                    MovieId = IdMovie
                };
                using (UnitOfWork db = new UnitOfWork())
                {
                    db.MovieList.InsertComment(comment);
                    db.Save();
                    DialogResult = DialogResult.OK;
                }

            }
        }
        private bool isValidComment()
        {
            if (txtComment.Text == "")
            {
                MessageBox.Show("لطفا نظر خود را وارد کنید");
                return false;
            }
            if (txtUserName.Text == "")
            {
                MessageBox.Show("لطفا نام خود را وارد کنید");
                return false;
            }
            if (txtUserRat.Text == "")
            {
                MessageBox.Show("لطفا امتیازی که به فیلم میدهید  را وارد کنید");
                return false;
            }
            return true;
        }
    }
}
