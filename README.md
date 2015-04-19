# IPC
IP Calculator

#Tasks:
##UI:


##Engine:

###string GetNetwork(string address, string mask)
```C#
//Example
var network = Engine.GetNetwork("78.90.149.55", "255.255.255.0");
Console.WriteLine(network); // 78.90.149.0
```
###string[] GetAddressRange(string address, string subnet)
```C#
//Example
var range = Engine.GetAddressRange("78.90.149.55", "255.255.255.0");
Console.WriteLine(range[0]); // 78.90.149.0
Console.WriteLine(range[1]); // 78.90.149.55
```

###string ConvertAddressToBinary(string address)
```C#
//Example
Engine.ConvertAddressToBinary("78.90.149.55") // 01001110.01011010.10010101.00110111
```

###List<string> GenerateMasks()
Generates list of Class A,B,C masks
```C#
//Example
var masks = Engine.GenerateMasks();
foreach (var mask in masks)
{
    Console.WriteLine(mask);
}

/*Result
128.0.0.0
.
.
255.255.255.0
*/
```

###
```C#

```
###
```C#

```

###
```C#

```
##Validator:
