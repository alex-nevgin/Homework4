using System;
namespace randomMatrix
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrix;
            string hintRows = "Введите число строк: ";
            string hintColumns = "Введите число столбцов: ";
            int r, c; // количество строк и столбцов
            //bool flagR, flagC; // флаги для проверки ввода
           

            Console.Write(hintRows);
            // flagR = int.TryParse(Console.ReadLine(), out r);
            // if (flagR == false)
            // {
            //     Console.WriteLine("Ошибка: число строк массива может быть только целым числом");
            // }
            r = Int32.Parse(Console.ReadLine());
            
            Console.Write(hintColumns);
            // flagC = int.TryParse(Console.ReadLine(), out c);
            // if (flagC == false)
            // {
            //     Console.WriteLine("Ошибка: число строк массива может быть только целым числом");
            // }
            c = Int32.Parse(Console.ReadLine());
            
            
            Random rnd = new Random();
            
            matrix = new int[r,c];
            
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = rnd.Next(10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            int sum = 0;

            foreach (var value in matrix)
            {
                sum += value;
            }

            Console.WriteLine("Сумма элементов массива: " + sum);
        }
    }
}