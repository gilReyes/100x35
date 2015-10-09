using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [MetadataType(typeof (MessageMetadata))]
    public partial class Message
    {
        internal sealed class MessageMetadata
        {
            public int Message_Id { get; set; }
            [Required]
            public string Subject { get; set; }
            [Required]
            public string Message1 { get; set; }
            public System.DateTime Sent_Date { get; set; }
            public Nullable<System.DateTime> Read_Date { get; set; }
            public Nullable<System.DateTime> Deletion_Date { get; set; }
        }
    }
}
