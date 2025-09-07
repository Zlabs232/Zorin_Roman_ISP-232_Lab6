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
                    //Ошибка 1: использование Convert.ToInt32 без проверки на пустую строку
                    //double number1 = Convert.ToInt32(Console.ReadLine()); 
                    double number1 = double.Parse(Console.ReadLine()); //Исправил

                    Console.WriteLine("Введите второе число: ");
                    //Ошибка 2: присваивание неверной переменной (number1 вместо number2)
                    //double number2 = number1;
                    double number2 = double.Parse(Console.ReadLine()); //Исправил

                    Console.WriteLine("Введите операцию (+, -, *, /, ^): ");
                    string? op = Console.ReadLine();

                    double res = 0;
                    bool validOperation = true;

                    if (op == "+") res = Add(number1, number2);
                    else if (op == "-") res = Subtract(number1, number2);
                    else if (op == "*") res = Multiply(number1, number2);
                    else if (op == "/")
                    {
                        //Ошибка 3: отсутствовала проверка деления на ноль
                        //res = Divide(number1, number2); 
                        if (number2 == 0)
                            throw new DivideByZeroException("Ошибка! деление на ноль");
                        res = Divide(number1, number2); //Исправил
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
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Неожиданная ошибка: {ex.Message}");
                }

                Console.WriteLine("Введите 'exit' для выхода. \nНажмите любую клавишу для продолжения");
                string? input = Console.ReadLine()?.ToLower(); 

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