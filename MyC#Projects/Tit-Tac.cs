using System;
using System.Threading;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 9 };
        
        for (int i = 0; i < numbers.Length - 1; i++) 
        {
            for (int j = 0; j < numbers.Length - i - 1; j++) 
            {
                // Visualize current comparison
                Console.WriteLine($"Comparing {numbers[j]} and {numbers[j+1]}");
        
                if (numbers[j] > numbers[j + 1]) 
                {
                    // Swap
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
            
                    Console.WriteLine("Swapped!");
                }
                
                PrintArray(numbers); // Now this method exists below
                Thread.Sleep(1000);
            }
        }
        
        Console.WriteLine("Final sorted array:");
        PrintArray(numbers);
    }

    // Added helper method to print the array
    public static void PrintArray(int[] arr)
    {
        Console.WriteLine("[" + string.Join(", ", arr) + "]");
    }
}
