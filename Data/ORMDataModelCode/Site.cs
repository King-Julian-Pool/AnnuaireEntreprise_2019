using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Data
{

    public partial class Site
    {
        [NonPersistent]
        public bool IsChecked { get; set; } = false;
        public Site(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
