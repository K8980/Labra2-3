using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Hizzi
    {
       // private int NykyinenKerros;
        //private int uusiKerros;
        private const int minKerros = 1;
        private const int maxKerros = 5;
        public int OnkoPaalla {get; set;}
        public bool VaihdaKerros(int UusiKerros)
        {
            if (UusiKerros >= minKerros && UusiKerros <= maxKerros)
                return true;
            else
            {
                return false;
            } 

        }
    }
}
