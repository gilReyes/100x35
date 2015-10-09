using API.Repositories;
using Entity;
using System.Collections.Generic;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Results;
using Newtonsoft.Json;

namespace API.Controllers
{
    public class MessageController : ApiController
    {
        //Add repository
        private readonly IMessageRepository _messageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            //Initialize repository
            _messageRepository = messageRepository;
        }

        [HttpGet]
        public IHttpActionResult RecievedMessages(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return BadRequest();
            }

            return Ok(_messageRepository.GetRecievedMessages(username));
        }

        [HttpGet]
        public IHttpActionResult SentMessages(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return BadRequest();
            }

            return Ok(_messageRepository.GetSentMessages(username));
        }

        [HttpGet]
        public IHttpActionResult DeletedMessages(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return BadRequest();
            }

            return Ok(_messageRepository.GetDeletedMessages(username));
        }

        [HttpGet]
        public IHttpActionResult GetUserMessage(int messageId)
        {
            if (messageId == 0)
            {
                return BadRequest();
            }

            return Ok(_messageRepository.GetUserMessageByMessageId(messageId));
        }

        [HttpPost]
        public IHttpActionResult SendMessage(User_Message userMessage)
        {
            if (userMessage == null)
            {
                return BadRequest();
            }
            _messageRepository.CreateMessage(userMessage);
            return Ok();
        }

        [HttpPost]
        public IHttpActionResult DeleteMessage(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            _messageRepository.DeleteMessage(id);
            return Ok();
        }
    }
}