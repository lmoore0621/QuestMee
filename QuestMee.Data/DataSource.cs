namespace QuestMee.Data
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataSource : DbContext
    {
        public DataSource()
            : base("name=DataSource")
        {
        }

        public DataSource(string ConnectionString)
            : base(ConnectionString)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ContentStatus> ContentStatuses { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Thread> Threads { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserStatus> UserStatuses { get; set; }
        public DbSet<Votes> Votes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryConfig());
            modelBuilder.Configurations.Add(new ContentStatusConfig());
            modelBuilder.Configurations.Add(new GroupsConfig());
            modelBuilder.Configurations.Add(new PostConfig());
            modelBuilder.Configurations.Add(new ThreadConfig());
            modelBuilder.Configurations.Add(new UserStatusConfig());
            //.Configurations.Add(new Use());
            modelBuilder.Configurations.Add(new UserStatusConfig());
            modelBuilder.Configurations.Add(new VotesConfig());
        }
    }
}