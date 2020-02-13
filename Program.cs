using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchVezba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("upisite broj vasih godina");
            int brojGodina = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Upisite vase ime");
            string mojeIme = Console.ReadLine();

            Console.WriteLine("Unesite vasu platu");
            double mojaPlata = double.Parse(Console.ReadLine());

            Console.WriteLine("unesite bracni status: ozenjen, neozenjen, razveden, udovac");
            string bracniStatus = Console.ReadLine();

            switch(bracniStatus)
            {
                case "ozenjen":
                    Console.WriteLine("Moguce da ima a moguce i da nema dece");
                    break;

                case "neozenjen":
                    Console.WriteLine("Nema dece");
                    break;

                case "razveden":
                    Console.WriteLine("ima dece");
                    break;

                case "udovac":
                    Console.WriteLine("ima dece");
                    break;

                default:
                    Console.WriteLine("Stanje nepoznato");
                    break;
            }
            Console.ReadLine();

        }
    }
}
