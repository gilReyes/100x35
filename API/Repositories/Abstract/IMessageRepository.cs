using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Repositories
{
    public interface IMessageRepository : IDisposable
    {
        IEnumerable<GetRecievedMessages_SP_Result> GetRecievedMessages(string username);
        IEnumerable<GetSentMessages_SP_Result> GetSentMessages(string username);
        IEnumerable<GetDeletedMessages_SP_Result> GetDeletedMessages(string username);
        Message GetMessageById(int id);
        void CreateMessage(Message messaage);
        void DeleteMessage(int id);
    }
}
