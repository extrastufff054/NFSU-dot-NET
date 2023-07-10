// // Develop a C# code to demonstrate the concept of Exception Handling

// using System;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             // Prompt the user to enter two numbers
//             Console.WriteLine("Enter two numbers:");

//             // Read the input from the user
//             int number1 = int.Parse(Console.ReadLine());
//             int number2 = int.Parse(Console.ReadLine());

//             // Perform the division
//             int result = DivideNumbers(number1, number2);

//             // Display the result
//             Console.WriteLine($"Result: {result}");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Invalid input. Please enter valid numbers.");
//         }
//         catch (DivideByZeroException)
//         {
//             Console.WriteLine("Error: Division by zero is not allowed.");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"An error occurred: {ex.Message}");
//         }
//     }

//     static int DivideNumbers(int dividend, int divisor)
//     {
//         if (divisor == 0)
//         {
//             throw new DivideByZeroException();
//         }

//         return dividend / divisor;
//     }
// }

// /*
// In this code, the try block is used to enclose the code that may potentially throw an exception. The code attempts to read two numbers from the user and divide them using the DivideNumbers method.

// If any exception occurs within the try block, it is caught by the corresponding catch block. In this example, we have specific catch blocks for FormatException (when the user enters invalid input) and DivideByZeroException (when the divisor is zero). The catch (Exception ex) block is a catch-all block that handles any other exceptions not explicitly caught.

// Within each catch block, you can provide appropriate error messages or perform additional actions as needed.
// */