using System;

namespace Kolko_I_Krzyzyk_lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string imieGraczaA = "";
            string imieGraczaB = "";
            char znakGraczaA = 'x';
            char znakGraczaB = 'o';

            int[] tablica1D = new int[4] { 5, 10, 15, 100 };

            char[,] plansza = new char[3, 3] {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            Console.Write("Wpisz imie gracza A: ");
            imieGraczaA = Console.ReadLine();
            Console.Write("Wpisz imie gracza B: ");
            imieGraczaB = Console.ReadLine();

            // ...

            Console.ReadKey();  // nacisnij dowolny klawisz zeby zakonczyc
        }
    }
}
