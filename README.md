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

## Usage

_TODO: Add instructions for using the application._

## Documentation

_TODO: Provide a link to the detailed documentation._

## Contributing

We welcome contributions to this project! Please read our [Contributing Guide](CONTRIBUTING.md) to learn how you can contribute, report issues, or suggest new features.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
