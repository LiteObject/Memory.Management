# Memory Management

## Basic Concepts:
* **Primitive Type** 
  - A primitive type is a type defined at the programming language level, often it is even a value type, directly supported by the compiler of the language.
  - Boolean, Byte, SByte, Int16, UInt16, Int32, UInt32, Int64, UInt64, IntPtr, UIntPtr, Char, Double, and Single.
  - `Type.IsPrimitive` returns `true` if the Type is one of the primitive types; otherwise, `false`
* **Value Type** 
  - A value type is usually whatever type reside on the Stack
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
* Stack
* Heap
