using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {  //task 1
            Console.WriteLine("Завдання 1:");
            int[,] myMatrix = new int[8, 8];
            Random rand = new Random();
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {

                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {

                    myMatrix[i, j] = rand.Next(0, 100);
                    Console.Write($"{myMatrix[i, j],4}");
                }
                Console.WriteLine();

            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Замiна:");
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                int temp = myMatrix[i, i];
                myMatrix[i, i] = myMatrix[i, myMatrix.GetLength(1) - 1 - i];
                myMatrix[i, myMatrix.GetLength(1) - 1 - i] = temp;
            }
            for (int i = 0; i < myMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < myMatrix.GetLength(1); j++)
                {
                    Console.Write($"{myMatrix[i, j],4} ");
                }
                Console.WriteLine();

            }
        }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            {  //task 2
                Console.WriteLine("Завдання 2:");
                int[] array = new int[20];
                Random rand = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 20);
                    Console.WriteLine($"{i}:" + array[i]);
                }
                int[] sort = new int[array.Length / 2];
                for (int i = 0, j = 0; i < array.Length; i += 2, j++)
                {
                    sort[j] = array[i];
                }
                Array.Sort(sort);
                Console.WriteLine("\nСтиснутий та відсортований масив:");
                for (int i = 0; i < sort.Length; i++)
                {
                    Console.WriteLine($"Елемент {i}: {sort[i]}");
                }
            }
        }
    }
}
