using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3.lab4.zadanie2.models
{
    public class Nauczyciel : Osoba
    {
        public string TytulNaukowy { get; set; }
        public List<Uczen> UczniowieKlasy { get; set; }

        public Nauczyciel()
        {
            UczniowieKlasy = new List<Uczen>();
        }

        public void DodajUcznia(Uczen uczen)
        {
            UczniowieKlasy.Add(uczen);
        }

        public List<string> KtorzyUczniowieMogaWrocicSamodzielnie()
        {
            List<string> uczniowie = new List<string>();

            foreach (var uczen in UczniowieKlasy)
            {
                if (uczen.CzyMozeSamWrocicDoDomu())
                {
                    uczniowie.Add($"{uczen.Imie} {uczen.Nazwisko} - {uczen.PobierzPlec()}");
                }
            }

            return uczniowie;
        }

        public void PodsumowanieKlasy(DateTime data)
        {
            Console.WriteLine($"Dnia: {data.ToShortDateString()}");
            Console.WriteLine($"Nauczyciel: {TytulNaukowy} {Imie} {Nazwisko}");
            Console.WriteLine("Lista studentów:");

            foreach (var uczen in UczniowieKlasy)
            {
                string verdict = uczen.CzyMozeSamWrocicDoDomu() ? "Może wrócić" : "Nie może wrócić";
                string reasoning = uczen.PobierzWiek() >= 12 ? "Wiek pozwala" : "Brak zgody rodziców";
                Console.WriteLine($"{uczen.Imie} {uczen.Nazwisko} - {uczen.PobierzPlec()} - {verdict} - {reasoning}");
            }
        }
    }
}
