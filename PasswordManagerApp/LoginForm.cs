using PasswordManagerApp.Services;

namespace PasswordManagerApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtMasterPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var pw = txtMasterPassword.Text;
            var masterPwService = new MasterPasswordService();

            if (!masterPwService.IsMasterPasswordSet())
            {
                masterPwService.SetMasterPassword(pw);
                MessageBox.Show("Masterpasswort gespeichert. Bitte erneut anmelden.");
                return;
            }

            if (masterPwService.VerifyMasterPassword(pw))
            {
                this.Tag = pw; // Passwort „mitgeben“
                this.DialogResult = DialogResult.OK; // Login erfolgreich
                this.Close();
            }
            else
            {
                MessageBox.Show("Falsches Masterpasswort.");
            }
        }

        private void txtMasterPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_masterPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
