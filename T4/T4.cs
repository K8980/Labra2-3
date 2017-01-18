using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra3_tehtava_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vechile vechile0 = new Vechile("Lambo", 330, 19);
            Vechile vechile1 = new Vechile("Tracktori", 45, 150);
            Vechile vechile2 = new Vechile("Bugatti", 380, 21);
            Vechile vechile3 = new Vechile("Lada", 80, 14);

            vechile0.PrintData();
            vechile1.PrintData();
            vechile2.PrintData();
            vechile3.PrintData();

            vechile0.ToString();
            vechile1.ToString();
            vechile2.ToString();
            vechile3.ToString();
        }
    }
}