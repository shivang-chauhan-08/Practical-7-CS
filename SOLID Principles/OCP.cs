using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    // OCP (Open/Closed Principle)
    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }

    public class Light : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("The Light is Turinng On.....");
        }
        public void TurnOff()
        {
            Console.WriteLine("The Light is Turinng Off.....");
        }
    }
    public class Fan : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("The Fan is Turinng On.....");
        }
        public void TurnOff()
        {
            Console.WriteLine("The Fan is Turinng Off.....");
        }
    }
    public class AC : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("The AC is Turinng On.....");
        }
        public void TurnOff()
        {
            Console.WriteLine("The AC is Turinng Off.....");
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
