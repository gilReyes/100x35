using API.Repositories;
using Entity;
using System.Collections.Generic;
using System.Web.Helpers;
using System.Web.Mvc;
using Newtonsoft.Json;

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
        public JsonResult RecievedMessages(string username)
        {
            return Json(_messageRepository.GetRecievedMessages(username), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult SentMessages(string username)
        {
            return Json(_messageRepository.GetSentMessages(username), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult DeletedMessages(string username)
        {
            return Json(_messageRepository.GetDeletedMessages(username), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetUserMessage(int messageId)
        {
            return Json(_messageRepository.GetUserMessageByMessageId(messageId), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public void SendMessage(User_Message userMessage)
        {
            _messageRepository.CreateMessage(userMessage);
        }

        [HttpPost]
        public void DeleteMessage(int id)
        {
            _messageRepository.DeleteMessage(id);
        }
    }
}