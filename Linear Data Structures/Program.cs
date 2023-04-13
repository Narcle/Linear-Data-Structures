using System;
using System.Collections;

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
        Console.ReadKey();

        //9.
    }

}
