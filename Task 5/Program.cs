namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Привет, введите количество максимальное целое число диапазона");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int result = rand.Next(0, n);
            int count = 0;
            string guess;
            Console.WriteLine("Нажмите кл.Enter и введите число, если устал то введи string.Empty");


            for (; ; )

            {
                guess = Console.ReadLine();
                if (guess == string.Empty)

                {
                    Console.WriteLine(result);
                    break;
                }

                int guessNumber = int.Parse(guess);

                if (guessNumber == result)
                {
                    Console.WriteLine($"Вы угадали число. Это {result}");
                    break;
                }
                else if (guessNumber > result)

                {
                    Console.WriteLine("Введите число поменьше");
                }
                else
                {
                    Console.WriteLine("Введите число побольше");
                }

            }

            Console.ReadKey();
        }
    }
}