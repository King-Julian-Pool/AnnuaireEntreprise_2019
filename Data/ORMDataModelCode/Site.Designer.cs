﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Data
{

    public partial class Site : XPObject
    {
        string fVille;
        public string Ville
        {
            get { return fVille; }
            set { SetPropertyValue<string>(nameof(Ville), ref fVille, value); }
        }
        [Association(@"SalarieReferencesSite")]
        public XPCollection<Salarie> Salaries { get { return GetCollection<Salarie>(nameof(Salaries)); } }
    }

}
