// // Develop a C# code to check given string is palindrome or not

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a string: ");
//         string input = Console.ReadLine();

//         bool isPalindrome = IsPalindrome(input);

//         if (isPalindrome)
//         {
//             Console.WriteLine("The string is a palindrome.");
//         }
//         else
//         {
//             Console.WriteLine("The string is not a palindrome.");
//         }
//     }

//     static bool IsPalindrome(string input)
//     {
//         int left = 0;
//         int right = input.Length - 1;

//         while (left < right)
//         {
//             if (input[left] != input[right])
//             {
//                 return false;
//             }

//             left++;
//             right--;
//         }

//         return true;
//     }
// }
