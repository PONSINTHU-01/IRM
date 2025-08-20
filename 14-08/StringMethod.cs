using System;

class StringMethodsExample
{
    static void Main()
    {
        string text = "  Hello World  ";

        Console.WriteLine("Original: '" + text + "'");
        Console.WriteLine("Trimmed: '" + text.Trim() + "'");
        Console.WriteLine("Uppercase: " + text.ToUpper());
        Console.WriteLine("Lowercase: " + text.ToLower());
        Console.WriteLine("Substring(2,5): " + text.Substring(2, 5));
        Console.WriteLine("Contains 'World'? " + text.Contains("World"));
        Console.WriteLine("Replace: " + text.Replace("World", "C#"));
    }
}

