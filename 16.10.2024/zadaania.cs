using System;
using System.ComponentModel.Design;
public class Program
{
    public static void Main(string[] args)
    {
    Console.WriteLine("Zad 1");
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i + " ");
        }

        Console.WriteLine(" ");
        Console.WriteLine("Zad2");
        for (int i =100; i >=50; --i)
        {
            Console.WriteLine(i + " ");
        }

        Console.WriteLine(" ");
        Console.WriteLine("Zad3");
        Console.WriteLine("Podaj liczbe");
        int y = 0;
        int a = 0;
        for (; ; a++)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                break;
            }
            else
            {
                y += x;
            }
        }
        Console.WriteLine("Suma liczb: " + y);
        Console.WriteLine("Ilosc liczb: " + a);

    }
}
