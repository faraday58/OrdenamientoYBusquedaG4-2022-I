using System;

namespace OrdenamientoYBusquedaG4_2022_I
{
    class Busqueda
    {
        public int Directa(int[] A, int X )
        {
            int N = A.Length;
            for(int i=0; i< N; i++)
            {
                if(  A[i]  == X   )
                {
                    return i;
                }                
            }

            return -1;

        }

    }
}
