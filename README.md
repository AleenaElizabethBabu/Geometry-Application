# Geometry-Application
# PROJECT EXPLANATION
The project involves creating a solution with a Class Library, Console Application, and Test Library. The Class Library defines an `IShape` interface and implements it in `Square`, `Rectangle`, and `Triangle` classes. The Console Application uses the `Microsoft.FeatureManagement` NuGet package to manage feature toggles and sets up dependency injection with `IFeatureManager` to control access to shape classes based on feature flags. User input for shape dimensions is accepted via `Console.ReadLine()`. The Test Library includes unit tests for each shape's area and perimeter calculations to ensure accuracy.
# OBJECTIVE OF THE PROJECT
The objectives of this project are to create a modular and testable software solution that demonstrates key software engineering principles. It aims to implement a Class Library for geometric shape calculations, utilize feature management to enable or disable features dynamically, and set up dependency injection for better code maintainability and flexibility. The project also focuses on user interaction by accepting input for shape dimensions and validating calculations through comprehensive unit tests. Ultimately, the project showcases effective software design patterns, including interface implementation, feature toggles, and dependency injection, to build a robust and scalable application.
# USING OF GIT FEATURES
In this project, Git features like branching and merging were utilized to enhance collaboration and manage development efficiently. Separate branches were created for each feature, such as implementing `IShape` classes, setting up feature management, and adding unit tests. This allowed parallel development without affecting the main codebase. After completing and testing each feature, the branches were merged into the main branch through pull requests, ensuring code review and integration without conflicts.
