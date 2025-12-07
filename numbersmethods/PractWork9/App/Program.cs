using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 1.25;
            double h = 0.1;
            double b = 1;
            int i = 0;

            while (x <= b + h / 2)
            {
                Console.WriteLine(i+". "+ "   x: "+ x+"    y: "+ Math.Round(y,4));

                y = y + h * (Math.Pow(x, 2.0) - 2 * y);
                x = x + h;
                i++;
            }

            Console.ReadKey();
        }
    }
}
