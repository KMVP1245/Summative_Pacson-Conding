namespace Summative_Pacson_Conding
{
    partial class AdminForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEqupmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Administrator!\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.recordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.addUserAccountToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addUserAccountToolStripMenuItem.Text = "Add User Account";
            // 
            // passwordRecoveryToolStripMenuItem
            // 
            this.passwordRecoveryToolStripMenuItem.Name = "passwordRecoveryToolStripMenuItem";
            this.passwordRecoveryToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEqupmentToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordRecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordsToolStripMenuItem;
    }
}