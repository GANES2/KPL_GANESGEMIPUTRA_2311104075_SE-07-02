# Modul 10 - MatematikaLibraries and ConsoleApp

## Project Structure

- `MatematikaLibraries`: Class library project containing math functions:
  - FPB (Greatest Common Divisor)
  - KPK (Least Common Multiple)
  - Turunan (Derivative of polynomial)
  - Integral (Integral of polynomial)

- `ConsoleApp`: Console application project that references `MatematikaLibraries` and calls its functions.

## How to Create the Solution and Projects in Visual Studio

1. Open Visual Studio.

2. Create a new solution:
   - Select **Create a new project**.
   - Choose **Blank Solution**.
   - Name the solution `modul10`.
   - Choose a location and click **Create**.

3. Add the Class Library project:
   - Right-click the solution in Solution Explorer.
   - Select **Add** > **New Project**.
   - Choose **Class Library (.NET Core)** or **Class Library (.NET 6)**.
   - Name it `MatematikaLibraries`.
   - Click **Create**.
   - Replace the generated `Class1.cs` with the provided `Matematika.cs` code.

4. Add the Console Application project:
   - Right-click the solution.
   - Select **Add** > **New Project**.
   - Choose **Console App (.NET Core)** or **Console App (.NET 6)**.
   - Name it `ConsoleApp`.
   - Click **Create**.
   - Replace the generated `Program.cs` with the provided `Program.cs` code.

5. Add project reference:
   - Right-click the `ConsoleApp` project.
   - Select **Add** > **Project Reference**.
   - Check the box for `MatematikaLibraries`.
   - Click **OK**.

6. Build the solution:
   - Select **Build** > **Build Solution**.

7. Run the ConsoleApp project:
   - Set `ConsoleApp` as the startup project (right-click > Set as Startup Project).
   - Press **F5** or click **Start** to run.
   - The console window will display the results of the math functions.

## Notes

- The polynomial coefficients arrays represent terms from highest degree to constant term.
- The derivative and integral functions return string representations of the results.
- The integral function adds a constant "+ C" at the end.

## Deliverables

- Source code files for both projects.
- Screenshots of the console output.
- Brief explanation of the code and screenshots of key code parts for the report.

---

Good luck with your assignment!
