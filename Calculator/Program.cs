using System;

namespace Calc
{
    class Program
    {
        static void Main()
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Введите первое число: ");
                    double number1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число: ");
                    double number2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите операцию (+, -, *, /, ^): ");
                    string? op = Console.ReadLine();

                    double res = 0;
                    bool validOperation = true;

                    if (op == "+") res = Add(number1, number2);
                    else if (op == "-") res = Subtract(number1, number2);
                    else if (op == "*") res = Multiply(number1, number2);
                    else if (op == "/")
                    {
                        if (number2 == 0)
                            throw new DivideByZeroException("Ошибка! деление на ноль");
                        res = Divide(number1, number2);
                    }
                    else if (op == "^") res = Pow(number1, number2);
                    else
                    {
                        Console.WriteLine("Неверная операция!");
                        validOperation = false;
                    }

                    if (validOperation)
                    {
                        Console.WriteLine($"Результат: {number1} {op} {number2} = {res}");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка ввода! Введите корректные числа.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Ошибка ввода. {ex.Message}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка непредвиденная ошибка. {ex.Message}.");
                }

                Console.WriteLine("Введите 'exit' для выхода. \nНажмите любую клавишу для продолжения");
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    flag = false;
                }
                else
                {
                    Console.Clear();
                }
            }
            Console.WriteLine("Работа калькулятора завершена. Нажмите любую клавишу для выхода...");
            Console.ReadKey();

            Console.Write("Введите делимое: ");
            double delm = Convert.ToDouble(Console.ReadLine());

            double del;
            do
            {
                Console.Write("Введите делитель: ");
                del = Convert.ToDouble(Console.ReadLine());

                if (del == 0)
                {
                    Console.Write("На ноль делить нельзя. Повторите ввод делителя: ");
                }

            } while (del == 0);

            double result = delm / del;
            Console.WriteLine($"Результат деления: {result}");


            bool isValid = false;
            int number = 0;

            while (!isValid)
            {
                try
                {
                    Console.Write("Введите целое число: ");
                    string input = Console.ReadLine();

                    number = int.Parse(input);
                    isValid = true;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Ошибка: введена пустая строка. Повторите ввод.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введен неверный формат. Повторите ввод.");
                }
            }
            Console.WriteLine($"Вы ввели корректное число: {number}");
        }
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}