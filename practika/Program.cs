using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practika
{
    public class Lib1
    {
        public string stpow(string a, int b)
        {
            string result = "";

            for (int i = 0; i < b; i++)
            {
                result += a;
            }
            return result;
        }

        public string rev(string a)
        {
            string result = "";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                result += a[i];
            }
            return result;
        }

        public string remov(string str, string s)
        {
            return str.Replace(s, "");
        }

        public int leng(string str)
        {
            return str.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Lib1 g = new Lib1();

            Console.WriteLine(g.stpow("ha", 4));
            Console.WriteLine(g.rev("I love c#!!"));
            Console.WriteLine(g.remov("aaaabccdadataa", "a"));
            Console.WriteLine(g.leng("vexus"));
        }
    }
}
