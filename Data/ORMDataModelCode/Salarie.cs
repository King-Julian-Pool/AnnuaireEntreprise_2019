using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Data
{

    public partial class Salarie
    {
        public string ServiceNom
        {
            get
            {
                if (this.Service != null)
                {
                    return this.Service.Nom;
                }
                return String.Empty;
            }
        }

        public string SiteVille
        {
            get
            {
                if (this.Site != null)
                {
                    return this.Site.Ville;
                }
                return String.Empty;
            }
        }
        public Salarie(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
