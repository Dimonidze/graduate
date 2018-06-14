using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace netservice
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "Inetservice" в коде и файле конфигурации.
    [ServiceContract(CallbackContract = typeof(INetServiceCallBack))]
    public interface INetService
    {
        [OperationContract]
        int Connect(string login, string password);

        [OperationContract]
        int Register(string login, string password, string firstname, string lastname, string position);

        [OperationContract]
        void Disconnect(string uid);

        [OperationContract(IsOneWay = true)]
        void SendMsg(string msg, string uid, int cid);
    }
    
    public interface INetServiceCallBack
    {
        [OperationContract(IsOneWay = true)]
        void CallBack(string msg, int idU, int idC);
    }
}
