
# 🕵️ Sensor Strike  
**Turn-Based Console Game – Defeat the Agent by Targeting Weaknesses**

A strategic console game where you play as an investigator. Your mission: use the right sensors to expose and eliminate an undercover agent's weaknesses.

---

## 🎯 Objective

Use various sensors to match and reduce the agent’s weaknesses.  
Each correct sensor reduces the corresponding weakness by 1.  
**When all weaknesses reach zero – you win.**

---

## 🔄 Game Flow

### 🟢 1. Start  
An agent is initialized with a predefined set of weaknesses:  
Each weakness is tied to a sensor and has a value (e.g., 1–3).  
Your task is to bring all values down to **zero**.

---

### 🌀 2. Turn-Based Loop  
For each turn:
- A menu appears prompting the player to choose a sensor.
- If the chosen sensor matches a weakness:
  - The weakness value is decreased by **1**.
- If it doesn’t match or is already zero:
  - Nothing happens.

The game continues **until all weaknesses are zero**.

---

### 🏁 3. Game End  
After each turn, the system checks:
- ✅ If **all values are zero** → `Victory!`
- 🔁 Otherwise → The next turn begins

---

## 🧠 Example Weakness Set
```
Thermal Sensor     → 2  
Sound Detector     → 1  
Pressure Sensor    → 3
```

---

## 📂 Project Structure

| File             | Description                                  |
|------------------|----------------------------------------------|
| `IAgent.cs`      | Interface for the agent (name, weaknesses)   |
| `ISensor.cs`     | Interface for the sensor                     |
| `Sensor.cs`      | Optional sensor implementation               |
| `Manager.cs`     | Main logic – turns, checks, progression      |
| `Menu.cs`        | Menu system – player interaction             |
| `Program.cs`     | Entry point of the application               |

---

## 🛠 Technologies Used

- **Language:** C#  
- **Framework:** .NET Framework 4.7.2  
- **Type:** Console Application

---

## 👤 Author  
Created with passion by **Moti Kopshitz**.
