// // Develop a menu driven C# code to perform following operations :
// // a) Convert binary to decimal
// // b) Convert decimal to binary
// // c) Convert hexadecimal to octal
// // d) Convert octal to decimal

// using System;

// class Program
// {
//     static void Main()
//     {
//         char choice;
//         do
//         {
//             Console.WriteLine("Menu:");
//             Console.WriteLine("a) Convert binary to decimal");
//             Console.WriteLine("b) Convert decimal to binary");
//             Console.WriteLine("c) Convert hexadecimal to octal");
//             Console.WriteLine("d) Convert octal to decimal");
//             Console.WriteLine("e) Exit");
//             Console.Write("Enter your choice: ");
//             choice = char.ToLower(Console.ReadKey().KeyChar);
//             Console.WriteLine();

//             switch (choice)
//             {
//                 case 'a':
//                     ConvertBinaryToDecimal();
//                     break;
//                 case 'b':
//                     ConvertDecimalToBinary();
//                     break;
//                 case 'c':
//                     ConvertHexadecimalToOctal();
//                     break;
//                 case 'd':
//                     ConvertOctalToDecimal();
//                     break;
//                 case 'e':
//                     Console.WriteLine("Exiting...");
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     break;
//             }

//             Console.WriteLine();
//         } while (choice != 'e');
//     }

//     static void ConvertBinaryToDecimal()
//     {
//         Console.Write("Enter a binary number: ");
//         string binary = Console.ReadLine();

//         try
//         {
//             int decimalNumber = Convert.ToInt32(binary, 2);
//             Console.WriteLine($"Decimal equivalent: {decimalNumber}");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Invalid binary number entered.");
//         }
//     }

//     static void ConvertDecimalToBinary()
//     {
//         Console.Write("Enter a decimal number: ");
//         int decimalNumber = int.Parse(Console.ReadLine());

//         string binary = Convert.ToString(decimalNumber, 2);
//         Console.WriteLine($"Binary equivalent: {binary}");
//     }

//     static void ConvertHexadecimalToOctal()
//     {
//         Console.Write("Enter a hexadecimal number: ");
//         string hexadecimal = Console.ReadLine();

//         try
//         {
//             int decimalNumber = Convert.ToInt32(hexadecimal, 16);
//             string octal = Convert.ToString(decimalNumber, 8);
//             Console.WriteLine($"Octal equivalent: {octal}");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Invalid hexadecimal number entered.");
//         }
//     }

//     static void ConvertOctalToDecimal()
//     {
//         Console.Write("Enter an octal number: ");
//         string octal = Console.ReadLine();

//         try
//         {
//             int decimalNumber = Convert.ToInt32(octal, 8);
//             Console.WriteLine($"Decimal equivalent: {decimalNumber}");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Invalid octal number entered.");
//         }
//     }
// }
