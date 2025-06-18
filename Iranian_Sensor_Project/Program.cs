using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iranian_Sensor_Project.Test_new_game;

namespace Iranian_Sensor_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            T_Menu x = new T_Menu();
            x.StartGame();
        }
    }
}
