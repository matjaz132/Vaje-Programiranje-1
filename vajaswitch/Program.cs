using System;

namespace vajaswitch {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Vnesi:");
            string odgovor;
            odgovor = Console.ReadLine();
            int x = int.Parse (odgovor);
            switch (x) {
                case 1:
                    System.Console.WriteLine ("enka");
                    break;
                case 2:
                    System.Console.WriteLine ("dvojka");
                    break;
                default:
                    System.Console.WriteLine ("error");
                    break;
            }
            System.Console.WriteLine("konc");
        }
    }
}