# Unexpected Zero Value Bug in C#

This repository demonstrates a subtle bug in C# where a class member unexpectedly becomes zero despite being initialized in the constructor.  The issue arises from a potential mismatch in how the object is created and used.

## Bug Description

The `ExampleClass` has a property `MyProperty` initialized in its constructor.  However, under certain conditions, `MyProperty` can become zero, leading to unexpected behavior and potential exceptions.

## Reproduction

1. Clone this repository.
2. Compile and run the `Bug.cs` file.
3. Observe the exception thrown when `MyProperty` is unexpectedly zero.

## Solution

The solution involves careful review of object initialization and usage. Possible causes include:

* **Incorrect object instantiation:** Verify the constructor is correctly called.
* **External modification:** Check if any external code modifies `MyProperty` unexpectedly.
* **Data binding issues:** If using data binding, inspect the data source to ensure consistency.

The corrected code is in `BugSolution.cs` and addresses the issue in a way that depends on the root cause. Note that the root cause is not specified by the example, only that the problem is happening.