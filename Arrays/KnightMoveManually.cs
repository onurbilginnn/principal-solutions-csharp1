using System;

namespace ChessKnightMove
{
    class Chess
    {
        private int[,] board = new int[8, 8];
        private int[] horizontal = { 2, 1, -1, -2, -2, -1, 1, 2 };
        private int[] vertical = { -1, -2, -2, -1, 1, 2, 2, 1 };
        private int currentRow = 0, currentColoumn = 0;


        int moveNumber;
        private const int Board_SIZE = 8;
        public void PlaceKnight()
        {
            Console.WriteLine("Where you want to put the knight ?");
            Console.WriteLine("Enter vertical coordinate = ");
            currentRow = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; ;)
            {
                if (currentRow < 0 || currentRow > 7)
                {
                    Console.WriteLine("It is out of boundary!!! Enter vertical coordinate = ");
                    currentRow = Convert.ToInt32(Console.ReadLine());
                }
                else
                    break;
            }
            Console.WriteLine("Enter horizontal coordinate = ");
            currentColoumn = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; ;)
            {
                if (currentColoumn < 0 || currentColoumn > 7)
                {
                    Console.WriteLine("It is out of boundary!!! Enter horizontal coordinate = ");
                    currentColoumn = Convert.ToInt32(Console.ReadLine());
                }
                else
                    break;
            }
            board[currentRow, currentColoumn] = 1;

        }
        public void DrawBoard()
        {
            Console.WriteLine();
            board[currentRow, currentColoumn] = 1;
            for (int row = 0; row < Board_SIZE; row++)
            {
                for (int coloumn = 0; coloumn < Board_SIZE; coloumn++)
                    Console.Write(" " + board[row, coloumn]);
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        public int MoveNumber
        {
            get
            {
                return moveNumber;
            }
            set
            {
                moveNumber = value;
            }
        }
        public void KnightMove()
        {

            for (int i = 0; i < Board_SIZE; i++)
            {
               Console.WriteLine("{0}.move vertical = {1}\t {0}.move horizontal = {2}", i + 1,
               vertical[i], horizontal[i]);
            }               

            Console.WriteLine("Enter a move number between 1 - 8 = ");
            moveNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            if (moveNumber < 0 || moveNumber > 7)
                for (int j = 0; ;)
                {
                    Console.WriteLine("Enter a move number between 1 - 8 = ");
                    moveNumber = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (moveNumber >= 0 || moveNumber <= 7)
                    {
                        currentRow += vertical[moveNumber];
                        currentColoumn += horizontal[moveNumber];
                        if (currentRow < 0 || currentRow > 7 || currentColoumn < 0 || currentColoumn > 7)
                        {
                            Console.WriteLine("It is out of boundary!!! Please try again");
                            KnightMove();
                        }
                        else if (board[currentRow, currentColoumn] == 1)
                        {
                            Console.WriteLine("The target has been visited before!!! Please try again");
                            KnightMove();
                        }

                        board[currentRow, currentColoumn] = 1;
                        break;
                    }
                }
            else
            {
                currentRow += vertical[moveNumber];
                currentColoumn += horizontal[moveNumber];
                if (currentRow < 0 || currentRow > 7 || currentColoumn < 0 || currentColoumn > 7)
                {
                    Console.WriteLine("It is out of boundary!!! Please try again");
                    KnightMove();
                }
                else if (board[currentRow, currentColoumn] == 1)
                {
                    Console.WriteLine("The target has been visited before!!! Please try again");
                    KnightMove();
                }

                board[currentRow, currentColoumn] = 1;
            }

        }//end KnightMove

    }//end class Chess
    class ChessTest
    {
        public static void Main(string[] args)
        {
            Chess a = new Chess();
            a.PlaceKnight();
            a.DrawBoard();
            for (int i = 0; i < 100; i++)
            {
                a.KnightMove();
                a.DrawBoard();
            }


        }
    }
}
