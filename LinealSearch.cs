using System.Diagnostics;
namespace Lab03_Search;
//Dueñas Mateo
class LinealSearch
{
    static void Main1(string[] args)
    {

        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Algoritmo de busqueda lineal");
        int[] A_Lin = { 10, 98, 14, 84, 18, 81, 20, 2, 24, 42, 28, 82, 32, 23, 36, 63, 40, 4, 19, 75 };
        Console.WriteLine("Arreglo Desordenado");

        for (int i = 0; i < A_Lin.Length; i++)
        {
            Console.Write("A[" + (i + 1) + "] = " + A_Lin[i] + "\n");
        }

        Console.Write("Ingrese un numero a buscar: ");
        int valorLeido = Convert.ToInt32(Console.ReadLine());
        stopwatch.Start();
        int posicionEncontrada = BusquedaLinealID(A_Lin, A_Lin.Length, valorLeido);

        if (posicionEncontrada != -1)
        {
            Console.WriteLine($"\nElemento encontrado en A[{posicionEncontrada}]={A_Lin[posicionEncontrada]}");
        }

        else
        {
            Console.WriteLine($"\nElemento no encontrado ");
        }

        stopwatch.Stop();
        Console.WriteLine($"Tiempo: {stopwatch.Elapsed.TotalMilliseconds} ms");
    }
    static int BusquedaLinealID(int[] array, int n, int clave)
    {
        int i;
        for (i = 0; i < n; i++) if (array[i] == clave) return i;
        return -1;
    }
}