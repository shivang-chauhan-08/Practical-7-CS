using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_Principles.Interfaces;

namespace SOLID_Principles
{
    // ISP (Interface Segrigation Principle)
    public class SecurityCamera : ISwitchable, ICamera
    {
        public void TurnOn()
        {
            Console.WriteLine("Security Camera Turning On....");
        }
        public void TurnOff()
        {
            Console.WriteLine("Security Camera Turning Off....");
        }
        public void RecordVideo()
        {
            Console.WriteLine("Security Camera is Recording Video....");
        }
    }
}
