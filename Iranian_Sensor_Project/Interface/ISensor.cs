using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iranian_Sensor_Project
{
    internal class ISensor
    {
        public string Name { get; protected set; }
        public bool IsActive { get; protected set; }

        public ISensor(string name)
        {
            Name = name;
            IsActive = true;
        }

        public void Activate()
        {
            IsActive = true;
            Console.WriteLine($"Sensor {Name} is now active.");
        }
    }
}
