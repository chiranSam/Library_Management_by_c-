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
    public partial class LibrarianLogin : Form
    {
        SqlConnection conect = new SqlConnection(@"Data Source=CHIRAN\SQLEXPRESS;Initial Catalog=LibraryDataBase;Integrated Security=True");
        public LibrarianLogin()
        {
            InitializeComponent();
        }

        private void LibrarianLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Llogin_btn_Click(object sender, EventArgs e)
        {
            if(lid_txt.Text == "" || lpw_txt.Text == "")
            {
                MessageBox.Show("Please fill all fields","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                if(conect.State != ConnectionState.Open)
                {
                    try
                    {
                        conect.Open();
                        string selectData = "SELECT * FROM LibrariansTable WHERE id = @id AND password = @password";
                        using(SqlCommand cmd = new SqlCommand(selectData, conect)) 
                        {
                            cmd.Parameters.AddWithValue("@id", lid_txt.Text);
                            cmd.Parameters.AddWithValue("@password", lpw_txt.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
                                LibrarianWindow librarianWindow = new LibrarianWindow();
                                librarianWindow.Show();
                                this.Close();
                                MessageBox.Show("Logged In successfully...!" , "Successfull", MessageBoxButtons.OK, MessageBoxIcon.None);
                                

                            }
                            else
                            {
                                MessageBox.Show("Incorrect User or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: "+ ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        conect.Close();
                    }
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Login_Type_Form login_Type_Form = new Login_Type_Form();
            login_Type_Form.Show();
            this.Close();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            lpw_txt.UseSystemPasswordChar = !showPasswordCheckBox.Checked;
        }
    }
}
