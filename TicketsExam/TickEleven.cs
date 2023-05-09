partial class Tickets
{
    public static void Eleven()
    {
        /*
        Напишите программу, которая считает количество чётных цифр введённого числа.
        */
        Console.WriteLine("Эта программа выводит количество четных цифр введенного числа");
        Console.WriteLine();

        string num = AdditionalMethods.Input("Число: ");
        int counter = 0;

        foreach (char digit in num)
        {
            int temp = Convert.ToInt32(digit);
            if (temp % 2 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine($"Количество четных цифр = {counter}");
    }
}