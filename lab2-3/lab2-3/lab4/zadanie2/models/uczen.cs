using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3.lab4.zadanie2.models
{
    public class Uczen : Osoba
    {
        public string Szkola { get; set; }
        public bool MozeSamWrocicDoDomu { get; set; }

        public void UstawSzkole(string szkola) => Szkola = szkola;
        public void ZmienSzkole(string szkola) => Szkola = szkola;
        public void UstawCzyMozeSamWrocic(bool mozeSamWrocic) => MozeSamWrocicDoDomu = mozeSamWrocic;

        public bool Informacja()
        {
            return PobierzWiek() >= 12 || MozeSamWrocicDoDomu;
        }

        public override string PobierzInformacjeOEdukacji() => $"Uczeń w szkole: {Szkola}";

        public override bool CzyMozeSamWrocicDoDomu()
        {
            return PobierzWiek() >= 12 || MozeSamWrocicDoDomu;
        }
    }
}
