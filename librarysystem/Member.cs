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
    
    public partial class Member
    {
        public Member()
        {
            this.BookIssues = new HashSet<BookIssue>();
        }
    
        public string MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberType { get; set; }
        public string LibraryCardStatus { get; set; }
        public string MemberGender { get; set; }
        public string MemberPhone { get; set; }
        public string MemberEmail { get; set; }
        public string MemberDepartment { get; set; }
        public string MemberAddress { get; set; }
    
        public virtual ICollection<BookIssue> BookIssues { get; set; }
        public virtual LogInInfo LogInInfo { get; set; }
        public virtual MemberCategory MemberCategory { get; set; }
    }
}
