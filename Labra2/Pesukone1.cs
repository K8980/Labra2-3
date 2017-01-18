using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Pesukone
    {
        public enum PesuOhjelma
        {
            PikaPesu,
            KylmaPesu,
            PitkaPesu,
            KuumaPesu,
            HienoPesu
        };
        PesuOhjelma pesuOhjelma;

        public bool Virta { get; set; }
        public bool Linkous { get; set; }
        public bool Pyöriminen { get; set; }

        public Pesukone()
        {
            Console.WriteLine("Tekee pesukonetta");
        }
        public Pesukone(PesuOhjelma ohjelma) : base()
        {
            pesuOhjelma = ohjelma;
        }
        public Pesukone(PesuOhjelma ohjelma, bool virta) : this(ohjelma)
        {
            Virta = virta;
        }
        public Pesukone(PesuOhjelma ohjelma, bool virta, bool pyöriminen) : this(ohjelma, virta)
        {
            Pyöriminen = pyöriminen;
        }
        public Pesukone(PesuOhjelma ohjelma, bool virta, bool pyöriminen, bool linkous) : this(ohjelma, virta, pyöriminen)
        {
            Linkous = linkous;
        }
        public void Aloita()
        {
            switch (pesuOhjelma)
            {
                case PesuOhjelma.PikaPesu:
                    Console.WriteLine("Pesee nopeasti pyykit");
                    break;
                case PesuOhjelma.KylmaPesu:
                    Console.WriteLine("Pesee kylmällä vedellä pyykit");
                    break;
                case PesuOhjelma.PitkaPesu:
                    Console.WriteLine("Pesee pitkään ja huolellisesti pyykit");
                    break;
                case PesuOhjelma.KuumaPesu:
                    Console.WriteLine("Pesee kuumalla vedellä pyykit");
                    break;
                case PesuOhjelma.HienoPesu:
                    Console.WriteLine("Pesee huolella ja hyvin pyykit");
                    break;
                default:
                    Console.WriteLine("Mitään ei ole valittu.");
                    break;
            }
        }
    }
}