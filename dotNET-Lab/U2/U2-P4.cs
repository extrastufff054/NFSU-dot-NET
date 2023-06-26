// // Develop a code to demonstrate the concept of multiple inheritances

// using System;

// interface IShape
// {
//     double CalculateArea();
// }

// interface IColor
// {
//     void PrintColor();
// }

// class Circle : IShape, IColor
// {
//     private double radius;
//     private string color;

//     public Circle(double radius, string color)
//     {
//         this.radius = radius;
//         this.color = color;
//     }

//     public double CalculateArea()
//     {
//         return Math.PI * radius * radius;
//     }

//     public void PrintColor()
//     {
//         Console.WriteLine("Color: " + color);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the radius of the circle: ");
//         double radius = double.Parse(Console.ReadLine());
        
//         Console.Write("Enter the color of the circle: ");
//         string color = Console.ReadLine();

//         Circle circle = new Circle(radius, color);
//         double area = circle.CalculateArea();

//         Console.WriteLine("Area: " + area);
//         circle.PrintColor();
//     }
// }
