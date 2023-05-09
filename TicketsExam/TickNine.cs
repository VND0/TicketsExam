partial class Tickets
{
    public static void Nine()
    {
        /*
        Напишите программу, которая вводит натуральные числа a и b, 
        и выводит сумму квадратов натуральных чисел в диапазоне от a до b .
        */
        Console.WriteLine("Эта программа выводит сумму квадратов натуральных чисел в диапозоне от введенного до другого введенного включительно.");
        Console.WriteLine();

        int s = Convert.ToInt32(AdditionalMethods.Input("Начало диапозона: "));
        int e = Convert.ToInt32(AdditionalMethods.Input("Конец диапозона: "));

        int sum = 0;
        for (int i = s; i <= e; i++)
        {
            sum += Convert.ToInt32(Math.Pow(i, 2));
        }
        Console.WriteLine($"Сумма квадратов = {sum}");
    }
}