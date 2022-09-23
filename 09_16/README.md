# 09/16 課程

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
topic : `C#` syntax

### Boilerplate

```cs

using System;
using System.Collections.Generic;

class Program {
    public static void Main (string[] args) {
        // todo 
    }
}
```
### Build-in type
- int 
- long
- float
- bool
- double 
- char
- string 

### I/O

- **Input**

Read from console : 
```cs
string raw_input = Console.ReadLine();
```
value type : `string`

Convert to `int` : 
```cs
int opt = Convert.ToInt32( Console.ReadLine() );
```

- **Output**

Basic output : 
```cs
Console.WriteLine("Write a new line");
Console.Write("Write on curent line");
int num = 10;
Console.Write( num );
```

Output with variables : 
```cs
Console.WriteLine( "option({0}) {1} :" ,i+1 ,usr.Options[i].Name);
```
- `{0}` : output value of `i+1`
- `{1}` : output value of `usr.Options[i].Name`

### Check type 

check `RawInput` is `int` or not
```cs 
string RawInput = UI.GetRawInput();
int money;
bool isInt = int.TryParse( RawInput , out money);
```
- `isInt` : `true` if `RawInput` is valid `int` input
- `money` : convert `RawInput` into `int` if `RawInput` is valid `int` input

### Array 

- Basic Syntax :
`TYPE[] NAME = new TYPE[SIZE];`
`TYPE[] NAME = new TYPE[] { v1 ,v2 ,v3 ... vn };`
`TYPE[] NAME = { v1,v2,v3 ... vn };`
```cs
int[] outArr = new int[5];
string[] nameArr = new string[10];

int[] initArr = new int[] { 1,2,3,4,5 };
int[] initArr2 = { 1,2,3,4,5 };
```

- Length
`int len = NAME.Length;`

### forEach loop 
```cs
foreach( TYPE element in ITERABLE ){
    // todo 
};
```


