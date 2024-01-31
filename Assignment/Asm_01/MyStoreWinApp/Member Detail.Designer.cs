namespace MyStoreWinApp
{
    partial class frmMemberDetail
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
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMemberId = new TextBox();
            txtMemberName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(157, 228);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 1;
            label1.Text = "Member ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 2;
            label2.Text = "Member Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 89);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 122);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 155);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 5;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 188);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 6;
            label6.Text = "City";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(157, 20);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(238, 27);
            txtMemberId.TabIndex = 7;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(157, 53);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(238, 27);
            txtMemberName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(157, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(157, 119);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(238, 27);
            txtPassword.TabIndex = 10;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(157, 152);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(238, 27);
            txtCountry.TabIndex = 11;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(157, 185);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(238, 27);
            txtCity.TabIndex = 12;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 267);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Name = "frmMemberDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMemberId;
        private TextBox txtMemberName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCountry;
        private TextBox txtCity;
    }
}