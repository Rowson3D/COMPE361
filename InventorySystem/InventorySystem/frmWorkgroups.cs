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
    public partial class frmWorkgroups : Form
    {
        public frmWorkgroups()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void frmWorkgroups_Load(object sender, EventArgs e)
        {
            UpdateUserList();
        }
        public void UpdateUserList()
        {
            config.Load_DTG("SELECT users_id as 'ID' , users_name as 'Name', users_type as 'Type', users_wg as 'Workgroup' from tbl_Users", dtgListWG);
        }

        private void dtgListWG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // On selected row, get the name and populate the textbox called txtName
            // Get the workgroup and populate the combobox called cboType.
            // Do not use the ID or Type for anything.
            txtName.Text = dtgListWG.CurrentRow.Cells[1].Value.ToString();
            cboType.Text = dtgListWG.CurrentRow.Cells[3].Value.ToString();

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // btnUpdate will get txtName and cboType and update the database.
            // It will also update the datagridview.
            // It will also clear the textbox and combobox.

            // Get the ID of the selected row.
            string id = dtgListWG.CurrentRow.Cells[0].Value.ToString();


            // Update the database.
            sql = "UPDATE tbl_Users SET users_name = '" + txtName.Text + "', users_wg = '" + cboType.Text + "' WHERE users_id = '" + id + "'";
            config.Execute_Query(sql);


            // Update the datagridview.
            UpdateUserList();


            // Clear the textbox and combobox.
            txtName.Clear();
            cboType.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            // This button will clear all the textboxes and comboboxes.
            txtName.Clear();
            cboType.Text = "";
        }
    }
}
