using System;

class Program
{
    static void Main()
    {
        int i;
        int[] datos = new int[5];
        int dias;
        string dia;
        int[] nros = new int[10];
        int diaMes;
        string mes;

        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("Indica un dato:");
            datos[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Los datos son: ");
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine(datos[i] + " ");
        }

        Console.WriteLine();

        Console.WriteLine("Los datos al reves son: ");
        for (i = 4; i >= 0; i--)
        {
            Console.WriteLine(datos[i] + " ");
        }

        // Array con datos prefijados:
        string[] diasDeSemana = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

        Console.WriteLine("dime un numero de dia:");
        dias = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El nombre del dia es : " + diasDeSemana[dias-1]);

        Console.WriteLine();

        Console.WriteLine("Dime el nombre de un dia: ");
        Console.WriteLine();
        dia = Console.ReadLine();
        int posicion = -1;
        for (i = 0; i < diasDeSemana.Length; i++)
        {
            if(dia == diasDeSemana[i])
                posicion = i + 1;

        }

        if (posicion == -1)
            Console.WriteLine("Este no es un dia de la semana");
        else
            Console.WriteLine("Este es el dia nro: " + posicion);


        Console.WriteLine("------------------------");
        Console.WriteLine("EJERCICIOS");
        Console.WriteLine("------------------------");

        for (i = 0; i < 10; i++)
        {
            Console.WriteLine("Dime 10 numeros");
            nros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Los datos ingresados son: ");
        for (i = 9; i >= 0; i--)
        {
            Console.WriteLine(nros[i] + " ");
        }


        Console.WriteLine();
        string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

        Console.WriteLine("Dime un numero de mes:");
        diaMes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El nombre del mes es : " + meses[diaMes - 1]);


        Console.WriteLine();
        Console.WriteLine("Dime el nombre de un mes: ");
        mes = Console.ReadLine();
        int mesPosicion = -1;
        for (i = 0; i < meses.Length; i++)
        {
            if (mes == meses[i])
                mesPosicion = i + 1;

        }

        if (mesPosicion == -1)
            Console.WriteLine("Este no es un MES.");
        else
            Console.WriteLine("Este es el MES nro: " + mesPosicion);
    }
}