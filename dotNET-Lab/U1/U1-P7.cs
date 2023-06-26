// // Develop a C# code to demonstrate the concept of if else ladder and switch statement

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Choose an option:");
//         Console.WriteLine("1. If-Else Ladder(Positve/Negative/Zero)");
//         Console.WriteLine("2. Switch Statement(Day of the Week)");

//         int option = int.Parse(Console.ReadLine());

//         if (option == 1)
//         {
//             Console.Write("Enter a number: ");
//             int number = int.Parse(Console.ReadLine());

//             if (number < 0)
//             {
//                 Console.WriteLine("The number is negative.");
//             }
//             else if (number > 0)
//             {
//                 Console.WriteLine("The number is positive.");
//             }
//             else
//             {
//                 Console.WriteLine("The number is zero.");
//             }
//         }
//         else if (option == 2)
//         {
//             Console.Write("Enter a day of the week: ");
//             string day = Console.ReadLine();

//             switch (day.ToLower())
//             {
//                 case "monday":
//                     Console.WriteLine("It's Monday.");
//                     break;
//                 case "tuesday":
//                     Console.WriteLine("It's Tuesday.");
//                     break;
//                 case "wednesday":
//                     Console.WriteLine("It's Wednesday.");
//                     break;
//                 case "thursday":
//                     Console.WriteLine("It's Thursday.");
//                     break;
//                 case "friday":
//                     Console.WriteLine("It's Friday.");
//                     break;
//                 case "saturday":
//                     Console.WriteLine("It's Saturday.");
//                     break;
//                 case "sunday":
//                     Console.WriteLine("It's Sunday.");
//                     break;
//                 default:
//                     Console.WriteLine("Invalid day.");
//                     break;
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid option.");
//         }
//     }
// }
