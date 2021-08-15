
namespace MovieList
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtDirectorNameForFilter = new System.Windows.Forms.TextBox();
            this.btnAddMovieToList = new System.Windows.Forms.Button();
            this.checkedListGenresForFilter = new System.Windows.Forms.CheckedListBox();
            this.checkBoxAscending = new System.Windows.Forms.CheckBox();
            this.checkBoxDecending = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.sortByCheckBox = new System.Windows.Forms.Button();
            this.checkboxProduction = new System.Windows.Forms.CheckBox();
            this.checkBoxRat = new System.Windows.Forms.CheckBox();
            this.listAllMovie = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilterByRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterByName = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.toDate = new System.Windows.Forms.MaskedTextBox();
            this.fromDate = new System.Windows.Forms.MaskedTextBox();
            this.btnEditMovieFromList = new System.Windows.Forms.Button();
            this.txtShowResultInPages = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSelectResultShow = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSelectPage = new System.Windows.Forms.ComboBox();
            this.dgvListMovie = new System.Windows.Forms.DataGridView();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateProduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageRateMovie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDirectorNameForFilter);
            this.groupBox1.Controls.Add(this.btnAddMovieToList);
            this.groupBox1.Controls.Add(this.checkedListGenresForFilter);
            this.groupBox1.Controls.Add(this.checkBoxAscending);
            this.groupBox1.Controls.Add(this.checkBoxDecending);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.sortByCheckBox);
            this.groupBox1.Controls.Add(this.checkboxProduction);
            this.groupBox1.Controls.Add(this.checkBoxRat);
            this.groupBox1.Controls.Add(this.listAllMovie);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFilterByRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFilterByName);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.toDate);
            this.groupBox1.Controls.Add(this.fromDate);
            this.groupBox1.Controls.Add(this.btnEditMovieFromList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مدیریت فیلم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1006, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "نام کارگردان :";
            // 
            // txtDirectorNameForFilter
            // 
            this.txtDirectorNameForFilter.Location = new System.Drawing.Point(900, 160);
            this.txtDirectorNameForFilter.Name = "txtDirectorNameForFilter";
            this.txtDirectorNameForFilter.Size = new System.Drawing.Size(100, 20);
            this.txtDirectorNameForFilter.TabIndex = 22;
            // 
            // btnAddMovieToList
            // 
            this.btnAddMovieToList.Location = new System.Drawing.Point(900, 16);
            this.btnAddMovieToList.Name = "btnAddMovieToList";
            this.btnAddMovieToList.Size = new System.Drawing.Size(152, 23);
            this.btnAddMovieToList.TabIndex = 21;
            this.btnAddMovieToList.Text = "افزودن فیلم";
            this.btnAddMovieToList.UseVisualStyleBackColor = true;
            this.btnAddMovieToList.Click += new System.EventHandler(this.btnAddMovieToList_Click);
            // 
            // checkedListGenresForFilter
            // 
            this.checkedListGenresForFilter.FormattingEnabled = true;
            this.checkedListGenresForFilter.Location = new System.Drawing.Point(179, 186);
            this.checkedListGenresForFilter.Name = "checkedListGenresForFilter";
            this.checkedListGenresForFilter.Size = new System.Drawing.Size(152, 19);
            this.checkedListGenresForFilter.TabIndex = 20;
            // 
            // checkBoxAscending
            // 
            this.checkBoxAscending.AutoSize = true;
            this.checkBoxAscending.Location = new System.Drawing.Point(390, 39);
            this.checkBoxAscending.Name = "checkBoxAscending";
            this.checkBoxAscending.Size = new System.Drawing.Size(118, 17);
            this.checkBoxAscending.TabIndex = 19;
            this.checkBoxAscending.Text = "مرتب سازی صعودی";
            this.checkBoxAscending.UseVisualStyleBackColor = true;
            // 
            // checkBoxDecending
            // 
            this.checkBoxDecending.AutoSize = true;
            this.checkBoxDecending.Location = new System.Drawing.Point(127, 16);
            this.checkBoxDecending.Name = "checkBoxDecending";
            this.checkBoxDecending.Size = new System.Drawing.Size(110, 17);
            this.checkBoxDecending.TabIndex = 18;
            this.checkBoxDecending.Text = "مرتب سازی نزولی";
            this.checkBoxDecending.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(542, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "حذف فیلم";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // sortByCheckBox
            // 
            this.sortByCheckBox.Location = new System.Drawing.Point(6, 12);
            this.sortByCheckBox.Name = "sortByCheckBox";
            this.sortByCheckBox.Size = new System.Drawing.Size(76, 23);
            this.sortByCheckBox.TabIndex = 16;
            this.sortByCheckBox.Text = "مرتب سازی";
            this.sortByCheckBox.UseVisualStyleBackColor = true;
            this.sortByCheckBox.Click += new System.EventHandler(this.sortByCheckBox_Click);
            // 
            // checkboxProduction
            // 
            this.checkboxProduction.AutoSize = true;
            this.checkboxProduction.Location = new System.Drawing.Point(243, 16);
            this.checkboxProduction.Name = "checkboxProduction";
            this.checkboxProduction.Size = new System.Drawing.Size(141, 17);
            this.checkboxProduction.TabIndex = 15;
            this.checkboxProduction.Text = "مرتب بر اساس تاریخ تولید";
            this.checkboxProduction.UseVisualStyleBackColor = true;
            // 
            // checkBoxRat
            // 
            this.checkBoxRat.AutoSize = true;
            this.checkBoxRat.Location = new System.Drawing.Point(390, 16);
            this.checkBoxRat.Name = "checkBoxRat";
            this.checkBoxRat.Size = new System.Drawing.Size(119, 17);
            this.checkBoxRat.TabIndex = 14;
            this.checkBoxRat.Text = "مرتب برا اساس امتیاز";
            this.checkBoxRat.UseVisualStyleBackColor = true;
            // 
            // listAllMovie
            // 
            this.listAllMovie.Location = new System.Drawing.Point(642, 16);
            this.listAllMovie.Name = "listAllMovie";
            this.listAllMovie.Size = new System.Drawing.Size(94, 23);
            this.listAllMovie.TabIndex = 13;
            this.listAllMovie.Text = "لیست فیلم ها";
            this.listAllMovie.UseVisualStyleBackColor = true;
            this.listAllMovie.Click += new System.EventHandler(this.listAllMovie_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 182);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "پاک کردن فیلتر";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "میانگین امتیاز : ";
            // 
            // txtFilterByRate
            // 
            this.txtFilterByRate.Location = new System.Drawing.Point(389, 187);
            this.txtFilterByRate.Name = "txtFilterByRate";
            this.txtFilterByRate.Size = new System.Drawing.Size(100, 20);
            this.txtFilterByRate.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(845, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "تا تاریخ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(1006, 190);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(49, 13);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "از تاریخ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "نام فیلم :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام ژانر :";
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Location = new System.Drawing.Point(580, 186);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(100, 20);
            this.txtFilterByName.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(97, 182);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(76, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "فیلتر";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(739, 187);
            this.toDate.Mask = "0000";
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(100, 20);
            this.toDate.TabIndex = 2;
            this.toDate.ValidatingType = typeof(System.DateTime);
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(900, 186);
            this.fromDate.Mask = "0000";
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(100, 20);
            this.fromDate.TabIndex = 1;
            this.fromDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnEditMovieFromList
            // 
            this.btnEditMovieFromList.Location = new System.Drawing.Point(742, 16);
            this.btnEditMovieFromList.Name = "btnEditMovieFromList";
            this.btnEditMovieFromList.Size = new System.Drawing.Size(152, 23);
            this.btnEditMovieFromList.TabIndex = 0;
            this.btnEditMovieFromList.Text = "ویرایش فیلم";
            this.btnEditMovieFromList.UseVisualStyleBackColor = true;
            this.btnEditMovieFromList.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtShowResultInPages
            // 
            this.txtShowResultInPages.Location = new System.Drawing.Point(6, 11);
            this.txtShowResultInPages.Name = "txtShowResultInPages";
            this.txtShowResultInPages.Size = new System.Drawing.Size(76, 23);
            this.txtShowResultInPages.TabIndex = 24;
            this.txtShowResultInPages.Text = "نمایش";
            this.txtShowResultInPages.UseVisualStyleBackColor = true;
            this.txtShowResultInPages.Click += new System.EventHandler(this.txtShowResultInPages_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtShowResultInPages);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbSelectResultShow);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbSelectPage);
            this.groupBox2.Controls.Add(this.dgvListMovie);
            this.groupBox2.Location = new System.Drawing.Point(12, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1081, 312);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست فیلم ها";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "تعداد نمایش :";
            // 
            // cmbSelectResultShow
            // 
            this.cmbSelectResultShow.FormattingEnabled = true;
            this.cmbSelectResultShow.Location = new System.Drawing.Point(389, 12);
            this.cmbSelectResultShow.Name = "cmbSelectResultShow";
            this.cmbSelectResultShow.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectResultShow.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "صفحه مورد نظر را انتخاب کنید :";
            // 
            // cmbSelectPage
            // 
            this.cmbSelectPage.FormattingEnabled = true;
            this.cmbSelectPage.Location = new System.Drawing.Point(96, 12);
            this.cmbSelectPage.Name = "cmbSelectPage";
            this.cmbSelectPage.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectPage.TabIndex = 1;
            // 
            // dgvListMovie
            // 
            this.dgvListMovie.AllowUserToAddRows = false;
            this.dgvListMovie.AllowUserToDeleteRows = false;
            this.dgvListMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieId,
            this.MovieName,
            this.DirectorName,
            this.DateProduction,
            this.AverageRateMovie,
            this.Generes});
            this.dgvListMovie.Location = new System.Drawing.Point(0, 39);
            this.dgvListMovie.Name = "dgvListMovie";
            this.dgvListMovie.ReadOnly = true;
            this.dgvListMovie.Size = new System.Drawing.Size(1075, 267);
            this.dgvListMovie.TabIndex = 0;
            this.dgvListMovie.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListMovie_CellMouseDoubleClick);
            // 
            // MovieId
            // 
            this.MovieId.DataPropertyName = "MovieID";
            this.MovieId.HeaderText = "ایدی";
            this.MovieId.Name = "MovieId";
            this.MovieId.ReadOnly = true;
            this.MovieId.Visible = false;
            // 
            // MovieName
            // 
            this.MovieName.DataPropertyName = "MovieNamee";
            this.MovieName.HeaderText = "نام فیلم ";
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            // 
            // DirectorName
            // 
            this.DirectorName.DataPropertyName = "DirectorName";
            this.DirectorName.HeaderText = "نام کارگردان";
            this.DirectorName.Name = "DirectorName";
            this.DirectorName.ReadOnly = true;
            // 
            // DateProduction
            // 
            this.DateProduction.DataPropertyName = "ProductionDate";
            this.DateProduction.HeaderText = "تاریخ تولید";
            this.DateProduction.Name = "DateProduction";
            this.DateProduction.ReadOnly = true;
            // 
            // AverageRateMovie
            // 
            this.AverageRateMovie.DataPropertyName = "MovieAverageRateByRateUsers";
            this.AverageRateMovie.HeaderText = "میانگین امتیاز فیلم";
            this.AverageRateMovie.Name = "AverageRateMovie";
            this.AverageRateMovie.ReadOnly = true;
            // 
            // Generes
            // 
            this.Generes.DataPropertyName = "GenresNamee";
            this.Generes.HeaderText = "ژانر";
            this.Generes.Name = "Generes";
            this.Generes.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت فیلم های من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.MaskedTextBox toDate;
        private System.Windows.Forms.MaskedTextBox fromDate;
        private System.Windows.Forms.Button btnEditMovieFromList;
        private System.Windows.Forms.DataGridView dgvListMovie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterByName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilterByRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button listAllMovie;
        private System.Windows.Forms.Button sortByCheckBox;
        private System.Windows.Forms.CheckBox checkboxProduction;
        private System.Windows.Forms.CheckBox checkBoxRat;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox checkBoxAscending;
        private System.Windows.Forms.CheckBox checkBoxDecending;
        private System.Windows.Forms.CheckedListBox checkedListGenresForFilter;
        private System.Windows.Forms.Button btnAddMovieToList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageRateMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Generes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSelectPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDirectorNameForFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSelectResultShow;
        private System.Windows.Forms.Button txtShowResultInPages;
    }
}

