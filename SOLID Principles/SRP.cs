using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.Interfaces;

namespace SOLID_Principles
{
    /// <summary>
    /// Problem : Single class managing multiple responsibility
    /// </summary>
    
    //public class Device
    //{
    //    public void TurnOn()
    //    {
    //        Console.WriteLine("Device Turning On....");
    //    }
    //    public void TurnOff()
    //    {
    //        Console.WriteLine("Device Turning Off....");
    //    }
    //    public void Log()
    //    {
    //        Console.WriteLine("Printing Log....");
    //    }
    //    public void SendNotification()
    //    {
    //        Console.WriteLine("Sending Notification....");
    //    }
    //}



    /// <summary>
    /// SRP (Single Responsibility Principle)
    /// </summary>
    public class Device
    {
        private static Device instance;
        private Device() { }
        public static Device GetInstance()
        {
            if (instance == null)
                instance = new Device();
            return instance;
        }
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
        private static DeviceLogger instance;
        private DeviceLogger() { }
        public static DeviceLogger GetInstance()
        {
            if (instance == null)
                instance = new DeviceLogger();
            return instance;
        }
        public void Log()
        {
            Console.WriteLine("Printing Log....");
        }
    }
    public class NotificationService
    {
        private static NotificationService instance;
        private NotificationService() { }
        public static NotificationService GetInstance()
        {
            if (instance == null)
                instance = new NotificationService();
            return instance;
        }
        public void SendNotification()
        {
            Console.WriteLine("Sending Notification....");
        }
    }
}
