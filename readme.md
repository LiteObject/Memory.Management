# Memory Management

## Basic Concepts:
* **Primitive Type** 
  - A primitive type is a type defined at the programming language level, often it is even a value type, directly supported by the compiler of the language.
  - Boolean, Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64, IntPtr, UIntPtr, Char, Double, and Single.
  - `Type.IsPrimitive` returns `true` if the Type is one of the primitive types; otherwise, `false`
* **Value Type** 
  - Local vlue types reside on the Stack, but static and class members (that are of vlue type) reside on Heap  
  - By default, on assignment, passing an argument to a method, and returning a method result, variable values are copied
  - C# provides the following built-in value types:
    - Integral numeric types
    - Floating-point numeric types
    - bool that represents a Boolean value
    - char that represents a Unicode UTF-16 character
* **Reference Types**
  - Reference types store references to their data (objects) on the Stack and the actual data on the Heap
  - With reference types, two variables can reference the same object; therefore, operations on one variable can affect the object referenced by the other variable
  - The following keywords are used to declare reference types:
    - class
    - interface
    - delegate
    - record
  - C# also provides the following built-in reference types:
    - dynamic
    - object
    - string
* **ref, out, in**
  - ref: The `ref` keyword indicates that a variable is a reference, or an alias for another object
  - in: The `in` keyword causes arguments to be passed by reference but ensures the argument is not modified

---
## [ref struct](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/ref-struct)
* **Can't be**
  - the element type of an array
  - a declared type of a field of a class or a non-ref struct
  - implement interfaces
  - boxed to `System.ValueType` or `System.Object`
  - a type argument
  - captured by a lambda expression or a local function
  - used in an `async` method. However, you can use ref struct variables in synchronous methods, for example, in methods that return `Task` or `Task<TResult>`
  - used in iterators.
* **Can be**
  - a method parameter
  - a return type
  - a local variable

## [Span](https://learn.microsoft.com/en-us/dotnet/api/system.span-1?view=net-6.0)
* A span is a value type that represents a contiguous region of arbitrary memory
* We need `ref struct` to implement a `span`
* `Span<T>` is a `ref struct` that is allocated on the stack rather than on the managed heap.

* Example: 
    ```csharp
    public readonly ref struct Span<T>
    {
        /// <summary>A byref or a native ptr.</summary>
        internal readonly ref T _reference;
    
        /// <summary>The number of elements this Span contains.</summary>
        private readonly int _length;
        ...
    }
    ```
    Source: https://source.dot.net/#System.Private.CoreLib/src/libraries/System.Private.CoreLib/src/System/Span.cs,d2517139cac388e8

---
* Stack
* Heap
* [Garbage collection](https://learn.microsoft.com/en-us/dotnet/standard/garbage-collection/)


