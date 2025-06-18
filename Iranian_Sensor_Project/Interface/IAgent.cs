using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Iranian_Sensor_Project
{
    internal interface IAgent
    {
        string name { get; }
        int rank { get; }

        //public Dictionary<string, int> sensor_Attached { get; private set; }
        //public IAgent(Dictionary<string, int> sensor_Attached, int rank =2)
        //{
        //    this.rank = rank;
        //    this.sensor_Attached = sensor_Attached;
        //}
    }
}
