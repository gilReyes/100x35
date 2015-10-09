using Entity;
using System;
using System.Collections.Generic;

//Change name space from API.Repositories.Abstract to API.Repositories
namespace API.Repositories
{
    //Implement IDisposable
    public interface IMessageRepository : IDisposable
    {
        //All your public methods
        IEnumerable<GetRecievedMessages_SP_Result> GetRecievedMessages(string username);
        IEnumerable<GetSentMessages_SP_Result> GetSentMessages(string username);
        IEnumerable<GetDeletedMessages_SP_Result> GetDeletedMessages(string username);
        User_Message GetUserMessageByMessageId(int id);
        void CreateMessage(User_Message userMessaage);
        void DeleteMessage(int id);
    }
}
