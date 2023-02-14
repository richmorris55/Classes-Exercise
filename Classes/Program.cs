namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {

            Car budgetCar = new Car()
            {

                Make = "Ford",

                Model = "Pinto",

                Year = 1971

            };
            Console.WriteLine($"Make of Car: {budgetCar.Make}");
            Console.WriteLine($"Model of Car: {budgetCar.Model}");
            Console.WriteLine($"Year of Car: {budgetCar.Year}");


            
        }
    }
}
