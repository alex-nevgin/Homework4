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
                num = progression[i];
                Console.ReadLine();
            }
            
            #endregion Поиск минимального значения

            int min = int.MaxValue;
            foreach (var i in progression)
            {
                if (progression[i] > min)
                {
                    min = progression[i];
                }
            }
            
            #region 

         

            #endregion
            
            
        }
    }
}