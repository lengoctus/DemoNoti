using System;
using System.Collections.Generic;

namespace DemoNoti.API.Entities
{
    public partial class User
    {
        public User()
        {
            Accesscontrols = new HashSet<Accesscontrol>();
            Chatmembers = new HashSet<Chatmember>();
            Comments = new HashSet<Comment>();
            Personalbroadcastings = new HashSet<Personalbroadcasting>();
            Userloginactions = new HashSet<Userloginaction>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; } = null!;
        public bool Gender { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateTime? LastestLogin { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public int RoleId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActived { get; set; }
        public string? Avatar { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Accesscontrol> Accesscontrols { get; set; }
        public virtual ICollection<Chatmember> Chatmembers { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Personalbroadcasting> Personalbroadcastings { get; set; }
        public virtual ICollection<Userloginaction> Userloginactions { get; set; }
    }
}
