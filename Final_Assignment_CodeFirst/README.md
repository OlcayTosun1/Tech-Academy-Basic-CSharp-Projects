# Olcay Final Assignment - Entity Framework Code First

This is a basic C# Console Application using Entity Framework Code First.

## What the program does

1. Creates a Student model class.
2. Uses a DbContext called SchoolContext.
3. Creates a local database called OlcayStudentDatabase.
4. Adds one student to the Students table.
5. Prints the student information in the console.

## How to run

1. Open `OlcayFinalAssignment.csproj` in Visual Studio.
2. Right-click the project and select **Restore NuGet Packages** if needed.
3. Build the project.
4. Run the project using **Ctrl + F5**.
5. Confirm the console shows that one student was added.

## Files included

- `Program.cs` - Runs the program and adds one student.
- `Student.cs` - Student model class.
- `SchoolContext.cs` - Entity Framework database context.
- `App.config` - LocalDB database connection string.
