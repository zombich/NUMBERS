using System;

class Program
{
    static void Main()
    {
        double a = 1.5;
        double b = 2.5;
        int n = 10;
        double h = (b - a) / n;

        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            double xi = a + i * h;

            double f1 = xi + (h / 2.0) - (h / (2.0 * Math.Sqrt(3.0)));
            double f2 = xi + (h / 2.0) + (h / (2.0 * Math.Sqrt(3.0)));

            double yi1 = f1 * f1 * Math.Tan(f1 / 2.0);
            double yi2 = f2 * f2 * Math.Tan(f2 / 2.0);

            sum += yi1 + yi2;
        }

        double integral = sum * (h / 2.0);

        Console.WriteLine("Интеграл: " + Math.Round(integral, 8));
        Console.ReadKey();
    }
}




