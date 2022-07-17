using System;

class PracWhile
{
    static void Main()
    {

        int num1, num2;
        Console.WriteLine("Indica el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Indica el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        while (num2 == 0)
        {
            Console.WriteLine("El numero no debe ser cero. Intenta otra vez: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"La division entre {num1} y {num2} es:");
        Console.WriteLine(num1/num2);


        Console.WriteLine("-----------------");
        Console.WriteLine("EJERCICIO:");
        Console.WriteLine("-----------------\n");
        string user;
        int clave;
        
        Console.Write("Insgrese su usuario: ");
        user = Console.ReadLine();

        while (user != "user1")
        {
        Console.Write("Usuario incorrecto. Insgrese su usuario de nuevo: ");
        user = Console.ReadLine();
        }

        if(user == "user1")
        {
            Console.Write("Insgrese su clave de acceso: ");
            clave = Convert.ToInt32(Console.ReadLine());

            while (clave != 123456)
            {
                Console.Write("Clave incorrecta Insgresa tu clave de acceso nuevamente: ");
                clave = Convert.ToInt32(Console.ReadLine());
            }
        }


        Console.WriteLine($"Bienvenido, {user}");

    }
}
