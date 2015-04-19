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

###
```C#

```


##Validator:
