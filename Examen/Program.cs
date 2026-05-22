int[] cantidades = new int[10];
double[] precios = new double[10];
string[] productos = new string[10];
int contador = 0;
double total = 0;
case 1:
    //registro de productos
    Console.WriteLine("Registro de productos");
    Console.WriteLine("(Presione Enter en el nombre para terminar.)\n");

    while (contador < productos.Length)
    {
        Console.Write("Ingrese nombre del producto: ");
        string? nombre = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombre))
            break;

        productos[contador] = nombre;

        Console.Write("Ingrese precio: ");
        while (!double.TryParse(Console.ReadLine(), out precios[contador]))
            Console.Write("Precio inválido. Ingrese precio: ");

        Console.Write("Ingrese cantidad vendida: ");
        while (!int.TryParse(Console.ReadLine(), out cantidades[contador]))
            Console.Write("Cantidad inválida. Ingrese cantidad: ");

        contador++;
        Console.WriteLine("Producto registrado con éxito.\n");
    }
    //validar si se ingresaron productos
    if (contador == 0)
    {
        Console.WriteLine("No se ingresaron productos.");
        break;
    }
    break;

case 6:
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Fin del programa");
    Console.WriteLine("Presiona cualquier tecla para salir...");
    Console.ReadKey();
    Console.ResetColor();
    return;
default:
    Console.WriteLine("ERROR, Ingreso un dato invalido.");
    break;
