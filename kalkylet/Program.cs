using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Простой калькулятор на C#");

            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите оператор (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();  // Перенос строки после оператора

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Неверный оператор.");
                    return;
            }

            Console.WriteLine($"Результат: {num1} {operation} {num2} = {result}");
        }
    }
}
