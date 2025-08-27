using System;
using System.Globalization;

class Program
{
    static void averageCalculator(double sum, int sumWeights)
    {
        double average = sum / sumWeights;
        average = Math.Floor(average * 10) / 10.0;
        Console.WriteLine("Media: " + average.ToString("F1", CultureInfo.InvariantCulture));
        if (average >= 7.0)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (average < 5.0)
        {
            Console.WriteLine("Aluno reprovado.");
        }
        else
        {
            Console.WriteLine("Aluno em exame.");
            double examScore = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota do exame: " + $"{examScore:F1}");
            average = (average + examScore) / 2;
            if (average >= 5.0)
                Console.WriteLine("Aluno aprovado.");
            else
                Console.WriteLine("Aluno reprovado.");

            Console.WriteLine("Media final: " + average.ToString("F1", CultureInfo.InvariantCulture));
        }
    }

    public static void Main(string[] args)
    {
        double sum = 0;
        int[] weights = { 2, 3, 4, 1 };
        int sumWeights = 0;

        string[] input = Console.ReadLine().Split(' ');
        for (int i = 0; i < input.Length; i++)
        {
            double score = double.Parse(input[i], CultureInfo.InvariantCulture);
            sum += (score * weights[i]);
        }
        foreach (int w in weights)
        {
            sumWeights += w;
        }
        averageCalculator(sum, sumWeights);
    }
}