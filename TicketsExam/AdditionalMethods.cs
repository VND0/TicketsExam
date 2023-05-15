class AdditionalMethods
{
    public static string[] Append(string[] oldArray, string newElement)
    {
        string[] temp = oldArray;
        Array.Resize(ref temp, temp.Length + 1);
        temp[^1] = newElement;
        return temp;
    }
    public static string[] Extend(string[] oldArray, string[] newArray)
    {
        string[] temp = oldArray;
        foreach (string element in newArray)
        {
            temp = Append(temp, element);
        }
        return temp;
    }
    public static string Input(string question)
    {
        Console.Write(question);
        string answer = Console.ReadLine();
        return answer;
    }
}