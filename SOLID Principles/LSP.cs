using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    // LSP (Liskov Substitution Principle)
    public class DeviceTester
    {
        public void TestDevice(IDevice device)
        {
            device.TurnOn();
        }
    }
}