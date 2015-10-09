using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ReplyViewModel
    {
        public string ReplyingToMessage { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }

    public class ComposeViewReply
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}