//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetWellWebApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class certificat
    {
        public int Num_cert { get; set; }
        public string Nom { get; set; }
        public string institut { get; set; }
        public string annén { get; set; }
        public Nullable<int> C_Id_doc { get; set; }
    
        public virtual medecin medecin { get; set; }
    }
}