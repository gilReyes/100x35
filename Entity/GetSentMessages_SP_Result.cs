//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    
    public partial class GetSentMessages_SP_Result
    {
        public int Message_Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public System.DateTime Sent_Date { get; set; }
        public Nullable<System.DateTime> Read_Date { get; set; }
        public Nullable<System.DateTime> Deletion_Date { get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public int Message_Id1 { get; set; }
        public int User_Message_Id { get; set; }
    }
}
