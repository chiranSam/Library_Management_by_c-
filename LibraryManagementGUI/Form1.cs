using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementGUI
{
    public partial class Login_Type_Form : Form
    {
        public Login_Type_Form()
        {
            InitializeComponent();
        }

        private void Login_Type_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            MemberLogin member_login = new MemberLogin();
            member_login.Show();

        }

        private void librarian_btn_Click(object sender, EventArgs e)
        {

            LibrarianLogin librarianLogin = new LibrarianLogin();
            librarianLogin.Show();
            this.Hide();

        }
    }
}
