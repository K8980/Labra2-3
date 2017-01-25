using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    /// <summary>
    /// This contains person properties
    /// </summary>
    class Henkilo
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string HeTu { get; set; }
        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + HeTu;
        }
    }
    ///This class holds person information in a collection
    ///
    class Henkilot
    {
        private List<Henkilo> henkilot;
        public List<Henkilo> HenkiloLista
        {
            get { return henkilot; }
        }
        public Henkilot()
        {
            henkilot = new List<Henkilo>();
        }
        public void LisaaHenkilo(Henkilo hlo)
        {
            henkilot.Add(hlo);
        }
        public Henkilo HaeHenkilo(int index)
        {
            if (index < henkilot.Count)
            {
                return henkilot.ElementAt(index);
            }
            else
            {
                return null;
            }
        }
        public Henkilo HaeHenkiloHeTulla(string hetu)
        {
            foreach (Henkilo hlo in henkilot)
            {
                if (hlo.HeTu == hetu)
                {
                    return hlo;
                }
            }
            return null;
        }
    }

  
}
