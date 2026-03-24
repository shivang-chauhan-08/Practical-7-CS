using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    // ISP (Interface Segrigation Principle)
    public interface ISwitchable
    {
        void TurnOn();
        void TurnOff();
    }
    public interface ICamera
    {
        void RecordVideo();
    }
    public interface IStreamable
    {
        void StreamOn();
        void StreamOff();
    }
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
