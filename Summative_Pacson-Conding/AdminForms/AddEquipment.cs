using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DataHelper;

namespace Summative_Pacson_Conding.AdminForms
{
    public partial class AddEquipment : Form
    {
        public AddEquipment()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           

        }

        private void addEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string equipmentName = itemName.Text;
            string equipmentType = itemDesc.Text;
            int quantity = (int)itemQty.Value;

            DataAccess da = new DataAccess();

            bool success = da.AddEquipment(equipmentName, equipmentType, quantity);

            if (success)
            {
                MessageBox.Show("Equipment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Equipment with the same name and description already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           panel1.Visible = true;
            panel2.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           panel2.Visible = true;
           panel1.Visible = false;
            LoadEquipmentList();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void AddEquipment_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }
        private void LoadEquipmentList()
        {
            DataAccess da = new DataAccess();
            DataTable dt = da.GetAllEquipment();

            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["EquipmentID"].ToString());
                item.SubItems.Add(row["EquipmentName"].ToString());
                item.SubItems.Add(row["Description"].ToString());
                item.SubItems.Add(row["Quantity"].ToString());
                listView1.Items.Add(item);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an equipment to Update or Delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int equipmentID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string equipmentName = nameUpdate.Text.Trim();
            string description = descUpdate.Text.Trim();
            int quantity = (int)qtyUpdate.Value;

            DataAccess da = new DataAccess();
            bool success = da.UpdateEquipment(equipmentID, equipmentName, description, quantity);

            if (success)
            {
                MessageBox.Show("Equipment updated successfully!");
                LoadEquipmentList();
            }
            else
            {
                MessageBox.Show("Update failed. Please try again.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an equipment to delete.");
                return;
            }
            int equipmentID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this equipment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                DataAccess da = new DataAccess();
                bool success = da.DeleteEquipment(equipmentID);

                if (success)
                {
                    MessageBox.Show("Equipment deleted successfully!");
                    LoadEquipmentList(); 
                }
                else
                {
                    MessageBox.Show("Failed to delete equipment. Try again.");
                }
            }
        }
    }
}
