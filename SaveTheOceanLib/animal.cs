namespace SaveTheOceanLib
{
    public class animal
    {
        public string Sfamily { get; set; } 
        public string Family { get; set; }
        public string Name { get; set; }
        public int AffectDegree { get; set; }

        public animal() { 
            this.Sfamily = "Tortuga Marina";
            this.Name = "tortuga";aa
            this.Family = "tortuga";
            this.AffectDegree = 0;
        }

        public void generateSfamily()
        {
            Random RNG = new Random();
            int select = RNG.Next(0, 3);

            switch (select)
            {
                case 0: this.Sfamily = "Tortuga Marina";
                    break;
                case 1:
                    this.Sfamily = "Au Marina";
                    break;
                case 2:
                    this.Sfamily = "Cetaci";
                    break;
            }
            
        }

        public void generateName()
        {
            Random RNG = new Random();
            string[] names = { "Falafel", "Flaffy", "Scrumba", "Brimblo", "Scrimblo", 
            "Scrimblo", "Theresa", "Baldurs gate 3", "Nuclear Reactor", "Thing", "Holy bingle", "Baron fofo",
            "Crispy", "Izutsumi"};
            this.Name = names[RNG.Next(0, names.Length)];
        }

        public void generateFamily()
        {
            Random RNG = new Random();
            string[] familiesTM = { "Tortuga llaüt", "Tortuga lora", "Tortuga golfina", "Tortuga caguama",
            "Tortuga carey", "Tortuga del pacífic"};
            string[] familiesAM = { "Corb mari", "Corb monyut", "Alcatraz comu", "Pardela", 
            "Gavina reidora", "Alca comú", "Fraret atlantic"};
            string[] familiesC = { "Balena", "Dofi", "Peix", "Cefalopod" };

            if (this.Sfamily == "Tortuga Marina")
            {
                this.Family = familiesTM[RNG.Next(0,familiesTM.Length)];
            } else if(this.Sfamily == "Au Marina")
            {
                this.Family = familiesAM[RNG.Next(0, familiesAM.Length)];
            }
            else
            {
                this.Family = familiesC[RNG.Next(0, familiesC.Length)];
            }
                       
        }

        public void setAD()
        {
            Random rnd = new Random();
            this.AffectDegree = rnd.Next(1, 100);
        }

        public int treat(string loc)
        {
            int x = 5;

            if (this.Sfamily == "Tortuga Marina")
            {
                this.AffectDegree = this.AffectDegree - ((this.AffectDegree - 2) * (2 * this.AffectDegree + 3)) - x;
            } else if (this.Sfamily == "Au Marina")
            {
                if (loc == "CRAM") x = 0;
                this.AffectDegree = this.AffectDegree - ((this.AffectDegree * this.AffectDegree) + x);
            }
            else
            {               
                x = 25;
                if (loc == "CRAM") x = 0;
                double affectedDlog = Math.Log10(this.AffectDegree);
                this.AffectDegree = this.AffectDegree - Convert.ToInt32(affectedDlog) - x;
            }
            return -1;
        }

    }
}
