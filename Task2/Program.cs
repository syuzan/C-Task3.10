
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Привет. Сколько у Вас карт?");
        int cards = int.Parse(Console.ReadLine());

        Console.WriteLine("Ведите значение карты, " +
               "\n или если у Вас картинки, то  " +
               "Валет это J," +
               "\n Королева - Q, " +
               "for Король - K," +
               "for Туз - T");
        var sum = 0;
        for (int i = 0; i < cards; i++)
        {

            var nominal = Console.ReadLine();

            switch (nominal)
            {

                case "2":
                    sum += 2;
                    break;
                case "3":
                    sum += 3;
                    break;
                case "4":
                    sum += 4;
                    break;
                case "5":
                    sum += 5;
                    break;
                case "6":
                    sum += 6;
                    break;
                case "7":
                    sum += 7;
                    break;
                case "8":
                    sum += 8;
                    break;
                case "9":
                    sum += 9;
                    break;
                case "J":
                    sum += 10;
                    break;
                case "Q":
                    sum += 10;
                    break;

                case "K":
                    sum += 10;
                    break;
                case "T":
                    sum += 10;
                    break;
                default:

                    Console.WriteLine("wrong value,You need to input right card value");
                    i -= 1;
                    break;
            }
        }
        Console.WriteLine($"{sum}");
        Console.ReadKey();

    }
}