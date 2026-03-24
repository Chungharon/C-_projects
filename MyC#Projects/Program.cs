// using System;
// using MaizeCalculator;

// namespace ForceCalculator
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World");
//             int[] numbers,randoms;
//             double[] trigs;


//             numbers = new int[100];
//             randoms = new int[100];
//             trigs = new double[100];

//             for (int i = 0; i < 100; i++) numbers[i] = i;
//             for (int i = 0; i < 100; i++) Console.WriteLine($"The cube of {i}{numbers[i]}");

//             Random rnd = new Random();
//             for (int i = 0; i < 100; i++) randoms[i] = rnd.Next(100);

//             for (int i = 0; i < 100; i++) Console.WriteLine($"The cube of {i}{randoms[i]}");

//             // call the maize price calculator from the other namespace
//             Console.WriteLine("\nRunning maize price calculator:\n");
//             PriceCalculator.Calculate();

//         }
//     }
// }




