using System;
using System.Collections.Generic;

namespace DemoNoti.Client.Entities
{
    public partial class Sporttype
    {
        public Sporttype()
        {
            Livescores = new HashSet<Livescore>();
            Livesports = new HashSet<Livesport>();
            Matchscores = new HashSet<Matchscore>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? UrlImage { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }
        public string NameKo { get; set; } = null!;
        public int SportRefId { get; set; }

        public virtual ICollection<Livescore> Livescores { get; set; }
        public virtual ICollection<Livesport> Livesports { get; set; }
        public virtual ICollection<Matchscore> Matchscores { get; set; }
    }
}
