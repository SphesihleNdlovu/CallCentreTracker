//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CallCentreFollowUps.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAgentActivity
    {
        public int AgentActiviryID { get; set; }
        public Nullable<int> RespondentID { get; set; }
        public Nullable<int> AgentID { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string Comments { get; set; }
        public string Contacts { get; set; }
        public string Phase { get; set; }
        public Nullable<int> ScreeningID { get; set; }
        public Nullable<int> InterviewID { get; set; }
        public string Resp_Surname { get; set; }
    
        public virtual lutStatu lutStatu { get; set; }
        public virtual tblAgent tblAgent { get; set; }
        public virtual tblRespondent tblRespondent { get; set; }
    }
}
