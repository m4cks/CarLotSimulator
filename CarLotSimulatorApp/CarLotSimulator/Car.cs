using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    //Create a seperate class file called Car
    internal class Car
    { 
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public Car()
        {

        }

        public Car(int Year, string Make, string Model, string EngineNoise, string HonkNoise, bool IsDriveable)
        {
            this.Year = Year;
            this.Make = Make;
            this.Model = Model;
            this.EngineNoise = EngineNoise;
            this.HonkNoise = HonkNoise;
            this.IsDriveable = IsDriveable;
        }

        public int Year;
        public string Make;
        public string Model;
        public string EngineNoise;
        public string HonkNoise;
        public bool IsDriveable;

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property
        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

        

    }
}
