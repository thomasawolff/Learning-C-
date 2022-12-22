//using System;
//using System.Text;
//using System.Threading;
//using System.Xml.Serialization;

//namespace ExampleProjUserInput

// Readline recieves user input
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Type some text: ");
//            string userInput = Console.ReadLine();
//            System.Diagnostics.Debug.WriteLine(userInput);
//        }
//    }
//}


//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("g = green, r = red, b = blue, w = white");
//            int x = Console.Read();
//            char userInput = Convert.ToChar(x);

//            while (userInput != 'z')
//            {
//                switch (userInput)
//                {
//                    case 'g':
//                        Console.BackgroundColor = ConsoleColor.Green;
//                        break;
//                    case 'r':
//                        Console.BackgroundColor = ConsoleColor.Red;
//                        break;
//                    case 'b':
//                        Console.BackgroundColor = ConsoleColor.Blue;
//                        break;
//                    case 'w':
//                        Console.BackgroundColor = ConsoleColor.White;
//                        break;
//                    default:
//                        break;
//                }
//                Console.Clear();
//                Console.WriteLine("g = green, r = red, b = blue, w = white");
//                x = Console.Read();
//                userInput = Convert.ToChar(x);
//            }
//        }
//    }
//}


//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            ConsoleKeyInfo keyInfo;
//            Console.TreatControlCAsInput = true; // This way inputs will be treated as inputs to this program and not affect the console

//            do
//            {
//                keyInfo = Console.ReadKey();

//                if((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
//                    Console.Write("ALT+");

//                if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
//                    Console.Write("SHIFT+");

//                if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
//                    Console.Write("SHIFT+");

//            } while(keyInfo.Key != ConsoleKey.Escape) // Gets us the console key that was pressed, keyChar gets the unicode char for key pressed
//                                                      // modifers check if a modifier was pressed
//        }
//    }
//}


//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Please enter a number: ");
//            do
//            {
//                string userInput = Console.ReadLine();
//                int number;

//                if(!int.TryParse(userInput, out number))
//                {
//                    Console.ForegroundColor = ConsoleColor.Red;
//                    Console.WriteLine("You entered invalid Input!");
//                    Console.ResetColor();
//                    Console.WriteLine("\n Please enter a new number: ");
//                }
//                else
//                {
//                    Console.WriteLine("\n Thanks! Enter another number: ");
//                }
//            } while (true);
//        }

//    }
//}

//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Example3.txt";
//            if(!File.Exists(path))
//            {
//                File.Create(path).Close();
//            }

//            FileStream fs = File.Open(path, FileMode.Append);
//            byte[] info = new UTF8Encoding(true).GetBytes("Hello World! ");
//            fs.Write(info, 0, info.Length);
//            fs.Close();

//            StreamReader sr = new StreamReader(path);
//            string fileText = sr.ReadToEnd();   
//            System.Diagnostics.Debug.WriteLine(fileText);
//        }
//    }
//}

// File I/O Exceptions:
// Data Property: a collection of key, value pairs that have additional information about the exception
// HelpLink property: can be used to get or set a link to the help file associated with this exception
// HResult property lets us get or set a numerical value that is assigned to a specific exception
// InnerException property gets the exception instance that caused the current exception
// Message property gets or sets the name of the application or object that caused the error
// Source property gets or sets the name of the property that caused the error
// StackTrace property gets a string representation of the call stack so that we can examine it and
// get a better picture of the calls leading up to the exception to determine what caused it.
// TargetSite property gets the method that throws the current exception


//{
//    class Program
//    {
//        static char[] spaces = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
//        static int player = 1;
//        static int choice;
//        static int flag;

//        static void DrawBoard()
//        {
//            Console.WriteLine("        |      |      ");
//            Console.WriteLine("  {0}   | {1}  | {2}  ", spaces[0], spaces[1], spaces[2]);
//            Console.WriteLine("________|______|______");
//            Console.WriteLine("        |      |      ");
//            Console.WriteLine("  {0}   | {1}  | {2}  ", spaces[3], spaces[4], spaces[5]);
//            Console.WriteLine("________|______|______");
//            Console.WriteLine("        |      |      ");
//            Console.WriteLine("  {0}   | {1}  | {2}  ", spaces[6], spaces[7], spaces[8]);
//            Console.WriteLine("________|______|______");
//        }

//        static int CheckWin()
//        {
//            if (spaces[0] == spaces[1] &&
//                spaces[1] == spaces[2] ||// straight line win
//                spaces[3] == spaces[4] &&
//                spaces[4] == spaces[5] || // straight line win
//                spaces[6] == spaces[7] &&
//                spaces[7] == spaces[8] || // straight line win
//                spaces[0] == spaces[3] &&
//                spaces[3] == spaces[6] || // diagonal line win
//                spaces[1] == spaces[4] &&
//                spaces[4] == spaces[7] || // diagonal line win
//                spaces[2] == spaces[5] &&
//                spaces[5] == spaces[8] || // diagonal line win
//                spaces[0] == spaces[4] &&
//                spaces[4] == spaces[8] || // diagonal line win
//                spaces[2] == spaces[4] &&
//                spaces[4] == spaces[6])
//            {
//                return 1;
//            }

//            else if (spaces[0] != '1' &&
//                spaces[1] != '2' &&
//                spaces[2] != '3' &&
//                spaces[3] != '4' &&
//                spaces[4] != '5' &&
//                spaces[5] != '6' &&
//                spaces[6] != '7' &&
//                spaces[7] != '8' &&
//                spaces[8] != '9')
//            {
//                return -1; // All spaces are occupied
//            }
//            else
//            {
//                return 0;
//            }
//        }

//        /// <Summary>
//        /// This function draws an X on the game board
//        /// </Summary>
//        /// <param name="pos"></param

//        static void DrawX(int pos)
//        {
//            spaces[pos] = 'X';
//        }

//        /// <Summary>
//        /// This function draws an O on the game board
//        /// </Summary>
//        /// <param name="pos"></param

//        static void DrawO(int pos)
//        {
//            spaces[pos] = 'O';
//        }

//        /// <Summary>
//        /// This function is the main game loop
//        /// </Summary>
//        /// <param name="pos"></param

//        public static void Main(string[] args)
//        {
//            do
//            {
//                Console.Clear(); // Clears the console
//                Console.WriteLine("Player 1: X and Player 2 : O" + "\n");
//                if(player % 2 == 0)
//                {
//                    Console.WriteLine("Player 2's turn");
//                }
//                else
//                {
//                    Console.WriteLine("Player 1's turn");
//                }
//                Console.WriteLine("\n");
//                DrawBoard();
//                choice = int.Parse(Console.ReadLine()) - 1;

//                if (spaces[choice] != 'X' &&
//                    spaces[choice] != 'O')
//                {
//                    if (player % 2 == 0)
//                    {
//                        DrawO(choice);  
//                    }

//                    else
//                    {
//                        DrawX(choice);
//                    }
//                    player++;
//                }
//                else
//                {
//                    Console.WriteLine("Sorry the row {0} is already marked with {1} \n", choice, spaces[choice]);
//                    Console.WriteLine("Please wait 2 seconds, the board is loading again...");
//                    Thread.Sleep(2000);
//                }

//                flag = CheckWin();
//            } while (flag != 1 && flag != -1);

//            Console.Clear();
//            DrawBoard();

//            if(flag == 1)
//            {
//                Console.WriteLine("Player {0} has won", (player % 2) + 1);
//            }
//            else
//            {
//                Console.WriteLine("Tie Game");
//            }

//            Console.ReadLine();
//        }
//    }
//}