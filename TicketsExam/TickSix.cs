partial class Tickets
{
    public static void Six()
    {
        /*
        Напишите программу, которая получает три числа и выводит количество одинаковых чисел в этой цепочке. 
        Программа должна вывести количество одинаковых чисел из переданного ей набора или число 0, 
        если все числа различные.
        */
        Console.WriteLine("Эта программа получает три числа и выводит количество одинаковых.");
        Console.WriteLine();

        int num1 = Convert.ToInt32(AdditionalMethods.Input("Число: "));
        int num2 = Convert.ToInt32(AdditionalMethods.Input("Число: "));
        int num3 = Convert.ToInt32(AdditionalMethods.Input("Число: "));

        List<int> nums = new List<int>() {num1, num2, num3};
        nums.Sort();

        int counter = 0;
        for (int ind = 1; ind < nums.Count(); ind++)
        {
            if (nums[ind-1] == nums[ind])
            {
                counter++;
            }
        }
        if (counter != 0)
        {
            counter++;
        }

        Console.WriteLine(counter);
    }
}