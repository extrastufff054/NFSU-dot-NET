// // Develop a C# code to demonstrate the concept of operator overloading

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("String Addition and Concatenation");
//         Console.WriteLine();

//         Console.Write("Enter the first string: ");
//         string str1 = Console.ReadLine();

//         Console.Write("Enter the second string: ");
//         string str2 = Console.ReadLine();

//         string result = str1 + str2;

//         Console.WriteLine();
//         Console.WriteLine("Menu:");
//         Console.WriteLine("1. Addition");
//         Console.WriteLine("2. Concatenation");
//         Console.WriteLine();

//         Console.Write("Enter your choice: ");
//         int choice = int.Parse(Console.ReadLine());

//         switch (choice)
//         {
//             case 1:
//                 int num1, num2;
//                 Console.Write("Enter the first number: ");
//                 int.TryParse(Console.ReadLine(), out num1);

//                 Console.Write("Enter the second number: ");
//                 int.TryParse(Console.ReadLine(), out num2);

//                 int sum = num1 + num2;
//                 Console.WriteLine("Addition Result: " + sum);
//                 break;
//             case 2:
//                 Console.WriteLine("Concatenation Result: " + result);
//                 break;
//             default:
//                 Console.WriteLine("Invalid choice!");
//                 break;
//         }
//     }
// }
