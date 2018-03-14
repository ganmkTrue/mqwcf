using System;
using Service.Interface;

namespace Service
{
    public partial class PublicMessageQueue : IPublicMessageQueue
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine(string.Format("消息队列开始处理，输入{0}成功", msg));
        }
    }
}
