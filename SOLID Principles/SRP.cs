using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    // SRP (Single Responsibility Principle)
    public class Device
    {
        public void TurnOn()
        {
            Console.WriteLine("Device Turning On....");
        }
        public void TurnOff()
        {
            Console.WriteLine("Device Turning Off....");
        }
    }
    public class DeviceLogger
    {
        public void Log()
        {
            Console.WriteLine("Printing Log....");
        }
    }
    public class NotificationService
    {
        public void SendNotification()
        {
            Console.WriteLine("Sending Notification....");
        }
    }
}
