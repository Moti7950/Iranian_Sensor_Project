using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iranian_Sensor_Project.Test_new_game
{
    //הפיצרים המרכזים 1)
    //1) סוכן 
    //2) חיישנים ומתודה להפעלה
    //3) פיצר שנותן הצמדה של חיישן לסוכן
    //4) אחרי ההצמדה פיצר שמשווה בין החיישנים המוצמדים לחיישנים של החולשות
    internal class T_Menu
    {
        //פה אני רוצה לבנות חלוקה רנדומלית של חיישנים
        public void randomSensors()
        { }
        public void StartGame()
        {
            List<T_Sensors> sensors = new List<T_Sensors>
            {    //יש תקלה שלבדיקה פעם ראשונה האם קיים הוא לא מצליח לכבות את השני, תיקנתי את זה בשורה 56 בזמן שלא עובר להמשך הקקוד
                 new T_Sensors("Cellular"),
                 new T_Sensors("Cellular")
            };

            T_Agent agent1 = new T_Agent("Ali", sensors);
            int totalSensors = sensors.Count;

            Console.WriteLine($"Agent created with {totalSensors} sensors.");
            agent1.PrintInfo();

            int hits = 0;

            while (hits < totalSensors)
            {
                Console.Write("Enter the name of the sensor to hit: ");
                string input = Console.ReadLine();

                
                T_Sensors target = null;

                foreach (T_Sensors sensor in agent1.sensors)
                {
                    if (sensor.Name == input)
                    {
                        target = sensor;
                        break;
                    }
                }

                if (target == null)
                {
                    Console.WriteLine($"Sensor '{input}' not found.");
                    //הוספה של רשימה חיישנים שלא היו במצב פעיל להוסיף לרשימה נוספת
                    continue;
                }

                if (!target.IsActive)
                {
                    //בנוסף לשינוי על פעיל ולא פעיל להוסיף את החיישן לרשימה נוספת
                    Console.WriteLine($"Sensor '{target.Name}' is already OFF.");
                    
                }

                target.Deactivate();
                hits++;
                Console.WriteLine($"HIT! Sensor '{target.Name}' is now OFF.");
                Console.WriteLine($"Total hits: {hits} / {totalSensors}");
            }

            Console.WriteLine("All sensors have been hit. Game over.");
        }
    }
}
