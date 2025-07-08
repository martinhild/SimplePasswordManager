namespace SimplePasswordManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpMain = new TableLayoutPanel();
            tlpTop = new TableLayoutPanel();
            pnlGenerator = new Panel();
            txtGenerated = new TextBox();
            btnGenerate = new Button();
            chkSpecial = new CheckBox();
            chkDigits = new CheckBox();
            chkUpper = new CheckBox();
            lblLength = new Label();
            nudLength = new NumericUpDown();
            lblGeneratorTitle = new Label();
            pnlNewEntry = new Panel();
            chkShowPassword = new CheckBox();
            btnSaveEntry = new Button();
            txtDescription = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblNewEntryTitle = new Label();
            pnlSavedEntries = new Panel();
            lblSavedTitle = new Label();
            tlpMain.SuspendLayout();
            tlpTop.SuspendLayout();
            pnlGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLength).BeginInit();
            pnlNewEntry.SuspendLayout();
            pnlSavedEntries.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(tlpTop, 0, 0);
            tlpMain.Controls.Add(pnlSavedEntries, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.Size = new Size(800, 450);
            tlpMain.TabIndex = 0;
            // 
            // tlpTop
            // 
            tlpTop.ColumnCount = 2;
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTop.Controls.Add(pnlGenerator, 0, 0);
            tlpTop.Controls.Add(pnlNewEntry, 1, 0);
            tlpTop.Dock = DockStyle.Fill;
            tlpTop.Location = new Point(3, 3);
            tlpTop.Name = "tlpTop";
            tlpTop.RowCount = 1;
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTop.Size = new Size(794, 219);
            tlpTop.TabIndex = 0;
            // 
            // pnlGenerator
            // 
            pnlGenerator.BorderStyle = BorderStyle.FixedSingle;
            pnlGenerator.Controls.Add(txtGenerated);
            pnlGenerator.Controls.Add(btnGenerate);
            pnlGenerator.Controls.Add(chkSpecial);
            pnlGenerator.Controls.Add(chkDigits);
            pnlGenerator.Controls.Add(chkUpper);
            pnlGenerator.Controls.Add(lblLength);
            pnlGenerator.Controls.Add(nudLength);
            pnlGenerator.Controls.Add(lblGeneratorTitle);
            pnlGenerator.Dock = DockStyle.Fill;
            pnlGenerator.Location = new Point(3, 3);
            pnlGenerator.Name = "pnlGenerator";
            pnlGenerator.Size = new Size(391, 213);
            pnlGenerator.TabIndex = 0;
            pnlGenerator.Paint += pnlGenerator_Paint;
            // 
            // txtGenerated
            // 
            txtGenerated.Location = new Point(75, 164);
            txtGenerated.Name = "txtGenerated";
            txtGenerated.ReadOnly = true;
            txtGenerated.Size = new Size(202, 23);
            txtGenerated.TabIndex = 7;
            txtGenerated.TextChanged += textBox1_TextChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(75, 132);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(202, 23);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Passwort generieren";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // chkSpecial
            // 
            chkSpecial.AutoSize = true;
            chkSpecial.Location = new Point(157, 107);
            chkSpecial.Name = "chkSpecial";
            chkSpecial.Size = new Size(103, 19);
            chkSpecial.TabIndex = 5;
            chkSpecial.Text = "Sonderzeichen";
            chkSpecial.UseVisualStyleBackColor = true;
            chkSpecial.CheckedChanged += chkSpecial_CheckedChanged;
            // 
            // chkDigits
            // 
            chkDigits.AutoSize = true;
            chkDigits.Location = new Point(157, 82);
            chkDigits.Name = "chkDigits";
            chkDigits.Size = new Size(62, 19);
            chkDigits.TabIndex = 4;
            chkDigits.Text = "Zahlen";
            chkDigits.UseVisualStyleBackColor = true;
            chkDigits.CheckedChanged += chkDigits_CheckedChanged;
            // 
            // chkUpper
            // 
            chkUpper.AutoSize = true;
            chkUpper.Location = new Point(157, 57);
            chkUpper.Name = "chkUpper";
            chkUpper.Size = new Size(114, 19);
            chkUpper.TabIndex = 3;
            chkUpper.Text = "Großbuchstaben";
            chkUpper.UseVisualStyleBackColor = true;
            chkUpper.CheckedChanged += chkUpper_CheckedChanged;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(68, 30);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(83, 15);
            lblLength.TabIndex = 2;
            lblLength.Text = "Passwortlänge";
            lblLength.Click += label1_Click;
            // 
            // nudLength
            // 
            nudLength.Location = new Point(157, 28);
            nudLength.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            nudLength.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            nudLength.Name = "nudLength";
            nudLength.Size = new Size(120, 23);
            nudLength.TabIndex = 1;
            nudLength.Tag = "";
            nudLength.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // lblGeneratorTitle
            // 
            lblGeneratorTitle.AutoSize = true;
            lblGeneratorTitle.Dock = DockStyle.Top;
            lblGeneratorTitle.Location = new Point(0, 0);
            lblGeneratorTitle.Name = "lblGeneratorTitle";
            lblGeneratorTitle.Size = new Size(105, 15);
            lblGeneratorTitle.TabIndex = 0;
            lblGeneratorTitle.Text = "Passwortgenerator";
            // 
            // pnlNewEntry
            // 
            pnlNewEntry.BorderStyle = BorderStyle.FixedSingle;
            pnlNewEntry.Controls.Add(chkShowPassword);
            pnlNewEntry.Controls.Add(btnSaveEntry);
            pnlNewEntry.Controls.Add(txtDescription);
            pnlNewEntry.Controls.Add(txtPassword);
            pnlNewEntry.Controls.Add(label2);
            pnlNewEntry.Controls.Add(label1);
            pnlNewEntry.Controls.Add(lblUsername);
            pnlNewEntry.Controls.Add(txtUsername);
            pnlNewEntry.Controls.Add(lblNewEntryTitle);
            pnlNewEntry.Dock = DockStyle.Fill;
            pnlNewEntry.Location = new Point(400, 3);
            pnlNewEntry.Name = "pnlNewEntry";
            pnlNewEntry.Size = new Size(391, 213);
            pnlNewEntry.TabIndex = 1;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(123, 101);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(125, 19);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Text = "Passwort Anzeigen";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnSaveEntry
            // 
            btnSaveEntry.Location = new Point(72, 166);
            btnSaveEntry.Name = "btnSaveEntry";
            btnSaveEntry.Size = new Size(194, 23);
            btnSaveEntry.TabIndex = 7;
            btnSaveEntry.Text = "Speichern";
            btnSaveEntry.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(121, 125);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(176, 23);
            txtDescription.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(121, 72);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(178, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 129);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 4;
            label2.Text = "Beschreibung";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 77);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Passwort";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(33, 39);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(83, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Benutzername";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(121, 36);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(178, 23);
            txtUsername.TabIndex = 1;
            // 
            // lblNewEntryTitle
            // 
            lblNewEntryTitle.AutoSize = true;
            lblNewEntryTitle.Dock = DockStyle.Top;
            lblNewEntryTitle.Location = new Point(0, 0);
            lblNewEntryTitle.Name = "lblNewEntryTitle";
            lblNewEntryTitle.Size = new Size(168, 15);
            lblNewEntryTitle.TabIndex = 0;
            lblNewEntryTitle.Text = "Neue Zugangsdaten speichern";
            lblNewEntryTitle.Click += lblNewEntryTitle_Click;
            // 
            // pnlSavedEntries
            // 
            pnlSavedEntries.BorderStyle = BorderStyle.FixedSingle;
            pnlSavedEntries.Controls.Add(lblSavedTitle);
            pnlSavedEntries.Dock = DockStyle.Fill;
            pnlSavedEntries.Location = new Point(3, 228);
            pnlSavedEntries.Name = "pnlSavedEntries";
            pnlSavedEntries.Size = new Size(794, 219);
            pnlSavedEntries.TabIndex = 1;
            // 
            // lblSavedTitle
            // 
            lblSavedTitle.AutoSize = true;
            lblSavedTitle.Dock = DockStyle.Top;
            lblSavedTitle.Location = new Point(0, 0);
            lblSavedTitle.Name = "lblSavedTitle";
            lblSavedTitle.Size = new Size(121, 15);
            lblSavedTitle.TabIndex = 0;
            lblSavedTitle.Text = "Gespeicherte Einträge";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpMain);
            Name = "MainForm";
            Text = "Form1";
            tlpMain.ResumeLayout(false);
            tlpTop.ResumeLayout(false);
            pnlGenerator.ResumeLayout(false);
            pnlGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLength).EndInit();
            pnlNewEntry.ResumeLayout(false);
            pnlNewEntry.PerformLayout();
            pnlSavedEntries.ResumeLayout(false);
            pnlSavedEntries.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpTop;
        private Panel pnlGenerator;
        private Panel pnlNewEntry;
        private Panel pnlSavedEntries;
        private Label lblGeneratorTitle;
        private Label lblNewEntryTitle;
        private Label lblSavedTitle;
        private NumericUpDown nudLength;
        private Label lblLength;
        private CheckBox chkSpecial;
        private CheckBox chkDigits;
        private CheckBox chkUpper;
        private Button btnGenerate;
        private TextBox txtGenerated;
        private TextBox txtDescription;
        private TextBox txtPassword;
        private Label label2;
        private Label label1;
        private Label lblUsername;
        private TextBox txtUsername;
        private Button btnSaveEntry;
        private CheckBox chkShowPassword;
    }
}
