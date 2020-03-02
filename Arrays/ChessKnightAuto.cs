using System;

namespace ChessKnightAuto
{
    class Chess
    {
        private int[,] board = { {2,3,4,4,4,4,3,2 },
                                 {3,4,6,6,6,6,4,3 },
                                 {4,6,8,8,8,8,6,4 },
                                 {4,6,8,8,8,8,6,4 },
                                 {4,6,8,8,8,8,6,4 },
                                 {4,6,8,8,8,8,6,4 },
                                 {3,4,6,6,6,6,4,3 },
                                 {2,3,4,4,4,4,3,2 }};
        private int[] horizontal = { 2, 1, -1, -2, -2, -1, 1, 2 };
        private int[] vertical = { -1, -2, -2, -1, 1, 2, 2, 1 };
        private int currentRow = 0, currentColoumn = 0;
        private int tempRow = 0, tempColoumn = 0;
        private int number = 10;
        private int staticRow = 0, staticColoumn = 0;

        int moveNumber = 0;
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
            board[currentRow, currentColoumn] = 9;

        }
        public void DrawBoard()
        {
            for (int i = 0; i < Board_SIZE; i++)
            {
                Console.WriteLine("{0}.vertical={1} - {0}.horizontal={2}", i, vertical[i], horizontal[i]);
            }
            Console.WriteLine();

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


            while (moveNumber < Board_SIZE)
            {

                tempRow = currentRow;
                tempColoumn = currentColoumn;
                currentRow += vertical[moveNumber];
                currentColoumn += horizontal[moveNumber];

                if (currentRow < 0 || currentRow > 7 || currentColoumn < 0 || currentColoumn > 7)
                {
                    currentRow = tempRow;
                    currentColoumn = tempColoumn;
                    moveNumber++;
                    continue;
                }
                else if (number > board[currentRow, currentColoumn] && board[currentRow, currentColoumn] != 9)
                {
                    number = board[currentRow, currentColoumn];
                    staticRow = currentRow;
                    staticColoumn = currentColoumn;
                    Console.WriteLine(currentRow);


                }
                currentRow = tempRow;
                currentColoumn = tempColoumn;

                moveNumber++;


            }//end while
            currentRow = staticRow;
            currentColoumn = staticColoumn;
            moveNumber = 0;
            number = 10;
            board[staticRow, staticColoumn] = 9;
        }//end KnightMove


    }//end class Chess
    class ChessTest
    {
        public static void Main(string[] args)
        {
            Chess a = new Chess();
            a.PlaceKnight();
            a.DrawBoard();
            for (int i = 0; i < 64; i++)
            {
                a.KnightMove();
                a.DrawBoard();
            }
        }
    }
}
