using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA43Team4B
{
    class MaintainControlClass
    {
        // <Control methods>
        FormMaintenanceMember mCaller = null;
        public MaintainControlClass() : this(null) { }
        public MaintainControlClass(FormMaintenanceMember caller) { mCaller = caller; }
        public string MemberAdd(Member mb, LibrarySystemEntities ct)        //Add Member
        {
            try
            {
                Member temp = ct.Members.Where(x => x.MemberID == mb.MemberID).FirstOrDefault();
                if (temp != null)
                    return "MemberID exists. Do you want to modify it?";
                // find MemberCategory from the link
                MemberCategory mc = ct.MemberCategories.Where(x => x.MemberType == mb.MemberType).FirstOrDefault();
                mb.MemberCategory = mc;
                // add in LoginInfo with password = default(8888) and type = Member
                LogInInfo lg = new LogInInfo();
                lg.UserID = mb.MemberID;
                lg.LoginPassword = "8888";
                lg.UserType = "Member";
                ct.LogInInfoes.Add(lg);

                mb.LogInInfo = lg;
                ct.Members.Add(mb);
                int ok = ct.SaveChanges();
                if (ok > 0) // return number of objects written
                {
                    mCaller.LoadEntity();
                    return "Successfully Added";
                }
            }
            catch (Exception except)
            {
                return except.ToString();
            }
            return "Failed, Nothing changed";
        }

        public string MemberUpdate(Member mb, LibrarySystemEntities ct)     //Update Member
        {
            try
            {
                Member temp = ct.Members.Where(x => x.MemberID == mb.MemberID).FirstOrDefault();
                if (temp == null) return "MemberID is not exist. Do you want to create one";
                // MemberID/LoginInfo/BookIssue should not change
                temp.LibraryCardStatus = mb.LibraryCardStatus;
                temp.MemberAddress = mb.MemberAddress;
                temp.MemberCategory = mb.MemberCategory;
                temp.MemberDepartment = mb.MemberDepartment;
                temp.MemberEmail = mb.MemberEmail;
                temp.MemberGender = mb.MemberGender;
                temp.MemberPhone = mb.MemberPhone;
                temp.MemberName = mb.MemberName;
                temp.MemberType = mb.MemberType;
                // find MemberCategory from the link
                MemberCategory mc = ct.MemberCategories.Where(x => x.MemberType == mb.MemberType).FirstOrDefault();
                temp.MemberCategory = mc;
                int ok = ct.SaveChanges();
                if (ok > 0)
                {
                    //LoadEntity();
                    return "Successfully Updated";
                }
            }
            catch (Exception except)
            {
                return except.ToString();
            }
            return "Failed, Nothing changed";
        }

        public bool DeleteCheck(Member mb, LibrarySystemEntities ct)
        {
            // check data integrity with BookIssue and IssueDetail
            BookIssue bis = ct.BookIssues.Where(x => x.MemberID == mb.MemberID).FirstOrDefault();
            return (bis == null);
        }

        public string MemberDelete(Member mb, LibrarySystemEntities ct)     //Delete Member
        {
            try
            {
                // delete all bookissue and issuedetails records
                List<BookIssue> bis = ct.BookIssues.Where(x => x.MemberID == mb.MemberID).ToList();
                foreach (BookIssue bi in bis)
                {
                    List<IssueDetail> isd = ct.IssueDetails.Where(x => x.IssueID == bi.IssueID).ToList();
                    foreach (IssueDetail id in isd)
                    {
                        ct.IssueDetails.Remove(id);
                    }
                    ct.BookIssues.Remove(bi);
                }

                // should both delete in LogInfo and Member
                LogInInfo lg = ct.LogInInfoes.Where(x => x.UserID == mb.MemberID).FirstOrDefault();
                // even cannot find mb in Members, if LogInInfo exist, should be deleted
                if (lg != null)
                    ct.LogInInfoes.Remove(lg);
                Member temp = ct.Members.Where(x => x.MemberID == mb.MemberID).FirstOrDefault();
                if (temp != null)
                    ct.Members.Remove(temp);

                int ok = ct.SaveChanges();
                mCaller.LoadEntity();

                if (temp == null)
                    return "MemberID is not exist. Please check the MemberID.";
                if (ok > 0)
                {
                    return "Successfully Deleted";
                }
            }
            catch (Exception except)
            {
                return except.ToString();
            }
            return "Failed, Nothing changed";
        }

        // </Control methods>

    }
}
