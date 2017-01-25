using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5_tehtava_1
{
    class Program
    {
        static void Main(string[] args)
        {
          

            List<Auto> autot = new List<Auto>();

            bool poop = true;

            Auto tempAuto;
            Rengas tempRengas;

            for (int i = 0; i < 2; i++)
            {
                tempAuto = new Auto(4);

                Console.WriteLine("Auton Merkki");
                tempAuto.Merkki = Console.ReadLine();

                Console.WriteLine("Auton Malli");
                tempAuto.Malli = Console.ReadLine();

                for (int y = 0; y < tempAuto.RenkaidenLkm; y++)
                {
                    tempRengas = new Rengas();
                    tempRengas.Valmistaja = "Nokia";
                    tempRengas.Malli = "3110";
                    tempRengas.Rengaskoko = 15;
                    tempRengas.Tyyppi = "Talvi";
                    tempAuto.LisaaRengas(tempRengas);
                }
                autot.Add(tempAuto);
            }

            foreach (Auto a in autot)
            {
                Console.WriteLine("Merkki: " + a.Merkki + ", Malli: " + a.Malli);
                foreach (Rengas r in a.Renkaat)
                {
                    Console.WriteLine("Renkaan valmistaja: " + r.Valmistaja + ", malli: " + r.Malli + ", tyyppi: " + r.Tyyppi + ", koko: " + r.Rengaskoko);
                }
            }


        }
    }
}