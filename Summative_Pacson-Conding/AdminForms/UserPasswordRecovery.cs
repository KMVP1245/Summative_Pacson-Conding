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
    public partial class UserPasswordRecovery : Form
    {
       
        public UserPasswordRecovery()
        {
           InitializeComponent();    
        }

        DataTable allUsers;

        private void UserPasswordRecovery_Load(object sender, EventArgs e)
        {
            txtNewPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            DataAccess da = new DataAccess();
            allUsers = da.GetAllUsers();
            LoadUserList(allUsers);
        }

        private void LoadUserList(DataTable dt)
        {
            DataAccess da = new DataAccess();
            

            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["StudentID"].ToString());
                item.SubItems.Add(row["FirstName"].ToString());
                item.SubItems.Add(row["LastName"].ToString());
                item.SubItems.Add(row["Gender"].ToString());
                item.SubItems.Add(row["Course"].ToString());
                item.SubItems.Add(row["Username"].ToString());
                listView1.Items.Add(item);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadUserList(allUsers);
                return;
            }

            DataView dv = allUsers.DefaultView;
            dv.RowFilter = $"StudentID LIKE '%{searchTerm}%' OR FirstName LIKE '%{searchTerm}%' OR LastName LIKE '%{searchTerm}%' OR Username LIKE '%{searchTerm}%'";
            LoadUserList(dv.ToTable());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Enabled = true;
            txtNewPassword.Enabled = true;
            txtNewPassword.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a user to reset the password.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = listView1.SelectedItems[0].SubItems[5].Text;
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if(string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please enter and confirm the new password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("The new password and confirmation do not match.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataAccess da = new DataAccess();
            bool success = da.ResetUserPassword(username, newPassword);


            if (success)
            {
                MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmPassword.Clear();
                txtNewPassword.Clear(); 
            }
            else
            {
                MessageBox.Show("Password reset failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
    }
}
