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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void cbEmployee_CheckedChanged(object sender, EventArgs e)
        {
            // If checkbox is checked, the empCodeReg textbox is enabled
            // If checkbox is unchecked, the empCodeReg textbox is disabled
            if (cbEmployee.Checked)
            {
                empCodeReg.Enabled = true;
            }
            else
            {
                empCodeReg.Enabled = false;
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtVerify.Text != "")
            {
                if (cbEmployee.Checked)
                {
                    if (empCodeReg.Text == "123")
                    {
                        if (txtPassword.Text == txtVerify.Text)
                        {
                            // Write sqlite script to add new user to database
                            // Check if the user already exists
                            sql = "SELECT * FROM tbl_Users WHERE users_username = '" + txtUsername.Text + "'";
                            if (config.checkExists(sql))
                            {
                                MessageBox.Show("Username already exists");
                            }
                            else
                            {
                                // Add new user to database
                            sql = "INSERT INTO tbl_Users(users_name, users_username, users_pass, users_mail, users_type, users_wg, users_address, users_zip, users_phone) VALUES('"+ txtName.Text +"', '"+ txtUsername.Text +"', '"+ txtPassword.Text +"', '"+ txtEmail.Text + "', 1, 'Applicant', '"+ txtAddress.Text +"', '" + txtZip.Text + "', '"+ txtPhone.Text +"')";
                            config.Execute_CUD(sql, "Unable to save", txtName.Text + " has been registered successfully as a new applicant.");
                            this.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter an employee code");
                    }
                }
                else
                {
                    if (txtPassword.Text == txtVerify.Text)
                    {
                        // Check if the user already exists
                        sql = "SELECT * FROM tbl_Users WHERE users_username = '" + txtUsername.Text + "'";
                        if (config.checkExists(sql))
                        {
                            MessageBox.Show("Username already exists");
                        }
                        else
                        {
                            // Add new user to database
                        sql = "INSERT INTO tbl_Users(users_name, users_username, users_pass, users_mail, users_type, users_wg, users_address, users_zip, users_phone) VALUES('" + txtName.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "','" + txtEmail.Text +"', 0, 'Customer', '" + txtAddress.Text + "', '"+ txtZip.Text +"', '" + txtPhone.Text + "')";
                        config.Execute_CUD(sql, "Unable to save", txtName.Text +" has been registered successfully as a customer.");
                        this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a username and password");
            }
        }
    }
}
