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
