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
            string[] names = { "Falafel", "Flaffy", "Scrumba", "Brimblo", 
            "Scrimblo", "Theresa", "Baldurs gate 3", "Nuclear Reactor", "Thing", "Holy bingle", "Baron fofo",
            "Crispy", "Izutsumi", "Tetris", "Nigel", "Basil", "Benjamin", "Alana", "Angelica", "Baja Blast", "Alaska",
            "Ratio", "Griddy", "Little dude", "Faust", "Bunkachunko", "Ka-ching", "Felxtape", "Mint", "Undecim", "Zeta",
            "Yi Sang", "Santiago", "Miserable", "Raquel", "Sissyphus", "Duke Erisia", "Regent", "Evengarde Rest", "Dantes",
            "L", "Hong Lu", "Meursault", "Sinclair", "Don", "Vergel", "Pepinex", "ElXokas", "Weyler", "Shibi", "Eusebio",
            "Haganeno", "Chorretosa", "Carlos", "Chidori", "Jhin", "Alex", "Coco", "Werlyb", "Joan Colomer", "EMPLOYEES",
            "MongoDB", "Roblox", "Guilty Gear", "4chan", "Cáceres", "Francesco Virgolini", "Skibidi Toilet", "Maya", 
            "Blender 4.0", "Alcolchon", "Noelia", "Alexia", "11th September 2001", "Rolando", "Kali", "Gato", "Javi",
            "Blender 3.5", "Visual Studio 2022", "Discord", "Sora", "Tiananmen", "Fifi", "README", "Flipabimbo", "Lesseps",
            "Bella", "Sigma", "Mewing", "Pluto", "Argalia", "Somalia", "Andrés", "Hod", "Yesod", "Chesed", "Gebura", "Hokma",
            "Tiphereth", "Angela", "Binah", "Vergilius", "Rodion", "Ayin", "Francisco José", "Baklava", "Orteil", "Malkuth"};
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
