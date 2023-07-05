using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() 
        {
            CarLot.numberOfCars++;
        }

    
   
        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }

        public void  MakeEngineNoise()
        {
            Console.WriteLine($"My car's engine sounds like: {EngineNoise}");
           
        }

        public void  MakeHonkNoise(string noise)
        {
            Console.WriteLine($"My car's horn sounds like: {noise}");
            
            
        }

        


    }
}
