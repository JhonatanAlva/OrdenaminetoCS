using System;

namespace OrdenacionInsercion
{
    using System;
    using System.Linq;
 
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingresa los numeros a ordenar separados por comas(,) y presiona Enter.");
            int[] numero = Console.ReadLine().Replace(" ","").Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            Console.WriteLine();
            Console.WriteLine("ordenado:");
            Console.WriteLine(string.Join(",", Ordenar(numero)));
            Console.WriteLine();
            Console.WriteLine("Presiona una tecla para salir.");
            Console.ReadKey();
        }
        private static int[] Ordenar(int[] numero)
        {
            int auxiliar;
 
            for (int i = 1; i < numero.Length; i++)
            {
                auxiliar = numero[i];
 
                for (int j = i - 1; j >= 0 && numero[j] > auxiliar; j--)
                {
                    numero[j + 1] = numero[j];
                    numero[j] = auxiliar;
                }
            }
 
            return numero;
        }
    }
}