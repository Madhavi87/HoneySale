//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HoneySaleDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class StaffPayment
    {
        public int ID { get; set; }
        public Nullable<int> Staff__ID { get; set; }
        public Nullable<decimal> Balance_Amount { get; set; }
        public Nullable<decimal> Return_Amount { get; set; }
        public Nullable<System.DateTime> Return_Date { get; set; }
        public Nullable<System.DateTime> Received_On { get; set; }
        public string Received_By { get; set; }
    
        public virtual tbluser tbluser { get; set; }
    }
}
