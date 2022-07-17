using System;

class PracCicloFor
{
    static void Main()
    {
        int i;

        for (i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        for (i = 10; i >= 1; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        for (i = 1; i <= 5; i++)
        {
            Console.Write("Holis!");
        }
        Console.WriteLine();

        for (i = 4; i <= 10; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        Console.WriteLine("-----------------");
        Console.WriteLine("EJERCICIOS:");
        Console.WriteLine("-----------------\n");

        for (i = 10; i <= 20; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        for (i = 15; i >= 10; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        for (i = 3; i <= 30; i += 3)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        for (i = 1; i <= 10; i++)
        {
            Console.WriteLine("Holis " + i);
        }
        Console.WriteLine();

    }
}
