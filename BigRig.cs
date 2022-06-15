using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class BigRig : IVehicle
    {
        public BigRig()
        {

        }

        public void Drive()
        {
            ConsoleLogger.VehicleStartUpDialogue();
            Console.WriteLine("The BigRig is driving slowly");

        }
    }
}
