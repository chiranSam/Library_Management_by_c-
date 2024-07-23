using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryManagementGUI
{
    public partial class ReturnBookWindow : Form
    {
        SqlConnection conect = new SqlConnection(@"Data Source=CHIRAN\SQLEXPRESS;Initial Catalog=LibraryDataBase;Integrated Security=True");

        public ReturnBookWindow()
        {
            InitializeComponent();
        }

        private void bookID_lbl_Click(object sender, EventArgs e)
        {

        }

        private void ReturnBookWindow_Load(object sender, EventArgs e)
        {

        }
        //Back button to Librarian window
        private void back_btn_Click(object sender, EventArgs e)
        {
            LibrarianWindow librarianWindow = new LibrarianWindow();
            librarianWindow.Show();
            this.Close();
        }

        private void memberIdTxt_TextChanged(object sender, EventArgs e)
        {

        }
       
        // Member loans button
        private void ViewBorrowBooks_btn_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Open();

                string memberId = memberIdTxt.Text.Trim();
                string query = "SELECT * FROM ReturnBookTable WHERE Member_ID = @memberId";
                using (SqlCommand cmd = new SqlCommand(query, conect)) 
                {
                    cmd.Parameters.AddWithValue("@memberId", memberId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd)) 
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        bookView_grid.DataSource = dt;
                    }
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }finally { conect.Close(); }

        }

        private void bookView_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void returnBookId_txt_TextChanged(object sender, EventArgs e)
        {

        }

        //Return book button
        private void Return_Book_Click(object sender, EventArgs e)
        {
            try
            {
                conect.Open();

                string bookId = returnBookId_txt.Text.Trim();

                if(string.IsNullOrEmpty(bookId) )
                {
                    MessageBox.Show("Please enter a book Id");
                    return;
                }

                bool isBookIdValid = BookIdInDataTable(bookId);
                if(!isBookIdValid) 
                {
                    MessageBox.Show("Please enter a valid book ID.");
                    return;
                }

                string deleteQuery = "DELETE FROM ReturnBookTable WHERE Book_ID = @bookId";//Removing from Return book table

                using(SqlCommand deleteCmd = new SqlCommand(deleteQuery, conect))
                {
                    deleteCmd.Parameters.AddWithValue("@bookId", bookId);
                    deleteCmd.ExecuteNonQuery();
                }

                string updateQuery = "UPDATE BooksTable SET Availability = 1 WHERE Book_Id = @bookId"; //Updating Books Table

                using(SqlCommand updateCmd = new SqlCommand(updateQuery, conect))
                {
                    updateCmd.Parameters.AddWithValue("@bookId", bookId);
                    updateCmd.ExecuteNonQuery();
                }

                string updateHisTable = "UPDATE TransactionHistoryTable SET Returned_Date = @returnedDate WHERE Book_Id = @bookId";//Add details to transaction window
                string currentDate = DateTime.Now.ToString("yyy-MM-dd");
                using (SqlCommand updateCmd = new SqlCommand(updateHisTable, conect))
                {
                    updateCmd.Parameters.AddWithValue("@returnedDate", currentDate);
                    updateCmd.Parameters.AddWithValue("@bookId", bookId);
                    updateCmd.ExecuteNonQuery();
                }



                MessageBox.Show("Book Returned Successfully");
                    returnBookId_txt.Text = "";
               

                ViewBorrowBooks_btn_Click(sender, e);
                bookView_grid.DataSource = null;

            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally 
            {
                if(conect.State == ConnectionState.Open)
                {
                    conect.Close();
                }

            }

        }
        
        private bool BookIdInDataTable(string bookId)
        {
            foreach (DataGridViewRow row in bookView_grid.Rows)
            {
                if (row.Cells["Book_ID"].Value != null && row.Cells["Book_ID"].Value.ToString() == bookId)
                {
                    return true;
                }
                
            }
            return false;
        }
    }
}
