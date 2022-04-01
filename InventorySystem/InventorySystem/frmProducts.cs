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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void frmProducts_Load(object sender, EventArgs e)
        {
            UpdateProdList();
        }

        public void UpdateProdList()
        {
            config.Load_DTG("SELECT prod_id as 'SKU' , prod_name as 'Name', prod_desc as 'Description', prod_type as 'Type', prod_price as 'Price', prod_quan as 'Quantity', prod_dept as 'Department', prod_ship as 'Ship Date', prod_vendor as 'Vendor' from tbl_Products", dtg_Products);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Create a search query that finds items like the text in the textbox based on all columns
            // The prod_id as 'SKU' format is 800-00-'SKU'
            sql = "SELECT prod_id as 'SKU' , prod_name as 'Name', prod_desc as 'Description', prod_type as 'Type', prod_price as 'Price', prod_quan as 'Quantity', prod_dept as 'Department' from tbl_Products where prod_name like '%" + txtSearch.Text + "%' or prod_desc like '%" + txtSearch.Text + "%' or prod_type like '%" + txtSearch.Text + "%' or prod_price like '%" + txtSearch.Text + "%' or prod_quan like '%" + txtSearch.Text + "%' or prod_dept like '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, dtg_Products);
        }

        private void dtg_Products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate the following textboxes with the selected item's data from dtg_Products
            // prod_sku, prod_name, prod_desc, prod_type, prod_price, prod_quan, prod_dept
            // The textboxes names are:
            // txtSku, txtName, txtDesc, cboCat, txtPrice, numQuan, cboDept
            txtSku.Text = dtg_Products.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dtg_Products.CurrentRow.Cells[1].Value.ToString();
            txtDesc.Text = dtg_Products.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dtg_Products.CurrentRow.Cells[4].Value.ToString();
            numQuan.Value = Convert.ToInt32(dtg_Products.CurrentRow.Cells[5].Value);
            // For prod_type Food = 0, Hardgoods = 1, Furniture = 2, Electronics = 3, Cars = 4, Softgoods = 5, Bicycle = 6, Other = 7
            if (dtg_Products.CurrentRow.Cells[3].Value.ToString() == "Glasses")
            {
                cboCat.SelectedIndex = 0;
            }
            else if (dtg_Products.CurrentRow.Cells[3].Value.ToString() == "Food")
            {
                cboCat.SelectedIndex = 1;
            }
            else if (dtg_Products.CurrentRow.Cells[3].Value.ToString() == "Jacket")
            {
                cboCat.SelectedIndex = 2;
            }
            else if (dtg_Products.CurrentRow.Cells[3].Value.ToString() == "Peripherals")
            {
                cboCat.SelectedIndex = 3;
            }
            else if (dtg_Products.CurrentRow.Cells[3].Value.ToString() == "Flask")
            {
                cboCat.SelectedIndex = 4;
            }
            else if (dtg_Products.CurrentRow.Cells[3].Value.ToString() == "Networking")
            {
                cboCat.SelectedIndex = 5;
            }
            else if (dtg_Products.CurrentRow.Cells[3].Value.ToString() == "Battery")
            {
                cboCat.SelectedIndex = 6;
            }
            else if (dtg_Products.CurrentRow.Cells[3].Value.ToString() == "Office")
            {
                cboCat.SelectedIndex = 7;
            }
            else if (dtg_Products.CurrentRow.Cells[3].Value.ToString() == "Knives")
            {
                cboCat.SelectedIndex = 7;
            }
            else if (dtg_Products.CurrentRow.Cells[3].Value.ToString() == "Microprocessor")
            {
                cboCat.SelectedIndex = 8;
            }

            if (dtg_Products.CurrentRow.Cells[6].Value.ToString() == "Hardgoods")
            {
                cboDept.SelectedIndex = 0;
            }
            else if (dtg_Products.CurrentRow.Cells[6].Value.ToString() == "Bakery")
            {
                cboDept.SelectedIndex = 1;
            }
            else if (dtg_Products.CurrentRow.Cells[6].Value.ToString() == "Clothing")
            {
                cboDept.SelectedIndex = 2;
            }
            else if (dtg_Products.CurrentRow.Cells[6].Value.ToString() == "Electronics")
            {
                cboDept.SelectedIndex = 3;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete the selected item from dtg_Products
            // The prod_id as 'SKU' format is 800-00-'SKU'
            // Confirm with the user if they want to delete the selected item
            if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE FROM tbl_Products WHERE prod_id = '" + txtSku.Text + "'";
                config.Execute_Query(sql);
                UpdateProdList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update the selected item from dtg_Products
            // The prod_id as 'SKU' format is 800-00-'SKU'
            sql = "UPDATE tbl_Products SET prod_name = '" + txtName.Text + "', prod_desc = '" + txtDesc.Text + "', prod_type = '" + cboCat.Text + "', prod_price = '" + txtPrice.Text + "', prod_quan = '" + numQuan.Value + "', prod_dept = '" + cboDept.Text + "' WHERE prod_id = '" + txtSku.Text + "'";
            config.Execute_Query(sql);
            UpdateProdList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // Get values from the textboxes, combo boxes and numeric up-down
            // txtSku, txtName, txtDesc, cboCat, txtPrice, numQuan, cboDept
            // The prod_id as 'SKU' format is 800-00-'SKU'
            sql = "INSERT INTO tbl_Products (prod_name, prod_desc, prod_type, prod_price, prod_quan, prod_dept) VALUES ('" + txtName.Text + "', '" + txtDesc.Text + "', '" + cboCat.Text + "', '" + txtPrice.Text + "', '" + numQuan.Value + "', '" + cboDept.Text + "')";
            config.Execute_Query(sql);
            UpdateProdList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
