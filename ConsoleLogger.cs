using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternExercise
{
    public class ConsoleLogger
    {
        public static void VehicleStartUpDialogue()
        {
            Console.WriteLine("Put key in ignition");
            Thread.Sleep(1000);
            Console.WriteLine("Turn the key");
            Thread.Sleep(1000);
        }
    }
}
