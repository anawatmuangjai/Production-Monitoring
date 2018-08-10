using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PDR.Infrastructure.Entities;

namespace PDR.Infrastructure.Context
{
    public partial class PDRContext : DbContext
    {
        public virtual DbSet<MstLossGroup> MstLossGroup { get; set; }
        public virtual DbSet<ProdMonitor> ProdMonitor { get; set; }

        public PDRContext(DbContextOptions<PDRContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasAnnotation("Relational:DefaultSchema", "PDR");
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "dbo");

            modelBuilder.Entity<MstLossGroup>(entity =>
            {
                entity.HasKey(e => e.IdFactor);

                entity.ToTable("MST_LOSS_GROUP");

                entity.Property(e => e.IdFactor)
                    .HasColumnName("ID_FACTOR")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppName)
                    .IsRequired()
                    .HasColumnName("APP_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BColor)
                    .HasColumnName("B_COLOR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Charge)
                    .IsRequired()
                    .HasColumnName("CHARGE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('UNKNOW')");

                entity.Property(e => e.FlagStop).HasColumnName("FLAG_STOP");

                entity.Property(e => e.Note)
                    .HasColumnName("NOTE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasColumnName("ORDER_NO")
                    .HasDefaultValueSql("((999))");

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('UNKNOW')");

                entity.Property(e => e.StatusName)
                    .HasColumnName("STATUS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TroubleName)
                    .IsRequired()
                    .HasColumnName("TROUBLE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProdMonitor>(entity =>
            {
                entity.HasKey(e => e.LineName);

                entity.ToTable("PROD_MONITOR");

                entity.Property(e => e.LineName)
                    .HasColumnName("LINE_NAME")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualShot)
                    .HasColumnName("ACTUAL_SHOT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DisplayGroup)
                    .HasColumnName("DISPLAY_GROUP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdMstLossGroup)
                    .HasColumnName("ID_MST_LOSS_GROUP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LossTime)
                    .HasColumnName("LOSS_TIME")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NgQty)
                    .HasColumnName("NG_QTY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlanDiff)
                    .HasColumnName("PLAN_DIFF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlanId)
                    .HasColumnName("PLAN_ID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.PlanShot)
                    .HasColumnName("PLAN_SHOT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate)
                    .IsRequired()
                    .HasColumnName("UPDATE_DATE")
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.UrgentFlag).HasColumnName("URGENT_FLAG");

                entity.HasOne(d => d.IdMstLossGroupNavigation)
                    .WithMany(p => p.ProdMonitor)
                    .HasForeignKey(d => d.IdMstLossGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROD_MONITOR_MST_LOSS_GROUP");
            });
        }
    }
}
