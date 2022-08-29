using System;
using System.Collections.Generic;

namespace DemoNoti.API.Entities
{
    public partial class Accesscontrol
    {
        public int UserId { get; set; }
        public int ResourceId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }
        public bool IsRead { get; set; }
        public bool IsWrite { get; set; }

        public virtual Accessresource Resource { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
