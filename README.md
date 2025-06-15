🎯 Sensor Strike – Turn-Based Agent Weakness Game
Sensor Strike is a turn-based console game where you play as an investigator trying to break an agent by exploiting their weaknesses.
Each sensor you choose targets a specific weakness. The goal is to reduce all weaknesses to zero and defeat the agent.

🧭 Game Flow
1. Game Start
At the beginning, an agent is loaded with a dictionary of weaknesses.
For example:

Thermal Sensor → 2

Sound Detector → 1

Pressure Sensor → 3

Each number represents how many times a specific sensor must be applied to neutralize that weakness.

2. Turn Loop
In every round:

A sensor selection menu is displayed.

The player chooses a sensor.

If the sensor matches an existing weakness and the value is above zero, the value is decreased by 1.

If it doesn't match or is already at zero – nothing happens.

This process repeats every turn until all weaknesses are reduced to zero.

3. End of Game
At the end of each turn, the game checks:

If all weakness values are zero, the game ends with a victory message:
"You defeated the agent!"

Otherwise – the game continues to the next round.

📁 Project Structure
IAgent.cs – Interface for the agent (name + weaknesses)

ISensor.cs – Interface for sensors (name + active state)

Sensor.cs – Optional class for implementing a concrete sensor

Manager.cs – Core game logic: turn handling, weakness checks

Menu.cs – Sensor selection menu and player interaction

Program.cs – Main entry point of the game

🛠 Technologies
Programming Language: C#

Framework: .NET Framework 4.7.2

Type: Console Application

