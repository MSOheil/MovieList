
namespace MovieList
{
    partial class frmAddComment
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbllllll = new System.Windows.Forms.Label();
            this.txtUserRat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.addCommentByUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(12, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(280, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام خود را وارد کنید :";
            // 
            // lbllllll
            // 
            this.lbllllll.AutoSize = true;
            this.lbllllll.Location = new System.Drawing.Point(294, 44);
            this.lbllllll.Name = "lbllllll";
            this.lbllllll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbllllll.Size = new System.Drawing.Size(144, 13);
            this.lbllllll.TabIndex = 3;
            this.lbllllll.Text = "امتیاز خود را وارد کنید(1تا10):";
            // 
            // txtUserRat
            // 
            this.txtUserRat.Location = new System.Drawing.Point(12, 41);
            this.txtUserRat.Name = "txtUserRat";
            this.txtUserRat.Size = new System.Drawing.Size(280, 20);
            this.txtUserRat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 73);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "کامنت خود را وارد کنید:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(12, 70);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(280, 190);
            this.txtComment.TabIndex = 5;
            // 
            // addCommentByUser
            // 
            this.addCommentByUser.Location = new System.Drawing.Point(299, 236);
            this.addCommentByUser.Name = "addCommentByUser";
            this.addCommentByUser.Size = new System.Drawing.Size(149, 23);
            this.addCommentByUser.TabIndex = 6;
            this.addCommentByUser.Text = "ثبت کامنت";
            this.addCommentByUser.UseVisualStyleBackColor = true;
            this.addCommentByUser.Click += new System.EventHandler(this.addCommentByUser_Click);
            // 
            // frmAddComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 272);
            this.Controls.Add(this.addCommentByUser);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbllllll);
            this.Controls.Add(this.txtUserRat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Name = "frmAddComment";
            this.Text = "frmAddComment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbllllll;
        private System.Windows.Forms.TextBox txtUserRat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button addCommentByUser;
    }
}