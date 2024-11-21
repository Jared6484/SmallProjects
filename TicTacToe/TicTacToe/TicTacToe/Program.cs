
namespace TicTacToe
{
    internal class Program
    {
        static string[] gridNums = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static int numTurns = 0;
        static void Main(string[] args)
        {

            bool isPlayerOne = true;

            while (!IsWinner() && numTurns != 9)  //Checks for winner and if there is a tie. 
            {
                PrintGrid();
                if (isPlayerOne)
                {
                    Console.WriteLine("It's Player 1's turn ! \n");
                }
                else
                {
                    Console.WriteLine("It's Player 2's turn ! \n");
                }
                string choice = Console.ReadLine();

                //make this a Try Catch
                if (gridNums.Contains(choice) && choice != "x" && choice != "o")
                {
                    int gridNumIndex = Convert.ToInt32(choice) - 1;

                    if (isPlayerOne)
                    {
                        gridNums[gridNumIndex] = "X";
                    }
                    else
                    {
                        gridNums[gridNumIndex] = "O";
                    }
                    numTurns++;
                }
                isPlayerOne = !isPlayerOne;  // if it is false, then it will be true.  If true, then changes to false.             
            }
            if (IsWinner())
            {
                PrintGrid();
                if (isPlayerOne = true)
                { Console.WriteLine("Player 1, You Won !!  * ! * ! "); }
                else
                { Console.WriteLine("Player 2, You Won !!  * ! * ! "); }
            }
            else
            { Console.WriteLine("It's a tie..."); }
            Console.WriteLine();
        }

        public static bool IsWinner()
        {
            bool row1 = gridNums[0] == gridNums[1] && gridNums[1] == gridNums[2];
            bool row2 = gridNums[3] == gridNums[4] && gridNums[4] == gridNums[5];
            bool row3 = gridNums[6] == gridNums[7] && gridNums[7] == gridNums[8];
            bool col1 = gridNums[0] == gridNums[3] && gridNums[3] == gridNums[6];
            bool col2 = gridNums[1] == gridNums[4] && gridNums[4] == gridNums[7];
            bool col3 = gridNums[2] == gridNums[5] && gridNums[5] == gridNums[8];
            bool diagDown = gridNums[0] == gridNums[4] && gridNums[4] == gridNums[8];
            bool diagUp = gridNums[6] == gridNums[4] && gridNums[4] == gridNums[2];

            return row1 || row2 || row3 || col1 || col2 || col3 || diagDown || diagUp;
        }

        public static void PrintGrid()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        Console.Write("  " + gridNums[i * 3 + j]); // e.g. 0 *3 = 0 +j =0+0 = index 0 = 1 || e.g. 2nd row 2*3 = 6 +j = 6 +0 == 6th index 
                    }
                    else
                    {
                        Console.Write("  " + gridNums[i * 3 + j] + " | ");
                    }

                }
                Console.WriteLine();
                Console.WriteLine("__________________");
                // Console.WriteLine();
            }

        }
    }
}
