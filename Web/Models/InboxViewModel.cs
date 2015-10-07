using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ReplyViewModel
    {
        public Message ReplyingTo { get; set; }
        public Message NewMessage { get; set; }
    }

}