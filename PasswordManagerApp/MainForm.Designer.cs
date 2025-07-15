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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tlpMain = new TableLayoutPanel();
            pnlTitle = new Panel();
            lblTitel = new Label();
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_gespZugDat = new Label();
            dgvEntries = new DataGridView();
            pnlEntryActions = new Panel();
            btnHideEntry = new Button();
            btnDeleteEntry = new Button();
            btnShowPassword = new Button();
            pnlContent = new Panel();
            tlpMain.SuspendLayout();
            pnlTitle.SuspendLayout();
            tlpTop.SuspendLayout();
            pnlGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudLength).BeginInit();
            pnlNewEntry.SuspendLayout();
            pnlSavedEntries.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntries).BeginInit();
            pnlEntryActions.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(pnlTitle, 0, 0);
            tlpMain.Controls.Add(tlpTop, 0, 1);
            tlpMain.Controls.Add(pnlSavedEntries, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(800, 541);
            tlpMain.TabIndex = 0;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = SystemColors.ActiveCaption;
            pnlTitle.Controls.Add(lblTitel);
            pnlTitle.Dock = DockStyle.Fill;
            pnlTitle.Location = new Point(3, 3);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(794, 34);
            pnlTitle.TabIndex = 8;
            // 
            // lblTitel
            // 
            lblTitel.BackColor = SystemColors.ActiveCaption;
            lblTitel.Dock = DockStyle.Top;
            lblTitel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitel.Location = new Point(0, 0);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(794, 30);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "SimplePasswordManager";
            lblTitel.TextAlign = ContentAlignment.MiddleCenter;
            lblTitel.Click += lblTitel_Click;
            // 
            // tlpTop
            // 
            tlpTop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpTop.ColumnCount = 2;
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTop.Controls.Add(pnlGenerator, 0, 0);
            tlpTop.Controls.Add(pnlNewEntry, 1, 0);
            tlpTop.Location = new Point(3, 43);
            tlpTop.Name = "tlpTop";
            tlpTop.RowCount = 1;
            tlpTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTop.Size = new Size(794, 214);
            tlpTop.TabIndex = 0;
            // 
            // pnlGenerator
            // 
            pnlGenerator.BackColor = SystemColors.Control;
            pnlGenerator.BorderStyle = BorderStyle.Fixed3D;
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
            pnlGenerator.Size = new Size(391, 208);
            pnlGenerator.TabIndex = 0;
            // 
            // txtGenerated
            // 
            txtGenerated.BackColor = SystemColors.HighlightText;
            txtGenerated.Location = new Point(47, 168);
            txtGenerated.Name = "txtGenerated";
            txtGenerated.ReadOnly = true;
            txtGenerated.Size = new Size(293, 23);
            txtGenerated.TabIndex = 7;
            txtGenerated.TextChanged += txtGenerated_TextChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = SystemColors.ActiveCaption;
            btnGenerate.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Location = new Point(47, 135);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(293, 25);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Passwort generieren";
            btnGenerate.UseVisualStyleBackColor = false;
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
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(68, 30);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(83, 15);
            lblLength.TabIndex = 2;
            lblLength.Text = "Passwortlänge";
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
            lblGeneratorTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGeneratorTitle.Location = new Point(0, 0);
            lblGeneratorTitle.Name = "lblGeneratorTitle";
            lblGeneratorTitle.Padding = new Padding(2);
            lblGeneratorTitle.Size = new Size(140, 23);
            lblGeneratorTitle.TabIndex = 0;
            lblGeneratorTitle.Text = "Passwortgenerator";
            // 
            // pnlNewEntry
            // 
            pnlNewEntry.BorderStyle = BorderStyle.Fixed3D;
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
            pnlNewEntry.Size = new Size(391, 208);
            pnlNewEntry.TabIndex = 1;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(141, 101);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(125, 19);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.Text = "Passwort Anzeigen";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnSaveEntry
            // 
            btnSaveEntry.BackColor = SystemColors.ActiveCaption;
            btnSaveEntry.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnSaveEntry.FlatStyle = FlatStyle.Flat;
            btnSaveEntry.Location = new Point(51, 166);
            btnSaveEntry.Name = "btnSaveEntry";
            btnSaveEntry.Size = new Size(266, 25);
            btnSaveEntry.TabIndex = 7;
            btnSaveEntry.Text = "Speichern";
            btnSaveEntry.UseVisualStyleBackColor = false;
            btnSaveEntry.Click += btnSaveEntry_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(139, 125);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(214, 23);
            txtDescription.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(139, 72);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(214, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 129);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 4;
            label2.Text = "Beschreibung";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 75);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Passwort";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(10, 39);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(123, 15);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Benutzername / Email";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(139, 36);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 23);
            txtUsername.TabIndex = 1;
            // 
            // lblNewEntryTitle
            // 
            lblNewEntryTitle.AutoSize = true;
            lblNewEntryTitle.Dock = DockStyle.Top;
            lblNewEntryTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNewEntryTitle.Location = new Point(0, 0);
            lblNewEntryTitle.Name = "lblNewEntryTitle";
            lblNewEntryTitle.Padding = new Padding(2);
            lblNewEntryTitle.Size = new Size(215, 23);
            lblNewEntryTitle.TabIndex = 0;
            lblNewEntryTitle.Text = "Neue Zugangsdaten speichern";
            // 
            // pnlSavedEntries
            // 
            pnlSavedEntries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlSavedEntries.BorderStyle = BorderStyle.Fixed3D;
            pnlSavedEntries.Controls.Add(tableLayoutPanel1);
            pnlSavedEntries.Controls.Add(pnlEntryActions);
            pnlSavedEntries.Location = new Point(3, 263);
            pnlSavedEntries.Name = "pnlSavedEntries";
            pnlSavedEntries.Size = new Size(794, 275);
            pnlSavedEntries.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lbl_gespZugDat, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvEntries, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(790, 236);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // lbl_gespZugDat
            // 
            lbl_gespZugDat.AutoSize = true;
            lbl_gespZugDat.Dock = DockStyle.Top;
            lbl_gespZugDat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl_gespZugDat.Location = new Point(3, 0);
            lbl_gespZugDat.Name = "lbl_gespZugDat";
            lbl_gespZugDat.Padding = new Padding(2);
            lbl_gespZugDat.Size = new Size(784, 23);
            lbl_gespZugDat.TabIndex = 3;
            lbl_gespZugDat.Text = "Gespeicherte Zugangsdaten";
            lbl_gespZugDat.Click += label3_Click;
            // 
            // dgvEntries
            // 
            dgvEntries.AllowUserToAddRows = false;
            dgvEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEntries.BorderStyle = BorderStyle.None;
            dgvEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvEntries.DefaultCellStyle = dataGridViewCellStyle1;
            dgvEntries.Dock = DockStyle.Fill;
            dgvEntries.Location = new Point(3, 26);
            dgvEntries.Name = "dgvEntries";
            dgvEntries.ReadOnly = true;
            dgvEntries.RowHeadersVisible = false;
            dgvEntries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntries.Size = new Size(784, 241);
            dgvEntries.TabIndex = 1;
            dgvEntries.CellContentClick += dgvEntries_CellContentClick;
            // 
            // pnlEntryActions
            // 
            pnlEntryActions.Controls.Add(btnHideEntry);
            pnlEntryActions.Controls.Add(btnDeleteEntry);
            pnlEntryActions.Controls.Add(btnShowPassword);
            pnlEntryActions.Dock = DockStyle.Bottom;
            pnlEntryActions.Location = new Point(0, 236);
            pnlEntryActions.Name = "pnlEntryActions";
            pnlEntryActions.Size = new Size(790, 35);
            pnlEntryActions.TabIndex = 2;
            pnlEntryActions.Paint += pnlEntryActions_Paint;
            // 
            // btnHideEntry
            // 
            btnHideEntry.BackColor = SystemColors.ActiveCaption;
            btnHideEntry.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnHideEntry.FlatStyle = FlatStyle.Flat;
            btnHideEntry.Location = new Point(321, 5);
            btnHideEntry.Name = "btnHideEntry";
            btnHideEntry.Size = new Size(150, 25);
            btnHideEntry.TabIndex = 9;
            btnHideEntry.Text = "Verbergen";
            btnHideEntry.UseVisualStyleBackColor = false;
            btnHideEntry.Click += btnHideEntry_Click;
            // 
            // btnDeleteEntry
            // 
            btnDeleteEntry.BackColor = SystemColors.ActiveCaption;
            btnDeleteEntry.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnDeleteEntry.FlatStyle = FlatStyle.Flat;
            btnDeleteEntry.Location = new Point(603, 5);
            btnDeleteEntry.Name = "btnDeleteEntry";
            btnDeleteEntry.Size = new Size(150, 25);
            btnDeleteEntry.TabIndex = 9;
            btnDeleteEntry.Text = "Löschen!";
            btnDeleteEntry.UseVisualStyleBackColor = false;
            btnDeleteEntry.Click += btnDeleteEntry_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackColor = SystemColors.ActiveCaption;
            btnShowPassword.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.Location = new Point(50, 5);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(150, 25);
            btnShowPassword.TabIndex = 8;
            btnShowPassword.Text = "Anzeigen";
            btnShowPassword.UseVisualStyleBackColor = false;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(tlpMain);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(800, 541);
            pnlContent.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(pnlContent);
            Name = "MainForm";
            Text = "SimplePasswordManager";
            tlpMain.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            tlpTop.ResumeLayout(false);
            pnlGenerator.ResumeLayout(false);
            pnlGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudLength).EndInit();
            pnlNewEntry.ResumeLayout(false);
            pnlNewEntry.PerformLayout();
            pnlSavedEntries.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEntries).EndInit();
            pnlEntryActions.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
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
        private DataGridView dgvEntries;
        private Button btnDeleteEntry;
        private Panel pnlTitle;
        private Label lblTitel;
        private Panel pnlContent;
        private Label lbl_gespZugDat;
        private Panel pnlEntryActions;
        private Button btnHideEntry;
        private Button btnShowPassword;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
