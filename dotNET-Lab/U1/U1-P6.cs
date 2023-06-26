// // Develop a C# code to find out vowels of a string

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a string: ");
//         string input = Console.ReadLine();

//         int vowelCount = CountVowels(input);

//         Console.WriteLine("The number of vowels in the string is: " + vowelCount);
//     }

//     static int CountVowels(string input)
//     {
//         int count = 0;

//         foreach (char c in input)
//         {
//             if (IsVowel(c))
//             {
//                 count++;
//             }
//         }

//         return count;
//     }

//     static bool IsVowel(char c)
//     {
//         c = char.ToLower(c);

//         return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
//     }
// }
