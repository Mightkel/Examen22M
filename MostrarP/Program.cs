//Mostrar todos los productos registrados, dentro de la matriz, donde la primera columna es el nombre del   producto, la segunda columna es el precio del producto y la tercera columna es la cantidad del producto.


using System;
using System.Collections.Generic;   

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese el nombre del producto:");
    string nombreProducto = Console.ReadLine();

    Console.WriteLine("Ingrese el precio del producto:");
    decimal precioProducto = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la cantidad del producto:");
    int cantidadProducto = int.Parse(Console.ReadLine());

    // Aquí puedes almacenar los datos en una matriz o lista según tus necesidades
    // Por ejemplo, podrías usar una lista de objetos para almacenar los productos
}


for (int i = 0; i < 3; i++)
{
    // Aquí puedes mostrar los productos almacenados en la matriz o lista
    // Por ejemplo, si usaste una lista de objetos, podrías iterar sobre ella para mostrar los productos
}