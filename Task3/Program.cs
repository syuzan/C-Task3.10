
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введите простое число");

            int n = int.Parse(Console.ReadLine());
            bool success = true;

            int i = 2;

            while (i  <= n-1)
            {
                if (n % i == 0)
                {
                   
                    success = false;
                   
                }
                i++;
                
            }

            if (success)
             {
                   Console.WriteLine($"{n} Число простое");
                Console.ReadKey();
              }
             else
             {
                   Console.WriteLine($"{n} Число не простое");
                Console.ReadKey();
            }
            
            
        }
    }
}