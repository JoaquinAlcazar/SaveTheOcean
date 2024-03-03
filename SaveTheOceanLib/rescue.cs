using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOceanLib
{
    public class rescue
    {
        public int RescueNum { get; set; }
        public string RescueDate { get; set; }
        protected string animalSuperfamily { get; set; }
        public int affectDegree { get; set; }
        public string localization { get; set; }

        public rescue (int rescueNumm, string animalSuperfamily, int affectDegree)
        {
            this.RescueNum = rescueNumm;
            this.RescueDate = Convert.ToString(DateTime.Now); ;
            this.animalSuperfamily = animalSuperfamily;
            this.affectDegree = affectDegree;
            this.localization = "California";
        }

        public void setLocation()
        {
            Random random = new Random();
            string[] locations = { "Deltebre", "Sitges", "Begur", "Calella de Palafrugell", "L'Escala",
            "Barcelona", "Badalona", "Arenys de Mar", "Gavà", "Tamariu", "Llançà", "Castelldefels"};

            this.localization = locations[random.Next(0,locations.Length)];
        }

        
    }
}
