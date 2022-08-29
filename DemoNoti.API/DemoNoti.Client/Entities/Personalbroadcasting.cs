using System;
using System.Collections.Generic;

namespace DemoNoti.Client.Entities
{
    public partial class Personalbroadcasting
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Bjvalue { get; set; }
        public string? Link { get; set; }
        public int Status { get; set; }
        public int BroadCastingTypeId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }
        public bool IsDefault { get; set; }

        public virtual Broadcastingtype BroadCastingType { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
