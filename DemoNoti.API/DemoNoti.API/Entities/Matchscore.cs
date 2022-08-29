using System;
using System.Collections.Generic;

namespace DemoNoti.API.Entities
{
    public partial class Matchscore
    {
        public int Id { get; set; }
        public string? UrlImage { get; set; }
        public string SportName { get; set; } = null!;
        public int SportTypeId { get; set; }
        public int SportRefId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }
        public string SportNameKo { get; set; } = null!;

        public virtual Sporttype SportType { get; set; } = null!;
    }
}
