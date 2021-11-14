using System;

namespace guessTheNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int userNum; // Число, вводимое пользователем
            int rangeThreshold; // Предел диапазона
            string userInput; // Собственно ввод пользователя
            string hint1 = "Введите предельное число диапазона: "; // Подсказки
            string hint2 = "Введите число: ";

            Console.WriteLine(hint1);

            rangeThreshold = int.Parse(Console.ReadLine());

            #region Генерация случайного числа ("загадывание" числа компьютером)

            Random rnd = new Random();
            int num = rnd.Next(rangeThreshold);

            #endregion
            
            while (true)
            {
                Console.WriteLine(hint2);
                userInput = Console.ReadLine();
                bool flag = int.TryParse(userInput, out userNum);
                if (flag)
                {
                    userNum = int.Parse(userInput);
                }
                else if (userInput == "")
                {
                    Console.WriteLine("Вы прервали игру.");
                    Console.WriteLine("Загаданное число: " + num);
                    break;
                }
                else
                {
                    Console.WriteLine("Допустимы только числа.");
                    break;
                }

                if (userNum > num)
                {
                    Console.WriteLine("Введенное число больше загаданного. Попробуйте снова.");
                }
                else if (userNum < num)
                {
                    Console.WriteLine("Введенное число меньше загаданного. Попробуйте снова.");
                }
                else
                {
                    Console.WriteLine("Вы угадали число!");
                    break;
                }
            }
        }
    }
}