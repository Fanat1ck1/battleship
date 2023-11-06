using System;

class BattleshipGame
{
    static char[,] grid = new char[10, 10];
    static int remainingShips = 5;

    static void Main()
    {
        InitializeGrid();
        PlaceShips();

        while (remainingShips > 0)
        {
            DisplayGrid();
            PlayTurn();
        }

        Console.WriteLine("You won! All ships have been sunk.");
    }

    static void InitializeGrid()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                grid[i, j] = ' ';
            }
        }
    }

    static void PlaceShips()
    {
        Random random = new Random();
        for (int ship = 0; ship < 5; ship++)
        {
            int x, y;
            do
            {
                x = random.Next(10);
                y = random.Next(10);
            } while (grid[x, y] == 'X');

            grid[x, y] = 'X';
        }
    }

    static void DisplayGrid()
    {
        Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 10; j++)
            {
                Console.Write(grid[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void PlayTurn()
    {
        Console.Write("Enter a row: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter a column: ");
        int y = int.Parse(Console.ReadLine());

        if (x < 0 || x > 9 || y < 0 || y > 9)
        {
            Console.WriteLine("Invalid coordinates. Please try again.");
        }
        else if (grid[x, y] == 'X')
        {
            Console.WriteLine("You've sunk a ship!");
            grid[x, y] = 'O';
            remainingShips--;
        }
        else if (grid[x, y] == 'O')
        {
            Console.WriteLine("You've already shot here.");
        }
        else
        {
            Console.WriteLine("Miss!");
            grid[x, y] = 'O';
        }
    }
}
