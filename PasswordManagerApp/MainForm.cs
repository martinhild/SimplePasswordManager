using PasswordManagerApp.Models;
using PasswordManagerApp.Services;

namespace SimplePasswordManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load; // Beim Start ausführen.
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Daten aus Datenbank laden und ins Grid einfügen
            LoadEntriesToGrid();
        }

        private void LoadEntriesToGrid()
        {
            dgvEntries.DataSource = null;
            dgvEntries.DataSource = new DatabaseService().GetAllEntries();
            // Spaltenreihenfolge:
            dgvEntries.Columns["Description"].DisplayIndex = 0;
            dgvEntries.Columns["Username"].DisplayIndex = 1;
            dgvEntries.Columns["EncryptedPassword"].DisplayIndex = 2;
            // Spalte "Id" ausblenden
            dgvEntries.Columns["Id"].Visible = false;
            // Optional: bessere Spaltennamen
            dgvEntries.Columns["Description"].HeaderText = "Beschreibung";
            dgvEntries.Columns["Username"].HeaderText = "Benutzername";
            dgvEntries.Columns["EncryptedPassword"].HeaderText = "Passwort";

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

        private void lblSavedTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveEntry_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string description = txtDescription.Text;


            PasswordEntry NewEntry = new PasswordEntry(username, password, description);
            new DatabaseService().CreateEntry(NewEntry);

            // Grid aktualisieren
            LoadEntriesToGrid();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pnlSavedEntries_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            // Prüfen, ob eine Zeile ausgewählt wurde
            if (dgvEntries.SelectedRows.Count == 0)
            {
                MessageBox.Show("Keine Zeile zum Löschen ausgewählt.");
                return; // Nichts tun
            }

            // Ausgewählte Zeile holen
            var selectedRow = dgvEntries.SelectedRows[0];

            // Prüfen, ob das DataBoundItem ein PasswordEntry ist
            if (selectedRow.DataBoundItem is PasswordEntry entry)
            {
                // Benutzer zur Bestätigung auffordern
                var confirm = MessageBox.Show(
                    $"Sind Sie sicher, dass Sie diesen Eintrag \"{entry.Description}\"löschen möchten?",
                    "Löschen bestätigen",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Wenn der Benutzer NICHT auf "Ja" klickt → abbrechen
                if (confirm != DialogResult.Yes)
                    return;

                // Eintrag aus der Datenbank löschen
                new DatabaseService().DeleteEntry(entry.Id);

                // Anzeige aktualisieren (Grid neu laden)
                LoadEntriesToGrid();
            }
        }

        private void pnlNewEntry_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
