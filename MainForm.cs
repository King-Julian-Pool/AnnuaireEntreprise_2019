using Data;
using DevExpress.Data.Filtering;
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
        public MainForm()
        {
            InitializeComponent();

            ((ListBox)this.checkedListBox_Site).DataSource = this.xpCollection_Site;
            ((ListBox)this.checkedListBox_Site).DisplayMember = "Ville";

            ((ListBox)this.checkedListBox_Service).DataSource = this.xpCollection_Service;
            ((ListBox)this.checkedListBox_Service).DisplayMember = "Nom";

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
            
            this.xpCollection_Salarie.Reload();

            this.dataGridView_Salarie.Rows[this.xpCollection_Salarie.IndexOf(salarie)].Selected = true;
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
                        this.xpCollection_Salarie.Reload();
                    }
                }
            }
        }

        private void SauvegarderSalarie()
        {
            //if (dataGridView_Salarie.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow row = dataGridView_Salarie.SelectedRows[0];

            //    if (row != null)
            //    {
            //        Salarie salarie = row.DataBoundItem as Salarie;

            //        //Control[] controls = this.userControl_Salarie?.FormControls;


            //        if (salarie != null && controls != null)
            //        {
            //            foreach (Control control in controls)
            //            {
            //                if (control?.Tag != null && salarie != null)
            //                {
            //                    string tag = (string)control.Tag;

            //                    switch (tag)
            //                    {
            //                        case nameof(Salarie.Nom):
            //                            salarie.Nom = control.Text;
            //                            break;
            //                        case nameof(Salarie.Prenom):
            //                            salarie.Prenom = control.Text;
            //                            break;
            //                        case nameof(Salarie.TelephoneFixe):
            //                            salarie.TelephoneFixe = control.Text;
            //                            break;
            //                        case nameof(Salarie.TelephonePortable):
            //                            salarie.TelephonePortable = control.Text;
            //                            break;
            //                        case nameof(Salarie.Email):
            //                            salarie.Email = control.Text;
            //                            break;
            //                        case nameof(Salarie.Site):
            //                            ComboBox comboBoxSite = (ComboBox)control;

            //                            bool siteExist = false;

            //                            if (comboBoxSite?.SelectedValue != null)
            //                            {
            //                                int? SiteOid = (int)comboBoxSite.SelectedValue;

            //                                if (SiteOid != null && SiteOid > 0)
            //                                {
            //                                    salarie.Site = this.Sites.FirstOrDefault(s => s.Oid == SiteOid);
            //                                    siteExist = true;
            //                                }
            //                            }

            //                            if (!siteExist)
            //                            {
            //                                salarie.Site = null;
            //                            }

            //                            break;
            //                        case nameof(Salarie.Service):
            //                            ComboBox comboBoxService = (ComboBox)control;

            //                            bool serviceExist = false;

            //                            if (comboBoxService?.SelectedValue != null)
            //                            {
            //                                int? ServiceOid = (int)comboBoxService.SelectedValue;

            //                                if (ServiceOid != null && ServiceOid > 0)
            //                                {
            //                                    salarie.Service = this.Services.FirstOrDefault(s => s.Oid == ServiceOid);
            //                                    serviceExist = true;
            //                                }
            //                            }

            //                            if (!serviceExist)
            //                            {
            //                                salarie.Service = null;
            //                            }

            //                            break;
            //                    }
            //                }
            //            }

            //            salarie.Save();
            //            //this.xpCollection_Salarie.Reload();
            //        }
            //    }
            //}
        }

        private void Annuler()
        {
            //if (dataGridView_Salarie.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow row = dataGridView_Salarie.SelectedRows[0];

            //    if (row != null)
            //    {
            //        Salarie? salarie = row.DataBoundItem as Salarie;

            //        if (salarie != null)
            //        {
            //            this.userControl_Salarie.Salarie = salarie;
            //        }
            //    }
            //}
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

            this.xpCollection_Salarie.Criteria = criteria;
        }

        private void dataGridView_Salarie_SelectionChanged(object sender, EventArgs e)
        {

        }

    }
}
