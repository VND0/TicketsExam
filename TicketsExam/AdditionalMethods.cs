class AdditionalMethods
{
    public static string[] StringArrayAppendWithString(string[] oldArray, string newElement)
    {
        string[] temp = oldArray;
        Array.Resize(ref temp, temp.Length + 1);
        temp[^1] = newElement;
        return temp;
    }
    public static string[] StringArrayAppendWithArray(string[] oldArray, string[] newArray)
    {
        string[] temp = oldArray;
        foreach (string element in newArray)
        {
            temp = StringArrayAppendWithString(temp, element);
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