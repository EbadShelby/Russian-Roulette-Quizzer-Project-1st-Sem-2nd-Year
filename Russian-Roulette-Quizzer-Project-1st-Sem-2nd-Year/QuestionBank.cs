using System.Collections.Generic;

namespace Russian_Roulette_Quizzer_Project_1st_Sem_2nd_Year
{
    public class QuestionBank
    {
        public List<(string Question, string[] Choices, int CorrectIndex)> Questions { get; set; }

        public QuestionBank()
        {
            Questions = new List<(string Question, string[] Choices, int CorrectIndex)>
        {
            ("What is OOP?", new[] { "Optional Output Processing", "Object-Oriented Programming", "Open Operational Procedure" }, 1),
            ("What is binary?", new[] { "A coding language", "A base-2 number system", "An IDE for coding" }, 1),
            ("What does 'int' mean in programming?", new[] { "Integer", "Integration", "Internet Protocol" }, 0),
            ("What is the purpose of a loop in programming?", new[] { "To sort data", "To stop the program", "To repeat a set of instructions" }, 2),
            ("What is an algorithm?", new[] { "An error in the code", "A set of steps to solve a problem", "A dance move" }, 1),
            ("What is a variable?", new[] { "A named storage for data", "A type of operator", "A function definition" }, 0),
            ("What is a function?", new[] { "A conditional statement", "A block of reusable code", "A data type" }, 1),
            ("What is debugging?", new[] { "Removing errors from code", "Writing new code", "Compiling the code" }, 0),
            ("What is recursion?", new[] { "A function calling itself", "Repeating a loop", "An error in the code" }, 0),
            ("What is an array?", new[] { "A data type for characters", "A collection of items of the same type", "A type of loop" }, 1),
            ("What does 'if-else' do in programming?", new[] { "Declares variables", "Checks a condition and executes code accordingly", "Performs arithmetic operations" }, 1),
            ("What is a compiler?", new[] { "A type of loop", "A tool to debug code", "A tool to convert code into machine-readable format" }, 2),
            ("What is a syntax error?", new[] { "An error during program execution", "An error in code structure", "A hardware malfunction" }, 1),
            ("What does 'boolean' represent?", new[] { "A numeric value", "True or False values", "A text string" }, 1),
            ("What is a parameter in programming?", new[] { "A type of loop", "An input to a function", "A conditional operator" }, 1),
            ("What is the purpose of a return statement?", new[] { "To terminate a loop", "To create a variable", "To send a value back from a function" }, 2),
            ("What is a constant?", new[] { "A conditional operator", "A type of loop", "A variable that does not change" }, 2),
            ("What is the purpose of a comment in code?", new[] { "To run faster", "To explain the code to developers", "To store data" }, 1),
            ("What is a data type?", new[] { "A loop structure", "Defines the kind of data a variable can store", "A type of error" }, 1),
            ("What is a class in programming?", new[] { "A conditional statement", "A type of function", "A blueprint for creating objects" }, 2),
            ("What is a constructor in OOP?", new[] { "A function that initializes an object", "A type of loop", "A conditional statement" }, 0),
            ("What does the 'break' keyword do in a loop?", new[] { "Skips the current iteration", "Exits the loop completely", "Ends the program" }, 1),
            ("What is an object in OOP?", new[] { "A function within a class", "An instance of a class", "A loop in the program" }, 1),
            ("What is the purpose of the 'continue' keyword?", new[] { "Exits the loop", "Skips the current iteration and moves to the next", "Pauses the program" }, 1),
            ("What does the 'switch' statement do?", new[] { "Loops through a set of conditions", "Compares a value to multiple options", "Defines a variable type" }, 1),
            ("What is the purpose of a 'break' statement inside a switch?", new[] { "To stop the program", "To terminate the current case", "To continue with the next case" }, 1),
            ("What is the difference between a list and an array?", new[] { "A list is fixed size, and an array is dynamic", "A list can store different types of data, and an array cannot", "A list is dynamic in size, while an array is fixed size" }, 2),
            ("What is the 'else if' condition used for?", new[] { "To check multiple conditions in a series", "To terminate a loop", "To create a variable" }, 0),
            ("What is an exception in programming?", new[] { "An error that can be caught and handled", "A normal part of code", "A data structure" }, 0),
            ("What is the purpose of the 'try-catch' block?", new[] { "To define the function", "To handle exceptions and errors", "To check conditions" }, 1),
            ("What does the 'void' keyword represent in a function?", new[] { "It indicates a function has no return value", "It represents a loop", "It defines a data type" }, 0),
            ("What is a for loop?", new[] { "A loop that repeats a set number of times", "A loop that runs while a condition is true", "A loop that repeats infinitely" }, 0),
            ("What is the purpose of 'else' in an if-else statement?", new[] { "To define an alternative action if the condition is false", "To create a variable", "To terminate the loop" }, 0),
            ("What is the purpose of the 'new' keyword in object-oriented programming?", new[] { "It is used to define a variable", "It creates a new instance of an object", "It defines a method" }, 1),
            ("What does '&&' represent in programming?", new[] { "Logical OR", "Logical AND", "Not equal to" }, 1),
            ("What is the use of 'public' in object-oriented programming?", new[] { "To define a private variable", "To declare that a method or class is accessible outside its class", "To define a constant" }, 1),
            ("What is inheritance in OOP?", new[] { "A process where one class inherits properties and methods from another class", "A method that repeats code", "A variable type" }, 0),
            ("What is the difference between '==' and '!='?", new[] { "Equality vs. inequality comparison", "Checking for null values", "Both are used for assignments" }, 0),
            ("What does 'null' represent in programming?", new[] { "A boolean value", "A memory location", "A reference to no value" }, 2),
            ("What does 'static' mean in programming?", new[] { "A keyword that defines variables with fixed values", "A keyword that makes methods belong to a class, not instances", "A loop control variable" }, 1),
            ("What base does the binary number system use?", new[] { "Base 2", "Base 8", "Base 10" }, 0),
            ("Which number system uses base 16?", new[] { "Octal", "Decimal", "Hexadecimal" }, 2),
            ("Which number system uses base 8?", new[] { "Octal", "Hexadecimal", "Binary" }, 0),
        };
        }
    }
}
