using System;

namespace KalkulatorOcenV1 {
    class Program {
        static void Main (string[] args) {
            const double PDELNI1 = 0.25;
            const double PDELNI2 = 0.25;
            const double PSEMINAR = 0.3;
            const double PUSTNA = 0.2;

            int delni1 = 70;
            int delni2 = 80;
            int seminar = 90;
            int ustna = 100;

            double končnaOcena = PDELNI1 * delni1 + PDELNI2 * delni2 + PSEMINAR * seminar + PUSTNA * ustna;

            Console.WriteLine ("Delni 1 " + delni1);
            Console.WriteLine ("Delni 2 " + delni2);
            Console.WriteLine ("Seminar " + seminar);
            Console.WriteLine ("Ustna " + ustna);
            Console.WriteLine ("Izračunana ocena " + končnaOcena);

        }
    }
}