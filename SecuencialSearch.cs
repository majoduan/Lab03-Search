using System.Diagnostics;
namespace Lab03_Search;
//Dueñas Mateo
class SecuencialSearch
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Stopwatch stopwatch = new Stopwatch();
        int[] A_Sec = new int[100];
        int[] randomNum = new int[50];
        int numExitos = 0, numFallos = 0;

        //100 enteros aleatorios en el rango de 1 a 200
        for (int i = 0; i < A_Sec.Length; i++)
        {
            A_Sec[i] = random.Next(1, 201);
        }

        Array.Sort(A_Sec);
        Console.WriteLine(" --- Array de 100 Enteros Aleatorios ---");
        for (int i = 0; i < A_Sec.Length; i++)
        {
            Console.Write(A_Sec[i] + ", ");
        }
        Console.WriteLine("\n");

        //Búsqueda de 50 enteros seleccionados aleatoriamente (iguales o distintos)

        stopwatch.Start();
        for (int i = 0; i < (A_Sec.Length/2); i++)
        {
            randomNum[i] = random.Next(1, 51);
        int posicionEncontrada = BusquedaSecuencial(A_Sec, randomNum[i]);

            if (posicionEncontrada != -1)
                numExitos++;
            else
            numFallos++;

        }
        stopwatch.Stop();

        Array.Sort(randomNum);
        Console.WriteLine(" --- 50 enteros aleatorios a buscar ---");
        for (int i = 0; i < (A_Sec.Length/2); i++)
        {
            Console.Write(randomNum[i] + ", ");
        }
        Console.WriteLine("\n");
        Console.WriteLine("El numero de busquedas exitosas es: "+ numExitos);
        Console.WriteLine("El numero de busquedas fallidas es: "+ numFallos);
        Console.WriteLine("El porcentaje de exito es: " + (numExitos*100)/50 + "%");
        Console.WriteLine("El porcentaje de fallo es: " + (numFallos*100)/50 + "%");
        Console.WriteLine($"Tiempo: {stopwatch.Elapsed.TotalMilliseconds} ms");
    }
    
    static int BusquedaSecuencial(int[] array, int clave)
    {
        for (int i = 0; i < array.Length; i++) if (array[i] == clave) return i;
        return -1;
    }
}