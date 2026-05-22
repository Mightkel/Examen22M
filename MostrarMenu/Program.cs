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
                Console.WriteLine($"{productos[i]}\t{precios[i]:F2}\t{cantidades[i]}\t");
            }

            Console.WriteLine($"\nTotal ventas: {total:F2}");
            break;

        case 3:
               
            if (contador == 0)
            {
                 Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No se ingresaron productos. Vuelva al menú para registrar productos.");
                return;
                Console.ResetColor();
            
            }


            Console.WriteLine("--- CALCULAR TOTAL VENDIDO ---");
            double totalCalculado = 0;
            
            for (int i = 0; i < contador; i++)
            {
                totalCalculado += precios[i] * cantidades[i];
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"El monto total de todas las ventas es: ${totalCalculado:F2}");
            Console.ResetColor();
            Console.WriteLine();
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