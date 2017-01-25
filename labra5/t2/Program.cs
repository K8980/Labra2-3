using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Tehtävä 2
             Pohdi jääkaappia reaalimaailman käsitteenä ja erityisesti sitä mitä sieltä löytyy. 
             Tee pienimuotoinen toteutus, joka koostaa jääkaapin sisältöä muutamista eri asioista/olioista.
            */

            Jaakaappi jaakaappi = new Jaakaappi();
            RuokaAines aines1 = new RuokaAines("Jugurtti, ");
            RuokaAines aines2 = new RuokaAines("Jauheliha, ");
            RuokaAines aines3 = new RuokaAines("Mehu, ");
            RuokaAines aines4 = new RuokaAines("Coca Cola, ");
            RuokaAines aines5 = new RuokaAines("Ruokakerma, ");
            RuokaAines aines6 = new RuokaAines("Kananmuna. ");

            jaakaappi.LisaaAines(aines1);
            jaakaappi.LisaaAines(aines2);
            jaakaappi.LisaaAines(aines3);
            jaakaappi.LisaaAines(aines4);
            jaakaappi.LisaaAines(aines5);
            jaakaappi.LisaaAines(aines6);

            Console.WriteLine("Jääkaapissa on: ");
            foreach (RuokaAines r in jaakaappi.RuokaAines)
            {
                Console.WriteLine(r.Nimi);
            }
        }
    }
}