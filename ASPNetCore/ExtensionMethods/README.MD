# Extension Methods

- Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. 
- Extension methods are static methods, but they're called as if they were instance methods on the extended type.

## General Guidelines

Extension methods are an excellent choice when :
- The original source isn't under your control.
- When a derived object is inappropriate or impossible.
- When the functionality shouldn't be exposed beyond its applicable scope.
