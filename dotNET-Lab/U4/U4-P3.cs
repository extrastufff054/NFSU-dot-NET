// Design one mini application using C# and ADO.NET
// Here's an example of a mini application that demonstrates the usage of ADO.NET in C#. This application allows users to manage a simple employee database by adding, searching, editing, and deleting records.

using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementApp
{
    class Program
    {
        static string connectionString = "Host=localhost;Port=5432;Database=mydb;Username=postgres;Password=12345678;"; // Replace with your actual connection string

        static void Main(string[] args)
        {
            Console.WriteLine("Employee Management Application");
            Console.WriteLine("-------------------------------");

            while (true)
            {
                Console.WriteLine("\n1. Add Employee");
                Console.WriteLine("2. Search Employee");
                Console.WriteLine("3. Edit Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Exit");

                Console.Write("\nEnter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        SearchEmployee();
                        break;
                    case "3":
                        EditEmployee();
                        break;
                    case "4":
                        DeleteEmployee();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddEmployee()
        {
            Console.WriteLine("\nAdd Employee");
            Console.WriteLine("------------");

            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();

            Console.Write("Enter employee designation: ");
            string designation = Console.ReadLine();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO Employees (Name, Designation) VALUES (@Name, @Designation)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Designation", designation);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Employee added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add employee.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void SearchEmployee()
        {
            Console.WriteLine("\nSearch Employee");
            Console.WriteLine("---------------");

            Console.Write("Enter employee name to search: ");
            string searchName = Console.ReadLine();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Employees WHERE Name LIKE @SearchName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchName", "%" + searchName + "%");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            Console.WriteLine("Search results:");
                            foreach (DataRow row in dataTable.Rows)
                            {
                                Console.WriteLine($"ID: {row["Id"]}, Name: {row["Name"]}, Designation: {row["Designation"]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No matching records found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void EditEmployee()
        {
            Console.WriteLine("\nEdit Employee");
            Console.WriteLine("-------------");

            Console.Write("Enter employee ID to edit: ");
            if (!int.TryParse(Console.ReadLine(), out int employeeId))
            {
                Console.WriteLine("Invalid employee ID.");
                return;
            }

            Console.Write("Enter new name: ");
            string newName = Console.ReadLine();

            Console.Write("Enter new designation: ");
            string newDesignation = Console.ReadLine();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Employees SET Name = @NewName, Designation = @NewDesignation WHERE Id = @EmployeeId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NewName", newName);
                        command.Parameters.AddWithValue("@NewDesignation", newDesignation);
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Employee updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update employee.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void DeleteEmployee()
        {
            Console.WriteLine("\nDelete Employee");
            Console.WriteLine("---------------");

            Console.Write("Enter employee ID to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int employeeId))
            {
                Console.WriteLine("Invalid employee ID.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM Employees WHERE Id = @EmployeeId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Employee deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete employee.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
