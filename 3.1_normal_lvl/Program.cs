using System;

namespace Kolesnikov_3._1_Normal_lvl
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите k:");
                int k = int.Parse(Console.ReadLine());
                double A = 0;
                double P = 1;
                for (int j = 1; j <= k; j++)
                {
                    {
                        if (j == 4) continue;
                        P *= ((j * j) - 4) * j / (j - k + 1);
                    }
                    double S = 0;
                    for (int i = 1; i <= 9; i++)
                    {
                        S = (i - 3) / (i - 7);
                    }
                    Console.WriteLine($"A={P * S:F2}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }

}








