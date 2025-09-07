
namespace Lab5
{
    class Lab5
    {
        static void Main()
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine(y);
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            finally
            {
                Console.WriteLine("Блок Finally");
            }
            Console.WriteLine("Конец программы.");

            //while (true)
            //{
                Console.WriteLine("Введите первое число: ");
                double number1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите первое число: ");
                double number2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите операцию (+,-,*,/): ");
                string? op = Console.ReadLine();

                double res = 0;

                try
                {
                    if (op == "+") res = number1 + number2;
                    else if (op == "-") res = number1 - number2;
                    else if (op == "*") res = number1 * number2;
                    else if (op == "/")
                    {
                        if (number2 == 0)
                            throw new DivideByZeroException("Ошибка! деление на ноль");
                        res = number1 / number2;
                    }

                    else Console.WriteLine("Неверная операция!");
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
                    Console.WriteLine($"Ошибка непредвиденная ошибка . {ex.Message}.");
                }
                finally
                {
                    Console.WriteLine("Работа калькулятора завершна.");
                }
            //}

            int numb = 12;
            Console.WriteLine(numb.ToString());
            bool boolean = true;
            Console.WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            object me = new();
            Console.WriteLine(me.ToString());

            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");

            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"My birthday is {birthday}: ");
            Console.WriteLine($"My birthday is {birthday:D}: ");

            Console.WriteLine("Какой максимальный балл по дисциплинам? ");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int count))
            {
                Console.WriteLine($"Это {count} баллов.");
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }

        }
    }
}


