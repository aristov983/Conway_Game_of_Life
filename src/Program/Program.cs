using System;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main()
        {
            bool[,] epochBoard = InitializateBoard.Initializate(); //Inicializa el tablero en base a un .txt
            int width = epochBoard.GetLength(0);
            int height = epochBoard.GetLength(1); 
            while (true) //Crea un bucle infinito que simula el paso del tiempo.
            {
                PrintBoard.Print(epochBoard, width, height); //Imprime el tablero
                epochBoard = Epoch.RunEpoch(epochBoard); //Genera la siguiente epoca y se lo asigna a epochBoard
                Thread.Sleep(300);
            }
        }
    }
}