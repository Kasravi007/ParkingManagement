# 🅿️ Parking Management System

This is a **console-based Parking Management System** developed in **C#**, designed to simulate a basic parking lot that handles **vehicle entry**, **exit**, **slot assignment**, and **billing**. This system is ideal for small to medium-sized parking lot management.

## 🚗 Features

- Add vehicles with details (number, type)
- Assign the nearest available parking slot
- Track parked vehicles
- Handle vehicle exit and release slots
- Calculate parking duration and charges
- Display available and occupied slots
- Prevent duplicate entries
- Clean and interactive command-line interface

## 📋 How It Works

### 1. On Startup
The application initializes the parking lot with a fixed number of slots (configurable). Each slot has a unique **slot number**.

### 2. Main Menu Options
The console shows the following options:


### 3. Park Vehicle
- Prompts for vehicle number and type (Car, Bike, etc.)
- Assigns the **nearest available slot**
- Records entry **timestamp**
- Displays assigned slot number

### 4. Remove Vehicle
- Prompts for vehicle number
- Calculates duration based on time-in and time-out
- Calculates total **parking fee** based on duration and type
- Frees the slot for new vehicles

### 5. View Parking Slots
Displays current parking status in tabular format:


### 6. Exit
Gracefully terminates the program.

## 💰 Sample Billing Logic

- First 2 hours: Free
- Next hours: ₹20/hour (customizable)
- Additional fees based on vehicle type (e.g., ₹10/hr extra for SUVs)

> ⚠️ Billing logic can be customized as per requirement.

## 🛠️ Tech Stack

- **Language:** C#
- **Framework:** .NET 6.0 or later
- **Type:** Console Application

## ▶️ How to Run

1. Clone the repository or download the `.cs` file.
2. Open it using Visual Studio or VS Code.
3. Run via terminal or IDE:

```bash
dotnet run
