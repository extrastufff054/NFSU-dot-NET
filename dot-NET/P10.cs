using System;

namespace Sphere
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the radius of the sphere: ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Enter 'volume' or 'surface area': ");
            string choice = Console.ReadLine();

            if (choice == "volume")
            {
                double sphereVolume = CalculateVolume(r);
                Console.WriteLine("Volume of the sphere is: {0}", sphereVolume);
            }
            else if (choice == "surface area")
            {
                double sphereSurfaceArea = CalculateSurfaceArea(r);
                Console.WriteLine("Surface area of the sphere is: {0}", sphereSurfaceArea);
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose 'volume' or 'surface area'.");
            }
        }

        static double CalculateVolume(double r)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3);
            return volume;
        }

        static double CalculateSurfaceArea(double r)
        {
            double surfaceArea = 4 * Math.PI * Math.Pow(r, 2);
            return surfaceArea;
        }
    }
}
