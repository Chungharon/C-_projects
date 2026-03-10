namespace MaizeCalculator
{
    // This class encapsulates the maize price calculation logic.
    // The entry point has been removed to avoid multiple Main methods
    // in the project. Call Calculate() from a single Program.Main.
    public static class PriceCalculator
    {
        public static void Calculate()
        {
            int bags;
            double pricePerBag;
            double totalIncome;

            Console.WriteLine("Number of maize bags harvested: ");
            bags = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per bag: ");
            pricePerBag = Convert.ToDouble(Console.ReadLine());

            totalIncome = pricePerBag * bags;

            Console.WriteLine($"Total income is ${totalIncome}");
        }
    }
}
