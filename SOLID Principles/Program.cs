using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Single Responsibility Principle (SRP)
            Console.WriteLine("===== Single Responsibility Principle : =====");
            Device device = new Device();
            device.TurnOn();
            device.TurnOff();

            DeviceLogger logger = new DeviceLogger();
            logger.Log();

            NotificationService alert = new NotificationService();
            alert.SendNotification();

            Console.WriteLine();
            Console.WriteLine();



            // OCP (Open/Closed Principle)
            Console.WriteLine("===== Open/Closed Principle : =====");
            Light light = new Light();
            Fan fan = new Fan();
            AC ac = new AC();
            DeviceManager manager = new DeviceManager();
            manager.StartDevice(light);
            manager.StopDevice(fan);
            manager.StartDevice(ac);

            Console.WriteLine();
            Console.WriteLine();



            // LSP (Liskov Substitution Principle)
            Console.WriteLine("===== Liskov Substitution Principle : =====");
            List<IDevice> devices = new List<IDevice>();
            devices.Add(light);
            devices.Add(fan);
            devices.Add(ac);

            DeviceTester tester = new DeviceTester();

            foreach (var dev in devices)
            {
                tester.TestDevice(dev);
            }

            Console.WriteLine();
            Console.WriteLine();



            // ISP (Interface Segrigation Principle)
            Console.WriteLine("===== Interface Segrigation Principle : =====");
            SecurityCamera camera = new SecurityCamera();
            camera.TurnOn();
            camera.RecordVideo();
            camera.TurnOff();

            Console.WriteLine();
            Console.WriteLine();



            // DIP (Dependency Inversion Principle)
            Console.WriteLine("===== Dependency Inversion Principle : =====");
            SmartHomeController controller = new SmartHomeController(ac);
            controller.OperateDevice();

        }
    }
}
