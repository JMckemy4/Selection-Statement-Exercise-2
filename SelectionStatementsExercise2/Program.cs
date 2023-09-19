using System;

namespace SelectionStatementsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string userSubject = Console.ReadLine();

            switch (userSubject.ToLower()) // Convert user input to lowercase for case-insensitivity
            {
                case "math":
                    Console.WriteLine($"Your favorite subject is {userSubject}. Math is fascinating!");
                    break;
                case "science":
                    Console.WriteLine($"Your favorite subject is {userSubject}. Science is full of wonders.");
                    break;
                case "history":
                    Console.WriteLine($"Your favorite subject is {userSubject}. History helps us learn from the past.");
                    break;
                case "english":
                    Console.WriteLine($"Your favorite subject is {userSubject}. English language and literature are enriching.");
                    break;
                case "art":
                    Console.WriteLine($"Your favorite subject is {userSubject}. Art allows for creative expression.");
                    break;
                default:
                    Console.WriteLine($"I'm not familiar with {userSubject}. Please enter a valid school subject.");
                    break;
            }
        }
    }
}






