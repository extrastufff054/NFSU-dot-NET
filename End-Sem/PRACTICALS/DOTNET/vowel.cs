//  using System;

//  class Program
//  {
//      static void Main()
//      {
//          Console.Write("Enter a string: ");
//          string input = Console.ReadLine();

//          string vowels = FindVowels(input);

//          Console.WriteLine($"Vowels in the string: {vowels}");
//      }

//      static string FindVowels(string input)
//      {
//          string vowels = "";
//          input = input.ToLower();

//          foreach (char c in input)
//          {
//              if (IsVowel(c))
//              {
//                  if (!vowels.Contains(c.ToString()))
//                      vowels += c;
//              }
//          }

//          return vowels;
//      }

//      static bool IsVowel(char c)
//      {
//          char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

//          foreach (char vowel in vowels)
//          {
//              if (c == vowel)
//                  return true;
//          }

//          return false;
//      }
//  }
