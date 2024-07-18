using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot carLot = new CarLot();

            Car car1 = new Car();
            car1.Make = "Ford";
            car1.Model = "Mustang";
            car1.Year = 2014;
            car1.EngineNoise = "BROOOOOOOM";
            car1.HonkNoise = "HOOOOONK";
            car1.IsDriveable = true;
            carLot.Cars.Add(car1);

            Car car2 = new Car
            {
                Make = "Mazda",
                Model = "RX-7",
                Year = 1993,
                EngineNoise = "BRAAPBRAAPBRAAP",
                HonkNoise = "BEEEEEEP",
                IsDriveable = true
            };
            carLot.Cars.Add(car2);

            Car car3 = new Car("Nissan", "GT-R", 2015, "VOOOOOOMVROOOOOM", "MEEEEEEEP", true);
            carLot.Cars.Add(car3);
            
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            
            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("\nCars at the Car Lot: ");
            foreach (var car in carLot.Cars)
            {
              Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");  
            }
        }
    }
}
