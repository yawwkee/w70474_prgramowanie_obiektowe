using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3.lab4.zadanie2.models
{
    public abstract class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }

        public void UstawImie(string imie) => Imie = imie;
        public void UstawNazwisko(string nazwisko) => Nazwisko = nazwisko;
        public void UstawPesel(string pesel) => Pesel = pesel;

        public int PobierzWiek()
        {
            
            var year = int.Parse(Pesel.Substring(0, 2));
            var month = int.Parse(Pesel.Substring(2, 2));
            var day = int.Parse(Pesel.Substring(4, 2));

            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;

            int age = currentYear - (1900 + year);
            if (currentMonth < month || (currentMonth == month && currentDay < day))
                age--;

            return age;
        }

        public string PobierzPlec()
        {
            
            int plecDigit = int.Parse(Pesel.Substring(9, 1));
            return plecDigit % 2 == 0 ? "Kobieta" : "Mężczyzna";
        }

       
        public virtual string PobierzInformacjeOEdukacji() => "Brak informacji o edukacji";
        public virtual string PobierzPelneImieNazwisko() => $"{Imie} {Nazwisko}";
        public virtual bool CzyMozeSamWrocicDoDomu() => false;  
    }
}
