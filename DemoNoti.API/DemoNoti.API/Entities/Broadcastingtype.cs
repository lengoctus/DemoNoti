using System;
using System.Collections.Generic;

namespace DemoNoti.API.Entities
{
    public partial class Broadcastingtype
    {
        public Broadcastingtype()
        {
            Personalbroadcastings = new HashSet<Personalbroadcasting>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }

        public virtual ICollection<Personalbroadcasting> Personalbroadcastings { get; set; }
    }
}
