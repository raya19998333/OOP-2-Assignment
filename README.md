<h1 align="center">💼 OOP-2 Assignment — MakeenSalalah Repository</h1>

<p align="center">
  <img src="https://img.shields.io/badge/Language-C%23-blue?style=for-the-badge" alt="C#">
  <img src="https://img.shields.io/badge/Status-Completed-success?style=for-the-badge" alt="Status">
  <img src="https://img.shields.io/badge/Concepts-OOP%20Fundamentals-lightgrey?style=for-the-badge" alt="OOP">
  <img src="https://img.shields.io/badge/Author-Raya_Al_Amri-blueviolet?style=for-the-badge" alt="Author">
</p>
---

## 🗂️ Table of Contents
- [📋 Assignment Rules](#-assignment-rules)
- [📘 OOP Assignment 1 — Book Class System](#-oop-assignment-1--book-class-system)
- [🎓 OOP Assignment 2 — Student Grade Tracker](#-oop-assignment-2--student-grade-tracker)
- [🚗 OOP Assignment 3 — Vehicle Hierarchy System](#-oop-assignment-3--vehicle-hierarchy-system)
- [🛒 OOP Assignment 4 — E-Commerce Order System](#-oop-assignment-4--e-commerce-order-system)
- [🐾 OOP Assignment 5 — Animal Sound Simulation](#-oop-assignment-5--animal-sound-simulation)
- [🏦 OOP Assignment 6 — Bank Account Management System](#-oop-assignment-6--bank-account-management-system)
- [🏠 OOP Assignment 7 — Smart Home Device Control](#-oop-assignment-7--smart-home-device-control)
- [👩🏻‍💼 OOP Assignment 8 — Employee Management System with Polymorphism](#-oop-assignment-8--employee-management-system-with-polymorphism)
- [👩🏻‍💻 Author](#-author)

---

## 📋 Assignment Rules
> ⚠️ Please read before starting the assignments.

| # | Rule |
|---|------|
| 1️⃣ | 🔍 **SEARCH IS ALLOWED** |
| 2️⃣ | 🚫 **Copy-paste code without explanation = rejected** → for each rejected problem, solve **5 extra applications** |
| 3️⃣ | ❌ **USING CHATGPT IS NOT ALLOWED** |
| 4️⃣ | 💻 **Submit your C# code on GitHub** |
| 5️⃣ | 🧠 **THINK — USE PEN AND PAPER** before coding |

---

## 📘 OOP Assignment 1 — Book Class System *(Easy)*  
**Concepts Used:** Class, Object, Constructor, Method, Encapsulation

📚 **Description:**  
Create a class `Book` with:
- Title  
- Author  
- Year  
- ISBN  

🧩 **Methods:**
- `PrintBookInfo()`  
- `IsOlderThan(year)` → returns `bool`

📘 Create 3 different book objects using constructors and demonstrate both methods.

---

## 🎓 OOP Assignment 2 — Student Grade Tracker *(Easy–Medium)*  
**Concepts Used:** Class, Constructor, List, Encapsulation

📚 **Description:**  
Create a class `Student` with:
- Name  
- ID  
- List of Grades  

🧩 **Methods:**
- `AddGrade(int grade)`  
- `CalculateAverage()`  
- `PrintStudentReport()`

📘 Create multiple students, add grades, and print their reports.

---

## 🚗 OOP Assignment 3 — Vehicle Hierarchy System *(Medium)*  
**Concepts Used:** Inheritance, Constructors, Method Overriding

📚 **Description:**  
Create a base class `Vehicle` with:
- Make  
- Model  
- Year  

Create derived classes:
- `Car` → with `NumberOfDoors`  
- `Truck` → with `LoadCapacity`

🧩 Override `DisplayInfo()` to show details for each type.

---

## 🛒 OOP Assignment 4 — E-Commerce Order System *(Medium)*  
**Concepts Used:** Constructor Overloading, Method Overloading

📚 **Description:**  
Create a class `Product` with:
- Name  
- Price  
- Quantity  

Overload:
- Constructors (default + with parameters)  
- Method `CalculateTotal()`  
  - Without parameters → uses fields  
  - With parameters (price, quantity)

Create a class `Order` that holds a list of products and calculates total cost.

---

## 🐾 OOP Assignment 5 — Animal Sound Simulation *(Medium–Hard)*  
**Concepts Used:** Abstract Class, Inheritance, Polymorphism

📚 **Description:**  
Create an abstract class `Animal`:
- Property: Name  
- Abstract method: `MakeSound()`

Derived classes:
- `Dog` → "Woof!"  
- `Cat` → "Meow!"  
- `Cow` → "Moo!"

🧩 Create a method that takes a list of `Animal` and calls `MakeSound()` on each — demonstrating polymorphism.

---

## 🏦 OOP Assignment 6 — Bank Account Management System *(Hard)*  
**Concepts Used:** Encapsulation, Static Members, Properties

📚 **Description:**  
Create class `BankAccount` with:
- Static field: `totalAccounts`  
- AccountNumber, Balance, Owner  

🧩 **Methods:**
- `Deposit()`  
- `Withdraw()`  
- Static `ShowTotalAccounts()`

Use **private fields** + **public properties** (validate balance ≥ 0).  
Create multiple accounts and show total accounts created.

---

## 🏠 OOP Assignment 7 — Smart Home Device Control *(Hard)*  
**Concepts Used:** Interface, Implementation, Encapsulation, Abstraction

📚 **Description:**  
Create interface `IDevice`:
- `TurnOn()`  
- `TurnOff()`  
- `ShowStatus()`

Implement two classes:
- `Light` → (on/off state, brightness level)  
- `Thermostat` → (on/off state, current temperature)

Create a `Controller` class that operates any `IDevice`.

---

## 👩🏻‍💼 OOP Assignment 8 — Employee Management System with Polymorphism *(Advanced)*  
**Concepts Used:** Inheritance, Polymorphism, Constructor Chaining, Base Class Logic

📚 **Description:**  
Create a base class `Employee`:
- Name, Salary  
- Method: `CalculateBonus()` → returns 10% of salary  

Derived classes:
- `Manager` → 20% bonus  
- `Developer` → 15% bonus  

Create `HR` class that takes a list of employees and prints bonuses using polymorphism.

🧩 **Extra:**  
- Use `base` keyword for constructor chaining  
- Validate salary is non-negative  

---

## 👩🏻‍💻 Author
**Raya Al Amri**  
🎓 *Information Systems Graduate*  
💡 Passionate about OOP design, clean code, and modular systems  
📍 *University of Technology and Applied Sciences — Salalah*

---

<p align="center">
  <b>✨ “Think logically, code cleanly, and let your objects do the talking.” ✨</b>
</p>
