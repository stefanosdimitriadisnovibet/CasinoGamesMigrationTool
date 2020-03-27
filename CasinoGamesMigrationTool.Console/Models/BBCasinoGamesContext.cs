using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class BBCasinoGamesContext : DbContext
    {
        public BBCasinoGamesContext()
        {
        }

        public BBCasinoGamesContext(DbContextOptions<BBCasinoGamesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BonusAttributeValues> BonusAttributeValues { get; set; }
        public virtual DbSet<BonusAttributes> BonusAttributes { get; set; }
        public virtual DbSet<BonusProfiles> BonusProfiles { get; set; }
        public virtual DbSet<DisplayAttributeValues> DisplayAttributeValues { get; set; }
        public virtual DbSet<DisplayAttributes> DisplayAttributes { get; set; }
        public virtual DbSet<DisplayProfiles> DisplayProfiles { get; set; }
        public virtual DbSet<GameAttributeValues> GameAttributeValues { get; set; }
        public virtual DbSet<GameAttributes> GameAttributes { get; set; }
        public virtual DbSet<GamePoolEntries> GamePoolEntries { get; set; }
        public virtual DbSet<GamePoolEntrySchedules> GamePoolEntrySchedules { get; set; }
        public virtual DbSet<GamePools> GamePools { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<LanguageTranslations> LanguageTranslations { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LaunchAttributeValues> LaunchAttributeValues { get; set; }
        public virtual DbSet<LaunchGameAttributes> LaunchGameAttributes { get; set; }
        public virtual DbSet<LaunchProfileAttributeValues> LaunchProfileAttributeValues { get; set; }
        public virtual DbSet<LaunchProfiles> LaunchProfiles { get; set; }
        public virtual DbSet<LayoutAttributeValues> LayoutAttributeValues { get; set; }
        public virtual DbSet<LayoutAttributes> LayoutAttributes { get; set; }
        public virtual DbSet<LayoutGameAttributeValues> LayoutGameAttributeValues { get; set; }
        public virtual DbSet<LayoutGameAttributes> LayoutGameAttributes { get; set; }
        public virtual DbSet<LayoutGames> LayoutGames { get; set; }
        public virtual DbSet<LayoutTemplates> LayoutTemplates { get; set; }
        public virtual DbSet<Layouts> Layouts { get; set; }
        public virtual DbSet<MediaImages> MediaImages { get; set; }
        public virtual DbSet<MultilingualTexts> MultilingualTexts { get; set; }
        public virtual DbSet<PoolGameAttributeValues> PoolGameAttributeValues { get; set; }
        public virtual DbSet<PoolGameAttributes> PoolGameAttributes { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<Texts> Texts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=sqlserver.local;Database=BBCasinoGames;user=bbuser;password=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BonusAttributeValues>(entity =>
            {
                entity.HasKey(e => new { e.GameId, e.BonusAttributeId });

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.HasOne(d => d.BonusAttribute)
                    .WithMany(p => p.BonusAttributeValues)
                    .HasForeignKey(d => d.BonusAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BonusAttributeValues_BonusAttributes");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.BonusAttributeValues)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BonusAttributeValues_Games");
            });

            modelBuilder.Entity<BonusAttributes>(entity =>
            {
                entity.HasIndex(e => new { e.Sysname, e.BonusProfileId })
                    .HasName("IX_BonusAttributes_Sysname")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.BonusProfile)
                    .WithMany(p => p.BonusAttributes)
                    .HasForeignKey(d => d.BonusProfileId)
                    .HasConstraintName("FK_BonusAttributes_BonusProfiles");
            });

            modelBuilder.Entity<BonusProfiles>(entity =>
            {
                entity.HasIndex(e => e.Sysname)
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<DisplayAttributeValues>(entity =>
            {
                entity.HasKey(e => new { e.GameId, e.DisplayAttributeId });

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.HasOne(d => d.DisplayAttribute)
                    .WithMany(p => p.DisplayAttributeValues)
                    .HasForeignKey(d => d.DisplayAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DisplayAttributeValues_DisplayAttributes");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.DisplayAttributeValues)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DisplayAttributeValues_Games");
            });

            modelBuilder.Entity<DisplayAttributes>(entity =>
            {
                entity.HasIndex(e => new { e.Sysname, e.DisplayProfileId })
                    .HasName("IX_DisplayAttributes_Sysname")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.DisplayProfile)
                    .WithMany(p => p.DisplayAttributes)
                    .HasForeignKey(d => d.DisplayProfileId)
                    .HasConstraintName("FK_DisplayAttributes_DisplayProfiles");
            });

            modelBuilder.Entity<DisplayProfiles>(entity =>
            {
                entity.HasIndex(e => e.Sysname)
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<GameAttributeValues>(entity =>
            {
                entity.HasKey(e => new { e.GameId, e.GameAttributeId })
                    .HasName("PK_GameAttributeValue");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.HasOne(d => d.GameAttribute)
                    .WithMany(p => p.GameAttributeValues)
                    .HasForeignKey(d => d.GameAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameAttributeValue_GameAttribute");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GameAttributeValues)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameAttributeValues_Games");
            });

            modelBuilder.Entity<GameAttributes>(entity =>
            {
                entity.HasIndex(e => e.Sysname)
                    .HasName("IX_GameAttribute_Sysname")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<GamePoolEntries>(entity =>
            {
                entity.HasKey(e => new { e.GamePoolId, e.GameId });

                entity.HasIndex(e => new { e.Sysname, e.GamePoolId })
                    .HasName("IX_GamePoolEntries_Sysname")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GamePoolEntries)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GamePoolEntries_Games");

                entity.HasOne(d => d.GamePool)
                    .WithMany(p => p.GamePoolEntries)
                    .HasForeignKey(d => d.GamePoolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GamePoolEntries_GamePools");

                entity.HasOne(d => d.LaunchProfile)
                    .WithMany(p => p.GamePoolEntries)
                    .HasForeignKey(d => d.LaunchProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GamePoolEntries_LaunchProfiles");
            });

            modelBuilder.Entity<GamePoolEntrySchedules>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.GamePoolEntrySchedules)
                    .HasForeignKey(d => new { d.GamePoolId, d.GameId })
                    .HasConstraintName("FK_GamePoolSchedules_GamePoolEntries");
            });

            modelBuilder.Entity<GamePools>(entity =>
            {
                entity.HasIndex(e => e.Sysname)
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Games>(entity =>
            {
                entity.HasIndex(e => new { e.Name, e.ProviderId })
                    .HasName("IX_Games_Name")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Games)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Games_Providers");
            });

            modelBuilder.Entity<LanguageTranslations>(entity =>
            {
                entity.HasKey(e => new { e.MultilingualTextId, e.LanguageId });

                entity.Property(e => e.Body).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LanguageTranslations)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LanguageTranslations_Languages");

                entity.HasOne(d => d.MultilingualText)
                    .WithMany(p => p.LanguageTranslations)
                    .HasForeignKey(d => d.MultilingualTextId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LanguageTranslations_MultilingualTexts");
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.HasIndex(e => e.Sysname)
                    .HasName("IX_Languages")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LaunchAttributeValues>(entity =>
            {
                entity.HasKey(e => new { e.GameId, e.LaunchAttributeId })
                    .HasName("PK_GameLaunchAttributeValues");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(512);

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.LaunchAttributeValues)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameLaunchAttributeValues_Games");

                entity.HasOne(d => d.LaunchAttribute)
                    .WithMany(p => p.LaunchAttributeValues)
                    .HasForeignKey(d => d.LaunchAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameLaunchAttributeValues_LaunchAttributes");
            });

            modelBuilder.Entity<LaunchGameAttributes>(entity =>
            {
                entity.HasIndex(e => new { e.Sysname, e.LaunchProfileId })
                    .HasName("IX_LaunchGameAttributes_Sysname")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.LaunchProfile)
                    .WithMany(p => p.LaunchGameAttributes)
                    .HasForeignKey(d => d.LaunchProfileId)
                    .HasConstraintName("FK_LaunchAttributes_LaunchProfiles");
            });

            modelBuilder.Entity<LaunchProfileAttributeValues>(entity =>
            {
                entity.HasIndex(e => new { e.Sysname, e.LaunchProfileId })
                    .HasName("IX_LaunchProfileAttributes_Sysname")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.HasOne(d => d.LaunchProfile)
                    .WithMany(p => p.LaunchProfileAttributeValues)
                    .HasForeignKey(d => d.LaunchProfileId)
                    .HasConstraintName("FK_LaunchProfileAttributes_LaunchProfiles");
            });

            modelBuilder.Entity<LaunchProfiles>(entity =>
            {
                entity.HasIndex(e => new { e.Sysname, e.ProviderId })
                    .HasName("IX_LaunchProfiles_Sysname")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.LaunchProfiles)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaunchProfiles_Providers");
            });

            modelBuilder.Entity<LayoutAttributeValues>(entity =>
            {
                entity.HasKey(e => new { e.LayoutId, e.LayoutAttributeId });

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(512);

                entity.HasOne(d => d.LayoutAttribute)
                    .WithMany(p => p.LayoutAttributeValues)
                    .HasForeignKey(d => d.LayoutAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LayoutAttributeValues_LayoutAttributes");

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.LayoutAttributeValues)
                    .HasForeignKey(d => d.LayoutId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LayoutAttributeValues_Layouts");
            });

            modelBuilder.Entity<LayoutAttributes>(entity =>
            {
                entity.HasIndex(e => new { e.Sysname, e.LayoutTemplateId })
                    .HasName("IX_LayoutAttributes_Sysname")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.LayoutTemplate)
                    .WithMany(p => p.LayoutAttributes)
                    .HasForeignKey(d => d.LayoutTemplateId)
                    .HasConstraintName("FK_LayoutAttributes_LayoutTemplates");
            });

            modelBuilder.Entity<LayoutGameAttributeValues>(entity =>
            {
                entity.HasKey(e => new { e.LayoutGameId, e.LayoutGameAttributeId });

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.HasOne(d => d.LayoutGameAttribute)
                    .WithMany(p => p.LayoutGameAttributeValues)
                    .HasForeignKey(d => d.LayoutGameAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LayoutGameAttributeValues_LayoutGameAttributes");

                entity.HasOne(d => d.LayoutGame)
                    .WithMany(p => p.LayoutGameAttributeValues)
                    .HasForeignKey(d => d.LayoutGameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LayoutGameAttributeValues_LayoutGames");
            });

            modelBuilder.Entity<LayoutGameAttributes>(entity =>
            {
                entity.HasIndex(e => new { e.Sysname, e.LayoutTemplateId })
                    .HasName("IX_LayoutGameAttributes_Sysname")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.LayoutTemplate)
                    .WithMany(p => p.LayoutGameAttributes)
                    .HasForeignKey(d => d.LayoutTemplateId)
                    .HasConstraintName("FK_LayoutGameAttributes_LayoutTemplates");
            });

            modelBuilder.Entity<LayoutGames>(entity =>
            {
                entity.HasIndex(e => new { e.GameId, e.LayoutId })
                    .HasName("IX_LayoutGames_Game")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.LayoutGames)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LayoutGames_Games");

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.LayoutGames)
                    .HasForeignKey(d => d.LayoutId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LayoutGames_Layouts");
            });

            modelBuilder.Entity<LayoutTemplates>(entity =>
            {
                entity.HasIndex(e => e.Sysname)
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Layouts>(entity =>
            {
                entity.HasIndex(e => e.Sysname)
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.LayoutTemplate)
                    .WithMany(p => p.Layouts)
                    .HasForeignKey(d => d.LayoutTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Layouts_LayoutTemplates");
            });

            modelBuilder.Entity<MediaImages>(entity =>
            {
                entity.HasIndex(e => e.Title)
                    .IsUnique();

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Tags).IsRequired();

                entity.Property(e => e.ThumbData).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<MultilingualTexts>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<PoolGameAttributeValues>(entity =>
            {
                entity.HasKey(e => new { e.GameId, e.PoolGameAttributeId })
                    .HasName("PK_PoolGameValues");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.PoolGameAttributeValues)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PoolGameAttributeValues_Games");

                entity.HasOne(d => d.PoolGameAttribute)
                    .WithMany(p => p.PoolGameAttributeValues)
                    .HasForeignKey(d => d.PoolGameAttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PoolGameAttributeValues_PoolGameAttributes");
            });

            modelBuilder.Entity<PoolGameAttributes>(entity =>
            {
                entity.HasIndex(e => new { e.Sysname, e.GamePoolId })
                    .HasName("IX_PoolGameAttributes_Sysname")
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.GamePool)
                    .WithMany(p => p.PoolGameAttributes)
                    .HasForeignKey(d => d.GamePoolId)
                    .HasConstraintName("FK_PoolGameAttributes_GamePools");
            });

            modelBuilder.Entity<Providers>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .IsUnique();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Sysname)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Texts>(entity =>
            {
                entity.Property(e => e.Body)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
