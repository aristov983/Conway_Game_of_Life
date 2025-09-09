using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
namespace Ucu.Poo.GameOfLife;

public class PrintBoard
{
    public static void Print(bool[,] board, int height, int width)
    {
        Console.Clear();
        StringBuilder s = new StringBuilder();
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (board[x, y])
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }

            s.Append("\n");
        }
        Console.WriteLine(s.ToString());
    }
}