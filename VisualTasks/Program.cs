using System;

namespace VisualTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Uzunlugu qeyd edin: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n*2; j++)
                {
                    if (i + j == n || j - i == n || (i == n/2 && j >= i && j<=i+n))
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
