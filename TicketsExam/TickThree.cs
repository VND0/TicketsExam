partial class Tickets
{
    public static void Three()
    {
        /*
        Напишите программу, которая вводит координаты двух точек на числовой оси и выводит расстояние между ними.
        */
        Console.WriteLine("Эта программа получает координаты двух точек и выводит расстояние между ними.");

        double x1 = Convert.ToDouble(AdditionalMethods.Input("X1: "));
        double y1 = Convert.ToDouble(AdditionalMethods.Input("Y1: "));
        double x2 = Convert.ToDouble(AdditionalMethods.Input("X2: "));
        double y2 = Convert.ToDouble(AdditionalMethods.Input("Y2: "));

        double squared = Convert.ToSingle(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        double result = Math.Round(Math.Sqrt(squared), 2);
        Console.WriteLine($"Расстояние между двумя точками - {result}");
    }
}