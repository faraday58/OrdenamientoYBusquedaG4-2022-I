using System;

namespace OrdenamientoYBusquedaG4_2022_I
{
    class Ordenamiento
    {
        public static void Burbuja(int [] A)
        {
            int N = A.Length;
            // A={5,3,9,7,10,1}
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    //i=0
                    // A[1]  > A[0]      
                    //   3       5
                    if (!(A[i + 1] > A[i]))
                    {
                        // Aux=A[0]
                        // Aux=5
                        int Aux = A[i];
                        //A[0]=A[1]
                        //A[0]=3
                        A[i] = A[i + 1];
                        //A[1]= 5
                        A[i + 1] = Aux;

                    }
                }
            }

        }
    }
}
