using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2_3.lab4.zadanie2.models;

namespace lab2_3.lab4.zadanie2
{
       class Program
        {
            static void Main(string[] args)
            {
               
                Uczen uczen1 = new Uczen { Imie = "Jan", Nazwisko = "Kowalski", Pesel = "44051401359" };
                uczen1.UstawSzkole("Szkoła Podstawowa Nr 1");
                uczen1.UstawCzyMozeSamWrocic(true);

                Uczen uczen2 = new Uczen { Imie = "Anna", Nazwisko = "Nowak", Pesel = "52080411567" };
                uczen2.UstawSzkole("Szkoła Podstawowa Nr 2");
                uczen2.UstawCzyMozeSamWrocic(false);

                
                Nauczyciel nauczyciel = new Nauczyciel { Imie = "Piotr", Nazwisko = "Kaczmarek", TytulNaukowy = "mgr" };

              
                nauczyciel.DodajUcznia(uczen1);
                nauczyciel.DodajUcznia(uczen2);

                
                nauczyciel.PodsumowanieKlasy(DateTime.Now);

               
                var uczniowieSamodzielni = nauczyciel.KtorzyUczniowieMogaWrocicSamodzielnie();
                Console.WriteLine("\nUczniowie, którzy mogą wrócić samodzielnie:");
                foreach (var ucz in uczniowieSamodzielni)
                {
                    Console.WriteLine(ucz);
                }
            }
        }
    }
