# battleship
This code represents a simplified console-based Battleship game implemented in C#. The game is played on a 10x10 grid where the player's goal is to sink five hidden ships (represented by 'X' on the grid) by guessing their locations. Here's a brief description of the code:

The grid is a 10x10 character array used to represent the game board.

The remainingShips variable keeps track of the number of ships that are yet to be sunk. The game continues until all five ships are sunk.

The InitializeGrid function initializes the grid with empty spaces.

The PlaceShips function randomly places five ships on the grid.

The DisplayGrid function displays the current state of the game board, showing the grid with coordinates and marking hits and misses.

The PlayTurn function allows the player to input their guesses for the row and column. It checks if the input coordinates are valid and processes the guess, updating the grid accordingly.

The game continues in a loop, allowing the player to take turns until all ships are sunk. The player wins when all five ships have been successfully hit and sunk.

This code provides a basic example of a Battleship game and can serve as a starting point for building a more feature-rich version with additional gameplay elements.

# How to run
If you want to run via .cs:

1. Open a new terminal (Terminal -> New Terminal)
2. Type the command: dotnet run

Discord: tony888.8
