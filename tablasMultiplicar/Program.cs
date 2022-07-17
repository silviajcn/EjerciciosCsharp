Console.WriteLine("\nTablas de multiplicar");
Console.Write("Ingresa un numero entre el 1 y el 12: ");

int number = Convert.ToInt32(Console.ReadLine());

if ( number >= 1 && number <= 12)
{
    Console.WriteLine($"\nLa tabla de multiplicar del numero {number} es: \n");
    for (int i = 1; i <= 12; i++)
    {
        int result = number * i;
        Console.WriteLine("{0} x {1} = {2}", number, i, result);
    }
    Console.WriteLine("");
}
else if ( number == 0)
{
    Console.WriteLine($"\nCuando multiplicas un numero por el numero {0} la multiplicacion siempre da como resultado un cero.\n");
}
else
{
    Console.WriteLine("\nEste numero no esta dentro del rango solicitado!\n");
}