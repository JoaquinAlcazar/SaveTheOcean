using SaveTheOceanLib;
using SaveTheOceanLib;

namespace saveTheOcean
{
    public class saveTheOceanGame
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            //Instanciació del animal
            animal animal = new animal();
            animal.generateSfamily();
            animal.generateFamily();
            animal.generateName();
            animal.setAD();

            //Instanciacio del jugador
            player jugador = new player();

            const string welcomeMSG = "Save the ocean!\nQue vols fer?";
            const string mainMenu = "1. Jugar!\n2. Sortir";
            const string byebyeMSG = "Gracies per jugar!";
            const string reSelect = "Valor invalid, selecciona 1 o 2";
            const string rescueMenu = "RESCAT\nRescat: RES{0}\nData rescat: {1}\nSuperfamilia: {2}" +
                "\nGA: {3}\nLocalitzacio: {4}\n\nAquí tens la seva fitxa, per a més informació:\n" +
                "Nom: {5}\nSuperfamilia: {2}\nEspecie: {6}\n\n" +
                "El {6} té un grau d'affectació (GA) del {3}%. Vols curar-lo aquí" +
                "(1) o traslladar-la al centre (2)?";
            const string rescueSuccess = "El tractament aplicat ha reduït el GA fins al {0}%. " +
                "L’exemplar està recuperat i pot tornar al seu hàbitat. " +
                "La teva experiència ha augmentat en +50XP." +
                "\n\nFins el proper rescat!";
            const string rescueFailiure = "El tractament aplicat ha reduït el GA fins al {0}%. " +
                "No ha estat prou efectiu i cal traslladar l’exemplar al centre. " +
                "La teva experiència s’ha reduït en -20XP.\n\nFins el proper rescat!";
            

            int mainMenuSelect = 0;
            int locationSelection = 0;

            Console.WriteLine(welcomeMSG);
            Console.WriteLine(mainMenu);

            while (mainMenuSelect < 1 ||  mainMenuSelect > 2) {
                mainMenuSelect = Convert.ToInt32(Console.ReadLine());
                if (mainMenuSelect == 2)
                {
                    Console.Clear();
                    Console.WriteLine(byebyeMSG);
                }
                else if(mainMenuSelect == 1) {
                    jugador.selectName();
                    //Instanciacio de rescue
                    rescue rescue = new rescue(rnd.Next(1, 999), animal.Sfamily, animal.AffectDegree);
                    rescue.setLocation();
                    Console.Clear();
                    Console.WriteLine(rescueMenu, rescue.RescueNum, rescue.RescueDate, animal.Sfamily, animal.AffectDegree
                        ,rescue.localization, animal.Name,animal.Family);
                    while (locationSelection < 1 || locationSelection > 2) {
                        locationSelection = Convert.ToInt32(Console.ReadLine());
                        switch (locationSelection)
                        {
                            case 1: break;
                            case 2: rescue.localization = "CRAM"; break; 
                            default: Console.WriteLine(reSelect); break;
                        }
                    }

                    animal.treat(rescue.localization);
                    if (animal.AffectDegree < 5)
                    {
                        Console.WriteLine(rescueSuccess, animal.AffectDegree);
                    }
                    else
                    {
                        Console.WriteLine(rescueFailiure, animal.AffectDegree);
                    }
                    

                } else{
                    Console.WriteLine(reSelect);
                }
            }
            
        }
    }
}
