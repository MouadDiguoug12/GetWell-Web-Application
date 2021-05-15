using System;
using CliassLibrary.DataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliassLibrary.Models;
using System.Data;
using Dapper;

namespace CliassLibrary.BussinessLogic
{
    public class MedecinProcessor
    {
        public static bool CreateMedecin(string User,string CIN ,string Name,
            string Fname , Byte image, string Tele, string Mail, string Mdp,string City, string Adress,double longi ,
            double lat,string link,string Fb, string whatssap,string Insta,string Twit)
        {
            bool result = false;
            if (CheckMedecin(CIN) == 0)
            {
                Medecin data = new Medecin
                {
                    username = User,
                    cin = CIN,
                    Nom = Name,
                    Prenom = Fname,
                    photo = image,
                    Telephone = Tele,
                    Email = Mail,
                    Password = Mdp,
                    Ville=City,
                    Adresse = Adress,
                    longitude=longi,
                    latitude = lat,
                    Linkedin = link,
                    Facebook = Fb,
                    Whatssap = whatssap,
                    Instagram = Insta,
                    Twitter = Twit
                    
                };

                string sql = "AddMedecin";

                SqlDataAccess.SaveData(sql, data);

                result = true;
            }
            return result;
        }
        public static int CheckMedecin(string cin)
        {
            string sql = "Select count(*) from Medecin where cin = @cin";

            var qp = new DynamicParameters();
            qp.Add(name: "@cin", value: cin, dbType: DbType.String, direction: ParameterDirection.Input);

            return SqlDataAccess.ReturnsSingleValue(sql, qp);
        }
       
          
    }
}
