using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE

            //DONE - Create a seperate class file called Car
            //FINISHED - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //FINISHED - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //FINISHED - The methods should take one string parameter: the respective noise property            


            //Now that the Car class is created we can instanciate 3 new cars

            //Set the properties for each of the cars
            

            // First Car Instantiation - Dot Notation
            var gregsCar = new Car();
            gregsCar.Make = "Jeep";
            gregsCar.Model = "Patriot";
            gregsCar.Year = 2016;
            gregsCar.EngineNoise = "I'm Smart!!!!";
            gregsCar.HonkNoise = "onk";
            gregsCar.IsDriveable = true;

            //Second Car - Wife's Car - Dot Notation
            var brandisCar = new Car();
            brandisCar.Make = "Chevy";
            brandisCar.Model = "Equinox";
            brandisCar.Year = 2018;
            brandisCar.EngineNoise = "I'm A Savage!!!!";
            brandisCar.HonkNoise = "tut-tut";
            brandisCar.IsDriveable = true;

            //Thrid Car - Second Instantiation - Object Initalizer Syntax
            var cheronsCar = new Car()
            {
                Year = 1988,
                Make = "Buick",
                Model = "Regal",
                EngineNoise = "...",
                HonkNoise = "urnk...urnk",
                IsDriveable = false,
            };

            //Fourth Car - Dream Car - Makes 3rd Instantiation - Using Constructor to allow parameters to be
            //placed inside of properites.
            var gregsCar2 = new Car(2020, "Mercedes", "G-Wagon", "doom..doom", "uuurrnnnkkk", true);

            //Call each of the methods for each car
            gregsCar.MakeEngineNoise();
            brandisCar.MakeEngineNoise();
            cheronsCar.MakeEngineNoise();
            gregsCar2.MakeEngineNoise();


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
