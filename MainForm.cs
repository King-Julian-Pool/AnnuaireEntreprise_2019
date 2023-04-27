using Data;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnnuaireEntreprise_2019
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Identifiant de l'utilisateur actuellement connecté
        /// </summary>
        public string utilisateurIdentifiant;

        /// <summary>
        /// Etat de connexion d'un utilisateur
        /// </summary>
        private bool _connecte { get; set; }
        public bool connecte
        {
            get => _connecte;
            set
            {
                _connecte = value;
                this.ConnexionChanged();
            }
        }

        /// <summary>
        /// Mode administrateur permettant des accès spécifiques
        /// </summary>
        private bool _modeAdmin;
        public bool modeAdmin
        {
            get => _modeAdmin;
            set => _modeAdmin = value;
        }


        /// <summary>
        /// Editeurs du formulaire de détail des salariés
        /// </summary>
        public Control[] DetailFormControls;

        /// <summary>
        /// Salarie actuellement sélectionné dans la grile et dont les informations s'affichent dans le formulaire de détail
        /// </summary>
        private Salarie _salarie;
        public Salarie Salarie
        {
            get => _salarie;
            set
            {
                ClearDetailFormDataBindings();

                _salarie = value;

                if (_salarie != null)
                {
                    this.InitDetailFormDataBindings();
                }
            }
        }

        XPCollection<Salarie> Salaries;
        XPCollection<Site> Sites;
        XPCollection<Service> Services;
        XPCollection<Utilisateur> Utilisateurs;

        public MainForm()
        {
            InitializeComponent();

            this.DetailFormControls = new Control[] {
                this.textBox_Nom,
                this.textBox_Prenom,
                this.textBox_TelephoneFixe,
                this.textBox_TelephonePortable,
                this.textBox_Email,
                this.comboBox_Site,
                this.comboBox_Service
            };

            this.connecte = false;
            this.modeAdmin = false;

            this.BindGridAndFilter();
        }

        /// <summary>
        /// Changement de statut de connexion
        /// </summary>
        private void ConnexionChanged()
        {
            if (connecte)
            {
                this.ToolStripMenuItem_ConnexionStatut.Text = $"Connecté en tant que {this.utilisateurIdentifiant}";
            }
            else
            {
                if (this.modeAdmin)
                {
                    this.modeAdmin = false;
                }
                this.utilisateurIdentifiant = null;
                this.ToolStripMenuItem_ConnexionStatut.Text = $"Non connecté";
            }

            // Pages de consultation et d'édition des sites et services
            TabPage[] tabPages = new TabPage[] {
                this.tabPage_Site,
                this.tabPage_Service,
                this.tabPage_Utilisateurs
            };

            // Boutons concernants l'ajout, la supression, la modification des salariés
            Button[] salarieButtons = new Button[] {
                this.button_NouveauSalarie,
                this.button_SupprimerSalarie,
                this.button_AnnulerSalarie,
                this.button_SauvegarderSalarie
            };

            if (modeAdmin)
            {
                // On affiche les onglets et pages
                foreach (TabPage tabPage in tabPages)
                {
                    if (!this.tabControl1.TabPages.Contains(tabPage))
                    {
                        this.tabControl1.TabPages.Add(tabPage);
                    }
                }

                // On permet l'édition des editeurs
                foreach (Control control in this.DetailFormControls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).ReadOnly = false;
                    }
                    else if (control is ComboBox)
                    {
                        ((ComboBox)control).Enabled = true;
                    }
                }

                // On affiche les boutons d'édition des salaries
                foreach (Button button in salarieButtons)
                {
                    button.Visible = true;
                }
            }
            else
            {
                // On masque les onglets et pages
                foreach (TabPage tabPage in tabPages)
                {
                    if (this.tabControl1.TabPages.Contains(tabPage))
                    {
                        this.tabControl1.TabPages.Remove(tabPage);
                    }
                }

                // On empêche l'édition des editeurs
                foreach (Control control in this.DetailFormControls)
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).ReadOnly = true;
                    }
                    else if (control is ComboBox)
                    {
                        ((ComboBox)control).Enabled = false;
                    }
                }

                // On masque les boutons d'édition des salaries
                foreach (Button button in salarieButtons)
                {
                    button.Visible = false;
                }
            }
        }

        #region " Evénements et méthodes liés aux boutons "
        /// <summary>
        /// Se déclenche lors du click d'un bouton
        /// </summary>
        /// <param name="sender">Le bouton cliqué</param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button != null)
            {
                switch (button.Name)
                {
                    case nameof(this.button_NouveauSalarie):
                        NouveauSalarie();
                        break;
                    case nameof(this.button_SupprimerSalarie):
                        SupprimerSalarie();
                        break;
                    case nameof(this.button_SauvegarderSalarie):
                        SauvegarderSalarie();
                        break;
                    case nameof(this.button_AnnulerSalarie):
                        ResetSalarie();
                        break;
                    case nameof(this.button_ReinitialiserFiltre):
                        ReinitialiserFiltre();
                        break;
                    case nameof(this.button_NouveauSite):
                        NouveauSite();
                        break;
                    case nameof(this.button_SupprimerSite):
                        SupprimerSite();
                        break;
                    case nameof(this.button_NouveauService):
                        NouveauService();
                        break;
                    case nameof(this.button_SupprimerService):
                        SupprimerService();
                        break;
                    case nameof(this.button_NouveauUtilisateur):
                        NouveauUtilisateur();
                        break;
                    case nameof(this.button_SupprimerUtilisateur):
                        SupprimerUtilisateur();
                        break;
                }
            }
        }

        /// <summary>
        /// Se déclenche lors du clik du bouton de Connexion/Deconnexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            if (item != null)
            {

                switch (item.Name)
                {
                    case nameof(this.ToolStripMenuItem_Connexion):

                        if (this.connecte)
                        {
                            this.connecte = false;
                            this.modeAdmin = false;
                            this.utilisateurIdentifiant = null;
                            this.ToolStripMenuItem_Connexion.Text = "Connexion";
                        }
                        else
                        {
                            Form form = new ConnexionForm(this.session, this);
                            form.StartPosition = FormStartPosition.CenterParent;
                            form.ShowDialog(this);
                            if (this.connecte)
                            {
                                this.ToolStripMenuItem_Connexion.Text = "Déconnexion";
                            }
                        }

                        break;

                    case nameof(this.toolStripMenuItem_Filtre):

                        this.splitContainer1.Panel1Collapsed = !this.splitContainer1.Panel1Collapsed;

                        break;

                    case nameof(this.toolStripMenuItem_Detail):

                        this.splitContainer2.Panel2Collapsed = !this.splitContainer2.Panel2Collapsed;

                        break;
                }
            }
        }

        #region " Salarie "
        /// <summary>
        /// Ajout d'un salarie
        /// </summary>
        private void NouveauSalarie()
        {
            Salarie salarie = new Salarie(this.session);

            salarie.Save();

            this.Salaries.Reload();

            this.dataGridView_Salarie.Rows[this.Salaries.IndexOf(salarie)].Selected = true;
        }

        /// <summary>
        /// Supression du salarie selectionné dans la grile
        /// </summary>
        private void SupprimerSalarie()
        {
            if (dataGridView_Salarie.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView_Salarie.SelectedRows[0];

                if (row != null)
                {
                    Salarie salarie = row.DataBoundItem as Salarie;

                    if (salarie != null)
                    {
                        row.Dispose();
                        salarie.Delete();
                        this.Salaries.Reload();
                    }
                }
            }
        }

        /// <summary>
        /// Enregistrement des modifications apportées au salarie selectionné dans la grille
        /// </summary>
        private void SauvegarderSalarie()
        {
            if (dataGridView_Salarie.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView_Salarie.SelectedRows[0];

                if (row != null)
                {
                    if (this._salarie != null && this.DetailFormControls != null)
                    {
                        string nom = null;
                        string prenom = null;
                        string telephoneFixe = null;
                        string telephonePortable = null;
                        string email = null;
                        Site site = null;
                        Service service = null;

                        foreach (Control control in this.DetailFormControls)
                        {
                            if (control?.Tag != null && this._salarie != null)
                            {
                                string tag = (string)control.Tag;

                                switch (tag)
                                {
                                    case nameof(Salarie.Nom):
                                        nom = control.Text;
                                        break;
                                    case nameof(Salarie.Prenom):
                                        prenom = control.Text;
                                        break;
                                    case nameof(Salarie.TelephoneFixe):
                                        telephoneFixe = control.Text;
                                        break;
                                    case nameof(Salarie.TelephonePortable):
                                        telephonePortable = control.Text;
                                        break;
                                    case nameof(Salarie.Email):
                                        email = control.Text;
                                        break;
                                    case nameof(Salarie.Site):
                                        ComboBox comboBoxSite = (ComboBox)control;

                                        bool siteExist = false;

                                        if (comboBoxSite?.SelectedValue != null)
                                        {
                                            int? SiteOid = (int)comboBoxSite.SelectedValue;

                                            if (SiteOid != null && SiteOid > 0)
                                            {
                                                site = this.Sites.FirstOrDefault(s => s.Oid == SiteOid);
                                                siteExist = true;
                                            }
                                        }

                                        if (!siteExist)
                                        {
                                            site = null;
                                        }

                                        break;
                                    case nameof(Salarie.Service):
                                        ComboBox comboBoxService = (ComboBox)control;

                                        bool serviceExist = false;

                                        if (comboBoxService?.SelectedValue != null)
                                        {
                                            int? ServiceOid = (int)comboBoxService.SelectedValue;

                                            if (ServiceOid != null && ServiceOid > 0)
                                            {
                                                service = this.Services.FirstOrDefault(s => s.Oid == ServiceOid);
                                                serviceExist = true;
                                            }
                                        }

                                        if (!serviceExist)
                                        {
                                            service = null;
                                        }

                                        break;
                                }

                            }
                        }

                        this._salarie.Nom = nom;
                        this._salarie.Prenom = prenom;
                        this._salarie.TelephoneFixe = telephoneFixe;
                        this._salarie.TelephonePortable = telephonePortable;
                        this._salarie.Email = email;
                        this._salarie.Site = site;
                        this._salarie.Service = service;

                        this._salarie.Save();
                    }
                }
            }
        }

        /// <summary>
        /// Annulation des modifications en cours pour le salarié sélectionné dans la grille
        /// </summary>
        private void ResetSalarie()
        {
            if (dataGridView_Salarie.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView_Salarie.SelectedRows[0];

                if (row != null)
                {
                    Salarie salarie = row.DataBoundItem as Salarie;

                    if (salarie != null)
                    {
                        this.Salarie = salarie;
                    }
                }
            }
        }

        #endregion

        #region " Site "
        /// <summary>
        /// Ajout d'un site
        /// </summary>
        private void NouveauSite()
        {
            Site site = new Site(this.session);

            site.Save();

            this.Sites.Reload();
            this.Sites.Reload();

            this.dataGridView_Site.Rows[this.Sites.IndexOf(site)].Selected = true;
        }

        /// <summary>
        /// Supression d'un site
        /// </summary>
        private void SupprimerSite()
        {
            if (dataGridView_Site.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView_Site.SelectedRows[0];

                if (row != null)
                {
                    Site site = row.DataBoundItem as Site;

                    if (site != null)
                    {

                        if (Salaries.Any(s => s.Site != null && s.Site.Oid == site.Oid))
                        {
                            /// Si le site est affecté à un salarié on affiche un message d'erreur
                            MessageBox.Show(this, $"Impssible de supprimer le site {site.Ville}. Au moins un salarié y est affecté.", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            row.Dispose();
                            site.Delete();
                            this.Sites.Reload();
                        }
                    }
                }
            }
        }
        #endregion
        #region " Service "
        /// <summary>
        /// Ajout d'un service
        /// </summary>
        private void NouveauService()
        {
            Service service = new Service(this.session);

            service.Save();

            this.Services.Reload();
            this.Services.Reload();

            this.dataGridView_Service.Rows[this.Services.IndexOf(service)].Selected = true;
        }

        /// <summary>
        /// Suppression d'un service
        /// </summary>
        private void SupprimerService()
        {
            if (dataGridView_Service.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView_Service.SelectedRows[0];

                if (row != null)
                {
                    Service service = row.DataBoundItem as Service;

                    if (service != null)
                    {
                        if (Salaries.Any(s => s.Service != null && s.Service.Oid == service.Oid))
                        {
                            /// Si le service est affecté à un salarié on affiche un message d'erreur
                            MessageBox.Show(this, $"Impssible de supprimer le service {service.Nom}. Au moins un salarié y est affecté.", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            row.Dispose();
                            service.Delete();
                            this.Services.Reload();
                        }
                    }
                }
            }
        }

        private void NouveauUtilisateur()
        {
            Utilisateur service = new Utilisateur(this.session);

            service.Save();

            this.Utilisateurs.Reload();
            this.Utilisateurs.Reload();

            this.dataGridView_Utilisateur.Rows[this.Utilisateurs.IndexOf(service)].Selected = true;
        }

        /// <summary>
        /// Suppression d'un service
        /// </summary>
        private void SupprimerUtilisateur()
        {
            if (dataGridView_Utilisateur.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView_Utilisateur.SelectedRows[0];

                if (row != null)
                {
                    Utilisateur service = row.DataBoundItem as Utilisateur;

                    if (service != null)
                    {
                        row.Dispose();
                        service.Delete();
                        this.Utilisateurs.Reload();
                    }
                }
            }
        }
        #endregion

        #region " Filtre "
        /// <summary>
        /// Réinitialisation du filtre
        /// </summary>
        private void ReinitialiserFiltre()
        {
            // On vide la barre de recherche du Nom/Prénom
            this.textBox_NomPrenom.Text = string.Empty;

            // On décoche tous les éléments de filtre
            CheckedListBox[] checkedListBoxes = new CheckedListBox[] { this.checkedListBox_Site, this.checkedListBox_Service };
            foreach (CheckedListBox checkedListBox in checkedListBoxes)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    checkedListBox.SetItemChecked(i, false);
                }
            }

            // On marque tous les sites comme décochés
            foreach (Site site in Sites)
            {
                if (site.IsChecked)
                {
                    site.IsChecked = false;
                }
            }

            // On marque tous les services comme décochés
            foreach (Service service in this.Services)
            {
                if (service.IsChecked)
                {
                    service.IsChecked = false;
                }
            }

            UpdateCriteria();
        }
        #endregion
        #endregion

        #region " Evenements et méthodes liés au filtre "
        /// <summary>
        /// Se déclenche lors du changement de texte du filtre Nom/Prénom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_NomPrenom_TextChanged(object sender, EventArgs e)
        {
            UpdateCriteria();
        }

        /// <summary>
        /// Se déclenche lorsqu'un élement de CheckListBox est coché ou décoché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox checkedListBox = sender as CheckedListBox;

            if (checkedListBox != null)
            {
                switch (checkedListBox.Name)
                {
                    case "checkedListBox_Site":
                        ((Site)checkedListBox.Items[e.Index]).IsChecked = e.NewValue == CheckState.Checked;
                        break;

                    case "checkedListBox_Service":
                        ((Service)checkedListBox.Items[e.Index]).IsChecked = e.NewValue == CheckState.Checked;
                        break;
                }
            }

            UpdateCriteria();

        }

        /// <summary>
        /// Actualisation du filtre de la grille des salariés
        /// </summary>
        private void UpdateCriteria()
        {
            CriteriaOperator NomPrenomOp = null;
            if (this.textBox_NomPrenom.Text != String.Empty)
            {
                var NomOp = DevExpress.Data.Filtering.CriteriaOperator.Parse($"Contains(Lower([{nameof(Salarie.Nom)}]), ?)", textBox_NomPrenom.Text.ToLower());
                var PrenomOp = DevExpress.Data.Filtering.CriteriaOperator.Parse($"Contains(Lower([{nameof(Salarie.Prenom)}]), ?)", textBox_NomPrenom.Text.ToLower());
                NomPrenomOp = CriteriaOperator.Or(NomOp, PrenomOp);
            }

            BinaryOperator SiteOp = null;
            foreach (Site site in this.Sites)
            {
                if (site.IsChecked)
                {
                    SiteOp = new BinaryOperator("Site.IsChecked", true);
                    break;
                }
            }

            BinaryOperator ServiceOp = null;
            foreach (Service service in this.Services)
            {
                if (service.IsChecked)
                {
                    ServiceOp = new BinaryOperator("Service.IsChecked", true);
                    break;
                }
            }

            var criteria = CriteriaOperator.And(NomPrenomOp, SiteOp, ServiceOp);

            this.Salaries.Criteria = criteria;
        }
        #endregion

        #region " Evénements liés aux grilles "
        /// <summary>
        /// Se déclenche lors du changement de ligne sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_Salarie_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            if (dataGridView != null && dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];

                if (row != null)
                {
                    Salarie salarie = row.DataBoundItem as Salarie;

                    if (salarie != null)
                    {
                        this.Salarie = salarie;
                    }
                }
            }
        }
        #endregion

        #region " DataBinding "

        /// <summary>
        /// Bind des grilles et des élements de filtres
        /// </summary>
        private void BindGridAndFilter()
        {
            // On désactive la création automatique de colonnes dans les grilles sur le changement de source de donnée
            this.dataGridView_Salarie.AutoGenerateColumns = false;
            this.dataGridView_Site.AutoGenerateColumns = false;
            this.dataGridView_Service.AutoGenerateColumns = false;
            this.dataGridView_Utilisateur.AutoGenerateColumns = false;

            Salaries = new XPCollection<Salarie>(this.session);
            this.dataGridView_Salarie.DataSource = Salaries;

            Sites = new XPCollection<Site>(this.session);
            ((ListBox)this.checkedListBox_Site).DataSource = Sites;
            ((ListBox)this.checkedListBox_Site).DisplayMember = "Ville";
            this.dataGridView_Site.DataSource = Sites;
            Sites.ListChanged += ListChanged;

            Services = new XPCollection<Service>(this.session);
            ((ListBox)this.checkedListBox_Service).DataSource = Services;
            ((ListBox)this.checkedListBox_Service).DisplayMember = "Nom";
            this.dataGridView_Service.DataSource = Services;
            Services.ListChanged += ListChanged;

            this.comboBox_Site.DataSource = this.xpView_Site;
            this.comboBox_Site.DisplayMember = "Ville";
            this.comboBox_Site.ValueMember = "Oid";

            this.comboBox_Service.DataSource = this.xpView_Service;
            this.comboBox_Service.DisplayMember = "Nom";
            this.comboBox_Service.ValueMember = "Oid";

            Utilisateurs = new XPCollection<Utilisateur>(this.session);
            this.dataGridView_Utilisateur.DataSource = Utilisateurs;
        }

        #region " Formulaire de détail des salariés "
        private void ClearDetailFormDataBindings()
        {
            if (this.DetailFormControls != null)
            {
                foreach (Control control in this.DetailFormControls)
                {
                    if (control.GetType() == typeof(TextBox))
                    {
                        control.Text = null;
                    }
                    else if (control.GetType() == typeof(ComboBox))
                    {
                        ((ComboBox)control).SelectedItem = null;
                    }
                }
            }
        }

        private void InitDetailFormDataBindings()
        {
            if (this.DetailFormControls != null)
            {
                foreach (Control control in this.DetailFormControls)
                {
                    if (control?.Tag != null && _salarie != null)
                    {
                        string tag = (string)control.Tag;

                        switch (tag)
                        {
                            case nameof(Salarie.Nom):
                                control.Text = _salarie.Nom;
                                break;
                            case nameof(Salarie.Prenom):
                                control.Text = _salarie.Prenom;
                                break;
                            case nameof(Salarie.TelephoneFixe):
                                control.Text = _salarie.TelephoneFixe;
                                break;
                            case nameof(Salarie.TelephonePortable):
                                control.Text = _salarie.TelephonePortable;
                                break;
                            case nameof(Salarie.Email):
                                control.Text = _salarie.Email;
                                break;
                            case nameof(Salarie.Site):
                                if (_salarie.Site != null)
                                {
                                    ((ComboBox)control).SelectedValue = _salarie.Site.Oid;
                                }
                                break;
                            case nameof(Salarie.Service):
                                if (_salarie.Service != null)
                                {
                                    ((ComboBox)control).SelectedValue = _salarie.Service.Oid;
                                }
                                break;
                        }
                    }
                }
            }
        }

        #endregion
        #endregion

        #region " Evénements liés aux sources de données "
        /// <summary>
        /// Se déclenche lors de l'ajout, la supression ou la modification d'un élément d'une liste
        /// </summary>
        /// <param name="sender">La liste modifiée</param>
        /// <param name="e"></param>
        private void ListChanged(object sender, ListChangedEventArgs e)
        {
            // On actualise les XpView pour synchroniser les modifications
            if (sender == this.Sites)
            {
                this.xpView_Site.Reload();
            }
            else if (sender == this.Services)
            {
                this.xpView_Service.Reload();
            }

            // On réinitialise le formulaire de détail à partir du salarié sélectionné
            this.ResetSalarie();
        }
        #endregion
    }
}
