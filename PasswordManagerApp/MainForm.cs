using PasswordManagerApp.Models;
using PasswordManagerApp.Services;

namespace SimplePasswordManager
{
    public partial class MainForm : Form
    {
        private readonly string _masterPassword;
        private DataGridViewRow? _lastDecryptedRow = null;


        // Konstruktor
        public MainForm(string masterPassword)
        {
            InitializeComponent();
            _masterPassword = masterPassword;
            this.Load += MainForm_Load; // Beim Start ausführen.
            dgvEntries.SelectionChanged += dgvEntries_SelectionChanged;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Daten aus Datenbank laden und ins Grid einfügen
            LoadEntriesToGrid();
        }


        private void LoadEntriesToGrid()
        {
            dgvEntries.DataSource = null;
            var entries = new DatabaseService().GetAllEntries();

            var displayEntries = entries.Select(entry => new PasswordEntryDisplay
            {
                Id = entry.Id,
                Description = entry.Description,
                Username = new string('*', entry.Username.Length),
                Password = new string('*', CryptoHelper.Decrypt(entry.EncryptedPassword, _masterPassword).Length)
            }).ToList();

            dgvEntries.DataSource = displayEntries;

            dgvEntries.Columns["Id"].Visible = false;
            dgvEntries.Columns["Description"].HeaderText = "Beschreibung";
            dgvEntries.Columns["Username"].HeaderText = "Benutzername";
            dgvEntries.Columns["Password"].HeaderText = "Passwort";
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

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }


        private void btnSaveEntry_Click(object sender, EventArgs e)
        {
            // Eingaben holen
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string description = txtDescription.Text;
            // Passwort Verschlüsseln
            string encrypted = CryptoHelper.Encrypt(password, _masterPassword);
            // Eingaben validieren
            if (!ValidationService.IsValidEntry(username, password, description, out string error))
            {
                MessageBox.Show(error);
                return;
            }
            // Eintrag erzeugen und anlegen
            PasswordEntry NewEntry = new PasswordEntry(username, encrypted, description);
            new DatabaseService().CreateEntry(NewEntry);
            // Grid aktualisieren
            LoadEntriesToGrid();
        }


        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            if (dgvEntries.SelectedRows.Count == 0)
            {
                MessageBox.Show("Keine Zeile zum Löschen ausgewählt.");
                return;
            }

            var selectedRow = dgvEntries.SelectedRows[0];

            // ID manuell auslesen
            if (selectedRow.Cells["Id"].Value is int id)
            {
                var entry = new DatabaseService().GetAllEntries().FirstOrDefault(e => e.Id == id);
                if (entry == null)
                {
                    MessageBox.Show("Eintrag nicht gefunden.");
                    return;
                }

                var confirm = MessageBox.Show(
                    $"Sind Sie sicher, dass Sie diesen Eintrag \"{entry.Description}\" löschen möchten?",
                    "Löschen bestätigen",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm != DialogResult.Yes)
                    return;

                new DatabaseService().DeleteEntry(entry.Id);
                LoadEntriesToGrid();
            }
        }


        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (dgvEntries.SelectedRows.Count == 0)
            {
                MessageBox.Show("Bitte einen Eintrag auswählen.");
                return;
            }

            var selectedRow = dgvEntries.SelectedRows[0];
            int id = (int)selectedRow.Cells["Id"].Value;

            var entry = new DatabaseService().GetAllEntries().FirstOrDefault(e => e.Id == id);
            if (entry == null) return;

            string decryptedPw = CryptoHelper.Decrypt(entry.EncryptedPassword, _masterPassword);

            selectedRow.Cells["Username"].Value = entry.Username;
            selectedRow.Cells["Password"].Value = decryptedPw;

            _lastDecryptedRow = selectedRow;
        }



        private void dgvEntries_SelectionChanged(object sender, EventArgs e)
        {
            if (_lastDecryptedRow != null)
            {
                // Alte Datenbank-ID holen
                int oldId = (int)_lastDecryptedRow.Cells["Id"].Value;

                // Originaldaten aus DB holen
                var entry = new DatabaseService().GetAllEntries().FirstOrDefault(e => e.Id == oldId);
                if (entry != null)
                {
                    _lastDecryptedRow.Cells["Username"].Value = new string('*', entry.Username.Length);
                    string decrypted = CryptoHelper.Decrypt(entry.EncryptedPassword, _masterPassword);
                    _lastDecryptedRow.Cells["Password"].Value = new string('*', decrypted.Length);
                }

                _lastDecryptedRow = null; // Reset
            }
        }



        private void dgvEntries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHideEntry_Click(object sender, EventArgs e)
        {
            // Wenn zuletzt entschlüsselter Eintrag existiert
            if (_lastDecryptedRow != null)
            {
                // ID auslesen
                if (_lastDecryptedRow.Cells["Id"].Value is int id)
                {
                    // Originaleintrag aus DB holen
                    var entry = new DatabaseService().GetAllEntries().FirstOrDefault(e => e.Id == id);
                    if (entry != null)
                    {
                        _lastDecryptedRow.Cells["Username"].Value = new string('*', entry.Username.Length);
                        string decrypted = CryptoHelper.Decrypt(entry.EncryptedPassword, _masterPassword);
                        _lastDecryptedRow.Cells["Password"].Value = new string('*', decrypted.Length);
                    }
                }

                _lastDecryptedRow = null; // zurücksetzen
            }
        }

        private void pnlEntryActions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblTitel_Click(object sender, EventArgs e)
        {

        }
    }
}
