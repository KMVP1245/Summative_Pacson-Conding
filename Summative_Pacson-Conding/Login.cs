using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Summative_Pacson_Conding.UserForms;


namespace Summative_Pacson_Conding
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           DataAccess da = new DataAccess();
            int role = da.ValidateLogin(txtUsername.Text, txtPassword.Text);


            if (role == -1)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form1 parent = this.MdiParent as Form1;
            if (role == 1)
            {
                AdminForm admin = new AdminForm();
                admin.MdiParent = parent;
                admin.Dock = DockStyle.Fill;
                admin.Show();

                this.Close(); 
            }
           else if (role == 0)
            {
               UserForm user = new UserForm();
               user.MdiParent = parent;
               user.Dock = DockStyle.Fill;
               user.Show();

                this.Close();
            }
        }
    }
}
