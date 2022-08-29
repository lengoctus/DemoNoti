using System;
using System.Collections.Generic;

namespace DemoNoti.Client.Entities
{
    public partial class Useractivity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QtyAccess { get; set; }
        public int QtyCmntposted { get; set; }
        public int QtyCommented { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }
    }
}
