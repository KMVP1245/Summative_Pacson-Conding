using Summative_Pacson_Conding.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summative_Pacson_Conding
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
