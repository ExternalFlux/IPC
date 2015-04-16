using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPCalculator.Engine
{
    public class Engine
    {
        private static Engine instance;

        private Engine() { }

        public static Engine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Engine();
                }
                return instance;
            }
        }

        // Sample calculator : http://www.subnet-calculator.com/subnet.php?net_class=B

        // Todo Implement
        public static string ConvertIP(string IP)
        {
            throw new NotImplementedException();
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
