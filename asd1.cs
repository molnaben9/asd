using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            kiiras("B");
            Console.WriteLine(terulet(2,3));
            kiiras(Convert.ToString(terulet(2, 3)));
            Program2.kiir2();
            
            Program2.kiir3();
            int a = 1;
            a = 2;
        }

        static void kiiras(string nev)
        {
            Console.WriteLine("SZia, {0}", nev);
        }

        static int terulet(int a, int b)
        {
            return a + b;
        }
    }

    class Program2
    {
        public static void kiir2()
        {
            Console.WriteLine("Ez egy másik!");
        }

        static void kiir3()
        {
            Console.WriteLine("Ez a 3.");
        }

        private void kiir4()
        {
            Console.WriteLine("Ez a 4.");
        }
    }
}

