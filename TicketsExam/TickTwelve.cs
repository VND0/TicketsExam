partial class Tickets
{
    public static void Twelve()
    {
        /*
        Напишите программу, которая считает сумму цифр введённого числа.
        */
        Console.WriteLine("Эта программа считает сумму цифр введенного числа");
        Console.WriteLine();

        string num = AdditionalMethods.Input("Число:");
        int sum = 0;
        foreach (int dig in num)
        {
            sum += dig;
        }
        Console.WriteLine($"Сумма цифр = {sum}");
    }
}