using System;

class PracDoWhile
{
    static void Main()
    {
        int num1, num2;

        Console.WriteLine("Indica el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.WriteLine("Indica el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Este numero no debe ser cero.");
            }
        }
        while (num2 == 0);

        Console.WriteLine($"La division entre {num1} y {num2} es:");
        Console.WriteLine(num1 / num2);


        Console.WriteLine("-----------------");
        Console.WriteLine("EJERCICIO:");
        Console.WriteLine("-----------------\n");
        string user;
        int clave;

        do
        {
            Console.Write("Insgrese su usuario: ");
            user = Console.ReadLine();

            if (user != "user1")
            {
                Console.WriteLine("Usuario incorrecto.");
            }
        }
        while (user != "user1");

        if (user == "user1")
        {
            do
            {
                Console.Write("Insgrese su clave de acceso: ");
                clave = Convert.ToInt32(Console.ReadLine());

                if (clave != 123456)
                {
                    Console.WriteLine("Usuario incorrecto.");
                }
            }
            while (clave != 123456);

        }


        Console.WriteLine($"Bienvenido, {user}");
    }
}
