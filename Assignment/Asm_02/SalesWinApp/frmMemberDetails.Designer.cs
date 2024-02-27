namespace SalesWinApp
{
    partial class frmMemberDetails
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
            txtPassword = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtEmail = new TextBox();
            txtCompanyName = new TextBox();
            label2 = new Label();
            lbEmail = new Label();
            lbCompanyName = new Label();
            lbPassword = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtMemberId = new TextBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(497, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(178, 27);
            txtPassword.TabIndex = 23;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(497, 77);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(178, 27);
            txtCity.TabIndex = 22;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(497, 27);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(178, 27);
            txtCountry.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(179, 77);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 27);
            txtEmail.TabIndex = 19;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(179, 131);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(183, 27);
            txtCompanyName.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 27);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 12;
            label2.Text = "Member Id";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(30, 84);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 13;
            lbEmail.Text = "Email";
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(30, 138);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(116, 20);
            lbCompanyName.TabIndex = 14;
            lbCompanyName.Text = "Company Name";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(407, 138);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 17;
            lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(407, 84);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 15;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(407, 27);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 16;
            lbCountry.Text = "Country";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(179, 194);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(296, 194);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(179, 27);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(183, 27);
            txtMemberId.TabIndex = 26;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 257);
            Controls.Add(txtMemberId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(txtEmail);
            Controls.Add(txtCompanyName);
            Controls.Add(label2);
            Controls.Add(lbEmail);
            Controls.Add(lbCompanyName);
            Controls.Add(lbPassword);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Name = "frmMemberDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtEmail;
        private TextBox txtCompanyName;
        private Label label2;
        private Label lbEmail;
        private Label lbCompanyName;
        private Label lbPassword;
        private Label lbCity;
        private Label lbCountry;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtMemberId;
    }
}