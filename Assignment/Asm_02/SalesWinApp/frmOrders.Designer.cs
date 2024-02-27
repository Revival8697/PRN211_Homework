namespace SalesWinApp
{
    partial class frmOrders
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
            dgvOrders = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dtStartDate = new DateTimePicker();
            dtEndDate = new DateTimePicker();
            btnSearch = new Button();
            cbSort = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(12, 105);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(855, 257);
            dgvOrders.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 2;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 22);
            label2.Name = "label2";
            label2.Size = new Size(23, 20);
            label2.TabIndex = 3;
            label2.Text = "to";
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(78, 17);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(250, 27);
            dtStartDate.TabIndex = 4;
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new Point(398, 17);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(250, 27);
            dtEndDate.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(173, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(169, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cbSort
            // 
            cbSort.AutoSize = true;
            cbSort.Location = new Point(36, 73);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(116, 24);
            cbSort.TabIndex = 7;
            cbSort.Text = "Sort By Sales";
            cbSort.UseVisualStyleBackColor = true;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 375);
            Controls.Add(cbSort);
            Controls.Add(btnSearch);
            Controls.Add(dtEndDate);
            Controls.Add(dtStartDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvOrders);
            Name = "frmOrders";
            Text = "Order History";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrders;
        private Label label1;
        private Label label2;
        private DateTimePicker dtStartDate;
        private DateTimePicker dtEndDate;
        private Button btnSearch;
        private CheckBox cbSort;
    }
}