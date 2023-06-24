//Zadanie 2 polaczone z zadaniem 3.
namespace Cwiczenia6
{
    internal class Zadanie2i3
    {
        public Zadanie2i3()
        {
            int wielkoscBoku = Pomocnik.DostanLiczbe<int>("Wielkosc boku:", int.MaxValue, 1);
            int[,] tablica = new int[wielkoscBoku, wielkoscBoku];

            int wiersz = 0;
            int kolumna = 0;
            Kierunek kierunek = Kierunek.Prawo;
            for (int i = 1; i <= wielkoscBoku*wielkoscBoku; i++)
            {
                tablica[wiersz, kolumna] = i;
                switch(kierunek)
                {
                    case Kierunek.Prawo:
                        if(kolumna + 1 >= wielkoscBoku || tablica[wiersz, kolumna + 1] != 0)
                        {
                            kierunek = Kierunek.Dol;
                            wiersz++;
                            break;
                        }
                        kolumna++;
                        break;
                    case Kierunek.Dol:
                        if (wiersz + 1 >= wielkoscBoku || tablica[wiersz +1, kolumna] != 0)
                        {
                            kierunek = Kierunek.Lewo;
                            kolumna--;
                            break;
                        }
                        wiersz++;
                        break;
                    case Kierunek.Lewo:
                        if (kolumna - 1 < 0 || tablica[wiersz, kolumna - 1] != 0)
                        {
                            kierunek = Kierunek.Gora;
                            wiersz--;
                            break;
                        }
                        kolumna--;
                        break;
                    case Kierunek.Gora:
                        if (tablica[wiersz - 1, kolumna] != 0)
                        {
                            kierunek = Kierunek.Prawo;
                            kolumna++;
                            break;
                        }
                        wiersz--;
                        break;
                }
            }
            for (int i = 0; i < wielkoscBoku; i++)
            {
                for (int j = 0; j < wielkoscBoku; j++)
                {
                    Console.Write("{0,3} ", tablica[i, j]);
                }
                Console.WriteLine();
            }
        }

        enum Kierunek
        {
            Prawo = 0,
            Dol = 1,
            Lewo = 2,
            Gora = 3
        }
    }
}
