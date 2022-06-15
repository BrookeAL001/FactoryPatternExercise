using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        public Car()
        {

        }
        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine($"The car is driving safely");
        }
    }
}
