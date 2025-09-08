/*
La clase BoardLoader tiene una única responsabilidad: cargar el tablero desde un archivo.
Por lo tanto, cumple con el principio SRP, ya que no se encarga ni de mostrar el tablero, ni de ejecutar
las reglas del juego, solo de leer y transformar la información a una matriz, responsabilidades relacionadas 
únicamente con la función de su clase.
Respecto al patrón Expert, esta clase también cumple porque conoce cómo acceder al archivo y 
cómo traducir su contenido en binario a una estructura de datos booleana. Es razonable que sea la "experta" 
en esa tarea,dado que tiene toda la información necesaria para realizarla sin depender de otras clases.  
*/
using System.IO;

namespace Ucu.Poo.GameOfLife;

public class BoardLoader
{
    public bool[,] LoadBoard(string url)
    {
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];

        for (int y = 0; y < contentLines.Length; y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if (contentLines[y][x] == '1')
                {
                    board[x, y] = true;
                }
            }
        }

        return board;
    }
}
    