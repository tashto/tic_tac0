// See https://aka.ms/new-console-template for more information
class TicTacToe
{
    private readonly char[,] board = new char[3, 3];
    private char currentPlayer = 'X';

    public TicTacToe()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = ' ';
            }
        }
    }

    public void Play(int x, int y)
    {
        board[x, y] = currentPlayer;

        if (currentPlayer == 'X')
        {
            currentPlayer = 'O';
        }
        else
        {
            currentPlayer = 'X';
        }
    }

    public bool IsWin()
    {
        // Check rows
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
            {
                return true;
            }
        }

        // Check columns
        for (int i = 0; i < 3; i++)
        {
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
            {
                return true;
            }
        }

        // Check diagonals
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
        {
            return true;
        }

        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
        {
            return true;
        }

        return false;
    }

    public bool IsDraw()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == ' ')
                {
                    return false;
                }
            }
        }

        return !IsWin();
    }

    public char[,] GetBoard()
    {
        return board;
    }

    public char GetCurrentPlayer()
    {
        return currentPlayer;
    }
}

class TicTacToeDisplay
{
    public static void PrintBoard(char[,] board)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(board[i, j]);
                if (j < 2)
                {
                    Console.Write("|");
                }
            }
            Console.WriteLine();
            if (i < 2)
            {
                Console.WriteLine("-+-+-");
            }
        }
    }
}