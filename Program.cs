using Lab2;

namespace Lab4Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            BusinessLogic businessLogic = new BusinessLogic();
            businessLogic.AddAirport("KFLD", "Fond du Lac", new DateTime(2023, 9, 18), 5);
            Airport airport = businessLogic.FindAirport("KFLD");
            Console.WriteLine(airport.ToString());
            Console.WriteLine("Hello, World!");
        }
    }
}