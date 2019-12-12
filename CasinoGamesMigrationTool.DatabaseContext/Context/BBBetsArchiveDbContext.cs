using CasinoGamesMigrationTool.DatabaseContext.Models;
using Microsoft.EntityFrameworkCore;

namespace CasinoGamesMigrationTool.DatabaseContext.Context
{
	public partial class BBBetsArchiveDbContext : DbContext
	{
		public BBBetsArchiveDbContext()
		{
		}

		public BBBetsArchiveDbContext(DbContextOptions<BBBetsArchiveDbContext> options)
			: base(options)
		{
		}

		public virtual DbSet<CasinoManufacturer> CasinoManufacturer { get; set; }
		public virtual DbSet<CasinoProviders> CasinoProviders { get; set; }
		public virtual DbSet<UserCasinoGameTypes> UserCasinoGameTypes { get; set; }
		public virtual DbSet<UserCasinoGames> UserCasinoGames { get; set; }
		public virtual DbSet<UserCasinoGamesCategories> UserCasinoGamesCategories { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
				optionsBuilder.UseSqlServer("server=sqlserver.local;database=bbbetsarchive;user id=bbuser;password=123;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CasinoManufacturer>(entity =>
			{
				entity.HasIndex(e => e.Sysname)
					.HasName("IX_CasinoManufacturer")
					.IsUnique();

				entity.Property(e => e.Sysname)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<CasinoProviders>(entity =>
			{
				entity.HasIndex(e => e.ProviderId)
					.HasName("IX_CasinoProviders")
					.IsUnique();

				entity.HasIndex(e => e.Sysname)
					.HasName("IX_CasinoProviders_1")
					.IsUnique();

				entity.Property(e => e.Description)
					.HasMaxLength(256)
					.IsUnicode(false);

				entity.Property(e => e.Sysname)
					.IsRequired()
					.HasMaxLength(256)
					.IsUnicode(false);
			});

			modelBuilder.Entity<UserCasinoGameTypes>(entity =>
			{
				entity.HasIndex(e => e.Sysname)
					.HasName("IX_UserCasinoGameTypes")
					.IsUnique();

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(256)
					.IsUnicode(false);

				entity.Property(e => e.Note).HasMaxLength(1024);

				entity.Property(e => e.Sysname)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<UserCasinoGames>(entity =>
			{
				entity.HasIndex(e => e.GameId)
					.HasName("IX_UserCasinoGames")
					.IsUnique();

				entity.HasIndex(e => e.Sysname)
					.HasName("IX_UserCasinoGames_1")
					.IsUnique();

				entity.Property(e => e.Caption)
					.IsRequired()
					.HasMaxLength(256);

				entity.Property(e => e.CaptionEn)
					.IsRequired()
					.HasColumnName("CaptionEN")
					.HasMaxLength(256);

				entity.Property(e => e.Category)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.Created)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description).HasMaxLength(256);

				entity.Property(e => e.JackpotContribution).HasColumnType("decimal(9, 5)");

				entity.Property(e => e.ProviderFee).HasColumnType("decimal(11, 7)");

				entity.Property(e => e.Sysname)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.Updated).HasColumnType("datetime");

				entity.HasOne(d => d.CategoryNavigation)
					.WithMany(p => p.UserCasinoGames)
					.HasPrincipalKey(p => p.Category)
					.HasForeignKey(d => d.Category)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCasinoGames_UserCasinoGamesCategories");

				entity.HasOne(d => d.ManufacturerNavigation)
					.WithMany(p => p.UserCasinoGames)
					.HasForeignKey(d => d.Manufacturer)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCasinoGames_CasinoManufacturer");

				entity.HasOne(d => d.ProviderNavigation)
					.WithMany(p => p.UserCasinoGames)
					.HasPrincipalKey(p => p.ProviderId)
					.HasForeignKey(d => d.Provider)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCasinoGames_CasinoProviders");

				entity.HasOne(d => d.TypeNavigation)
					.WithMany(p => p.UserCasinoGames)
					.HasForeignKey(d => d.Type)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCasinoGames_UserCasinoGameTypes");
			});

			modelBuilder.Entity<UserCasinoGamesCategories>(entity =>
			{
				entity.HasIndex(e => e.Category)
					.HasName("IX_UserCasinoGamesCategories")
					.IsUnique();

				entity.Property(e => e.Category)
					.IsRequired()
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
