namespace IPCalculator.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Engine
    {


        // Sample calculator : http://www.subnet-calculator.com/subnet.php?net_class=B

        // Todo Implement
        public static string ConvertAddressToBinary(string address)
        {
            var splitted_address = address.Split('.').ToArray();

            for (int i = 0; i < splitted_address.Length; i++)
            {
                int currentOctet = int.Parse(splitted_address[i]);
                splitted_address[i] = Convert.ToString(currentOctet, 2).PadLeft(8, '0');
            }



            return String.Join(".", splitted_address); 
        }

        public static string HostAddressRange()
        {
            throw new NotImplementedException();
        }
        public static string SubnetID()
        {
            throw new NotImplementedException();
        }

        public static string BroadcastAddress()
        {
            throw new NotImplementedException();
        }

        public static string SubnetBitmap()
        {
            throw new NotImplementedException();
        }
    }
}
