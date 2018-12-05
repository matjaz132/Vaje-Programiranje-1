using System;

namespace nastevnitip {
    enum Planeti { Merkur, Venera, Zemlja, Mars, Jupiter, Saturn, Uran, Neptun, Pluton }
    enum PeriodaPlanetov { Merkur = 88, Venera = 225, Zemlja = 365, Mars = 687, Jupiter, Saurn, Uran, Neptun, Pluton }
    class Program {
        static void Main (string[] args) {
            Planeti p = Planeti.Zemlja;
            int pozicija = (int) p;
            Console.WriteLine (p + " je po oddaljenosti od Sonca " + pozicija);

            pozicija = 5;
            p = (Planeti) pozicija;
            Console.WriteLine (pozicija + " po vrsti je " + p);

            PeriodaPlanetov zemlja = PeriodaPlanetov.Zemlja;
            int obhodniČas = (int) zemlja;
            Console.WriteLine ("Obhodni čas Zemlje je " + obhodniČas);

        }
    }
}