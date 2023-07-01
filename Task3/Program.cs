
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите простое число");

            int n = int.Parse(Console.ReadLine());
            bool success = false;

            int i = 2;

            while (i <= n - 1)
            {
                if (n % i == 0)
                {
                    success = true;

                }
                i++;
                break;

            }

            if (!success)
             {
                   Console.WriteLine("Число простое");
                Console.ReadKey();
              }
             else
             {
                   Console.WriteLine("Число не простое");
                Console.ReadKey();
            }
            
            
        }
    }
}