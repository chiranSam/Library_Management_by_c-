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
    public partial class RemoveBookWindow : Form
    {
        string connectionString = @"Data Source=CHIRAN\SQLEXPRESS;Initial Catalog=LibraryDataBase;Integrated Security=True";
        public RemoveBookWindow()
        {
            InitializeComponent();
        }

        private void bookView_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemoveBookWindow_Load(object sender, EventArgs e)
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

        private void rmvBookIdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeBook_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string bookId = rmvBookIdTxt.Text.Trim();
                if(!string.IsNullOrEmpty(bookId))
                {
                    using(SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string checkExixting = "SELECT COUNT(*) FROM BooksTable WHERE Book_Id = @bookId";

                        using(SqlCommand checkcmd = new SqlCommand(checkExixting, connection))
                        {
                            checkcmd.Parameters.AddWithValue("@bookId", bookId);
                            int existingCount = (int)checkcmd.ExecuteScalar();

                            if (existingCount == 0) 
                            {
                                MessageBox.Show("Book Id does not exists.Please enter a valid book Id");
                                return;
                            }
                        }
                        string deleteQuery = "DELETE FROM BooksTable WHERE Book_Id = @bookId ";
                        using(SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@bookId", bookId);
                            deleteCmd.ExecuteNonQuery();

                            MessageBox.Show("Book removed successfully.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshTable();
                            rmvBookIdTxt.Text = "";

                        }


                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Book Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }
        public void RefreshTable()
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM BooksTable",conn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                bookView_grid.DataSource = dt;
                bookView_grid.ReadOnly = true;
                foreach(DataGridViewColumn column in bookView_grid.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }


            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            LibrarianWindow librarianWindow = new LibrarianWindow();
            librarianWindow.Show();
            this.Close();
        }
    }
}
