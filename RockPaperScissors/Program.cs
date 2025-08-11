using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userWins = 0, computerWins = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Камень-Ножницы-Бумага");
                Console.WriteLine($"Счёт: Вы {userWins} — Компьютер {computerWins}");
                Console.WriteLine("Выберите: [к]амень, [н]ожницы, [б]умага или [в]ыход");

                string input = Console.ReadLine().ToLower();
                if (input == "в") break;

                Random random = new Random();
                int computerChoice = random.Next(0, 3); // 0-камень, 1-ножницы, 2-бумага

                // Проверка выигрыша
                if ((input == "к" && computerChoice == 1) ||
                    (input == "н" && computerChoice == 2) ||
                    (input == "б" && computerChoice == 0))
                {
                    Console.WriteLine("Вы выиграли!");
                    userWins++;
                }
                else if ((input == "к" && computerChoice == 2) ||
                         (input == "н" && computerChoice == 0) ||
                         (input == "б" && computerChoice == 1))
                {
                    Console.WriteLine("Компьютер выиграл!");
                    computerWins++;
                }
                else
                {
                    Console.WriteLine("Ничья!");
                }

                Console.WriteLine("Нажмите Enter для продолжения...");
                Console.ReadLine();
            }
        }
    }
}

