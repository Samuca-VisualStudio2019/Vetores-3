using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];

            string[] Valores = Console.ReadLine().Split(" ");
            for(int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Valores[i]);
            }

            Valores = Console.ReadLine().Split(" ");
            for(int i = 0; i < N; i++)
            {
                B[i] = int.Parse(Valores[i]);
            }

            //1: Gerando vetor C
            int[] C = new int[N];
            for (int i = 0; i < N; i++)
            {
                C[i] = A[i] + B[i];
            }

            //2: Mostrando resultado na tela
            for(int i = 0; i < N; i++)
            {
                Console.Write(C[i] + " ");
            }
        }
    }
}
