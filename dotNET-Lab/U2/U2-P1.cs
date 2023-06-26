// // Develop a C# code to multiply two values by using concept of parameterized constructor

// using System;

// class Multiplier
// {
//     private int result;

//     public Multiplier(int value1, int value2)
//     {
//         result = value1 * value2;
//     }

//     public int GetResult()
//     {
//         return result;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the first value: ");
//         int value1 = int.Parse(Console.ReadLine());

//         Console.Write("Enter the second value: ");
//         int value2 = int.Parse(Console.ReadLine());

//         Multiplier multiplier = new Multiplier(value1, value2);
//         int product = multiplier.GetResult();

//         Console.WriteLine("The product of {0} and {1} is {2}", value1, value2, product);
//     }
// }
