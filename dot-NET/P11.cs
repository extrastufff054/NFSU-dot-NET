// // Write a program to demonstrate the use of bitwise operators .

// using System;

// namespace Bitwise_Operators
// {
//     class Bitwise_Operators
//     {
//         static void Main()
//         {
//             Console.WriteLine("Enter the first number:");
//             int num1 = int.Parse(Console.ReadLine());
//             Console.WriteLine("Enter the second number:");
//             int num2 = int.Parse(Console.ReadLine());
//             Console.WriteLine("Which condition do you want to check?");
//             Console.WriteLine("1. num1 > num2");
//             Console.WriteLine("2. num1 < num2");
//             Console.WriteLine("3. num1 == num2");
//             Console.WriteLine("4. num1 != num2");
//             Console.WriteLine("5. num1 >= num2");
//             Console.WriteLine("6. num1 <= num2");
//             Console.WriteLine("Enter your choice:");

//             switch(Console.ReadLine())
//             {
//                 case "1" :
//                     if(num1 > num2)
//                     {
//                         Console.WriteLine("num1 is greater than num2");
//                     }
//                     else
//                     {
//                         Console.WriteLine("num2 is greater than num1");
//                     }
//                     break;
//                 case "2" :
//                     if(num1 < num2)
//                     {
//                         Console.WriteLine("num1 is less than num2");
//                     }
//                     else
//                     {
//                         Console.WriteLine("num2 is less than num1");
//                     }
//                     break;

//                 case "3" :
//                     if(num1 == num2)
//                     {
//                         Console.WriteLine("num1 is equal to num2");
//                     }
//                     else
//                     {
//                         Console.WriteLine("num2 is not equal to num1");
//                     }
//                     break;

//                 case "4" :
//                     if(num1 != num2)
//                     {
//                         Console.WriteLine("num1 is not equal to num2");
//                     }
//                     else
//                     {
//                         Console.WriteLine("num2 is equal to num1");
//                     }
//                     break;
                
//                 case "5" :
//                     if(num1 >= num2)
//                     {
//                         Console.WriteLine("num1 is greater than or equal to num2");
//                     }
//                     else
//                     {
//                         Console.WriteLine("num2 is greater than or equal to num1");
//                     }
//                     break;

//                 case "6" :
//                     if(num1 <= num2)
//                     {
//                         Console.WriteLine("num1 is less than or equal to num2");
//                     }
//                     else
//                     {
//                         Console.WriteLine("num2 is less than or equal to num1");
//                     }
//                     break;

//                 default :
//                     Console.WriteLine("Invalid input");
//                     break;
//             }
//         }
//     }
// }