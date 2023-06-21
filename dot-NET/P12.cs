// Write a program to demonstrate Jagged Array

using System;
namespace Jagged_Array
{
	class Jagged_Array
	{
		static void Main()
		{
			int[][] jaggedArray = new int[3][];
			jaggedArray[0] = new int[5];
			jaggedArray[1] = new int[3];
			jaggedArray[2] = new int[2];
			Console.WriteLine("Enter the elements of the jagged array:");
			for(int i = 0; i < jaggedArray.Length; i++)
			{
				for(int j = 0; j < jaggedArray[i].Length; j++)
				{
					jaggedArray[i][j] = int.Parse(Console.ReadLine());
				}
			}
			Console.WriteLine("The elements of the jagged array are:");
			for(int i = 0; i < jaggedArray.Length; i++)
			{
				for(int j = 0; j < jaggedArray[i].Length; j++)
				{
					Console.Write(jaggedArray[i][j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}