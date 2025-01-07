# MVFramework

## Overview

MVFramework is a flexible and lightweight framework for Unity, designed to simplify the implementation of **MVC** (Model-View-Controller) or **MVP** (Model-View-Presenter) patterns. It incorporates **dependency injection** to enhance modularity, scalability, and testability in your Unity projects.

This framework allows you to effectively separate concerns, making your codebase more maintainable and easier to extend.

---

## Key Features

- **MVC and MVP Architecture**: Choose between MVC or MVP patterns based on your project needs.
- **Dependency Injection**: Simplifies decoupling and facilitates integration of reusable components.
- **Test-Friendly**: Built with unit testing in mind for reliable and robust code.
- **Unity Ready**: Seamlessly integrates with Unity to support common workflows.
- **Modular Design**: Encourages clean and structured code by separating logic, presentation, and data layers.

---

## Getting Started

1. **Clone the Repository**:
   Clone this repository to your Unity project to start using MVFramework.

2. **Example Usage**:
   Check out the [MVFramework Test Project](https://github.com/DanCastroArjona/MVFrameworkTest) for an example implementation. It demonstrates how to use the framework with a real-world scenario, such as controlling a stamina bar in a 3D environment.

---

## Why MVFramework?

- Simplifies project architecture in Unity by enforcing proven design patterns.
- Reduces code duplication and improves maintainability.
- Makes testing and debugging easier with clear separation of concerns.
- Speeds up development by promoting reusable and modular components.

---

## How It Works

MVFramework enforces the MVC or MVP design patterns, ensuring a clear separation of concerns and streamlined communication between components. Here's an overview of its core components:

### Core Components

#### **GlobalContext**
- Acts as a singleton hub for managing dependencies across the application.
- Provides centralized access to:
  - **Models**: Represent data and logic.
  - **Controllers**: Connect logic between Models and Views.
  - **Presenters**: Mediate logic between Views and Models (specific to MVP).
  - **ScriptableObjects**: Reusable assets or configurations.
- Automatically initializes at application startup.

#### **SceneContext**
- Handles scene-specific dependencies.
- Registers Models, Controllers, and Presenters with the `GlobalContext` when the scene is loaded.
- Cleans up and unregisters dependencies when the scene is destroyed.

#### **Installer**
- A `ScriptableObject` used to register Models, Controllers, Presenters, and Signals.
- Provides modular and reusable dependency configurations.
- Ensures clean installation and uninstallation of components.

#### **Signals**
- A messaging system for decoupled communication between components.
- Types of signals:
  - **UserSignals**: Handle user-driven events.
  - **UpdateSignals**: Notify updates in Views or Models.
  - **ActionSignals**: Handle general-purpose actions within the app.

---

## Resources

- **Test Project**: [MVFramework Test Project](https://github.com/DanCastroArjona/MVFrameworkTest)
- **Repository**: [MVFramework GitHub Repository](https://github.com/DanCastroArjona/MVFramework.git)

---

## Contributing

Contributions are welcome! Feel free to submit issues or pull requests to improve the framework.

---

Happy coding! 🚀
