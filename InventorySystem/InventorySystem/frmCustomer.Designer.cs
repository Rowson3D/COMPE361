namespace InventorySystem
{
    partial class frmCustomer
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
            this.dtgInventory = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotalLbl = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTaxlbl = new System.Windows.Forms.Label();
            this.lblShippinglbl = new System.Windows.Forms.Label();
            this.lblTotallbl = new System.Windows.Forms.Label();
            this.dtgCart = new System.Windows.Forms.DataGridView();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Packaging = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInventory
            // 
            this.dtgInventory.AllowUserToAddRows = false;
            this.dtgInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInventory.Location = new System.Drawing.Point(12, 82);
            this.dtgInventory.Name = "dtgInventory";
            this.dtgInventory.ReadOnly = true;
            this.dtgInventory.RowHeadersVisible = false;
            this.dtgInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInventory.Size = new System.Drawing.Size(394, 253);
            this.dtgInventory.TabIndex = 1;
            this.dtgInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInventory_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Contact Information";
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Enabled = false;
            this.txtCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCustomerInfo.Location = new System.Drawing.Point(6, 19);
            this.txtCustomerInfo.Multiline = true;
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.Size = new System.Drawing.Size(259, 163);
            this.txtCustomerInfo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboYear);
            this.groupBox2.Controls.Add(this.cboMonth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCVV);
            this.groupBox2.Controls.Add(this.txtCC);
            this.groupBox2.Location = new System.Drawing.Point(289, 394);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 188);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Payment Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(92, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "/";
            // 
            // cboYear
            // 
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(112, 103);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(73, 28);
            this.cboYear.TabIndex = 6;
            // 
            // cboMonth
            // 
            this.cboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cboMonth.Location = new System.Drawing.Point(6, 103);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(80, 28);
            this.cboMonth.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(199, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "CVV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Expiration Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Credit Card:";
            // 
            // txtCVV
            // 
            this.txtCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCVV.Location = new System.Drawing.Point(203, 105);
            this.txtCVV.MaxLength = 3;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(61, 26);
            this.txtCVV.TabIndex = 7;
            // 
            // txtCC
            // 
            this.txtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCC.Location = new System.Drawing.Point(6, 39);
            this.txtCC.MaxLength = 16;
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(258, 26);
            this.txtCC.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiscount);
            this.groupBox3.Controls.Add(this.lblSubtotal);
            this.groupBox3.Controls.Add(this.lblTax);
            this.groupBox3.Controls.Add(this.lblShipping);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblSubtotalLbl);
            this.groupBox3.Controls.Add(this.txtCode);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblTaxlbl);
            this.groupBox3.Controls.Add(this.lblShippinglbl);
            this.groupBox3.Controls.Add(this.lblTotallbl);
            this.groupBox3.Location = new System.Drawing.Point(566, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 188);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total:";
            // 
            // btnDiscount
            // 
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnDiscount.Location = new System.Drawing.Point(180, 39);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(72, 26);
            this.btnDiscount.TabIndex = 10;
            this.btnDiscount.Text = "Apply";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSubtotal.Location = new System.Drawing.Point(90, 74);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(49, 20);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "$0.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTax.Location = new System.Drawing.Point(90, 103);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(49, 20);
            this.lblTax.TabIndex = 8;
            this.lblTax.Text = "$0.00";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblShipping.Location = new System.Drawing.Point(90, 133);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(49, 20);
            this.lblShipping.TabIndex = 7;
            this.lblShipping.Text = "$0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTotal.Location = new System.Drawing.Point(90, 164);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "$0.00";
            // 
            // lblSubtotalLbl
            // 
            this.lblSubtotalLbl.AutoSize = true;
            this.lblSubtotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSubtotalLbl.Location = new System.Drawing.Point(6, 74);
            this.lblSubtotalLbl.Name = "lblSubtotalLbl";
            this.lblSubtotalLbl.Size = new System.Drawing.Size(80, 20);
            this.lblSubtotalLbl.TabIndex = 5;
            this.lblSubtotalLbl.Text = "Subtotal: ";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCode.Location = new System.Drawing.Point(10, 39);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(164, 26);
            this.txtCode.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Discount Code:";
            // 
            // lblTaxlbl
            // 
            this.lblTaxlbl.AutoSize = true;
            this.lblTaxlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTaxlbl.Location = new System.Drawing.Point(6, 103);
            this.lblTaxlbl.Name = "lblTaxlbl";
            this.lblTaxlbl.Size = new System.Drawing.Size(41, 20);
            this.lblTaxlbl.TabIndex = 2;
            this.lblTaxlbl.Text = "Tax:";
            // 
            // lblShippinglbl
            // 
            this.lblShippinglbl.AutoSize = true;
            this.lblShippinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblShippinglbl.Location = new System.Drawing.Point(6, 133);
            this.lblShippinglbl.Name = "lblShippinglbl";
            this.lblShippinglbl.Size = new System.Drawing.Size(78, 20);
            this.lblShippinglbl.TabIndex = 1;
            this.lblShippinglbl.Text = "Shipping:";
            // 
            // lblTotallbl
            // 
            this.lblTotallbl.AutoSize = true;
            this.lblTotallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTotallbl.Location = new System.Drawing.Point(6, 164);
            this.lblTotallbl.Name = "lblTotallbl";
            this.lblTotallbl.Size = new System.Drawing.Size(51, 20);
            this.lblTotallbl.TabIndex = 0;
            this.lblTotallbl.Text = "Total:";
            // 
            // dtgCart
            // 
            this.dtgCart.AllowUserToAddRows = false;
            this.dtgCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtgCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.Name,
            this.Description,
            this.Type,
            this.Price,
            this.Quantity,
            this.Packaging});
            this.dtgCart.Location = new System.Drawing.Point(443, 37);
            this.dtgCart.Name = "dtgCart";
            this.dtgCart.RowHeadersVisible = false;
            this.dtgCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCart.Size = new System.Drawing.Size(394, 298);
            this.dtgCart.TabIndex = 8;
            this.dtgCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCart_CellClick);
            this.dtgCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCart_CellValueChanged);
            this.dtgCart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtgCart_KeyPress);
            // 
            // SKU
            // 
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Packaging
            // 
            this.Packaging.HeaderText = "Packaging";
            this.Packaging.Name = "Packaging";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(164, 21);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(79, 13);
            this.lblInventory.TabIndex = 9;
            this.lblInventory.Text = "Store Inventory";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(598, 21);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(73, 13);
            this.lblCart.TabIndex = 10;
            this.lblCart.Text = "Customer Cart";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(135, 602);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(271, 42);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(443, 602);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(271, 42);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtSearch.Location = new System.Drawing.Point(79, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(326, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(413, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(413, 197);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 656);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.dtgCart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgInventory);
            //this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgInventory;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox tbWelcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTaxlbl;
        private System.Windows.Forms.Label lblShippinglbl;
        private System.Windows.Forms.Label lblTotallbl;
        private System.Windows.Forms.DataGridView dtgCart;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubtotalLbl;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Packaging;
    }
}