namespace LibraryManagementGUI
{
    partial class LibrarianWindow
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
            this.lib_view_book_btn = new System.Windows.Forms.Button();
            this.returnBook_btn = new System.Windows.Forms.Button();
            this.addBook_btn = new System.Windows.Forms.Button();
            this.removeBook_btn = new System.Windows.Forms.Button();
            this.addMember_btn = new System.Windows.Forms.Button();
            this.transHistory_btn = new System.Windows.Forms.Button();
            this.lbl_log_user = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.addMemberBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lib_view_book_btn
            // 
            this.lib_view_book_btn.BackColor = System.Drawing.SystemColors.Info;
            this.lib_view_book_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.lib_view_book_btn.Location = new System.Drawing.Point(603, 157);
            this.lib_view_book_btn.Name = "lib_view_book_btn";
            this.lib_view_book_btn.Size = new System.Drawing.Size(302, 53);
            this.lib_view_book_btn.TabIndex = 0;
            this.lib_view_book_btn.Text = "View Books";
            this.lib_view_book_btn.UseVisualStyleBackColor = false;
            this.lib_view_book_btn.Click += new System.EventHandler(this.lib_view_book_btn_Click);
            // 
            // returnBook_btn
            // 
            this.returnBook_btn.BackColor = System.Drawing.SystemColors.Info;
            this.returnBook_btn.Font = new System.Drawing.Font("Arial", 10F);
            this.returnBook_btn.Location = new System.Drawing.Point(603, 247);
            this.returnBook_btn.Name = "returnBook_btn";
            this.returnBook_btn.Size = new System.Drawing.Size(302, 53);
            this.returnBook_btn.TabIndex = 1;
            this.returnBook_btn.Text = "Return Book and Loan Books";
            this.returnBook_btn.UseVisualStyleBackColor = false;
            this.returnBook_btn.Click += new System.EventHandler(this.returnBook_btn_Click);
            // 
            // addBook_btn
            // 
            this.addBook_btn.BackColor = System.Drawing.SystemColors.Info;
            this.addBook_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.addBook_btn.Location = new System.Drawing.Point(603, 339);
            this.addBook_btn.Name = "addBook_btn";
            this.addBook_btn.Size = new System.Drawing.Size(302, 53);
            this.addBook_btn.TabIndex = 2;
            this.addBook_btn.Text = "Add Book";
            this.addBook_btn.UseVisualStyleBackColor = false;
            this.addBook_btn.Click += new System.EventHandler(this.addBook_btn_Click);
            // 
            // removeBook_btn
            // 
            this.removeBook_btn.BackColor = System.Drawing.SystemColors.Info;
            this.removeBook_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.removeBook_btn.Location = new System.Drawing.Point(603, 423);
            this.removeBook_btn.Name = "removeBook_btn";
            this.removeBook_btn.Size = new System.Drawing.Size(302, 53);
            this.removeBook_btn.TabIndex = 3;
            this.removeBook_btn.Text = "Remove Book";
            this.removeBook_btn.UseVisualStyleBackColor = false;
            this.removeBook_btn.Click += new System.EventHandler(this.removeBook_btn_Click);
            // 
            // addMember_btn
            // 
            this.addMember_btn.BackColor = System.Drawing.SystemColors.Info;
            this.addMember_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.addMember_btn.Location = new System.Drawing.Point(603, 608);
            this.addMember_btn.Name = "addMember_btn";
            this.addMember_btn.Size = new System.Drawing.Size(302, 53);
            this.addMember_btn.TabIndex = 4;
            this.addMember_btn.Text = "View Members";
            this.addMember_btn.UseVisualStyleBackColor = false;
            this.addMember_btn.Click += new System.EventHandler(this.addMember_btn_Click);
            // 
            // transHistory_btn
            // 
            this.transHistory_btn.BackColor = System.Drawing.SystemColors.Info;
            this.transHistory_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.transHistory_btn.Location = new System.Drawing.Point(603, 697);
            this.transHistory_btn.Name = "transHistory_btn";
            this.transHistory_btn.Size = new System.Drawing.Size(302, 53);
            this.transHistory_btn.TabIndex = 5;
            this.transHistory_btn.Text = "Transsaction History";
            this.transHistory_btn.UseVisualStyleBackColor = false;
            this.transHistory_btn.Click += new System.EventHandler(this.removeMember_btn_Click);
            // 
            // lbl_log_user
            // 
            this.lbl_log_user.AutoSize = true;
            this.lbl_log_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_log_user.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_log_user.ForeColor = System.Drawing.Color.White;
            this.lbl_log_user.Location = new System.Drawing.Point(117, 31);
            this.lbl_log_user.Name = "lbl_log_user";
            this.lbl_log_user.Size = new System.Drawing.Size(385, 45);
            this.lbl_log_user.TabIndex = 6;
            this.lbl_log_user.Text = "Welcome Librarian..!";
            this.lbl_log_user.Click += new System.EventHandler(this.lbl_log_user_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LibraryManagementGUI.Properties.Resources.HOW_DO_YOU_DESIGN_A_LIBRARY_MANAGEMENT_SYSTEM_min;
            this.pictureBox2.Location = new System.Drawing.Point(74, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(483, 466);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // logOut_btn
            // 
            this.logOut_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.logOut_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.logOut_btn.Location = new System.Drawing.Point(125, 700);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(349, 50);
            this.logOut_btn.TabIndex = 14;
            this.logOut_btn.Text = "Log Out";
            this.logOut_btn.UseVisualStyleBackColor = false;
            this.logOut_btn.Click += new System.EventHandler(this.logOut_btn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::LibraryManagementGUI.Properties.Resources.book_png_image_pngfre_12;
            this.pictureBox4.Location = new System.Drawing.Point(691, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(112, 117);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.BackColor = System.Drawing.SystemColors.Info;
            this.addMemberBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.addMemberBtn.Location = new System.Drawing.Point(603, 514);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(302, 53);
            this.addMemberBtn.TabIndex = 16;
            this.addMemberBtn.Text = "Add Member";
            this.addMemberBtn.UseVisualStyleBackColor = false;
            this.addMemberBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LibrarianWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagementGUI.Properties.Resources.Photo_abstract_blue_background_with_smooth_lines;
            this.ClientSize = new System.Drawing.Size(1063, 845);
            this.Controls.Add(this.addMemberBtn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.logOut_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_log_user);
            this.Controls.Add(this.transHistory_btn);
            this.Controls.Add(this.addMember_btn);
            this.Controls.Add(this.removeBook_btn);
            this.Controls.Add(this.addBook_btn);
            this.Controls.Add(this.returnBook_btn);
            this.Controls.Add(this.lib_view_book_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1085, 901);
            this.MinimumSize = new System.Drawing.Size(1085, 901);
            this.Name = "LibrarianWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian";
            this.Load += new System.EventHandler(this.LibrarianWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lib_view_book_btn;
        private System.Windows.Forms.Button returnBook_btn;
        private System.Windows.Forms.Button addBook_btn;
        private System.Windows.Forms.Button removeBook_btn;
        private System.Windows.Forms.Button addMember_btn;
        private System.Windows.Forms.Button transHistory_btn;
        private System.Windows.Forms.Label lbl_log_user;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button logOut_btn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button addMemberBtn;
    }
}