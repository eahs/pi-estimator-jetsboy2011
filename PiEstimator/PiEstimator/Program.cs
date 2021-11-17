using System;

namespace PiEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;
            
            Console.WriteLine("Pi Estimator");
            Console.WriteLine("================================================");

            n = GetNumber("Enter number of iterations (n): ");

            double pi = EstimatePi(n);
            double diff = Math.Abs(pi - Math.PI);

            Console.WriteLine();
            Console.WriteLine($"Pi (estimate): {pi}, Pi (system): {Math.PI}, Difference: {diff}");
        }

        static double EstimatePi(long n)
        {
            Random rand = new Random(System.Environment.TickCount);
            double pi = 0.0;

            // TODO: Calculate Pi
            double point;
            double rad;
            double ratio = 0;
            double hits = 0;
            for(int i = 0;i < n; i++)
            {
                double xa = rand.NextDouble();
                double ya = rand.NextDouble();
                rad = (xa * xa) + (ya * ya);
                if (rad < 1)
                {
                    hits++;
                }

            }

            ratio = hits / n;
            pi = ratio * 4;
            return pi;
            
            return pi;
        }

        static long GetNumber(string prompt)
        {
            long output;

            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (Int64.TryParse(input, out output))
                {
                    return output;
                }
            }
        }
    }
}