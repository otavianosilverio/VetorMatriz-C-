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
            // vetor
            int[] idade = new int[10];
            
            idade[0] = 20;
            idade[1] = 30;

           
            for (int x = 0; x < idade.Length; x++)
            {
               idade[x] = objeto.Next(1,15);
               Console.Write(idade[x] + "\n");

            }


            // Matriz
            int[ , ] notas = new int[2 , 5] ;
            int linha, coluna = 0;
            for (linha = 0; linha < 2; linha++)
            {
                for (coluna =0; coluna < 5; coluna++)
                {
                    notas[linha,coluna] = objeto.Next();
                }
            }
            for (linha = 0; linha < 2; linha++)
            {
                for (coluna = 0; coluna < 5; coluna++)
                {
                    Console.Write(notas[linha,coluna] + "\t");
                }
                Console.Write("\n");
            }


            Console.ReadKey();


        }
    }
}
