using System;
using System.Collections.Generic;

namespace DemoNoti.API.Entities
{
    public partial class Popupsbanner
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime StartFrom { get; set; }
        public DateTime EndTo { get; set; }
        public int AccessResourceId { get; set; }
        public string Image { get; set; } = null!;
        public string Content { get; set; } = null!;
        public int Type { get; set; }
        public int WidthSize { get; set; }
        public int? Priority { get; set; }
        public int ContentType { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }
        public int? DirectSettingFrequency { get; set; }
        public int HeightSize { get; set; }
        public int PostingFrequency { get; set; }

        public virtual Accessresource AccessResource { get; set; } = null!;
    }
}
