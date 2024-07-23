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
    public partial class RemoveMemberWindow : Form
    {
        string connectionString = @"Data Source=CHIRAN\SQLEXPRESS;Initial Catalog=LibraryDataBase;Integrated Security=True";
        public RemoveMemberWindow()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            LibrarianWindow librarianWindow = new LibrarianWindow();
            librarianWindow.Show();
            this.Close();
        }

        private void RemoveMemberWindow_Load(object sender, EventArgs e)
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

        private void removeMember_btn_Click(object sender, EventArgs e)
        {
            string memberId = rmvMemberIdTxt.Text;
            if(!string.IsNullOrEmpty(memberId) )
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkExisting = "SELECT COUNT(*) FROM NewMembersTable WHERE id = @memberId";
                    using(SqlCommand checkcmd = new SqlCommand(checkExisting,connection)) 
                    {
                        checkcmd.Parameters.AddWithValue("@memberId", memberId);
                        int existCount = (int)checkcmd.ExecuteScalar();

                        if (existCount == 0) 
                        {
                            MessageBox.Show("Member Id does not exists.Please enter a valid member Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }


                    }

                    string deleteMember = "DELETE FROM NewMembersTable WHERE id = @memberId";
                    using(SqlCommand deletecmd = new SqlCommand(deleteMember, connection))
                    {
                        deletecmd.Parameters.AddWithValue("@memberId", memberId);
                        deletecmd.ExecuteNonQuery();

                        MessageBox.Show("Member removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshTable(); // Update the table
                        rmvMemberIdTxt.Text = ""; // clear the textbox
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter the member Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Methodd to Refresh and update the member table
        public void RefreshTable()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM NewMembersTable", conn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                membersView_grid.DataSource = dt;
                membersView_grid.ReadOnly = true;
                foreach (DataGridViewColumn column in membersView_grid.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }


            }
        }
    }
}
