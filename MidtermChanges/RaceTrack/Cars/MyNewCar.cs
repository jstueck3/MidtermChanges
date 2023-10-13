using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RaceTrack.RaceTrack.Cars
{
    public class MyNewCar : RaceCar
    {
        public MyNewCar(string name, int topSpeed)
        {
            Name = name;
            TopSpeed = topSpeed;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"Starting the engine of my custom car, {Name}!");
        }

        public override void Brake()
        {
            Console.WriteLine($"My custom car, {Name}, comes to a screeching halt!");
        }

    }
}
