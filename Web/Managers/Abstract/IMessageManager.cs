using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Managers
{
    public interface IMessageManager
    {
        IEnumerable<GetRecievedMessages_SP_Result> RecievedMessages(string username);
        IEnumerable<GetSentMessages_SP_Result> SentMessages(string username);
        IEnumerable<GetDeletedMessages_SP_Result> DeletedMessages(string username);
        Message GetMessage(int id);
        bool SendMessage(Message message);
        bool DeleteMessage(int id);
    }
}
