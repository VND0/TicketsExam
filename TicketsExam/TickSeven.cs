partial class Tickets
{
    public static void Seven()
    {
        /*
        Напишите программу, которая вводит с клавиатуры номер месяца и день, и определяет, 
        сколько дней осталось до Нового года. При вводе неверных данных должно быть выведено сообщение об ошибке. 
        Считается, что год невисокосный.Программа должна вывести количество дней, оставшихся до Нового года. 
        Если введены неверные данные, нужно вывести число -1.
        */
        Console.WriteLine("Эта программа принимает номер месяца и день и выводит, сколько дней осталось до НГ. При вводе неверных данных выводится -1");
        Console.WriteLine();

        string mon_raw = AdditionalMethods.Input("Месяц: ");
        string day_raw = AdditionalMethods.Input("День: ");
        int mon, day;
        if (!Int32.TryParse(mon_raw, out mon)) { Console.WriteLine(-1); return; }
        if (!Int32.TryParse(day_raw, out day)) { Console.WriteLine(-1); return; }
        if (!(0 < mon & mon <= 12)) { Console.WriteLine(-1); return; }

        Dictionary<int, int> days = new Dictionary<int, int>()
        {
            {1, 31}, {2, 28}, {3, 31}, {4, 30}, {5, 31}, {6, 30}, {7, 31}, {8, 31}, {9, 30}, {10, 31}, {11, 30}, {12, 31}
        };
        if (day > days[mon]) { Console.WriteLine(-1); return; }

        int counter = days[mon] - day;
        for (int m = mon; m < days.Count; m++)
        {
            counter += days[m];
        }
        Console.WriteLine($"Осталось: {counter}");
    }
}