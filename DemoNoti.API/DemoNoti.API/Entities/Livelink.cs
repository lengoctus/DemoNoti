using System;
using System.Collections.Generic;

namespace DemoNoti.API.Entities
{
    public partial class Livelink
    {
        public int Id { get; set; }
        public string Link { get; set; } = null!;
        public int LiveSportId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }

        public virtual Livesport LiveSport { get; set; } = null!;
    }
}
