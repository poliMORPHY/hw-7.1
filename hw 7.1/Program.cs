using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            int[,] myArray = CreateRandomArray2D();
            Show2DArray(myArray);
        }
        static int[,] CreateRandomArray2D()
        {
            Console.Write("Input a quantity of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a quantity of colums: ");
            int colums = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a min value: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a max value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    array[i, j] = new Random().Next(minValue, maxValue + 1);
                }
            }
            return array;
        }
        static void Show2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j] +  " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
