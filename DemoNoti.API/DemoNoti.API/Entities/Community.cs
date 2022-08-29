using System;
using System.Collections.Generic;

namespace DemoNoti.API.Entities
{
    public partial class Community
    {
        public Community()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int QtyReCommend { get; set; }
        public int QtyView { get; set; }
        public string Content { get; set; } = null!;
        public bool Pinned { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
