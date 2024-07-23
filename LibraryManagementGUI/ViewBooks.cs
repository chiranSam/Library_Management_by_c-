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
    public partial class ViewBooks : Form
    {
        string connectionString = @"Data Source=CHIRAN\SQLEXPRESS;Initial Catalog=LibraryDataBase;Integrated Security=True";
        public ViewBooks()
        {
            InitializeComponent();
        }

        private void ViewBooks_Load(object sender, EventArgs e)
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            LibrarianWindow librarianWindow = new LibrarianWindow();
            librarianWindow.Show();
        }

        private void bookView_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void viewBook_Header_Click(object sender, EventArgs e)
        {

        }
    }
}
