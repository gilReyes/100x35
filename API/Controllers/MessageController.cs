using API.Repositories;
using Entity;
using System.Collections.Generic;
using System.Web.Mvc;

namespace API.Controllers
{
    public class MessageController : Controller
    {
        //Add repository
        private IMessageRepository _messageRepository;

        public MessageController(MessageRepository messageRepository)
        {
            //Initialize repository
            _messageRepository = messageRepository;
        }

        [HttpGet]
        public IEnumerable<GetRecievedMessages_SP_Result> RecievedMessages(string username)
        {
            return _messageRepository.GetRecievedMessages(username);
        }

        [HttpGet]
        public IEnumerable<GetSentMessages_SP_Result> SentMessages(string username)
        {
            return _messageRepository.GetSentMessages(username);
        }

        [HttpGet]
        public IEnumerable<GetDeletedMessages_SP_Result> DeletedMessages(string username)
        {
            return _messageRepository.GetDeletedMessages(username);
        }

        [HttpGet]
        public Message GetMessage(int id)
        {
            return _messageRepository.GetMessageById(id);
        }

        [HttpPost]
        public void SendMessage(Message message)
        {
            _messageRepository.CreateMessage(message);
        }

        [HttpPost]
        public void DeleteMessage(int id)
        {
            _messageRepository.DeleteMessage(id);
        }
    }
}