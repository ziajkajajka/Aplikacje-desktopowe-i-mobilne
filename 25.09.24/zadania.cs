using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Zad 1");
        Console.WriteLine("Witaj świecie");

        Console.WriteLine("Zad 2");
        string imie = Console.ReadLine();
        Console.WriteLine("Cześć " + imie);

        Console.WriteLine("Zad 3");
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        var x = Convert.ToDouble(a);
        var y = Convert.ToDouble(b);
        var c = Convert.ToInt32(x);
        var d = Convert.ToInt32(y);
        Console.WriteLine("Wynik to " + (c + d));

        Console.WriteLine("Zad 4");
        Console.WriteLine("podaj promień koła");
        var pk = Console.ReadLine();
        double p = Convert.ToDouble(pk);
        Console.WriteLine("Promien kola wynosi " + (3, 14 * p * p));

        Console.WriteLine("Zad 5");
        Console.WriteLine("Podaj temperature w stopniach celcjusza ");
        string tc = Console.ReadLine();
        double tf =  Convert.ToDouble(tc);
        Console.WriteLine("Temperatura w stopniach Fahrenheita wynosi " + (tf * 9 / 5 )+ 32);

        Console.WriteLine("Zad 6");
        int liczba3 = int.Parse(Console.ReadLine());
        string liczba4 = Convert.ToString(liczba3);
        Console.WriteLine( liczba4 );

        Console.WriteLine("Zad 7");
        Console.WriteLine("Podaj liczby ");
        double liczba1 = int.Parse(Console.ReadLine());
        double liczba2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ich średnia to ");
        Console.WriteLine((liczba1 + liczba2) / 2);

        Console.WriteLine("Zad 8");
        Console.WriteLine("Podaj liczbe ");
        double liczba5 = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Pow (liczba5, 2));

        Console.WriteLine("Zad 9");
        float liczba6 = float.Parse(Console.ReadLine());
        int liczba7 = Convert.ToInt32(liczba6);
        Console.WriteLine(liczba7 );

    }
}