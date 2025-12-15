# Interpreter Pattern

## Short Explanation
The Interpreter pattern defines a way to **interpret expressions** by representing them as objects.  
It is useful when you need to **evaluate simple languages or rules**, such as mathematical expressions, filters, or command parsing.

## Math Expression Example

This example shows how a **math expression (`5 + 3`)** is interpreted using the **Interpreter pattern**.

- **Context:** The expression being evaluated
- **Expression interface:** `IExpression` (defines the `Interpret()` method)
- **Terminal expressions:** `NumberExpression` (represents numbers)
- **Non-terminal expressions:** `AddExpression` (represents operations)
- **Interpretation:** Expressions evaluate themselves recursively

**Why it’s a good example:**
- Expressions are represented as **objects**
- Complex expressions are built from **simple expressions**
- Behavior is evaluated **recursively**
- New expressions can be added without changing existing code

**Usage:**
```csharp
// Represents: 5 + 3
IExpression five = new NumberExpression(5);
IExpression three = new NumberExpression(3);

IExpression expression = new AddExpression(five, three);

Console.WriteLine(expression.Interpret()); // 8
