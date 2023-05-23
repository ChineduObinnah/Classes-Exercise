namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "4Runner";
            myCar.Year =  2023;

            Console.WriteLine($"This is a {myCar.Make} {myCar.Model} {myCar.Year} it's really tough");
        }
    }
}
