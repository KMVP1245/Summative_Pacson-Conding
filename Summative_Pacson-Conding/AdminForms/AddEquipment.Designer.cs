namespace Summative_Pacson_Conding.AdminForms
{
    partial class AddEquipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEqupmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Line = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.itemName = new System.Windows.Forms.TextBox();
            this.itemDesc = new System.Windows.Forms.TextBox();
            this.itemQty = new System.Windows.Forms.NumericUpDown();
            this.username = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.showAddPanel = new System.Windows.Forms.Button();
            this.showEditPanel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.nameUpdate = new System.Windows.Forms.TextBox();
            this.descUpdate = new System.Windows.Forms.TextBox();
            this.qtyUpdate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemQty)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.recordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEquipmentToolStripMenuItem,
            this.editEqupmentToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.managementToolStripMenuItem.Text = "Equipment";
            // 
            // addEquipmentToolStripMenuItem
            // 
            this.addEquipmentToolStripMenuItem.Name = "addEquipmentToolStripMenuItem";
            this.addEquipmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addEquipmentToolStripMenuItem.Text = "Add Equipment";
            this.addEquipmentToolStripMenuItem.Click += new System.EventHandler(this.addEquipmentToolStripMenuItem_Click);
            // 
            // editEqupmentToolStripMenuItem
            // 
            this.editEqupmentToolStripMenuItem.Name = "editEqupmentToolStripMenuItem";
            this.editEqupmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editEqupmentToolStripMenuItem.Text = "Edit Equpment";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserAccountToolStripMenuItem,
            this.passwordRecoveryToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addUserAccountToolStripMenuItem
            // 
            this.addUserAccountToolStripMenuItem.Name = "addUserAccountToolStripMenuItem";
            this.addUserAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addUserAccountToolStripMenuItem.Text = "Add User Account";
            // 
            // passwordRecoveryToolStripMenuItem
            // 
            this.passwordRecoveryToolStripMenuItem.Name = "passwordRecoveryToolStripMenuItem";
            this.passwordRecoveryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.passwordRecoveryToolStripMenuItem.Text = "Password Recovery";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewRecordsToolStripMenuItem});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.recordToolStripMenuItem.Text = "Record";
            // 
            // viewRecordsToolStripMenuItem
            // 
            this.viewRecordsToolStripMenuItem.Name = "viewRecordsToolStripMenuItem";
            this.viewRecordsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.viewRecordsToolStripMenuItem.Text = "View Records";
            // 
            // Line
            // 
            this.Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 275.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line.Location = new System.Drawing.Point(253, 3);
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.Size = new System.Drawing.Size(10, 423);
            this.Line.TabIndex = 100;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.showEditPanel);
            this.splitContainer1.Panel1.Controls.Add(this.showAddPanel);
            this.splitContainer1.Panel1.Controls.Add(this.Line);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(679, 387);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 19;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.itemName);
            this.panel1.Controls.Add(this.itemDesc);
            this.panel1.Controls.Add(this.itemQty);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 387);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(220, 258);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 33);
            this.btnLogin.TabIndex = 23;
            this.btnLogin.Text = "Add Item";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // itemName
            // 
            this.itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemName.Location = new System.Drawing.Point(184, 118);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(160, 26);
            this.itemName.TabIndex = 17;
            // 
            // itemDesc
            // 
            this.itemDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDesc.Location = new System.Drawing.Point(185, 198);
            this.itemDesc.Name = "itemDesc";
            this.itemDesc.Size = new System.Drawing.Size(160, 26);
            this.itemDesc.TabIndex = 18;
            // 
            // itemQty
            // 
            this.itemQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.itemQty.Location = new System.Drawing.Point(184, 158);
            this.itemQty.Name = "itemQty";
            this.itemQty.Size = new System.Drawing.Size(160, 26);
            this.itemQty.TabIndex = 22;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(78, 122);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 18);
            this.username.TabIndex = 19;
            this.username.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Quantity";
            // 
            // showAddPanel
            // 
            this.showAddPanel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAddPanel.Location = new System.Drawing.Point(29, 33);
            this.showAddPanel.Name = "showAddPanel";
            this.showAddPanel.Size = new System.Drawing.Size(147, 60);
            this.showAddPanel.TabIndex = 24;
            this.showAddPanel.Text = "Add New Equipment";
            this.showAddPanel.UseVisualStyleBackColor = true;
            this.showAddPanel.Click += new System.EventHandler(this.button1_Click);
            // 
            // showEditPanel
            // 
            this.showEditPanel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEditPanel.Location = new System.Drawing.Point(29, 101);
            this.showEditPanel.Name = "showEditPanel";
            this.showEditPanel.Size = new System.Drawing.Size(147, 60);
            this.showEditPanel.TabIndex = 101;
            this.showEditPanel.Text = "Edit Equpment";
            this.showEditPanel.UseVisualStyleBackColor = true;
            this.showEditPanel.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.nameUpdate);
            this.panel2.Controls.Add(this.descUpdate);
            this.panel2.Controls.Add(this.qtyUpdate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 387);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 50);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(414, 187);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 30;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // nameUpdate
            // 
            this.nameUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameUpdate.Location = new System.Drawing.Point(129, 258);
            this.nameUpdate.Name = "nameUpdate";
            this.nameUpdate.Size = new System.Drawing.Size(160, 26);
            this.nameUpdate.TabIndex = 24;
            // 
            // descUpdate
            // 
            this.descUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descUpdate.Location = new System.Drawing.Point(130, 338);
            this.descUpdate.Name = "descUpdate";
            this.descUpdate.Size = new System.Drawing.Size(160, 26);
            this.descUpdate.TabIndex = 25;
            this.descUpdate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // qtyUpdate
            // 
            this.qtyUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.qtyUpdate.Location = new System.Drawing.Point(129, 298);
            this.qtyUpdate.Name = "qtyUpdate";
            this.qtyUpdate.Size = new System.Drawing.Size(160, 26);
            this.qtyUpdate.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Select Equipment in list to edit";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Equipment Name";
            this.columnHeader2.Width = 152;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description";
            this.columnHeader3.Width = 131;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(309, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 43);
            this.button2.TabIndex = 32;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 411);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AddEquipment";
            this.Load += new System.EventHandler(this.AddEquipment_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemQty)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEqupmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordRecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
        private System.Windows.Forms.TextBox Line;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox itemName;
        private System.Windows.Forms.TextBox itemDesc;
        private System.Windows.Forms.NumericUpDown itemQty;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showAddPanel;
        private System.Windows.Forms.Button showEditPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameUpdate;
        private System.Windows.Forms.TextBox descUpdate;
        private System.Windows.Forms.NumericUpDown qtyUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button2;
    }
}