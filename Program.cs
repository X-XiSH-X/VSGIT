using System;

class Program
{
    static double A = 0, B = 0;

    static void Main()
    {
        // Автоматический запрос на ввод A и B в начале
        InputA();
        InputB();

        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Выход");
            Console.Write("Выберите пункт: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Add();
                    break;
                case "2":
                    return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    break;
            }
        }
    }

    static void InputA()
    {
        Console.Write("Введите A: ");
        A = double.Parse(Console.ReadLine());
    }

    static void InputB()
    {
        Console.Write("Введите B: ");
        B = double.Parse(Console.ReadLine());
    }

    static void Add()
    {
        Console.WriteLine($"Результат: {A + B}");
    }
}