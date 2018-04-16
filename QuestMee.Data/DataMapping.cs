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

            HasMany(c => c.Categories).WithOptional().HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false);
            HasMany(c => c.Groups).WithRequired(c => c.Category).HasForeignKey(c => c.CategoryId).WillCascadeOnDelete(false);
            HasRequired(cs => cs.ContentStatus).WithMany(c => c.Categories).HasForeignKey(cs => cs.ContentStatusId).WillCascadeOnDelete(false);
        }
    }

    public class ContentStatusConfig : EntityTypeConfiguration<ContentStatus>
    {
        public ContentStatusConfig(string table = "ContentStatuses", string schema = "dbo")
        {
            ToTable(table, schema);
            HasKey(cs => cs.Id);
            Property(cs => cs.Name).HasMaxLength(100).IsRequired();

            HasMany(cs => cs.Threads).WithRequired(cs => cs.Status).HasForeignKey(s => s.ContentStatusId).WillCascadeOnDelete(false);
            HasMany(p => p.Posts).WithRequired(s => s.ContentStatus).HasForeignKey(cs => cs.ContentStatusId).WillCascadeOnDelete(false);
            HasMany(cs => cs.Categories).WithRequired(cs => cs.ContentStatus).HasForeignKey(c => c.ContentStatusId).WillCascadeOnDelete(false);
        }
    }

    public class GroupsConfig : EntityTypeConfiguration<Groups>
    {
        public GroupsConfig(string table = "Groups", string schema = "dbo")
        {
            ToTable(table, schema);
            HasKey(g => g.Id);
            Property(g => g.Name).HasMaxLength(100).IsRequired();

            HasRequired(g => g.Category).WithMany(g => g.Groups).HasForeignKey(g => g.CategoryId).WillCascadeOnDelete(false);
            HasMany(g => g.UserGroups).WithRequired(g => g.Group).HasForeignKey(g => g.GroupsId).WillCascadeOnDelete(false);
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

            HasRequired(p => p.ContentStatus).WithMany(p => p. Posts).HasForeignKey(p => p.ContentStatusId).WillCascadeOnDelete(false);
            HasRequired(p => p.UserAccount).WithMany(p => p.Posts).HasForeignKey(p => p.UserAccountId).WillCascadeOnDelete(false);
            HasRequired(p => p.Thread).WithMany(p => p.Posts).HasForeignKey(p => p.ThreadId).WillCascadeOnDelete(false);
            HasMany(p => p.Votes).WithOptional(p => p.Post).WillCascadeOnDelete(false);
        }
    }

    public class ThreadConfig : EntityTypeConfiguration<Thread>
    {
        public ThreadConfig(string table = "Threads", string schema = "dbo")
        {
            ToTable(table, schema);
            HasKey(t => t.Id);
            Property(t => t.Subject).HasMaxLength(100).IsRequired();
            Property(t => t.CreatedTime).HasMaxLength(20).IsRequired();

            HasRequired(t => t.Status).WithMany(t => t.Threads).HasForeignKey(t => t.ContentStatusId).WillCascadeOnDelete(false);
            HasRequired(t => t.UserAccount).WithMany(t => t.Threads).HasForeignKey(t => t.UserAccountId).WillCascadeOnDelete(false);
            HasMany(t => t.Votes).WithOptional(t => t.Thread).WillCascadeOnDelete(false);
            HasMany(t => t.Posts).WithRequired(t => t.Thread).HasForeignKey(t => t.ThreadId).WillCascadeOnDelete(false);
        }
    }

    public class UserAccountConfig : EntityTypeConfiguration<UserAccount>
    {
        public UserAccountConfig(string table = "UserAccounts", string schema = "dbo")
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

            HasMany(ua => ua.Categories).WithRequired(ua => ua.Creator).HasForeignKey(ua => ua.CategoryId).WillCascadeOnDelete(false);
            HasMany(ua => ua.UserGroups).WithRequired(ua => ua.UserAccount).HasForeignKey(ua => ua.UserId).WillCascadeOnDelete(false);
            HasMany(ua => ua.Posts).WithRequired(ua => ua.UserAccount).HasForeignKey(ua => ua.UserAccountId).WillCascadeOnDelete(false);
            HasMany(ua => ua.Threads).WithRequired(ua => ua.UserAccount).HasForeignKey(ua => ua.UserAccountId).WillCascadeOnDelete(false);
            HasRequired(ua => ua.UserStatus).WithMany(ua => ua.UserAccounts).HasForeignKey(ua => ua.UserStatusId).WillCascadeOnDelete(false);
        }
    }

    public class UserStatusConfig : EntityTypeConfiguration<UserStatus>
    {
        public UserStatusConfig(string table = "UserStatus", string schema = "dbo")
        {
            ToTable(table, schema);
            HasKey(us => us.Id);
            Property(us => us.Name).HasMaxLength(10).IsRequired();

            HasMany(ua => ua.UserAccounts).WithRequired(us => us.UserStatus).HasForeignKey(fk => fk.UserStatusId).WillCascadeOnDelete(false);
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

            HasOptional(v => v.Thread).WithMany(v => v.Votes).HasForeignKey(v => v.ThreadId).WillCascadeOnDelete(false);
            HasOptional(v => v.Post).WithMany(v => v.Votes).HasForeignKey(v => v.PostId).WillCascadeOnDelete(false);
        }
    }
}