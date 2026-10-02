using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
         // Unidad 1: Estructuras de control II
         // Unidad 2: Funciones II
         // Sesión 12: Instrucción while 30092026
         // Sintaxis: while
         // inicialización;
         // while (expresión)
         // {
         //     bloque de instrucciones
         //     iterador;
         // }
         // Iterar: repetir
         // Ejemplo 1: Ciclo ascendente (rango: 1-3)
         // m: variable de control
         int m = 1; // Inicialización
         while (m <= 3) // Expresión
            {
                // Bloque de instrucciones
                Console.WriteLine($"m: {m}");
                m += 1; // Iterador
            }
         // Ejercitación
         // Definir un ciclo  para imprimir tu nombre 5 veces. Nota: Para la expresión, utilizar el operador <.
         // a. Ciclo ascendente
         int n = 1;
         while (n < 6)
            {
                Console.WriteLine("Marcel");
                n += 1;
            }
         // b. Ciclo descendente  
         int d = 3;
         while (d >= 1)
            {
                Console.WriteLine($"d: {d}");
                d -= 1;
            }

         // c. Incrementos (ciclo ascendente)
         // Secuencia: 3 6 9 12 15 18
         int s = 3;
         while (s <= 18)
            {
                Console.WriteLine($"s: {s}");
                s += 3;
            }
         // d. Definir un ciclo para imprimir "331" 8 veces.
         // Nota. Para la solucion, definir un ciclo descendente con decrementos de 2 unidades.
         int a = 16;
         while (a > 0)
            {
                Console.WriteLine("331");
                a -= 2;
            }
         // Actividad 1: Ciclo infinito
         // 1. Definir un ciclo infinito ascendente.
         // 2. Definir un ciclo infinito descendente.
         // Nota: Para la solucion, utilizar el operador de diferencia.
         // Ascendente
         int x = 0;
         while (x >= -1)
            {
                Console.WriteLine($"x: {x}");
                x += 1;
            }
         // Descendente
         int z = 0;
         while (z != 1)
            {
                Console.WriteLine($"z: {z}");
                z -= 1;
            }            
        }
    }
}