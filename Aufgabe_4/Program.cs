﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl eingeben");
            string eingabe = Console.ReadLine();
            int zahl = Convert.ToInt32(eingabe);


            {
                switch (zahl)
                {
                    case 1:
                        Console.WriteLine("Monat:Januar");
                        break;
                    case 2:
                        Console.WriteLine("Monat:Ferbuar");
                        break;
                    case 3:
                        Console.WriteLine("Monat:März");
                        break;
                    case 4:
                        Console.WriteLine("Monat:April");
                        ; break;
                    case 5:
                        Console.WriteLine("Monat:Mai");
                        break;
                    case 6:
                        Console.WriteLine("Monat:Juni") 
                            ; break;
                    case 7:
                        Console.WriteLine("Monat:Juli");
                        break;
                    case 8:
                        Console.WriteLine("Monat:August");
                        break; 
                    case 9:
                        Console.WriteLine("Monat:September");
                        break;
                    case 10:
                        Console.WriteLine("Monat:Oktober");
                        break;
                    case 11:
                        Console.WriteLine("Monat:Novemeber"); 
                        break;
                    case 12:
                        Console.WriteLine("Monat:Dezember");
                        break;

                } Console.ReadKey(); 
                }



            }

        } 
    }