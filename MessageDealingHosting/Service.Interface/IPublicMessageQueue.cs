using System.ServiceModel;

namespace Service.Interface
{
    [ServiceContract]
    public interface IPublicMessageQueue
    {
        [OperationContract(IsOneWay = true)]
        void SendMessage(string msg);
    }
}
