using System;
using System.Collections.Generic;

namespace DemoNoti.Client.Entities
{
    public partial class Accessresource
    {
        public Accessresource()
        {
            Accesscontrols = new HashSet<Accesscontrol>();
            Popupsbanners = new HashSet<Popupsbanner>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Slug { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }
        public int? ParentId { get; set; }
        public bool? IsEdit { get; set; }
        public int Priority { get; set; }

        public virtual ICollection<Accesscontrol> Accesscontrols { get; set; }
        public virtual ICollection<Popupsbanner> Popupsbanners { get; set; }
    }
}
