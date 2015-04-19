namespace Experiments
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using IPCalculator.Engine;

    class Experiments
    {
        static void Main(string[] args)
        {
            var ip = Engine.ConvertAddressToBinary("78.90.149.55");
            var subnet = Engine.ConvertAddressToBinary("255.255.255.0");
            Console.WriteLine(ip);
            Console.WriteLine(subnet);

            var masks = Engine.GenerateMasks();
            foreach (var mask in masks)
            {
                Console.WriteLine(mask);
            }
            Console.WriteLine(Engine.GetNetwork("78.90.149.55", "255.255.255.0"));

        }
    }
}
