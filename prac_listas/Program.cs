using System;
using System.Collections.Generic;

class EjemploListas
{
    static void Main()
    {
        int i;
        List<int> datos = new List<int>();
        int numero;

        
        do
        {
            Console.WriteLine("Indica cuantos datod quieras y el dato (-1) para termianr: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero != -1)
                datos.Add(numero);
        }
        while (numero != -1);

        Console.WriteLine("Los datos son: ");
        for (i = 0; i < datos.Count; i++)
        {
            Console.WriteLine(datos[i] + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Los datos al reves son: ");
        for (i = datos.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(datos[i] + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Dime un dato: ");
        int datoBuscar = Convert.ToInt32(Console.ReadLine());
        if (datos.Contains(datoBuscar))
        {
            Console.WriteLine("Esta el numero");
        }
        else
        {
            Console.WriteLine("No encontrado");
        }


        Console.WriteLine("------------------------");
        Console.WriteLine("EJERCICIOS");
        Console.WriteLine("------------------------");

        
    }
}