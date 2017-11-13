using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int milliseconds = 3000;

            Kat Jasper = new Kat();
            Muis Thomas = new Muis();
            Console.WriteLine(Thomas.ToString());
            System.Threading.Thread.Sleep(milliseconds);
            Console.WriteLine("Daar komt tie! Ga weg!");
            System.Threading.Thread.Sleep(milliseconds);
            Console.WriteLine("Te laat!");
            Jasper.Vang(Thomas);

            Console.WriteLine(Thomas.ToString());

        }
    }
}
