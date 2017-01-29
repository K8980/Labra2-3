using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra6t1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaHenkiloRekisteri();
        }
        static void TestaaHenkiloRekisteri()
        {
            //luodaan muuttuja
            Henkilot poppoo = new Henkilot();
            Henkilo hlo = new Henkilo { Etunimi = "Jack ", Sukunimi = "Sparrow ", HeTu = "987652-754Å " };
            Henkilo hlo1 = new Henkilo { Etunimi = "James ", Sukunimi = "Bond ", HeTu = "007007-007A " };
            Henkilo hlo2 = new Henkilo { Etunimi = "Ninjaspidar ", Sukunimi = "Kurwaspidar ", HeTu = "696969-6969 " };
            //lisätään henkilöt poppooseen
            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);
            foreach (Henkilo h in poppoo.HenkiloLista)
            {
                Console.WriteLine("{0}", h.ToString());
            }
            //TODO kysy käyttäjältä hetu ja haetaan sitä vastaava henkilö näytölle
             Console.WriteLine("\n Syötä henkilötunnus: ");
            string hetu = Console.ReadLine();
            Henkilo haettu = poppoo.HaeHenkiloHetulla(hetu);
            Console.WriteLine();
            if (haettu != null)
            {
                Console.WriteLine(haettu.ToString()); 
            }
            else
            {
                Console.WriteLine("Ei löytynyt. Better luck next time");
            }

        }
    }
}
