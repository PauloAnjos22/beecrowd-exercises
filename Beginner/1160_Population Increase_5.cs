using System;
using System.Globalization;

class Program
{
    static void calculatePopulationIncrease(string[] data)
    {
        int PA = int.Parse(data[0]);
        int PB = int.Parse(data[1]);
        double GA = double.Parse(data[2]);
        double GB = double.Parse(data[3]);
        int years = 0;

        while ((PA <= PB) && (years <= 100))
        {
            double increasePA = PA * (1 + (GA / 100));
            PA = (int)Math.Floor(increasePA);

            double increasePB = PB * (1 + (GB / 100));
            PB = (int)Math.Floor(increasePB);
            years++;
        }
        if (years > 100)
            Console.WriteLine("Mais de 1 seculo.");
        else
            Console.WriteLine(years + " anos.");
    }

    public static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine());
        string[] data;
        for (int i = 0; i < testCase; i++)
        {
            data = Console.ReadLine().Split(' ');
            calculatePopulationIncrease(data);
        }
    }
}