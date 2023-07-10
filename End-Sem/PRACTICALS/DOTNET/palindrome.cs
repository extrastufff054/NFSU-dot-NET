//  using System;

//  class Program
//  {
//      static bool IsPalindrome(string input)
//      {
//          // Remove any spaces and convert to lowercase
//          input = input.Replace(" ", "").ToLower();

//          int left = 0;
//          int right = input.Length - 1;

//          while (left < right)
//          {
//              if (input[left] != input[right])
//                  return false;

//              left++;
//              right--;
//          }

//          return true;
//      }

//      static void Main()
//      {
//          Console.Write("Enter a string: ");
//          string input = Console.ReadLine();

//          if (IsPalindrome(input))
//              Console.WriteLine($"{input} is a palindrome.");
//          else
//              Console.WriteLine($"{input} is not a palindrome.");
//      }
//  }
