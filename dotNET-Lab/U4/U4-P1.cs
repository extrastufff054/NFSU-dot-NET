// // Design a program to provide connectivity with ADO.NET for adding, searching, editing, deleting as bound mode
// using System;
// using System.Data;
// using System.Data.SqlClient;

// namespace ADO.NET_BoundMode_VSCode
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string connectionString = "Host=localhost;Port=5432;Database=mydb;Username=postgres;Password=12345678;";    // Replace with your actual connection string

//             using (SqlConnection connection = new SqlConnection(connectionString))
//             {
//                 connection.Open();

//                 // Create a SqlDataAdapter and a DataTable
//                 SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Employees", connection);
//                 DataTable dataTable = new DataTable();

//                 // Fill the DataTable with data from the database
//                 dataAdapter.Fill(dataTable);

//                 // Display the data in the DataTable
//                 DisplayData(dataTable);

//                 // Add a new row
//                 DataRow newRow = dataTable.NewRow();
//                 newRow["FirstName"] = "John";
//                 newRow["LastName"] = "Doe";
//                 dataTable.Rows.Add(newRow);

//                 // Update the database with the changes
//                 dataAdapter.Update(dataTable);

//                 // Display the updated data
//                 Console.WriteLine("Data updated successfully.");
//                 DisplayData(dataTable);

//                 // Search for a specific record
//                 DataRow[] foundRows = dataTable.Select("FirstName = 'John' AND LastName = 'Doe'");
//                 if (foundRows.Length > 0)
//                 {
//                     DataRow row = foundRows[0];
//                     Console.WriteLine($"Found record: {row["FirstName"]} {row["LastName"]}");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Record not found.");
//                 }

//                 // Edit the record
//                 if (foundRows.Length > 0)
//                 {
//                     DataRow row = foundRows[0];
//                     row["LastName"] = "Smith";
//                     dataAdapter.Update(dataTable);
//                     Console.WriteLine("Record updated successfully.");
//                     DisplayData(dataTable);
//                 }

//                 // Delete the record
//                 if (foundRows.Length > 0)
//                 {
//                     DataRow row = foundRows[0];
//                     row.Delete();
//                     dataAdapter.Update(dataTable);
//                     Console.WriteLine("Record deleted successfully.");
//                     DisplayData(dataTable);
//                 }
//             }
//         }

//         static void DisplayData(DataTable dataTable)
//         {
//             foreach (DataRow row in dataTable.Rows)
//             {
//                 Console.WriteLine($"{row["FirstName"]} {row["LastName"]}");
//             }
//             Console.WriteLine();
//         }
//     }
// }
