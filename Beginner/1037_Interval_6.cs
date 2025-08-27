using System;

class Program
{
    public static void Main(string[] args)
    {
        var value = double.Parse(Console.ReadLine());
        if (value > 100 || value < 0)
            Console.WriteLine("Fora de intervalo");
        else if (value <= 25)
            Console.WriteLine("Intervalo [0,25]");
        else if (value <= 50)
            Console.WriteLine("Intervalo (25,50]");
        else if (value <= 75)
            Console.WriteLine("Intervalo (50,75]");
        else if (value <= 100)
            Console.WriteLine("Intervalo (75,100]");
    }
}