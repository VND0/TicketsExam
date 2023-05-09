using System.Runtime.CompilerServices;

partial class Tickets
{
    public static void Fourteen()
    {
        /*
        Напишите программу, которая определяет, верно ли, что введённое число состоит из одинаковых цифр 
        (как, например, число 222). Программа должна вывести слово 'YES', если в числе все цифры одинаковые, 
        и слово 'NO', в противном случае.
         */

        Console.WriteLine("Эта программа проверяет, верно ли, что все цифры введенного числа одинаковы.");

        string num = "Not a num now";
        int fuckingCSharpRulesAndSyntaxWhyCannotIJustGetTrueOrFalseThereIWishDevelopersToRealiseThatThereExistsIsDigitInPython = 0;
        while (!(Int32.TryParse(num, out fuckingCSharpRulesAndSyntaxWhyCannotIJustGetTrueOrFalseThereIWishDevelopersToRealiseThatThereExistsIsDigitInPython)))
        {
            Console.Write("Введите целое число: ");
            num = Console.ReadLine();
        }

        char checker = num[0];
        bool allAreSame = true;
        foreach (char digit in num)
        {
            if (!(checker == digit))
            {
                allAreSame = false;
                break;
            }
        }

        if (allAreSame)
        {
            Console.WriteLine("\nYES");
        }
        else 
        {
            Console.WriteLine("\nNO");
        }

    }
}