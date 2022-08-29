using System;
using System.Collections.Generic;

namespace DemoNoti.API.Entities
{
    public partial class Chatroom
    {
        public Chatroom()
        {
            Chatmembers = new HashSet<Chatmember>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int NbAllowAccess { get; set; }
        public int NbCurrentAccess { get; set; }
        public int? NbUnRead { get; set; }
        public int Type { get; set; }
        public string? Image { get; set; }
        public string RoomKey { get; set; } = null!;
        public int ManagerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }

        public virtual ICollection<Chatmember> Chatmembers { get; set; }
    }
}
