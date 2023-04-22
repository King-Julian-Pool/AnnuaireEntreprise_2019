
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Salarie = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_Filtre = new System.Windows.Forms.GroupBox();
            this.checkedListBox_Service = new System.Windows.Forms.CheckedListBox();
            this.label_Service = new System.Windows.Forms.Label();
            this.checkedListBox_Site = new System.Windows.Forms.CheckedListBox();
            this.label_Site = new System.Windows.Forms.Label();
            this.textBox_NomPrenom = new System.Windows.Forms.TextBox();
            this.label_NomPrenom = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_Salarie = new System.Windows.Forms.DataGridView();
            this.session = new DevExpress.Xpo.Session(this.components);
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.button_AnnulerSalarie = new System.Windows.Forms.Button();
            this.button_SauvegarderSalarie = new System.Windows.Forms.Button();
            this.button_SupprimerSalarie = new System.Windows.Forms.Button();
            this.button_NouveauSalarie = new System.Windows.Forms.Button();
            this.tabPage_Site = new System.Windows.Forms.TabPage();
            this.button_ReinitialiserFiltre = new System.Windows.Forms.Button();
            this.oidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneFixeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephonePortableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpCollection_Salarie = new DevExpress.Xpo.XPCollection(this.components);
            this.xpView_Site = new DevExpress.Xpo.XPView(this.components);
            this.xpView_Service = new DevExpress.Xpo.XPView(this.components);
            this.xpCollection_Site = new DevExpress.Xpo.XPCollection(this.components);
            this.xpCollection_Service = new DevExpress.Xpo.XPCollection(this.components);
            this.groupBox_Nom = new System.Windows.Forms.GroupBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.groupBox_Prenom = new System.Windows.Forms.GroupBox();
            this.textBox_Prenom = new System.Windows.Forms.TextBox();
            this.groupBox_TelephoneFixe = new System.Windows.Forms.GroupBox();
            this.textBox__TelephoneFixe = new System.Windows.Forms.TextBox();
            this.groupBox_TelephonePortable = new System.Windows.Forms.GroupBox();
            this.textBox_TelephonePortable = new System.Windows.Forms.TextBox();
            this.groupBox_Email = new System.Windows.Forms.GroupBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.groupBox_Site = new System.Windows.Forms.GroupBox();
            this.comboBox__Site = new System.Windows.Forms.ComboBox();
            this.groupBox_Service = new System.Windows.Forms.GroupBox();
            this.comboBox_Service = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.session)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Salarie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView_Site)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView_Service)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Site)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Service)).BeginInit();
            this.groupBox_Nom.SuspendLayout();
            this.groupBox_Prenom.SuspendLayout();
            this.groupBox_TelephoneFixe.SuspendLayout();
            this.groupBox_TelephonePortable.SuspendLayout();
            this.groupBox_Email.SuspendLayout();
            this.groupBox_Site.SuspendLayout();
            this.groupBox_Service.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Salarie);
            this.tabControl1.Controls.Add(this.tabPage_Site);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1367, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Salarie
            // 
            this.tabPage_Salarie.Controls.Add(this.splitContainer1);
            this.tabPage_Salarie.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Salarie.Name = "tabPage_Salarie";
            this.tabPage_Salarie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Salarie.Size = new System.Drawing.Size(1359, 582);
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
            this.splitContainer1.Size = new System.Drawing.Size(1353, 576);
            this.splitContainer1.SplitterDistance = 211;
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
            this.groupBox_Filtre.Size = new System.Drawing.Size(209, 574);
            this.groupBox_Filtre.TabIndex = 0;
            this.groupBox_Filtre.TabStop = false;
            this.groupBox_Filtre.Text = "Filtres";
            // 
            // checkedListBox_Service
            // 
            this.checkedListBox_Service.CheckOnClick = true;
            this.checkedListBox_Service.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkedListBox_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Service.FormattingEnabled = true;
            this.checkedListBox_Service.Location = new System.Drawing.Point(3, 180);
            this.checkedListBox_Service.Name = "checkedListBox_Service";
            this.checkedListBox_Service.Size = new System.Drawing.Size(203, 89);
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
            this.checkedListBox_Site.Size = new System.Drawing.Size(203, 89);
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
            this.textBox_NomPrenom.Size = new System.Drawing.Size(203, 22);
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
            this.splitContainer2.Size = new System.Drawing.Size(1132, 576);
            this.splitContainer2.SplitterDistance = 859;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView_Salarie
            // 
            this.dataGridView_Salarie.AllowUserToAddRows = false;
            this.dataGridView_Salarie.AllowUserToDeleteRows = false;
            this.dataGridView_Salarie.AllowUserToOrderColumns = true;
            this.dataGridView_Salarie.AutoGenerateColumns = false;
            this.dataGridView_Salarie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Salarie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oidDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.telephoneFixeDataGridViewTextBoxColumn,
            this.telephonePortableDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.serviceKeyDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.siteDataGridViewTextBoxColumn,
            this.siteKeyDataGridViewTextBoxColumn});
            this.dataGridView_Salarie.DataSource = this.xpCollection_Salarie;
            this.dataGridView_Salarie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Salarie.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Salarie.MultiSelect = false;
            this.dataGridView_Salarie.Name = "dataGridView_Salarie";
            this.dataGridView_Salarie.RowHeadersWidth = 51;
            this.dataGridView_Salarie.RowTemplate.Height = 24;
            this.dataGridView_Salarie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Salarie.Size = new System.Drawing.Size(857, 574);
            this.dataGridView_Salarie.TabIndex = 0;
            this.dataGridView_Salarie.SelectionChanged += new System.EventHandler(this.dataGridView_Salarie_SelectionChanged);
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
            this.splitContainer3.Size = new System.Drawing.Size(261, 574);
            this.splitContainer3.SplitterDistance = 465;
            this.splitContainer3.TabIndex = 0;
            // 
            // button_AnnulerSalarie
            // 
            this.button_AnnulerSalarie.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_AnnulerSalarie.Location = new System.Drawing.Point(0, 69);
            this.button_AnnulerSalarie.Name = "button_AnnulerSalarie";
            this.button_AnnulerSalarie.Size = new System.Drawing.Size(261, 23);
            this.button_AnnulerSalarie.TabIndex = 3;
            this.button_AnnulerSalarie.Text = "Annuler";
            this.button_AnnulerSalarie.UseVisualStyleBackColor = true;
            this.button_AnnulerSalarie.Click += new System.EventHandler(this.button_Click);
            // 
            // button_SauvegarderSalarie
            // 
            this.button_SauvegarderSalarie.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_SauvegarderSalarie.Location = new System.Drawing.Point(0, 46);
            this.button_SauvegarderSalarie.Name = "button_SauvegarderSalarie";
            this.button_SauvegarderSalarie.Size = new System.Drawing.Size(261, 23);
            this.button_SauvegarderSalarie.TabIndex = 2;
            this.button_SauvegarderSalarie.Text = "Sauvegarder";
            this.button_SauvegarderSalarie.UseVisualStyleBackColor = true;
            this.button_SauvegarderSalarie.Click += new System.EventHandler(this.button_Click);
            // 
            // button_SupprimerSalarie
            // 
            this.button_SupprimerSalarie.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_SupprimerSalarie.Location = new System.Drawing.Point(0, 23);
            this.button_SupprimerSalarie.Name = "button_SupprimerSalarie";
            this.button_SupprimerSalarie.Size = new System.Drawing.Size(261, 23);
            this.button_SupprimerSalarie.TabIndex = 1;
            this.button_SupprimerSalarie.Text = "Supprimer";
            this.button_SupprimerSalarie.UseVisualStyleBackColor = true;
            this.button_SupprimerSalarie.Click += new System.EventHandler(this.button_Click);
            // 
            // button_NouveauSalarie
            // 
            this.button_NouveauSalarie.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_NouveauSalarie.Location = new System.Drawing.Point(0, 0);
            this.button_NouveauSalarie.Name = "button_NouveauSalarie";
            this.button_NouveauSalarie.Size = new System.Drawing.Size(261, 23);
            this.button_NouveauSalarie.TabIndex = 0;
            this.button_NouveauSalarie.Text = "Nouveau";
            this.button_NouveauSalarie.UseVisualStyleBackColor = true;
            this.button_NouveauSalarie.Click += new System.EventHandler(this.button_Click);
            // 
            // tabPage_Site
            // 
            this.tabPage_Site.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Site.Name = "tabPage_Site";
            this.tabPage_Site.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Site.Size = new System.Drawing.Size(1359, 582);
            this.tabPage_Site.TabIndex = 1;
            this.tabPage_Site.Text = "Sites";
            this.tabPage_Site.UseVisualStyleBackColor = true;
            // 
            // button_ReinitialiserFiltre
            // 
            this.button_ReinitialiserFiltre.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ReinitialiserFiltre.Location = new System.Drawing.Point(3, 269);
            this.button_ReinitialiserFiltre.Name = "button_ReinitialiserFiltre";
            this.button_ReinitialiserFiltre.Size = new System.Drawing.Size(203, 23);
            this.button_ReinitialiserFiltre.TabIndex = 6;
            this.button_ReinitialiserFiltre.Text = "Réinitialiser";
            this.button_ReinitialiserFiltre.UseVisualStyleBackColor = true;
            this.button_ReinitialiserFiltre.Click += new System.EventHandler(this.button_Click);
            // 
            // oidDataGridViewTextBoxColumn
            // 
            this.oidDataGridViewTextBoxColumn.DataPropertyName = "Oid";
            this.oidDataGridViewTextBoxColumn.HeaderText = "Oid";
            this.oidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oidDataGridViewTextBoxColumn.Name = "oidDataGridViewTextBoxColumn";
            this.oidDataGridViewTextBoxColumn.Visible = false;
            this.oidDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.Width = 125;
            // 
            // telephoneFixeDataGridViewTextBoxColumn
            // 
            this.telephoneFixeDataGridViewTextBoxColumn.DataPropertyName = "TelephoneFixe";
            this.telephoneFixeDataGridViewTextBoxColumn.HeaderText = "TelephoneFixe";
            this.telephoneFixeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephoneFixeDataGridViewTextBoxColumn.Name = "telephoneFixeDataGridViewTextBoxColumn";
            this.telephoneFixeDataGridViewTextBoxColumn.Width = 125;
            // 
            // telephonePortableDataGridViewTextBoxColumn
            // 
            this.telephonePortableDataGridViewTextBoxColumn.DataPropertyName = "TelephonePortable";
            this.telephonePortableDataGridViewTextBoxColumn.HeaderText = "TelephonePortable";
            this.telephonePortableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephonePortableDataGridViewTextBoxColumn.Name = "telephonePortableDataGridViewTextBoxColumn";
            this.telephonePortableDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceKeyDataGridViewTextBoxColumn
            // 
            this.serviceKeyDataGridViewTextBoxColumn.DataPropertyName = "Service!Key";
            this.serviceKeyDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceKeyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceKeyDataGridViewTextBoxColumn.Name = "serviceKeyDataGridViewTextBoxColumn";
            this.serviceKeyDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service!";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.Width = 125;
            // 
            // siteDataGridViewTextBoxColumn
            // 
            this.siteDataGridViewTextBoxColumn.DataPropertyName = "Site!";
            this.siteDataGridViewTextBoxColumn.HeaderText = "Site";
            this.siteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siteDataGridViewTextBoxColumn.Name = "siteDataGridViewTextBoxColumn";
            this.siteDataGridViewTextBoxColumn.Width = 125;
            // 
            // siteKeyDataGridViewTextBoxColumn
            // 
            this.siteKeyDataGridViewTextBoxColumn.DataPropertyName = "Site!Key";
            this.siteKeyDataGridViewTextBoxColumn.HeaderText = "Site";
            this.siteKeyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.siteKeyDataGridViewTextBoxColumn.Name = "siteKeyDataGridViewTextBoxColumn";
            this.siteKeyDataGridViewTextBoxColumn.Width = 125;
            // 
            // xpCollection_Salarie
            // 
            this.xpCollection_Salarie.ObjectType = typeof(Data.Salarie);
            this.xpCollection_Salarie.Session = this.session;
            // 
            // xpView_Site
            // 
            this.xpView_Site.ObjectType = typeof(Data.Site);
            this.xpView_Site.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("Oid", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("Ville", DevExpress.Xpo.SortDirection.None, "[Ville]", false, true),
            new DevExpress.Xpo.ViewProperty("IsChecked", DevExpress.Xpo.SortDirection.None, "[IsChecked]", false, true)});
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
            // xpCollection_Site
            // 
            this.xpCollection_Site.ObjectType = typeof(Data.Site);
            this.xpCollection_Site.Session = this.session;
            // 
            // xpCollection_Service
            // 
            this.xpCollection_Service.ObjectType = typeof(Data.Service);
            this.xpCollection_Service.Session = this.session;
            // 
            // groupBox_Nom
            // 
            this.groupBox_Nom.Controls.Add(this.textBox_Nom);
            this.groupBox_Nom.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Nom.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Nom.Name = "groupBox_Nom";
            this.groupBox_Nom.Size = new System.Drawing.Size(261, 57);
            this.groupBox_Nom.TabIndex = 7;
            this.groupBox_Nom.TabStop = false;
            this.groupBox_Nom.Text = "Nom";
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Nom.Location = new System.Drawing.Point(3, 18);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(255, 22);
            this.textBox_Nom.TabIndex = 0;
            // 
            // groupBox_Prenom
            // 
            this.groupBox_Prenom.Controls.Add(this.textBox_Prenom);
            this.groupBox_Prenom.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Prenom.Location = new System.Drawing.Point(0, 57);
            this.groupBox_Prenom.Name = "groupBox_Prenom";
            this.groupBox_Prenom.Size = new System.Drawing.Size(261, 57);
            this.groupBox_Prenom.TabIndex = 8;
            this.groupBox_Prenom.TabStop = false;
            this.groupBox_Prenom.Text = "Prénom";
            // 
            // textBox_Prenom
            // 
            this.textBox_Prenom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Prenom.Location = new System.Drawing.Point(3, 18);
            this.textBox_Prenom.Name = "textBox_Prenom";
            this.textBox_Prenom.Size = new System.Drawing.Size(255, 22);
            this.textBox_Prenom.TabIndex = 0;
            // 
            // groupBox_TelephoneFixe
            // 
            this.groupBox_TelephoneFixe.Controls.Add(this.textBox__TelephoneFixe);
            this.groupBox_TelephoneFixe.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_TelephoneFixe.Location = new System.Drawing.Point(0, 114);
            this.groupBox_TelephoneFixe.Name = "groupBox_TelephoneFixe";
            this.groupBox_TelephoneFixe.Size = new System.Drawing.Size(261, 57);
            this.groupBox_TelephoneFixe.TabIndex = 8;
            this.groupBox_TelephoneFixe.TabStop = false;
            this.groupBox_TelephoneFixe.Text = "Téléphone fixe";
            // 
            // textBox__TelephoneFixe
            // 
            this.textBox__TelephoneFixe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox__TelephoneFixe.Location = new System.Drawing.Point(3, 18);
            this.textBox__TelephoneFixe.Name = "textBox__TelephoneFixe";
            this.textBox__TelephoneFixe.Size = new System.Drawing.Size(255, 22);
            this.textBox__TelephoneFixe.TabIndex = 0;
            // 
            // groupBox_TelephonePortable
            // 
            this.groupBox_TelephonePortable.Controls.Add(this.textBox_TelephonePortable);
            this.groupBox_TelephonePortable.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_TelephonePortable.Location = new System.Drawing.Point(0, 171);
            this.groupBox_TelephonePortable.Name = "groupBox_TelephonePortable";
            this.groupBox_TelephonePortable.Size = new System.Drawing.Size(261, 57);
            this.groupBox_TelephonePortable.TabIndex = 9;
            this.groupBox_TelephonePortable.TabStop = false;
            this.groupBox_TelephonePortable.Text = "Téléphone portable";
            // 
            // textBox_TelephonePortable
            // 
            this.textBox_TelephonePortable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TelephonePortable.Location = new System.Drawing.Point(3, 18);
            this.textBox_TelephonePortable.Name = "textBox_TelephonePortable";
            this.textBox_TelephonePortable.Size = new System.Drawing.Size(255, 22);
            this.textBox_TelephonePortable.TabIndex = 0;
            // 
            // groupBox_Email
            // 
            this.groupBox_Email.Controls.Add(this.textBox_Email);
            this.groupBox_Email.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Email.Location = new System.Drawing.Point(0, 228);
            this.groupBox_Email.Name = "groupBox_Email";
            this.groupBox_Email.Size = new System.Drawing.Size(261, 57);
            this.groupBox_Email.TabIndex = 9;
            this.groupBox_Email.TabStop = false;
            this.groupBox_Email.Text = "Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Email.Location = new System.Drawing.Point(3, 18);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(255, 22);
            this.textBox_Email.TabIndex = 0;
            // 
            // groupBox_Site
            // 
            this.groupBox_Site.Controls.Add(this.comboBox__Site);
            this.groupBox_Site.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Site.Location = new System.Drawing.Point(0, 285);
            this.groupBox_Site.Name = "groupBox_Site";
            this.groupBox_Site.Size = new System.Drawing.Size(261, 57);
            this.groupBox_Site.TabIndex = 10;
            this.groupBox_Site.TabStop = false;
            this.groupBox_Site.Text = "Site";
            // 
            // comboBox__Site
            // 
            this.comboBox__Site.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox__Site.FormattingEnabled = true;
            this.comboBox__Site.Location = new System.Drawing.Point(3, 18);
            this.comboBox__Site.Name = "comboBox__Site";
            this.comboBox__Site.Size = new System.Drawing.Size(255, 24);
            this.comboBox__Site.TabIndex = 0;
            // 
            // groupBox_Service
            // 
            this.groupBox_Service.Controls.Add(this.comboBox_Service);
            this.groupBox_Service.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Service.Location = new System.Drawing.Point(0, 342);
            this.groupBox_Service.Name = "groupBox_Service";
            this.groupBox_Service.Size = new System.Drawing.Size(261, 57);
            this.groupBox_Service.TabIndex = 11;
            this.groupBox_Service.TabStop = false;
            this.groupBox_Service.Text = "Service";
            // 
            // comboBox_Service
            // 
            this.comboBox_Service.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Service.FormattingEnabled = true;
            this.comboBox_Service.Location = new System.Drawing.Point(3, 18);
            this.comboBox_Service.Name = "comboBox_Service";
            this.comboBox_Service.Size = new System.Drawing.Size(255, 24);
            this.comboBox_Service.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 611);
            this.Controls.Add(this.tabControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.session)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Salarie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView_Site)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView_Service)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Site)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection_Service)).EndInit();
            this.groupBox_Nom.ResumeLayout(false);
            this.groupBox_Nom.PerformLayout();
            this.groupBox_Prenom.ResumeLayout(false);
            this.groupBox_Prenom.PerformLayout();
            this.groupBox_TelephoneFixe.ResumeLayout(false);
            this.groupBox_TelephoneFixe.PerformLayout();
            this.groupBox_TelephonePortable.ResumeLayout(false);
            this.groupBox_TelephonePortable.PerformLayout();
            this.groupBox_Email.ResumeLayout(false);
            this.groupBox_Email.PerformLayout();
            this.groupBox_Site.ResumeLayout(false);
            this.groupBox_Service.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private DevExpress.Xpo.XPCollection xpCollection_Salarie;
        private DevExpress.Xpo.XPView xpView_Site;
        private DevExpress.Xpo.XPView xpView_Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn oidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneFixeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephonePortableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteKeyDataGridViewTextBoxColumn;
        private DevExpress.Xpo.XPCollection xpCollection_Site;
        private DevExpress.Xpo.XPCollection xpCollection_Service;
        private System.Windows.Forms.Button button_ReinitialiserFiltre;
        private System.Windows.Forms.GroupBox groupBox_Site;
        private System.Windows.Forms.GroupBox groupBox_Email;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.GroupBox groupBox_TelephonePortable;
        private System.Windows.Forms.TextBox textBox_TelephonePortable;
        private System.Windows.Forms.GroupBox groupBox_TelephoneFixe;
        private System.Windows.Forms.TextBox textBox__TelephoneFixe;
        private System.Windows.Forms.GroupBox groupBox_Prenom;
        private System.Windows.Forms.TextBox textBox_Prenom;
        private System.Windows.Forms.GroupBox groupBox_Nom;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.GroupBox groupBox_Service;
        private System.Windows.Forms.ComboBox comboBox_Service;
        private System.Windows.Forms.ComboBox comboBox__Site;
    }
}

