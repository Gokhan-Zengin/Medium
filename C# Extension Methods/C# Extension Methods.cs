using System;

class Program
{
    public static void Main()
    {
        int value = 5;
        value.Add(6);
        Console.WriteLine(value);
        // Output : 11
    }
}

public static class ExtensionMethods
{
    public static void Add(this ref int value1, int value2)
    {
        value1 += value2;
    }
}