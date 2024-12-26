using System;
using System.Collections.Generic;
using System.Threading;

namespace Russian_Roulette_Quizzer_Project_1st_Sem_2nd_Year
{
    internal class Program
    {
        static Dictionary<string, string> userDatabase = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine(" ");
                Console.WriteLine("=======================================================");
                Console.WriteLine("||               Welcome to Quiz Game                ||");
                Console.WriteLine("||           Russian Roulette Programming            ||");
                Console.WriteLine("=======================================================");
                Console.WriteLine("|| 1. Sign Up                                        ||");
                Console.WriteLine("|| 2. Log In                                         ||");
                Console.WriteLine("|| 3. Exit                                           ||");
                Console.WriteLine("=======================================================");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SignUp();
                        break;
                    case "2":
                        if (LogIn())
                        {
                            runGame();
                        }
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Exiting the game. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void SignUp()
        {
            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.WriteLine("||                       Sign Up                     ||");
            Console.WriteLine("=======================================================");
            string username, password, confirmPassword;
            while (true)
            {
                Console.Write("Enter a username: ");
                username = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(username))
                {
                    Console.WriteLine("Username cannot be empty or contain spaces. Please try again.");
                }
                else
                {
                    break;
                }
            }
            if (userDatabase.ContainsKey(username))
            {
                Console.WriteLine("This username is already taken. Try a different one.");
                return;
            }

            while (true)
            {
                Console.Write("Enter a password (minimum 6 characters): ");
                password = Console.ReadLine();
                if (string.IsNullOrEmpty(password) || password.Contains(" ") || password.Length < 6)
                {
                    Console.WriteLine("Password must be at least 6 characters long and cannot contain spaces. Please try again.");
                    continue;
                }

                Console.Write("Retype your password: ");
                confirmPassword = Console.ReadLine();
                if (password != confirmPassword)
                {
                    Console.WriteLine("Passwords do not match. Please try again.");
                }
                else
                {
                    break;
                }
                break;
            }

            userDatabase[username] = password;
            Console.WriteLine("Sign-up successful! You can now log in.");
        }

