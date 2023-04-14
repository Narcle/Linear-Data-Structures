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
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < arr.Length; i++)//read top to bottom
        {
            stack.Push(arr[i]);          
        }
        
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(stack.Pop());
        }


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

        number7();
    }

    public static void number7()
    {
        int[] arr = new int[] { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
        int[] count = new int[arr.Length];
        int i, j;

        // loop over the given array and count the occurance of each number
        for (i = 0; i < arr.Length; i++)
        {
            count[i] = 0;
            for (j = 0; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count[i]++;
                }
            }
        }

        // print the occurance of each number
        for (i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Number " + arr[i] + " occurs " + count[i] + " times");
        }
    }

}
