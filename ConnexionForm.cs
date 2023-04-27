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
    }
}
