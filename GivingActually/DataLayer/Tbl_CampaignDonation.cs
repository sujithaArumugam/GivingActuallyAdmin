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
    
    public partial class Tbl_CampaignDonation
    {
        public int Id { get; set; }
        public int StoryId { get; set; }
        public decimal DonationAmnt { get; set; }
        public bool Status { get; set; }
        public string Email { get; set; }
        public Nullable<bool> isAnanymous { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string PinCode { get; set; }
        public string DonatedBy { get; set; }
        public Nullable<System.DateTime> DonatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string PlaceName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public Nullable<bool> isPaid { get; set; }
        public string razorpay_order_id { get; set; }
        public string razorpay_payment_id { get; set; }
        public string razorpay_signature { get; set; }
    
        public virtual Tbl_Campaign Tbl_Campaign { get; set; }
    }
}
