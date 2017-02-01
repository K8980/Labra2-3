using JAMK.IT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra_7_Tehtava_2
{
    class Program
    {
        static void Main(string[] args)
        {           
            try
            {
                List<Henkilo> ukkelit = new List<Henkilo>();
                using (StreamReader sr = new StreamReader("input.txt"))
                {
                    Henkilo temp;
                    string s;
                    string[] split;
                    while ((s = sr.ReadLine()) != null)
                    {
                        temp = new Henkilo();
                        split = s.Split(' ');
                        temp.Etunimi = split[0];
                        temp.Sukunimi = split[1];
                        ukkelit.Add(temp);
                    }

                    Dictionary<string, int> montaNimea = new Dictionary<string, int>();

                    for (int i = 0; i < ukkelit.Count; i++)
                    {
                        if (montaNimea.ContainsKey(ukkelit[i].Etunimi))
                        {
                            montaNimea[ukkelit[i].Etunimi]++;
                        }
                        else
                        {
                            montaNimea.Add(ukkelit[i].Etunimi, 1);
                        }
                    }

                    foreach (KeyValuePair<string, int> key in montaNimea)
                    {
                        Console.WriteLine(key.Key + " " + key.Value);
                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}