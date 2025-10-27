# Singleton Pattern
## Short Explanation
The Singleton pattern ensures that a class has **only one instance** and provides a **global point of access** to it.  
It is useful when you need exactly **one object to coordinate actions** across the system, like a configuration manager, logger, or a "President" class.
## President Example

This example ensures that only one instance of the **President** class exists throughout the program, demonstrating the **Singleton pattern**.

- **Singleton class:** `President` (private constructor, single instance)
- **Global access:** `getInstance()` provides access to the one instance
- **Controlled instantiation:** prevents creating multiple presidents

**Why it’s a good example:**
- Only **one instance** exists at a time
- Any part of the program can access the same instance via `getInstance()`
- Shows **controlled instantiation** and **global access**, core ideas of Singleton

**Usage:**
```js
const president1 = President.getInstance();
const president2 = President.getInstance();

console.log(president1 === president2); // true, same instance
