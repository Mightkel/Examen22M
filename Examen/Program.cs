int[] cantidades = new int[10];
double[] precios = new double[10];
string[] productos = new string[10];
int contador = 0;
double total = 0;
while (true)
{
    //menu
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
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ERROR, Ingreso un dato inválido");
        Console.ResetColor();
        return;
    }

    switch (opcion)
    {

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

        case 2:
            //validar si se ingresaron productos
            if (contador == 0)
            {
                Console.WriteLine("No se ingresaron productos.");
                return;
            }
            //mostrar productos registrados
            Console.WriteLine("\nProductos registrados:");
            Console.WriteLine("Producto\tPrecio\tCantidad\t");
            for (int i = 0; i < contador; i++)
            {
                double subtotal = precios[i] * cantidades[i];
                total += subtotal;
                Console.WriteLine($"{productos[i]}\tC${precios[i]:F2}\t{cantidades[i]}\t");
            }


            break;

        case 3:
            Console.WriteLine($"\nTotal ventas: C${total:F2}");
            break;
        case 4:

        case 5:

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
    }
}