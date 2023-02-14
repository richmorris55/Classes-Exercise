using System;
namespace Classes
{
	public class Car
	{
		public Car()//Default Constructor
		{

		}

		public Car(string make, string model, int year)//Custom Constructor
		{

			Make = make;

			Model = model;

			Year = year;

		}

		public string Make { get; set; }

		public string Model { get; set; }

		public int Year { get; set; }


		
	}
}

