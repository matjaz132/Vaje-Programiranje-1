using System;

namespace vajaIf {
    class Program {
        static void Main (string[] args) {
            // vnosni poziv - input prompt
            System.Console.WriteLine ("Kateri je tvoj najljubši programski jezik?");
            string odgovor = Console.ReadLine ();
            if (odgovor == "C#" || odgovor == "c$") {
                System.Console.WriteLine ("C# je res najboljši");
            } else {
                System.Console.WriteLine(odgovor + " je tudi dober jezik");
            }
        }
    }
}