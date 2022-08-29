using System;
using System.Collections.Generic;

namespace DemoNoti.Client.Entities
{
    public partial class Vendor
    {
        public int Id { get; set; }
        public string LicenseKey { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ConnectionStr { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }
        public string CompanyName { get; set; } = null!;
        public string SiteLink { get; set; } = null!;
        public string CompanyId { get; set; } = null!;
    }
}
