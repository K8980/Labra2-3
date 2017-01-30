using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra_6_Tehtava_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            CD_Levy cd = new CD_Levy();

            cd.Artisti = "Mixed";
            cd.LevynNimi = "Karpaasi kakas mix";
            cd.Hinta = 20f;

            cd.Laulut.Add("Laulu 1");
            cd.Laulut.Add("Laulu 2");
            cd.Laulut.Add("Laulu 3");
            cd.Laulut.Add("Laulu 4");
            cd.Laulut.Add("Laulu 5");
            cd.Laulut.Add("Laulu 6");
            cd.Laulut.Add("Laulu 7");
            cd.Laulut.Add("Laulu 8");
            cd.Laulut.Add("Laulu 9");
            cd.Laulut.Add("Laulu 10");
            cd.Laulut.Add("Laulu 11");
            cd.Laulut.Add("Laulu 12");
            cd.Laulut.Add("Laulu 13");
            cd.Laulut.Add("Laulu 14");
            cd.Laulut.Add("Laulu 15");
            cd.Laulut.Add("Laulu 16");
            cd.Laulut.Add("Laulu 17");
            cd.Laulut.Add("Laulu 18");
            cd.Laulut.Add("Laulu 19");
            cd.Laulut.Add("Laulu 20");
            cd.Laulut.Add("Laulu 21");
            cd.Laulut.Add("Laulu 22");
            cd.Laulut.Add("Laulu 23");
            cd.Laulut.Add("Laulu 24");
            cd.Laulut.Add("Laulu 25");
            cd.Laulut.Add("Laulu 26");
            cd.Laulut.Add("Laulu 27");
            cd.Laulut.Add("Laulu 28");
            cd.Laulut.Add("Laulu 29");
            cd.Laulut.Add("Laulu 30");
            cd.Laulut.Add("Laulu 31");

            foreach (string s in cd.Laulut)
            {
                Console.WriteLine(s);
            }
        }
    }
}