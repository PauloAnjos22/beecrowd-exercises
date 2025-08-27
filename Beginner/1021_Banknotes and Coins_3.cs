using System;
using System.Globalization;

class Program
{
    static int getDecompositionNotes(int value, int[] arrayNotes)
    {
        Console.WriteLine("NOTAS:");
        foreach (int note in arrayNotes)
        {
            if (value >= note)
            {
                int count = value / note;
                Console.WriteLine($"{count} nota(s) de R$ {note.ToString("F2", CultureInfo.InvariantCulture)}");
                value %= note;
            }
            else
            {
                Console.WriteLine($"0 nota(s) de R$ {note.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
        return value * 100;
    }

    static void getDecompositionCoins(int value, int[] arrayCoins)
    {
        Console.WriteLine("MOEDAS:");
        foreach (int note in arrayCoins)
        {
            if (value >= note)
            {
                int count = value / note;
                Console.WriteLine($"{count} moeda(s) de R$ {(0.01 * note).ToString("F2", CultureInfo.InvariantCulture)}");
                value %= note;
            }
            else
            {
                Console.WriteLine($"0 moeda(s) de R$ {(0.01 * note).ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }

    }

    public static void Main(string[] args)
    {
        double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int[] arrNotes = { 100, 50, 20, 10, 5, 2 };
        int[] arrCoins = { 100, 50, 25, 10, 5, 1 };
        int notesValue = (int)Math.Truncate(value);
        int coinsValue = (int)((value - notesValue) * 100);
        coinsValue += getDecompositionNotes(notesValue, arrNotes);
        getDecompositionCoins(coinsValue, arrCoins);
    }
}