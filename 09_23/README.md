# 09/23 課程

- [Practice 1-1](#practice-1-1)
- [Practice 1-2](#practice-1-2)
- [Course Note](#boilerplate)
    - [Build-in Type](#build-in-type)
    - [Console I/O](#io)
    - [Type checking](#check-type)
    - [Array & ForEach lopp](#array)

## Homework
### Practice 1-1
![](https://i.imgur.com/mknVCa0.png)

### Practice 1-2 
![](https://i.imgur.com/5LYaFcV.png)
## Course
### Array method
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

### String method 

