

namespace GuessingGame
{
    class Program321
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру ‘Угадай число’!");

            // Генерация случайного числа

            Random random = new Random();
            int secretNumber = random.Next(10);

            // Игровой цикл

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите ваше предположение:");
                int userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess < 0 || userGuess > 10)
                {
                    Console.WriteLine("Ваше предположение должно быть в диапазоне от 0 до 10.");
                    continue;
                }

                // Проверка, отгадано число или нет
                if (userGuess == secretNumber)
                {
                    if (i == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Вы угадали! {secretNumber}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
                