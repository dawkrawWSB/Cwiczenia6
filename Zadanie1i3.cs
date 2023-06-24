//Zadanie 1 polaczone z zadaniem 3.
namespace Cwiczenia6
{
    internal class Zadanie1i3
    {
        public Zadanie1i3()
        {
            int wielkoscBoku = Pomocnik.DostanLiczbe<int>("Wielkosc boku:", int.MaxValue, 1);
            int[,] tablica = new int[wielkoscBoku, wielkoscBoku];
            int nastepnaLiczba = 1;
            for (int i = 0; i < wielkoscBoku; i++)
            {
                if(i % 2 == 1)
                {
                    for (int j = wielkoscBoku - 1; j >= 0; j--)
                    {
                        tablica[i, j] = nastepnaLiczba;
                        nastepnaLiczba++;
                    }
                }
                else
                {
                    for (int j = 0; j < wielkoscBoku; j++)
                    {
                        tablica[i, j] = nastepnaLiczba;
                        nastepnaLiczba++;
                    }
                }
            }

            for(int i = 0; i < wielkoscBoku; i++)
            {
                for(int j = 0;j < wielkoscBoku; j++)
                {
                    Console.Write("{0,3} ", tablica[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
