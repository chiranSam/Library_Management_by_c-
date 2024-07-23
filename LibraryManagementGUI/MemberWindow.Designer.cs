namespace LibraryManagementGUI
{
    partial class MemberWindow
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
            this.borrowBook_btn = new System.Windows.Forms.Button();
            this.lbl_log_user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.logOut_btn = new System.Windows.Forms.Button();
            this.id_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowBook_btn
            // 
            this.borrowBook_btn.BackColor = System.Drawing.SystemColors.Info;
            this.borrowBook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowBook_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.borrowBook_btn.Location = new System.Drawing.Point(612, 263);
            this.borrowBook_btn.Name = "borrowBook_btn";
            this.borrowBook_btn.Size = new System.Drawing.Size(349, 56);
            this.borrowBook_btn.TabIndex = 0;
            this.borrowBook_btn.Text = "Borrow Book";
            this.borrowBook_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.borrowBook_btn.UseVisualStyleBackColor = false;
            this.borrowBook_btn.Click += new System.EventHandler(this.borrowBook_btn_Click);
            // 
            // lbl_log_user
            // 
            this.lbl_log_user.AutoSize = true;
            this.lbl_log_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_log_user.Font = new System.Drawing.Font("Arial", 20F);
            this.lbl_log_user.ForeColor = System.Drawing.Color.White;
            this.lbl_log_user.Location = new System.Drawing.Point(172, 40);
            this.lbl_log_user.Name = "lbl_log_user";
            this.lbl_log_user.Size = new System.Drawing.Size(187, 45);
            this.lbl_log_user.TabIndex = 5;
            this.lbl_log_user.Text = "Welcome";
            this.lbl_log_user.Click += new System.EventHandler(this.lbl_log_user_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(489, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 46);
            this.label3.TabIndex = 7;
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.BackColor = System.Drawing.Color.Transparent;
            this.userName_lbl.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Bold);
            this.userName_lbl.ForeColor = System.Drawing.Color.White;
            this.userName_lbl.Location = new System.Drawing.Point(495, 40);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(0, 54);
            this.userName_lbl.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Arial", 12F);
            this.button3.Location = new System.Drawing.Point(612, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(349, 56);
            this.button3.TabIndex = 9;
            this.button3.Text = "View Books";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LibraryManagementGUI.Properties.Resources.HOW_DO_YOU_DESIGN_A_LIBRARY_MANAGEMENT_SYSTEM_min;
            this.pictureBox2.Location = new System.Drawing.Point(12, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(515, 562);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::LibraryManagementGUI.Properties.Resources.k1ANjs_light_book_picture_png;
            this.pictureBox3.Location = new System.Drawing.Point(612, 581);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(364, 103);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::LibraryManagementGUI.Properties.Resources.book_png_image_pngfre_12;
            this.pictureBox4.Location = new System.Drawing.Point(816, 40);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(145, 150);
            this.pictureBox4.MinimumSize = new System.Drawing.Size(145, 150);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 150);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // logOut_btn
            // 
            this.logOut_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.logOut_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.logOut_btn.Location = new System.Drawing.Point(612, 491);
            this.logOut_btn.Name = "logOut_btn";
            this.logOut_btn.Size = new System.Drawing.Size(349, 50);
            this.logOut_btn.TabIndex = 13;
            this.logOut_btn.Text = "Log Out";
            this.logOut_btn.UseVisualStyleBackColor = false;
            this.logOut_btn.Click += new System.EventHandler(this.logOut_btn_Click);
            // 
            // id_lbl
            // 
            this.id_lbl.AutoSize = true;
            this.id_lbl.BackColor = System.Drawing.Color.Transparent;
            this.id_lbl.Font = new System.Drawing.Font("Arial", 20F);
            this.id_lbl.ForeColor = System.Drawing.Color.White;
            this.id_lbl.Location = new System.Drawing.Point(172, 85);
            this.id_lbl.Name = "id_lbl";
            this.id_lbl.Size = new System.Drawing.Size(59, 45);
            this.id_lbl.TabIndex = 14;
            this.id_lbl.Text = "ID";
            // 
            // MemberWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagementGUI.Properties.Resources.Photo_abstract_blue_background_with_smooth_lines;
            this.ClientSize = new System.Drawing.Size(1063, 716);
            this.Controls.Add(this.id_lbl);
            this.Controls.Add(this.logOut_btn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.userName_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_log_user);
            this.Controls.Add(this.borrowBook_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1085, 772);
            this.MinimumSize = new System.Drawing.Size(1085, 772);
            this.Name = "MemberWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberWindow";
            this.Load += new System.EventHandler(this.MemberWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button borrowBook_btn;
        private System.Windows.Forms.Label lbl_log_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button logOut_btn;
        private System.Windows.Forms.Label id_lbl;
    }
}