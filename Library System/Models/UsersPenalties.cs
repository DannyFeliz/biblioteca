//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_System.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersPenalties
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public Nullable<decimal> Penalty { get; set; }
        public int IsPaid { get; set; }
        public System.DateTime CreatedAt { get; set; }
    }
}
