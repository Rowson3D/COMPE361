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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            // Set the focus to txtUsername
            txtbox_user.Focus();
            // Call timer1_Tick
            Timer1.Start();
        }

        string sql;
        SQLConfig config = new SQLConfig();

        // Create Timer1_Tick
        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        { 
            // Button gets the username and password from the text boxes
            // The username can be upper or lower case
            string username = txtbox_user.Text;
            string password = txtbox_pass.Text;
            // Create sql statement
            sql = "SELECT * FROM tbl_Users WHERE users_username = '" + username + "' AND users_pass = '" + password + "'";
            // Call SQLConfig.SQL_Query
            config.singleResult(sql);
            if(config.dt.Rows.Count > 0)
            {
                // Check if the user is type employee >= 1 or customer == 1
                // Open frmCustomer if user is customer
                // Open frmMenu if user is employee
                if (config.dt.Rows[0]["users_type"].ToString() == "1" || config.dt.Rows[0]["users_type"].ToString() == "2" || config.dt.Rows[0]["users_type"].ToString() == "3")
                {
                    frmMenu frm = new frmMenu(config.dt.Rows[0]["users_name"].ToString(), config.dt.Rows[0]["users_type"].ToString(), config.dt.Rows[0]["users_id"].ToString());
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    frmCustomer frm = new frmCustomer(config.dt.Rows[0]["users_name"].ToString(), config.dt.Rows[0]["users_type"].ToString(), config.dt.Rows[0]["users_id"].ToString(), config.dt.Rows[0]["users_address"].ToString(), config.dt.Rows[0]["users_phone"].ToString(), config.dt.Rows[0]["users_zip"].ToString(), config.dt.Rows[0]["users_mail"].ToString());
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                // If the user is not found, display an error message
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToShortDateString();

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        // Clicking this button opens frmRegister.cs
        {
            frmRegister register = new frmRegister();
            register.Show();
        }
    }
}
