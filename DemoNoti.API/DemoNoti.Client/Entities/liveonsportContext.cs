using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DemoNoti.Client.Entities
{
    public partial class liveonsportContext : DbContext
    {
        public liveonsportContext()
        {
        }

        public liveonsportContext(DbContextOptions<liveonsportContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accesscontrol> Accesscontrols { get; set; } = null!;
        public virtual DbSet<Accessresource> Accessresources { get; set; } = null!;
        public virtual DbSet<Broadcastingtype> Broadcastingtypes { get; set; } = null!;
        public virtual DbSet<Chatmember> Chatmembers { get; set; } = null!;
        public virtual DbSet<Chatroom> Chatrooms { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Community> Communities { get; set; } = null!;
        public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; } = null!;
        public virtual DbSet<Livelink> Livelinks { get; set; } = null!;
        public virtual DbSet<Livescore> Livescores { get; set; } = null!;
        public virtual DbSet<Livesport> Livesports { get; set; } = null!;
        public virtual DbSet<Matchscore> Matchscores { get; set; } = null!;
        public virtual DbSet<Minigame> Minigames { get; set; } = null!;
        public virtual DbSet<Personalbroadcasting> Personalbroadcastings { get; set; } = null!;
        public virtual DbSet<Popupsbanner> Popupsbanners { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Sporttype> Sporttypes { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Useractivity> Useractivities { get; set; } = null!;
        public virtual DbSet<Userloginaction> Userloginactions { get; set; } = null!;
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=liveonsport;uid=root;pwd=ng@ctu2005212;port=3306", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Accesscontrol>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ResourceId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("accesscontrols");

                entity.HasIndex(e => e.ResourceId, "IX_AccessControls_ResourceId");

                entity.HasIndex(e => e.UserId, "IX_AccessControls_UserId");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Accesscontrols)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_AccessControls_AccessResources_ResourceId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Accesscontrols)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AccessControls_Users_UserId");
            });

            modelBuilder.Entity<Accessresource>(entity =>
            {
                entity.ToTable("accessresources");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Slug).HasMaxLength(250);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);
            });

            modelBuilder.Entity<Broadcastingtype>(entity =>
            {
                entity.ToTable("broadcastingtypes");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);
            });

            modelBuilder.Entity<Chatmember>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoomId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("chatmembers");

                entity.HasIndex(e => e.RoomId, "IX_ChatMembers_RoomId");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Chatmembers)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_ChatMembers_ChatRooms_RoomId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Chatmembers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ChatMembers_Users_UserId");
            });

            modelBuilder.Entity<Chatroom>(entity =>
            {
                entity.ToTable("chatrooms");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("comments");

                entity.HasIndex(e => e.CommunityId, "IX_Comments_CommunityId");

                entity.HasIndex(e => e.UserId, "IX_Comments_UserId");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);

                entity.HasOne(d => d.Community)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.CommunityId)
                    .HasConstraintName("FK_Comments_Communities_CommunityId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Comments_Users_UserId");
            });

            modelBuilder.Entity<Community>(entity =>
            {
                entity.ToTable("communities");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<Livelink>(entity =>
            {
                entity.ToTable("livelinks");

                entity.HasIndex(e => e.LiveSportId, "IX_LiveLinks_LiveSportId");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.Link).HasMaxLength(250);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);

                entity.HasOne(d => d.LiveSport)
                    .WithMany(p => p.Livelinks)
                    .HasForeignKey(d => d.LiveSportId)
                    .HasConstraintName("FK_LiveLinks_LiveSports_LiveSportId");
            });

            modelBuilder.Entity<Livescore>(entity =>
            {
                entity.ToTable("livescores");

                entity.HasIndex(e => e.SportTypeId, "IX_LiveScores_SportTypeId");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);

                entity.HasOne(d => d.SportType)
                    .WithMany(p => p.Livescores)
                    .HasForeignKey(d => d.SportTypeId)
                    .HasConstraintName("FK_LiveScores_SportTypes_SportTypeId");
            });

            modelBuilder.Entity<Livesport>(entity =>
            {
                entity.ToTable("livesports");

                entity.HasIndex(e => e.SportTypeId, "IX_LiveSports_SportTypeId");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.EndTime).HasMaxLength(6);

                entity.Property(e => e.LeagueName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.StartTime).HasMaxLength(6);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);

                entity.HasOne(d => d.SportType)
                    .WithMany(p => p.Livesports)
                    .HasForeignKey(d => d.SportTypeId)
                    .HasConstraintName("FK_LiveSports_SportTypes_SportTypeId");
            });

            modelBuilder.Entity<Matchscore>(entity =>
            {
                entity.ToTable("matchscores");

                entity.HasIndex(e => e.SportTypeId, "IX_MatchScores_SportTypeId");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);

                entity.HasOne(d => d.SportType)
                    .WithMany(p => p.Matchscores)
                    .HasForeignKey(d => d.SportTypeId)
                    .HasConstraintName("FK_MatchScores_SportTypes_SportTypeId");
            });

            modelBuilder.Entity<Minigame>(entity =>
            {
                entity.ToTable("minigames");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.DeActivedAt).HasMaxLength(6);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);
            });

            modelBuilder.Entity<Personalbroadcasting>(entity =>
            {
                entity.ToTable("personalbroadcastings");

                entity.HasIndex(e => e.BroadCastingTypeId, "IX_PersonalBroadCastings_BroadCastingTypeId");

                entity.HasIndex(e => e.UserId, "IX_PersonalBroadCastings_UserId");

                entity.Property(e => e.Bjvalue)
                    .HasMaxLength(250)
                    .HasColumnName("BJValue");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.EndTime).HasMaxLength(6);

                entity.Property(e => e.Link).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.StartTime).HasMaxLength(6);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);

                entity.HasOne(d => d.BroadCastingType)
                    .WithMany(p => p.Personalbroadcastings)
                    .HasForeignKey(d => d.BroadCastingTypeId)
                    .HasConstraintName("FK_PersonalBroadCastings_BroadCastingTypes_BroadCastingTypeId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Personalbroadcastings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PersonalBroadCastings_Users_UserId");
            });

            modelBuilder.Entity<Popupsbanner>(entity =>
            {
                entity.ToTable("popupsbanners");

                entity.HasIndex(e => e.AccessResourceId, "IX_PopupsBanners_AccessResourceId");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.EndTo)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("'0001-01-01 00:00:00.000000'");

                entity.Property(e => e.StartFrom)
                    .HasMaxLength(6)
                    .HasDefaultValueSql("'0001-01-01 00:00:00.000000'");

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);

                entity.HasOne(d => d.AccessResource)
                    .WithMany(p => p.Popupsbanners)
                    .HasForeignKey(d => d.AccessResourceId)
                    .HasConstraintName("FK_PopupsBanners_AccessResources_AccessResourceId");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);
            });

            modelBuilder.Entity<Sporttype>(entity =>
            {
                entity.ToTable("sporttypes");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.RoleId, "IX_Users_RoleId");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.LastestLogin).HasMaxLength(6);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.RefreshToken).HasMaxLength(250);

                entity.Property(e => e.RefreshTokenExpiryTime).HasMaxLength(6);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);

                entity.Property(e => e.UserName).HasMaxLength(250);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Users_Roles_RoleId");
            });

            modelBuilder.Entity<Useractivity>(entity =>
            {
                entity.ToTable("useractivities");

                entity.HasIndex(e => e.UserId, "IX_UserActivities_UserId")
                    .IsUnique();

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.QtyCmntposted).HasColumnName("QtyCMNTPosted");

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);
            });

            modelBuilder.Entity<Userloginaction>(entity =>
            {
                entity.ToTable("userloginactions");

                entity.HasIndex(e => e.UserId, "IX_UserLoginActions_UserId");

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.DeviceAccess).HasMaxLength(250);

                entity.Property(e => e.Ipaccess)
                    .HasMaxLength(50)
                    .HasColumnName("IPAccess");

                entity.Property(e => e.LoginTime).HasMaxLength(6);

                entity.Property(e => e.LogoutTime).HasMaxLength(6);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userloginactions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserLoginActions_Users_UserId");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("vendors");

                entity.Property(e => e.CompanyId)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConnectionStr).HasMaxLength(200);

                entity.Property(e => e.CreatedAt).HasMaxLength(6);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.LicenseKey).HasMaxLength(32);

                entity.Property(e => e.PhoneNumber).HasMaxLength(12);

                entity.Property(e => e.SiteLink).HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasMaxLength(6);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
