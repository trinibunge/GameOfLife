/*
La clase GameBoard tiene como responsabilidad principal representar y actualizar el estado del tablero del juego de la vida. 
Esto significa que se encarga de aplicar las reglas de evolución de las células y modificar la estructura del tablero para 
la siguiente iteración del tiempo.
En cuanto al principio SRP, la clase se centra únicamente en gestionar la lógica del juego. 
No se ocupa de cargar datos externos como lo hace BoardLoader, ni de mostrar el resultado en pantalla, por lo que se 
considera que respeta el principio de responsabilidad única.
Respecto al patrón Expert, la clase cumple con él porque posee toda la información necesaria para decidir cómo deben cambiar 
las células de acuerdo con sus vecinos. Es decir, es la "experta" en aplicar las reglas del juego, ya que contiene tanto el 
tablero como los métodos para modificarlo.
 */
namespace Ucu.Poo.GameOfLife;

public class GameBoard
{
    BoardLoader loader;
    public bool[,] gameBoard; 
    int boardWidth;
    int boardHeight;
    
    public GameBoard()
    {
        loader = new BoardLoader();
        gameBoard = loader.LoadBoard("board.txt");
        boardWidth = gameBoard.GetLength(0);
        boardHeight = gameBoard.GetLength(1);
    }

    public void ActualizarTablero()
    {
        bool[,] cloneboard = new bool[boardWidth, boardHeight];

        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                int aliveNeighbors = 0;

                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && gameBoard[i, j])
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (gameBoard[x, y])
                {
                    aliveNeighbors--;
                }

                if (gameBoard[x, y] && aliveNeighbors < 2)
                {
                    cloneboard[x, y] = false;
                }
                else if (gameBoard[x, y] && aliveNeighbors > 3)
                {
                    cloneboard[x, y] = false;
                }
                else if (!gameBoard[x, y] && aliveNeighbors == 3)
                {
                    cloneboard[x, y] = true;
                }
                else
                {
                    cloneboard[x, y] = gameBoard[x, y];
                }
            }
        }
        gameBoard = cloneboard;
    }
}



