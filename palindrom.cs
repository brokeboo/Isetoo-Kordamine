using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isetoo_Kordamine
{
    class palindrom
    {
 /*       static void Main(string[] args)
        {
            Console.WriteLine("Sisestage tekst: ");
            string str = Console.ReadLine();
            char[] symbol = { ' ', ',', '.', '!', '?' };
            for (; ; )
            {
                int offset = str.IndexOfAny(symbol);
                if (offset == -1) break;
                string st1 = str.Substring(0, offset);
                string st2 = str.Substring(offset + 1);
                str = string.Concat(st1, st2);
            }
            Char[] s = str.ToCharArray();
            Char[] s1 = new char[str.Length];
            int index = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                s1[i] = s[index--];
            }
            string str1 = new string(s);
            string str2 = new string(s1);
            if (string.Compare(str1, str2, true) == 0)
            {
                Console.Write("String - palindroom");
            }
            else Console.Write("String ei ole palindroom");
            Console.ReadLine();
        }
    }
}*/