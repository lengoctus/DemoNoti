using System;
using System.Collections.Generic;

namespace DemoNoti.API.Entities
{
    public partial class Chatmember
    {
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }

        public virtual Chatroom Room { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
