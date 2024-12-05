//using lab2_3.Lab2_3;


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class Program
//{
//    static void Main(string[] args)
//    {
//        //Licz licz = new Licz(10); 
//        //licz.WypiszStan();        

//        //licz.Dodaj(5);             
//        //licz.WypiszStan();        

//        //licz.Odejmij(3);           
//        //licz.WypiszStan();

//        //Osoba osoba = new Osoba("Jan", "Kowalski", 25, "12345678901");


//        //Console.WriteLine(osoba.Przdestawsie());

//        //osoba.Wiek = -5;
//        //Console.WriteLine(osoba.Przdestawsie()); 

//        //osoba.Imie = "Anna";
//        //osoba.Nazwisko = "Nowak";
//        //Console.WriteLine(osoba.Przdestawsie());  
//        int[] liczby = { 1, 2, 3, 4, 5, 6, 9, 12 };
//        Summator sumator = new Summator(liczby);

//        Console.WriteLine("Suma wszystkich liczb: " + sumator.Sum());
//        Console.WriteLine("Suma liczb podzielnych przez 3: " + sumator.SumPod3());
//        Console.WriteLine("Liczba elementów: " + sumator.Count());
//        Console.WriteLine("Elementy tablicy: ");
//    }

//}
using lab2_3.lab5.zad1;
using lab2_3.lab5.zad2;

Shape shape = new Square() { X = 5 };
Shape shape1 = new Square() { X = 154 };
Shape circle = new Circle() { Radius = 12 };

Console.WriteLine(shape.CalculateArea());
Console.WriteLine(shape1.CalculateArea());
Console.WriteLine(circle.CalculateArea());

IVehicle car = new Car();

try
{

    car.Start();

    car.Stop();
}
catch (NotImplementedException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
