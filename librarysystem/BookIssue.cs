//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA43Team4B
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookIssue
    {
        public BookIssue()
        {
            this.IssueDetails = new HashSet<IssueDetail>();
        }
    
        public string IssueID { get; set; }
        public string EmpID { get; set; }
        public string MemberID { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<IssueDetail> IssueDetails { get; set; }
    }
}
