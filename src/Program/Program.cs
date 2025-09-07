using System;
using Ucu.Poo.GameOfLife;

class Program
{
    static void Main()
    {
        // Cargar tablero
        GameBoard game = new GameBoard();

        // Crear el printer
        GamePrinter printer = new GamePrinter();

        // Arranca el bucle del juego
        printer.Print(game.gameBoard, game);
    }
}

