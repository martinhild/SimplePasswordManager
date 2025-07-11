using PasswordManagerApp.Services;

namespace SimplePasswordManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pnlGenerator_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkUpper_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {            
            int length = (int)nudLength.Value;
            bool useUpper = chkUpper.Checked;
            bool useDigits = chkDigits.Checked;
            bool useSpecial = chkSpecial.Checked;
            PasswordGenerator generator = new PasswordGenerator();
            txtGenerated.Text = new PasswordGenerator().Generate(length, useUpper, useDigits, useSpecial);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNewEntryTitle_Click(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }


        private void chkSpecial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkDigits_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nudLength_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
