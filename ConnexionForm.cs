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
    public partial class ConnexionForm : Form
    {
        #region " Propriétés "
        Session session;
        MainForm parentMainForm;
        #endregion

        #region " Constructeur "
        public ConnexionForm(Session session, MainForm parentMainForm)
        {
            InitializeComponent();

            this.session = session;
            this.parentMainForm = parentMainForm;
        }
        #endregion

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
                    case "button_Valider":
                        this.Connexion();
                        break;
                    case "button_Fermer":
                        this.Close();
                        break;
                }
            }
        }
        #endregion

        #region " Connexion "
        private void Connexion()
        {
            string identifiant = this.textBox_Identifiant.Text;
            string MotDePasse = this.textBox_MotDePasse.Text;

            if (identifiant != string.Empty && MotDePasse != string.Empty)
            {
                BinaryOperator identifiantOp = new BinaryOperator(nameof(Utilisateur.Identifiant), identifiant);

                Utilisateur utilisateur = session.FindObject<Utilisateur>(CriteriaOperator.And(identifiantOp));

                if (this.parentMainForm is MainForm)
                {
                    try
                    {
                        if (utilisateur != null && BCrypt.Net.BCrypt.Verify(string.Format("{0}.{1}", MotDePasse, Program.SecretKey), utilisateur.MotDePasse))
                        {
                            parentMainForm.utilisateurIdentifiant = utilisateur.Identifiant;
                            parentMainForm.modeAdmin = utilisateur.Admin;
                            parentMainForm.connecte = true;
                            this.Close();
                        }
                        else
                        {
                            this.label_Erreur.Text = "Identifiant ou mot de passe incorrect";
                        }
                    }
                    catch (Exception ex)
                    {
                        this.label_Erreur.Text = "Identifiant ou mot de passe incorrect";
                        Console.WriteLine($"Erreur : {ex.Message}");
                    }
                }
            }
            else
            {
                this.label_Erreur.Text = "Veuillez renseigner un identifiant et un mot de passe";
            }
        }
        #endregion
    }
}
