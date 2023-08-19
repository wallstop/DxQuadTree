# DxQuadTree
An immutable quad tree built for Unity

# How to use
If you want to construct a QuadTree of some elements, simply call:
```csharp
QuadTree<T> quadTree = new QuadTree<T>(yourElements, functionThatConvertsElementTypeToVector2, theBoundsOfYourElements, optionalBucketSize);
```

Once constructed, the tree and all of its functions are threadsafe. You can:
* Get all elements in range of a point
* Get all elements within a Bounds
* Get *n* approximate nearest neighbors

# Important notes
* The quad tree must operate on a distinct set of points - if there are more duplicate points than the bucket size, the constructor can infinite loop.
* If the positions of the data in the quadtree change, the quadtree is invalid and must be rebuilt (hence, "immutable")
