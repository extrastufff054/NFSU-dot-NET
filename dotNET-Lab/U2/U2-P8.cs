// // Develop a C# code to demonstrate the concept of Multiple catch blocks

// using System;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Console.WriteLine("Enter two numbers:");
//             int num1 = int.Parse(Console.ReadLine());
//             int num2 = int.Parse(Console.ReadLine());

//             int result = DivideNumbers(num1, num2);

//             Console.WriteLine("Result: " + result);
//         }
//         catch (DivideByZeroException)
//         {
//             Console.WriteLine("Error: Division by zero is not allowed!");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Error: Invalid input format! Please enter valid integer values.");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("An error occurred: " + ex.Message);
//         }
//         finally
//         {
//             Console.WriteLine("Finally block executed.");
//         }
//     }

//     static int DivideNumbers(int dividend, int divisor)
//     {
//         return dividend / divisor;
//     }
// }
