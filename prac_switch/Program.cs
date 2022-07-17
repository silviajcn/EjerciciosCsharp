using System;

class Prac_Switch
{
    static void Main()
    {
        Console.Write("Indica un numero: ");
        int n = Convert.ToInt32(Console.ReadLine());

        switch (n)
        {
            case 0:
                Console.Write($"Hoy es domingo");
                break;
            case 1:
                Console.Write($"Hoy es lunes");
                break;
            case 2:
                Console.Write($"Hoy es martes");
                break;

            case 3:
                Console.Write($"Hoy es miercoles");
                break;

            case 4:
                Console.Write($"Hoy es jueves");
                break;

            case 5:
                Console.Write($"Hoy es viernes");
                break;

            case 6:
                Console.Write($"Hoy es sabado");
                break;

            default:
                Console.Write($"{n} no es un dia de la semana");
                break;
        }


        Console.WriteLine("Indica un numero de mes: ");
        int mes = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.Write($"Estamos en enero");
                break;
            case 2:
                Console.Write($"Estamos en febrero");
                break;

            case 3:
                Console.Write($"Estamos en marzo");
                break;

            case 4:
                Console.Write($"Estamos en abril");
                break;

            case 5:
                Console.Write($"Estamos en mayo");
                break;

            case 6:
                Console.Write($"Estamos en junio");
                break;

            case 7:
                Console.Write($"Estamos en julio");
                break;

            case 8:
                Console.Write($"Estamos en agosto");
                break;

            case 9:
                Console.Write($"Estamos en septiembre");
                break;

            case 10:
                Console.Write($"Estamos en octubre");
                break;

            case 11:
                Console.Write($"Estamos en noviembre");
                break;

            case 12:
                Console.Write($"Estamos en diciembre");
                break;

            default:
                Console.Write($"{mes} no es un mes");
                break;
        }


        Console.WriteLine("Indica un mes para saber cuantos dias tiene: ");
        string mesLetras = Console.ReadLine();

        switch (mesLetras)
        {
            case "enero":
                Console.Write($"{mesLetras} tiene 31 dias");
                break;
            case "febrero":
                Console.Write($"{mesLetras} tiene 28 dias");
                break;

            case "marzo":
                Console.Write($"{mesLetras} tiene 31 dias");
                break;

            case "abril":
                Console.Write($"{mesLetras} tiene 30 dias");
                break;

            case "mayo":
                Console.Write($"{mesLetras} tiene 31 dias");
                break;

            case "junio":
                Console.Write($"{mesLetras} tiene 30 dias");
                break;

            case "julio":
                Console.Write($"{mesLetras} tiene 31 dias");
                break;

            case "agosto":
                Console.Write($"{mesLetras} tiene 31 dias");
                break;

            case "septiembre":
                Console.Write($"{mesLetras} tiene 30 dias");
                break;

            case "octubre":
                Console.Write($"{mesLetras} tiene 31 dias");
                break;

            case "noviembre":
                Console.Write($"{mesLetras} tiene 30 dias");
                break;

            case "diciembre":
                Console.Write($"{mesLetras} tiene 31 dias");
                break;

            default:
                Console.Write($"Ups! {mesLetras} no es un mes");
                break;
        }
    }
}
