//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace emarket
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public long orderID { get; set; }
        public long userID { get; set; }
        public string sessionID { get; set; }
        public Nullable<int> orderStatus { get; set; }
        public Nullable<decimal> subtotal { get; set; }
        public Nullable<decimal> tax { get; set; }
        public Nullable<decimal> shipping { get; set; }
        public Nullable<decimal> total { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
    
        public virtual user user { get; set; }
    }
}