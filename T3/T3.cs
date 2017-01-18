using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class T3
    {
        static void Main(string[] args)
        {
            int kanava;

            Teevee tv = new Teevee();
            
            tv.Virta = true;

            if (tv.Virta)
            {
                Console.WriteLine("TV on päällä. ");
            }

            Console.Write("Valitse kanava? ");
            if (int.TryParse(Console.ReadLine(), out kanava))
            {
                tv.Kanava = kanava;
            }

            Console.WriteLine("Kanava: " + tv.Kanava + " on päällä. ");

            tv.Virta = false;
            if (!tv.Virta)
            {
                Console.WriteLine("Televisio on pois päältä. ");
            }
        }
    }
}
