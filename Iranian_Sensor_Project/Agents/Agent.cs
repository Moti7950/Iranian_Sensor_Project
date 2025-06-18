using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iranian_Sensor_Project
{
    internal class Agent
    {
        public string name { get; private set; }
        public int rank { get; private set; }
        public List<ISensor> sensors { get; private set; }

        public Agent(string name, int rank, List<ISensor> sensors)
        {
            this.name = name;
            this.rank = rank;
            this.sensors = sensors;
            this.sensors = sensors;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"🕵️ Agent: {name}, Rank: {rank}");
            Console.WriteLine("🔍 Sensors:");
            foreach (var sensor in sensors)
            { Console.WriteLine(sensor.ToString()); }
        }
    }
}
