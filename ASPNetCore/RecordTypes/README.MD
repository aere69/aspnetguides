# Enums or Record Types

When there is a need to represent a group of constants, consider replacing enumeration types in favor of record types.

## Enums

Enums can provide flexibility maintaning a set of constant values.
Enums introduce tight coupling between the domain model and the code.

Problems:
1. Encapsulation.
   
   The logic that queries the model and the model are separate.

   The logic that checks the model is not within the same class.

2. Spaghetti Code.
   
    Need to use explicit casts to retrieve a value from an enum.

    Explicit casts are costly in terms of performance.

3. Naming Constraints
   
   The name of an enum cannot contain spaces.

   Attributes can oercome that limitation using
   ```c#
   [Display(Name = "Super Admin")]
   ```
   However, this introduces problems when the application needs to provide support for different locales.

## Record Types

Record Types offer a better alternative.
Record Types create an inmutable type.

Inmutable objects once instantiated, cannot be altered.

Record Types posses an intrinsic thread-safety and immunity to race conditions.

Immutable onbjects make code more readable and easier to maintain.

Record Types preserve encapsulation because any extension method can be part of the model.

With Record Types it is easy to proide meaningful names.

## Create and run a console application

```sh
dotnet new console --framework net8.0 --use-program-main

dotnet run
```