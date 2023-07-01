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

            Car myCar = new Car();
            myCar.Year = 2018;
            myCar.Make = "Chevrolet";
            myCar.Model = "Tahoe";
            myCar.IsDriveable = true;
            myCar.EngineNoise = "Vroom!";
            myCar.HonkNoise = "Beep beep!";

            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise(myCar.HonkNoise);

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car myCar2 = new Car();
            myCar2.Year = 1996;
            myCar2.Make = "Ford";
            myCar2.Model = "Mustang";
            myCar2.IsDriveable = true;
            myCar2.EngineNoise = "Yeet!";
            myCar2.HonkNoise = "Womp Womp!!";

            myCar2.MakeEngineNoise();
            myCar2.MakeHonkNoise(myCar2.HonkNoise);

            Car myCar3 = new Car();
            myCar3.Year = 2001;
            myCar3.Make = "Nissan";
            myCar3.Model = "Altima";
            myCar3.IsDriveable = true;
            myCar3.EngineNoise = "Buzz buzz!";
            myCar3.HonkNoise = "Ding ding!";

            myCar3.MakeEngineNoise();
            myCar3.MakeHonkNoise(myCar3.HonkNoise);

            var carList = new List<Car>() { myCar, myCar2, myCar3 };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model} {vehicle.IsDriveable} {vehicle.EngineNoise} {vehicle.HonkNoise}");
            }
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console













        }
    }
}

