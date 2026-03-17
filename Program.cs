using System;

namespace con124
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0, sum = 0;
            string s = "";

            while (true)
            {
                Console.Write("Введите число: ");
                s = Console.ReadLine(); 

                if (s == "Q") break; 

                if (double.TryParse(s, out n))
                {
                    sum += n; 
                    Console.WriteLine("сумма = " + sum);
                }
            }
        }
    }
}