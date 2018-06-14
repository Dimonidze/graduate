using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace netservice
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class NetService : INetService
    {
        List<Users> users = new List<Users>();
        List<Chats> chats = new List<Chats>();

        public int Connect(string login, string password)
        {
            var user = users.Find(i => i.Login == login);
            if (user != null)
            {
                if (user.Password == password)
                {
                    user.OperationContext = OperationContext.Current;
                    return 0;
                }
                return 2;
            }
            return 1;
        }

        public void Disconnect(string uid)
        {
            throw new NotImplementedException();
        }

        public int Register(string login, string password, string firstname, string lastname, string position)
        {
            var userf = users.Find(i => i.Login == login);
            if (userf == null)
            {
                Users user = new Users()
                {
                    Login = login,
                    Password = password,
                    FirstName = firstname,
                    LastName = lastname,
                    Position = position,
                    OperationContext = OperationContext.Current
                };
                users.Add(user);
                return 0;
            }
            return 1;
        }

        public void SendMsg(string msg, string uid, int cid)
        {
            throw new NotImplementedException();
        }
    }
}
