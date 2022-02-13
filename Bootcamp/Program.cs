using System;
using Bootcamp.src.Entities;

namespace Bootcamp;

    public class Program
    {
        static void Main (string[] args)
        {
            Knight Arus = new Knight ("Arus", 42, "Knight", 749, 72);
            Ninja Wedge = new Ninja ("Wedge", 42, "Ninja", 574, 89);
            WhiteWizard Jenica = new WhiteWizard ("Jenica", 42, "White Wizard", 601, 482);
            BlackWizard Topapa = new BlackWizard ("Topapa", 42, "Black Wizard", 385, 641);

            Console.WriteLine(Arus);
            Console.WriteLine(Wedge);
            Console.WriteLine(Jenica);
            Console.WriteLine(Topapa);
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Wedge.Attack());
            Console.WriteLine(Jenica.Attack());
            Console.WriteLine(Topapa.Attack());
        }
    }

