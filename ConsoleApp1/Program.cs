int liczba = Convert.ToInt32(Console.ReadLine());
if (liczba % 2 == 0)
{
    Console.WriteLine("jest parzysta");
}
else
{
    Console.WriteLine("nie jest parzysta");
}
for (int i = 0; i < liczba; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

static void Imie()
{
    string imie = "pavlo";
    Console.WriteLine(imie);
}
static void Nazwisko()
{
    string nazwisko = "mysiuk";
    Console.WriteLine(nazwisko);
}
static void Age()
{
    int age = 18;
    Console.WriteLine(age);
}
while (true)
{
    Console.WriteLine("menu użytkownika");
    Console.WriteLine("opcja 1");
    Console.WriteLine("opcja 2");
    Console.WriteLine("opcja 3");
    Console.WriteLine("wypierz opcje:");
    int wybierz = Convert.ToInt32(Console.ReadLine());
    if (wybierz == 1)
    {
        Imie();
    }
    if (wybierz == 2)
    {
        Nazwisko();
    }
    if (wybierz == 3)
    {
        Age();
    }
    if (wybierz == 0)
    {
        break;
    }

}
static int silnia(int x)
{
    if (x == 0)
    {
        return 1;
    }
    else
    {
        return silnia(x - 1) * x;
    }
}

