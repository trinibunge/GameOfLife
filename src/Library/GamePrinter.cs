/*
La clase GamePrinter se encarga únicamente de mostrar en consola el estado del tablero y actualizarlo en cada iteración.
Respecto al SRP, cumple con él porque su única responsabilidad es la visualización del juego. No aplica reglas ni carga información, 
solo imprime el tablero.
En cuanto al patrón Expert, no sería la experta en los datos del tablero, ya que depende de GameBoard para obtenerlos. 
Sin embargo, sí es la experta en cómo mostrar esos datos en consola, ya que conoce el formato de salida y cómo representarlo. 
Por lo tanto, cumple el principio Expert en el contexto de la presentación.
 */

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