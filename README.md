# UtilitySuite

UtilitySuite is a C# console application that combines several small utilities into a single menu-driven program. I developed the project as a way to practice fundamental C# concepts while also focusing on organizing an application into reusable and maintainable components.

## Features

UtilitySuite currently includes four tools:

- **Tip Calculator** – Calculates a tip and total based on a bill amount and selected tip percentage.
- **Temperature Converter** – Converts temperatures between Fahrenheit and Celsius.
- **Word Counter** – Counts the number of words in user-provided text.
- **To-Do List** – Allows users to add, view, complete, and remove tasks.

The to-do list also saves its data to disk so tasks can be restored when the application is reopened.

## Project Structure

The application separates responsibilities into several areas:

- **Core** – Contains shared functionality used throughout the application, including input handling and tool results.
- **Menu** – Handles navigation between the available utilities.
- **Persistence** – Handles saving and loading to-do list data.
- **Tools** – Contains the individual utilities available through the main menu.

This structure allows each utility to remain largely independent while sharing common functionality where appropriate.

## Technologies

- C#
- .NET
- Object-Oriented Programming
- File I/O
- Console Application Development
- Git / GitHub

## What I Learned

Building UtilitySuite gave me experience moving beyond small, isolated console programs and combining multiple features into one organized application. I gained additional practice with input validation, file persistence, class design, and separating responsibilities between different parts of a program.

The project also helped reinforce the importance of reusable code. Shared functionality, such as validated user input and navigation behavior, is handled separately rather than being repeatedly implemented within each utility.

## Running the Project

1. Clone the repository.
2. Open the project in Visual Studio or another compatible .NET development environment.
3. Build and run the application.
4. Select a utility from the main menu and follow the prompts.