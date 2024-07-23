﻿namespace LibraryManagementGUI
{
    partial class ViewBooks
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
            this.viewBook_Header = new System.Windows.Forms.Label();
            this.bookView_grid = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookView_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // viewBook_Header
            // 
            this.viewBook_Header.AutoSize = true;
            this.viewBook_Header.BackColor = System.Drawing.Color.Transparent;
            this.viewBook_Header.Font = new System.Drawing.Font("Arial", 20F);
            this.viewBook_Header.ForeColor = System.Drawing.Color.Transparent;
            this.viewBook_Header.Location = new System.Drawing.Point(346, 62);
            this.viewBook_Header.Name = "viewBook_Header";
            this.viewBook_Header.Size = new System.Drawing.Size(365, 45);
            this.viewBook_Header.TabIndex = 6;
            this.viewBook_Header.Text = "Books in the Library";
            this.viewBook_Header.Click += new System.EventHandler(this.viewBook_Header_Click);
            // 
            // bookView_grid
            // 
            this.bookView_grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bookView_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookView_grid.Location = new System.Drawing.Point(103, 183);
            this.bookView_grid.Name = "bookView_grid";
            this.bookView_grid.RowHeadersWidth = 62;
            this.bookView_grid.RowTemplate.Height = 28;
            this.bookView_grid.Size = new System.Drawing.Size(862, 436);
            this.bookView_grid.TabIndex = 7;
            this.bookView_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookView_grid_CellContentClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::LibraryManagementGUI.Properties.Resources.book_png_image_pngfre_12;
            this.pictureBox4.Location = new System.Drawing.Point(840, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(125, 139);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
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
            this.back_btn.TabIndex = 21;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // ViewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagementGUI.Properties.Resources.Photo_abstract_blue_background_with_smooth_lines;
            this.ClientSize = new System.Drawing.Size(1063, 716);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bookView_grid);
            this.Controls.Add(this.viewBook_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1085, 772);
            this.MinimumSize = new System.Drawing.Size(1085, 772);
            this.Name = "ViewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.ViewBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookView_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label viewBook_Header;
        private System.Windows.Forms.DataGridView bookView_grid;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox back_btn;
    }
}