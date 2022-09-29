using System;
using static System.Random;
using System.Text;
using System.Collections.Generic;


namespace Hangman
{

    class Program
    {

        //draw a hangman
        static void PrintHangman(int wrong)
        {
            if (wrong == 0)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 1)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 2)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 3)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|  |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 4)
            {
                Console.WriteLine("\n+----+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("     |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 5)
            {
                Console.WriteLine("\n+----+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine(" |   |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 6)
            {
                Console.WriteLine("\n+----+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine(" |   |");
                Console.WriteLine("/    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 7)
            {
                Console.WriteLine("\n+-----+");
                Console.WriteLine("  O   |");
                Console.WriteLine(" /|\\  |");
                Console.WriteLine("  |   |");
                Console.WriteLine(" /    |");
                Console.WriteLine("/     |");
                Console.WriteLine("    ===");
            }
            else if (wrong == 8)
            {
                Console.WriteLine("\n+-----+");
                Console.WriteLine("  O   |");
                Console.WriteLine(" /|\\  |");
                Console.WriteLine("  |   |");
                Console.WriteLine(" / \\  |");
                Console.WriteLine("/     |");
                Console.WriteLine("    ===");
            }
            else if (wrong == 9)
            {
                Console.WriteLine("\n+-----+");
                Console.WriteLine("  O   |");
                Console.WriteLine(" /|\\  |");
                Console.WriteLine("  |   |");
                Console.WriteLine(" / \\  |");
                Console.WriteLine("/   \\ |");
                Console.WriteLine("    ===");
            }
            else if (wrong == 10)
            {
                Console.WriteLine("\n+-----+");
                Console.WriteLine("  O   |");
                Console.WriteLine("------|");
                Console.WriteLine(" /|\\  |");
                Console.WriteLine("  |   |");
                Console.WriteLine(" / \\  |");
                Console.WriteLine("/   \\ |");
                Console.WriteLine("    ===");
            }
            return;
        }
       


        private static int printWord(StringBuilder guessedLetters, String randomWord)
        {
            int counter = 0;
            int rightLetters = 0;
            Console.Write("\r\n");
            foreach (var c in randomWord)
            {
                //check guessed letter in the randomword string use contains function.
                if (guessedLetters.ToString().Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters++;
                }
                else
                {
                    Console.Write("  ");
                }
                counter ++;
            }
            //Console.Write("\r\n");
            return rightLetters;
        }

        private static void printLines(String randomWord)
        {
            Console.Write("\r");
            foreach (var c in randomWord)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                // dashline
                Console.Write("\u0305 ");
            }
        }
        // Restart or Exit
        static void Restart()
        {
            try
            {
                Console.Write("restart? (y/n): ");

                char restart_input = Convert.ToChar(Console.ReadLine().ToLower());

                if (restart_input == 'y')
                {

                    Console.Clear();
                }

                else if (restart_input == 'n')
                {
                    Console.Write("\n Press any key to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);


                }

                else if (restart_input != 'y' && restart_input != 'n')
                {
                    Console.WriteLine("\ninvalid input");
                    Restart();


                }

            }

            catch (Exception e)
            {
                Console.Write("\n" + e);
                Restart();
            }

        }






        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Welcome to hangman");
                Console.WriteLine("-----------------------------------------");

                Random random = new Random();
                List<string> wordDictionary = new List<string> { "book", "dog" ,"test" };
                int index = random.Next(wordDictionary.Count);
                // create a randdomword         
                String randomWord = wordDictionary[index];

                foreach (char c in randomWord)
                {
                    Console.Write("_ ");
                }

                int lengthOfWordToGuess = randomWord.Length;
                int amountOfTimesWrong = 0;
                StringBuilder currentLettersGuessed = new StringBuilder();
                int currentLettersRight = 0;

                while (amountOfTimesWrong != 10 && currentLettersRight != lengthOfWordToGuess)
                {
                    Console.Write($"\nLetters guessed so far: {currentLettersGuessed}");


                    // Prompt user for input
                    Console.Write("\nGuess a letter: ");


                   
                    String letterGuessed = Console.ReadLine();

                    if(letterGuessed.Length > 1)
                    {
                        if (letterGuessed.Equals(randomWord))
                        {
                            currentLettersRight = lengthOfWordToGuess;
                        }
                        else
                        {

                            Console.WriteLine("you guessed wrong");
                            amountOfTimesWrong++;

                            PrintHangman(amountOfTimesWrong);
                            Console.WriteLine(printWord(currentLettersGuessed, randomWord).ToString());
                           // Console.WriteLine(currentLettersRight);
                            printLines(randomWord);



                        }
                    }
                    
                    else
                    {


                        // Check if that letter has already been guessed
                        if (currentLettersGuessed.ToString().Contains(letterGuessed))
                        {
                            Console.Write("\r\n You have already guessed this letter");
                            PrintHangman(amountOfTimesWrong);
                            
                            printLines(randomWord.ToString());
                        }
                        else
                        {
                            // Check if letter is in randomWord
                            bool right = false;
                            /*for (int i = 0; i < randomWord.Length; i++)*/
                            if (randomWord.Contains(letterGuessed)) { right = true; }


                            // User is right
                            if (right)
                            {
                                PrintHangman(amountOfTimesWrong);
                                // Print word
                                currentLettersGuessed.Append(letterGuessed + " ");
                                currentLettersRight = printWord(currentLettersGuessed, randomWord);
                                Console.Write("\r\n");
                                printLines(randomWord);

                            }

                            // User was wrong 
                            else
                            {
                                amountOfTimesWrong++;
                                currentLettersGuessed.Append(letterGuessed + " ");
                                // Update the drawing
                                PrintHangman(amountOfTimesWrong);
                                // Print word
                                currentLettersRight = printWord(currentLettersGuessed, randomWord);
                                Console.Write("\r\n");
                                printLines(randomWord);

                            }
                        }
                    }

                    
                    
                }


                //win
                if (currentLettersRight == randomWord.Length)
                {
                    Console.WriteLine("\r\n");
                    Console.WriteLine("You Win! word was '{0}'", randomWord);
                }
                //lost
                else
                {
                    
                    Console.WriteLine("\r\nYou lost! word was '{0}'", randomWord);
                }

                Console.WriteLine("\r\n Thank you for playing");

                Restart();


            }

        }
    }
}



