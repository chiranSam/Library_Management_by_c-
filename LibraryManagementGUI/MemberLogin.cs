using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace LibraryManagementGUI
{
    public partial class MemberLogin : Form
    {
        SqlConnection conect = new SqlConnection(@"Data Source=CHIRAN\SQLEXPRESS;Initial Catalog=LibraryDataBase;Integrated Security=True");
        public MemberLogin()
        {
            InitializeComponent();
        }
        string ulg;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mLogin_btn_Click(object sender, EventArgs e)
        {
            if (mid_txt.Text == "" || mpw_txt.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (conect.State != ConnectionState.Open)
                {
                    try
                    {
                        conect.Open();
                        string selectData = "SELECT id, name FROM NewMembersTable WHERE id = @id AND password = @password ";
                        using (SqlCommand cmd = new SqlCommand(selectData, conect))
                        {
                            cmd.Parameters.AddWithValue("@id", mid_txt.Text);
                            cmd.Parameters.AddWithValue("@password", mpw_txt.Text);
                            object result = cmd.ExecuteScalar();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1 && result != null)
                            {
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                       
                                        string memberName = reader["name"].ToString(); 
                                        string memberId = reader["id"].ToString();
                                        this.Close();
                                        MemberWindow memberWindow = new MemberWindow();
                                        memberWindow.SetLoggedInUserId(memberId);
                                        memberWindow.SetLoggedInUserName(memberName);
                                        memberWindow.Show();
                                        MessageBox.Show($"Logged In successfully \n Welcome {memberName}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.None);
                                    }
                                }
                               


                            }
                            else
                            {
                                MessageBox.Show("Incorrect User or Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        conect.Close();
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login_Type_Form login_Type_Form = new Login_Type_Form();
            login_Type_Form.Show();
            this.Close();
            
        }

        private void MemberLogin_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mpw_txt.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
