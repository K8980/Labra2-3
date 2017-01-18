using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra2
{
    class T2
    {
        static void Main(string[] args)
        {
            Pesukone pesukone0 = new Pesukone(Pesukone.PesuOhjelma.PikaPesu);
            Pesukone pesukone1 = new Pesukone(Pesukone.PesuOhjelma.KylmaPesu);
            Pesukone pesukone2 = new Pesukone(Pesukone.PesuOhjelma.PitkaPesu);
            Pesukone pesukone3 = new Pesukone(Pesukone.PesuOhjelma.KuumaPesu);
            Pesukone pesukone4 = new Pesukone(Pesukone.PesuOhjelma.HienoPesu);

            pesukone0.Aloita();
            pesukone1.Aloita();
            pesukone2.Aloita();
            pesukone3.Aloita();
            pesukone4.Aloita();
        }
    }
}
