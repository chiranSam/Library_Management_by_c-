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
    public partial class LibrarianWindow : Form
    {
        string connectionString = @"Data Source=CHIRAN\SQLEXPRESS;Initial Catalog=LibraryDataBase;Integrated Security=True";
        public LibrarianWindow()
        {
            InitializeComponent();
        }
        //View book Button to display books in anothe window
        private void lib_view_book_btn_Click(object sender, EventArgs e)
        {
            ViewBooks viewBooks = new ViewBooks();
            viewBooks.Show();
            this.Hide();
        }

        //Return Book window open Button
        private void returnBook_btn_Click(object sender, EventArgs e)
        {
            ReturnBookWindow returnBookWindow = new ReturnBookWindow();
            returnBookWindow.Show();
            this.Hide();
        }
        //Log out Button back to the login
        private void logOut_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login_Type_Form login_Type_Form = new Login_Type_Form();
            login_Type_Form.Show();
        }
        //Add book window open button

        private void addBook_btn_Click(object sender, EventArgs e)
        {
            AddBookWindow addBookWindow = new AddBookWindow();
            addBookWindow.Show();
            this.Hide();
        }
        //Remove book wondow open button
        private void removeBook_btn_Click(object sender, EventArgs e)
        {
            RemoveBookWindow removeBookWindow = new RemoveBookWindow();
            removeBookWindow.Show();
            this.Hide();
        }
        //Add member window open button
        private void addMember_btn_Click(object sender, EventArgs e)
        {
            MembersWindow addMemberWindow = new MembersWindow();
            addMemberWindow.Show();
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            AddMemberWindow_2_ addMemberWindow_2_ = new AddMemberWindow_2_();
            addMemberWindow_2_.Show();
            this.Hide();
        }

        private void removeMember_btn_Click(object sender, EventArgs e)
        {
            TransactionHistoryWin TransactionHistoryWin = new TransactionHistoryWin();
            TransactionHistoryWin.Show();
            this.Hide();
        }

        private void LibrarianWindow_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_log_user_Click(object sender, EventArgs e)
        {

        }
    }
}
