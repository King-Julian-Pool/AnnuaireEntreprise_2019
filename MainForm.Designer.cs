
namespace AnnuaireEntreprise_2019
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Salarie = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_Filtre = new System.Windows.Forms.GroupBox();
            this.button_ReinitialiserFiltre = new System.Windows.Forms.Button();
            this.checkedListBox_Service = new System.Windows.Forms.CheckedListBox();
            this.label_Service = new System.Windows.Forms.Label();
            this.checkedListBox_Site = new System.Windows.Forms.CheckedListBox();
            this.label_Site = new System.Windows.Forms.Label();
            this.textBox_NomPrenom = new System.Windows.Forms.TextBox();
            this.label_NomPrenom = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Salarie = new System.Windows.Forms.DataGridView();
            this.oidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneFixeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephonePortableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox_Service = new System.Windows.Forms.GroupBox();
            this.comboBox_Service = new System.Windows.Forms.ComboBox();
            this.groupBox_Site = new System.Windows.Forms.GroupBox();
            this.comboBox_Site = new System.Windows.Forms.ComboBox();
            this.groupBox_Email = new System.Windows.Forms.GroupBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.groupBox_TelephonePortable = new System.Windows.Forms.GroupBox();
            this.textBox_TelephonePortable = new System.Windows.Forms.TextBox();
            this.groupBox_TelephoneFixe = new System.Windows.Forms.GroupBox();
            this.textBox_TelephoneFixe = new System.Windows.Forms.TextBox();
            this.groupBox_Prenom = new System.Windows.Forms.GroupBox();
            this.textBox_Prenom = new System.Windows.Forms.TextBox();
            this.groupBox_Nom = new System.Windows.Forms.GroupBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.button_AnnulerSalarie = new System.Windows.Forms.Button();
            this.button_SauvegarderSalarie = new System.Windows.Forms.Button();
            this.button_SupprimerSalarie = new System.Windows.Forms.Button();
            this.button_NouveauSalarie = new System.Windows.Forms.Button();
            this.tabPage_Site = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Site = new System.Windows.Forms.DataGridView();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.button_SupprimerSite = new System.Windows.Forms.Button();
            this.button_NouveauSite = new System.Windows.Forms.Button();
            this.tabPage_Service = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Service = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.button_SupprimerService = new System.Windows.Forms.Button();
            this.button_NouveauService = new System.Windows.Forms.Button();
            this.tabPage_Utilisateurs = new System.Windows.Forms.TabPage();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Utilisateur = new System.Windows.Forms.DataGridView();
            this.identifiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motDePasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.button_SupprimerUtilisateur = new System.Windows.Forms.Button();
            this.button_NouveauUtilisateur = new System.Windows.Forms.Button();
            this.session = new DevExpress.Xpo.Session(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Connexion = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ConnexionStatut = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem_Detail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Filtre = new System.Windows.Forms.ToolStripMenuItem();
            this.sommaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnaliserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sélectionnertoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.xpView_Site = new DevExpress.Xpo.XPView(this.components);
            this.xpView_Service = new DevExpress.Xpo.XPView(this.components);
            this.xpCollection_Utilisateur = new DevExpress.Xpo.XPCollection(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage_Salarie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_Filtre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Salarie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox_Service.SuspendLayout();
            this.groupBox_Site.SuspendLayout();
            this.groupBox_Email.SuspendLayout();
            this.groupBox_TelephonePortable.SuspendLayout();
            this.groupBox_TelephoneFixe.SuspendLayout();
            this.groupBox_Prenom.SuspendLayout();
            this.groupBox_Nom.SuspendLayout();
            this.tabPage_Site.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Site)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tabPage_Service.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.tabPage_Utilisateurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Utilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpView_Site)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView_Service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Utilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Salarie);
            this.tabControl1.Controls.Add(this.tabPage_Site);
            this.tabControl1.Controls.Add(this.tabPage_Service);
            this.tabControl1.Controls.Add(this.tabPage_Utilisateurs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1371, 583);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Salarie
            // 
            this.tabPage_Salarie.Controls.Add(this.splitContainer1);
            this.tabPage_Salarie.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Salarie.Name = "tabPage_Salarie";
            this.tabPage_Salarie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Salarie.Size = new System.Drawing.Size(1363, 554);
            this.tabPage_Salarie.TabIndex = 0;
            this.tabPage_Salarie.Text = "Salaries";
            this.tabPage_Salarie.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Filtre);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1357, 548);
            this.splitContainer1.SplitterDistance = 177;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox_Filtre
            // 
            this.groupBox_Filtre.Controls.Add(this.button_ReinitialiserFiltre);
            this.groupBox_Filtre.Controls.Add(this.checkedListBox_Service);
            this.groupBox_Filtre.Controls.Add(this.label_Service);
            this.groupBox_Filtre.Controls.Add(this.checkedListBox_Site);
            this.groupBox_Filtre.Controls.Add(this.label_Site);
            this.groupBox_Filtre.Controls.Add(this.textBox_NomPrenom);
            this.groupBox_Filtre.Controls.Add(this.label_NomPrenom);
            this.groupBox_Filtre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Filtre.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Filtre.Name = "groupBox_Filtre";
            this.groupBox_Filtre.Size = new System.Drawing.Size(175, 546);
            this.groupBox_Filtre.TabIndex = 0;
            this.groupBox_Filtre.TabStop = false;
            this.groupBox_Filtre.Text = "Filtres";
            // 
            // button_ReinitialiserFiltre
            // 
            this.button_ReinitialiserFiltre.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ReinitialiserFiltre.Location = new System.Drawing.Point(3, 269);
            this.button_ReinitialiserFiltre.Name = "button_ReinitialiserFiltre";
            this.button_ReinitialiserFiltre.Size = new System.Drawing.Size(169, 23);
            this.button_ReinitialiserFiltre.TabIndex = 6;
            this.button_ReinitialiserFiltre.Text = "Réinitialiser";
            this.button_ReinitialiserFiltre.UseVisualStyleBackColor = true;
            this.button_ReinitialiserFiltre.Click += new System.EventHandler(this.button_Click);
            // 
            // checkedListBox_Service
            // 
            this.checkedListBox_Service.CheckOnClick = true;
            this.checkedListBox_Service.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Service.FormattingEnabled = true;
            this.checkedListBox_Service.Location = new System.Drawing.Point(3, 180);
            this.checkedListBox_Service.Name = "checkedListBox_Service";
            this.checkedListBox_Service.Size = new System.Drawing.Size(169, 89);
            this.checkedListBox_Service.TabIndex = 5;
            this.checkedListBox_Service.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // label_Service
            // 
            this.label_Service.AutoSize = true;
            this.label_Service.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Service.Location = new System.Drawing.Point(3, 163);
            this.label_Service.Name = "label_Service";
            this.label_Service.Size = new System.Drawing.Size(55, 17);
            this.label_Service.TabIndex = 4;
            this.label_Service.Text = "Service";
            // 
            // checkedListBox_Site
            // 
            this.checkedListBox_Site.CheckOnClick = true;
            this.checkedListBox_Site.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox_Site.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Site.FormattingEnabled = true;
            this.checkedListBox_Site.Location = new System.Drawing.Point(3, 74);
            this.checkedListBox_Site.Name = "checkedListBox_Site";
            this.checkedListBox_Site.Size = new System.Drawing.Size(169, 89);
            this.checkedListBox_Site.TabIndex = 3;
            this.checkedListBox_Site.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_ItemCheck);
            // 
            // label_Site
            // 
            this.label_Site.AutoSize = true;
            this.label_Site.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Site.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Site.Location = new System.Drawing.Point(3, 57);
            this.label_Site.Name = "label_Site";
            this.label_Site.Size = new System.Drawing.Size(32, 17);
            this.label_Site.TabIndex = 2;
            this.label_Site.Text = "Site";
            // 
            // textBox_NomPrenom
            // 
            this.textBox_NomPrenom.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_NomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NomPrenom.Location = new System.Drawing.Point(3, 35);
            this.textBox_NomPrenom.Name = "textBox_NomPrenom";
            this.textBox_NomPrenom.Size = new System.Drawing.Size(169, 22);
            this.textBox_NomPrenom.TabIndex = 1;
            this.textBox_NomPrenom.TextChanged += new System.EventHandler(this.textBox_NomPrenom_TextChanged);
            // 
            // label_NomPrenom
            // 
            this.label_NomPrenom.AutoSize = true;
            this.label_NomPrenom.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_NomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NomPrenom.Location = new System.Drawing.Point(3, 18);
            this.label_NomPrenom.Name = "label_NomPrenom";
            this.label_NomPrenom.Size = new System.Drawing.Size(90, 17);
            this.label_NomPrenom.TabIndex = 0;
            this.label_NomPrenom.Text = "Nom/Prénom";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView_Salarie);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1170, 548);
            this.splitContainer2.SplitterDistance = 940;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView_Salarie
            // 
            this.dataGridView_Salarie.AllowUserToAddRows = false;
            this.dataGridView_Salarie.AllowUserToDeleteRows = false;
            this.dataGridView_Salarie.AllowUserToOrderColumns = true;
            this.dataGridView_Salarie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Salarie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oidDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.telephoneFixeDataGridViewTextBoxColumn,
            this.telephonePortableDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.siteDataGridViewTextBoxColumn,
            this.serviceKeyDataGridViewTextBoxColumn});
            this.dataGridView_Salarie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Salarie.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Salarie.MultiSelect = false;
            this.dataGridView_Salarie.Name = "dataGridView_Salarie";
            this.dataGridView_Salarie.ReadOnly = true;
            this.dataGridView_Salarie.RowHeadersWidth = 51;
            this.dataGridView_Salarie.RowTemplate.Height = 24;
            this.dataGridView_Salarie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Salarie.Size = new System.Drawing.Size(938, 546);
            this.dataGridView_Salarie.TabIndex = 0;
            this.dataGridView_Salarie.SelectionChanged += new System.EventHandler(this.dataGridView_Salarie_SelectionChanged);
            // 
            // oidDataGridViewTextBoxColumn
            // 
            this.oidDataGridViewTextBoxColumn.DataPropertyName = "Oid";
            this.oidDataGridViewTextBoxColumn.HeaderText = "Oid";
            this.oidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oidDataGridViewTextBoxColumn.Name = "oidDataGridViewTextBoxColumn";
            this.oidDataGridViewTextBoxColumn.ReadOnly = true;
            this.oidDataGridViewTextBoxColumn.Visible = false;
            this.oidDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 125;
            // 
            // telephoneFixeDataGridViewTextBoxColumn
            // 
            this.telephoneFixeDataGridViewTextBoxColumn.DataPropertyName = "TelephoneFixe";
            this.telephoneFixeDataGridViewTextBoxColumn.HeaderText = "Télephone fixe";
            this.telephoneFixeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephoneFixeDataGridViewTextBoxColumn.Name = "telephoneFixeDataGridViewTextBoxColumn";
            this.telephoneFixeDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephoneFixeDataGridViewTextBoxColumn.Width = 125;
            // 
            // telephonePortableDataGridViewTextBoxColumn
            // 
            this.telephonePortableDataGridViewTextBoxColumn.DataPropertyName = "TelephonePortable";
            this.telephonePortableDataGridViewTextBoxColumn.HeaderText = "Télephone portable";
            this.telephonePortableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephonePortableDataGridViewTextBoxColumn.Name = "telephonePortableDataGridViewTextBoxColumn";
            this.telephonePortableDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephonePortableDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // siteDataGridViewTextBoxColumn
            // 
            this.siteDataGridViewTextBoxColumn.DataPropertyName = "SiteVille";
            this.siteDataGridViewTextBoxColumn.HeaderText = "Site";
            this.siteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siteDataGridViewTextBoxColumn.Name = "siteDataGridViewTextBoxColumn";
            this.siteDataGridViewTextBoxColumn.ReadOnly = true;
            this.siteDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceKeyDataGridViewTextBoxColumn
            // 
            this.serviceKeyDataGridViewTextBoxColumn.DataPropertyName = "ServiceNom";
            this.serviceKeyDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceKeyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceKeyDataGridViewTextBoxColumn.Name = "serviceKeyDataGridViewTextBoxColumn";
            this.serviceKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceKeyDataGridViewTextBoxColumn.Width = 125;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_Service);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_Site);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_Email);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_TelephonePortable);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_TelephoneFixe);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_Prenom);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox_Nom);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.button_AnnulerSalarie);
            this.splitContainer3.Panel2.Controls.Add(this.button_SauvegarderSalarie);
            this.splitContainer3.Panel2.Controls.Add(this.button_SupprimerSalarie);
            this.splitContainer3.Panel2.Controls.Add(this.button_NouveauSalarie);
            this.splitContainer3.Size = new System.Drawing.Size(218, 546);
            this.splitContainer3.SplitterDistance = 437;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox_Service
            // 
            this.groupBox_Service.Controls.Add(this.comboBox_Service);
            this.groupBox_Service.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Service.Location = new System.Drawing.Point(0, 342);
            this.groupBox_Service.Name = "groupBox_Service";
            this.groupBox_Service.Size = new System.Drawing.Size(218, 57);
            this.groupBox_Service.TabIndex = 6;
            this.groupBox_Service.TabStop = false;
            this.groupBox_Service.Text = "Service";
            // 
            // comboBox_Service
            // 
            this.comboBox_Service.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Service.Enabled = false;
            this.comboBox_Service.FormattingEnabled = true;
            this.comboBox_Service.Location = new System.Drawing.Point(3, 18);
            this.comboBox_Service.Name = "comboBox_Service";
            this.comboBox_Service.Size = new System.Drawing.Size(212, 24);
            this.comboBox_Service.TabIndex = 6;
            this.comboBox_Service.Tag = "Service";
            // 
            // groupBox_Site
            // 
            this.groupBox_Site.Controls.Add(this.comboBox_Site);
            this.groupBox_Site.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Site.Location = new System.Drawing.Point(0, 285);
            this.groupBox_Site.Name = "groupBox_Site";
            this.groupBox_Site.Size = new System.Drawing.Size(218, 57);
            this.groupBox_Site.TabIndex = 5;
            this.groupBox_Site.TabStop = false;
            this.groupBox_Site.Text = "Site";
            // 
            // comboBox_Site
            // 
            this.comboBox_Site.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Site.Enabled = false;
            this.comboBox_Site.FormattingEnabled = true;
            this.comboBox_Site.Location = new System.Drawing.Point(3, 18);
            this.comboBox_Site.Name = "comboBox_Site";
            this.comboBox_Site.Size = new System.Drawing.Size(212, 24);
            this.comboBox_Site.TabIndex = 5;
            this.comboBox_Site.Tag = "Site";
            // 
            // groupBox_Email
            // 
            this.groupBox_Email.Controls.Add(this.textBox_Email);
            this.groupBox_Email.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Email.Location = new System.Drawing.Point(0, 228);
            this.groupBox_Email.Name = "groupBox_Email";
            this.groupBox_Email.Size = new System.Drawing.Size(218, 57);
            this.groupBox_Email.TabIndex = 4;
            this.groupBox_Email.TabStop = false;
            this.groupBox_Email.Text = "Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Email.Location = new System.Drawing.Point(3, 18);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.ReadOnly = true;
            this.textBox_Email.Size = new System.Drawing.Size(212, 22);
            this.textBox_Email.TabIndex = 4;
            this.textBox_Email.Tag = "Email";
            // 
            // groupBox_TelephonePortable
            // 
            this.groupBox_TelephonePortable.Controls.Add(this.textBox_TelephonePortable);
            this.groupBox_TelephonePortable.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_TelephonePortable.Location = new System.Drawing.Point(0, 171);
            this.groupBox_TelephonePortable.Name = "groupBox_TelephonePortable";
            this.groupBox_TelephonePortable.Size = new System.Drawing.Size(218, 57);
            this.groupBox_TelephonePortable.TabIndex = 3;
            this.groupBox_TelephonePortable.TabStop = false;
            this.groupBox_TelephonePortable.Text = "Téléphone portable";
            // 
            // textBox_TelephonePortable
            // 
            this.textBox_TelephonePortable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TelephonePortable.Location = new System.Drawing.Point(3, 18);
            this.textBox_TelephonePortable.Name = "textBox_TelephonePortable";
            this.textBox_TelephonePortable.ReadOnly = true;
            this.textBox_TelephonePortable.Size = new System.Drawing.Size(212, 22);
            this.textBox_TelephonePortable.TabIndex = 3;
            this.textBox_TelephonePortable.Tag = "TelephonePortable";
            // 
            // groupBox_TelephoneFixe
            // 
            this.groupBox_TelephoneFixe.Controls.Add(this.textBox_TelephoneFixe);
            this.groupBox_TelephoneFixe.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_TelephoneFixe.Location = new System.Drawing.Point(0, 114);
            this.groupBox_TelephoneFixe.Name = "groupBox_TelephoneFixe";
            this.groupBox_TelephoneFixe.Size = new System.Drawing.Size(218, 57);
            this.groupBox_TelephoneFixe.TabIndex = 2;
            this.groupBox_TelephoneFixe.TabStop = false;
            this.groupBox_TelephoneFixe.Text = "Téléphone fixe";
            // 
            // textBox_TelephoneFixe
            // 
            this.textBox_TelephoneFixe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TelephoneFixe.Location = new System.Drawing.Point(3, 18);
            this.textBox_TelephoneFixe.Name = "textBox_TelephoneFixe";
            this.textBox_TelephoneFixe.ReadOnly = true;
            this.textBox_TelephoneFixe.Size = new System.Drawing.Size(212, 22);
            this.textBox_TelephoneFixe.TabIndex = 2;
            this.textBox_TelephoneFixe.Tag = "TelephoneFixe";
            // 
            // groupBox_Prenom
            // 
            this.groupBox_Prenom.Controls.Add(this.textBox_Prenom);
            this.groupBox_Prenom.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Prenom.Location = new System.Drawing.Point(0, 57);
            this.groupBox_Prenom.Name = "groupBox_Prenom";
            this.groupBox_Prenom.Size = new System.Drawing.Size(218, 57);
            this.groupBox_Prenom.TabIndex = 1;
            this.groupBox_Prenom.TabStop = false;
            this.groupBox_Prenom.Text = "Prénom";
            // 
            // textBox_Prenom
            // 
            this.textBox_Prenom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Prenom.Location = new System.Drawing.Point(3, 18);
            this.textBox_Prenom.Name = "textBox_Prenom";
            this.textBox_Prenom.ReadOnly = true;
            this.textBox_Prenom.Size = new System.Drawing.Size(212, 22);
            this.textBox_Prenom.TabIndex = 1;
            this.textBox_Prenom.Tag = "Prenom";
            // 
            // groupBox_Nom
            // 
            this.groupBox_Nom.Controls.Add(this.textBox_Nom);
            this.groupBox_Nom.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Nom.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Nom.Name = "groupBox_Nom";
            this.groupBox_Nom.Size = new System.Drawing.Size(218, 57);
            this.groupBox_Nom.TabIndex = 0;
            this.groupBox_Nom.TabStop = false;
            this.groupBox_Nom.Text = "Nom";
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Nom.Location = new System.Drawing.Point(3, 18);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.ReadOnly = true;
            this.textBox_Nom.Size = new System.Drawing.Size(212, 22);
            this.textBox_Nom.TabIndex = 0;
            this.textBox_Nom.Tag = "Nom";
            // 
            // button_AnnulerSalarie
            // 
            this.button_AnnulerSalarie.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_AnnulerSalarie.Location = new System.Drawing.Point(0, 90);
            this.button_AnnulerSalarie.Name = "button_AnnulerSalarie";
            this.button_AnnulerSalarie.Size = new System.Drawing.Size(218, 30);
            this.button_AnnulerSalarie.TabIndex = 3;
            this.button_AnnulerSalarie.Text = "Annuler";
            this.button_AnnulerSalarie.UseVisualStyleBackColor = true;
            this.button_AnnulerSalarie.Visible = false;
            this.button_AnnulerSalarie.Click += new System.EventHandler(this.button_Click);
            // 
            // button_SauvegarderSalarie
            // 
            this.button_SauvegarderSalarie.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_SauvegarderSalarie.Location = new System.Drawing.Point(0, 60);
            this.button_SauvegarderSalarie.Name = "button_SauvegarderSalarie";
            this.button_SauvegarderSalarie.Size = new System.Drawing.Size(218, 30);
            this.button_SauvegarderSalarie.TabIndex = 2;
            this.button_SauvegarderSalarie.Text = "Sauvegarder";
            this.button_SauvegarderSalarie.UseVisualStyleBackColor = true;
            this.button_SauvegarderSalarie.Visible = false;
            this.button_SauvegarderSalarie.Click += new System.EventHandler(this.button_Click);
            // 
            // button_SupprimerSalarie
            // 
            this.button_SupprimerSalarie.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_SupprimerSalarie.Location = new System.Drawing.Point(0, 30);
            this.button_SupprimerSalarie.Name = "button_SupprimerSalarie";
            this.button_SupprimerSalarie.Size = new System.Drawing.Size(218, 30);
            this.button_SupprimerSalarie.TabIndex = 1;
            this.button_SupprimerSalarie.Text = "Supprimer";
            this.button_SupprimerSalarie.UseVisualStyleBackColor = true;
            this.button_SupprimerSalarie.Visible = false;
            this.button_SupprimerSalarie.Click += new System.EventHandler(this.button_Click);
            // 
            // button_NouveauSalarie
            // 
            this.button_NouveauSalarie.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_NouveauSalarie.Location = new System.Drawing.Point(0, 0);
            this.button_NouveauSalarie.Name = "button_NouveauSalarie";
            this.button_NouveauSalarie.Size = new System.Drawing.Size(218, 30);
            this.button_NouveauSalarie.TabIndex = 0;
            this.button_NouveauSalarie.Text = "Nouveau";
            this.button_NouveauSalarie.UseVisualStyleBackColor = true;
            this.button_NouveauSalarie.Visible = false;
            this.button_NouveauSalarie.Click += new System.EventHandler(this.button_Click);
            // 
            // tabPage_Site
            // 
            this.tabPage_Site.Controls.Add(this.splitContainer4);
            this.tabPage_Site.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Site.Name = "tabPage_Site";
            this.tabPage_Site.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Site.Size = new System.Drawing.Size(1363, 554);
            this.tabPage_Site.TabIndex = 1;
            this.tabPage_Site.Text = "Sites";
            this.tabPage_Site.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataGridView_Site);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(1357, 548);
            this.splitContainer4.SplitterDistance = 1074;
            this.splitContainer4.SplitterWidth = 10;
            this.splitContainer4.TabIndex = 1;
            // 
            // dataGridView_Site
            // 
            this.dataGridView_Site.AllowUserToAddRows = false;
            this.dataGridView_Site.AllowUserToDeleteRows = false;
            this.dataGridView_Site.AllowUserToOrderColumns = true;
            this.dataGridView_Site.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Site.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ville});
            this.dataGridView_Site.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Site.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Site.MultiSelect = false;
            this.dataGridView_Site.Name = "dataGridView_Site";
            this.dataGridView_Site.RowHeadersWidth = 51;
            this.dataGridView_Site.RowTemplate.Height = 24;
            this.dataGridView_Site.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Site.Size = new System.Drawing.Size(1072, 546);
            this.dataGridView_Site.TabIndex = 0;
            // 
            // Ville
            // 
            this.Ville.DataPropertyName = "Ville";
            this.Ville.HeaderText = "Ville";
            this.Ville.MinimumWidth = 6;
            this.Ville.Name = "Ville";
            this.Ville.Width = 125;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.button_SupprimerSite);
            this.splitContainer5.Panel2.Controls.Add(this.button_NouveauSite);
            this.splitContainer5.Size = new System.Drawing.Size(271, 546);
            this.splitContainer5.SplitterDistance = 437;
            this.splitContainer5.TabIndex = 0;
            // 
            // button_SupprimerSite
            // 
            this.button_SupprimerSite.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_SupprimerSite.Location = new System.Drawing.Point(0, 30);
            this.button_SupprimerSite.Name = "button_SupprimerSite";
            this.button_SupprimerSite.Size = new System.Drawing.Size(271, 30);
            this.button_SupprimerSite.TabIndex = 1;
            this.button_SupprimerSite.Text = "Supprimer";
            this.button_SupprimerSite.UseVisualStyleBackColor = true;
            this.button_SupprimerSite.Click += new System.EventHandler(this.button_Click);
            // 
            // button_NouveauSite
            // 
            this.button_NouveauSite.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_NouveauSite.Location = new System.Drawing.Point(0, 0);
            this.button_NouveauSite.Name = "button_NouveauSite";
            this.button_NouveauSite.Size = new System.Drawing.Size(271, 30);
            this.button_NouveauSite.TabIndex = 0;
            this.button_NouveauSite.Text = "Nouveau";
            this.button_NouveauSite.UseVisualStyleBackColor = true;
            this.button_NouveauSite.Click += new System.EventHandler(this.button_Click);
            // 
            // tabPage_Service
            // 
            this.tabPage_Service.Controls.Add(this.splitContainer6);
            this.tabPage_Service.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Service.Name = "tabPage_Service";
            this.tabPage_Service.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Service.Size = new System.Drawing.Size(1363, 554);
            this.tabPage_Service.TabIndex = 2;
            this.tabPage_Service.Text = "Services";
            this.tabPage_Service.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.dataGridView_Service);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer6.Size = new System.Drawing.Size(1357, 548);
            this.splitContainer6.SplitterDistance = 1074;
            this.splitContainer6.SplitterWidth = 10;
            this.splitContainer6.TabIndex = 2;
            // 
            // dataGridView_Service
            // 
            this.dataGridView_Service.AllowUserToAddRows = false;
            this.dataGridView_Service.AllowUserToDeleteRows = false;
            this.dataGridView_Service.AllowUserToOrderColumns = true;
            this.dataGridView_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn1});
            this.dataGridView_Service.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Service.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Service.MultiSelect = false;
            this.dataGridView_Service.Name = "dataGridView_Service";
            this.dataGridView_Service.RowHeadersWidth = 51;
            this.dataGridView_Service.RowTemplate.Height = 24;
            this.dataGridView_Service.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Service.Size = new System.Drawing.Size(1072, 546);
            this.dataGridView_Service.TabIndex = 0;
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            this.nomDataGridViewTextBoxColumn1.Width = 125;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.button_SupprimerService);
            this.splitContainer7.Panel2.Controls.Add(this.button_NouveauService);
            this.splitContainer7.Size = new System.Drawing.Size(271, 546);
            this.splitContainer7.SplitterDistance = 437;
            this.splitContainer7.TabIndex = 0;
            // 
            // button_SupprimerService
            // 
            this.button_SupprimerService.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_SupprimerService.Location = new System.Drawing.Point(0, 30);
            this.button_SupprimerService.Name = "button_SupprimerService";
            this.button_SupprimerService.Size = new System.Drawing.Size(271, 30);
            this.button_SupprimerService.TabIndex = 1;
            this.button_SupprimerService.Text = "Supprimer";
            this.button_SupprimerService.UseVisualStyleBackColor = true;
            this.button_SupprimerService.Click += new System.EventHandler(this.button_Click);
            // 
            // button_NouveauService
            // 
            this.button_NouveauService.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_NouveauService.Location = new System.Drawing.Point(0, 0);
            this.button_NouveauService.Name = "button_NouveauService";
            this.button_NouveauService.Size = new System.Drawing.Size(271, 30);
            this.button_NouveauService.TabIndex = 0;
            this.button_NouveauService.Text = "Nouveau";
            this.button_NouveauService.UseVisualStyleBackColor = true;
            this.button_NouveauService.Click += new System.EventHandler(this.button_Click);
            // 
            // tabPage_Utilisateurs
            // 
            this.tabPage_Utilisateurs.Controls.Add(this.splitContainer8);
            this.tabPage_Utilisateurs.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Utilisateurs.Name = "tabPage_Utilisateurs";
            this.tabPage_Utilisateurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Utilisateurs.Size = new System.Drawing.Size(1363, 554);
            this.tabPage_Utilisateurs.TabIndex = 3;
            this.tabPage_Utilisateurs.Text = "Utilisateurs";
            this.tabPage_Utilisateurs.UseVisualStyleBackColor = true;
            // 
            // splitContainer8
            // 
            this.splitContainer8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer8.Location = new System.Drawing.Point(3, 3);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.dataGridView_Utilisateur);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.splitContainer9);
            this.splitContainer8.Size = new System.Drawing.Size(1357, 548);
            this.splitContainer8.SplitterDistance = 1074;
            this.splitContainer8.SplitterWidth = 10;
            this.splitContainer8.TabIndex = 3;
            // 
            // dataGridView_Utilisateur
            // 
            this.dataGridView_Utilisateur.AllowUserToAddRows = false;
            this.dataGridView_Utilisateur.AllowUserToDeleteRows = false;
            this.dataGridView_Utilisateur.AllowUserToOrderColumns = true;
            this.dataGridView_Utilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Utilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifiantDataGridViewTextBoxColumn,
            this.motDePasseDataGridViewTextBoxColumn,
            this.adminDataGridViewCheckBoxColumn});
            this.dataGridView_Utilisateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Utilisateur.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Utilisateur.MultiSelect = false;
            this.dataGridView_Utilisateur.Name = "dataGridView_Utilisateur";
            this.dataGridView_Utilisateur.RowHeadersWidth = 51;
            this.dataGridView_Utilisateur.RowTemplate.Height = 24;
            this.dataGridView_Utilisateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Utilisateur.Size = new System.Drawing.Size(1072, 546);
            this.dataGridView_Utilisateur.TabIndex = 0;
            // 
            // identifiantDataGridViewTextBoxColumn
            // 
            this.identifiantDataGridViewTextBoxColumn.DataPropertyName = "Identifiant";
            this.identifiantDataGridViewTextBoxColumn.HeaderText = "Identifiant";
            this.identifiantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.identifiantDataGridViewTextBoxColumn.Name = "identifiantDataGridViewTextBoxColumn";
            this.identifiantDataGridViewTextBoxColumn.Width = 125;
            // 
            // motDePasseDataGridViewTextBoxColumn
            // 
            this.motDePasseDataGridViewTextBoxColumn.DataPropertyName = "MotDePasse";
            this.motDePasseDataGridViewTextBoxColumn.HeaderText = "MotDePasse";
            this.motDePasseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.motDePasseDataGridViewTextBoxColumn.Name = "motDePasseDataGridViewTextBoxColumn";
            this.motDePasseDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            this.adminDataGridViewCheckBoxColumn.DataPropertyName = "Admin";
            this.adminDataGridViewCheckBoxColumn.HeaderText = "Admin";
            this.adminDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            this.adminDataGridViewCheckBoxColumn.Width = 125;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.button_SupprimerUtilisateur);
            this.splitContainer9.Panel2.Controls.Add(this.button_NouveauUtilisateur);
            this.splitContainer9.Size = new System.Drawing.Size(271, 546);
            this.splitContainer9.SplitterDistance = 437;
            this.splitContainer9.TabIndex = 0;
            // 
            // button_SupprimerUtilisateur
            // 
            this.button_SupprimerUtilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_SupprimerUtilisateur.Location = new System.Drawing.Point(0, 30);
            this.button_SupprimerUtilisateur.Name = "button_SupprimerUtilisateur";
            this.button_SupprimerUtilisateur.Size = new System.Drawing.Size(271, 30);
            this.button_SupprimerUtilisateur.TabIndex = 1;
            this.button_SupprimerUtilisateur.Text = "Supprimer";
            this.button_SupprimerUtilisateur.UseVisualStyleBackColor = true;
            this.button_SupprimerUtilisateur.Click += new System.EventHandler(this.button_Click);
            // 
            // button_NouveauUtilisateur
            // 
            this.button_NouveauUtilisateur.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_NouveauUtilisateur.Location = new System.Drawing.Point(0, 0);
            this.button_NouveauUtilisateur.Name = "button_NouveauUtilisateur";
            this.button_NouveauUtilisateur.Size = new System.Drawing.Size(271, 30);
            this.button_NouveauUtilisateur.TabIndex = 0;
            this.button_NouveauUtilisateur.Text = "Nouveau";
            this.button_NouveauUtilisateur.UseVisualStyleBackColor = true;
            this.button_NouveauUtilisateur.Click += new System.EventHandler(this.button_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Filtre,
            this.toolStripMenuItem_Detail,
            this.toolStripTextBox1,
            this.ToolStripMenuItem_Connexion,
            this.ToolStripMenuItem_ConnexionStatut});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1371, 30);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Connexion
            // 
            this.ToolStripMenuItem_Connexion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripMenuItem_Connexion.Name = "ToolStripMenuItem_Connexion";
            this.ToolStripMenuItem_Connexion.Size = new System.Drawing.Size(93, 26);
            this.ToolStripMenuItem_Connexion.Text = "&Connexion";
            this.ToolStripMenuItem_Connexion.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_ConnexionStatut
            // 
            this.ToolStripMenuItem_ConnexionStatut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripMenuItem_ConnexionStatut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToolStripMenuItem_ConnexionStatut.Enabled = false;
            this.ToolStripMenuItem_ConnexionStatut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolStripMenuItem_ConnexionStatut.Name = "ToolStripMenuItem_ConnexionStatut";
            this.ToolStripMenuItem_ConnexionStatut.Size = new System.Drawing.Size(500, 26);
            this.ToolStripMenuItem_ConnexionStatut.Text = "Non connecté";
            this.ToolStripMenuItem_ConnexionStatut.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripMenuItem_Detail
            // 
            this.toolStripMenuItem_Detail.Name = "toolStripMenuItem_Detail";
            this.toolStripMenuItem_Detail.Size = new System.Drawing.Size(63, 26);
            this.toolStripMenuItem_Detail.Text = "Détail";
            this.toolStripMenuItem_Detail.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_Filtre
            // 
            this.toolStripMenuItem_Filtre.Name = "toolStripMenuItem_Filtre";
            this.toolStripMenuItem_Filtre.Size = new System.Drawing.Size(56, 26);
            this.toolStripMenuItem_Filtre.Text = "Filtre";
            this.toolStripMenuItem_Filtre.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // sommaireToolStripMenuItem
            // 
            this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
            this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.sommaireToolStripMenuItem.Text = "&Sommaire";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.rechercherToolStripMenuItem.Text = "&Rechercher";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // àproposdeToolStripMenuItem
            // 
            this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
            this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.àproposdeToolStripMenuItem.Text = "À &propos de...";
            // 
            // personnaliserToolStripMenuItem
            // 
            this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
            this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.personnaliserToolStripMenuItem.Text = "&Personnaliser";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // annulerToolStripMenuItem
            // 
            this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
            this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.annulerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.annulerToolStripMenuItem.Text = "&Annuler";
            // 
            // rétablirToolStripMenuItem
            // 
            this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
            this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.rétablirToolStripMenuItem.Text = "&Rétablir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 6);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
            this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.couperToolStripMenuItem.Text = "&Couper";
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
            this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.copierToolStripMenuItem.Text = "Co&pier";
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
            this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.collerToolStripMenuItem.Text = "Co&ller";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // sélectionnertoutToolStripMenuItem
            // 
            this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
            this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Enabled = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 26);
            // 
            // xpView_Site
            // 
            this.xpView_Site.ObjectType = typeof(Data.Site);
            this.xpView_Site.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("Oid", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("Ville", DevExpress.Xpo.SortDirection.None, "[Ville]", false, true)});
            this.xpView_Site.Session = this.session;
            // 
            // xpView_Service
            // 
            this.xpView_Service.ObjectType = typeof(Data.Service);
            this.xpView_Service.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("Oid", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("Nom", DevExpress.Xpo.SortDirection.None, "[Nom]", false, true)});
            this.xpView_Service.Session = this.session;
            // 
            // xpCollection_Utilisateur
            // 
            this.xpCollection_Utilisateur.ObjectType = typeof(Data.Utilisateur);
            this.xpCollection_Utilisateur.Session = this.session;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 613);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Annuaire";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Salarie.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_Filtre.ResumeLayout(false);
            this.groupBox_Filtre.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Salarie)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox_Service.ResumeLayout(false);
            this.groupBox_Site.ResumeLayout(false);
            this.groupBox_Email.ResumeLayout(false);
            this.groupBox_Email.PerformLayout();
            this.groupBox_TelephonePortable.ResumeLayout(false);
            this.groupBox_TelephonePortable.PerformLayout();
            this.groupBox_TelephoneFixe.ResumeLayout(false);
            this.groupBox_TelephoneFixe.PerformLayout();
            this.groupBox_Prenom.ResumeLayout(false);
            this.groupBox_Prenom.PerformLayout();
            this.groupBox_Nom.ResumeLayout(false);
            this.groupBox_Nom.PerformLayout();
            this.tabPage_Site.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Site)).EndInit();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tabPage_Service.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Service)).EndInit();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.tabPage_Utilisateurs.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Utilisateur)).EndInit();
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpView_Site)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView_Service)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Utilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Salarie;
        private System.Windows.Forms.TabPage tabPage_Site;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox_Filtre;
        private System.Windows.Forms.CheckedListBox checkedListBox_Service;
        private System.Windows.Forms.Label label_Service;
        private System.Windows.Forms.CheckedListBox checkedListBox_Site;
        private System.Windows.Forms.Label label_Site;
        private System.Windows.Forms.TextBox textBox_NomPrenom;
        private System.Windows.Forms.Label label_NomPrenom;
        private System.Windows.Forms.DataGridView dataGridView_Salarie;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button button_AnnulerSalarie;
        private System.Windows.Forms.Button button_SauvegarderSalarie;
        private System.Windows.Forms.Button button_SupprimerSalarie;
        private System.Windows.Forms.Button button_NouveauSalarie;
        private DevExpress.Xpo.Session session;
        private DevExpress.Xpo.XPView xpView_Site;
        private DevExpress.Xpo.XPView xpView_Service;
        private System.Windows.Forms.Button button_ReinitialiserFiltre;
        private System.Windows.Forms.GroupBox groupBox_Nom;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.GroupBox groupBox_Prenom;
        private System.Windows.Forms.TextBox textBox_Prenom;
        private System.Windows.Forms.GroupBox groupBox_TelephoneFixe;
        private System.Windows.Forms.TextBox textBox_TelephoneFixe;
        private System.Windows.Forms.GroupBox groupBox_TelephonePortable;
        private System.Windows.Forms.TextBox textBox_TelephonePortable;
        private System.Windows.Forms.GroupBox groupBox_Email;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.GroupBox groupBox_Site;
        private System.Windows.Forms.ComboBox comboBox_Site;
        private System.Windows.Forms.GroupBox groupBox_Service;
        private System.Windows.Forms.ComboBox comboBox_Service;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dataGridView_Site;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button button_SupprimerSite;
        private System.Windows.Forms.Button button_NouveauSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn oidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneFixeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephonePortableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage_Service;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.DataGridView dataGridView_Service;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Button button_SupprimerService;
        private System.Windows.Forms.Button button_NouveauService;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Connexion;
        private System.Windows.Forms.ToolStripMenuItem sommaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnaliserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sélectionnertoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox ToolStripMenuItem_ConnexionStatut;
        private System.Windows.Forms.TabPage tabPage_Utilisateurs;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.DataGridView dataGridView_Utilisateur;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.Button button_SupprimerUtilisateur;
        private System.Windows.Forms.Button button_NouveauUtilisateur;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Filtre;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motDePasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
        private DevExpress.Xpo.XPCollection xpCollection_Utilisateur;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Detail;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}

