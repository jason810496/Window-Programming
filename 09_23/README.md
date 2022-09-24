# 09/23 課程

- [Practice 2-1](#practice-2-1)
- [Practice 2-2](#practice-2-2)
- [Course Note](#course)
    - [Array methods](#array-methods)
    - [Random](#random)
    - [Function pass paramater by reference](#pass-by-reference)
    - [String methods](#string-methods)

## Homework
### Practice 2-1

![](https://i.imgur.com/YKIBZ3r.png)

### Practice 2-2 
**Basic Reversi Game**
![](https://i.imgur.com/mqbgvvR.png)

![](https://i.imgur.com/e0CbBlY.png)
## Course
### Array methods
require namespace : `System`

- **Sort** ( default : increasing sort ) : 
```cs
int[] arr = {5,2,3,10,-1};
Array.Sort( arr );
```
- **Reverse**
```cs
int[] arr = {5,2,3,10,-1};
Array.Reverse( arr );
```

- **IndexOf**
```cs
int[] arr = {5,2,3,10,-1};
int Idx = Array.Index( arr , -1 ); // 4
int NotFound = Array.Index( arr , 99 ); // -1
```

- **Resize**
The `arr` must **pass by reference**
```cs
int[] arr = {5,2,3,10,-1};
Array.Resize( ref arr  , 100 );
```

### Random
Random object must be **realized** before used : 

syntax : 
- `randObj.Next()` : return an unsigned integer random between `0` and `2147483647`
- `randObj.Next( N )` : return an unsigned integer random smaller than `N`
- `randObj.Next( L , R )` : return an integer `N` that `L`≤`N`<`R`
```cs
Random randObj = new Random();
int num = randObj.Next(10);
```

### Pass by reference 
syntax : add `ref` before parameter type
```cs
private void Convert(ref int X ){
    X*=100;
}
```
pass Array object as reference : 
```cs
private void Convert(ref int[] X ){
    Array.Sort(X);
}
```

### String methods

