using System;

class ProjectileMotion
{
    static void Main()
    {
        // Program Title
        Console.WriteLine("===============================");
        Console.WriteLine(" Group One Motion Calculator");
        Console.WriteLine("===============================");

        // Variables input user
        Console.Write("Enter Initial velocity (v0) in m/s: ");
        double v0 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter launch angle (theta) in degrees: ");
        double theta = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter gravitational (g) in mls/s^2: ");
        double g = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time (t) in seconds: ");
        double t = Convert.ToDouble(Console.ReadLine());

        // converstion degress to radians(radians)
        double thetaRad = theta * Math.PI / 180.0;

        // calculations
        double t = 0.0;
        double x, y;


        double maxHeight = 0.0;

        // calculation of flight time using a formula
        double timeOfflight = 2 * v0 * Math.Sin(thetaRad) / g;
        // lets calculate the range
        double range = v0 * maxHeight.Cos(thetaRad) * timeOfflight;

        // maximum height using formula
        double maxHeighFormula = v0 * v0 * Math.Sin(thetaRad) * Math.Sin(thetaRad) / (2 * g);

        Console.WriteLine("\nCalculating project motion.....\n");

        // printing table header
        Console.WriteLine("Time (t). x-position(m) y-position(m)");
        Console.WriteLine("===============================");


        // Stimulating the motion until y becomes negative
        while (true)
        {
            x = v0 * Math.Cos(thetaRad) * t;
            y = v0 * Math.Sin(thetaRad) * t - 0.5 * g * t * t;

            // Trackking maximum height from simulation
            if (y > maxHeight)
            {
                maxHeight = y;
            }

            // stopping if projectile has hit the graound (y < 0)
            if (y < 0)
            {
                break;
            }
            //print current time and positions in(float point)
            Console.WriteLine($"{t,6:F2} {x,6:F2} {y,6:F2}");

            // Increase time by the time step
            t += deltaT;
        }
        // Output
        Console.WriteLine("\n===============================");
        Console.WriteLine(" RESULTS");
        Console.WriteLine("===============================");
        Console.WriteLine($"Time of Flight (T): {timeOfFlight:F2} seconds");
        Console.WriteLine($"Range (R): {range:F2} meters");
        Console.WriteLine($"Maximum Height (H) - Formula: {maxHeightFormula:F2} meters");
        Console.WriteLine($"Maximum Height (H) - Simulation: {maxHeight:F2} meters");
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}