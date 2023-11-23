using System;
using System.Text;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Random random = new Random();
            int[] numero = new int[100];

            //Початок створення двовимірного масиву
            int[][] ints = new int[10][];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = new int[10];
            }
            //Кінець створення двовимірного масиву

            //Заповнення масиву і вивід на екран
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints[i].Length; j++)
                {
                    ints[i][j] = random.Next(100, 900);

                    Console.Write(ints[i][j] + " ");
                }
                Console.WriteLine();
            }

            //Робота з масивом
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints[i].Length; j++)
                {
                    if (i == j)
                    {
                        sum += ints[i][j];
                        Console.WriteLine(sum);
                    }
                }
            }
        }
    }
}