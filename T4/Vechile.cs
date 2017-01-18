using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Vechile
    {
        public string Name {get;}

        int speed;
        public int Speed
        {
            get {return speed;}
            set {if (!(value >= 0 && value <= 380))
                    speed = value;
                else
                    speed = 0;}
        }

        int tyres;
        public int Tyres
        {
            get{return tyres;}
            set{if (!(value >= 10 && value <= 150))
                    tyres = 14;
                else
                    tyres = value;}
        }

        public Vechile(string name, int vechileSpeed, int tires)
        {
            if (!(speed >= 0 && speed <= 380))
                vechileSpeed = 0;

            if (tyres >= 10 && tyres <= 150)
                tires = 14;

            speed = vechileSpeed;
            tyres = tires;
            Name = name;
        }

        public void PrintData()
        {
            Console.WriteLine("Vechile: " + Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }

        public override string ToString()
        {
            string s = Name + ", " + Speed + ", " + Tyres;
            return "";
        }
    }
}