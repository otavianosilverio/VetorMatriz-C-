using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Random objeto = new Random(10);
            // Matriz - Lista Atividade 1
            //int[ , ] notas = new int[2 , 4] ;
            //int linha, coluna = 0;
            //int qtdecelulas = 0;
            // for (linha = 0; linha < 2; linha++)
            // {
            //     for (coluna =0; coluna < 4; coluna++)
            //     {
            //         notas[linha,coluna] = objeto.Next(1,20);
            // Verificar colunas com valores entre 10 e 15
            //        if ((notas[linha, coluna] >=10) && (notas[linha, coluna] <= 15))
            //        {
            //            qtdecelulas++;
            //        }
            // Console.Write(notas[linha, coluna] + "\t");
            //    }
            // Console.Write("\n");
            //  }
            //Console.Write(qtdecelulas + "\n");


            // Matriz - Lista Atividade 2
            //  int[,] notas = new int[10, 10];
            // int linha, coluna = 0;
            //  int somacoluna7 = 0, somalinha5 = 0;

            //  for (linha = 0; linha < 10; linha++)
            //  {
            //      for (coluna = 0; coluna < 10; coluna++)
            //      {
            //          notas[linha, coluna] = objeto.Next(1, 10);
            //          Console.Write(notas[linha, coluna] + "\t");
            //          somalinha5 = somalinha5 + notas[4, coluna];
            //      }
            //      somacoluna7 = somacoluna7 + notas[linha, 6];
            //      
            //       Console.Write("\n");
            //    }
            //    Console.Write("Soma Coluna 7"+somacoluna7+ "\n");
            //    Console.Write("Soma Linha 5" + somalinha5 + "\n");

            // Lista Questao 4

            int[,] matriz = new int[6, 6];
            int[] vetor = new int[6];
            int Maior = 0;
            int linha, coluna = 0;
            // Preenchendo a matriz
            for (linha = 0; linha < 6; linha++)
            {
                Maior = 0;
                for (coluna = 0; coluna < 6; coluna++)
                {
                      matriz[linha, coluna] = objeto.Next(1, 50);
                      Console.Write(matriz[linha, coluna] + "\t");
                    // Verificar se a linha da matriz é par
                    if (linha % 2 == 0)
                    {
                        // Linha para identiicando o numero maior
                        if (matriz[linha, coluna] > Maior)
                        {
                            Maior = matriz[linha, coluna];
                        }
                    }
                }
                Console.Write("\n");
                Console.Write("Maior da Linha "+Maior + "\t");
               
            }


                Console.ReadKey();


        }
    }
}
