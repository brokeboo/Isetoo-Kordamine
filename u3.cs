using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isetoo_Kordamine
{
    class u3
    {
        public static void Main(string[] args)
        {
            int arv;
            int[] arvud = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Sisesta {0} arv:", i + 1);
                arv = int.Parse(Console.ReadLine());
                arvud[i] = arv;
            }
            Array.Sort(arvud);
            foreach (var a in arvud)
            {
                Console.Write(a);
            }
            int arv4 = 0;
            Array.Reverse(arvud);
            foreach (var a in arvud)
            {
                arv4 = arv4 * 10 + a;

            }
            Console.Write(arv4);
            Console.ReadLine();
        }
        
    }
}
