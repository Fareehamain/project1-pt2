//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project_1_pt_5
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assignment
    {
        public int AssignmentID { get; set; }
        public System.DateTime DateAssigned { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ProblemDescription { get; set; }
        public Nullable<bool> Completed { get; set; }
        public Nullable<int> EmployeeID { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
