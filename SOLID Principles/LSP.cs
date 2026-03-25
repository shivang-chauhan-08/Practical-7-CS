using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.Interfaces;

namespace SOLID_Principles
{
    /// <summary>
    /// Problem : child class doesn't behave properly when used as parent
    /// </summary>

    //public class Sensor : IDevice
    //{
    //    public bool TurnOn()
    //    {
    //        throw new NotImplementedException("Sensor cannot be turned ON manually");
    //    }
    //}



    /// <summary>
    /// LSP (Liskov Substitution Principle)
    /// </summary>
    public class DeviceTester
    {
        public void TestDevice(IDevice device)
        {
            if (device.TurnOn())
            {
                Console.WriteLine("Device turned On using TestDevice");
            }
        }
    }
}