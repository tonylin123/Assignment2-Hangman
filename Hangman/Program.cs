using System;
using static System.Random;
using System.Text;
using System.Collections.Generic;

namespace Hangman
{

    internal class Program
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
        Console.WriteLine("\n+---+");
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
        Console.WriteLine("\n+----+");
        Console.WriteLine("  O   |");
        Console.WriteLine(" /|\\  |");
        Console.WriteLine("  |   |");
        Console.WriteLine(" /    |");
        Console.WriteLine("/     |");
        Console.WriteLine("    ===");
    }
    else if (wrong == 8)
    {
        Console.WriteLine("\n+----+");
        Console.WriteLine("  O   |");
        Console.WriteLine(" /|\\  |");
        Console.WriteLine("  |   |");
        Console.WriteLine(" / \\  |");
        Console.WriteLine("/     |");
        Console.WriteLine("    ===");
    }
    else if (wrong == 9)
    {
        Console.WriteLine("\n+----+");
        Console.WriteLine("  O   |");
        Console.WriteLine(" /|\\  |");
        Console.WriteLine(" / \\  |");
        Console.WriteLine("/   \\ |");
        Console.WriteLine("    ===");
    }
  
    return;
}
        static void Main(string[] args)
        {
            //string[] strArr = new string[2] {"key","test"};
            int wrong = 10;
        for (int i = 0; i < wrong; i++)

    //Console.WriteLine("Loop nr. {0}",i+1);
   PrintHangman(i);
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