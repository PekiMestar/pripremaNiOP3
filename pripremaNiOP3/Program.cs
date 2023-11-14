using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaNiOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj;

            Console.WriteLine("Unesite neki broj: ");
            broj = int.Parse(Console.ReadLine());

            for (int i = 0; i < broj; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.WriteLine(j);
                }

                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
