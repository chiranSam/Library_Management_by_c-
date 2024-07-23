namespace LibraryManagementGUI
{
    partial class AddBookWindow
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.newBookIdTxt = new System.Windows.Forms.TextBox();
            this.memberID_lbl = new System.Windows.Forms.Label();
            this.newBookNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newAuthortxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addBook_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(404, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Books";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::LibraryManagementGUI.Properties.Resources.HOW_DO_YOU_DESIGN_A_LIBRARY_MANAGEMENT_SYSTEM_min;
            this.pictureBox2.Location = new System.Drawing.Point(22, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(515, 562);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
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
            this.back_btn.TabIndex = 18;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // newBookIdTxt
            // 
            this.newBookIdTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.newBookIdTxt.Location = new System.Drawing.Point(617, 162);
            this.newBookIdTxt.Name = "newBookIdTxt";
            this.newBookIdTxt.Size = new System.Drawing.Size(309, 35);
            this.newBookIdTxt.TabIndex = 20;
            this.newBookIdTxt.TextChanged += new System.EventHandler(this.newBookIdTxt_TextChanged);
            // 
            // memberID_lbl
            // 
            this.memberID_lbl.AutoSize = true;
            this.memberID_lbl.BackColor = System.Drawing.Color.Transparent;
            this.memberID_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberID_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.memberID_lbl.Location = new System.Drawing.Point(611, 112);
            this.memberID_lbl.Name = "memberID_lbl";
            this.memberID_lbl.Size = new System.Drawing.Size(243, 32);
            this.memberID_lbl.TabIndex = 19;
            this.memberID_lbl.Text = "Enter the Book ID ";
            this.memberID_lbl.Click += new System.EventHandler(this.memberID_lbl_Click);
            // 
            // newBookNametxt
            // 
            this.newBookNametxt.Font = new System.Drawing.Font("Arial", 12F);
            this.newBookNametxt.Location = new System.Drawing.Point(617, 299);
            this.newBookNametxt.Name = "newBookNametxt";
            this.newBookNametxt.Size = new System.Drawing.Size(309, 35);
            this.newBookNametxt.TabIndex = 22;
            this.newBookNametxt.TextChanged += new System.EventHandler(this.newBookNametxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(611, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 64);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enter the Book Name\r\n\r\n";
            // 
            // newAuthortxt
            // 
            this.newAuthortxt.Font = new System.Drawing.Font("Arial", 12F);
            this.newAuthortxt.Location = new System.Drawing.Point(617, 432);
            this.newAuthortxt.Name = "newAuthortxt";
            this.newAuthortxt.Size = new System.Drawing.Size(309, 35);
            this.newAuthortxt.TabIndex = 24;
            this.newAuthortxt.TextChanged += new System.EventHandler(this.newAuthortxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(611, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Enter the Author\r\n";
            // 
            // addBook_btn
            // 
            this.addBook_btn.BackColor = System.Drawing.SystemColors.Info;
            this.addBook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBook_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.addBook_btn.Location = new System.Drawing.Point(617, 532);
            this.addBook_btn.Name = "addBook_btn";
            this.addBook_btn.Size = new System.Drawing.Size(349, 56);
            this.addBook_btn.TabIndex = 25;
            this.addBook_btn.Text = "Add Book";
            this.addBook_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addBook_btn.UseVisualStyleBackColor = false;
            this.addBook_btn.Click += new System.EventHandler(this.addBook_btn_Click);
            // 
            // AddBookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagementGUI.Properties.Resources.Photo_abstract_blue_background_with_smooth_lines;
            this.ClientSize = new System.Drawing.Size(1063, 716);
            this.Controls.Add(this.addBook_btn);
            this.Controls.Add(this.newAuthortxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newBookNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newBookIdTxt);
            this.Controls.Add(this.memberID_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1085, 772);
            this.MinimumSize = new System.Drawing.Size(1085, 772);
            this.Name = "AddBookWindow";
            this.Text = "AddBookWindow";
            this.Load += new System.EventHandler(this.AddBookWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.TextBox newBookIdTxt;
        private System.Windows.Forms.Label memberID_lbl;
        private System.Windows.Forms.TextBox newBookNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newAuthortxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBook_btn;
    }
}