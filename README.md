# Verbosity: Student Feedback and Goal Management System

[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://opensource.org/licenses/MIT)
[![C#](https://img.shields.io/badge/C%23-WinForms-brightgreen)](https://docs.microsoft.com/en-us/dotnet/csharp/)

Verbosity is an open-source WinForms application built with .NET, designed to help teachers and students communicate effectively by managing feedback and tracking goals. Teachers can leave feedback for students, while students can register goals and subgoals to improve their learning experience.

![Verbosity Screenshot](./screenshot.png)

## Table of Contents

- [Features](#features)
- [N-Tier Architecture](#n-tier-architecture)
- [Installation](#installation)
- [Usage](#usage)
- [Documentation](#documentation)
- [Contributing](#contributing)
- [License](#license)

## Features

- Teachers can leave feedback for students.
- Students can register goals and subgoals.
- Intuitive and user-friendly interface.
- Secure data storage and handling.
- Easily customizable and extensible.

## N-Tier Architecture

The project is built using the N-Tier architecture, which allows for a scalable, maintainable, and modular application. The architecture is divided into the following layers:

1. `FBS.Entity`: Contains the entities: Feedback, Goal, Group, Student, Subgoal, and Teacher.
2. `FBS.Repository`: Includes all SQL statements that interact with the SQL Server.
3. `FBS.DataAccess`: Data access layer containing the connection string for the database.
4. `Frontend`: Contains the WinForms forms for the user interface.

### FBS.Entity

This layer contains the classes representing the various entities in the system, such as Feedback, Goal, Group, Student, Subgoal, and Teacher. These classes define the data structure and relationships among them.

### FBS.Repository

This layer is responsible for executing SQL queries to interact with the SQL Server. It contains methods to perform CRUD operations (Create, Read, Update, Delete) on the different entities in the system.

### FBS.DataAccess

The data access layer is responsible for managing the connection with the SQL Server, using the connection string provided in the configuration file. It abstracts the details of connecting to the database from the other layers.

### Frontend

This layer contains the WinForms forms, which make up the user interface of the application. The forms provide a user-friendly interface for teachers and students to manage feedback, goals, and subgoals.

## Installation

_TODO: Add instructions for installation and setup._

## Usage:

1. Restore the database using the provided bak file located in the project root directory. This can be done by opening SQL Server Management Studio, right-clicking on the Databases folder and selecting "Restore Database", then selecting the .bak file and following the prompts to restore the database.

2. Update the ConnectionString inside FBS.DataAccess with the appropriate server name and database name. This can be done by opening the FBS.DataAccess project in Visual Studio, opening the `/FBS.DataAccess/FeedbackCollection/FeedbackCollectionDBDataAccess.cs` file, and updating the `connectionString` property with the appropriate server name and database name.

3. Install the SQL Server NuGet package by right-clicking on the solution in Visual Studio and selecting "Manage NuGet Packages...", then searching for and installing the `System.Data.SqlClient` package.

4. Run the Windows Forms application called FeedbackSysteem by opening the Frontend project in Visual Studio, setting the startup project to FeedbackSysteem, and running the application. Once the application is running, you can log in as a teacher or a student and begin using the application to manage feedback and goals.


## Documentation

_TODO: Provide a link to the detailed documentation._

## Contributing

In order to maintain a clean and well-organized codebase for the Verbosity project, we require all contributors to follow these commit guidelines. This will help ensure a smooth development process and easy collaboration among team members.

### Branching

1. Always create a new branch from the `staging` branch.
2. The branch name should be the name of the linear ticket you are working on, e.g., `LIN-123`.

### Committing

1. Commit messages should be clear, concise, and written in the imperative form, e.g., "Add new feature", not "Adding new feature" or "Added new feature".
2. Use the linear ticket name as a prefix in your commit messages, e.g., `LIN-123: Add new feature`.

### Pull Requests

1. When your work on the branch is complete and tested, create a pull request (PR) targeting the `staging` branch.
2. PRs should have a descriptive title and a detailed description of the changes made.

### Review and Merge Process

1. For changes to be merged into `staging`, at least one team member must review and approve the PR.
2. For changes to be merged into `main`, at least two team members must review and approve the PR.
3. The `staging` and `main` branches are protected. Only approved PRs can be merged into these branches.
4. After the required number of approvals is reached, the PR author is responsible for merging the PR.
5. Once the PR is merged, remember to delete the feature branch.


## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
