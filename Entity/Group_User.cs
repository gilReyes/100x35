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
    
    public partial class Group_User
    {
        public string Username { get; set; }
        public int Group_Id { get; set; }
        public System.DateTime Join_Date { get; set; }
        public Nullable<System.DateTime> Deletion_Date { get; set; }
        public int Group_User_Id { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}