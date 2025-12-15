# Flyweight Pattern

## Short Explanation
The Flyweight Pattern is used to **share common objects** to save memory and improve performance.  
It separates **intrinsic state** (shared, reusable data) from **extrinsic state** (unique per object) so that many objects can reuse the same shared data.

## Forest Example

This example shows how a forest can have many trees without creating a separate object for each identical tree type.

- **Item:** `TreeType` (represents the shared type of tree, e.g., Oak, Pine)  
- **Context:** `Tree` (stores unique position information for each tree)  
- **Factory:** `TreeFactory` (creates or reuses `TreeType` objects)

**Why it’s a good example:**
- Saves memory when many objects share the same data  
- Separates **shared intrinsic state** from **unique extrinsic state**  
- Makes it easy to manage many similar objects efficiently  

## Usage
```csharp
var forest = new List<Tree>();

// Reuse same TreeType objects
TreeType oakType = TreeFactory.GetTreeType("Oak", "Green");
TreeType pineType = TreeFactory.GetTreeType("Pine", "DarkGreen");

// Create trees with positions
forest.Add(new Tree(10, 20, oakType));
forest.Add(new Tree(15, 25, oakType));
forest.Add(new Tree(5, 5, pineType));

foreach (var tree in forest)
    tree.Display();
