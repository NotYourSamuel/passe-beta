namespace passe
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.myPasswordsLabel = new System.Windows.Forms.Label();
            this.passwordDataGrid = new System.Windows.Forms.DataGridView();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.fileTypeComboBox = new System.Windows.Forms.ComboBox();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.mainTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.liveValuesCheckBox = new System.Windows.Forms.CheckBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.topbarStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFirewallRuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.managementPage = new System.Windows.Forms.TabPage();
            this.encryptionPage = new System.Windows.Forms.TabPage();
            this.encryptionTitleLabel = new System.Windows.Forms.Label();
            this.EPhashLabel = new System.Windows.Forms.Label();
            this.EecryptButton = new System.Windows.Forms.Button();
            this.EhashTextBox = new System.Windows.Forms.TextBox();
            this.EpasswordTextbox = new System.Windows.Forms.TextBox();
            this.EcopyResultButton = new System.Windows.Forms.Button();
            this.EPpasswordLabel = new System.Windows.Forms.Label();
            this.EdecryptButton = new System.Windows.Forms.Button();
            this.EencryptedResult = new System.Windows.Forms.TextBox();
            this.EPresultLabel = new System.Windows.Forms.Label();
            this.strengthMeterPage = new System.Windows.Forms.TabPage();
            this.SMscoreLabel = new System.Windows.Forms.Label();
            this.SMexcellentPanel = new System.Windows.Forms.Panel();
            this.SMgreatPanel = new System.Windows.Forms.Panel();
            this.SMgoodPanel = new System.Windows.Forms.Panel();
            this.SMbetterPanel = new System.Windows.Forms.Panel();
            this.SMdecentPanel = new System.Windows.Forms.Panel();
            this.SMokayPanel = new System.Windows.Forms.Panel();
            this.SMbadPanel = new System.Windows.Forms.Panel();
            this.SMbottomPanel = new System.Windows.Forms.Panel();
            this.SMspecialAmountLabel = new System.Windows.Forms.Label();
            this.SMdigitCountLabel = new System.Windows.Forms.Label();
            this.SMuppercaseLabel = new System.Windows.Forms.Label();
            this.SMlowercaseLettersLabel = new System.Windows.Forms.Label();
            this.SMmaxLengthLabel = new System.Windows.Forms.Label();
            this.SMminLengthLabel = new System.Windows.Forms.Label();
            this.SMpasswordTextBox = new System.Windows.Forms.TextBox();
            this.strengthMeterTitle = new System.Windows.Forms.Label();
            this.SMpasswordLabel = new System.Windows.Forms.Label();
            this.securePasswordPage = new System.Windows.Forms.TabPage();
            this.SPGexportButton = new System.Windows.Forms.Button();
            this.SPGquanityLabel = new System.Windows.Forms.Label();
            this.SPGquanity = new System.Windows.Forms.NumericUpDown();
            this.SPGgenerateButton = new System.Windows.Forms.Button();
            this.SPGpasswordsLabel = new System.Windows.Forms.Label();
            this.SPGpasswordTextBox = new System.Windows.Forms.TextBox();
            this.SPGlengthLabel = new System.Windows.Forms.Label();
            this.SPGlength = new System.Windows.Forms.NumericUpDown();
            this.SPGnoSequentialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.SPGnoDupeCharactersCheckBox = new System.Windows.Forms.CheckBox();
            this.SPGnoSimilarCharactersCheckBox = new System.Windows.Forms.CheckBox();
            this.SPGbeginWithLetterCheckBox = new System.Windows.Forms.CheckBox();
            this.SPGincludeSymbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.SPGincludeUppercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.SPGincludeLowercaseCheckBox = new System.Windows.Forms.CheckBox();
            this.SPGincludeNumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.logPage = new System.Windows.Forms.TabPage();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.performanceLabel = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.fileStatus = new System.Windows.Forms.Label();
            this.CPUperformance = new System.Diagnostics.PerformanceCounter();
            this.RAMperformance = new System.Diagnostics.PerformanceCounter();
            this.performanceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.passwordDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBindingSource)).BeginInit();
            this.topbarStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.managementPage.SuspendLayout();
            this.encryptionPage.SuspendLayout();
            this.strengthMeterPage.SuspendLayout();
            this.securePasswordPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPGquanity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPGlength)).BeginInit();
            this.logPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPUperformance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAMperformance)).BeginInit();
            this.SuspendLayout();
            // 
            // myPasswordsLabel
            // 
            this.myPasswordsLabel.AutoSize = true;
            this.myPasswordsLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myPasswordsLabel.Location = new System.Drawing.Point(3, 3);
            this.myPasswordsLabel.Name = "myPasswordsLabel";
            this.myPasswordsLabel.Size = new System.Drawing.Size(122, 21);
            this.myPasswordsLabel.TabIndex = 0;
            this.myPasswordsLabel.Text = "My Passwords:";
            // 
            // passwordDataGrid
            // 
            this.passwordDataGrid.AutoGenerateColumns = false;
            this.passwordDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passwordDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.passwordDataGrid.DataSource = this.dataGridBindingSource;
            this.passwordDataGrid.Location = new System.Drawing.Point(3, 27);
            this.passwordDataGrid.Name = "passwordDataGrid";
            this.passwordDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.passwordDataGrid.Size = new System.Drawing.Size(427, 192);
            this.passwordDataGrid.TabIndex = 2;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.accountDataGridViewTextBoxColumn.ToolTipText = "This is the name of the account for the program/website.";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.passwordDataGridViewTextBoxColumn.ToolTipText = "This is the password for the account.";
            // 
            // dataGridBindingSource
            // 
            this.dataGridBindingSource.DataSource = typeof(passe.dataGrid);
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(461, 17);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(126, 29);
            this.newButton.TabIndex = 4;
            this.newButton.Text = "New";
            this.mainTooltip.SetToolTip(this.newButton, "This will create a popup that will guide you into adding a password to this list." +
        "");
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(461, 52);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(126, 29);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.mainTooltip.SetToolTip(this.deleteButton, "This will delete the selected password.");
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // fileTypeComboBox
            // 
            this.fileTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileTypeComboBox.FormattingEnabled = true;
            this.fileTypeComboBox.Items.AddRange(new object[] {
            ".encryptedpassword",
            ".encpas",
            ".pass",
            ".password",
            ".hiddenpassword",
            ".passcrypy",
            ".lockdata",
            ".keychain",
            ".vaultx",
            ".securepass",
            ".lockbox",
            ".keyring"});
            this.fileTypeComboBox.Location = new System.Drawing.Point(461, 153);
            this.fileTypeComboBox.Name = "fileTypeComboBox";
            this.fileTypeComboBox.Size = new System.Drawing.Size(126, 26);
            this.fileTypeComboBox.TabIndex = 6;
            this.mainTooltip.SetToolTip(this.fileTypeComboBox, "Adding a password will add an encrypted file containing the data with a custom Fi" +
        "leType. Here is where you can customize it.");
            this.fileTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.fileTypeComboBox_SelectedIndexChanged);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAllButton.Location = new System.Drawing.Point(461, 118);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(126, 29);
            this.deleteAllButton.TabIndex = 7;
            this.deleteAllButton.Text = "Delete All";
            this.mainTooltip.SetToolTip(this.deleteAllButton, "This will delete all saved passwords.");
            this.deleteAllButton.UseVisualStyleBackColor = true;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // mainTooltip
            // 
            this.mainTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.mainTooltip.ToolTipTitle = "Help";
            // 
            // liveValuesCheckBox
            // 
            this.liveValuesCheckBox.AutoSize = true;
            this.liveValuesCheckBox.Location = new System.Drawing.Point(461, 194);
            this.liveValuesCheckBox.Name = "liveValuesCheckBox";
            this.liveValuesCheckBox.Size = new System.Drawing.Size(81, 17);
            this.liveValuesCheckBox.TabIndex = 8;
            this.liveValuesCheckBox.Text = "Live Values";
            this.mainTooltip.SetToolTip(this.liveValuesCheckBox, "This will continuously update the values.");
            this.liveValuesCheckBox.UseVisualStyleBackColor = true;
            this.liveValuesCheckBox.CheckedChanged += new System.EventHandler(this.liveValuesCheckBox_CheckedChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(461, 85);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(126, 29);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh";
            this.mainTooltip.SetToolTip(this.refreshButton, "Refresh");
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // topbarStrip
            // 
            this.topbarStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.topbarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.fileToolStripMenuItem1,
            this.optionsToolStripMenuItem});
            this.topbarStrip.Location = new System.Drawing.Point(0, 0);
            this.topbarStrip.Name = "topbarStrip";
            this.topbarStrip.Size = new System.Drawing.Size(636, 24);
            this.topbarStrip.TabIndex = 13;
            this.topbarStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&Reset";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordsFolderToolStripMenuItem,
            this.resourcesFolderToolStripMenuItem,
            this.mainFolderToolStripMenuItem});
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // passwordsFolderToolStripMenuItem
            // 
            this.passwordsFolderToolStripMenuItem.Name = "passwordsFolderToolStripMenuItem";
            this.passwordsFolderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.passwordsFolderToolStripMenuItem.Text = "Passwords Folder";
            this.passwordsFolderToolStripMenuItem.Click += new System.EventHandler(this.passwordsFolderToolStripMenuItem_Click);
            // 
            // resourcesFolderToolStripMenuItem
            // 
            this.resourcesFolderToolStripMenuItem.Name = "resourcesFolderToolStripMenuItem";
            this.resourcesFolderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.resourcesFolderToolStripMenuItem.Text = "Resources Folder";
            this.resourcesFolderToolStripMenuItem.Click += new System.EventHandler(this.resourcesFolderToolStripMenuItem_Click);
            // 
            // mainFolderToolStripMenuItem
            // 
            this.mainFolderToolStripMenuItem.Name = "mainFolderToolStripMenuItem";
            this.mainFolderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.mainFolderToolStripMenuItem.Text = "Main Folder";
            this.mainFolderToolStripMenuItem.Click += new System.EventHandler(this.mainFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFirewallRuleToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addFirewallRuleToolStripMenuItem
            // 
            this.addFirewallRuleToolStripMenuItem.Name = "addFirewallRuleToolStripMenuItem";
            this.addFirewallRuleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addFirewallRuleToolStripMenuItem.Text = "Add Firewall Rule";
            this.addFirewallRuleToolStripMenuItem.Click += new System.EventHandler(this.addFirewallRuleToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.managementPage);
            this.tabControl.Controls.Add(this.encryptionPage);
            this.tabControl.Controls.Add(this.strengthMeterPage);
            this.tabControl.Controls.Add(this.securePasswordPage);
            this.tabControl.Controls.Add(this.logPage);
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl.Location = new System.Drawing.Point(12, 24);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(619, 254);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 14;
            this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            // 
            // managementPage
            // 
            this.managementPage.Controls.Add(this.refreshButton);
            this.managementPage.Controls.Add(this.myPasswordsLabel);
            this.managementPage.Controls.Add(this.liveValuesCheckBox);
            this.managementPage.Controls.Add(this.passwordDataGrid);
            this.managementPage.Controls.Add(this.deleteAllButton);
            this.managementPage.Controls.Add(this.newButton);
            this.managementPage.Controls.Add(this.fileTypeComboBox);
            this.managementPage.Controls.Add(this.deleteButton);
            this.managementPage.Location = new System.Drawing.Point(4, 22);
            this.managementPage.Name = "managementPage";
            this.managementPage.Padding = new System.Windows.Forms.Padding(3);
            this.managementPage.Size = new System.Drawing.Size(611, 228);
            this.managementPage.TabIndex = 0;
            this.managementPage.Text = "Manager";
            this.managementPage.UseVisualStyleBackColor = true;
            // 
            // encryptionPage
            // 
            this.encryptionPage.Controls.Add(this.encryptionTitleLabel);
            this.encryptionPage.Controls.Add(this.EPhashLabel);
            this.encryptionPage.Controls.Add(this.EecryptButton);
            this.encryptionPage.Controls.Add(this.EhashTextBox);
            this.encryptionPage.Controls.Add(this.EpasswordTextbox);
            this.encryptionPage.Controls.Add(this.EcopyResultButton);
            this.encryptionPage.Controls.Add(this.EPpasswordLabel);
            this.encryptionPage.Controls.Add(this.EdecryptButton);
            this.encryptionPage.Controls.Add(this.EencryptedResult);
            this.encryptionPage.Controls.Add(this.EPresultLabel);
            this.encryptionPage.Location = new System.Drawing.Point(4, 22);
            this.encryptionPage.Name = "encryptionPage";
            this.encryptionPage.Padding = new System.Windows.Forms.Padding(3);
            this.encryptionPage.Size = new System.Drawing.Size(611, 228);
            this.encryptionPage.TabIndex = 2;
            this.encryptionPage.Text = "Encryption";
            this.encryptionPage.UseVisualStyleBackColor = true;
            // 
            // encryptionTitleLabel
            // 
            this.encryptionTitleLabel.AutoSize = true;
            this.encryptionTitleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptionTitleLabel.Location = new System.Drawing.Point(6, 3);
            this.encryptionTitleLabel.Name = "encryptionTitleLabel";
            this.encryptionTitleLabel.Size = new System.Drawing.Size(109, 25);
            this.encryptionTitleLabel.TabIndex = 32;
            this.encryptionTitleLabel.Text = "Encryption";
            // 
            // EPhashLabel
            // 
            this.EPhashLabel.AutoSize = true;
            this.EPhashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPhashLabel.Location = new System.Drawing.Point(6, 94);
            this.EPhashLabel.Name = "EPhashLabel";
            this.EPhashLabel.Size = new System.Drawing.Size(42, 16);
            this.EPhashLabel.TabIndex = 31;
            this.EPhashLabel.Text = "Hash:";
            // 
            // EecryptButton
            // 
            this.EecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EecryptButton.Location = new System.Drawing.Point(3, 128);
            this.EecryptButton.Name = "EecryptButton";
            this.EecryptButton.Size = new System.Drawing.Size(300, 64);
            this.EecryptButton.TabIndex = 27;
            this.EecryptButton.Text = "Encrypt";
            this.EecryptButton.UseVisualStyleBackColor = true;
            this.EecryptButton.Click += new System.EventHandler(this.EecryptButton_Click);
            // 
            // EhashTextBox
            // 
            this.EhashTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EhashTextBox.Location = new System.Drawing.Point(84, 91);
            this.EhashTextBox.Name = "EhashTextBox";
            this.EhashTextBox.Size = new System.Drawing.Size(521, 22);
            this.EhashTextBox.TabIndex = 30;
            // 
            // EpasswordTextbox
            // 
            this.EpasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EpasswordTextbox.Location = new System.Drawing.Point(84, 35);
            this.EpasswordTextbox.Name = "EpasswordTextbox";
            this.EpasswordTextbox.Size = new System.Drawing.Size(521, 22);
            this.EpasswordTextbox.TabIndex = 23;
            // 
            // EcopyResultButton
            // 
            this.EcopyResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EcopyResultButton.Location = new System.Drawing.Point(3, 194);
            this.EcopyResultButton.Name = "EcopyResultButton";
            this.EcopyResultButton.Size = new System.Drawing.Size(602, 29);
            this.EcopyResultButton.TabIndex = 29;
            this.EcopyResultButton.Text = "Copy";
            this.EcopyResultButton.UseVisualStyleBackColor = true;
            this.EcopyResultButton.Click += new System.EventHandler(this.EcopyResultButton_Click);
            // 
            // EPpasswordLabel
            // 
            this.EPpasswordLabel.AutoSize = true;
            this.EPpasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPpasswordLabel.Location = new System.Drawing.Point(6, 38);
            this.EPpasswordLabel.Name = "EPpasswordLabel";
            this.EPpasswordLabel.Size = new System.Drawing.Size(70, 16);
            this.EPpasswordLabel.TabIndex = 24;
            this.EPpasswordLabel.Text = "Password:";
            // 
            // EdecryptButton
            // 
            this.EdecryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdecryptButton.Location = new System.Drawing.Point(305, 128);
            this.EdecryptButton.Name = "EdecryptButton";
            this.EdecryptButton.Size = new System.Drawing.Size(300, 64);
            this.EdecryptButton.TabIndex = 28;
            this.EdecryptButton.Text = "Decrypt";
            this.EdecryptButton.UseVisualStyleBackColor = true;
            this.EdecryptButton.Click += new System.EventHandler(this.EdecryptButton_Click);
            // 
            // EencryptedResult
            // 
            this.EencryptedResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EencryptedResult.Location = new System.Drawing.Point(84, 63);
            this.EencryptedResult.Name = "EencryptedResult";
            this.EencryptedResult.ReadOnly = true;
            this.EencryptedResult.Size = new System.Drawing.Size(521, 22);
            this.EencryptedResult.TabIndex = 25;
            // 
            // EPresultLabel
            // 
            this.EPresultLabel.AutoSize = true;
            this.EPresultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPresultLabel.Location = new System.Drawing.Point(6, 67);
            this.EPresultLabel.Name = "EPresultLabel";
            this.EPresultLabel.Size = new System.Drawing.Size(48, 16);
            this.EPresultLabel.TabIndex = 26;
            this.EPresultLabel.Text = "Result:";
            // 
            // strengthMeterPage
            // 
            this.strengthMeterPage.Controls.Add(this.SMscoreLabel);
            this.strengthMeterPage.Controls.Add(this.SMexcellentPanel);
            this.strengthMeterPage.Controls.Add(this.SMgreatPanel);
            this.strengthMeterPage.Controls.Add(this.SMgoodPanel);
            this.strengthMeterPage.Controls.Add(this.SMbetterPanel);
            this.strengthMeterPage.Controls.Add(this.SMdecentPanel);
            this.strengthMeterPage.Controls.Add(this.SMokayPanel);
            this.strengthMeterPage.Controls.Add(this.SMbadPanel);
            this.strengthMeterPage.Controls.Add(this.SMbottomPanel);
            this.strengthMeterPage.Controls.Add(this.SMspecialAmountLabel);
            this.strengthMeterPage.Controls.Add(this.SMdigitCountLabel);
            this.strengthMeterPage.Controls.Add(this.SMuppercaseLabel);
            this.strengthMeterPage.Controls.Add(this.SMlowercaseLettersLabel);
            this.strengthMeterPage.Controls.Add(this.SMmaxLengthLabel);
            this.strengthMeterPage.Controls.Add(this.SMminLengthLabel);
            this.strengthMeterPage.Controls.Add(this.SMpasswordTextBox);
            this.strengthMeterPage.Controls.Add(this.strengthMeterTitle);
            this.strengthMeterPage.Controls.Add(this.SMpasswordLabel);
            this.strengthMeterPage.Location = new System.Drawing.Point(4, 22);
            this.strengthMeterPage.Name = "strengthMeterPage";
            this.strengthMeterPage.Padding = new System.Windows.Forms.Padding(3);
            this.strengthMeterPage.Size = new System.Drawing.Size(611, 228);
            this.strengthMeterPage.TabIndex = 3;
            this.strengthMeterPage.Text = "Strength Meter";
            this.strengthMeterPage.UseVisualStyleBackColor = true;
            // 
            // SMscoreLabel
            // 
            this.SMscoreLabel.AutoSize = true;
            this.SMscoreLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMscoreLabel.Location = new System.Drawing.Point(413, 144);
            this.SMscoreLabel.Name = "SMscoreLabel";
            this.SMscoreLabel.Size = new System.Drawing.Size(59, 19);
            this.SMscoreLabel.TabIndex = 15;
            this.SMscoreLabel.Text = "Score: 0";
            // 
            // SMexcellentPanel
            // 
            this.SMexcellentPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.SMexcellentPanel.Enabled = false;
            this.SMexcellentPanel.Location = new System.Drawing.Point(521, 23);
            this.SMexcellentPanel.Name = "SMexcellentPanel";
            this.SMexcellentPanel.Size = new System.Drawing.Size(25, 110);
            this.SMexcellentPanel.TabIndex = 49;
            // 
            // SMgreatPanel
            // 
            this.SMgreatPanel.BackColor = System.Drawing.Color.Chartreuse;
            this.SMgreatPanel.Location = new System.Drawing.Point(490, 42);
            this.SMgreatPanel.Name = "SMgreatPanel";
            this.SMgreatPanel.Size = new System.Drawing.Size(25, 90);
            this.SMgreatPanel.TabIndex = 48;
            // 
            // SMgoodPanel
            // 
            this.SMgoodPanel.BackColor = System.Drawing.Color.YellowGreen;
            this.SMgoodPanel.Location = new System.Drawing.Point(459, 57);
            this.SMgoodPanel.Name = "SMgoodPanel";
            this.SMgoodPanel.Size = new System.Drawing.Size(25, 75);
            this.SMgoodPanel.TabIndex = 47;
            // 
            // SMbetterPanel
            // 
            this.SMbetterPanel.BackColor = System.Drawing.Color.Yellow;
            this.SMbetterPanel.Location = new System.Drawing.Point(428, 77);
            this.SMbetterPanel.Name = "SMbetterPanel";
            this.SMbetterPanel.Size = new System.Drawing.Size(25, 55);
            this.SMbetterPanel.TabIndex = 46;
            // 
            // SMdecentPanel
            // 
            this.SMdecentPanel.BackColor = System.Drawing.Color.Orange;
            this.SMdecentPanel.Location = new System.Drawing.Point(397, 92);
            this.SMdecentPanel.Name = "SMdecentPanel";
            this.SMdecentPanel.Size = new System.Drawing.Size(25, 40);
            this.SMdecentPanel.TabIndex = 45;
            // 
            // SMokayPanel
            // 
            this.SMokayPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.SMokayPanel.Location = new System.Drawing.Point(366, 108);
            this.SMokayPanel.Name = "SMokayPanel";
            this.SMokayPanel.Size = new System.Drawing.Size(25, 25);
            this.SMokayPanel.TabIndex = 44;
            // 
            // SMbadPanel
            // 
            this.SMbadPanel.BackColor = System.Drawing.Color.Red;
            this.SMbadPanel.Location = new System.Drawing.Point(335, 123);
            this.SMbadPanel.Name = "SMbadPanel";
            this.SMbadPanel.Size = new System.Drawing.Size(25, 10);
            this.SMbadPanel.TabIndex = 43;
            // 
            // SMbottomPanel
            // 
            this.SMbottomPanel.BackColor = System.Drawing.Color.Gray;
            this.SMbottomPanel.Location = new System.Drawing.Point(335, 138);
            this.SMbottomPanel.Name = "SMbottomPanel";
            this.SMbottomPanel.Size = new System.Drawing.Size(211, 2);
            this.SMbottomPanel.TabIndex = 42;
            // 
            // SMspecialAmountLabel
            // 
            this.SMspecialAmountLabel.AutoSize = true;
            this.SMspecialAmountLabel.Location = new System.Drawing.Point(5, 112);
            this.SMspecialAmountLabel.Name = "SMspecialAmountLabel";
            this.SMspecialAmountLabel.Size = new System.Drawing.Size(279, 13);
            this.SMspecialAmountLabel.TabIndex = 40;
            this.SMspecialAmountLabel.Text = "Your Password must contain at least 0 special characters.";
            // 
            // SMdigitCountLabel
            // 
            this.SMdigitCountLabel.AutoSize = true;
            this.SMdigitCountLabel.Location = new System.Drawing.Point(5, 125);
            this.SMdigitCountLabel.Name = "SMdigitCountLabel";
            this.SMdigitCountLabel.Size = new System.Drawing.Size(217, 13);
            this.SMdigitCountLabel.TabIndex = 39;
            this.SMdigitCountLabel.Text = "Your Password must contain at least 0 digits.";
            // 
            // SMuppercaseLabel
            // 
            this.SMuppercaseLabel.AutoSize = true;
            this.SMuppercaseLabel.Location = new System.Drawing.Point(5, 138);
            this.SMuppercaseLabel.Name = "SMuppercaseLabel";
            this.SMuppercaseLabel.Size = new System.Drawing.Size(274, 13);
            this.SMuppercaseLabel.TabIndex = 38;
            this.SMuppercaseLabel.Text = "Your Password must contain at least 0 uppercase letters.";
            // 
            // SMlowercaseLettersLabel
            // 
            this.SMlowercaseLettersLabel.AutoSize = true;
            this.SMlowercaseLettersLabel.Location = new System.Drawing.Point(5, 151);
            this.SMlowercaseLettersLabel.Name = "SMlowercaseLettersLabel";
            this.SMlowercaseLettersLabel.Size = new System.Drawing.Size(285, 13);
            this.SMlowercaseLettersLabel.TabIndex = 37;
            this.SMlowercaseLettersLabel.Text = "Your Password must contain more than 0 lowercase letters.";
            // 
            // SMmaxLengthLabel
            // 
            this.SMmaxLengthLabel.AutoSize = true;
            this.SMmaxLengthLabel.Location = new System.Drawing.Point(5, 164);
            this.SMmaxLengthLabel.Name = "SMmaxLengthLabel";
            this.SMmaxLengthLabel.Size = new System.Drawing.Size(244, 13);
            this.SMmaxLengthLabel.TabIndex = 36;
            this.SMmaxLengthLabel.Text = "Your Password cannot be more than 0 characters.";
            // 
            // SMminLengthLabel
            // 
            this.SMminLengthLabel.AutoSize = true;
            this.SMminLengthLabel.Location = new System.Drawing.Point(6, 177);
            this.SMminLengthLabel.Name = "SMminLengthLabel";
            this.SMminLengthLabel.Size = new System.Drawing.Size(220, 13);
            this.SMminLengthLabel.TabIndex = 35;
            this.SMminLengthLabel.Text = "Your Password must be at least 0 characters.";
            // 
            // SMpasswordTextBox
            // 
            this.SMpasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMpasswordTextBox.Location = new System.Drawing.Point(88, 193);
            this.SMpasswordTextBox.Name = "SMpasswordTextBox";
            this.SMpasswordTextBox.Size = new System.Drawing.Size(517, 26);
            this.SMpasswordTextBox.TabIndex = 34;
            this.SMpasswordTextBox.TextChanged += new System.EventHandler(this.SMpasswordTextBox_TextChanged);
            // 
            // strengthMeterTitle
            // 
            this.strengthMeterTitle.AutoSize = true;
            this.strengthMeterTitle.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthMeterTitle.Location = new System.Drawing.Point(3, 3);
            this.strengthMeterTitle.Name = "strengthMeterTitle";
            this.strengthMeterTitle.Size = new System.Drawing.Size(152, 25);
            this.strengthMeterTitle.TabIndex = 33;
            this.strengthMeterTitle.Text = "Strength Meter";
            // 
            // SMpasswordLabel
            // 
            this.SMpasswordLabel.AutoSize = true;
            this.SMpasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMpasswordLabel.Location = new System.Drawing.Point(9, 199);
            this.SMpasswordLabel.Name = "SMpasswordLabel";
            this.SMpasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.SMpasswordLabel.TabIndex = 0;
            this.SMpasswordLabel.Text = "Password:";
            // 
            // securePasswordPage
            // 
            this.securePasswordPage.Controls.Add(this.SPGexportButton);
            this.securePasswordPage.Controls.Add(this.SPGquanityLabel);
            this.securePasswordPage.Controls.Add(this.SPGquanity);
            this.securePasswordPage.Controls.Add(this.SPGgenerateButton);
            this.securePasswordPage.Controls.Add(this.SPGpasswordsLabel);
            this.securePasswordPage.Controls.Add(this.SPGpasswordTextBox);
            this.securePasswordPage.Controls.Add(this.SPGlengthLabel);
            this.securePasswordPage.Controls.Add(this.SPGlength);
            this.securePasswordPage.Controls.Add(this.SPGnoSequentialCharsCheckBox);
            this.securePasswordPage.Controls.Add(this.SPGnoDupeCharactersCheckBox);
            this.securePasswordPage.Controls.Add(this.SPGnoSimilarCharactersCheckBox);
            this.securePasswordPage.Controls.Add(this.SPGbeginWithLetterCheckBox);
            this.securePasswordPage.Controls.Add(this.SPGincludeSymbolsCheckBox);
            this.securePasswordPage.Controls.Add(this.SPGincludeUppercaseCheckBox);
            this.securePasswordPage.Controls.Add(this.SPGincludeLowercaseCheckBox);
            this.securePasswordPage.Controls.Add(this.SPGincludeNumbersCheckBox);
            this.securePasswordPage.Location = new System.Drawing.Point(4, 22);
            this.securePasswordPage.Name = "securePasswordPage";
            this.securePasswordPage.Padding = new System.Windows.Forms.Padding(3);
            this.securePasswordPage.Size = new System.Drawing.Size(611, 228);
            this.securePasswordPage.TabIndex = 4;
            this.securePasswordPage.Text = "Generator";
            this.securePasswordPage.UseVisualStyleBackColor = true;
            // 
            // SPGexportButton
            // 
            this.SPGexportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGexportButton.Location = new System.Drawing.Point(437, 199);
            this.SPGexportButton.Name = "SPGexportButton";
            this.SPGexportButton.Size = new System.Drawing.Size(168, 23);
            this.SPGexportButton.TabIndex = 18;
            this.SPGexportButton.Text = "Export";
            this.SPGexportButton.UseVisualStyleBackColor = true;
            this.SPGexportButton.Click += new System.EventHandler(this.SPGexportButton_Click);
            // 
            // SPGquanityLabel
            // 
            this.SPGquanityLabel.AutoSize = true;
            this.SPGquanityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGquanityLabel.Location = new System.Drawing.Point(12, 152);
            this.SPGquanityLabel.Name = "SPGquanityLabel";
            this.SPGquanityLabel.Size = new System.Drawing.Size(55, 16);
            this.SPGquanityLabel.TabIndex = 17;
            this.SPGquanityLabel.Text = "Quanity:";
            // 
            // SPGquanity
            // 
            this.SPGquanity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGquanity.Location = new System.Drawing.Point(71, 150);
            this.SPGquanity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SPGquanity.Name = "SPGquanity";
            this.SPGquanity.Size = new System.Drawing.Size(227, 22);
            this.SPGquanity.TabIndex = 16;
            this.SPGquanity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SPGgenerateButton
            // 
            this.SPGgenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGgenerateButton.Location = new System.Drawing.Point(6, 182);
            this.SPGgenerateButton.Name = "SPGgenerateButton";
            this.SPGgenerateButton.Size = new System.Drawing.Size(411, 40);
            this.SPGgenerateButton.TabIndex = 15;
            this.SPGgenerateButton.Text = "Generate";
            this.SPGgenerateButton.UseVisualStyleBackColor = true;
            this.SPGgenerateButton.Click += new System.EventHandler(this.SPGgenerateButton_Click);
            // 
            // SPGpasswordsLabel
            // 
            this.SPGpasswordsLabel.AutoSize = true;
            this.SPGpasswordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGpasswordsLabel.Location = new System.Drawing.Point(447, 17);
            this.SPGpasswordsLabel.Name = "SPGpasswordsLabel";
            this.SPGpasswordsLabel.Size = new System.Drawing.Size(139, 20);
            this.SPGpasswordsLabel.TabIndex = 11;
            this.SPGpasswordsLabel.Text = "Generated Output";
            // 
            // SPGpasswordTextBox
            // 
            this.SPGpasswordTextBox.Location = new System.Drawing.Point(437, 49);
            this.SPGpasswordTextBox.Multiline = true;
            this.SPGpasswordTextBox.Name = "SPGpasswordTextBox";
            this.SPGpasswordTextBox.ReadOnly = true;
            this.SPGpasswordTextBox.Size = new System.Drawing.Size(168, 144);
            this.SPGpasswordTextBox.TabIndex = 10;
            // 
            // SPGlengthLabel
            // 
            this.SPGlengthLabel.AutoSize = true;
            this.SPGlengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGlengthLabel.Location = new System.Drawing.Point(12, 123);
            this.SPGlengthLabel.Name = "SPGlengthLabel";
            this.SPGlengthLabel.Size = new System.Drawing.Size(53, 16);
            this.SPGlengthLabel.TabIndex = 9;
            this.SPGlengthLabel.Text = "Length: ";
            // 
            // SPGlength
            // 
            this.SPGlength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGlength.Location = new System.Drawing.Point(71, 121);
            this.SPGlength.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.SPGlength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SPGlength.Name = "SPGlength";
            this.SPGlength.Size = new System.Drawing.Size(227, 22);
            this.SPGlength.TabIndex = 8;
            this.SPGlength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // SPGnoSequentialCharsCheckBox
            // 
            this.SPGnoSequentialCharsCheckBox.AutoSize = true;
            this.SPGnoSequentialCharsCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGnoSequentialCharsCheckBox.Location = new System.Drawing.Point(163, 63);
            this.SPGnoSequentialCharsCheckBox.Name = "SPGnoSequentialCharsCheckBox";
            this.SPGnoSequentialCharsCheckBox.Size = new System.Drawing.Size(185, 23);
            this.SPGnoSequentialCharsCheckBox.TabIndex = 7;
            this.SPGnoSequentialCharsCheckBox.Text = "No Sequential Characters";
            this.SPGnoSequentialCharsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SPGnoDupeCharactersCheckBox
            // 
            this.SPGnoDupeCharactersCheckBox.AutoSize = true;
            this.SPGnoDupeCharactersCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGnoDupeCharactersCheckBox.Location = new System.Drawing.Point(163, 40);
            this.SPGnoDupeCharactersCheckBox.Name = "SPGnoDupeCharactersCheckBox";
            this.SPGnoDupeCharactersCheckBox.Size = new System.Drawing.Size(187, 23);
            this.SPGnoDupeCharactersCheckBox.TabIndex = 6;
            this.SPGnoDupeCharactersCheckBox.Text = "No Duplicated Characters";
            this.SPGnoDupeCharactersCheckBox.UseVisualStyleBackColor = true;
            // 
            // SPGnoSimilarCharactersCheckBox
            // 
            this.SPGnoSimilarCharactersCheckBox.AutoSize = true;
            this.SPGnoSimilarCharactersCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGnoSimilarCharactersCheckBox.Location = new System.Drawing.Point(163, 17);
            this.SPGnoSimilarCharactersCheckBox.Name = "SPGnoSimilarCharactersCheckBox";
            this.SPGnoSimilarCharactersCheckBox.Size = new System.Drawing.Size(162, 23);
            this.SPGnoSimilarCharactersCheckBox.TabIndex = 5;
            this.SPGnoSimilarCharactersCheckBox.Text = "No Similar Characters";
            this.SPGnoSimilarCharactersCheckBox.UseVisualStyleBackColor = true;
            // 
            // SPGbeginWithLetterCheckBox
            // 
            this.SPGbeginWithLetterCheckBox.AutoSize = true;
            this.SPGbeginWithLetterCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGbeginWithLetterCheckBox.Location = new System.Drawing.Point(163, 86);
            this.SPGbeginWithLetterCheckBox.Name = "SPGbeginWithLetterCheckBox";
            this.SPGbeginWithLetterCheckBox.Size = new System.Drawing.Size(135, 23);
            this.SPGbeginWithLetterCheckBox.TabIndex = 4;
            this.SPGbeginWithLetterCheckBox.Text = "Begin With Letter";
            this.SPGbeginWithLetterCheckBox.UseVisualStyleBackColor = true;
            // 
            // SPGincludeSymbolsCheckBox
            // 
            this.SPGincludeSymbolsCheckBox.AutoSize = true;
            this.SPGincludeSymbolsCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGincludeSymbolsCheckBox.Location = new System.Drawing.Point(15, 86);
            this.SPGincludeSymbolsCheckBox.Name = "SPGincludeSymbolsCheckBox";
            this.SPGincludeSymbolsCheckBox.Size = new System.Drawing.Size(129, 23);
            this.SPGincludeSymbolsCheckBox.TabIndex = 3;
            this.SPGincludeSymbolsCheckBox.Text = "Include Symbols";
            this.SPGincludeSymbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SPGincludeUppercaseCheckBox
            // 
            this.SPGincludeUppercaseCheckBox.AutoSize = true;
            this.SPGincludeUppercaseCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGincludeUppercaseCheckBox.Location = new System.Drawing.Point(15, 17);
            this.SPGincludeUppercaseCheckBox.Name = "SPGincludeUppercaseCheckBox";
            this.SPGincludeUppercaseCheckBox.Size = new System.Drawing.Size(142, 23);
            this.SPGincludeUppercaseCheckBox.TabIndex = 2;
            this.SPGincludeUppercaseCheckBox.Text = "Include Uppercase";
            this.SPGincludeUppercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // SPGincludeLowercaseCheckBox
            // 
            this.SPGincludeLowercaseCheckBox.AutoSize = true;
            this.SPGincludeLowercaseCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGincludeLowercaseCheckBox.Location = new System.Drawing.Point(15, 40);
            this.SPGincludeLowercaseCheckBox.Name = "SPGincludeLowercaseCheckBox";
            this.SPGincludeLowercaseCheckBox.Size = new System.Drawing.Size(141, 23);
            this.SPGincludeLowercaseCheckBox.TabIndex = 1;
            this.SPGincludeLowercaseCheckBox.Text = "Include Lowercase";
            this.SPGincludeLowercaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // SPGincludeNumbersCheckBox
            // 
            this.SPGincludeNumbersCheckBox.AutoSize = true;
            this.SPGincludeNumbersCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPGincludeNumbersCheckBox.Location = new System.Drawing.Point(15, 63);
            this.SPGincludeNumbersCheckBox.Name = "SPGincludeNumbersCheckBox";
            this.SPGincludeNumbersCheckBox.Size = new System.Drawing.Size(134, 23);
            this.SPGincludeNumbersCheckBox.TabIndex = 0;
            this.SPGincludeNumbersCheckBox.Text = "Include Numbers";
            this.SPGincludeNumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // logPage
            // 
            this.logPage.Controls.Add(this.logTextBox);
            this.logPage.Controls.Add(this.performanceLabel);
            this.logPage.Controls.Add(this.logLabel);
            this.logPage.Location = new System.Drawing.Point(4, 22);
            this.logPage.Name = "logPage";
            this.logPage.Padding = new System.Windows.Forms.Padding(3);
            this.logPage.Size = new System.Drawing.Size(611, 228);
            this.logPage.TabIndex = 5;
            this.logPage.Text = "Log";
            this.logPage.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(20, 32);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(567, 161);
            this.logTextBox.TabIndex = 5;
            // 
            // performanceLabel
            // 
            this.performanceLabel.AutoSize = true;
            this.performanceLabel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performanceLabel.Location = new System.Drawing.Point(17, 196);
            this.performanceLabel.Name = "performanceLabel";
            this.performanceLabel.Size = new System.Drawing.Size(147, 20);
            this.performanceLabel.TabIndex = 4;
            this.performanceLabel.Text = "CPU: 0% | RAM: 0%";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.Location = new System.Drawing.Point(18, 9);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(30, 16);
            this.logLabel.TabIndex = 0;
            this.logLabel.Text = "Log";
            // 
            // fileStatus
            // 
            this.fileStatus.AutoSize = true;
            this.fileStatus.Location = new System.Drawing.Point(16, 277);
            this.fileStatus.Name = "fileStatus";
            this.fileStatus.Size = new System.Drawing.Size(0, 13);
            this.fileStatus.TabIndex = 12;
            // 
            // CPUperformance
            // 
            this.CPUperformance.CategoryName = "Processor";
            this.CPUperformance.CounterName = "% Processor Time";
            this.CPUperformance.InstanceName = "_Total";
            // 
            // RAMperformance
            // 
            this.RAMperformance.CategoryName = "Memory";
            this.RAMperformance.CounterName = "Available MBytes";
            // 
            // performanceTimer
            // 
            this.performanceTimer.Interval = 1000;
            this.performanceTimer.Tick += new System.EventHandler(this.performanceTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 297);
            this.Controls.Add(this.fileStatus);
            this.Controls.Add(this.topbarStrip);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topbarStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Passe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBindingSource)).EndInit();
            this.topbarStrip.ResumeLayout(false);
            this.topbarStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.managementPage.ResumeLayout(false);
            this.managementPage.PerformLayout();
            this.encryptionPage.ResumeLayout(false);
            this.encryptionPage.PerformLayout();
            this.strengthMeterPage.ResumeLayout(false);
            this.strengthMeterPage.PerformLayout();
            this.securePasswordPage.ResumeLayout(false);
            this.securePasswordPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPGquanity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPGlength)).EndInit();
            this.logPage.ResumeLayout(false);
            this.logPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPUperformance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAMperformance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myPasswordsLabel;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.DataGridView passwordDataGrid;
        private System.Windows.Forms.BindingSource dataGridBindingSource;
        private System.Windows.Forms.ComboBox fileTypeComboBox;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn webisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip mainTooltip;
        private System.Windows.Forms.CheckBox liveValuesCheckBox;
        private System.Windows.Forms.MenuStrip topbarStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordsFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainFolderToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage managementPage;
        private System.Windows.Forms.TabPage encryptionPage;
        private System.Windows.Forms.Label encryptionTitleLabel;
        private System.Windows.Forms.Label EPhashLabel;
        private System.Windows.Forms.Button EecryptButton;
        private System.Windows.Forms.TextBox EhashTextBox;
        private System.Windows.Forms.TextBox EpasswordTextbox;
        private System.Windows.Forms.Button EcopyResultButton;
        private System.Windows.Forms.Label EPpasswordLabel;
        private System.Windows.Forms.Button EdecryptButton;
        private System.Windows.Forms.TextBox EencryptedResult;
        private System.Windows.Forms.Label EPresultLabel;
        private System.Windows.Forms.TabPage strengthMeterPage;
        private System.Windows.Forms.TextBox SMpasswordTextBox;
        private System.Windows.Forms.Label strengthMeterTitle;
        private System.Windows.Forms.Label SMpasswordLabel;
        private System.Windows.Forms.Label SMminLengthLabel;
        private System.Windows.Forms.Label SMmaxLengthLabel;
        private System.Windows.Forms.Label SMlowercaseLettersLabel;
        private System.Windows.Forms.Label SMuppercaseLabel;
        private System.Windows.Forms.Label SMdigitCountLabel;
        private System.Windows.Forms.Label SMspecialAmountLabel;
        private System.Windows.Forms.Label SMscoreLabel;
        private System.Windows.Forms.Panel SMexcellentPanel;
        private System.Windows.Forms.Panel SMgreatPanel;
        private System.Windows.Forms.Panel SMgoodPanel;
        private System.Windows.Forms.Panel SMbetterPanel;
        private System.Windows.Forms.Panel SMdecentPanel;
        private System.Windows.Forms.Panel SMokayPanel;
        private System.Windows.Forms.Panel SMbadPanel;
        private System.Windows.Forms.Panel SMbottomPanel;
        private System.Windows.Forms.TabPage securePasswordPage;
        private System.Windows.Forms.CheckBox SPGnoSequentialCharsCheckBox;
        private System.Windows.Forms.CheckBox SPGnoDupeCharactersCheckBox;
        private System.Windows.Forms.CheckBox SPGnoSimilarCharactersCheckBox;
        private System.Windows.Forms.CheckBox SPGbeginWithLetterCheckBox;
        private System.Windows.Forms.CheckBox SPGincludeSymbolsCheckBox;
        private System.Windows.Forms.CheckBox SPGincludeUppercaseCheckBox;
        private System.Windows.Forms.CheckBox SPGincludeLowercaseCheckBox;
        private System.Windows.Forms.CheckBox SPGincludeNumbersCheckBox;
        private System.Windows.Forms.Label SPGlengthLabel;
        private System.Windows.Forms.NumericUpDown SPGlength;
        private System.Windows.Forms.Button SPGgenerateButton;
        private System.Windows.Forms.Label SPGpasswordsLabel;
        private System.Windows.Forms.TextBox SPGpasswordTextBox;
        private System.Windows.Forms.Label SPGquanityLabel;
        private System.Windows.Forms.NumericUpDown SPGquanity;
        private System.Windows.Forms.Button SPGexportButton;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFirewallRuleToolStripMenuItem;
        private System.Windows.Forms.Label fileStatus;
        private System.Windows.Forms.TabPage logPage;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label performanceLabel;
        private System.Diagnostics.PerformanceCounter CPUperformance;
        private System.Diagnostics.PerformanceCounter RAMperformance;
        private System.Windows.Forms.Timer performanceTimer;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button refreshButton;
    }
}

