using System;
using System.Collections.Generic;

namespace DemoNoti.Client.Entities
{
    public partial class Livesport
    {
        public Livesport()
        {
            Livelinks = new HashSet<Livelink>();
        }

        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Name { get; set; } = null!;
        public int SportTypeId { get; set; }
        public int LeagueId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }
        public string LeagueName { get; set; } = null!;

        public virtual Sporttype SportType { get; set; } = null!;
        public virtual ICollection<Livelink> Livelinks { get; set; }
    }
}
