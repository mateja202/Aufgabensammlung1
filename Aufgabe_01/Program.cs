using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Schreibe mir eine Zahl: ");
            string eingabe1 = Console.ReadLine();
            int zahl1 = Convert.ToInt32(eingabe1);

            Console.Write("Schriebe mir eine zweite Zahl: ");
            string eingabe2 = Console.ReadLine();
            int zahl2 = Convert.ToInt32(eingabe1);
            int berechnung = zahl1 + zahl2;

            
            Console.WriteLine("Zahl 1: " + zahl1);
            Console.WriteLine("Zahl 2: " + zahl2);
            Console.WriteLine("Summe: " + berechnung);
            Console.ReadKey();





        }
    }
}
