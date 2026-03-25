using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.Interfaces;

namespace SOLID_Principles
{
    /// <summary>
    /// Problem : To add new feature add specific methods in different class.
    /// </summary>

    //public class Light
    //{
    //    public bool TurnOn()
    //    {
    //        Console.WriteLine("The Light is Turinng On.....");
    //        return true;
    //    }
    //}
    //public class Fan
    //{
    //    public bool TurnOff()
    //    {
    //        Console.WriteLine("The Fan is Turinng Off.....");
    //        return true;
    //    }
    //}



    /// <summary>
    /// OCP (Open/Closed Principle)
    /// </summary>
    public class Light : IDevice
    {
        public bool TurnOn()
        {
            Console.WriteLine("The Light is Turinng On.....");
            return true;
        }
        public bool TurnOff()
        {
            Console.WriteLine("The Light is Turinng Off.....");
            return true;
        }
    }
    public class Fan : IDevice
    {
        public bool TurnOn()
        {
            Console.WriteLine("The Fan is Turinng On.....");
            return true;
        }
        public bool TurnOff()
        {
            Console.WriteLine("The Fan is Turinng Off.....");
            return true;
        }
    }
    public class AC : IDevice
    {
        public bool TurnOn()
        {
            Console.WriteLine("The AC is Turinng On.....");
            return true;
        }
        public bool TurnOff()
        {
            Console.WriteLine("The AC is Turinng Off.....");
            return true;
        }
    }

    public class DeviceManager
    {
        public void StartDevice(IDevice device)
        {
            device.TurnOn();
        }
        public void StopDevice(IDevice device)
        {
            device.TurnOff();
        }
    }
}
