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
        Session session;
        MainForm parentMainForm;
        public ConnexionForm(Session session, MainForm parentMainForm)
        {
            InitializeComponent();

            this.session = session;
            this.parentMainForm = parentMainForm;
        }

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
        private void Connexion()
        {
            string identifiant = this.textBox_Identifiant.Text;
            string cryptedMotDePasse = this.textBox_MotDePasse.Text;

            if (identifiant != string.Empty && cryptedMotDePasse != string.Empty)
            {
                string decryptedMotDePasse = this.Decrypt(cryptedMotDePasse);

                BinaryOperator identifiantOp = new BinaryOperator(nameof(Utilisateur.Identifiant), identifiant);
                BinaryOperator motDePasseOp = new BinaryOperator(nameof(Utilisateur.MotDePasse), decryptedMotDePasse);

                Utilisateur utilisateur = session.FindObject<Utilisateur>(CriteriaOperator.And(identifiantOp, motDePasseOp));

                if (this.parentMainForm is MainForm)
                {
                    if (utilisateur != null)
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
            }
            else
            {
                this.label_Erreur.Text = "Veuillez renseigner un identifiant et un mot de passe";
            }
        }

        private string Decrypt(string cryptedPassword)
        {
            string decryptedPassword = null;



            return decryptedPassword;
        }
    }
}
