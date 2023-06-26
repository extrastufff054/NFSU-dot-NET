// // Develop a C# code to demonstrate the concept of Multilevel Inheritance

// using System;

// class Vehicle
// {
//     public void Start()
//     {
//         Console.WriteLine("Vehicle started.");
//     }

//     public void Stop()
//     {
//         Console.WriteLine("Vehicle stopped.");
//     }
// }

// class Car : Vehicle
// {
//     public void Accelerate()
//     {
//         Console.WriteLine("Car accelerating.");
//     }

//     public void Brake()
//     {
//         Console.WriteLine("Car braking.");
//     }
// }

// class SportsCar : Car
// {
//     public void Boost()
//     {
//         Console.WriteLine("Sports car boosting.");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the type of car (1 - Car, 2 - SportsCar):");
//         int carType = Convert.ToInt32(Console.ReadLine());

//         if (carType == 1)
//         {
//             Car car = new Car();
//             car.Start();
//             car.Accelerate();
//             car.Brake();
//             car.Stop();
//         }
//         else if (carType == 2)
//         {
//             SportsCar sportsCar = new SportsCar();
//             sportsCar.Start();
//             sportsCar.Accelerate();
//             sportsCar.Brake();
//             sportsCar.Boost();
//             sportsCar.Stop();
//         }
//         else
//         {
//             Console.WriteLine("Invalid car type.");
//         }
//     }
// }
