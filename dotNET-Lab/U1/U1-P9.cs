// // Develop a C# code to find out factorial of given number

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a number: ");
//         int number = int.Parse(Console.ReadLine());

//         long factorial = CalculateFactorial(number);

//         Console.WriteLine($"Factorial of {number} is: {factorial}");
//     }

//     static long CalculateFactorial(int n)
//     {
//         if (n == 0)
//         {
//             return 1;
//         }
//         else
//         {
//             long result = 1;
//             for (int i = 1; i <= n; i++)
//             {
//                 result *= i;
//             }
//             return result;
//         }
//     }
// }
