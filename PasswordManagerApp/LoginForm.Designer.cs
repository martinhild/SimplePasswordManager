namespace PasswordManagerApp
{
    partial class LoginForm
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
            txtMasterPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            lbl_masterPassword = new Label();
            SuspendLayout();
            // 
            // txtMasterPassword
            // 
            txtMasterPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtMasterPassword.Location = new Point(225, 196);
            txtMasterPassword.Name = "txtMasterPassword";
            txtMasterPassword.Size = new Size(300, 23);
            txtMasterPassword.TabIndex = 0;
            txtMasterPassword.UseSystemPasswordChar = true;
            txtMasterPassword.TextChanged += txtMasterPassword_TextChanged;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(318, 225);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(123, 19);
            chkShowPassword.TabIndex = 1;
            chkShowPassword.Text = "Passwort anzeigen";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(531, 196);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbl_masterPassword
            // 
            lbl_masterPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_masterPassword.AutoSize = true;
            lbl_masterPassword.Font = new Font("Segoe UI", 10F);
            lbl_masterPassword.Location = new Point(225, 161);
            lbl_masterPassword.Name = "lbl_masterPassword";
            lbl_masterPassword.Size = new Size(170, 19);
            lbl_masterPassword.TabIndex = 3;
            lbl_masterPassword.Text = "Masterpasswort eingeben:";
            lbl_masterPassword.TextAlign = ContentAlignment.MiddleCenter;
            lbl_masterPassword.Click += lbl_masterPassword_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_masterPassword);
            Controls.Add(btnLogin);
            Controls.Add(chkShowPassword);
            Controls.Add(txtMasterPassword);
            Name = "LoginForm";
            Text = "SimplePasswordManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMasterPassword;
        private CheckBox chkShowPassword;
        private Button btnLogin;
        private Label lbl_masterPassword;
    }
}