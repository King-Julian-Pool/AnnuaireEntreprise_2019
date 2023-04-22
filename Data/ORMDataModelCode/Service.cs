using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Data
{

    public partial class Service
    {
        [NonPersistent]
        public bool IsChecked { get; set; } = false;
        public Service(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
