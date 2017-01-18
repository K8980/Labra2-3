using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Teevee
    {
        public int Kanava { get; set; }
        public bool Virta { get; set; }

        public Teevee() { }
        public Teevee(int kanava)
        {
            Kanava = kanava;
        }
    }
}
