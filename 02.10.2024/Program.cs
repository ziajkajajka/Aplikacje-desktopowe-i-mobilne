using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zad 1");
        Console.WriteLine("Podaj liczbe x");
        int x =
        Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj liczbe y");
        int y
            = Convert.ToInt32(Console.ReadLine());
        if (x > 0 && y > 0)
        {
            Console.WriteLine("To jest ćwiartka 1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("To jest ćwiartka 2");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("To jest ćwiartka 3");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("To jest ćwiartka 4");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("Nie ma ćwiartki");
        }
        Console.WriteLine("Zad 2");
        Console.WriteLine("Podaj a");
        int a = 
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj b");
        int b = 
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj c");
        int c =
            Convert.ToInt32(Console.ReadLine());
        if (a + b > c && a + b > c && b + c > a)
        {
            Console.WriteLine("Pole wynosi");
            Console.WriteLine(0.25 * (Math.Sqrt(4 * a * a * b * b - (a * a + b * b - c * c) * (a * a + b * b - c * c))));
        }
        else if (a + b < c)
        {
            Console.WriteLine("Nie ma takiego trójkąta");
        }
        Console.WriteLine("Obwód wynosi");
        Console.WriteLine(a + b + c);

        Console.WriteLine("Zad 4");
        Console.WriteLine("Podaj 1 liczbe");
        int pl = 
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj 2 liczbe");
        int dl =
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wybierz działanie które chcesz wykonać");
        Console.WriteLine("1-dodawanie");
        Console.WriteLine("2-odejmowanie");
        Console.WriteLine("3-mnożenie");
        Console.WriteLine("4-dzielenie");
        int znak = 
            Convert.ToInt32(Console.ReadLine());

        if (znak == 1)
        {
            Console.WriteLine(pl + dl);
        }
        else if (znak == 2)
        {
            Console.WriteLine(pl - dl);
        }
        else if (znak == 3)
        {
            Console.WriteLine(pl * dl);
        }
        else if (znak == 4)
        {
            Console.WriteLine(pl / dl);
        }
        else
        {
            Console.WriteLine("Twoja liczba nie jest od 1 do 4");
        }
        Console.WriteLine("Wynik to: ");

        Console.WriteLine("Podaj 1 liczbe");
        int tt =
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj 2 liczbe");
        int rt =
            Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wybierz działanie które chcesz wykonać");
        Console.WriteLine("1-dodawanie");
        Console.WriteLine("2-odejmowanie");
        Console.WriteLine("3-mnożenie");
        Console.WriteLine("4-dzielenie");
        int znak2 =
            Convert.ToInt32(Console.ReadLine());
        switch (znak2)
        {
            case 1:
                Console.WriteLine(tt + rt);
                break;
            case 2:
                Console.WriteLine(tt - rt);
                break;
            case 3:
                Console.WriteLine(tt * rt);
                break;
            case 4:
                Console.WriteLine(tt / rt);
                break;
        }
        Console.WriteLine("Wynik to: ");




    }
}
