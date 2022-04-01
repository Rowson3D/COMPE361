namespace InventorySystem
{
    partial class frmMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSold = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.btnReports = new System.Windows.Forms.Button();
            this.tbEmpId = new System.Windows.Forms.TextBox();
            this.btnUsers = new System.Windows.Forms.Button();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnWorkgroups = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(228, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "User: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(745, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee Role: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(463, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee ID: ";
            // 
            // btnSold
            // 
            this.btnSold.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSold.Enabled = false;
            this.btnSold.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSold.Location = new System.Drawing.Point(391, 12);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(170, 41);
            this.btnSold.TabIndex = 4;
            this.btnSold.Text = "Order Lookup";
            this.btnSold.UseVisualStyleBackColor = false;
            this.btnSold.Click += new System.EventHandler(this.btnSold_Click);
            // 
            // tbUser
            // 
            this.tbUser.Enabled = false;
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbUser.Location = new System.Drawing.Point(280, 65);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(171, 23);
            this.tbUser.TabIndex = 9;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Lavender;
            this.btnReports.Enabled = false;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReports.Location = new System.Drawing.Point(919, 12);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(170, 41);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Print Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // tbEmpId
            // 
            this.tbEmpId.Enabled = false;
            this.tbEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbEmpId.Location = new System.Drawing.Point(564, 65);
            this.tbEmpId.Name = "tbEmpId";
            this.tbEmpId.Size = new System.Drawing.Size(171, 23);
            this.tbEmpId.TabIndex = 10;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Honeydew;
            this.btnUsers.Enabled = false;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsers.Location = new System.Drawing.Point(567, 12);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(170, 41);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Manage Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // tbRole
            // 
            this.tbRole.Enabled = false;
            this.tbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbRole.Location = new System.Drawing.Point(862, 65);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(171, 23);
            this.tbRole.TabIndex = 11;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1059, 65);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnWorkgroups
            // 
            this.btnWorkgroups.BackColor = System.Drawing.Color.PowderBlue;
            this.btnWorkgroups.Enabled = false;
            this.btnWorkgroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWorkgroups.Location = new System.Drawing.Point(743, 12);
            this.btnWorkgroups.Name = "btnWorkgroups";
            this.btnWorkgroups.Size = new System.Drawing.Size(170, 41);
            this.btnWorkgroups.TabIndex = 2;
            this.btnWorkgroups.Text = "Manage Workgroups";
            this.btnWorkgroups.UseVisualStyleBackColor = false;
            this.btnWorkgroups.Click += new System.EventHandler(this.btnWorkgroups_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnSold);
            this.panel1.Controls.Add(this.btnWorkgroups);
            this.panel1.Controls.Add(this.tbUser);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.tbEmpId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.tbRole);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-7, 771);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 104);
            this.panel1.TabIndex = 13;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.MistyRose;
            this.btnProduct.Enabled = false;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProduct.Location = new System.Drawing.Point(215, 12);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(170, 41);
            this.btnProduct.TabIndex = 13;
            this.btnProduct.Text = "Stock Management";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1342, 869);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.Text = "Inventory Management";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSold;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.TextBox tbEmpId;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.TextBox tbRole;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnWorkgroups;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProduct;
    }
}