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
    public partial class frmCustomer : Form
    {
        string sname, stype, sid, saddress, sphone, szip, semail;
        public frmCustomer(string name, string type, string id, string address, string phone, string zip, string email)
        {
            sname = name;
            stype = type;
            sid = id;
            saddress = address;
            sphone = phone;
            szip = zip;
            semail = email;
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            UpdateProdList();
            ShowUserInfo();
            InitializePaymentDates();
        }

        // Create a method that shows the logged in users information
        private void ShowUserInfo()
        {
            txtCustomerInfo.Text = "Name: " + sname;
            txtCustomerInfo.Text += "\r\nAddress: " + saddress;
            txtCustomerInfo.Text += "\r\nZip: " + szip;
            txtCustomerInfo.Text += "\r\nE-mail: " + semail;
            txtCustomerInfo.Text += "\r\nPhone: " + funct.FormatPhoneNumber(sphone); // Formats phone #
            txtCustomerInfo.Text += "\r\nCustomer Level: " + funct.GetName(stype);
            txtCustomerInfo.Text += "\r\nCustomer Number: " + sid;

        }


        // Create a method that populates cboMonth and cboYear
        // cboMonth will be Jan - Dec
        // cboYear will be the current year - 20 years
        private void InitializePaymentDates()
        {

            // Populate cboYear
            int year = DateTime.Now.Year;
            for (int i = 0; i < 20; i++)
            {
                cboYear.Items.Add(year);
                year++;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // This button will log the user out
            this.Close();

        }


        // Used for order generation //
        double total { get; set; }
        double shipping { get; set; }
        double tax { get; set; }
        double subtotal { get; set; }
        //                           //


        private void btnOrder_Click(object sender, EventArgs e)
        {   
                string order_id = funct.GenerateOrderNumber();
                string order_name = sname;
                string order_address = saddress;
                string order_shipper = funct.GetShipper();
                string order_date = funct.GetDate();
                // Using GetLastFourDigits to get last four digits of the credit card number
                int order_cc = Convert.ToInt32(funct.getLastFourDigits(txtCC.Text));
                // create string order_month and pad it with zeros if less than 10
                string order_month = Convert.ToString(cboMonth.SelectedIndex + 1);
                if (order_month.Length < 2)
                {
                    order_month = "0" + order_month;
                }
                // Using GetYear, to get the year from the cboYear
                int order_year = Convert.ToInt32(funct.getYear(cboYear));
                string order_exp = (order_month + "" + order_year);
                
                sql = "INSERT INTO tbl_Order_Details (order_id, order_name, order_address, order_shipper, order_total, order_shipping, order_date, order_cc, order_exp) VALUES ('" + order_id + "', '" + order_name + "', '" + order_address + "', '" + order_shipper + "', '" + total + "', '" + shipping + "', '" + order_date + "', '" + order_cc + "', '" + order_exp + "')";
                config.Execute_Query(sql);
                // Insert the items into the tbl_Order_Items table.
                // The four columns are: id, item, qty, price
                // The contents from dtgCart will be inserted into the tbl_Order_Items table.
                // id will be the order_id generated above.
                // item will be the product name
                // qty will be the quantity of the product as an integer
                // price will be the price of the product as a double
                // Ignore the last row of the dtgCart.
                for (int i = 0; i < dtgCart.Rows.Count; i++)
                {
                    string item = dtgCart.Rows[i].Cells[1].Value.ToString();
                    int qty = Convert.ToInt32(dtgCart.Rows[i].Cells[5].Value);
                    double price = Convert.ToDouble(dtgCart.Rows[i].Cells[4].Value);
                    sql = "INSERT INTO tbl_Order_Items (order_id, item, qty, price) VALUES ('" + order_id + "', '" + item + "', '" + qty + "', '" + price + "')";
                    config.Execute_Query(sql);
                }
                // Update the quantity of the prod_quan and prod_name is the tbl_Products from the dtgInventory.
                // The quantity of the product will be updated by the quantity of the product in the dtgInventory.
                // Product name is just used for comparison.
                for (int i = 0; i < dtgInventory.Rows.Count; i++)
                {
                    // declare prod_id as int
                    int prod_id = Convert.ToInt32(dtgInventory.Rows[i].Cells[0].Value);
                    int prod_quan = Convert.ToInt32(dtgInventory.Rows[i].Cells[5].Value);
                    // the sql command will contain apostrophes, avoid s in syntax error
                    sql = "UPDATE tbl_Products SET prod_quan = '" + prod_quan + "' WHERE prod_id = '" + prod_id + "'";
                    config.Execute_Query(sql);
                }

                // Create a messagebox that will display the order number and the email address of the customer
                // Make the messagebox a success message
                MessageBox.Show("Order #" + order_id + " has been placed.\r\n" + "Your order will be shipped to " + saddress + ".\nPlease check " + semail + ".", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateProdList();
                // Now clear the cart
                ClearCart();
        }
        // Create a method that will update the Tax and Total labels called lblTax and lblTotal
        // First calculate the subtotal using dtgCart price * dtgCart quantity
        // Then calculate the tax using the subtotal * 0.06
        // Then calculate the total using the subtotal + tax

        private void ClearCart()
        {
            dtgCart.Rows.Clear();
            lblTax.Text = "$0.00";
            lblTotal.Text = "$0.00";
            lblSubtotal.Text = "$0.00";
            lblShipping.Text = "$0.00";
        }
        
        public void UpdateTotal()
        {
            // for every instance of new row or updated quantity, calculate the new total
            // then update the lblTotal
            double subtotal = 0;
            for (int i = 0; i < dtgCart.Rows.Count; i++)
            {
                subtotal += Convert.ToDouble(dtgCart.Rows[i].Cells[4].Value) * Convert.ToInt32(dtgCart.Rows[i].Cells[5].Value);
            }

            tax = subtotal * 0.06;
            shipping = subtotal * 0.05;
            total = subtotal + tax;
            lblShipping.Text = shipping.ToString("C");
            lblSubtotal.Text = subtotal.ToString("C");
            lblTax.Text = tax.ToString("C");
            lblTotal.Text = total.ToString("C");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT prod_id as 'SKU', prod_name as 'Name', prod_desc as 'Description', prod_type as 'Type', prod_price as 'Price', prod_quan as 'Quantity', prod_dept as 'Department' from tbl_Products WHERE prod_id LIKE '%" + txtSearch.Text + "%'  OR prod_name LIKE '%" + txtSearch.Text + "%' OR prod_desc LIKE '%" + txtSearch.Text + "%' OR prod_type LIKE '%" + txtSearch.Text + "%'";
            config.Load_DTG(sql, dtgInventory);
        }

        private void dtgCart_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dtgCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {

        }

        public void UpdateProdList()
        {
            config.Load_DTG("SELECT prod_id as 'SKU' , prod_name as 'Name', prod_desc as 'Description', prod_type as 'Type', prod_price as 'Price', prod_quan as 'Quantity', prod_dept as 'Department' from tbl_Products", dtgInventory);
        }

        // Create a new method initializes columns in dtgCart
        public void InitializeColumns()
        {
            dtgCart.Columns.Add("SKU", "SKU");
            dtgCart.Columns.Add("Name", "Name");
            dtgCart.Columns.Add("Description", "Description");
            dtgCart.Columns.Add("Type", "Type");
            dtgCart.Columns.Add("Price", "Price");
            dtgCart.Columns.Add("Quantity", "Quantity");
            dtgCart.Columns.Add("Packaging", "Packaging");
        }
        private void dtgInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add the selected row from dtgInventory to dtgCart
            // If the row already exists in dtgCart, then update the quantity
            // Otherwise, add the row to dtgCart
            // Don't forget to -1 from the quantity in dtgInventory
            // If the quantity is 0 in dtgInventory, prompt the user with a messagebox
            // Notify the user if the quantity is 0 in dtgInventory
            if (dtgInventory.SelectedRows.Count > 0)
            {
                string sku = dtgInventory.SelectedRows[0].Cells[0].Value.ToString();
                string name = dtgInventory.SelectedRows[0].Cells[1].Value.ToString();
                string desc = dtgInventory.SelectedRows[0].Cells[2].Value.ToString();
                string type = dtgInventory.SelectedRows[0].Cells[3].Value.ToString();
                string price = dtgInventory.SelectedRows[0].Cells[4].Value.ToString();
                string quan = dtgInventory.SelectedRows[0].Cells[5].Value.ToString();
                string unit = dtgInventory.SelectedRows[0].Cells[6].Value.ToString();
                int qty = Convert.ToInt32(quan);
                if (qty == 0)
                {
                    MessageBox.Show("Sorry, " + name + " is out of stock.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool found = false;
                    for (int i = 0; i < dtgCart.Rows.Count; i++)
                    {
                        if (dtgCart.Rows[i].Cells[0].Value.ToString() == sku)
                        {
                            found = true;
                            dtgCart.Rows[i].Cells[5].Value = Convert.ToInt32(dtgCart.Rows[i].Cells[5].Value) + 1;
                            break;
                        }
                    }
                    if (!found)
                    {
                        dtgCart.Rows.Add(sku, name, desc, type, price, 1, unit);
                    }
                    qty--;
                    dtgInventory.Rows[dtgInventory.SelectedRows[0].Index].Cells[5].Value = qty;
                    UpdateTotal();
                }
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // This button is similar to btnAdd, but instead of sending it to dtgCart, it sends the item to dtgInventory
            // If the quantity is 1, remove the row from dtgCart
            // Otherwise, update the quantity in dtgCart
            // The item being updated must have the same SKU id as the item being removed

            if (dtgCart.SelectedRows.Count > 0)
            {
                string sku = dtgCart.SelectedRows[0].Cells[0].Value.ToString();
                string name = dtgCart.SelectedRows[0].Cells[1].Value.ToString();
                string desc = dtgCart.SelectedRows[0].Cells[2].Value.ToString();
                string type = dtgCart.SelectedRows[0].Cells[3].Value.ToString();
                string price = dtgCart.SelectedRows[0].Cells[4].Value.ToString();
                string quan = dtgCart.SelectedRows[0].Cells[5].Value.ToString();
                string unit = dtgCart.SelectedRows[0].Cells[6].Value.ToString();
                int qty = Convert.ToInt32(quan);
                if (qty == 1)
                {
                    dtgCart.Rows.RemoveAt(dtgCart.SelectedRows[0].Index);
                }
                else
                {
                    qty--;
                    dtgCart.Rows[dtgCart.SelectedRows[0].Index].Cells[5].Value = qty;
                }
                qty++;
                for (int i = 0; i < dtgInventory.Rows.Count; i++)
                {
                    if (dtgInventory.Rows[i].Cells[0].Value.ToString() == sku)
                    {
                        // Now convert dtgInventory to int and add 1
                        dtgInventory.Rows[i].Cells[5].Value = Convert.ToInt32(dtgInventory.Rows[i].Cells[5].Value) + 1;
                        break;
                    }
                }
                UpdateTotal();
            }
        }
    }
}
