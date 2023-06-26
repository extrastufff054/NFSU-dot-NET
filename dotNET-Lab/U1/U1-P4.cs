// // Develop a C# code to check given number is prime or not

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a number: ");
//         int number = int.Parse(Console.ReadLine());

//         bool isPrime = IsPrime(number);

//         if (isPrime)
//         {
//             Console.WriteLine(number + " is a prime number.");
//         }
//         else
//         {
//             Console.WriteLine(number + " is not a prime number.");
//         }
//     }

//     static bool IsPrime(int number)
//     {
//         if (number <= 1)
//         {
//             return false;
//         }

//         for (int i = 2; i * i <= number; i++)
//         {
//             if (number % i == 0)
//             {
//                 return false;
//             }
//         }

//         return true;
//     }
// }
