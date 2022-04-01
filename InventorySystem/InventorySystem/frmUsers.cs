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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtVerify.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtVerify.Text)
            {
                MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Check if username already exists
                sql = "SELECT * FROM tbl_Users WHERE users_username = '" + txtUsername.Text + "'";
                if (config.checkExists(sql))
                {
                    MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                // userType should get the index of the selected item
                int userType = cboType.SelectedIndex;
                sql = "INSERT INTO tbl_Users(users_name, users_username, users_pass, users_mail, users_type, users_wg, users_zip, users_address, users_phone) VALUES('" + txtName.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + txtEmail.Text + "', '" + userType + "', 0, '" + txtZip.Text + "' , '" + txtAddress.Text + "', '" + txtPhone.Text + "')";
                config.Execute_CUD(sql, "Unable to save", txtName.Text + " has been successfully added to the database.");
                funct.ClearTextBoxes(this);
                UpdateUserList();
                }
            }
        }

        // Create a method that updates the user list, no button clicks
        public void UpdateUserList()
        {
        config.Load_DTG("SELECT users_id as 'ID' , users_name as 'Name', users_username as 'Username', users_pass as 'Password', users_mail as 'E-mail', users_address as 'Address', users_zip as 'Zip Code', users_phone as 'Phone' ,users_type as 'Type' from tbl_Users", dtg_listUser);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete the selected user from the database
            if (dtg_listUser.SelectedRows.Count > 0)
            {
                int userID = Convert.ToInt32(dtg_listUser.SelectedRows[0].Cells[0].Value);
                sql = "DELETE FROM tbl_Users WHERE users_id = '" + userID + "'";
                config.Execute_CUD(sql, "Unable to delete", "The selected user has been successfully deleted.");
                funct.ClearTextBoxes(this);
                UpdateUserList();
            }
            else
            {
                MessageBox.Show("Please select a user to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            UpdateUserList();
        }

        private void dtg_listUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtg_listUser.Rows[e.RowIndex];
                txtName.Text = row.Cells[1].Value.ToString();
                txtUsername.Text = row.Cells[2].Value.ToString();
                txtPassword.Text = row.Cells[3].Value.ToString();
                txtVerify.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                txtAddress.Text = row.Cells[5].Value.ToString();
                txtZip.Text = row.Cells[6].Value.ToString();
                txtPhone.Text = row.Cells[7].Value.ToString();
                // Change combobox value based on the user type from the datagridview in column 6
                // Value 3 = Admin, Value 2 = Manager, Value 1 = Associate, Value 0 = Customer
                if (row.Cells[8].Value.ToString() == "3")
                {
                    cboType.SelectedIndex = 3;
                }
                else if (row.Cells[8].Value.ToString() == "2")
                {
                    cboType.SelectedIndex = 2;
                }
                else if (row.Cells[8].Value.ToString() == "1")
                {
                    cboType.SelectedIndex = 1;
                }
                else if (row.Cells[8].Value.ToString() == "0")
                {
                    cboType.SelectedIndex = 0;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update the selected user from the database
            // Make sure to check userType with the combo box
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtVerify.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtVerify.Text)
            {
                MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int userType = cboType.SelectedIndex;
                string id = dtg_listUser.CurrentRow.Cells[0].Value.ToString();
                // Update sqlite databse from textboxes
                sql = "UPDATE tbl_Users SET users_name = '" + txtName.Text + "', users_username = '" + txtUsername.Text + "', users_pass = '" + txtPassword.Text + "', users_mail = '" + txtEmail.Text + "', users_type = '" + userType + "', users_zip = '" + txtZip.Text + "',users_address = '" + txtAddress.Text + "' WHERE users_id = '" + id +"'";
                config.Execute_CUD(sql, "Unable to update", txtName.Text + " has been successfully updated.");
                funct.ClearTextBoxes(this);
                UpdateUserList();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            funct.ClearTextBoxes(this);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Search for the user in the database
            // This uses txtSearch to search for the user
            // The search is case insensitive
            sql = "SELECT users_id as 'ID' , users_name as 'Name', users_username as 'Username', users_pass as 'Password', users_address as 'Address', users_mail as 'E-mail', users_zip as 'Zip Code', users_phone as 'Phone' ,users_type as 'Type' from tbl_Users WHERE users_name LIKE '%" + txtSearch.Text + "%'  OR users_username LIKE '%" + txtSearch.Text + "%' OR users_address LIKE '%" + txtSearch.Text + "%' OR users_phone LIKE '%" + txtSearch.Text + "%' OR users_type LIKE '%" + txtSearch.Text + "%' OR users_zip LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, dtg_listUser);
            
        }
    }
}
