using System;

namespace ticTacToeGame
{
    class Game
    {
        public static void boardDisplay(string[,] x) // METHOD FOR DISPLAYING GAME BOARD
        {
            for (int z = 0; z < 5; z++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Console.Write(x[z, y]);
                }
                Console.WriteLine("");
            }
        }
        public static bool IsSpaceTaken(string[,] x, int b, int y) // LOOKING TO SEE IF SPACE IS TAKEN 
        {
            bool z = true;
            if (x[b, y] != null)
            {
                z = true;
            }
            else if (x[b, y] == null)
            {
                z = false;
            }
            return z;
        }

        public static bool threeInARow(string[,] x, string y) // CHECKING FOR THREE IN A ROW
        {
            bool winner = false;
            if (x[0, 0] == y && x[0, 2] == y && x[0, 4] == y)
            {
                winner = true;
            }
            else if (x[2, 0] == y && x[2, 2] == y && x[2, 4] == y)
            {
                winner = true;
            }
            else if (x[4, 0] == y && x[4, 2] == y && x[4, 4] == y)
            {
                winner = true;
            }
            else if (x[0, 0] == y && x[2, 0] == y && x[4, 0] == y)
            {
                winner = true;
            }
            else if (x[0, 2] == y && x[2, 2] == y && x[4, 2] == y)
            {
                winner = true;
            }
            else if (x[0, 4] == y && x[2, 4] == y && x[4, 4] == y)
            {
                winner = true;
            }
            else if (x[0, 4] == y && x[2, 2] == y && x[4, 0] == y)
            {
                winner = true;
            }
            else if (x[0, 0] == y && x[2, 2] == y && x[4, 4] == y)
            {
                winner = true;
            }
            return winner;
        }


        static void Main(string[] args) // MAIN METHOD
        {
            string[,] currentPlays = new string[5, 5];
            string[,] board = {{ " ","|", " ", "|", " " },
                               {"-", "-", "-",  "-", "-"},
                               { " ","|", " ", "|", " " },
                               {"-", "-", "-",  "-", "-"},
                               { " ","|", " ", "|", " " } };
            byte counter = 1;


            do // MAIN GAME LOOP
            {
                string who = "";
                bool Oturn = false, Xturn = false;
                if (counter % 2 == 0)
                {
                    Oturn = true;
                    who = "O";
                }
                else if (counter % 2 != 0)
                {
                    Xturn = true;
                    who = "X";
                }
                counter++;

                Console.WriteLine("It is " + who + " turn. Where would you like to play?");
                boardDisplay(board);

                string input = Console.ReadLine();
                input = input.ToUpper();

                bool valid = true;
                do  // LOOP UNTIL A VALID INPUT IS GIVEN                                    
                {
                    input = input.ToUpper();

                    switch (input)
                    {
                        case "MIDDLE":
                            int l = 2, p = 2;
                            if (IsSpaceTaken(currentPlays, l, p) == false)
                            {
                                board[2, 2] = who; currentPlays[2, 2] = who;
                                valid = false;
                            }
                            else if (IsSpaceTaken(currentPlays, l, p) == true)
                            {
                                Console.WriteLine("That square is already taken. Please enter a valid square: ");
                                input = Console.ReadLine();
                                valid = true;
                            }
                            break;
                        case "MIDDLE LEFT":
                            l = 2; p = 0;
                            if (IsSpaceTaken(currentPlays, l, p) == false)
                            {
                                board[2, 0] = who; currentPlays[2, 0] = who;
                                valid = false;
                            }
                            else if (IsSpaceTaken(currentPlays, l, p) == true)
                            {
                                Console.WriteLine("That square is already taken. Please enter a valid square: ");
                                input = Console.ReadLine();
                                valid = true;
                            }
                            break;
                        case "MIDDLE RIGHT":
                            l = 2; p = 4;
                            if (IsSpaceTaken(currentPlays, l, p) == false)
                            {
                                board[2, 4] = who; currentPlays[2, 4] = who;
                                valid = false;
                            }
                            else if (IsSpaceTaken(currentPlays, l, p) == true)
                            {
                                Console.WriteLine("That square is already taken. Please enter a valid square: ");
                                input = Console.ReadLine();
                                valid = true;
                            }
                            break;
                        case "TOP LEFT":
                            l = 0; p = 0;
                            if (IsSpaceTaken(currentPlays, l, p) == false)
                            {
                                board[0, 0] = who; currentPlays[0, 0] = who;
                                valid = false;
                            }
                            else if (IsSpaceTaken(currentPlays, l, p) == true)
                            {
                                Console.WriteLine("That square is already taken. Please enter a valid square: ");
                                input = Console.ReadLine();
                                valid = true;
                            }
                            break;
                        case "TOP MIDDLE":
                            l = 0; p = 2;
                            if (IsSpaceTaken(currentPlays, l, p) == false)
                            {
                                board[0, 2] = who; currentPlays[0, 2] = who;
                                valid = false;
                            }
                            else if (IsSpaceTaken(currentPlays, l, p) == true)
                            {
                                Console.WriteLine("That square is already taken. Please enter a valid square: ");
                                input = Console.ReadLine();
                                valid = true;
                            }
                            break;
                        case "TOP RIGHT":
                            l = 0; p = 4;
                            if (IsSpaceTaken(currentPlays, l, p) == false)
                            {
                                board[0, 4] = who; currentPlays[0, 4] = who;
                                valid = false;
                            }
                            else if (IsSpaceTaken(currentPlays, l, p) == true)
                            {
                                Console.WriteLine("That square is already taken. Please enter a valid square: ");
                                input = Console.ReadLine();
                                valid = true;
                            }
                            break;
                        case "BOTTOM MIDDLE":
                            l = 4; p = 2;
                            if (IsSpaceTaken(currentPlays, l, p) == false)
                            {
                                board[4, 2] = who; currentPlays[4, 2] = who;
                                valid = false;
                            }
                            else if (IsSpaceTaken(currentPlays, l, p) == true)
                            {
                                Console.WriteLine("That square is already taken. Please enter a valid square: ");
                                input = Console.ReadLine();
                                valid = true;
                            }
                            break;
                        case "BOTTOM RIGHT":
                            l = 4; p = 4;
                            if (IsSpaceTaken(currentPlays, l, p) == false)
                            {
                                board[4, 4] = who; currentPlays[4, 4] = who;
                                valid = false;
                            }
                            else if (IsSpaceTaken(currentPlays, l, p) == true)
                            {
                                Console.WriteLine("That square is already taken. Please enter a valid square: ");
                                input = Console.ReadLine();
                                valid = true;
                            }
                            break;
                        case "BOTTOM LEFT":
                            l = 4; p = 0;
                            if (IsSpaceTaken(currentPlays, l, p) == false)
                            {
                                board[4, 0] = who; currentPlays[4, 0] = who;
                                valid = false;
                            }
                            else if (IsSpaceTaken(currentPlays, l, p) == true)
                            {
                                Console.WriteLine("That square is already taken. Please enter a valid square: ");
                                input = Console.ReadLine();
                                valid = true;
                            }
                            break;
                    }
                    
                } while (valid); // BREAKS ONCE PLAYER PROVIDES A VALID INPUT

                Console.Clear();

                if (threeInARow(currentPlays, who)) // CALLING THREE IN A ROW METHOD AT END OF EVERY TURN 
                {
                    Console.WriteLine(who + " Wins!");
                    boardDisplay(board);
                    break;
                }

            } while (true); // BREAKS ONCE THREE IN A ROW IS CALLED TRUE
        }
    }
}
