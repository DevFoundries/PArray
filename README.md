# PArray

.NET Implementation of Perl's excellent Array features

## Author
Wm. Barrett Simms @ [DevFoundries](DevFoundries.com)

## Install
```
Install-Package PArray
```

## Usage

The PArray object implements the following interface:

```
    public interface IPArray<T> : IEnumerable<T>
    {

        // Take entity from the start
        T Shift();

        
        // Add entity to the top
        void Unshift(T entity);
        

        // Add entity to the end
        void Push(T entity);


        // Remove entity from the end
        T Pop();

        int Count { get; }
    }
```

Creating the object:
```
    PArray<int> pa = new PArray<int>(new List<int> { 1,2,3,4});
```

Adding an entity to the end of the list:
```
    PArray<int> pa = new PArray<int>(new List<int> { 1, 2, 3, 4 });
    pa.Push(5);
```

Taking an entity from the end of the list:
```
    PArray<int> pa = new PArray<int>(new List<int> { 1, 2, 3, 4 });
    int i = pa.Pop(5);
```

Adding an entity to the front of the list:
```
    PArray<int> pa = new PArray<int>(new List<int> { 1, 2, 3, 4 });
    pa.Unshift(5);
```

Taking an entity from the front of the list:
```
    PArray<int> pa = new PArray<int>(new List<int> { 1, 2, 3, 4 });
    int i = pa.Shift(5);
```



