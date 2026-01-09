# Casino - C# Practice Examples

This repository contains a set of small, focused C# console examples demonstrating common language constructs and patterns: string parsing, control flow, arrays, loops, random generation, and simple simulations.

These examples are intentionally small and self-contained — perfect for showcasing fundamental skills in interviews, technical screens, or a personal portfolio.

## Why this repository is useful for hiring managers
- Clear, focused examples each in its own file with descriptive names that map to the demonstrated concept.
- Easy-to-run console samples to observe behavior quickly.
- Shows practical usage of control flow, loops, arrays, and basic simulation logic — great for junior/mid-level C# roles.

## Technologies
- C# (compatible with .NET 6+)
- Console application examples

## How to run
1. Create a .NET console project (or add these files to an existing one):
   - dotnet new console -n CasinoExamplesApp
2. Copy the .cs files into the project.
3. Build and run:
   - dotnet run

Program.cs demonstrates each example in sequence.

## Files and intent
- `Program.cs` - Entrypoint; demonstrates each example.
- `SkuParser.cs` - Parses SKU strings into human-readable product descriptions.
- `PermissionChecker.cs` - Example of evaluating permission strings and numeric access levels.
- `ArrayOperations.cs` - Sum, contains check, reverse printing of arrays.
- `ReplaceAndPrintNames.cs` - In-place replacement in string arrays and printing.
- `FizzBuzz.cs` - Classic FizzBuzz example (good for whiteboard-style tests).
- `RandomLoops.cs` - Demonstrates `while` and `do-while` loops with random numbers.
- `CombatSimulation.cs` - Small turn-based combat loop demonstrating state changes and randomness.

## What to highlight during interviews
- Clean separation of responsibilities into small classes.
- Defensive programming (null checks and input validation).
- Ability to explain control flow choices (switch vs. switch expression, loop types).
- Understand and discuss trade-offs (determinism vs. randomness for tests).

## Next improvements (nice-to-have)
- Add unit tests for each class (e.g., using xUnit).
- Add dependency injection and abstractions for random number generation so the simulations are deterministic in tests.
- Add README badges (build status, test coverage) and a short CONTRIBUTING.md.

## Contact / Author
Project author: bIipn


