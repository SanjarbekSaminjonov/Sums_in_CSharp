using System;

class MainClass
{
    public static void Main()
    {
        string a, b, c = "";
        a = "salom";
        b = "hayr";
        for (byte i = 0; i < 4; i++)
        {
            c += Convert.ToString(a[i]) + (b[i]);
        }
        Console.WriteLine(c);
    }
}