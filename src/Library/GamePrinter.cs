using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class GamePrinter
{
    public void Print(bool[,] b, GameBoard game)
    {
        int width = b.GetLength(0);
        int height = b.GetLength(1);

        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (b[x, y])
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
            
            b = game.gameBoard;
            game.ActualizarTablero();
            
            Thread.Sleep(300);
        }
    }
}