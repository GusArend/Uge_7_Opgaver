﻿

namespace Uge_7_Opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] assignments = ["1. Opgave 1.1", "2. Opgave 1.2", "3. Opgave 1.3", "4. Opgave 2.1", "5. Opgave 2.2", "6. Opgave 2.3"];

            while (true)
            {
                Console.WriteLine("Hello! There are: " + assignments.Length + " assignments, choose one by pressing a number: ");
                foreach (string assignment in assignments)
                {
                    Console.WriteLine(assignment);
                }

                int userChoice = int.Parse(Console.ReadLine());
                Console.WriteLine("\n -------------------------------------------------------- \n");

                // opgave 1.1
                if (userChoice == 1)
                {
                    Console.WriteLine("Let me calculate the area of a rectangle for you!");
                    Console.Write("Please enter a Height: ");
                    double height = double.Parse(Console.ReadLine());

                    Console.Write("Please enter a Width: ");
                    double width = double.Parse(Console.ReadLine());
                   
                    double sum = height * width;
                    Console.WriteLine("The area is: " + sum);
                    Console.WriteLine("\n -------------------------------------------------------- \n");
                }
                // opgave 1.2
                else if (userChoice == 2)
                {
                    Console.WriteLine("Let me calculate the angle between two coordinates: ");
                    Console.Write("Enter the first coordinate as two number seperated by a . (ex. 1.1): ");
                    string firstCoord = Console.ReadLine();
                    Console.Write("Enter the second coordinate as two number seperated by a . (ex. 2.9): ");
                    string secondCoord = Console.ReadLine();
               
                    int x1 = int.Parse(firstCoord.Split(".")[0]);
                    int y1 = int.Parse(firstCoord.Split(".")[1]);
                    int x2 = int.Parse(secondCoord.Split(".")[0]);
                    int y2 = int.Parse(secondCoord.Split(".")[1]);
                    int sum = (y2 - y1) / (x2 - x1);

                    Console.WriteLine("The angle is: " + sum);
                    Console.WriteLine("\n -------------------------------------------------------- \n");
                }
                // opgave 1.3
                else if (userChoice == 3)
                {
                    Console.WriteLine("Let me calculate the angle between two coordinates: ");

                    Console.Write("Enter the first coordinate as two number seperated by a . (ex. 1.1): ");
                    string firstCoord = Console.ReadLine();
                    Console.Write("Enter the second coordinate as two number seperated by a . (ex. 2.9): ");
                    string secondCoord = Console.ReadLine();
              
                    double x1 = double.Parse(firstCoord.Split(".")[0]);
                    double y1 = double.Parse(firstCoord.Split(".")[1]);
                    double x2 = double.Parse(secondCoord.Split(".")[0]);
                    double y2 = double.Parse(secondCoord.Split(".")[1]);
                    double sum = (y2 - y1) / (x2 - x1);

                    Console.WriteLine("The angle is: " + sum);
                    Console.WriteLine("\n -------------------------------------------------------- \n");
                }
                // opgave 2.1
                else if (userChoice== 4)
                {
                    Console.WriteLine("Let me count the characters in a sentence: ");
                    Console.Write("Type your sentence: ");
                    string input = Console.ReadLine();

                    Console.WriteLine(input.Length + " characters (including spaces)");
                    Console.WriteLine("\n -------------------------------------------------------- \n");
                }
                // opgave 2.2
                else if (userChoice == 5)
                {
                    string sentence = "Choose a part of this sentence you want to pull out. ";
                    Console.WriteLine(sentence);

                    Console.Write("From charater: ");
                    int startIndex = int.Parse(Console.ReadLine());
                    Console.Write("How many charaters: ");
                    int endIndex = int.Parse(Console.ReadLine());

                    Console.WriteLine(sentence.Substring(startIndex, endIndex));
                    Console.WriteLine("\n -------------------------------------------------------- \n");
                }
                // opgave 2.3
                else if(userChoice == 6)
                {
                    string sentence = "Choose a character in this sentence you want the index of. ";
                    Console.WriteLine(sentence);

                    Console.Write("Character: ");
                    char character = char.Parse(Console.ReadLine());

                    if (sentence.IndexOf(character) != -1)
                    {
                        Console.WriteLine(sentence.IndexOf(character));
                        Console.WriteLine("\n -------------------------------------------------------- \n");
                    }
                    else
                    {
                        Console.WriteLine("Character not found!");
                        Console.WriteLine("\n -------------------------------------------------------- \n");
                    }
                    
                } else { break; }
            }

        }
    }
}
