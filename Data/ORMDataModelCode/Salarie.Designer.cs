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

    public partial class Salarie : XPObject
    {
        string fNom;
        public string Nom
        {
            get { return fNom; }
            set { SetPropertyValue<string>(nameof(Nom), ref fNom, value); }
        }
        string fPrenom;
        public string Prenom
        {
            get { return fPrenom; }
            set { SetPropertyValue<string>(nameof(Prenom), ref fPrenom, value); }
        }
        string fTelephoneFixe;
        public string TelephoneFixe
        {
            get { return fTelephoneFixe; }
            set { SetPropertyValue<string>(nameof(TelephoneFixe), ref fTelephoneFixe, value); }
        }
        string fTelephonePortable;
        public string TelephonePortable
        {
            get { return fTelephonePortable; }
            set { SetPropertyValue<string>(nameof(TelephonePortable), ref fTelephonePortable, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        Service fService;
        [Association(@"SalarieReferencesService")]
        public Service Service
        {
            get { return fService; }
            set { SetPropertyValue<Service>(nameof(Service), ref fService, value); }
        }
        Site fSite;
        [Association(@"SalarieReferencesSite")]
        public Site Site
        {
            get { return fSite; }
            set { SetPropertyValue<Site>(nameof(Site), ref fSite, value); }
        }
    }

}
