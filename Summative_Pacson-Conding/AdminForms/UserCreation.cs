using DataHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summative_Pacson_Conding.AdminForms
{
    public partial class UserCreation : Form
    {
        public UserCreation()
        {
            InitializeComponent();
        }

        private void UserCreation_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentID = txtId.Text;
            string firstName = txtFname.Text;
            string lastName = txtLname.Text;
            string gender = cboGender.SelectedItem?.ToString();
            string course = cboCourse.SelectedItem?.ToString();
            string username = txtUsername.Text;
            string password = txtPass.Text;
            string confirmPassword = txtConfirmPass.Text;

            if (string.IsNullOrWhiteSpace(studentID) ||
             string.IsNullOrWhiteSpace(firstName) ||
             string.IsNullOrWhiteSpace(lastName) ||
             string.IsNullOrWhiteSpace(gender) ||
             string.IsNullOrWhiteSpace(course) ||
             string.IsNullOrWhiteSpace(username) ||
             string.IsNullOrWhiteSpace(password) ||
             string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataAccess da = new DataAccess();
            bool success =da.CreateUser(studentID, firstName, lastName, gender, course, username, password);

            if (success) {
                MessageBox.Show("User created successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                txtId.Clear();
                txtFname.Clear();
                txtLname.Clear();
                cboGender.SelectedIndex = -1;
                cboCourse.SelectedIndex = -1;
                txtUsername.Clear();
                txtPass.Clear();
                txtConfirmPass.Clear();

                txtId.Focus(); 
            }
            else
            {
                MessageBox.Show("Failed to create user.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void addUserAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 parent = this.MdiParent as Form1;
            UserCreation usercreate = new UserCreation();
            usercreate.MdiParent = parent;
            usercreate.Dock = DockStyle.Fill;
            usercreate.Show();


            this.Close(); // or this.Hide(); kung gusto tago lang
        }

        private void passwordRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 parent = this.MdiParent as Form1;
            UserPasswordRecovery upr = new UserPasswordRecovery();
            upr.MdiParent = parent;
            upr.Dock = DockStyle.Fill;
            upr.Show();


            this.Close(); // or this.Hide(); kung gusto tago lang
        }

        private void addEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 parent = this.MdiParent as Form1;
            AddEquipment addForm = new AddEquipment();
            addForm.MdiParent = parent;
            addForm.Dock = DockStyle.Fill;
            addForm.Show();


            this.Close(); // or this.Hide(); kung gusto tago lang
        }
    }
}
