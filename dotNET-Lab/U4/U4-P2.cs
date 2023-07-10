// // Design a program to provide connectivity with ADO.NET for adding, searching, editing, deleting as unbound mode

// using System;
// using System.Data;
// using System.Data.SqlClient;

// namespace ADO.NET_UnboundMode_VSCode
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string connectionString = "Host=localhost;Port=5432;Database=mydb;Username=postgres;Password=12345678;";     // Replace with your actual connection string

//             using (SqlConnection connection = new SqlConnection(connectionString))
//             {
//                 connection.Open();

//                 // Add a new record
//                 AddRecord(connection, "John", "Doe");

//                 // Search for a record
//                 DataTable searchResults = SearchRecords(connection, "John", "Doe");
//                 DisplayRecords(searchResults);

//                 // Edit a record
//                 EditRecord(connection, 1, "John", "Smith");

//                 // Delete a record
//                 DeleteRecord(connection, 1);

//                 // Display all records
//                 DataTable allRecords = GetAllRecords(connection);
//                 DisplayRecords(allRecords);
//             }
//         }

//         static void AddRecord(SqlConnection connection, string firstName, string lastName)
//         {
//             string query = "INSERT INTO Employees (FirstName, LastName) VALUES (@FirstName, @LastName)";

//             using (SqlCommand command = new SqlCommand(query, connection))
//             {
//                 command.Parameters.AddWithValue("@FirstName", firstName);
//                 command.Parameters.AddWithValue("@LastName", lastName);

//                 int rowsAffected = command.ExecuteNonQuery();

//                 if (rowsAffected > 0)
//                 {
//                     Console.WriteLine("Record added successfully.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Failed to add record.");
//                 }
//             }
//         }

//         static DataTable SearchRecords(SqlConnection connection, string firstName, string lastName)
//         {
//             string query = "SELECT * FROM Employees WHERE FirstName = @FirstName AND LastName = @LastName";

//             using (SqlCommand command = new SqlCommand(query, connection))
//             {
//                 command.Parameters.AddWithValue("@FirstName", firstName);
//                 command.Parameters.AddWithValue("@LastName", lastName);

//                 SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
//                 DataTable dataTable = new DataTable();

//                 dataAdapter.Fill(dataTable);

//                 return dataTable;
//             }
//         }

//         static void EditRecord(SqlConnection connection, int recordId, string newFirstName, string newLastName)
//         {
//             string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName WHERE Id = @Id";

//             using (SqlCommand command = new SqlCommand(query, connection))
//             {
//                 command.Parameters.AddWithValue("@FirstName", newFirstName);
//                 command.Parameters.AddWithValue("@LastName", newLastName);
//                 command.Parameters.AddWithValue("@Id", recordId);

//                 int rowsAffected = command.ExecuteNonQuery();

//                 if (rowsAffected > 0)
//                 {
//                     Console.WriteLine("Record updated successfully.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Failed to update record.");
//                 }
//             }
//         }

//         static void DeleteRecord(SqlConnection connection, int recordId)
//         {
//             string query = "DELETE FROM Employees WHERE Id = @Id";

//             using (SqlCommand command = new SqlCommand(query, connection))
//             {
//                 command.Parameters.AddWithValue("@Id", recordId);

//                 int rowsAffected = command.ExecuteNonQuery();

//                 if (rowsAffected > 0)
//                 {
//                     Console.WriteLine("Record deleted successfully.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Failed to delete record.");
//                 }
//             }
//         }

//         static DataTable GetAllRecords(SqlConnection connection)
//         {
//             string query = "SELECT * FROM Employees";

//             using (SqlCommand command = new SqlCommand(query, connection))
//             {
//                 SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
//                 DataTable dataTable = new DataTable();

//                 dataAdapter.Fill(dataTable);

//                 return dataTable;
//             }
//         }

//         static void DisplayRecords(DataTable dataTable)
//         {
//             foreach (DataRow row in dataTable.Rows)
//             {
//                 Console.WriteLine($"{row["Id"]}: {row["FirstName"]} {row["LastName"]}");
//             }
//             Console.WriteLine();
//         }
//     }
// }
