using System;

namespace vajaostanki {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Vnesi število");
            string odgovor;
            odgovor = Console.ReadLine ();
            int x = int.Parse (odgovor);
            if (x % 2 == 0) {
                System.Console.WriteLine ("sodo");
            } else {
                System.Console.WriteLine ("liho");
            }
        }
    }
}