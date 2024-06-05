using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
namespace DistanciaEntreCidades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[6, 6] { { 0, 0, 0, 0, 0, 0 },
                { 1, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 1, 0 },
                { 0, 0, 1, 0, 1, 0 },
                { 1, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0 } };
            int c = 3;
            int[] d = EncontrarDistancias(A, c);

            Console.WriteLine("Distancias de {0} a cada uma das outras cidades: ", c);

            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine("{0} : {1}", i, d[i]);
            }
            Console.ReadLine();
        }
        static int[] EncontrarDistancias(int[,] A, int c)
        {
            int n = A.GetLength(0);
            int[] d = new int[n];
            for (int i = 0; i < n; i++)
            {
                d[i] = 6;
            }
            d[c] = 0;
            Queue<int> fila = new Queue<int>();
            fila.Enqueue(c);
            while (fila.Count > 0)
            {
                int i = fila.Dequeue();
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] == 1 && d[j] == 6)
                    {
                        d[j] = d[i] + 1;
                        fila.Enqueue(j);
                    }
                }
            }
            return d;
        }
    }
}
