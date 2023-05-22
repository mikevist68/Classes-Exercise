namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Car car1 = new Car();

            car1.Make = "toyota";
            car1.Model = "camry";
            car1.Year = 2014;

            Console.WriteLine($"Hello, my car is a {car1.Make} The model is {car1.Model} and it is a {car1.Year}.");


        }
    }
}
