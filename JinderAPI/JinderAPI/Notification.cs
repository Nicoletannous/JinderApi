//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JinderAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notification
    {
        public int NotificationId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string NotificationText { get; set; }
        public Nullable<System.DateTime> NotificationDate { get; set; }
        public Nullable<int> TargetId { get; set; }
    
        public virtual JinderUser JinderUser { get; set; }
    }
}