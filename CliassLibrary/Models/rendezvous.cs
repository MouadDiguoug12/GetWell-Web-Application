using System;
using System.Collections.Generic;

namespace CliassLibrary.Models
{
    public class rendezvous
    {
        public int Id_rv { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> dateprise { get; set; }
        public Nullable<System.TimeSpan> temp_rdv { get; set; }
        public Nullable<int> C_Id_patient { get; set; }
        public Nullable<int> C_Id_doc { get; set; }
        public Nullable<int> C_Id_cat { get; set; }
        
    }
}
