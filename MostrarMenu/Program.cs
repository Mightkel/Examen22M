using System.Linq.Expressions;

int opcion = 0;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("=== MENÚ DE OPCIONES ===");
Console.WriteLine("1. Registrar productos");
Console.WriteLine("2. Mostrar productos");
Console.WriteLine("3. Calcular total vendido");
Console.WriteLine("4. Mostrar producto mas vendido");
Console.WriteLine("5. Mostrar promedio de ventas");
Console.WriteLine("6. Salir");
Console.ResetColor();
try
{
    opcion = int.Parse(Console.ReadLine()!);
}
catch(FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ERROR, Ingreso un dato inválido");
    Console.ResetColor();
    return;
}

switch (opcion)
{
    
        case 1:

        case 2:

        case 3:

        case 4:

        case 5:

        case 6:
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Fin del programa");
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
        Console.ResetColor();
        break;
        default:
        Console.WriteLine("ERROR, Ingreso un dato invalido.");
        break;
    
}
