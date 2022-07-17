using System;

class praccondicionales
{
    static void Main()
    {
        Console.Write("Indica un numero:");
        int n = Convert.ToInt32(Console.ReadLine());

        if(n > 0) {
            Console.WriteLine($"{n} es un numero positivo.");
        } else 
        {
            Console.WriteLine($"{n} es un numero negativo o es cero.");
        }

        if (n < 0)
        {
            Console.WriteLine($"{n} es un numero negativo.");
        }

        if (n == 0)
        {
            Console.WriteLine($"{n} es un cero.");
        }

        if (n != 0)
        {
            Console.WriteLine($"{n} no es cero.");
        }

        if ((n == 2) || (n == 4))
        {
            Console.WriteLine($"{n} es dos o tres.");
        }

        if ((n > 0) || (n % 2 == 0))
        {
            Console.WriteLine($"{n} es positivo y par.");
        }

        if (!(n < 0))
        {
            Console.WriteLine($"{n} No es negativo.");
        }

        if (n == 2)        {
            Console.WriteLine($"{n} Es dos.");
        }
        else if (n == 3)
        {
            Console.WriteLine($"{n} Es tres.");
        }
        else if (n == 6)
        {
            Console.WriteLine($"{n} Es seis.");
        } else
        {
            Console.WriteLine($"{n} no esta dentro del rango dado.");
        }

        Console.Write("Dime tu nombre: ");
        string name = Console.ReadLine();
        if (name == "Silvi")
        {
            Console.WriteLine(
                $"Holis, {name}");
        }
        else{
            Console.WriteLine($"{name}, tu no eres bienvenido");
        }
    }
}
