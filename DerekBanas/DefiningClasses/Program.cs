using System;

namespace MyApp // Namespaces are wrapper for the classes, and if we want to use those classes we need to import this namespace like so: "using MyApp;"
{
    class Person
    {
        public Person() // If we delete the empty constructor we must define variables when we create a new Object.
        {
            Console.WriteLine("From Constructor!");
        }
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, int age) : this(name) // When constructors are calling each other this is called constructors chaining.
        {
            Age = age;
        }

        // Example of encapsulation we hide Age field.
        public string Name { get; set; } = ""; // This becomes property they have set and get methods.. We also can set default value: public string Name { get; set; } = "Ico"; like so.
        private int age; // private fields by convention start with smal letter or with _ dephends of the project.

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    //-------------------------------- Car Example ---------------------
    class Car
    {
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            Engine = engine;
            Tires = tires;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {
            double result = FuelQuantity - (distance * (FuelConsumption / 100));
            if (result > 0) { }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}";
        }
    }
    class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }
    }
    class Tire
    {
        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
        public int Year { get; set; }
        public double Pressure { get; set; }
    }

    //------------------------------------- Enumerations Example --------------------
    enum Season // Enumerable type of data can only be called with the listed values.
    {
        Spring, Summer, Autumn, Winter
    }
    enum Coffee // Enums also can have customized values.
    {
        Small = 100, Normal = 150, Double = 300,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person("Ani", 30);

            person.Name = "Ico";
            Console.WriteLine(person.Name);
            person.Age = 35;
            Console.WriteLine(person.Age);

            Console.WriteLine(person2.Name);
            Console.WriteLine(person2.Age);

            //-------------------------------- Car Example ---------------------
            Engine engine = new Engine(155, 2.0);
            Tire[] tires = new Tire[]
            {
                new Tire(2022, 2.2),
                new Tire(2022, 2.2),
                new Tire(2022, 2.0),
                new Tire(2022, 2.0),
            };

            Car mitsubishi = new Car("Mitsubishi", "Lancer", 2008, 60, 6.5, engine, tires);
            Console.WriteLine(mitsubishi.WhoAmI());
            mitsubishi.Drive(1000);

            //-------------------------------- Enumerations Example ---------------------
            Season season = Season.Winter;
            Console.WriteLine(season);
            Coffee coffee = Coffee.Normal;
            Console.WriteLine(coffee);
            Console.WriteLine((int)coffee); // Converting enum values.
        }
    }
}
