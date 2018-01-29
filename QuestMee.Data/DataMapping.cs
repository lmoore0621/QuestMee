using QuestMee.Model;
using System.Data.Entity.ModelConfiguration;

namespace QuestMee.Data
{
    public class CategoryConfig : EntityTypeConfiguration<Category>
    {
        public CategoryConfig(string table = "Categories", string schema = "dbo")
        {
            ToTable(table, schema);
            HasKey(c => c.Id);
            Property(c => c.Name).HasMaxLength(100).IsRequired();
            Property(c => c.Description).HasMaxLength(250);
            Property(c => c.CreatedTime).HasMaxLength(50);
        }
    }

    public class ContentStatusConfig : EntityTypeConfiguration<ContentStatus>
    {
        public ContentStatusConfig(string table = "Categories", string schema = "dbo")
        {
            ToTable(table, schema);
            HasKey(c => c.Id);
            Property(c => c.Name).HasMaxLength(100).IsRequired();
        }
    }

    public class GroupsConfig : EntityTypeConfiguration<Groups>
    {
        public GroupsConfig(string table = "Groups", string schema = "dbo")
        {
            ToTable(table, schema);
            HasKey(g => g.Id);
            Property(g => g.Name).HasMaxLength(100).IsRequired();
        }
    }

    public class PostConfig : EntityTypeConfiguration<Post>
    {
        public PostConfig(string table = "Posts", string schema = "dbo")
        {
            ToTable(table, schema);
            HasKey(p => p.Id);
            Property(p => p.Subject).HasMaxLength(100).IsRequired();
            Property(p => p.Content).IsMaxLength().IsRequired();
            Property(p => p.CreatedTime).HasMaxLength(20).IsRequired();
        }
    }

    public class ThreadConfig : EntityTypeConfiguration<Post>
    {
        public ThreadConfig(string table = "Threads", string schema = "dbo")
        {
            ToTable(table, schema);
            HasKey(t => t.Id);
            Property(t => t.Subject).HasMaxLength(100).IsRequired();
            Property(t => t.CreatedTime).HasMaxLength(20).IsRequired();
        }
    }

    public class UserAccountConfig : EntityTypeConfiguration<UserAccount>
    {
        public UserAccountConfig(string table = "UserAccount", string schema = "dbo")
        {
            ToTable(table, schema);
            HasKey(ua => ua.Id);
            Property(ua => ua.UserName).HasMaxLength(50).IsRequired();
            Property(ua => ua.Password).HasMaxLength(50).IsRequired();
            Property(ua => ua.FirstName).HasMaxLength(50).IsRequired();
            Property(ua => ua.LastName).HasMaxLength(50).IsRequired();
            Property(ua => ua.Email).HasMaxLength(50).IsRequired();
            Property(ua => ua.CreatedTime).HasMaxLength(20).IsRequired();
            Property(ua => ua.Picture).HasMaxLength(50).IsOptional();
            Property(ua => ua.LastActivity).HasMaxLength(50).IsRequired();
            Property(ua => ua.IsModerator).HasColumnType("BIT").IsRequired();
            Property(ua => ua.Status).HasMaxLength(50).IsRequired();
        }
    }

    public class UserStatusConfig : EntityTypeConfiguration<UserStatus>
    {
        public UserStatusConfig(string table = "UserStatus", string schema = "dbo")
        {
            ToTable(table, schema);
            HasKey(us => us.Id);
            Property(us => us.Name).HasMaxLength(10).IsRequired();
        }
    }

    public class VotesConfig : EntityTypeConfiguration<Votes>
    {
        public VotesConfig(string table = "Votes", string schema = "dbo")
        {
            ToTable(table, schema);
            HasKey(t => t.Id);
            Property(t => t.UpVote).HasColumnType("int").IsRequired();
            Property(t => t.DownVote).HasColumnType("int").IsRequired();
        }
    }
}