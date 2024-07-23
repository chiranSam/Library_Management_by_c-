namespace LibraryManagementGUI
{
    partial class Login_Type_Form
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
            this.member_btn = new System.Windows.Forms.Button();
            this.librarian_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // member_btn
            // 
            this.member_btn.BackColor = System.Drawing.SystemColors.Info;
            this.member_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.member_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_btn.Location = new System.Drawing.Point(121, 281);
            this.member_btn.Name = "member_btn";
            this.member_btn.Size = new System.Drawing.Size(264, 57);
            this.member_btn.TabIndex = 1;
            this.member_btn.Text = "Member Login";
            this.member_btn.UseVisualStyleBackColor = false;
            this.member_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // librarian_btn
            // 
            this.librarian_btn.BackColor = System.Drawing.SystemColors.Info;
            this.librarian_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.librarian_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librarian_btn.Location = new System.Drawing.Point(121, 379);
            this.librarian_btn.Name = "librarian_btn";
            this.librarian_btn.Size = new System.Drawing.Size(264, 57);
            this.librarian_btn.TabIndex = 2;
            this.librarian_btn.Text = "Librarian Login";
            this.librarian_btn.UseVisualStyleBackColor = false;
            this.librarian_btn.Click += new System.EventHandler(this.librarian_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::LibraryManagementGUI.Properties.Resources.book_png_image_pngfre_12;
            this.pictureBox1.Location = new System.Drawing.Point(180, 99);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(145, 150);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(145, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::LibraryManagementGUI.Properties.Resources.k1ANjs_light_book_picture_png;
            this.pictureBox2.Location = new System.Drawing.Point(77, 483);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(364, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Library Management System";
            // 
            // Login_Type_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagementGUI.Properties.Resources.Photo_abstract_blue_background_with_smooth_lines;
            this.ClientSize = new System.Drawing.Size(519, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.librarian_btn);
            this.Controls.Add(this.member_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(541, 689);
            this.MinimumSize = new System.Drawing.Size(541, 689);
            this.Name = "Login_Type_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Type_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button member_btn;
        private System.Windows.Forms.Button librarian_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

