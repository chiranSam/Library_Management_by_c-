namespace LibraryManagementGUI
{
    partial class BorrowBook
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bookView_grid = new System.Windows.Forms.DataGridView();
            this.bookID_lbl = new System.Windows.Forms.Label();
            this.bookIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BorrowBook_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookView_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementGUI.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1039, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(379, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Borrow Books";
            // 
            // bookView_grid
            // 
            this.bookView_grid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.bookView_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookView_grid.Location = new System.Drawing.Point(12, 240);
            this.bookView_grid.Name = "bookView_grid";
            this.bookView_grid.RowHeadersWidth = 62;
            this.bookView_grid.RowTemplate.Height = 28;
            this.bookView_grid.Size = new System.Drawing.Size(583, 464);
            this.bookView_grid.TabIndex = 7;
            this.bookView_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookView_grid_CellContentClick);
            // 
            // bookID_lbl
            // 
            this.bookID_lbl.AutoSize = true;
            this.bookID_lbl.BackColor = System.Drawing.Color.Transparent;
            this.bookID_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookID_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.bookID_lbl.Location = new System.Drawing.Point(623, 240);
            this.bookID_lbl.Name = "bookID_lbl";
            this.bookID_lbl.Size = new System.Drawing.Size(232, 32);
            this.bookID_lbl.TabIndex = 8;
            this.bookID_lbl.Text = "Enter the book ID";
            // 
            // bookIdTextBox
            // 
            this.bookIdTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.bookIdTextBox.Location = new System.Drawing.Point(629, 290);
            this.bookIdTextBox.Name = "bookIdTextBox";
            this.bookIdTextBox.Size = new System.Drawing.Size(309, 35);
            this.bookIdTextBox.TabIndex = 9;
            this.bookIdTextBox.TextChanged += new System.EventHandler(this.bookIdTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(588, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 32);
            this.label3.TabIndex = 10;
            // 
            // BorrowBook_btn
            // 
            this.BorrowBook_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BorrowBook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BorrowBook_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.BorrowBook_btn.Location = new System.Drawing.Point(629, 386);
            this.BorrowBook_btn.Name = "BorrowBook_btn";
            this.BorrowBook_btn.Size = new System.Drawing.Size(295, 46);
            this.BorrowBook_btn.TabIndex = 11;
            this.BorrowBook_btn.Text = "Borrow ";
            this.BorrowBook_btn.UseVisualStyleBackColor = false;
            this.BorrowBook_btn.Click += new System.EventHandler(this.BorrowBook_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(161, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Books in the Library";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LibraryManagementGUI.Properties.Resources.book_png_image_pngfre_12;
            this.pictureBox2.Location = new System.Drawing.Point(31, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::LibraryManagementGUI.Properties.Resources.k1ANjs_light_book_picture_png;
            this.pictureBox3.Location = new System.Drawing.Point(610, 561);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(364, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.back_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.back_btn.Location = new System.Drawing.Point(629, 477);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(295, 46);
            this.back_btn.TabIndex = 15;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagementGUI.Properties.Resources.Photo_abstract_blue_background_with_smooth_lines;
            this.ClientSize = new System.Drawing.Size(1063, 716);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BorrowBook_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookIdTextBox);
            this.Controls.Add(this.bookID_lbl);
            this.Controls.Add(this.bookView_grid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1085, 772);
            this.MinimumSize = new System.Drawing.Size(1085, 772);
            this.Name = "BorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Book";
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookView_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bookView_grid;
        private System.Windows.Forms.Label bookID_lbl;
        private System.Windows.Forms.TextBox bookIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BorrowBook_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button back_btn;
    }
}