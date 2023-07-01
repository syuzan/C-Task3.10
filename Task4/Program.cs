namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Привет, введите количество целых чисел");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целые числа");

            int minValue = int.MaxValue;
            int firstValue = -1;
            for (; count > 0; count--)
            {
                firstValue = int.Parse(Console.ReadLine());
                minValue = minValue > firstValue ? firstValue : minValue;
                // Console.WriteLine($"{minValue}");
            }

            Console.WriteLine($"{minValue}");
            Console.ReadKey(true);
        }
    }
}