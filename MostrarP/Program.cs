﻿int[] cantidades = new int[10];
double[] precios = new double[10];
string[] productos = new string[10];
int contador = 0;
double total = 0;  

        case 4:
         if (contador == 0)
        {
            Console.WriteLine("No se ingresaron productos.");
            break;
        }   

            int maxCantidad = cantidades[0];   
            int indiceMax = 0;
            for (int i = 1; i < contador; i++)
            {
                if (cantidades[i] > maxCantidad)
                {
                    maxCantidad = cantidades[i];
                    indiceMax = i;
                }
            }
            Console.WriteLine($"Producto más vendido: {productos[indiceMax]} con {cantidades[indiceMax]} unidades vendidas.");
        break;
