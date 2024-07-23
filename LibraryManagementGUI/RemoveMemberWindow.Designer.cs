namespace LibraryManagementGUI
{
    partial class RemoveMemberWindow
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
            this.membersView_grid = new System.Windows.Forms.DataGridView();
            this.removeMember_btn = new System.Windows.Forms.Button();
            this.rmvMemberIdTxt = new System.Windows.Forms.TextBox();
            this.memberID_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.membersView_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // membersView_grid
            // 
            this.membersView_grid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.membersView_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersView_grid.Location = new System.Drawing.Point(25, 132);
            this.membersView_grid.Name = "membersView_grid";
            this.membersView_grid.RowHeadersWidth = 62;
            this.membersView_grid.RowTemplate.Height = 28;
            this.membersView_grid.Size = new System.Drawing.Size(539, 561);
            this.membersView_grid.TabIndex = 39;
            // 
            // removeMember_btn
            // 
            this.removeMember_btn.BackColor = System.Drawing.SystemColors.Info;
            this.removeMember_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeMember_btn.Font = new System.Drawing.Font("Arial", 12F);
            this.removeMember_btn.Location = new System.Drawing.Point(601, 484);
            this.removeMember_btn.Name = "removeMember_btn";
            this.removeMember_btn.Size = new System.Drawing.Size(349, 56);
            this.removeMember_btn.TabIndex = 38;
            this.removeMember_btn.Text = "Remove Member";
            this.removeMember_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.removeMember_btn.UseVisualStyleBackColor = false;
            this.removeMember_btn.Click += new System.EventHandler(this.removeMember_btn_Click);
            // 
            // rmvMemberIdTxt
            // 
            this.rmvMemberIdTxt.Font = new System.Drawing.Font("Arial", 12F);
            this.rmvMemberIdTxt.Location = new System.Drawing.Point(601, 356);
            this.rmvMemberIdTxt.Name = "rmvMemberIdTxt";
            this.rmvMemberIdTxt.Size = new System.Drawing.Size(349, 35);
            this.rmvMemberIdTxt.TabIndex = 37;
            // 
            // memberID_lbl
            // 
            this.memberID_lbl.AutoSize = true;
            this.memberID_lbl.BackColor = System.Drawing.Color.Transparent;
            this.memberID_lbl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberID_lbl.ForeColor = System.Drawing.Color.Transparent;
            this.memberID_lbl.Location = new System.Drawing.Point(595, 299);
            this.memberID_lbl.Name = "memberID_lbl";
            this.memberID_lbl.Size = new System.Drawing.Size(283, 32);
            this.memberID_lbl.TabIndex = 36;
            this.memberID_lbl.Text = "Enter the member ID ";
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
            this.back_btn.TabIndex = 35;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(373, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 52);
            this.label1.TabIndex = 34;
            this.label1.Text = "Remove Member";
            // 
            // RemoveMemberWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagementGUI.Properties.Resources.Photo_abstract_blue_background_with_smooth_lines;
            this.ClientSize = new System.Drawing.Size(1063, 716);
            this.Controls.Add(this.membersView_grid);
            this.Controls.Add(this.removeMember_btn);
            this.Controls.Add(this.rmvMemberIdTxt);
            this.Controls.Add(this.memberID_lbl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1085, 772);
            this.MinimumSize = new System.Drawing.Size(1085, 772);
            this.Name = "RemoveMemberWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Member";
            this.Load += new System.EventHandler(this.RemoveMemberWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membersView_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView membersView_grid;
        private System.Windows.Forms.Button removeMember_btn;
        private System.Windows.Forms.TextBox rmvMemberIdTxt;
        private System.Windows.Forms.Label memberID_lbl;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.Label label1;
    }
}