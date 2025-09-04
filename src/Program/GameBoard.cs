namespace Ucu.Poo.GameOfLife;
public class GameBoard
{
<<<<<<< HEAD
    private bool[,] gameBoard;
    
    public int boardWidth => gameBoard.GetLength(0);
    public int boardHeight => gameBoard.GetLength(1);

=======
    private bool[,] gameBoard = board.txt;

    public int boardWidth = gameBoard.GetLength(0);
    public int boardHeight = gameBoard.GetLength(1);

>>>>>>> feature-gameboard
    public GameBoard(int width, int height)
    {
        gameBoard = new bool[width, height];
    }

    public bool GetCell(int x, int y)
    {
        return gameBoard[x, y];
    }

    public void SetCell(int x, int y, bool value)
    {
        gameBoard[x, y] = value;
    }

    public GameBoard Clone()
    {
        GameBoard cloneboard = new GameBoard(boardWidth, boardHeight);
        for (int x = 0; x < boardWidth; x++)
        {
            for (int y = 0; y < boardHeight; y++)
            {
                cloneboard.SetCell(x, y, GetCell(x, y));
            }
        }
        return cloneboard;
    }
<<<<<<< HEAD
}
=======
    
    public void UpdateBoard()
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
                        if (i >= 0 && i < boardWidth &&
                            j >= 0 && j < boardHeight &&
                            gameBoard[i, j])
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (gameBoard[x, y])
                    aliveNeighbors--; 

                if (gameBoard[x, y] && aliveNeighbors < 2)
                    cloneboard[x, y] = false; 
                else if (gameBoard[x, y] && aliveNeighbors > 3)
                    cloneboard[x, y] = false; 
                else if (!gameBoard[x, y] && aliveNeighbors == 3)
                    cloneboard[x, y] = true; 
                else
                    cloneboard[x, y] = gameBoard[x, y]; 
            }
        }

        gameBoard = cloneboard;
    }
}
>>>>>>> feature-gameboard
