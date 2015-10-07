using System;
using System.Collections.Generic;
using Entity;
using System.Data.Entity;

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
            var messages = context.GetRecievedMessages_SP(username);
            return messages;
        }

        public IEnumerable<GetSentMessages_SP_Result> GetSentMessages(string username)
        {
            var messages = context.GetSentMessages_SP(username);
            return messages;
        }

        public IEnumerable<GetDeletedMessages_SP_Result> GetDeletedMessages(string username)
        {
            var messages = context.GetDeletedMessages_SP(username);
            return messages;
        }

        public Message GetMessageById(int id)
        {
            var message = context.Messages.Find(id);
            ReadMessage(message);
            return message;
        }

        public void CreateMessage(Message messaage)
        {
            context.Messages.Add(messaage);
            SaveChanges();
        }

        public void DeleteMessage(int id)
        {
            var message = GetMessageById(id);
            context.Messages.Remove(message);
            SaveChanges();
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