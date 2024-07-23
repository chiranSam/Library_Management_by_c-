using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementGUI
{
    public partial class MemberWindow : Form
    {
        private string memberId;
        string connectionString = @"Data Source=CHIRAN\SQLEXPRESS;Initial Catalog=LibraryDataBase;Integrated Security=True";
        public MemberWindow()
        {
            InitializeComponent();
            
        }
        //logged user name displaying
        public void SetLoggedInUserName(string userName) 
        { 
            lbl_log_user.Text =$"Welcome {userName} !";
        }

        //logged user id displaying
        public void SetLoggedInUserId(string userId)
        {
            memberId = userId;
            id_lbl.Text = $"ID {userId} !";
        }
        //view books window open
        private void button3_Click(object sender, EventArgs e)
        {
          ViewBooksMember viewBooksMember = new ViewBooksMember();
            viewBooksMember.Show();
            this.Hide();
        }

        private void MemberWindow_Load(object sender, EventArgs e)
        {

        }
        //borrow bok button
        private void borrowBook_btn_Click(object sender, EventArgs e)
        {

            BorrowBook borrowBook = new BorrowBook(memberId);
            borrowBook.Show();
            this.Hide();

        }
        //Log out button
        private void logOut_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Type_Form login_Type_Form = new Login_Type_Form();
            login_Type_Form.Show();
        }

        private void lbl_log_user_Click(object sender, EventArgs e)
        {

        }
    }
}
