// // Develop a C# code to add two values by using the concept of function overloading

// using System;

// class Calculator
// {
//     public int Add(int a, int b)
//     {
//         return a + b;
//     }

//     public double Add(double a, double b)
//     {
//         return a + b;
//     }

//     public string Add(string a, string b)
//     {
//         return a + b;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Calculator calculator = new Calculator();

//         Console.WriteLine("Enter two integers:");
//         int int1 = int.Parse(Console.ReadLine());
//         int int2 = int.Parse(Console.ReadLine());
//         int intResult = calculator.Add(int1, int2);
//         Console.WriteLine("Integer result: " + intResult);

//         Console.WriteLine("Enter two doubles:");
//         double double1 = double.Parse(Console.ReadLine());
//         double double2 = double.Parse(Console.ReadLine());
//         double doubleResult = calculator.Add(double1, double2);
//         Console.WriteLine("Double result: " + doubleResult);

//         Console.WriteLine("Enter two strings:");
//         string string1 = Console.ReadLine();
//         string string2 = Console.ReadLine();
//         string stringResult = calculator.Add(string1, string2);
//         Console.WriteLine("String result: " + stringResult);
//     }
// }
