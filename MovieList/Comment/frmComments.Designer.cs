
namespace MovieList
{
    partial class frmComments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvComment = new System.Windows.Forms.DataGridView();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.lblNameComment = new System.Windows.Forms.Label();
            this.txtMovieRate = new System.Windows.Forms.TextBox();
            this.UserCommentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRatComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentUserDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUserComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMovieRate);
            this.groupBox1.Controls.Add(this.dgvComment);
            this.groupBox1.Controls.Add(this.btnAddComment);
            this.groupBox1.Controls.Add(this.lblNameComment);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 239);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "کامنت ها";
            // 
            // dgvComment
            // 
            this.dgvComment.AllowUserToAddRows = false;
            this.dgvComment.AllowUserToDeleteRows = false;
            this.dgvComment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserCommentName,
            this.UserRatComment,
            this.CommentUserDescription,
            this.IdUserComment});
            this.dgvComment.Location = new System.Drawing.Point(7, 40);
            this.dgvComment.Name = "dgvComment";
            this.dgvComment.ReadOnly = true;
            this.dgvComment.Size = new System.Drawing.Size(893, 193);
            this.dgvComment.TabIndex = 3;
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(7, 11);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(82, 23);
            this.btnAddComment.TabIndex = 2;
            this.btnAddComment.Text = "ثبت کامنت";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // lblNameComment
            // 
            this.lblNameComment.AutoSize = true;
            this.lblNameComment.Location = new System.Drawing.Point(894, 19);
            this.lblNameComment.Name = "lblNameComment";
            this.lblNameComment.Size = new System.Drawing.Size(0, 16);
            this.lblNameComment.TabIndex = 1;
            // 
            // txtMovieRate
            // 
            this.txtMovieRate.Location = new System.Drawing.Point(582, 12);
            this.txtMovieRate.Name = "txtMovieRate";
            this.txtMovieRate.ReadOnly = true;
            this.txtMovieRate.Size = new System.Drawing.Size(100, 23);
            this.txtMovieRate.TabIndex = 4;
            // 
            // UserCommentName
            // 
            this.UserCommentName.DataPropertyName = "UserName";
            this.UserCommentName.HeaderText = "نام کاربر";
            this.UserCommentName.Name = "UserCommentName";
            this.UserCommentName.ReadOnly = true;
            // 
            // UserRatComment
            // 
            this.UserRatComment.DataPropertyName = "CommentRat";
            this.UserRatComment.HeaderText = "امتیاز کاربر";
            this.UserRatComment.Name = "UserRatComment";
            this.UserRatComment.ReadOnly = true;
            // 
            // CommentUserDescription
            // 
            this.CommentUserDescription.DataPropertyName = "CommentUser";
            this.CommentUserDescription.HeaderText = "کامنت";
            this.CommentUserDescription.Name = "CommentUserDescription";
            this.CommentUserDescription.ReadOnly = true;
            // 
            // IdUserComment
            // 
            this.IdUserComment.DataPropertyName = "CommentID";
            this.IdUserComment.HeaderText = "ایدی کاربر";
            this.IdUserComment.Name = "IdUserComment";
            this.IdUserComment.ReadOnly = true;
            this.IdUserComment.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "میانگین امتیاز گرفته شده از کاربران :";
            // 
            // frmComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 263);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmComments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست کامنت ها";
            this.Load += new System.EventHandler(this.frmComments_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.DataGridView dgvComment;
        private System.Windows.Forms.TextBox txtMovieRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserCommentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRatComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentUserDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUserComment;
        private System.Windows.Forms.Label label1;
    }
}