using System;

namespace Temperatura {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Vnesi temperaturo: ");
            int temperatura = Convert.ToInt32 (Console.ReadLine ());
            if (temperatura < 5 || temperatura > 100) {
                System.Console.WriteLine ("Error: Temperatura prevečja/premajhna");
            } else {
                if (temperatura <= 10) {
                    System.Console.WriteLine ("Super mrzla!");
                }
                if (temperatura > 10 && temperatura <= 70) {
                    System.Console.WriteLine ("V redu.");
                }
                if (temperatura > 70) {
                    System.Console.WriteLine ("Super topla!");
                }
            }
        }
    }
}