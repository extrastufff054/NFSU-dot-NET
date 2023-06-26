// // Develop a C# code to generate Fibonacci series of N numbers

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the number of terms in the Fibonacci series: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.WriteLine("Fibonacci Series:");
//         for (int i = 0; i < n; i++)
//         {
//             int fibonacciNumber = Fibonacci(i);
//             Console.Write(fibonacciNumber + " ");
//         }
//     }

//     static int Fibonacci(int n)
//     {
//         if (n <= 1)
//         {
//             return n;
//         }
//         else
//         {
//             return Fibonacci(n - 1) + Fibonacci(n - 2);
//         }
//     }
// }
