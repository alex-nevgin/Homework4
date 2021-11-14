using System;

namespace lowestValue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] progression;

            #region Ввод данных

            uint length = 0;
            bool flag;
            
            Console.WriteLine("Введите длину последовательности: ");
            
            flag = uint.TryParse(Console.ReadLine(), out length);

            if (flag == false)
            {
                if (length <= 0)
                {
                    Console.WriteLine("Длина последовательности должна быть положительна и не равна 0.");
                }
                return;
            }

            Console.WriteLine("Введите последовательность:");

            progression = new int[length];

            for (int i = 0; i < length; i++)
            {
                int num = int.Parse(Console.ReadLine());
                progression[i] = num;
            }

            #endregion

            #region Поиск минимального значения

            int min = int.MaxValue;
            for (int i = 0; i < length; i++)
            {
                if (progression[i] < min)
                {
                    min = progression[i];   
                }
            }
            Console.WriteLine("Минимальное значение: " + min);

            #endregion
        }
    }
}