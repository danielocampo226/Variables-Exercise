namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string name = "John";
            int age = 31;
            char middleInitial = 'D';
            bool isOver18 = true;
            double currentTemp = 77.9;
            decimal currentPrice = 29.99m;
            
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");   
            Console.WriteLine($"middleInitial: {middleInitial}");
            Console.WriteLine($"IsOver18: {isOver18}");
            Console.WriteLine($"currentTemp: {currentTemp}");
            Console.WriteLine($"currentPrice: {currentPrice}");

        }
    }
}
