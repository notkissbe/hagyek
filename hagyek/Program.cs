using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hagyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok f1 = new Feladatok();
            f1.Beolvasas();
            Console.WriteLine(f1.Megszamlal());
            Console.WriteLine(f1.Legmagasabb());


            Console.WriteLine("6.Feladat: Kérem a magasságot: ");
            int magassag = int.Parse(Console.ReadLine());
            f1.Feladat6(magassag);
            Console.WriteLine("Ennyi 3000 lábnál magasabb van: "+f1.Magasabb3000Labnal());



            Console.ReadKey();
        }
    }
}
