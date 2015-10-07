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
        private IMessageManager _messageManager;

        public InboxController(MessageManager messageManager)
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
            return PartialView("_Deleted", model);
        }

        [HttpGet]
        public PartialViewResult Compose()
        {
            return PartialView("_Compose", new Message());
        }

        [HttpPost]
        public RedirectToRouteResult Compose(Message message)
        {
            _messageManager.SendMessage(message);
            return RedirectToAction("Outbox");
        }

        [HttpGet]
        public PartialViewResult Reply(int replyingToId)
        {
            var message = _messageManager.GetMessage(replyingToId);
            var model = new ReplyViewModel() { ReplyingTo = message };
            return PartialView("_Reply", model);
        }

        [HttpPost]
        public RedirectToRouteResult Reply(Message message)
        {
            _messageManager.SendMessage(message);
            return RedirectToAction("Outbox");
        }

        [HttpGet]
        public PartialViewResult View(int id)
        {
            var message = _messageManager.GetMessage(id);
            return PartialView("_Read", message);
        }

    }
}