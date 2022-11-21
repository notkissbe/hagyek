using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hagyek
{
    internal class Feladatok
    {
        private List<Hegy> lista;

        public Feladatok()
        {
            lista = new List<Hegy>();
        }
        public void Beolvasas()
        {
            StreamReader sr = new StreamReader("hegyekMo.txt");
            sr.ReadLine();
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string [] parts = line.Split(';');
                Hegy uj = new Hegy(parts[0], parts[1], Convert.ToInt32(parts[2]));
                lista.Add(uj);
            }
            sr.Close();
        }

        public int Megszamlal()
        {
            return lista.Count;
        }

        public int Atlagmagassag()
        {
            int magassag = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                magassag += lista[i].Magassag;
            };
            return magassag / lista.Count;
            
        }
        public Hegy Legmagasabb()
        {
            int legmagasabbindex = 0;
            int legmagasabb = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Magassag > legmagasabb)
                {
                    legmagasabb = lista[i].Magassag;
                    legmagasabbindex = i;
                }
            }
            return lista[legmagasabbindex];
        }
        public void Feladat6(int bekertMagassag)
        {
            //dowhile
            int i = 0;
            bool megvan= lista[i].Magassag <= bekertMagassag && lista[i].Hegyseg == "Börzsöny";
            while(i<lista.Count && !megvan)
            {
                i++;
                if (i<lista.Count)
                {
                    megvan = lista[i].Hegyseg == "Börzsöny" && lista[i].Magassag > bekertMagassag;
                }
            }
            if (i<lista.Count)
            {
                Console.WriteLine("Van magasabb");
            }
            else
            {
                Console.WriteLine("Nincs magasabb.");
            }
        }

       public int Magasabb3000Labnal()
        {
            int db = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].MagassagLabban>3000)
                {
                    db++;
                }
            }
            return db;
        }

        //Hashset, dictionary, do while <- új anyag

        public int HegyCsucsokSzama()
        {
            HashSet<string> halmaz = new HashSet<string>;
            return 0;
        }
        public void f8_2()
        {
            Dictionary<string, int> szatisztika
        }



    }
}
