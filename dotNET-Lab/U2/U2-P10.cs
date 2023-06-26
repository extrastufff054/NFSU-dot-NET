// Develop a Console application that implements all collection classes

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Dictionary<TKey, TValue>
        Console.WriteLine("Dictionary<TKey, TValue> Example:");
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        dictionary.Add("One", 1);
        dictionary.Add("Two", 2);
        dictionary.Add("Three", 3);

        foreach (KeyValuePair<string, int> kvp in dictionary)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }
        Console.WriteLine();

        // LINQ
        Console.WriteLine("LINQ Example:");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        foreach (int num in evenNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        // Sorting of collection
        Console.WriteLine("Sorting of Collection Example:");
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date" };
        fruits.Sort();

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine();

        // Defining a custom collection
        Console.WriteLine("Custom Collection Example:");
        CustomCollection<string> customCollection = new CustomCollection<string>();
        customCollection.Add("Item 1");
        customCollection.Add("Item 2");
        customCollection.Add("Item 3");

        foreach (string item in customCollection)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // Iterators
        Console.WriteLine("Iterator Example:");
        foreach (int num in EvenSequence(1, 10))
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        // Stack
        Console.WriteLine("Stack Example:");
        Stack<string> stack = new Stack<string>();
        stack.Push("Item 1");
        stack.Push("Item 2");
        stack.Push("Item 3");

        while (stack.Count > 0)
        {
            string item = stack.Pop();
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // Queue
        Console.WriteLine("Queue Example:");
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Item 1");
        queue.Enqueue("Item 2");
        queue.Enqueue("Item 3");

        while (queue.Count > 0)
        {
            string item = queue.Dequeue();
            Console.WriteLine(item);
        }
        Console.WriteLine();

        // HashSet
        Console.WriteLine("HashSet Example:");
        HashSet<string> hashSet = new HashSet<string>();
        hashSet.Add("Item 1");
        hashSet.Add("Item 2");
        hashSet.Add("Item 3");

        foreach (string item in hashSet)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Custom Collection class
    public class CustomCollection<T> : IEnumerable<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    // Iterator method
    private static IEnumerable<int> EvenSequence(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                yield return i;
            }
        }
    }
}
