using System;

namespace vaja2 {
    class Program {
        static void Main (string[] args) {
            // prvo število
            System.Console.WriteLine ("Vnesi stranico a: ");
            string odgovor = Console.ReadLine ();
            int a = int.Parse (odgovor);
            // drugo število
            Console.WriteLine ("Vnesi stranico b: ");
            odgovor = Console.ReadLine ();
            int b = int.Parse (odgovor);
            // tretje število
            Console.WriteLine ("Vnesi stranico c: ");
            odgovor = Console.ReadLine ();
            int c = int.Parse (odgovor);

            if (a + b > 6 && a + c > b & b + c > a) {
                System.Console.WriteLine ("So stranice trikotnika");
            } else {
                System.Console.WriteLine ("Niso stranice trikotnika");
            }
        }
    }
}