using System;

namespace Gostilne {
    class Program {
        static void Main (string[] args) {

            DateTime danes;
            danes = DateTime.Now;

            if (danes.DayOfWeek == DayOfWeek.Monday) {
                System.Console.WriteLine ("Jej pri Bricu");

            }
            if (danes.DayOfWeek == DayOfWeek.Tuesday) {
                System.Console.WriteLine ("Jej pri Kenu");

            }
            if (danes.DayOfWeek == DayOfWeek.Tuesday) {
                System.Console.WriteLine ("Jej pri Metki");

            }
            if (danes.DayOfWeek == DayOfWeek.Tuesday) {
                System.Console.WriteLine ("Jej pri Francu");

            }
            if (danes.DayOfWeek == DayOfWeek.Tuesday) {
                System.Console.WriteLine ("Jej pri Tonetu");

            }
            if (danes.DayOfWeek == DayOfWeek.Tuesday) {
                System.Console.WriteLine ("Jej pri Matjanu");

            }
            if (danes.DayOfWeek == DayOfWeek.Tuesday) {
                System.Console.WriteLine ("Jej pri Janezu");

            }
        }
    }
}