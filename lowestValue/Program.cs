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
            }

            Console.WriteLine("Введите последовательность:");
            
            #endregion

            #region 

         

            #endregion
            
            
        }
    }
}