# Strategy Pattern
## Short Explanation
The Strategy pattern allows a class to **change its behavior at runtime** by using different interchangeable algorithms (strategies).  
It is useful when you want to **swap behaviors dynamically** without modifying the class, like switching between melee and ranged attacks.
## performAttack Example

This example shows how a character can switch attack behavior at runtime using the **Strategy pattern**.

- **Strategy interface:** `AttackStrategy` (defines `Attack`)
- **Concrete strategies:** `MeleeAttack`, `RangedAttack`
- **Context:** `Character` (delegates attack to current strategy)

**Why it’s a good example:**
- Characters can **change attacks on the fly** without modifying class code.
- Adding a new attack requires **just a new strategy class**, no `if/else` logic.
- Demonstrates **composition over inheritance**.

**Usage:**
```js
const hero = new Character('Hero', new MeleeAttack());
hero.Attack();      // melee attack
hero.setAttackStrategy(new RangedAttack());
hero.Attack();      // ranged attack

