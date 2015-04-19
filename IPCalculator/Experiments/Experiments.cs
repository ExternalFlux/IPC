using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
    class Experiments
    {
        static void Main(string[] args)
        {
            var ip = ConvertAddressToBinary("78.90.149.55");
            var subnet = ConvertAddressToBinary("255.255.255.0");
            Console.WriteLine(ip);
            Console.WriteLine(subnet);

            var masks = GenerateMasks();
            foreach (var mask in masks)
            {
                Console.WriteLine(mask);
            }
        }
        static int ChangeBitAt(int value, int position)
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
    }
}
