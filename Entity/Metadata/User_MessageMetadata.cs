using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [MetadataType(typeof (User_MessageMetadata))]
    public partial class User_Message
    {
        internal sealed class User_MessageMetadata
        {
            [Required]
            public string Sender { get; set; }
            [Required]
            public string Reciever { get; set; }
            public int Message_Id { get; set; }
            public int User_Message_Id { get; set; }
        }
    }

}
