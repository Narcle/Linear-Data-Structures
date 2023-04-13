using System;
using System.Collections;
using System.Collections.Generic;

//
class MainClass
{
    public static void Main(string[] args)
    {
        //2. 
        Console.WriteLine("N Integers (uses spaces between numbers):");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for (int i = (arr.Length-1); i > -1; i--)//read top to bottom
        {
            Console.WriteLine(arr[i]);
        }
        //less to code than push/pop


        //7. 
        int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
        var dict = new Dictionary<int, int>();

        foreach (var value in array)
        {
            // When the key is not found, "count" will be initialized to 0
            dict.TryGetValue(value, out int count);
            dict[value] = count + 1;
        }

        foreach (var pair in dict)
            Console.WriteLine("Value {0} counted {1} times.", pair.Key, pair.Value);       

        //9. 
        Queue<int> queue = new Queue<int>();
        Console.WriteLine("Queue Integer N:");
        int num = Convert.ToInt32(Console.ReadLine());//Start with N
        int newnum = 0;
        queue.Enqueue(num);
        Console.WriteLine(num);

        while (queue.Count < 50)
        {          
            num = queue.Dequeue();
            
            newnum = num + 1;
            queue.Enqueue(newnum);
            Console.WriteLine(newnum);

            newnum = 2 * num + 1;
            queue.Enqueue(newnum);
            Console.WriteLine(newnum);

            newnum = num + 2;
            queue.Enqueue(newnum);
            Console.WriteLine(newnum);           
        }
    }
}
