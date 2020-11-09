
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA201109
{
    class Program
    {
        static void Main(string[] args)
        {
            //F15(Beker());
            //F16(Beker());
            //F17(Beker(), Beker());
            //for (int i = 0; i < 10; i++) F18();
            //F20(Beker());
            //F21(Beker());
            //F22(Beker());
            Console.ReadKey();
        }

        private static void F22(string szo)
        {
            Console.CursorVisible = false;
            Console.Clear();
            for (int i = 0; i < szo.Length; i++)
            {
                Console.Write(szo[i]);
                Thread.Sleep(500);
                Console.Clear();
                Thread.Sleep(100);
            }
            Console.CursorVisible = true;
        }

        private static void F21(string szoveg)
        {
            var dic = new Dictionary<char, int>();
            foreach (var c in szoveg)
            {
                if (!dic.ContainsKey(c))
                    dic.Add(c, 1);
                else dic[c]++;
            }
            foreach (var kvp in dic)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} db");
            }
        }

        private static void F20(string ir)
        {
            Console.WriteLine($"ez az irányítószám a {ir.Substring(1, 2)} kerületé");
        }

        static Random rnd = new Random();
        private static void F18()
        {
            var karakterek = "abcdefgh1234567890_";
            string jelszo = "";
            for (int i = 0; i < 8; i++)
            {
                jelszo += karakterek[rnd.Next(karakterek.Length)];
            }
            Console.WriteLine(jelszo);

        }

        private static void F17(string elso, string masodik)
        {

            var et = elso.ToLower().ToCharArray();
            var mt = masodik.ToLower().ToCharArray();
            Array.Sort(et);
            Array.Sort(mt);
            Console.WriteLine((new string(et) == new string(mt)) ? "anagramma" : "nem anagramma");
        }

        private static void F16(string szoveg)
        {
            var ct = szoveg.ToLower().ToCharArray();
            Array.Sort(ct);
            Console.WriteLine(new string(ct));
        }

        private static string Beker()
        {
            Console.Write("Írj be egy szöveget: ");
            return Console.ReadLine();
        }
        private static void F15(string szoveg)
        {
            Console.WriteLine(szoveg.Replace(' ', '\n'));
        }
    }
}
