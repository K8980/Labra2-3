using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra_6_Tehtava_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            List<Card> cards = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                cards.Add(deck.DrawCard());
            }

            //cards.Sort();

            foreach (Card c in cards)
            {
                Console.WriteLine(c.CardValue + " of " + c.CardSuite);
            }



        }
    }
}