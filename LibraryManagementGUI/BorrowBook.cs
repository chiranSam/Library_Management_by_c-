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
    public partial class BorrowBook : Form
    {
        private int booksBorrowed = 0;
        private readonly string memberId;

        string connectionString = @"Data Source=CHIRAN\SQLEXPRESS;Initial Catalog=LibraryDataBase;Integrated Security=True";
        public BorrowBook(string memberId)
        {
            
            InitializeComponent();
            this.memberId = memberId;
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM BooksTable", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);

                bookView_grid.DataSource = dataTable;
                bookView_grid.ReadOnly = true;
                foreach (DataGridViewColumn column in bookView_grid.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }

            }
        }

        private void bookView_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BorrowBook_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the book ID from the TextBox
                string bookId = bookIdTextBox.Text.Trim();

               // BorrowBook book = new BorrowBook(memberId);

                // Check if the book ID is not empty
                if (string.IsNullOrEmpty(bookId))
                {
                    MessageBox.Show("Please enter a valid Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Connect to the database
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    // Check the availability of the book
                    string selectQuery = "SELECT * FROM BooksTable WHERE Book_Id = @BookID";
                    SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConnection);
                    selectCommand.Parameters.AddWithValue("@BookID", bookId);

                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        bool isAvailable = (bool)reader["Availability"]; 
                        string bookName = reader["Book_Name"].ToString(); 

                        reader.Close();

                        if (isAvailable && booksBorrowed < 2)
                        {
                            // Book is available, update the database and show success message
                            string updateQuery = "UPDATE BooksTable SET Availability = 0 WHERE Book_Id = @BookID"; // Table: BooksTable, Column: Availability, BookID
                            SqlCommand updateCommand = new SqlCommand(updateQuery, sqlConnection);
                            updateCommand.Parameters.AddWithValue("@BookID", bookId);

                            updateCommand.ExecuteNonQuery();

                            string insertQuery = "INSERT INTO ReturnBookTable (Member_ID, Book_ID, Issued_Date, Due_Date) VALUES (@MemberID, @BookID, @IssuedDate, @ReturnDate)";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                            insertCommand.Parameters.AddWithValue("@MemberID", memberId);
                            insertCommand.Parameters.AddWithValue("@BookID", bookId);
                            insertCommand.Parameters.AddWithValue("@IssuedDate", DateTime.Now.ToString("yyyy-MM-dd")); // Current date as issued date
                            insertCommand.Parameters.AddWithValue("@ReturnDate", DateTime.Now.AddDays(14).ToString("yyyy-MM-dd")); // 14 days from now as return date

                            insertCommand.ExecuteNonQuery();

                            string insertToHistory = "INSERT INTO TransactionHistoryTable (Book_Id, Borrwed_Date, Returned_Date, Member_Id) VALUES (@BookId, @BorrowedDate, @ReturnedDate, @memberId)";
                            string returnedDate = "";

                            SqlCommand insertTransHisCmd = new SqlCommand(insertToHistory, sqlConnection);
                            insertTransHisCmd.Parameters.AddWithValue("@BookId", bookId);
                            insertTransHisCmd.Parameters.AddWithValue("@BorrowedDate", DateTime.Now.ToString("yyyy-MM-dd"));
                            insertTransHisCmd.Parameters.AddWithValue("@ReturnedDate", returnedDate);
                            insertTransHisCmd.Parameters.AddWithValue("@memberId", memberId);

                            insertTransHisCmd.ExecuteNonQuery();


                            MessageBox.Show($"Book '{bookName}' is successfully borrowed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //LoadBooksData(); // Refresh the DataGridView
                            bookIdTextBox.Clear();
                            RefreshTable();
                            booksBorrowed++;
                        }
                        else if (booksBorrowed >= 2)
                        {
                            MessageBox.Show($"You can borrow two books at once", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                       
                        else
                        {
                            // Book is not available
                            MessageBox.Show($"Book '{bookName}' is not available.", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bookIdTextBox.Clear();
                        }
                    }
                    else
                    {
                        // Book ID not found
                        MessageBox.Show("Invalid Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberWindow memberWindow = new MemberWindow();
            memberWindow.Show();
        }
        public void RefreshTable()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM BooksTable", conn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                bookView_grid.DataSource = dt;
                bookView_grid.ReadOnly = true;
                foreach (DataGridViewColumn column in bookView_grid.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }


            }
        }

        private void bookIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
