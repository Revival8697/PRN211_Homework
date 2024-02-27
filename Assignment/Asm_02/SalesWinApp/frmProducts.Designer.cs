namespace SalesWinApp
{
    partial class frmProducts
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
            dgvProducts = new DataGridView();
            lbProductId = new Label();
            lbProductName = new Label();
            lbCategoryId = new Label();
            lbWeight = new Label();
            lbUnitPrice = new Label();
            lbUnitsInStock = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtProductName = new TextBox();
            txtWeight = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitsInStock = new TextBox();
            txtCategoryId = new TextBox();
            gbOrder = new GroupBox();
            btnOrder = new Button();
            label8 = new Label();
            tcProducts = new TabControl();
            tpMain = new TabPage();
            txtProductId = new TextBox();
            tpFilter = new TabPage();
            btnClear = new Button();
            btnSearch = new Button();
            label6 = new Label();
            txtMaxUnit = new TextBox();
            txtMinUnit = new TextBox();
            txtMaxPrice = new TextBox();
            txtMinPrice = new TextBox();
            txtKeyword = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tpOrder = new TabPage();
            txtTotalPrice = new TextBox();
            label10 = new Label();
            btnRemoveOrderedProduct = new Button();
            btnSubmitOrder = new Button();
            dgvOrderProducts = new DataGridView();
            txtQuantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            gbOrder.SuspendLayout();
            tcProducts.SuspendLayout();
            tpMain.SuspendLayout();
            tpFilter.SuspendLayout();
            tpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(16, 263);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1040, 226);
            dgvProducts.TabIndex = 1;
            // 
            // lbProductId
            // 
            lbProductId.AutoSize = true;
            lbProductId.Location = new Point(19, 12);
            lbProductId.Name = "lbProductId";
            lbProductId.Size = new Size(77, 20);
            lbProductId.TabIndex = 0;
            lbProductId.Text = "Product Id";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(19, 117);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(104, 20);
            lbProductName.TabIndex = 1;
            lbProductName.Text = "Product Name";
            // 
            // lbCategoryId
            // 
            lbCategoryId.AutoSize = true;
            lbCategoryId.Location = new Point(19, 58);
            lbCategoryId.Name = "lbCategoryId";
            lbCategoryId.Size = new Size(86, 20);
            lbCategoryId.TabIndex = 2;
            lbCategoryId.Text = "Category Id";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(420, 12);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(56, 20);
            lbWeight.TabIndex = 3;
            lbWeight.Text = "Weight";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(420, 58);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 4;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(420, 120);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(98, 20);
            lbUnitsInStock.TabIndex = 5;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(142, 163);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(249, 163);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(420, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(142, 113);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(201, 27);
            txtProductName.TabIndex = 8;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(563, 12);
            txtWeight.Name = "txtWeight";
            txtWeight.ReadOnly = true;
            txtWeight.Size = new Size(145, 27);
            txtWeight.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(563, 58);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(145, 27);
            txtUnitPrice.TabIndex = 10;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(563, 117);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.ReadOnly = true;
            txtUnitsInStock.Size = new Size(145, 27);
            txtUnitsInStock.TabIndex = 11;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(142, 58);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.ReadOnly = true;
            txtCategoryId.Size = new Size(150, 27);
            txtCategoryId.TabIndex = 16;
            // 
            // gbOrder
            // 
            gbOrder.Controls.Add(txtQuantity);
            gbOrder.Controls.Add(btnOrder);
            gbOrder.Controls.Add(label8);
            gbOrder.Location = new Point(744, 19);
            gbOrder.Name = "gbOrder";
            gbOrder.Size = new Size(246, 149);
            gbOrder.TabIndex = 19;
            gbOrder.TabStop = false;
            gbOrder.Text = "Order";
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(77, 89);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 15;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 41);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 18;
            label8.Text = "Quantity";
            // 
            // tcProducts
            // 
            tcProducts.Controls.Add(tpMain);
            tcProducts.Controls.Add(tpFilter);
            tcProducts.Controls.Add(tpOrder);
            tcProducts.Location = new Point(12, 12);
            tcProducts.Name = "tcProducts";
            tcProducts.SelectedIndex = 0;
            tcProducts.Size = new Size(1044, 249);
            tcProducts.TabIndex = 0;
            // 
            // tpMain
            // 
            tpMain.Controls.Add(txtProductId);
            tpMain.Controls.Add(gbOrder);
            tpMain.Controls.Add(txtCategoryId);
            tpMain.Controls.Add(txtUnitsInStock);
            tpMain.Controls.Add(txtUnitPrice);
            tpMain.Controls.Add(txtWeight);
            tpMain.Controls.Add(txtProductName);
            tpMain.Controls.Add(btnDelete);
            tpMain.Controls.Add(btnUpdate);
            tpMain.Controls.Add(btnCreate);
            tpMain.Controls.Add(lbUnitsInStock);
            tpMain.Controls.Add(lbUnitPrice);
            tpMain.Controls.Add(lbWeight);
            tpMain.Controls.Add(lbCategoryId);
            tpMain.Controls.Add(lbProductName);
            tpMain.Controls.Add(lbProductId);
            tpMain.Location = new Point(4, 29);
            tpMain.Name = "tpMain";
            tpMain.Padding = new Padding(3);
            tpMain.Size = new Size(1036, 216);
            tpMain.TabIndex = 0;
            tpMain.Text = "Main";
            tpMain.UseVisualStyleBackColor = true;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(142, 9);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(150, 27);
            txtProductId.TabIndex = 20;
            // 
            // tpFilter
            // 
            tpFilter.Controls.Add(btnClear);
            tpFilter.Controls.Add(btnSearch);
            tpFilter.Controls.Add(label6);
            tpFilter.Controls.Add(txtMaxUnit);
            tpFilter.Controls.Add(txtMinUnit);
            tpFilter.Controls.Add(txtMaxPrice);
            tpFilter.Controls.Add(txtMinPrice);
            tpFilter.Controls.Add(txtKeyword);
            tpFilter.Controls.Add(label5);
            tpFilter.Controls.Add(label4);
            tpFilter.Controls.Add(label3);
            tpFilter.Controls.Add(label2);
            tpFilter.Location = new Point(4, 29);
            tpFilter.Name = "tpFilter";
            tpFilter.Padding = new Padding(3);
            tpFilter.Size = new Size(1036, 216);
            tpFilter.TabIndex = 1;
            tpFilter.Text = "Filter";
            tpFilter.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(253, 79);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear All";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(116, 79);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(772, 79);
            label6.Name = "label6";
            label6.Size = new Size(23, 20);
            label6.TabIndex = 11;
            label6.Text = "to";
            // 
            // txtMaxUnit
            // 
            txtMaxUnit.Location = new Point(813, 72);
            txtMaxUnit.Name = "txtMaxUnit";
            txtMaxUnit.Size = new Size(125, 27);
            txtMaxUnit.TabIndex = 10;
            // 
            // txtMinUnit
            // 
            txtMinUnit.Location = new Point(603, 72);
            txtMinUnit.Name = "txtMinUnit";
            txtMinUnit.Size = new Size(125, 27);
            txtMinUnit.TabIndex = 9;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(813, 31);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(160, 27);
            txtMaxPrice.TabIndex = 5;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(603, 31);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(150, 27);
            txtMinPrice.TabIndex = 4;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(138, 31);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(231, 27);
            txtKeyword.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 79);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 8;
            label5.Text = "Units In Stock from";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(772, 34);
            label4.Name = "label4";
            label4.Size = new Size(23, 20);
            label4.TabIndex = 7;
            label4.Text = "to";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 34);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 6;
            label3.Text = "Price from";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 34);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 3;
            label2.Text = "Product Name";
            // 
            // tpOrder
            // 
            tpOrder.Controls.Add(txtTotalPrice);
            tpOrder.Controls.Add(label10);
            tpOrder.Controls.Add(btnRemoveOrderedProduct);
            tpOrder.Controls.Add(btnSubmitOrder);
            tpOrder.Controls.Add(dgvOrderProducts);
            tpOrder.Location = new Point(4, 29);
            tpOrder.Name = "tpOrder";
            tpOrder.Size = new Size(1036, 216);
            tpOrder.TabIndex = 2;
            tpOrder.Text = "Order";
            tpOrder.UseVisualStyleBackColor = true;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(829, 20);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(168, 27);
            txtTotalPrice.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(726, 23);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 4;
            label10.Text = "TotalPrice:";
            // 
            // btnRemoveOrderedProduct
            // 
            btnRemoveOrderedProduct.Font = new Font("Segoe UI", 9F);
            btnRemoveOrderedProduct.ForeColor = Color.Black;
            btnRemoveOrderedProduct.Location = new Point(791, 96);
            btnRemoveOrderedProduct.Name = "btnRemoveOrderedProduct";
            btnRemoveOrderedProduct.Size = new Size(125, 29);
            btnRemoveOrderedProduct.TabIndex = 3;
            btnRemoveOrderedProduct.Text = "Remove";
            btnRemoveOrderedProduct.UseVisualStyleBackColor = true;
            // 
            // btnSubmitOrder
            // 
            btnSubmitOrder.ForeColor = Color.Black;
            btnSubmitOrder.Location = new Point(791, 146);
            btnSubmitOrder.Name = "btnSubmitOrder";
            btnSubmitOrder.Size = new Size(118, 29);
            btnSubmitOrder.TabIndex = 2;
            btnSubmitOrder.Text = "Submit Order";
            btnSubmitOrder.UseVisualStyleBackColor = true;
            // 
            // dgvOrderProducts
            // 
            dgvOrderProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderProducts.Location = new Point(13, 13);
            dgvOrderProducts.Name = "dgvOrderProducts";
            dgvOrderProducts.ReadOnly = true;
            dgvOrderProducts.RowHeadersWidth = 51;
            dgvOrderProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderProducts.Size = new Size(687, 192);
            dgvOrderProducts.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(77, 38);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(145, 27);
            txtQuantity.TabIndex = 21;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 507);
            Controls.Add(tcProducts);
            Controls.Add(dgvProducts);
            Name = "frmProducts";
            Text = "Products Management";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            gbOrder.ResumeLayout(false);
            gbOrder.PerformLayout();
            tcProducts.ResumeLayout(false);
            tpMain.ResumeLayout(false);
            tpMain.PerformLayout();
            tpFilter.ResumeLayout(false);
            tpFilter.PerformLayout();
            tpOrder.ResumeLayout(false);
            tpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvProducts;
        private GroupBox gbOrder;
        private Button btnOrder;
        private Label label8;
        private TextBox txtCategoryId;
        private TextBox txtUnitsInStock;
        private TextBox txtUnitPrice;
        private TextBox txtWeight;
        private TextBox txtProductName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnCreate;
        private Label lbUnitsInStock;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Label lbCategoryId;
        private Label lbProductName;
        private Label lbProductId;
        private TabControl tcProducts;
        private TabPage tpMain;
        private TabPage tpFilter;
        private Button btnClear;
        private Button btnSearch;
        private Label label6;
        private TextBox txtMaxUnit;
        private TextBox txtMinUnit;
        private TextBox txtMaxPrice;
        private TextBox txtMinPrice;
        private TextBox txtKeyword;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tpOrder;
        private TextBox txtTotalPrice;
        private Label label10;
        private Button btnRemoveOrderedProduct;
        private Button btnSubmitOrder;
        private DataGridView dgvOrderProducts;
        private TextBox txtProductId;
        private TextBox txtQuantity;
    }
}