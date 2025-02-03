# Unexpected Mutation of Mutable Variable in F# Function

This example demonstrates a common error in F# involving mutable variables and function calls.  When a mutable variable is passed to a function, it's not copied; the function directly modifies the original variable. This can lead to unexpected behavior and bugs if not handled correctly.

The `bug.fs` file contains code that exhibits this issue, and `bugSolution.fs` provides a solution illustrating best practices.

## How to Reproduce
1. Compile and run `bug.fs`. Observe that the output shows both `x` and `y` as 11.  The expected behavior might be for `x` to remain 10 and `y` to be 11, but because `addOne` modifies `x` directly, the output is different.
2. Next, compile and run `bugSolution.fs` to see how to avoid this unintended mutation.