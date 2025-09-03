namespace Ucu.Poo.GameOfLife;
public class GameBoard
{
    private bool[,] gameBoard;
    
    public int boardWidth => gameBoard.GetLength(0);
    public int boardHeight => gameBoard.GetLength(1);

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
}