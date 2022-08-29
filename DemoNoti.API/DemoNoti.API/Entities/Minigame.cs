using System;
using System.Collections.Generic;

namespace DemoNoti.API.Entities
{
    public partial class Minigame
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CompanyName { get; set; }
        public string? UrlLink { get; set; }
        public DateTime DeActivedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }
    }
}
