namespace LibraryManagementGUI
{
    partial class RemoveBookWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.removeBook_btn = new System.Windows.Forms.Button();
            this.rmvBookIdTxt = new System.Windows.Forms.TextBox();
            this.memberID_lbl = new System.Windows.Forms.Label();
            this.bookView_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookView_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(373, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Remove Books";
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
            // removeBook_btn
            // 
            this.removeBook_btn.BackColor = System.Drawing.SystemColors.Info;
            this.removeBook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBook_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.removeBook_btn.Location = new System.Drawing.Point(601, 484);
            this.removeBook_btn.Name = "removeBook_btn";
            this.removeBook_btn.Size = new System.Drawing.Size(349, 56);
            this.removeBook_btn.TabIndex = 32;
            this.removeBook_btn.Text = "Remove Book";
            this.removeBook_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.removeBook_btn.UseVisualStyleBackColor = false;
            this.removeBook_btn.Click += new System.EventHandler(this.removeBook_btn_Click);
            // 
            // rmvBookIdTxt
            // 
            this.rmvBookIdTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.rmvBookIdTxt.Location = new System.Drawing.Point(601, 356);
            this.rmvBookIdTxt.Name = "rmvBookIdTxt";
            this.rmvBookIdTxt.Size = new System.Drawing.Size(309, 35);
            this.rmvBookIdTxt.TabIndex = 27;
            this.rmvBookIdTxt.TextChanged += new System.EventHandler(this.rmvBookIdTxt_TextChanged);
            // 
            // memberID_lbl
            // 
            this.memberID_lbl.AutoSize = true;
            this.memberID_lbl.BackColor = System.Drawing.Color.Transparent;
            this.memberID_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberID_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.memberID_lbl.Location = new System.Drawing.Point(595, 299);
            this.memberID_lbl.Name = "memberID_lbl";
            this.memberID_lbl.Size = new System.Drawing.Size(243, 32);
            this.memberID_lbl.TabIndex = 26;
            this.memberID_lbl.Text = "Enter the Book ID ";
            // 
            // bookView_grid
            // 
            this.bookView_grid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.bookView_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookView_grid.Location = new System.Drawing.Point(25, 132);
            this.bookView_grid.Name = "bookView_grid";
            this.bookView_grid.RowHeadersWidth = 62;
            this.bookView_grid.RowTemplate.Height = 28;
            this.bookView_grid.Size = new System.Drawing.Size(539, 561);
            this.bookView_grid.TabIndex = 33;
            this.bookView_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookView_grid_CellContentClick);
            // 
            // RemoveBookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagementGUI.Properties.Resources.Photo_abstract_blue_background_with_smooth_lines;
            this.ClientSize = new System.Drawing.Size(1063, 716);
            this.Controls.Add(this.bookView_grid);
            this.Controls.Add(this.removeBook_btn);
            this.Controls.Add(this.rmvBookIdTxt);
            this.Controls.Add(this.memberID_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1085, 772);
            this.MinimumSize = new System.Drawing.Size(1085, 772);
            this.Name = "RemoveBookWindow";
            this.Text = "RemoveBookWindow";
            this.Load += new System.EventHandler(this.RemoveBookWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookView_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.Button removeBook_btn;
        private System.Windows.Forms.TextBox rmvBookIdTxt;
        private System.Windows.Forms.Label memberID_lbl;
        private System.Windows.Forms.DataGridView bookView_grid;
    }
}