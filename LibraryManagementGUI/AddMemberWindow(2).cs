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
    public partial class AddMemberWindow_2_ : Form
    {

        string connectionString = @"Data Source=CHIRAN\SQLEXPRESS;Initial Catalog=LibraryDataBase;Integrated Security=True";
        public AddMemberWindow_2_()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            LibrarianWindow librarianWindow = new LibrarianWindow();
            librarianWindow.Show();
            this.Close();

        }

        private void AddMemberWindow_2__Load(object sender, EventArgs e)
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

        private void addMember_btn_Click(object sender, EventArgs e)
        {
            if(newMemberIdTxt.Text != "" && newMemberNametxt.Text != "" && emailTxt.Text != "" && newMemberPassword_txt.Text != "")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        //check the entered ook id is exists
                        string checkExisting = "SELECT COUNT(*) FROM NewMembersTable WHERE id = @membersId";
                        using (SqlCommand checkCmd = new SqlCommand(checkExisting, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@membersId", newMemberIdTxt.Text.Trim());
                            int existingCount = (int)checkCmd.ExecuteScalar();

                            if (existingCount > 0)
                            {
                                MessageBox.Show("Members ID already exists. Please enter a different Member ID.");
                                return;
                            }
                        }


                        //add book to the table
                        string insertQuery = "INSERT INTO  NewMembersTable (id, name, email, password)" +
                                              "VALUES (@memberId, @name, @email, @pw)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@memberId", newMemberIdTxt.Text);
                            cmd.Parameters.AddWithValue("@name", newMemberNametxt.Text);
                            cmd.Parameters.AddWithValue("@email", emailTxt.Text);
                            cmd.Parameters.AddWithValue("@pw", newMemberPassword_txt.Text);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Member Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshTable();

                            //clear the fields
                            newMemberIdTxt.Text = "";
                            newMemberNametxt.Text = "";
                            emailTxt.Text = "";
                            newMemberPassword_txt.Text = "";
                            conn.Close();

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //Refresh the Member Table
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
