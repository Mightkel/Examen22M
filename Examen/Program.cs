
int[] cantidades = new int[10];
double[] precios = new double[10];
string[] productos = new string[10];
int contador = 0;

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

if (contador == 0)
{
    Console.WriteLine("No se ingresaron productos.");
    return;
}

Console.WriteLine("\nProductos registrados:");
Console.WriteLine("Producto\tPrecio\tCantidad\tSubtotal");
double total = 0;
for (int i = 0; i < contador; i++)
{
    double subtotal = precios[i] * cantidades[i];
    total += subtotal;
    Console.WriteLine($"{productos[i]}\t{precios[i]:F2}\t{cantidades[i]}\t{subtotal:F2}");
}

Console.WriteLine($"\nTotal ventas: {total:F2}");