using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOceanLib
{
    public class player
    {
        protected type playerType { get; set; }
        public int experience { get; set; } = 0;
        public string name { get; set; }

        public player()
        {
            this.playerType = type.tecnic;
            this.experience = 0;
            this.name = "Placeholder";
        }
        public void selectType()
        {
            int selection = 0;
            Console.WriteLine("Selecciona el teu personatje \n 1. Veterinari\n2. Tecnic");
            while (selection < 1 || selection > 2) {
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1: this.playerType = type.veterinari; break;
                    case 2: this.playerType = type.tecnic; break;
                    default: Console.WriteLine("Error, selecciona una altra vegada"); break;
                }
            }
        }

        public void selectName()
        {
            Console.WriteLine("Selecciona el teu nom");
            this.name = Console.ReadLine();
        }
    }
}
