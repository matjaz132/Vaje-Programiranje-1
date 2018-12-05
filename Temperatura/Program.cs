using System;

namespace Temperatura {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Vnesi temperaturo: ");
            int temperatura = Console.ReadLine ();
            if (temperatura < 5 || temperatura > 100) {
                System.Console.WriteLine ("Error: Temperatura prevečja/premajhna");
            }
            if (temperatura <= 10) {
                
            }
        }
    }
}