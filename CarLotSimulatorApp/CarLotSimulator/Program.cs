using System;

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

            //INSTANTIATE CARLOT
            CarLot carLot = new CarLot();

            //SETTING PROPERTIES 3 DIFFERENT WAYS FOR CARS
            Car car1 = new Car() { Year = 2010, Make = "Honda", Model = "Civic", EngineNoise = "*vrum*", HonkNoise = "Honk", IsDriveable = true };
            Car car2 = new Car(1990, "Toyota", "Camota", "*vrOOm*", "HREnK", true);
            Car car3 = new Car();
            car3.Year = 1900;
            car3.Make = "Ferrari";
            car3.Model = "GT3";
            car3.EngineNoise = "*VRRRskdfnvx*";
            car3.HonkNoise = "hRuNkk";
            car3.IsDriveable = false;

            //ADDING CARS TO THE CARLOT
            carLot.CarList.Add(car1);
            carLot.CarList.Add(car2);
            carLot.CarList.Add(car3);

            Console.WriteLine("Engine Noises:");
            car1.MakeEngineNoise();
            car2.MakeEngineNoise();
            car3.MakeEngineNoise();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Honk Noises:");
            car1.MakeHonkNoise();
            car2.MakeHonkNoise();
            car3.MakeHonkNoise();

            Console.WriteLine("------------- Iterate through CarLot -------------");
            foreach(Car c in carLot.CarList)
            {
                Console.WriteLine($"Year: {c.Year} | Make: {c.Make} | Model: {c.Model}");
            }

            //*************BONUS*************//

            //==================================DONE==================================================
            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //==================================DONE==================================================

            //*************BONUS X 2*************//

            //==================================DONE==================================================
            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            //==================================DONE=================================================

        }
    }
}
