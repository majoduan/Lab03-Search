using System.Diagnostics;
namespace BinarySearch;
//Dueñas Mateo

class Program
{
    static void Main1(string[] args)
    {
        int[] A_Bin = { -8, 4, 5, 9, 12, 18, 25, 40, 60, 54, 17, 78, 65, 4, 1, -47, -67, -13, 2, 20 };
        int n = 20, buscar = 0;
        Console.WriteLine(" --- ALGORITMO DE BUSQUEDA BINARIA --- ");
        Console.WriteLine("Arreglo desordenado: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write("A[" + (i + 1) + "] = " + A_Bin[i] + "\n");
        }

        Console.WriteLine("");
        Array.Sort(A_Bin);
        Console.WriteLine("Arreglo ordenado: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write("A[" + (i + 1) + "] = " + A_Bin[i] + "\n");
        }

        Console.WriteLine("");
        Console.Write("Ingrese el elemento a buscar: ");
        buscar = Convert.ToInt32(Console.ReadLine());
        int posicionEncontrada = busquedaBinaria(A_Bin, n, buscar);
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        if (posicionEncontrada != -1)
            Console.WriteLine("Elemento encontrado en posicion: " + (posicionEncontrada + 1));
        else
            Console.WriteLine("Elemento no encontrado");

        stopwatch.Stop();
        Console.WriteLine($"Tiempo: {stopwatch.Elapsed.TotalMilliseconds} ms");
    }

    static int busquedaBinaria(int[] lista, int n, int clave)
    {
        int central = 0, bajo = 0, alto = n - 1;
        int valorCentral;

        while (bajo <= alto)
        {
            central = (bajo + alto) / 2;
            /* indice de elemento central */
            valorCentral = lista[central];
            /* valor del indice central */

            if (lista[central] == clave)
                return central; /* encontrado, devuelve posicion */
            else if (clave < lista[central])
                alto = central - 1; /* ir a sublista inferior */
            else
                bajo = central + 1; /* ir a sublista superior */
        
        }

        return -1;
        /* elemento no encontrado */
    }

    static int BusquedaBinaria(int[] lista, int n, int clave)
    {
        int bajo = 0, alto = n - 1, central = 0;
        bool encontrado = false;
        
        while ((bajo <= alto) && (!encontrado))
        {
            central = (bajo + alto) / 2;

            if (lista[central] == clave)
                encontrado = true;             // éxito en la búsqueda
            else if (clave < lista[central]) // a lo bajo del central
                alto = central - 1;
            else                            // a la alto del central
                bajo = central + 1;

        }

        return encontrado ? central : -1; // central si encontrado -1 otro caso
    }
}


