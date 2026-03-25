using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.Interfaces;

namespace SOLID_Principles
{
    // LSP (Liskov Substitution Principle)
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