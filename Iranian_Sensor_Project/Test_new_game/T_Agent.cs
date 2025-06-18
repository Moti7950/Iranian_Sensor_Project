using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Iranian_Sensor_Project.Test_new_game
{
    internal class T_Agent
    {
        public string name { get; private set; }
        public int rank { get; private set; }
        public List<T_Sensors> sensors { get; private set; }

        public T_Agent(string name, List<T_Sensors> sensors, int rank = 2)
        {
            this.name = name;
            this.sensors = sensors;

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Agent: {name}, Rank: {rank}");
            Console.WriteLine("Sensors:");
            foreach (var sensor in sensors)
            {
                Console.WriteLine($" - {sensor}");
            }

        }
    }
}