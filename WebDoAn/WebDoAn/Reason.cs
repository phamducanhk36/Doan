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
    
    public partial class Reason
    {
        public Reason()
        {
            this.AbsenceLetters = new HashSet<AbsenceLetter>();
            this.GoOutLetters = new HashSet<GoOutLetter>();
        }
    
        public string ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<AbsenceLetter> AbsenceLetters { get; set; }
        public virtual ICollection<GoOutLetter> GoOutLetters { get; set; }
    }
}