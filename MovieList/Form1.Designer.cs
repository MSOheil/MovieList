
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
            this.listAllMovie = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterByGeneres = new System.Windows.Forms.TextBox();
            this.txtFilterByName = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.toDate = new System.Windows.Forms.MaskedTextBox();
            this.fromDate = new System.Windows.Forms.MaskedTextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListMovie = new System.Windows.Forms.DataGridView();
            this.MovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateProduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageRat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxRat = new System.Windows.Forms.CheckBox();
            this.checkboxProduction = new System.Windows.Forms.CheckBox();
            this.sortByCheckBox = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortByCheckBox);
            this.groupBox1.Controls.Add(this.checkboxProduction);
            this.groupBox1.Controls.Add(this.checkBoxRat);
            this.groupBox1.Controls.Add(this.listAllMovie);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFilterByGeneres);
            this.groupBox1.Controls.Add(this.txtFilterByName);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.toDate);
            this.groupBox1.Controls.Add(this.fromDate);
            this.groupBox1.Controls.Add(this.btnAddMovie);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مدیریت فیلم";
            // 
            // listAllMovie
            // 
            this.listAllMovie.Location = new System.Drawing.Point(6, 53);
            this.listAllMovie.Name = "listAllMovie";
            this.listAllMovie.Size = new System.Drawing.Size(93, 23);
            this.listAllMovie.TabIndex = 13;
            this.listAllMovie.Text = "لیست فیلم ها";
            this.listAllMovie.UseVisualStyleBackColor = true;
            this.listAllMovie.Click += new System.EventHandler(this.listAllMovie_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(6, 82);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "پاک کردن فیلتر";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "میانگین امتیاز : ";
            // 
            // txtRat
            // 
            this.txtRat.Location = new System.Drawing.Point(207, 89);
            this.txtRat.Name = "txtRat";
            this.txtRat.Size = new System.Drawing.Size(100, 20);
            this.txtRat.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(821, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "تا تاریخ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(982, 92);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(49, 13);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "از تاریخ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "نام فیلم :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام ژانر :";
            // 
            // txtFilterByGeneres
            // 
            this.txtFilterByGeneres.Location = new System.Drawing.Point(398, 91);
            this.txtFilterByGeneres.Name = "txtFilterByGeneres";
            this.txtFilterByGeneres.Size = new System.Drawing.Size(100, 20);
            this.txtFilterByGeneres.TabIndex = 5;
            // 
            // txtFilterByName
            // 
            this.txtFilterByName.Location = new System.Drawing.Point(556, 91);
            this.txtFilterByName.Name = "txtFilterByName";
            this.txtFilterByName.Size = new System.Drawing.Size(100, 20);
            this.txtFilterByName.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(105, 82);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "فیلتر";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(715, 91);
            this.toDate.Mask = "0000/00/00";
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(100, 20);
            this.toDate.TabIndex = 2;
            this.toDate.ValidatingType = typeof(System.DateTime);
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(876, 89);
            this.fromDate.Mask = "0000/00/00";
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(100, 20);
            this.fromDate.TabIndex = 1;
            this.fromDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(956, 19);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(75, 23);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "افزودن فیلم جدید";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListMovie);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 383);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست فیلم ها";
            // 
            // dgvListMovie
            // 
            this.dgvListMovie.AllowUserToAddRows = false;
            this.dgvListMovie.AllowUserToDeleteRows = false;
            this.dgvListMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieId,
            this.CommentModel,
            this.MovieName,
            this.DirectorName,
            this.DateProduction,
            this.AverageRat,
            this.Generes});
            this.dgvListMovie.Location = new System.Drawing.Point(6, 19);
            this.dgvListMovie.Name = "dgvListMovie";
            this.dgvListMovie.ReadOnly = true;
            this.dgvListMovie.Size = new System.Drawing.Size(1025, 358);
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
            // CommentModel
            // 
            this.CommentModel.DataPropertyName = "CommentModel";
            this.CommentModel.HeaderText = "کامنت ها";
            this.CommentModel.Name = "CommentModel";
            this.CommentModel.ReadOnly = true;
            this.CommentModel.Visible = false;
            // 
            // MovieName
            // 
            this.MovieName.DataPropertyName = "MovieName";
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
            this.DateProduction.DataPropertyName = "DateProduction";
            this.DateProduction.HeaderText = "تاریخ تولید";
            this.DateProduction.Name = "DateProduction";
            this.DateProduction.ReadOnly = true;
            // 
            // AverageRat
            // 
            this.AverageRat.DataPropertyName = "AverageRat";
            this.AverageRat.HeaderText = "میانگین امتیاز";
            this.AverageRat.Name = "AverageRat";
            this.AverageRat.ReadOnly = true;
            // 
            // Generes
            // 
            this.Generes.DataPropertyName = "Generes";
            this.Generes.HeaderText = "ژانر";
            this.Generes.Name = "Generes";
            this.Generes.ReadOnly = true;
            // 
            // checkBoxRat
            // 
            this.checkBoxRat.AutoSize = true;
            this.checkBoxRat.Location = new System.Drawing.Point(207, 59);
            this.checkBoxRat.Name = "checkBoxRat";
            this.checkBoxRat.Size = new System.Drawing.Size(51, 17);
            this.checkBoxRat.TabIndex = 14;
            this.checkBoxRat.Text = "امتیاز";
            this.checkBoxRat.UseVisualStyleBackColor = true;
            // 
            // checkboxProduction
            // 
            this.checkboxProduction.AutoSize = true;
            this.checkboxProduction.Location = new System.Drawing.Point(398, 59);
            this.checkboxProduction.Name = "checkboxProduction";
            this.checkboxProduction.Size = new System.Drawing.Size(76, 17);
            this.checkboxProduction.TabIndex = 15;
            this.checkboxProduction.Text = "تاریخ تولید";
            this.checkboxProduction.UseVisualStyleBackColor = true;
            // 
            // sortByCheckBox
            // 
            this.sortByCheckBox.Location = new System.Drawing.Point(106, 53);
            this.sortByCheckBox.Name = "sortByCheckBox";
            this.sortByCheckBox.Size = new System.Drawing.Size(75, 23);
            this.sortByCheckBox.TabIndex = 16;
            this.sortByCheckBox.Text = "مرتب سازی";
            this.sortByCheckBox.UseVisualStyleBackColor = true;
            this.sortByCheckBox.Click += new System.EventHandler(this.sortByCheckBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت فیلم های من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.MaskedTextBox toDate;
        private System.Windows.Forms.MaskedTextBox fromDate;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.DataGridView dgvListMovie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterByGeneres;
        private System.Windows.Forms.TextBox txtFilterByName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageRat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Generes;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button listAllMovie;
        private System.Windows.Forms.Button sortByCheckBox;
        private System.Windows.Forms.CheckBox checkboxProduction;
        private System.Windows.Forms.CheckBox checkBoxRat;
    }
}

