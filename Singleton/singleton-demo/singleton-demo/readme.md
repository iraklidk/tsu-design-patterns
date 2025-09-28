# Singleton Pattern — `President` Example

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
