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
    public partial class MembersWindow : Form
    {
        string connectionString = @"Data Source=CHIRAN\SQLEXPRESS;Initial Catalog=LibraryDataBase;Integrated Security=True";
        public MembersWindow()
        {
            InitializeComponent();
        }

        private void MembersWindow_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM NewMembersTable", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);

                membersView_grid.DataSource = dataTable;
                membersView_grid.ReadOnly = true;
                foreach (DataGridViewColumn column in membersView_grid.Columns)
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
