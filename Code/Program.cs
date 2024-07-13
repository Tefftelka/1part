namespace Code;

class Program
{
    static void Main(string[] args)
    {
        string[] strings = new [] {"Hello", "2", "world", ":-)"};
        string[] rslt = CreateArray(strings);
        string joinedResult = string.Join("\",\"", rslt);
        if(!string.IsNullOrWhiteSpace(joinedResult))
            joinedResult = $"\"{joinedResult}\"";

        Console.WriteLine($"[{joinedResult}]");
    }

    private static string[] CreateArray(string[] arrString)
    {
        const int maxLength = 3;
        string[] arrTemp = new string[arrString.Length];
        int index = -1;
        foreach(string str in arrString) {
            if(str.Length > maxLength)
                continue;
            arrTemp[++index] = str;
        }
        string[] arrNew = new string[index + 1];
        Array.Copy(arrTemp, 0, arrNew, 0, index + 1);

        return arrNew;
    }
}
