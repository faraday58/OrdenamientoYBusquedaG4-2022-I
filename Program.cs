using System;

namespace OrdenamientoYBusquedaG4_2022_I
{
    class Program
    {
        static void Main()
        {
            int[] A = { 5, 3, 9, 7, 10, 1 };
            ImprimeArreglo(A);
            Ordenamiento.Burbuja(A);
            ImprimeArreglo(A);
            Console.ReadLine();

        }


        public int [] ArregloAleatorio(int N)
        {
            int[] A = new int[N];
            Random random = new Random();
            for(int i=0; i< N; i++)
            {
                A[i] = (int)(random.NextDouble()*1000);
            }
            return A;

        }


        public static void ImprimeArreglo(int [] A)
        {
            foreach(int elemento in A)
            {
                Console.Write("{0},", elemento);
            }
            Console.WriteLine();
        }
    }
}
