using System;
using System.Collections.Generic;
using Entity;
using System.Data.Entity;
using System.Linq;

//Change name space from API.Repositories.Concrete to API.Repositories
namespace API.Repositories
{
    //Implement BaseRepository and respective interface
    public class MessageRepository : BaseRepository, IMessageRepository
    {
        //Initializer method that accepts data base context
        public MessageRepository(DataModelConnection context)
        {
            //this.context is declared in BaseRepository
            this.context = context;
        }

        //Public Methods
        public IEnumerable<GetRecievedMessages_SP_Result> GetRecievedMessages(string username)
        {
            var messages = context.GetRecievedMessages_SP(username).ToList();
            return messages;
        }

        public IEnumerable<GetSentMessages_SP_Result> GetSentMessages(string username)
        {
            var messages = context.GetSentMessages_SP(username).ToList();
            return messages;
        }

        public IEnumerable<GetDeletedMessages_SP_Result> GetDeletedMessages(string username)
        {
            var messages = context.GetDeletedMessages_SP(username).ToList();
            return messages;
        }

        public User_Message GetUserMessageByMessageId(int id)
        {
            var userMessage = context.User_Message.AsQueryable().FirstOrDefault(foo => foo.Message_Id == id);
            ReadMessage(context.Messages.Find(id));
            SaveChanges();
            return userMessage;
        }

        public void CreateMessage(User_Message userMessage)
        {
            context.Messages.Add(userMessage.Message);
            userMessage.Message_Id = userMessage.Message.Message_Id;
            context.User_Message.Add(userMessage);
            SaveChanges();
        }

        public void DeleteMessage(int id)
        {
            var message = context.Messages.Find(id);
            if (message != null)
            {
                message.Deletion_Date = DateTime.Now;
                context.Entry(message).State = EntityState.Modified;
                SaveChanges();
            }
        }

        //Private Methods
        private void ReadMessage(Message message)
        {
            message.Read_Date = DateTime.Now;
            context.Entry(message).State = EntityState.Modified;
        }

        private void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}