using System;
using System.Reflection.Metadata;
using Internal;

class Calculator
{
    static void Main()
    {
        while (true) // Loop to keep the calculator running until the user chooses to exit.
        {
            Console.WriteLine("Simple Calculator Menu:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.Write("Please choose an operation (1-5): ");
            string choice = Console.ReadLine();

            if (choice == "5") //this is if the choice is 5 - then the app will exit
            {
                Console.WriteLine("Exiting the calculator. Goodbye!");
                break; // Exit the loop and terminate the program.
            }

            if (!int.TryParse(choice, out int operation) || operation < 1 || operation > 4) // 'out' parameters are used when you want a method to return more than one value. 'TryParse' returns two things -
                                                                                            // it returns a 'bool', which is 'true' if the parsing was successful and 'fail' if it failed.
                                                                                            // it returns the parsed integer value as an 'out' parameter. if parsing is successful, the parse integer is stored in the result variable provided by caller.
                                                                                            // operation < 1 and operation > 4 - this returns the invalid for the operation selection at the top
            {
                Console.WriteLine("Invalid choice. Please select a valid operation.");
                continue; // Restart the loop.
            }

            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1)) //this is used to parse the user input into a 'double' (floating-pint number. returns 'true'
                                                                       //if the parsing was success and stores the parse value in the 'num1' variable.
                                                                       //'!' is used as a logical NOT operator when applied to the double.TryParse, it negates the boolean value. So '!double.TryParse(...) means "if parsing fails" or
                                                                       //"if the result of the 'TryParse' is 'false'." - if it fails it means the user did not enter a valid numeric value and it displays the error message and continues the loop to prompt the user for valid input.
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; // Restart the loop.
            }

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue; // Restart the loop.
            }

            double result = 0; //result is used to store the reult of the arithmetic operation performed by the calculator. Initializing the 'result' to '0', it ensure that if there are any issues
                               //with the calculations or if no operation is performed, 'result' will have the default value of '0'

            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        continue; // Restart the loop.
                    }
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine($"Result: {result}"); //the 'result' variable is updated with the actual result and then its displayed to the user. 
        }
    }
}
