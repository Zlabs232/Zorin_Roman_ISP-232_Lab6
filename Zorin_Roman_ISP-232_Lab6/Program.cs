
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
            
        }
    }
}