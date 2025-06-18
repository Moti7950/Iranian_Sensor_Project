using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iranian_Sensor_Project.Test_new_game
{
    internal class T_Sensors
    {
            public string Name { get; private set; }
            public bool IsActive { get; private set; }

            public T_Sensors(string name)
            {
                Name = name;
                IsActive = true;
            }

            public void Deactivate()
            {
                IsActive = false;
            }

            public void Activate()
            {
                IsActive = true;
            }

            public override string ToString()
            {
                return $"{Name} (Active: {IsActive})";
            }
        
    }
}
