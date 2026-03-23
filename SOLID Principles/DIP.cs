using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    // DIP (Dependency Inversion Principle)
    public class SmartHomeController
    {
        private IDevice _device;
        public SmartHomeController(IDevice device)
        {
            _device = device;
        }
        public void OperateDevice()
        {
            _device.TurnOn();
            _device.TurnOff();
        }
    }
}
