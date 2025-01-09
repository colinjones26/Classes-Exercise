namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Car class
            Car myCar = new Car();

            // Object properties set 
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2023;

            // Values printing to console
            Console.WriteLine("Car Make: " + myCar.Make);
            Console.WriteLine("Car Model: " + myCar.Model);
            Console.WriteLine("Car Year: " + myCar.Year);
        }
    }
}
