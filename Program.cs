using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualProxyDataset virtualProxyDataset = new VirtualProxyDataset("sensitiveData.csv");

            User user1 = User.GenerateUser("John");
            User user2 = User.GenerateUser("Owen");

            ProtectionProxyDataset protectionProxyDataset1 = new ProtectionProxyDataset(user1);
            ProtectionProxyDataset protectionProxyDataset2 = new ProtectionProxyDataset(user2);

            DataConsolePrinter dataConsolePrinter = new DataConsolePrinter();

            try
            {
                dataConsolePrinter.PrintData(protectionProxyDataset1);
                dataConsolePrinter.PrintData(protectionProxyDataset2);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
}
