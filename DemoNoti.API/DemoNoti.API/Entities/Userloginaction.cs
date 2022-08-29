using System;
using System.Collections.Generic;

namespace DemoNoti.API.Entities
{
    public partial class Userloginaction
    {
        public int Id { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public string Ipaccess { get; set; } = null!;
        public string DeviceAccess { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
