using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Managers;
using Web.Models;

namespace Web.Controllers
{
    public class InboxController : Controller
    {
        //Add manager
        private readonly IMessageManager _messageManager;

        public InboxController(IMessageManager messageManager)
        {
            //Initialize manager
            _messageManager = messageManager;
        }

        public ActionResult Index()
        {
            var model = _messageManager.RecievedMessages("test-username");
            return View(model);
        }

        [HttpGet]
        public PartialViewResult Inbox()
        {
            var model = _messageManager.RecievedMessages("test-username");
            return PartialView("_Inbox", model);
        }

        [HttpGet]
        public PartialViewResult Outbox()
        {
            var model = _messageManager.SentMessages("test-username");
            return PartialView("_Outbox", model);
        }

        [HttpGet]
        public PartialViewResult Deleted()
        {
            var model = _messageManager.DeletedMessages("test-username");
            return PartialView("_Trash", model);
        }

        [HttpPost]
        public RedirectToRouteResult Delete(int id)
        {
            _messageManager.DeleteMessage(id);
            return RedirectToAction("Inbox");
        }

        [HttpGet]
        public PartialViewResult Compose()
        {
            return PartialView("_Compose", new ComposeViewReply());
        }

        [HttpPost]
        public RedirectToRouteResult Compose(ComposeViewReply model)
        {
            var userMessage = new User_Message() { Sender = "test-username" ,Reciever = model.To, Message = new Message() { Sent_Date = DateTime.Now, Subject = model.Subject, Message1 = model.Message} };
            _messageManager.SendMessage(userMessage);
            return RedirectToAction("Inbox");
        }

        [HttpGet]
        public PartialViewResult Reply(int replyingToId)
        {
            var userMessage = _messageManager.GetUserMessageByMessageId(replyingToId);
            var model = new ReplyViewModel() { ReplyingToMessage = userMessage.Message.Message1, Subject = userMessage.Message.Subject, To = userMessage.Sender};
            return PartialView("_Reply", model);
        }

        [HttpPost]
        public RedirectToRouteResult Reply(ReplyViewModel model)
        {
            var userMessage = new User_Message() { Sender = "test-username", Reciever = model.To, Message = new Message() { Sent_Date = DateTime.Now, Subject = model.Subject, Message1 = model.Message } };
            _messageManager.SendMessage(userMessage);
            return RedirectToAction("Inbox");
        }

        [HttpGet]
        public PartialViewResult ViewInboxMessage(int id)
        {
            var userMessage = _messageManager.GetUserMessageByMessageId(id);
            return PartialView("_ReadInbox", userMessage);
        }

        [HttpGet]
        public PartialViewResult ViewSentMessage(int id)
        {
            var userMessage = _messageManager.GetUserMessageByMessageId(id);
            return PartialView("_ReadSent", userMessage);
        }

        [HttpGet]
        public PartialViewResult ViewDeletedMessage(int id)
        {
            var userMessage = _messageManager.GetUserMessageByMessageId(id);
            return PartialView("_ReadTrash", userMessage);
        }
    }
}