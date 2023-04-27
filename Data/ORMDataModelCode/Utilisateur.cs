using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using AnnuaireEntreprise_2019;
using System.Windows.Forms;

namespace Data
{

    public partial class Utilisateur
    {
        [NonPersistent]
        private bool MotDePasseModified;
        public Utilisateur(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        protected override void OnChanged(string propertyName, object oldValue, object newValue)
        {
            base.OnChanged(propertyName, oldValue, newValue);

            switch (propertyName)
            {
                case nameof(this.Identifiant):
                    if(Session.FindObject<Utilisateur>(new BinaryOperator(nameof(this.Identifiant), this.Identifiant)) != null){
                        this.Identifiant = (string)oldValue;
                        MessageBox.Show("Cet identifiant est déjà associé à un autre utilisateur, veuillez en saisir un autre.", "Identifiant existant", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                    }                    
                    break;

                case nameof(this.MotDePasse):

                    if(newValue != null && oldValue != newValue && !this.MotDePasseModified)
                    {
                        this.MotDePasseModified = true;
                    }
                    else
                    {
                        this.MotDePasseModified = false;
                    }

                    break;
            }
        }

        protected override void OnSaving()
        {
            base.OnSaving();

            if(this.MotDePasse != null && this.MotDePasseModified)
            {
                this.MotDePasse = BCrypt.Net.BCrypt.HashPassword(string.Format("{0}.{1}", MotDePasse, Program.SecretKey));
            }
        }
    }

}
