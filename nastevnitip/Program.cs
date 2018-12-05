using System;

namespace nastevnitip
{
    enum Planeti
    {Merkur, Venera, Zemlja, Mars, Jupiter, Saturn, Uran, Neptun, Pluton}
    class Program
    {
        static void Main(string[] args)
        {
            Planeti p = Planeti.Zemlja;
            int pozicija = (int)p;
            Console.WriteLine(p+" je po oddaljenosti od Sonca " + pozicija);

            pozicija = 5;
            p = (Planeti) pozicija;
            Console.WriteLine(pozicija + " po vrsti je " + p);
        }
    }
}
