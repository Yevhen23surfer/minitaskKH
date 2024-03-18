
using System;

class MultipurposeApp
{
    static void Main(string[] args)
    {
        // Task 1: Name Input
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}!");

        // Task 2: Age Verification and Terms of Service Agreement
        Console.WriteLine("\nPlease enter your age:");
        int userAge = Convert.ToInt32(Console.ReadLine());

        if (userAge < 18)
        {
            Console.WriteLine("You must be 18 years old to use this service.");
        }
        else
        {
            Console.WriteLine("Do you agree with the terms of service? (yes/no)");
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes")
            {
                Console.WriteLine("Thank you!");
                Console.WriteLine($"Name: {userName}");
                Console.WriteLine($"Age: {userAge}");
                Console.WriteLine("Accepted TOS: yes");
            }
            else if (answer == "no")
            {
                Console.WriteLine("You must agree to the terms of service to continue.");
            }
            else
            {
                Console.WriteLine("Invalid answer. Please enter 'yes' or 'no'.");
            }
        }
        /*
        // Task 3: Variable Names and Types (Example)
        string itemName = "";
        int quantity = 0;
        double weight = 0.0;
        double pricePerUnit = 0.0;

        // Prompt for grocery item details (optional, adapt as needed)
        Console.WriteLine("\nWould you like to enter details for a grocery item? (yes/no)");
        string enterItemDetails = Console.ReadLine().ToLower();

        if (enterItemDetails == "yes")
        {
            Console.WriteLine("Enter the name of the grocery item:");
            itemName = Console.ReadLine();

            Console.WriteLine("Enter the quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the weight in kilograms:");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the price per unit:");
            pricePerUnit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Item: {itemName}, Quantity: {quantity}, Weight: {weight} kg, Price: ${pricePerUnit * quantity}");
        }
        */
        
        /*
        // Task 4: Simple Calculator (Example)
        Console.WriteLine("\nWould you like to use the simple calculator? (yes/no)");
        string useCalculator = Console.ReadLine().ToLower();

        if (useCalculator == "yes")
        {
            Console.WriteLine("Enter the first number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, /, or *):");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return; // Exit program on division by zero
                    }
                    result = firstNumber / secondNumber;
                    break;
                default:
                    Console.WriteLine("Invalid operator entered.");
                    return; // Exit on invalid operator
            }

            Console.WriteLine($"The result is: {result}");
        }
        */
        Console.WriteLine("\nThank you for using the Multipurpose App!");
    }
}
