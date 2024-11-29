using System;
using System.IO;

namespace Практикум_10._5._1__HW_03____2;

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        IAdder adder = new Adder(logger);

        double num1 = 0;
        double num2 = 0;

        // Цикл для повторного запроса ввода, пока не будет введено корректное число
        while (!GetNumberFromUser(out num1, logger, "первое"))
        {
            // Цикл будет продолжаться до тех пор, пока пользователь не введет корректное число
        }

        while (!GetNumberFromUser(out num2, logger, "второе"))
        {
            // Цикл будет продолжаться до тех пор, пока пользователь не введет корректное число
        }


        try
        {
            double sum = adder.Add(num1, num2);
            logger.Log($"Сумма: {sum}", ConsoleColor.Blue);
        }
        catch (Exception ex)
        {
            logger.Log($"Произошла ошибка: {ex.Message}", ConsoleColor.Red);
        }
        finally
        {
            logger.Log("Выполнение завершено.", ConsoleColor.Gray);
        }

        Console.ReadKey();
    }

    // Вспомогательная функция для безопасного парсинга double
    static bool TryParseDouble(string input, out double result)
    {
        if (double.TryParse(input, out result))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите число.");
            return false;
        }
    }

    static bool GetNumberFromUser(out double result, ILogger logger, string numberOrder)
    {
        Console.WriteLine($"Введите {numberOrder} число:");
        string input = Console.ReadLine();
        if (double.TryParse(input, out result))
        {
            return true;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red; // Красный фон
            Console.ForegroundColor = ConsoleColor.White; // Белый текст
            Console.WriteLine("Некорректный ввод. Введите число.");
            Console.ResetColor(); // Сброс цветов
            return false;
        }
    }

}