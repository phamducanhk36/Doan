//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebDoAn
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoOutLetter
    {
        public int ID { get; set; }
        public string StartTime { get; set; }
        public byte TimeLeave { get; set; }
        public string CreateTime { get; set; }
        public string Status { get; set; }
        public string Reason_ID { get; set; }
        public int Account_ID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Reason Reason { get; set; }
    }
}
