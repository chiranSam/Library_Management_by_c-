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
    public partial class AddBookWindow : Form
    {
        string connectionString = @"Data Source=CHIRAN\SQLEXPRESS;Initial Catalog=LibraryDataBase;Integrated Security=True";
        public AddBookWindow()
        {
            InitializeComponent();
        }

        private void memberID_lbl_Click(object sender, EventArgs e)
        {

        }

        private void newBookIdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void newBookNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void newAuthortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBook_btn_Click(object sender, EventArgs e)
        {
            if(newBookIdTxt.Text != "" && newBookNametxt.Text != "" && newAuthortxt.Text != "")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        //check the entered ook id is exists
                        string checkExisting = "SELECT COUNT(*) FROM BooksTable WHERE Book_Id = @bookId";
                        using (SqlCommand checkCmd = new SqlCommand(checkExisting, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@bookId", newBookIdTxt.Text.Trim());
                            int existingCount = (int)checkCmd.ExecuteScalar();

                            if (existingCount > 0)
                            {
                                MessageBox.Show("Book ID already exists. Please enter a different Book ID.");
                                return;
                            }
                        }


                        //add book to the table
                        string insertQuery = "INSERT INTO BooksTable (Book_Id, Book_Name, Author, Availability)" +
                                              "VALUES (@bookId, @bookName, @bookAuthor, @availability)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@bookId", newBookIdTxt.Text);
                            cmd.Parameters.AddWithValue("@bookName", newBookNametxt.Text);
                            cmd.Parameters.AddWithValue("@bookAuthor", newAuthortxt.Text);
                            cmd.Parameters.AddWithValue("@availability", 1);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Book Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //clear the fields
                            newBookNametxt.Text = "";
                            newBookIdTxt.Text = "";
                            newAuthortxt.Text = "";
                            conn.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
               
            }
            else
            {
                MessageBox.Show("Please fill the all fields","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private void AddBookWindow_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            //back button
            LibrarianWindow librarianWindow = new LibrarianWindow();
            librarianWindow.Show();
            this.Close();
        }
    }
}
