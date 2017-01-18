using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;
namespace Viikkotehtävät
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaKiuas();
        }


        // tehtävän 1 Kiuas-luokan testaus
        static void TestaaKiuas()
        {
            //lyodaan kiuas olio

            Kiuas kiuas = new Kiuas();
            //pistetään kiuas lämpenemään ja asetetaan lämpöä & kosteutta
            kiuas.OnkoPäällä = true;
            kiuas.Lämpötila = 90F;
            kiuas.Kosteus = 50F;
            //näytetään lämpötila ja kosteus

            Console.WriteLine("Kiuas on päällä {0} ja ", kiuas.OnkoPäällä);
            Console.WriteLine("lämpötila on {0} astetta", kiuas.Lämpötila);
            Console.WriteLine("kosteus {0}", kiuas.Kosteus);
            //Mitä tapahtuu jos kosteus yli rajojen

            kiuas.Kosteus = 101;
            Console.WriteLine("kiukaan kosteus {0}", kiuas.Kosteus);
        }
    }
}