using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Jaakaappi
    {
        List<RuokaAines> ruokaAines = new List<RuokaAines>();

        public List<RuokaAines> RuokaAines
        {
            get
            {
                return ruokaAines;
            }
        }

        public void LisaaAines(RuokaAines aines)
        {
            ruokaAines.Add(aines);
        }


       
        
    }
}