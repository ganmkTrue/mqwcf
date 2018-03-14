using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using MessageDealingClient.ServiceReference1;

namespace MessageDealingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ChannelFactory<IPublicMessageQueue> channelFactory = new ChannelFactory<IPublicMessageQueue>("NetMsmqBinding_IPublicMessageQueue"))
            {
                IPublicMessageQueue proxyServer = channelFactory.CreateChannel();
                proxyServer.SendMessage("hello world");
                Console.WriteLine("客户端先启动，将消息传到消息队列，若WCF服务启动，则会输出hello world");
            }
            Console.Read();
        }
    }
}
