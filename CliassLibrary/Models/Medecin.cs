using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace CliassLibrary.Models
{
    class Medecin

    {
        public Medecin doctor = new Medecin();

        public string username { get; set; }
        public string cin { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Nullable<System.Byte> photo { get; set; }

        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Ville { get; set; }
        public string Adresse { get; set; }
        public Nullable<double> longitude { get; set; }
        public double latitude { get; set; }
        public string Linkedin { get; set; }
        public string Facebook { get; set; }
        public string Whatssap { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }



    }
}
