using System;
using static System.Random;
using System.Text;
using System.Collections.Generic;

namespace Hangman
{

     class Program
    {


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
                Console.WriteLine(" ---- |");
                Console.WriteLine(" /|\\  |");
                Console.WriteLine("  |   |");
                Console.WriteLine(" / \\  |");
                Console.WriteLine("/   \\ |");
                Console.WriteLine("    ===");
            }
            return;
}
//        static void Main(string[] args)
//        {
//            //string[] strArr = new string[2] {"key","test"};
//            int wrong = 10;
//        for (int i = 0; i < wrong; i++)

//    //Console.WriteLine("Loop nr. {0}",i+1);
//   PrintHangman(i);
//}

//    }


private static int printWord(List<char> guessedLetters, String randomWord)
{
    int counter = 0;
    int rightLetters = 0;
    Console.Write("\r\n");
    foreach (char c in randomWord)
    {
        if (guessedLetters.Contains(c))
        {
            Console.Write(c + " ");
            rightLetters ++;
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
    foreach (char c in randomWord)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
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
          while(true)
            {

                Console.WriteLine("Welcome to hangman");
    Console.WriteLine("-----------------------------------------");
    
    Random random = new Random();
    List<string> wordDictionary = new List<string> { "sunflower", "house" };
    int index = random.Next(wordDictionary.Count);
    String randomWord = wordDictionary[index];

    foreach (char x in randomWord)
    {
        Console.Write("_ ");
    }

    int lengthOfWordToGuess = randomWord.Length;
    int amountOfTimesWrong = 0;
    List<char> currentLettersGuessed = new List<char>();
    int currentLettersRight = 0;

    while (amountOfTimesWrong != 10 && currentLettersRight != lengthOfWordToGuess)
    {
        Console.Write("\nLetters guessed so far: ");
        foreach (char letter in currentLettersGuessed)
        {
            Console.Write(letter + " ");
        }
        // Prompt user for input
        Console.Write("\nGuess a letter: ");
        char letterGuessed = Console.ReadLine()[0];
        // Check if that letter has already been guessed
        if (currentLettersGuessed.Contains(letterGuessed))
        {
            Console.Write("\r\n You have already guessed this letter");
           PrintHangman(amountOfTimesWrong);
            currentLettersRight = printWord(currentLettersGuessed, randomWord);
            printLines(randomWord);
        }
        else
        {
            // Check if letter is in randomWord
            bool right = false;
            for (int i = 0; i < randomWord.Length; i++) { if (letterGuessed == randomWord[i]) { right = true; } }

            // User is right
            if (right)
            {
                PrintHangman(amountOfTimesWrong);
                // Print word
                currentLettersGuessed.Add(letterGuessed);
                currentLettersRight = printWord(currentLettersGuessed, randomWord);
                Console.Write("\r\n");
                printLines(randomWord);
              
                    }
                    
            // User was wrong af
            else
            {
                amountOfTimesWrong += 1;
                currentLettersGuessed.Add(letterGuessed);
                // Update the drawing
                PrintHangman(amountOfTimesWrong);
                // Print word
                currentLettersRight = printWord(currentLettersGuessed, randomWord);
                Console.Write("\r\n");
                printLines(randomWord);
                
            }
        }
            }
            
            if (currentLettersRight == randomWord.Length)
                {
                Console.WriteLine("\r\n");
                Console.WriteLine("You Win! word was '{0}'", randomWord);
                }
                else
                {
                    Console.WriteLine("\r\n");
                    Console.WriteLine("You lost! word was '{0}'", randomWord);
                }
                
                Console.WriteLine("\r\nGame is over! Thank you for playing");
                Restart();


            }

        }
        }
}



//foreach (string item in strArr)
//{
//    Console.WriteLine(item);
//}

//int index = 0;
//while (index < strArr.Length)
//{
//    Console.WriteLine(strArr[index]);
//    index++;
//}
//for (int i = 0; i < strArr.Length; i++)
//{
//    Console.WriteLine(strArr[i]);
//}