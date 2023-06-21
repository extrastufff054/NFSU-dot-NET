//  // Write a program to make a calculator in C#

// using System;

// namespace Calculator {
//     class Calculator{
//         static void Main()
//         {
//             Console.Write("Enter the numbers to be performed operations onto :");
//             int a = int.Parse(Console.ReadLine());
//             int b = int.Parse(Console.ReadLine());
//             Console.WriteLine("Select operation to be performed" );
//             Console.WriteLine("1. Addition \n2. Subtraction \nMultiplication \nDivision \nModulo \nPower ");
//             switch(Console.ReadLine()) {
//                 case "1" :
//                     Console.WriteLine("The sum of " +a+ "and" +b+"is:" +(a+b) );
//                     break;
                
//                 case "2" :
//                     Console.WriteLine("The subraction of "+a+ "and" +b+"is :" +(a-b));
//                     break;

//                 case "3" :
//                     Console.WriteLine("The product of "+a+ "and" +b+ "is :" +(a*b));
//                     break;

//                 case "4" :
//                     Console.WriteLine("The division of "+a+ "and" +b+ "is :" +(a/b));
//                     break;
                
//                 case "5" :
//                     Console.WriteLine("The modulo of "+a+ "and" +b+ "is :" +(a%b));
//                     break;

//                 case "6" :
//                     Console.WriteLine("The power of "+a+ "and" +b+ "is :" +(Math.Pow(a,b)));
//                     break;

//                 default :
//                     Console.WriteLine("Invalid input");
//                     break;
//             }
//         }
//     }
// }