using System;

namespace Exerciciomatriz02
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicoesMatriz matriz = new PosicoesMatriz();
            int linhas = int.Parse(Console.ReadLine());
            int colunas = int.Parse(Console.ReadLine());

            int[,] mat = new int[linhas, colunas];
            Console.WriteLine();
            Console.Write("Celulas da matriz: ");
            Console.WriteLine(mat.Length);
            Console.WriteLine();
            for(int i = 0; i< linhas; i++)
            {
                string[] values = Console.ReadLine().Split(" ");
                for(int j=0; j< colunas; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Informe um numero para consulta: ");
            int numeroConsulta = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    
                    if (mat[i, j] == numeroConsulta)
                    {
                        Console.WriteLine("Position of " + numeroConsulta + ": [" + i + "," + j + "]");
                        Console.WriteLine();

                        if (j > 0)
                        {
                            Console.WriteLine("LEFT: "+mat[i, j - 1]);
                        }

                        if ((j + 1) < colunas)
                        {
                            Console.WriteLine("RIGHT: "+mat[i, j + 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("UP: "+mat[i - 1, j]);
                        }

                        if ((i + 1) < linhas)
                        {
                            Console.WriteLine("DOWN: "+mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
