using System;

namespace Exercicio4
{
    class Program
    {
        static void leMatriz(int [,] matriz){
            for(int l = 0; l < matriz.GetLength(0); l++){
                for(int c = 0; c < matriz.GetLength(1); c++){
                    Console.Write("{0}:{1} = ", l+1, c+1);
                    matriz [l,c] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void somaMatriz(int [,] matriz){
            int rowSum = 0, colSum = 0, contCol = 0;
            for(int l = 0; l < matriz.GetLength(0); l++){
                for(int c = 0; c < matriz.GetLength(1); c++){

                    for(int y = 0; y < matriz.GetLength(0); y++){
                        colSum += matriz[y, c];
                    }
                    if(contCol < matriz.GetLength(1)){
                        Console.WriteLine("Soma da coluna {0} = {1}", c+1, colSum);
                        colSum = 0;   
                        contCol += 1;
                    }
                }

                for(int i = 0; i < matriz.GetLength(1); i++){
                    rowSum += matriz[l, i];
                }
                Console.WriteLine("Soma da linha {0} = {1}", l+1, rowSum);
                rowSum = 0;
            }
        }

        static void Main(string[] args)
        {
            int [,] matriz = new int [5,3];
            leMatriz(matriz);
            somaMatriz(matriz);
        }
    }
}