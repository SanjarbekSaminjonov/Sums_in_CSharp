using System;

class Program {
    static void Main() {
        string str = Console.ReadLine();
        str = str.Replace("10", "ten");
        str = str.Replace("0", "zero");
        str = str.Replace("1", "one");
        str = str.Replace("2", "two");
        str = str.Replace("3", "three");
        str = str.Replace("4", "four");
        str = str.Replace("5", "five");
        str = str.Replace("6", "six");
        str = str.Replace("7", "seven");
        str = str.Replace("8", "eight");
        str = str.Replace("9", "nine");
        Console.WriteLine(str);
    }
}