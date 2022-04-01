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
    public partial class frmOrderLookup : Form
    {
        public frmOrderLookup()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void frmOrderLookup_Load(object sender, EventArgs e)
        {
            UpdateOrderList();
        }

        // Create a method called UpdateOrderList()
        // This method will populate the data grid view called dtgOrders with all the orders
        // from the database table tbl_Order_Details
        private void UpdateOrderList()
        {
            // Create a string variable called sql and set it to the following SQL statement
            // SELECT * FROM tbl_Order_Details
        config.Load_DTG("SELECT order_id as 'Order ID', order_name as 'Name', order_address as 'Address', order_shipper as 'Shipper', order_total as 'Total', order_shipping as 'Shipping Cost', order_date as 'Order Date', order_cc as 'Credit Card', order_exp as 'Expiration' from tbl_Order_Details", dtgOrders);
        }

        private void txtOrderNum_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT order_id as 'Order ID', order_name as 'Name', order_address as 'Address', order_shipper as 'Shipper', order_total as 'Total', order_shipping as 'Shipping Cost', order_date as 'Order Date', order_cc as 'Credit Card', order_exp as 'Expiration' from tbl_Order_Details where order_id like '%" + txtOrderNum.Text + "%'";
            config.Load_DTG(sql, dtgOrders);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT order_id as 'Order ID', order_name as 'Name', order_address as 'Address', order_shipper as 'Shipper', order_total as 'Total', order_shipping as 'Shipping Cost', order_date as 'Order Date', order_cc as 'Credit Card', order_exp as 'Expiration' from tbl_Order_Details where order_name like '%" + txtName.Text + "%'";
            config.Load_DTG(sql, dtgOrders);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT order_id as 'Order ID', order_name as 'Name', order_address as 'Address', order_shipper as 'Shipper', order_total as 'Total', order_shipping as 'Shipping Cost', order_date as 'Order Date', order_cc as 'Credit Card', order_exp as 'Expiration' from tbl_Order_Details where order_address like '%" + txtAddress.Text + "%'";
            config.Load_DTG(sql, dtgOrders);
        }

        private void dtgOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the order_id from the selected row.
            string order_id = dtgOrders.Rows[e.RowIndex].Cells[0].Value.ToString();

            // Now, with that order_id, get the order details from the database in the table tbl_Order_Items using the following rows:
            // order_id, item, qty, price
            // and populate the data grid view dtgOrderItems with the results
            sql = "SELECT order_id, item, qty, price from tbl_Order_Items where order_id = '" + order_id + "'";
            config.Load_DTG(sql, dtgOrderInfo);   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // This button will will be a cancel order button. It will first add the quantities of the products in the order back into the tbl_Produts table
            // Then it will delete the order from the tbl_Order_Details table
            // Then it will delete all the entries in tbl_Order_Items for that order.
            // Then it will update the dtgOrders data grid view with the new data.
            // Then it will clear the text boxes and the data grid views.

            // First, get the order_id from the selected row.
            string order_id = dtgOrders.Rows[dtgOrders.CurrentRow.Index].Cells[0].Value.ToString();
            
            // In dtgOrderInfo, get the item, qty, and price for each row associated with the order_id.
            // Then, for each row, add the qty to the tbl_Products table.
            // Then, delete the order from the tbl_Order_Details table.
            // Then, delete all the entries in tbl_Order_Items for that order.
            // Then, update the dtgOrders data grid view with the new data.
            // Then, clear the text boxes and the data grid views.
            // Ask if the user is sure they want to cancel the order.
            if (MessageBox.Show("Are you sure you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // For each row in dtgOrderInfo, get the item, qty, and price.
                // Then, add the qty to the tbl_Products table.
                foreach (DataGridViewRow row in dtgOrderInfo.Rows)
                {
                    // Get the item, qty, and price.
                    string item = row.Cells[1].Value.ToString();
                    int qty = Convert.ToInt32(row.Cells[2].Value);
                    double price = Convert.ToDouble(row.Cells[3].Value);

                    // Add the qty to the tbl_Products table.
                    config.Execute_Query("UPDATE tbl_Products SET prod_quan = prod_quan + " + qty + " WHERE prod_name = '" + item + "'");
                }

                // Delete the order from the tbl_Order_Details table.
                config.Execute_Query("DELETE FROM tbl_Order_Details WHERE order_id = '" + order_id + "'");

                // Delete all the entries in tbl_Order_Items for that order.
                config.Execute_Query("DELETE FROM tbl_Order_Items WHERE order_id = '" + order_id + "'");

                // Update the dtgOrders data grid view with the new data.
                UpdateOrderList();

                // Clear the text boxes and the data grid views.
                txtOrderNum.Clear();
                txtName.Clear();
                txtAddress.Clear();
                // Clear dtgOrderInfo
                dtgOrderInfo.DataSource = null;
            }            
        }
    }
}
