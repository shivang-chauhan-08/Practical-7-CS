using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.Interfaces;

namespace SOLID_Principles
{
    /// <summary>
    /// Problem : entity depends on concrete class
    /// </summary>

    //public class SmartHomeController
    //{
    //    private Light _light = new Light();
    //    public void OperateDevice()
    //    {
    //        _light.TurnOn();
    //        _light.TurnOff();
    //    }
    //}



    /// <summary>
    /// DIP (Dependency Inversion Principle)
    /// </summary>
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
