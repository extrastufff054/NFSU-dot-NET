// // Develop a C# code to demonstrate the concept of Hybrid Inheritance

// using System;

// interface IShape
// {
//     void Draw();
// }

// class Shape
// {
//     public string color; // Make color field public

//     public Shape(string color)
//     {
//         this.color = color;
//     }
// }

// class Rectangle : Shape, IShape
// {
//     private int width;
//     private int height;

//     public Rectangle(string color, int width, int height) : base(color)
//     {
//         this.width = width;
//         this.height = height;
//     }

//     public void Draw()
//     {
//         Console.WriteLine($"Drawing a {color} rectangle with width {width} and height {height}");
//     }
// }

// class Circle : Shape, IShape
// {
//     private int radius;

//     public Circle(string color, int radius) : base(color)
//     {
//         this.radius = radius;
//     }

//     public void Draw()
//     {
//         Console.WriteLine($"Drawing a {color} circle with radius {radius}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Rectangle rectangle = new Rectangle("red", 5, 3);
//         Circle circle = new Circle("blue", 7);

//         Console.WriteLine($"Rectangle color: {rectangle.color}");
//         Console.WriteLine($"Circle color: {circle.color}");

//         rectangle.Draw();
//         circle.Draw();
//     }
// }
