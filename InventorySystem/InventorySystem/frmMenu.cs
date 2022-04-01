using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class frmMenu : Form
    {

        string sname, stype, sid;

        public frmMenu(string name, string type, string id)
        {
            sname = name;
            stype = type;
            sid = id;
            InitializeComponent();
        }

        // Create a showFrm method
        private void showFrm(Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Hide current and show frmLogin
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        // Create a closeForm method
        private void closeForm(Form frm)
        {
            foreach (Form f in this.MdiChildren)
            {
                    f.Close();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // Close all child forms
            closeForm(this);
            // Show frmReports
            showFrm(new frmReports());
        }

        private void btnStockMGMT_Click(object sender, EventArgs e)
        {
            // Close all child forms
            closeForm(this);
            // Show frmStock
            //showFrm(new frmStock());
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            // Close all child forms
            closeForm(this);
            // Show frmSold
            showFrm(new frmOrderLookup());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            // Close all child forms
            closeForm(this);
            // Show frmUsers
            showFrm(new frmUsers());
        }

        private void btnWorkgroups_Click(object sender, EventArgs e)
        {
            // Close all child forms
            closeForm(this);
            // Show frmWorkgroups
            showFrm(new frmWorkgroups());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            closeForm(this);
            showFrm(new frmProducts());
        }

        SQLConfig config = new SQLConfig();

        private void frmMenu_Load(object sender, EventArgs e)
        // Display the current user that is logged in
        {
            this.IsMdiContainer = true;
        

            tbUser.Text = sname;
            tbEmpId.Text = "I-" + sid;
            tbRole.Text = "E-" + stype;

            // If user is a manager or admin then enable all buttons
            if (stype == "2" || stype == "3")
            {
                btnReports.Enabled = true;
                btnSold.Enabled = true;
                btnUsers.Enabled = true;
                btnWorkgroups.Enabled = true;
                btnProduct.Enabled = true;
            }
            else
            {
                btnReports.Enabled = false;
                btnSold.Enabled = true;
                btnUsers.Enabled = false;
                btnWorkgroups.Enabled = false;
                btnProduct.Enabled = true;
            }
        }
    }
}
