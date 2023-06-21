// // Purpose: To find the smallest element of a matrix
// using System;

// namespace Smallest_Element_Matrix
// {
// 	class Smallest_Element_Matrix
// 	{
// 		static void Main()
// 		{
// 			int[,] matrix = new int[3,3];	//2D array
// 			Console.WriteLine("Enter the elements of the matrix");
// 			for(int i = 0 ; i<matrix.GetLength(0); i++)		//GetLength(0) returns the number of rows
// 			{
// 				for(int j=0; j<matrix.GetLength(1); j++)	//GetLength(1) returns the number of columns
// 				{
// 					matrix[i,j] = int.Parse(Console.ReadLine());		// taking input from the user
// 				}
// 			}
// 			int min = matrix[0,0];
// 			for(int i = 0; i<matrix.GetLength(0); i++)		//GetLength(0) returns the number of rows
// 			{
// 				for(int j=0; j<matrix.GetLength(1); j++)	//GetLength(1) returns the number of columns
// 				{
// 					if(matrix[i,j] < min)		//if the element is less than the min element
// 					{
// 						min = matrix[i,j];		//assign the element to min
// 					}
// 				}
// 			}
// 			Console.WriteLine("The smallest element of the matrix is :" + min);

// 		}

// 	}
// }