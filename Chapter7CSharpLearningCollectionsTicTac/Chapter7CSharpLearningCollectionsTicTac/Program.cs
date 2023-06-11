using System;
using System.ComponentModel;
using System.Linq;

namespace Chapter7CSharpLearningCollectionsTicTac
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int index = 1;
            bool winner = false;
            string[,] board = {
            {"1", "2", "3"},
            {"4", "5", "6" },
            {"7", "8", "9" }};
            int playerNumber = 0;
            string[] player = { "X", "O" };
            int number = 0;
            int[] options = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            while (winner != true)
            {
                Console.WriteLine("{0}|{1}|{2}", board[0,0], board[0,1], board[0,2]);
                Console.WriteLine("-----");
                Console.WriteLine("{0}|{1}|{2}", board[1, 0], board[1, 1], board[1, 2]);
                Console.WriteLine("-----");
                Console.WriteLine("{0}|{1}|{2}", board[2, 0], board[2, 1], board[2, 2]);
                switch (index%2)
                {
                    case 0:
                        playerNumber = 0;
                        break;
                    case 1:
                        playerNumber = 1;
                        break;
                }
                Console.WriteLine("{0}: Choose your field", player[playerNumber]);
       
                    number = Int32.Parse(Console.ReadLine());
                if (options.Contains(number))
                {
                    switch (number)
                    {
                        case 1:
                            board[0, 0] = player[playerNumber];
                            options = options.Where(val => val != number).ToArray();
                            index++;
                            break;
                        case 2:
                            board[0, 1] = player[playerNumber];
                            options = options.Where(val => val != number).ToArray();
                            index++;
                            break;
                        case 3:
                            board[0, 2] = player[playerNumber];
                            options = options.Where(val => val != number).ToArray();
                            index++;
                            break;
                        case 4:
                            board[1, 0] = player[playerNumber];
                            options = options.Where(val => val != number).ToArray();
                            index++;
                            break;
                        case 5:
                            board[1, 1] = player[playerNumber];
                            options = options.Where(val => val != number).ToArray();
                            index++;
                            break;
                        case 6:
                            board[1, 2] = player[playerNumber];
                            options = options.Where(val => val != number).ToArray();
                            index++;
                            break;
                        case 7:
                            board[2, 0] = player[playerNumber];
                            options = options.Where(val => val != number).ToArray();
                            index++;
                            break;
                        case 8:
                            board[2, 1] = player[playerNumber];
                            options = options.Where(val => val != number).ToArray();
                            index++;
                            break;
                        case 9:
                            board[2, 2] = player[playerNumber];
                            options = options.Where(val => val != number).ToArray();
                            index++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong number");
                }
                for (int i = 0; i<3; i++)
                {
                        //Console.WriteLine("{0}, {1}, {2}", board[i,0], board[i,1], board[i, 2]);
                        if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                        {
                            winner = true;
                            break;
                        }
                        
                }
                for (int i = 0; i < 3; i++)
                {
                    //Console.WriteLine("{0}, {1}, {2}", board[i, 0], board[i, 1], board[i, 2]);
                    if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                    {
                        winner = true;
                        break;
                    }

                }

                if (winner != true)
                {
                    winner = String.Equals(board[0, 0], board[1, 1]) && String.Equals(board[1, 1], board[2, 2]) || String.Equals(board[0, 2], board[1, 1]) && String.Equals(board[1, 1], board[2, 0]);
                }
                //Console.WriteLine(winner);
                Console.Clear();
            }
            Console.WriteLine("Player {0} win. To exit pres any key", player[playerNumber]);
            Console.ReadLine();
        }
    }
}
