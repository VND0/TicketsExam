partial class Tickets
{
    internal static bool CheckerForTen(int num)
    {
        int div1 = Convert.ToInt32(Convert.ToString(num).Substring(0, 1));
        int div2 = Convert.ToInt32(Convert.ToString(num).Substring(1, 1));

        if (num % div1 == 0 & num % div2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void Ten()
    {
        /*
        Напишите программу, которая вводит двухзначные натуральные числа а и b и 
        выводит на экран все натуральные числа на отрезке [a, b] , делящиеся на каждую из своих цифр. 
        Входная строка содержит два натуральных числа – значения a и b, разделённых пробелами. 
        Гарантируется, что a ≤ b .
        */
        Console.WriteLine("Эта программа получает два двухзначных натуральных числа на одной строке, разделенных пробелом" +
                          "\nи выводит все все натуральные числа на их отрезке, делящиеся на каждую из своих цифр." +
                          "\nПервое число меньше или равно второму.");
        Console.WriteLine();

        string num_raw = AdditionalMethods.Input("Числа: ");
        int s = Convert.ToInt32(num_raw.Substring(0, 2));
        int e = Convert.ToInt32(num_raw.Substring(3, 2));

        for (int i = s; i <= e; i++)
        {
            if (CheckerForTen(i))
            {
                Console.WriteLine(i);
            }
        }

    }
}