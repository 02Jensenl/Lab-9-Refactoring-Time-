using System;
using System.Collections.Generic;

namespace Lab9_Refactoring
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> students = new List<string>
                {
                "Aaron", "Chelsea", "Edward", "Shelby", "Carl", "Mary", "Paul", "Heather", "Darren", "Melody"

                };

            List<string> hometown = new List<string>
                {
                "Milford", "Keego Harbor", "Westland", "Bay City", "Blissfield", "Algonac", "Standish", "Lansing", "Escanaba", "Marquette"
                };

            List<string> food = new List<string>
                {
                "Chili", "Lobster", "Curry", "Sushi", "Tacos", "Chicken parmesan", "Spaghetti", "Waffles", "Salmon", "Falafel"
                };

            List<string> color = new List<string>
                {
                "Red", "Purple", "Blue", "Orange", "Black", "Pink", "Green", "Yellow", "Neon green", "Silver"
                };
            List<string> sport = new List<string>
                {
                "Soccer", "Baseball", "Water polo", "Curling", "Football", "Cricket", "Hockey", "Basketball", "Dodgeball", "Tennis"
                };

            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("Which student would you like to know more about?");
                DisplayPeople(students);
                Console.WriteLine("Enter a number that corresponds with a student:");

                int userInput = int.Parse(Console.ReadLine());
                if (userInput >= 1 && userInput <= 20)
                {
                    Console.WriteLine($"\nOkay, you want to know more about {students[userInput - 1]}.\n");
                }

                else 
                {
                    Console.WriteLine("Error.");
                    return;
                }

                Console.WriteLine($"What would you like to know about {students[userInput - 1]}?\nHometown, favorite food, favorite color, or favorite sport?\n(Enter H for hometown, F for favorite food, C for favorite color, S for favorite sport.)");

                string homeFoodColor = Console.ReadLine();

                if (homeFoodColor == "H" || homeFoodColor == "h")
                {
                    Console.WriteLine($"{students[userInput - 1]}'s hometown is {hometown[userInput - 1]}");
                }
                else if (homeFoodColor == "F" || homeFoodColor == "f")
                {
                    Console.WriteLine($"{students[userInput - 1]}'s favorite food is {food[userInput - 1]}");
                }
                else if (homeFoodColor == "C" || homeFoodColor == "c")
                {
                    Console.WriteLine($"{students[userInput - 1]}'s favorite color is {color[userInput - 1]}");
                }
                else if (homeFoodColor == "S" || homeFoodColor == "s")
                {
                    Console.WriteLine($"{students[userInput - 1]}'s favorite sport is {sport[userInput - 1]}");
                }
                else
                {
                    Console.WriteLine("Please try again. Enter H for hometown, F for favorite food, C for favorite color, or S for favorite sport.");
                    return;
                }
                Console.WriteLine("Would you like to learn about someone else?\nPress Y to continue, A to add, or any other key to quit.");

                string userContinue = Console.ReadLine();
                if (userContinue == "y" || userContinue == "Y")
                {
                    playAgain = true;
                }

                else if (userContinue == "A" || userContinue == "a")
                {
                    Console.WriteLine("Enter a Name:");
                    string userInputA = Console.ReadLine();
                    Console.WriteLine("Enter a hometown:");
                    string userInputB = Console.ReadLine();
                    Console.WriteLine("Enter a food:");
                    string userInputC = Console.ReadLine();
                    Console.WriteLine("Enter a color:");
                    string userInputD = Console.ReadLine();
                    Console.WriteLine("Enter a sport:");
                    string userInputE = Console.ReadLine();
                    students.Add(userInputA);
                    hometown.Add(userInputB);
                    food.Add(userInputC);
                    color.Add(userInputD);
                    sport.Add(userInputE);
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing.");
        }
        public static void DisplayPeople(List<string> students)
        {
            int counter = 1;
            foreach (string student in students)
            {
                Console.WriteLine($"{counter}: {student}");
                counter++;
            }
        }
    }
}