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
        // Sample 2 : http://www.gestioip.net/cgi-bin/subnet_calculator.cgi

        // Todo Implement
        public static string GetNetwork(string address, string mask)
        {
            var addressOctets = address.Split('.');
            var maskOctets = mask.Split('.');
            var result = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                int currentAddressOctet = int.Parse(addressOctets[i]);
                int currentMaskOctect = int.Parse(maskOctets[i]);

                result.Append((currentAddressOctet & currentMaskOctect).ToString() + ((i < 3) ? "." : ""));
            }

            return result.ToString();
        }

        public static int ChangeBitAt(int value, int position)
        {
            if (value > 255)
            {
                throw new ArgumentOutOfRangeException("ZeroBit value is more than 255.");
            }
            return value | (1 << position);
        }

        public static List<string> GenerateMasks()
        {
            var masks = new List<string>();

            int value = 0;

            //Generate class A masks
            for (int i = 8 - 1; i >= 0; i--)
            {
                value = value | ChangeBitAt(128, i);
                masks.Add(value.ToString() + ".0.0.0");
            }

            //Generate class B masks
            value = 0;
            for (int i = 8 - 1; i >= 0; i--)
            {
                value = value | ChangeBitAt(128, i);
                masks.Add("255." + value.ToString() + ".0.0");
            }

            //Generate class C masks
            value = 0;
            for (int i = 8 - 1; i >= 0; i--)
            {
                value = value | ChangeBitAt(128, i);
                masks.Add("255.255." + value.ToString() + ".0");
            }

            return masks;
        }

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

        public static string ConvertAddressToHostAndNetwork(string address, string subnet)
        {
            string result = String.Empty;

            /*
            Class A - 255.0.0.0
            Class B - 255.255.0.0
            Class C - 255.255.255.0
            */

            // Generate mask octets
            for (int i = 0; i < 8; i++)
            {

            }

            return result;
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
