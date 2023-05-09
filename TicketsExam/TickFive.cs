partial class Tickets
{
    public static void Five()
    {
        /*
        Напишите программу, которая определяет, верно ли, что введённое число – трёхзначное. 
        Если введённое число – трёхзначное, нужно вывести ответ YES, если нет, то вывести ответ NO.
        */

        Console.WriteLine("Эта программа определяет, верно ли, что введенное число трехзначное.");
        Console.WriteLine();

        string num = Convert.ToString(Math.Abs(Convert.ToInt32(AdditionalMethods.Input("Число: "))));
        if (num.Length == 3)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }

    }
}