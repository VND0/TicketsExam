 partial class Tickets
{
    public static void One()
    {
        /*
        Напишите программу, которая находит сумму, произведение и среднее арифметическое трёх целых чисел, 
        введённых с клавиатуры.
         */
        Console.WriteLine("Эта программа находит сумму, произведение и среднее арифметическое трёх целых чисел, введённых с клавиатуры");
        Console.WriteLine();

        Console.Write("Число 1: ");
        float num1 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Число 2: ");
        float num2 = Convert.ToSingle(Console.ReadLine());
        Console.Write("Число 3: ");
        float num3 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("\n");

        float sum = num1 + num2 + num3;
        float prod = num1 * num2 * num3;
        float aver = sum / 3f;

        Console.WriteLine($"Сумма = {sum}");
        Console.WriteLine($"Произведение = {prod}");
        Console.WriteLine($"Среднее арифметическое = {aver}");

    }
}