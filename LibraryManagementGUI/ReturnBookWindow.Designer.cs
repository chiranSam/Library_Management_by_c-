namespace LibraryManagementGUI
{
    partial class ReturnBookWindow
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
            this.memberIdTxt = new System.Windows.Forms.TextBox();
            this.memberID_lbl = new System.Windows.Forms.Label();
            this.ViewBorrowBooks_btn = new System.Windows.Forms.Button();
            this.returnBookId_txt = new System.Windows.Forms.TextBox();
            this.returnBookId_lbl = new System.Windows.Forms.Label();
            this.Return_Book = new System.Windows.Forms.Button();
            this.bookView_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookView_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // memberIdTxt
            // 
            this.memberIdTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.memberIdTxt.Location = new System.Drawing.Point(676, 241);
            this.memberIdTxt.Name = "memberIdTxt";
            this.memberIdTxt.Size = new System.Drawing.Size(309, 35);
            this.memberIdTxt.TabIndex = 11;
            this.memberIdTxt.TextChanged += new System.EventHandler(this.memberIdTxt_TextChanged);
            // 
            // memberID_lbl
            // 
            this.memberID_lbl.AutoSize = true;
            this.memberID_lbl.BackColor = System.Drawing.Color.Transparent;
            this.memberID_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberID_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.memberID_lbl.Location = new System.Drawing.Point(670, 191);
            this.memberID_lbl.Name = "memberID_lbl";
            this.memberID_lbl.Size = new System.Drawing.Size(274, 32);
            this.memberID_lbl.TabIndex = 10;
            this.memberID_lbl.Text = "Enter the Member ID";
            this.memberID_lbl.Click += new System.EventHandler(this.bookID_lbl_Click);
            // 
            // ViewBorrowBooks_btn
            // 
            this.ViewBorrowBooks_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ViewBorrowBooks_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewBorrowBooks_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.ViewBorrowBooks_btn.Location = new System.Drawing.Point(676, 312);
            this.ViewBorrowBooks_btn.Name = "ViewBorrowBooks_btn";
            this.ViewBorrowBooks_btn.Size = new System.Drawing.Size(309, 46);
            this.ViewBorrowBooks_btn.TabIndex = 12;
            this.ViewBorrowBooks_btn.Text = "Borrowed Books";
            this.ViewBorrowBooks_btn.UseVisualStyleBackColor = false;
            this.ViewBorrowBooks_btn.Click += new System.EventHandler(this.ViewBorrowBooks_btn_Click);
            // 
            // returnBookId_txt
            // 
            this.returnBookId_txt.Font = new System.Drawing.Font("Arial", 12F);
            this.returnBookId_txt.Location = new System.Drawing.Point(676, 516);
            this.returnBookId_txt.Name = "returnBookId_txt";
            this.returnBookId_txt.Size = new System.Drawing.Size(309, 35);
            this.returnBookId_txt.TabIndex = 14;
            this.returnBookId_txt.TextChanged += new System.EventHandler(this.returnBookId_txt_TextChanged);
            // 
            // returnBookId_lbl
            // 
            this.returnBookId_lbl.AutoSize = true;
            this.returnBookId_lbl.BackColor = System.Drawing.Color.Transparent;
            this.returnBookId_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookId_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.returnBookId_lbl.Location = new System.Drawing.Point(670, 466);
            this.returnBookId_lbl.Name = "returnBookId_lbl";
            this.returnBookId_lbl.Size = new System.Drawing.Size(235, 32);
            this.returnBookId_lbl.TabIndex = 13;
            this.returnBookId_lbl.Text = "Enter the Book ID";
            // 
            // Return_Book
            // 
            this.Return_Book.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Return_Book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return_Book.Font = new System.Drawing.Font("Arial", 12F);
            this.Return_Book.Location = new System.Drawing.Point(676, 600);
            this.Return_Book.Name = "Return_Book";
            this.Return_Book.Size = new System.Drawing.Size(309, 46);
            this.Return_Book.TabIndex = 15;
            this.Return_Book.Text = "Return Book";
            this.Return_Book.UseVisualStyleBackColor = false;
            this.Return_Book.Click += new System.EventHandler(this.Return_Book_Click);
            // 
            // bookView_grid
            // 
            this.bookView_grid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.bookView_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookView_grid.Location = new System.Drawing.Point(12, 143);
            this.bookView_grid.Name = "bookView_grid";
            this.bookView_grid.RowHeadersWidth = 62;
            this.bookView_grid.RowTemplate.Height = 28;
            this.bookView_grid.Size = new System.Drawing.Size(583, 561);
            this.bookView_grid.TabIndex = 16;
            this.bookView_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookView_grid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = "Return Books";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LibraryManagementGUI.Properties.Resources.book_png_image_pngfre_12;
            this.pictureBox2.Location = new System.Drawing.Point(763, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Image = global::LibraryManagementGUI.Properties.Resources._950805;
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(62, 61);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_btn.TabIndex = 19;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ReturnBookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LibraryManagementGUI.Properties.Resources.Photo_abstract_blue_background_with_smooth_lines;
            this.ClientSize = new System.Drawing.Size(1063, 716);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookView_grid);
            this.Controls.Add(this.Return_Book);
            this.Controls.Add(this.returnBookId_txt);
            this.Controls.Add(this.returnBookId_lbl);
            this.Controls.Add(this.ViewBorrowBooks_btn);
            this.Controls.Add(this.memberIdTxt);
            this.Controls.Add(this.memberID_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1085, 772);
            this.MinimumSize = new System.Drawing.Size(1085, 772);
            this.Name = "ReturnBookWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.ReturnBookWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookView_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox memberIdTxt;
        private System.Windows.Forms.Label memberID_lbl;
        private System.Windows.Forms.Button ViewBorrowBooks_btn;
        private System.Windows.Forms.TextBox returnBookId_txt;
        private System.Windows.Forms.Label returnBookId_lbl;
        private System.Windows.Forms.Button Return_Book;
        private System.Windows.Forms.DataGridView bookView_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox back_btn;
    }
}