partial class Tickets
{
    public static void Eight()
    {
        /*
        Напишите программу, которая вводит натуральное число N и находит сумму всех натуральных чисел от 1 до N.
        */
        Console.WriteLine("Эта программа выводит сумму всех натуральных чисел от 1 до введенного включительно.");
        Console.WriteLine();

        int n = Convert.ToInt32(AdditionalMethods.Input("Число: "));
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сумма = {sum}");
    }
}