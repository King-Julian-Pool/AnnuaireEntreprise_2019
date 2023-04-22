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
        XPCollection<Salarie> Salaries;
        XPCollection<Site> Sites;
        XPCollection<Service> Services;
        public Control[] FormControls;

        private Salarie _salarie;
        public Salarie Salarie
        {
            get => _salarie;
            set
            {
                ClearDataBindings();

                _salarie = value;

                if (_salarie != null)
                {
                    this.InitDataBindings();
                }
            }
        }
        public MainForm()
        {
            InitializeComponent();

            this.dataGridView_Salarie.AutoGenerateColumns = false;

            Salaries = new XPCollection<Salarie>(this.session);
            this.dataGridView_Salarie.DataSource = Salaries;

            this.xpCollection_Salarie.Dispose();

            Sites = new XPCollection<Site>(this.session);
            ((ListBox)this.checkedListBox_Site).DataSource = Sites;
            ((ListBox)this.checkedListBox_Site).DisplayMember = "Ville";

            Services = new XPCollection<Service>(this.session);
            ((ListBox)this.checkedListBox_Service).DataSource = Services;
            ((ListBox)this.checkedListBox_Service).DisplayMember = "Nom";


            
            this.comboBox_Site.DataSource = this.xpView_Site;
            this.comboBox_Site.DisplayMember = "Ville";
            this.comboBox_Site.ValueMember = "Oid";

            this.comboBox_Service.DataSource = this.xpCollection_Service;
            this.comboBox_Service.DisplayMember = "Nom";
            this.comboBox_Service.ValueMember = "Oid";

            this.FormControls = new Control[] {
                this.textBox_Nom,
                this.textBox_Prenom,
                this.textBox_TelephoneFixe,
                this.textBox_TelephonePortable,
                this.textBox_Email,
                this.comboBox_Site,
                this.comboBox_Service
            };
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button != null)
            {
                switch (button.Name)
                {
                    case "button_NouveauSalarie":
                        NouveauSalarie();
                        break;
                    case "button_SupprimerSalarie":
                        SupprimerSalarie();
                        break;
                    case "button_SauvegarderSalarie":
                        SauvegarderSalarie();
                        break;
                    case "button_AnnulerSalarie":
                        Annuler();
                        break;
                    case "button_ReinitialiserFiltre":
                        ReinitialiserFiltre();
                        break;
                        //case "button_NouveauSite":
                        //    NouveauSite();
                        //    break;
                        //case "button_SupprimerSite":
                        //    SupprimerSite();
                        //    break;
                }
            }
        }

        private void NouveauSalarie()
        {
            Salarie salarie = new Salarie(this.session);

            salarie.Save();

            this.Salaries.Reload();

            this.dataGridView_Salarie.Rows[this.Salaries.IndexOf(salarie)].Selected = true;
        }

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

        private void SauvegarderSalarie()
        {
            if (dataGridView_Salarie.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView_Salarie.SelectedRows[0];

                if (row != null)
                {

                    if (this._salarie != null && this.FormControls != null)
                    {
                        foreach (Control control in this.FormControls)
                        {
                            if (control?.Tag != null && this._salarie != null)
                            {
                                string tag = (string)control.Tag;

                                switch (tag)
                                {
                                    case nameof(Salarie.Nom):
                                        this._salarie.Nom = control.Text;
                                        break;
                                    case nameof(Salarie.Prenom):
                                        this._salarie.Prenom = control.Text;
                                        break;
                                    case nameof(Salarie.TelephoneFixe):
                                        this._salarie.TelephoneFixe = control.Text;
                                        break;
                                    case nameof(Salarie.TelephonePortable):
                                        this._salarie.TelephonePortable = control.Text;
                                        break;
                                    case nameof(Salarie.Email):
                                        this._salarie.Email = control.Text;
                                        break;
                                    case nameof(Salarie.Site):
                                        ComboBox comboBoxSite = (ComboBox)control;

                                        bool siteExist = false;

                                        if (comboBoxSite?.SelectedValue != null)
                                        {
                                            int? SiteOid = (int)comboBoxSite.SelectedValue;

                                            if (SiteOid != null && SiteOid > 0)
                                            {
                                                this._salarie.Site = this.Sites.FirstOrDefault(s => s.Oid == SiteOid);
                                                siteExist = true;
                                            }
                                        }

                                        if (!siteExist)
                                        {
                                            this._salarie.Site = null;
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
                                                this._salarie.Service = this.Services.FirstOrDefault(s => s.Oid == ServiceOid);
                                                serviceExist = true;
                                            }
                                        }

                                        if (!serviceExist)
                                        {
                                            this._salarie.Service = null;
                                        }

                                        break;
                                }
                            }
                        }

                        this._salarie.Save();
                    }
                }
            }
        }

        private void Annuler()
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

        private void ReinitialiserFiltre()
        {
            this.textBox_NomPrenom.Text = string.Empty;


            for (int i = 0; i < this.checkedListBox_Site.Items.Count; i++)
            {
                this.checkedListBox_Site.SetItemChecked(i, false);
            }

            foreach (Site site in this.xpCollection_Site)
            {
                if (site.IsChecked)
                {
                    site.IsChecked = false;
                }
            }

            foreach (Service service in this.xpCollection_Service)
            {
                if (service.IsChecked)
                {
                    service.IsChecked = false;
                }
            }

            UpdateCriteria();

        }

        //private void NouveauSite()
        //{
        //    Site site = new Site(this.session);

        //    site.Save();

        //    this.xpCollection_Site.Reload();
        //    xpCollection_Site.Reload();

        //    this.dataGridView_Site.Rows[xpCollectionSite.IndexOf(site)].Selected = true;
        //}

        //private void SupprimerSite()
        //{
        //    if (dataGridView_Site.SelectedRows.Count > 0)
        //    {
        //        DataGridViewRow row = dataGridView_Site.SelectedRows[0];

        //        if (row != null)
        //        {
        //            Site? site = row.DataBoundItem as Site;

        //            if (site != null)
        //            {
        //                row.Dispose();
        //                site.Delete();
        //                xpCollectionSite.Reload();
        //            }
        //        }
        //    }
        //}
        private void textBox_NomPrenom_TextChanged(object sender, EventArgs e)
        {
            UpdateCriteria();
        }

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
            foreach (Site site in this.xpCollection_Site)
            {
                if (site.IsChecked)
                {
                    SiteOp = new BinaryOperator("Site.IsChecked", true);
                    break;
                }
            }

            BinaryOperator ServiceOp = null;
            foreach (Service service in this.xpCollection_Service)
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


        private void ClearDataBindings()
        {
            if (this.FormControls != null)
            {
                foreach (Control control in this.FormControls)
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

        private void InitDataBindings()
        {
            if (this.FormControls != null)
            {
                foreach (Control control in this.FormControls)
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
    }
}
