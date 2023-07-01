
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Привет. Сколько у Вас карт?");
        int cards = int.Parse(Console.ReadLine());

       
        var sum = 0;
        for (int i = 0; i < cards; i++)
        {
            Console.WriteLine("Введите карту(2 - 10, J, Q, K, T): ");
            var nominal = Console.ReadLine();

            switch (nominal)
            {
                case "J":
                case "Q":
                case "K":
                case "T":
                    sum += 10;
                    break;
                default:
                    bool ValueNumber =int.TryParse(nominal, out int Valueint);
                    if (ValueNumber && Valueint >= 2 && Valueint <= 10)
                    {
                        sum += Valueint;
                    }
                    else
                    {
                       Console.WriteLine("неправильное значение карты.  Попобуйте еще раз");
                        i --;

                    }
                    break;
            }
        }
        Console.WriteLine($"{sum}");
        Console.ReadKey();

    }
}