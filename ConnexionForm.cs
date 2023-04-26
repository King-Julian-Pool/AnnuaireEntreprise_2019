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

        private void button_Valider_Click(object sender, EventArgs e)
        {
            string identifiant = this.textBox_Identifiant.Text;
            string motDePasse = this.textBox_MotDePasse.Text;

            if (identifiant != string.Empty && motDePasse != string.Empty)
            {

                BinaryOperator identifiantOp = new BinaryOperator(nameof(Utilisateur.Identifiant), identifiant);
                BinaryOperator motDePasseOp = new BinaryOperator(nameof(Utilisateur.MotDePasse), motDePasse);

                Utilisateur utilisateur = session.FindObject<Utilisateur>(CriteriaOperator.And(identifiantOp, motDePasseOp));

                if (this.parentMainForm is MainForm)
                {
                    if (utilisateur != null)
                    {
                        this.button_Valider.ForeColor = Color.Green;

                        parentMainForm.utilisateurIdentifiant = utilisateur.Identifiant;
                        parentMainForm.modeAdmin = utilisateur.Admin;
                        parentMainForm.connecte = true;
                        this.Close();
                    }
                    else
                    {
                        this.button_Valider.ForeColor = Color.Red;
                        parentMainForm.connecte = false;
                    }
                }
            }
        }
    }
}
