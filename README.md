# IPC - Internet Protocol Calculator
Simple IP calculator now supports only v4. The next updates will support v6.

##UI:
Simple and easy to use UI.

![alt tag](http://i.imgur.com/CV0UJo3.png)

##Engine:

###GetNetwork(string address, string mask)
```C#
//Example
var network = Engine.GetNetwork("78.90.149.55", "255.255.255.0");
Console.WriteLine(network); // 78.90.149.0
```
###GetAddressRange(string address, string subnet)
```C#
//Example
var range = Engine.GetAddressRange("78.90.149.55", "255.255.255.0");
Console.WriteLine(range[0]); // 78.90.149.0
Console.WriteLine(range[1]); // 78.90.149.55
```

###ConvertAddressToBinary(string address)
```C#
//Example
Engine.ConvertAddressToBinary("78.90.149.55") // 01001110.01011010.10010101.00110111
```

###GenerateMasks()
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


###string isIPLocal(IPAddress ipaddress)
```C#
string isLocal1 =  isIPLocal("78.90.149.55");
string isLocal2 =  isIPLocal("10.90.149.55");
Console.WriteLine('isLocal1'); // Public
Console.WriteLine('isLocal2'); // Private
```

#SubnetMask
###string ReturnSubnetmask(String ipaddress)
```C#
string mask =  ReturnSubnetmask("78.90.149.55") // 255.0.0.0
```

###string ReturnClass(String ipaddress)
```C#
string class =  ReturnClass("78.90.149.55") // A
```

###uint ReturnFirtsOctet(string ipAddress)
```C#
uint octet = ReturnFirtsOctet("78.90.149.55") // 78
```

#Other Sources :
IPAddressExtensions - http://blogs.msdn.com/b/knom/archive/2008/12/31/ip-address-calculations-with-c-subnetmasks-networks.aspx
###Used in this project:
```C#
IPAddress GetBroadcastAddress(this IPAddress address, IPAddress subnetMask)
IPAddress GetNetworkAddress(this IPAddress address, IPAddress subnetMask)
bool IsInSameSubnet(this IPAddress address2, IPAddress address, IPAddress subnetMask)
```
