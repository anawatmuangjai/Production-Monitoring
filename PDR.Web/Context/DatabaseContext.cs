namespace PDR.Web.Context
{
    using PDR.Web.Models;
    using System.Data.Entity;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<MST_LOSS_GROUP> MST_LOSS_GROUP { get; set; }
        public virtual DbSet<PROD_MONITOR> PROD_MONITOR { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MST_LOSS_GROUP>()
                .Property(e => e.TROUBLE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MST_LOSS_GROUP>()
                .Property(e => e.APP_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MST_LOSS_GROUP>()
                .Property(e => e.STATUS_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<MST_LOSS_GROUP>()
                .Property(e => e.OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<MST_LOSS_GROUP>()
                .Property(e => e.CHARGE)
                .IsUnicode(false);

            modelBuilder.Entity<MST_LOSS_GROUP>()
                .Property(e => e.B_COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<MST_LOSS_GROUP>()
                .Property(e => e.NOTE)
                .IsUnicode(false);

            modelBuilder.Entity<MST_LOSS_GROUP>()
                .HasMany(e => e.PROD_MONITOR)
                .WithRequired(e => e.MST_LOSS_GROUP)
                .HasForeignKey(e => e.ID_MST_LOSS_GROUP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PROD_MONITOR>()
                .Property(e => e.LINE_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<PROD_MONITOR>()
                .Property(e => e.UPDATE_DATE)
                .IsUnicode(false);

            modelBuilder.Entity<PROD_MONITOR>()
                .Property(e => e.DISPLAY_GROUP)
                .IsUnicode(false);
        }
    }
}
