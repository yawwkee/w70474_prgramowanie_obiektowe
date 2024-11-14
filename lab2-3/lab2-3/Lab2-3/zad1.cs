using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab2_3.Lab2_3
{
//    class Osoba
//    {
//        private string imie;
//        private string nazwisko;
//        private int wiek;
//        private string pesel;
//        public Osoba(string imie, string nazwisko, int wiek, string pesel)
//        {
//            this.imie = imie;
//            this.nazwisko = nazwisko;
//            this.wiek = wiek;
//            this.pesel = pesel;
//        }
//        public string Imie
//        {
//            get { return imie; }
//            set { imie = value; }
//        }
//        public string Nazwisko
//        {
//            get { return nazwisko; }
//            set { nazwisko = value; }
//        }
//        public int Wiek
//        {
//            get { return wiek; }
//            set { wiek = value >= 0 ? value : 0; }
//        }
//        public string Pesel
//        {
//            get { return pesel; }

//        }
//        public string Przdestawsie()
//        {
//            return $"Nazywam się {imie} {nazwisko} i mam {wiek} lat";
//        }
//    }

    //class Licz
    //{
       
    //    private int wartość;

    //    public Licz(int wartość)
    //    {
    //        this.wartość = wartość;
    //    }

    //    public void Dodaj(int liczba)
    //    {
    //        this.wartość += liczba;
    //    }

    //    public void Odejmij(int liczba)
    //    {
    //        this.wartość -= liczba;
    //    }


    //    public void WypiszStan()
    //    {
    //        Console.WriteLine("Aktualna wartość: " + this.wartość);
    //    }

    //}
    class Summator
    {
        private int[] Liczby;
        public Summator(int[] Liczby) 
        {
            this.Liczby = Liczby;
        }
        public int  Sum()
        {
            return Liczby.Sum();
        }
        public int SumPod3()
        {
            return Liczby.Sum(x => x / 3);
        }
        public int Count()
        {
            return Liczby.Count();

        }

    }
}