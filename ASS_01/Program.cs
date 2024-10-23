
using System;
namespace ass
{
    public class Program
    {
        public static void Main()
        {
            int[,,] matrix =
            {
                { {10,20,20},{40,50,60},{70,80,90} },
                { {11,32,34 },{14,15,26, },{17,28,39} },
                {{13,45,21},{45,67,23},{36,19,20} }
            };
            
            Console.WriteLine(" Given Matrix : ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("  ");
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        Console.Write($"{matrix[i, j, k]} ");
                    }
                }
            }

            int sum_diagnol = 0;

            for (int i = 0; i < 3; i++)
            {
                sum_diagnol += matrix[i, i, i];
            }

            Console.WriteLine($"\n\nThe sum of diagnol of given(3x3x3) matrix is: {sum_diagnol}");
        }

    }
}