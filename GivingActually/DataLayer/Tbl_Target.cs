//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GivingActually.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Target
    {
        public int Id { get; set; }
        public Nullable<decimal> TargetAmount { get; set; }
        public string MoneyType { get; set; }
        public Nullable<System.DateTime> TargetDate { get; set; }
        public string HospitalName { get; set; }
        public string HospitalLocation { get; set; }
        public string Ailment { get; set; }
        public int StoryId { get; set; }
        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int Category { get; set; }
    
        public virtual Tbl_Stories Tbl_Stories { get; set; }
    }
}
