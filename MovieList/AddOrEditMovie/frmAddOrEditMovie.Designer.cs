
namespace MovieList
{
    partial class frmAddOrEditMovie
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
            this.txtProductionDateMovie = new System.Windows.Forms.MaskedTextBox();
            this.btnInsertOrEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRatMovie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGenresName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDirectorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProductionDateMovie);
            this.groupBox1.Controls.Add(this.btnInsertOrEdit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRatMovie);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGenresName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDirectorName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMovieName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtProductionDateMovie
            // 
            this.txtProductionDateMovie.Location = new System.Drawing.Point(6, 95);
            this.txtProductionDateMovie.Mask = "0000/00/00";
            this.txtProductionDateMovie.Name = "txtProductionDateMovie";
            this.txtProductionDateMovie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductionDateMovie.Size = new System.Drawing.Size(406, 20);
            this.txtProductionDateMovie.TabIndex = 11;
            this.txtProductionDateMovie.ValidatingType = typeof(System.DateTime);
            // 
            // btnInsertOrEdit
            // 
            this.btnInsertOrEdit.Location = new System.Drawing.Point(6, 147);
            this.btnInsertOrEdit.Name = "btnInsertOrEdit";
            this.btnInsertOrEdit.Size = new System.Drawing.Size(548, 23);
            this.btnInsertOrEdit.TabIndex = 10;
            this.btnInsertOrEdit.Text = "ثبت اطلاعات";
            this.btnInsertOrEdit.UseVisualStyleBackColor = true;
            this.btnInsertOrEdit.Click += new System.EventHandler(this.btnInsertOrEdit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "میانگین امتیاز گرفته شده :";
            // 
            // txtRatMovie
            // 
            this.txtRatMovie.Location = new System.Drawing.Point(6, 121);
            this.txtRatMovie.Name = "txtRatMovie";
            this.txtRatMovie.Size = new System.Drawing.Size(406, 20);
            this.txtRatMovie.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "تاریخ تولید :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "نام ژانر :";
            // 
            // txtGenresName
            // 
            this.txtGenresName.Location = new System.Drawing.Point(6, 69);
            this.txtGenresName.Name = "txtGenresName";
            this.txtGenresName.Size = new System.Drawing.Size(406, 20);
            this.txtGenresName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام کارگردان :";
            // 
            // txtDirectorName
            // 
            this.txtDirectorName.Location = new System.Drawing.Point(6, 43);
            this.txtDirectorName.Name = "txtDirectorName";
            this.txtDirectorName.Size = new System.Drawing.Size(406, 20);
            this.txtDirectorName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام فیلم :";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(6, 17);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(406, 20);
            this.txtMovieName.TabIndex = 0;
            // 
            // frmAddOrEditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 271);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddOrEditMovie";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "افزودن فیلم";
            this.Load += new System.EventHandler(this.frmAddOrEditMovie_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGenresName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirectorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Button btnInsertOrEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRatMovie;
        private System.Windows.Forms.MaskedTextBox txtProductionDateMovie;
    }
}