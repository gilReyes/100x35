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
    using System.Collections.Generic;
    
    public partial class Event_User
    {
        public int Event_Id { get; set; }
        public string Username { get; set; }
        public bool Attending { get; set; }
        public int Event_User_Id { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
    }
}