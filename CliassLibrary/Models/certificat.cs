using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliassLibrary.Models
{
    public partial class certificat
    {
        public int Num_cert { get; set; }
        public string Nom { get; set; }
        public string institut { get; set; }
        public string annén { get; set; }
        public Nullable<int> C_Id_doc { get; set; }
    }
}
