using System;
class Program
{
    public static void Main()
    {
        go:
        Random tr = new Random();
        double[,] mass = new double[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                mass[i, j] = tr.Next(10, 99);
                Console.Write(mass[i, j] + "  ");
            }
            Console.WriteLine("\n");
        }
        Console.WriteLine("--------------------------------------\n");
        Console.ReadKey(true);
        goto go;
    }
    
    static void tasodifiy()
    {
        
    }
}
