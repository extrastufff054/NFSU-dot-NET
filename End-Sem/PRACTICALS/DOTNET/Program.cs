// using System;
// using System.Collections;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // ArrayList
//         ArrayList arrayList = new ArrayList();
//         arrayList.Add("Hello");
//         arrayList.Add(123);
//         arrayList.Add(true);

//         Console.WriteLine("ArrayList:");
//         foreach (var item in arrayList)
//         {
//             Console.WriteLine(item);
//         }

//         Console.WriteLine();

//         // List
//         List<int> list = new List<int>();
//         list.Add(10);
//         list.Add(20);
//         list.Add(30);

//         Console.WriteLine("List:");
//         foreach (var item in list)
//         {
//             Console.WriteLine(item);
//         }

//         Console.WriteLine();

//         // Stack
//         Stack<string> stack = new Stack<string>();
//         stack.Push("First");
//         stack.Push("Second");
//         stack.Push("Third");

//         Console.WriteLine("Stack:");
//         while (stack.Count > 0)
//         {
//             Console.WriteLine(stack.Pop());
//         }

//         Console.WriteLine();

//         // Queue
//         Queue<string> queue = new Queue<string>();
//         queue.Enqueue("First");
//         queue.Enqueue("Second");
//         queue.Enqueue("Third");

//         Console.WriteLine("Queue:");
//         while (queue.Count > 0)
//         {
//             Console.WriteLine(queue.Dequeue());
//         }

//         Console.WriteLine();

//         // Dictionary
//         Dictionary<string, int> dictionary = new Dictionary<string, int>();
//         dictionary.Add("Apple", 1);
//         dictionary.Add("Banana", 2);
//         dictionary.Add("Orange", 3);

//         Console.WriteLine("Dictionary:");
//         foreach (var kvp in dictionary)
//         {
//             Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//         }

//         Console.WriteLine();

//         // HashSet
//         HashSet<int> hashSet = new HashSet<int>();
//         hashSet.Add(1);
//         hashSet.Add(2);
//         hashSet.Add(3);

//         Console.WriteLine("HashSet:");
//         foreach (var item in hashSet)
//         {
//             Console.WriteLine(item);
//         }

//         Console.WriteLine();
//     }
// }
