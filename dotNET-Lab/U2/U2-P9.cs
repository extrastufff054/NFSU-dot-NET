// // Develop a C# code to demonstrate the concept of Nested catch blocks

// using System;

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             int[] numbers = { 1, 2, 3 };
//             Console.WriteLine("Enter an index:");
//             int index = int.Parse(Console.ReadLine());

//             try
//             {
//                 int result = numbers[index];
//                 Console.WriteLine("Result: " + result);
//             }
//             catch (IndexOutOfRangeException)
//             {
//                 Console.WriteLine("Error: Index is out of range!");
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine("An error occurred: " + ex.Message);
//             }
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Error: Invalid input format! Please enter a valid integer.");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine("An error occurred: " + ex.Message);
//         }
//     }
// }
