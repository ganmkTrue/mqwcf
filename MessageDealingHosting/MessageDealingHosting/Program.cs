using Service;
using System;
using System.ServiceModel;

namespace MessageDealingHosting
{
    class Program
        {
            static void Main(string[] args)
            {                
                using (ServiceHost host = new ServiceHost(typeof(PublicMessageQueue)))
                {
                    host.Opened += delegate
                    {
                        Console.WriteLine(host.Description.Endpoints[0].Address.Uri + "已经启动，按任意键终止服务！");
                    };

                    host.Open();
                    Console.Read();
                }
            }
        }
}
