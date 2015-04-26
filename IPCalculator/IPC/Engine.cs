namespace IPC.Engine
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

        
        public static string[] GetAddressRange(string address, string subnet)
        {
            string[] result = new string[2];

            int ip = ExtractIp(address);
            int mask = ExtractIp(subnet);
            result[0] = ConvertToIp(ip & mask);
            result[1] = ConvertToIp((ip & mask) + (~mask));
            return result;
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
        public static string ConvertNumberToBinary(string number)
        {
            return Convert.ToString(int.Parse(number), 2).PadLeft(8, '0');
        }

        public static string ConvertAddressToHostAndNetwork(string address, string subnet)
        {
            var result = new StringBuilder();

            /*
            Class A - 255.0.0.0
            Class B - 255.255.0.0
            Class C - 255.255.255.0
            */

            // Generate mask octets
            var subnetOctets = subnet.Split('.');

            int counter = 0;
            foreach (var octet in subnetOctets)
            {
                string currentOctet = ConvertNumberToBinary(octet);
                foreach (var item in currentOctet)
                {
                    if (int.Parse(item.ToString()) > 0)
                    {
                        result.Append("n");
                    }
                    else
                    {
                        result.Append("h");
                    }
                }
                if (counter < 3)
                {
                    result.Append(".");
                }
                counter++;
            }

            return result.ToString();
        }

        public static int ExtractIp(String s)
        {
            int h = 0;
            string[] v = s.Split('.');
            foreach (string t in v)
            {
                if (Convert.ToInt32(t) > 255)
                {
                    throw new FormatException();
                }
                h = (h << 8) + Convert.ToInt32(t);
            }
            return h;
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

        private static string ConvertToIp(int h)
        {
            return ((h & 0xFF000000) >> 24) + "." + ((h & 0x00FF0000) >> 16) + "." + ((h & 0x0000FF00) >> 8) + "." + (h & 0x000000FF); ;
        }
        private static int ChangeBitAt(int value, int position)
        {
            if (value > 255)
            {
                throw new ArgumentOutOfRangeException("ZeroBit value is more than 255.");
            }
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("ZeroBit value is less than 0."); //Never gonna happen
            }
            return value | (1 << position);
        }

        public static void InvertArray(byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (byte)(255 - array[i]);
            }
        }
        public static int PowerOf(int number, int power)
        {
            int result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
