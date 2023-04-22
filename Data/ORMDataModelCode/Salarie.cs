using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace AnnuaireEntreprise_2019.Data.AnnuaireEntreprise_DEV
{

    public partial class Salarie
    {
        public Salarie(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
