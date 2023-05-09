partial class Tickets
{
    public static void Fifteen()
    {
        /*
        Дано натуральное число N. Выведите слово YES, если число N является точной степенью двойки, 
        или слово NO в противном случае. Операцией возведения в степень пользоваться нельзя!
        */
        Console.WriteLine("Эта программа проверяет, является ли введенное число натуральной степенью двойки.");
        Console.WriteLine();

        long num = Convert.ToInt64(AdditionalMethods.Input("Число: "));
        long power = 0;
        while (num > Math.Pow(2, power))
        {
            power++;
        }
        if (num == Convert.ToInt64(Math.Pow(2, power)))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}