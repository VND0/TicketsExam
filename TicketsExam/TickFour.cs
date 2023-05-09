partial class Tickets
{
    public static void Four()
    {
        /*
        Напишите программу, которая выбирает максимальное и минимальное из пяти введённых чисел
        */

        Console.WriteLine("Эта программа получает пять чисел и выводит максимальное и минимальное.");
        double num1 = Convert.ToDouble(AdditionalMethods.Input("Число: "));
        double num2 = Convert.ToDouble(AdditionalMethods.Input("Число: "));
        double num3 = Convert.ToDouble(AdditionalMethods.Input("Число: "));
        double num4 = Convert.ToDouble(AdditionalMethods.Input("Число: "));
        double num5 = Convert.ToDouble(AdditionalMethods.Input("Число: "));

        double[] allNums = {num1, num2, num3, num4, num5};
        Console.WriteLine($"Максимальное - {allNums.Max()}");
        Console.WriteLine($"Минимальное - {allNums.Min()}");

        
    }
}