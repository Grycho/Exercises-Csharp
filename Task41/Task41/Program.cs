using System;

namespace Task41
{
    class Program
    {
        struct DataHuman
        {
            public string Name, Surname, Gender;
            public int Age, Height;
        }
        struct DataCar
        {
            public string BrandCar, ModelCarName, Color;
            public int YearProductCar, EngineCapacity; 
        }
        struct DataBook
        {
            public string Title, AuthorName, AuthorSurname, CoverType;
            public int HowManyPages;
        }
        struct DataPhone
        {
            public string BrandPhone, ModelPhoneName;
            public int YearPhone, Megapixels, WeightPhone;
        }
        static void Main(string[] args)
        {
            //[Structures]The program will read data about any object, each object described with 5 parameters. 

            DataHuman Person;
            Console.Write("Name: ");
            Person.Name = Console.ReadLine();
            Console.Write("Surname: ");
            Person.Surname = Console.ReadLine();
            Console.Write("Gender: ");
            Person.Gender = Console.ReadLine();
            Console.Write("Age: ");
            Person.Age = int.Parse(Console.ReadLine());
            Console.Write("Height: ");
            Person.Height = int.Parse(Console.ReadLine());

            DataCar Car;
            Console.Write("\nVehicle brand: ");
            Car.BrandCar = Console.ReadLine();
            Console.Write("Model name: ");
            Car.ModelCarName = Console.ReadLine();
            Console.Write("Color: ");
            Car.Color = Console.ReadLine();
            Console.Write("Year of production: ");
            Car.YearProductCar = int.Parse(Console.ReadLine());
            Console.Write("Engine capacity: ");
            Car.EngineCapacity = int.Parse(Console.ReadLine());

            DataBook Book;
            Console.Write("\nThe title of your favorite book: ");
            Book.Title = Console.ReadLine();
            Console.Write("The name of the author: ");
            Book.AuthorName = Console.ReadLine();
            Console.Write("The surname of the author: ");
            Book.AuthorSurname = Console.ReadLine();
            Console.Write("What kind of book cover(hard/soft): ");
            Book.CoverType = Console.ReadLine();
            Console.Write("How many pages: ");
            Book.HowManyPages = int.Parse(Console.ReadLine());

            DataPhone Smartphone;
            Console.Write("\nSmartphone's brand: ");
            Smartphone.BrandPhone = Console.ReadLine();
            Console.Write("Smartphone's model name:");
            Smartphone.ModelPhoneName = Console.ReadLine();
            Console.Write("Year of purchase: ");
            Smartphone.YearPhone = int.Parse(Console.ReadLine());
            Console.Write("How many megapixels: ");
            Smartphone.Megapixels = int.Parse(Console.ReadLine());
            Console.Write("What a weight: ");
            Smartphone.WeightPhone = int.Parse(Console.ReadLine());
        }
    }
}