        static bool LogIn()
        {
            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.WriteLine("||                        Log In                     ||");
            Console.WriteLine("=======================================================");
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (userDatabase.TryGetValue(username, out string storedPassword) && storedPassword == password)
            {
                Console.WriteLine($"Welcome To the Game, {username}!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
                return false;
            }
        }

        static void runGame()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================================================");
                Console.WriteLine("||           Russian Roulette Programming            ||");
                Console.WriteLine("=======================================================");
                Console.WriteLine("|| 1. Start Game                                     ||");
                Console.WriteLine("|| 2. Instructions                                   ||");
                Console.WriteLine("|| 3. Log Out                                        ||");
                Console.WriteLine("|| 4. Exit                                           ||");
                Console.WriteLine("=======================================================");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StartGame();
                        break;
                    case "2":
                        ShowInstructions();
                        break;
                    case "3":
                        Console.WriteLine("Logging out... Returning to the main menu.");
                        return;
                    case "4":
                        Console.WriteLine("Exiting the game. Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void StartGame()
        {
            var questionBank = new QuestionBank();
            var questions = questionBank.Questions;

            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.WriteLine("||           Russian Roulette Programming            ||");
            Console.WriteLine("=======================================================");
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();

            bool playAgain = true;
            while (playAgain)
            {
                Random rand = new Random();
                int bulletPosition = rand.Next(1, 9); // Bullet randomly placed in a 8-chamber gun
                int chamberPosition = 0;
                bool gameOver = false;

                Console.Clear();
                Console.WriteLine("=======================================================");
                Console.WriteLine("||           Russian Roulette Programming            ||");
                Console.WriteLine("=======================================================");
                Console.WriteLine("||       Welcome to Russian Roulette Quiz Game!      ||");
                Console.WriteLine("||   Answer correctly to avoid triggering the gun.   ||");
                Console.WriteLine("=======================================================");
                Console.WriteLine("Press any key to proceed.");
                Console.ReadKey();
                Console.Clear();

                // alternating turns between player and enemy
                while (!gameOver)
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine("||           Russian Roulette Programming            ||");
                    Console.WriteLine("=======================================================");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\n{playerName}'s Turn:");
                    Console.ResetColor();
                    if (PlayTurn(playerName, questions, ref chamberPosition, bulletPosition, rand))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nGame Over!");
                        Console.ResetColor();
                        gameOver = true;
                        break;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nEnemy's Turn:");
                    Console.ResetColor();
                    if (PlayTurn("Enemy", questions, ref chamberPosition, bulletPosition, rand, isEnemy: true))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nYou Won, {playerName}!!!");
                        Console.ResetColor();
                        gameOver = true;
                        break;
                    }
                }

                string playAgainChoice = "";
                bool validInput = false;
                while (!validInput)
                {
                    Console.Write("\nDo you want to play again? (y/n): ");
                    playAgainChoice = Console.ReadLine().ToLower();

                    if (playAgainChoice == "y" || playAgainChoice == "n")
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 'y' for yes or 'n' for no.");
                    }
                }

                if (playAgainChoice != "y")
                {
                    playAgain = false;
                    Console.WriteLine("Returning to the main menu...");
                }
            }
        }

        static bool PlayTurn(string playerName, List<(string Question, string[] Choices, int CorrectIndex)> questions, ref int chamberPosition, int bulletPosition, Random rand, bool isEnemy = false)
        {
            // Randomly select a question from the list
            var (Question, Choices, CorrectIndex) = questions[rand.Next(questions.Count)];
            Console.WriteLine($"\nQuestion: {Question}");
            for (int i = 0; i < Choices.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Choices[i]}");
            }

            int answer = 0;

            if (isEnemy)
            {
                answer = rand.Next(1, Choices.Length + 1); // Randomly pick an answer for the enemy
                Console.WriteLine($"Enemy chooses: {answer}");
            }
            else
            {
                bool validInput = false;
                while (!validInput)
                {
                    Console.Write("Your answer (1-3): ");
                    validInput = int.TryParse(Console.ReadLine(), out answer) && answer > 0 && answer <= Choices.Length;
                    if (!validInput) Console.WriteLine("Invalid choice. Please try again.");
                }
            }

            // Check if the player's or enemy's answer is correct
            if (answer - 1 == CorrectIndex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(2500);
                Console.WriteLine($"{playerName} got it right! No trigger this round.");
                Console.Beep(500, 250);
                Console.Beep(500, 250);
                Console.Beep(600, 250);
                Console.ResetColor();
                Thread.Sleep(4000);
                if (isEnemy)
                {
                    Console.Clear();
                }
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(2500);
                Console.WriteLine($"{playerName} got it wrong!");
                Console.Beep(400, 250);
                Console.Beep(300, 250);
                Console.Beep(200, 250);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Correct answer: {(CorrectIndex + 1)}");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Triggering the gun...");
                Console.ResetColor();
                Thread.Sleep(4000);
                chamberPosition++;

                if (chamberPosition == bulletPosition)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep(300, 1000);
                    Console.WriteLine($"{playerName} is unlucky! The gun fired!");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    return true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Beep(500, 300);
                    Console.WriteLine($"Click! {playerName} got lucky this time.");
                    Console.ResetColor();
                    Thread.Sleep(4000);
                    if (isEnemy)
                    {
                        Console.Clear();
                    }
                    return false;
                }
            }
        }

        static void ShowInstructions()
        {
            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.WriteLine("||                    Instructions                   ||");
            Console.WriteLine("=======================================================");
            Console.WriteLine("1. Answer questions correctly to avoid triggering the gun.");
            Console.WriteLine("2. Each wrong answer advances the chamber, possibly triggering the bullet.");
            Console.WriteLine("3. Compete against the enemy. Survive and win!");
            Console.WriteLine("Press any key to proceed.");
            Console.ReadKey();
        }
    }
}
