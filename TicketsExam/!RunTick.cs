class MainProg
{
    static void Zaglushka()
    {
        Console.WriteLine("Билет, к которому вы обратились, еще не добавлен в словарь или не существует.");
    }

    static void Main()
    {
        // Обратитесь к методу, соответствующему нужному билету.
        int ticket = Convert.ToInt32(AdditionalMethods.Input("Номер билета: "));
        Dictionary<int, Action> ticketsNumbers = new Dictionary<int, Action>()
        {
            {1, Tickets.One},
            {2, Tickets.Two},
            {3, Tickets.Three},
            {4, Tickets.Four},
            {5, Tickets.Five},
            {6, Tickets.Six},
            {7, Tickets.Seven},
            {8, Tickets.Eight},
            {9, Tickets.Nine},
            {10, Tickets.Ten},
            {11, Tickets.Eleven},
            {12, Tickets.Twelve},
            {13, Tickets.Thirteen},
            {14, Tickets.Fourteen},
            {15, Tickets.Fifteen}
        };

        try
        {
            ticketsNumbers[ticket]();
        }
        catch (KeyNotFoundException)
        {
            Zaglushka();
        }
        

        Console.Write("\nДля выхода нажмите любую клавишу...");
        Console.ReadKey();
        
    }
}