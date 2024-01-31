namespace MyStoreWinApp
{
    partial class frmLogin
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
            lblEmail = new Label();
            lblPass = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 23);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(26, 52);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(57, 15);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(108, 20);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(164, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(108, 49);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(164, 23);
            txtPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(108, 88);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 130);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(lblPass);
            Controls.Add(lblEmail);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPass;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Button btnLogin;
    }
}