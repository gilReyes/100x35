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
        User_Message GetUserMessageByMessageId(int id);
        bool SendMessage(User_Message userMessage);
        bool DeleteMessage(int id);
    }
}
