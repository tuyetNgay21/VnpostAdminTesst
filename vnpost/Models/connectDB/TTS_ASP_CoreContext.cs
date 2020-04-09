using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace vnpost.Models.connectDB
{
    public partial class TTS_ASP_CoreContext : DbContext
    {
        public TTS_ASP_CoreContext()
        {
        }

        public TTS_ASP_CoreContext(DbContextOptions<TTS_ASP_CoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Infomation> Infomation { get; set; }
        public virtual DbSet<IsAdmin> IsAdmin { get; set; }
        public virtual DbSet<IsLogin> IsLogin { get; set; }
        public virtual DbSet<IsMenuSinger1> IsMenuSinger1 { get; set; }
        public virtual DbSet<IsNavSinger> IsNavSinger { get; set; }
        public virtual DbSet<IsNavbar> IsNavbar { get; set; }
        public virtual DbSet<IsPost> IsPost { get; set; }
        public virtual DbSet<IsSpecies> IsSpecies { get; set; }
        public virtual DbSet<IsTheme> IsTheme { get; set; }
        public virtual DbSet<IsVideo> IsVideo { get; set; }
        public virtual DbSet<ThanTrang> ThanTrang { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Server=WT436;Database=TTS_ASP_Core;Trusted_Connection=True");
                optionsBuilder.UseSqlServer("Server=DESKTOP-J4QTH4N\\SQLEXPRESS;Database=TTS_ASP_Core;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Infomation>(entity =>
            {
                entity.Property(e => e.InfomationId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.IsAddress)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.IsAge).HasDefaultValueSql("((8))");

                entity.Property(e => e.IsName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsPhone).HasColumnType("numeric(15, 0)");

                entity.HasOne(d => d.InfomationNavigation)
                    .WithOne(p => p.Infomation)
                    .HasForeignKey<Infomation>(d => d.InfomationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Infomatio__Infom__1AD3FDA4");
            });

            modelBuilder.Entity<IsAdmin>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__IsAdmin__719FE4883D0C54EE");

                entity.Property(e => e.Footer)
                    .IsRequired()
                    .HasColumnName("footer")
                    .HasMaxLength(300);

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasColumnName("logo")
                    .HasMaxLength(100);

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.IsAdmin)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK__IsAdmin__MenuId__489AC854");

                entity.HasOne(d => d.MenuId1Navigation)
                    .WithMany(p => p.IsAdminMenuId1Navigation)
                    .HasForeignKey(d => d.MenuId1)
                    .HasConstraintName("FK__IsAdmin__MenuId1__45BE5BA9");

                entity.HasOne(d => d.MenuId2Navigation)
                    .WithMany(p => p.IsAdminMenuId2Navigation)
                    .HasForeignKey(d => d.MenuId2)
                    .HasConstraintName("FK__IsAdmin__MenuId2__46B27FE2");

                entity.HasOne(d => d.MenuId3Navigation)
                    .WithMany(p => p.IsAdminMenuId3Navigation)
                    .HasForeignKey(d => d.MenuId3)
                    .HasConstraintName("FK__IsAdmin__MenuId3__47A6A41B");
            });

            modelBuilder.Entity<IsLogin>(entity =>
            {
                entity.HasKey(e => e.Account)
                    .HasName("PK__IsLogin__EA162E10A1BAFD62");

                entity.Property(e => e.Account)
                    .HasColumnName("account")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Decentralization).HasColumnName("decentralization");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HaskPassword)
                    .IsRequired()
                    .HasColumnName("haskPassword")
                    .HasMaxLength(10);

                entity.Property(e => e.Passwork)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IsMenuSinger1>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("PK__IsMenuSi__C99ED2305C7DE466");

                entity.Property(e => e.BoN).HasColumnName("boN");

                entity.Property(e => e.Stt).HasColumnName("stt");

                entity.HasOne(d => d.BoNNavigation)
                    .WithMany(p => p.InverseBoNNavigation)
                    .HasForeignKey(d => d.BoN)
                    .HasConstraintName("FK__IsMenuSinge__boN__40058253");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.IsMenuSinger1)
                    .HasForeignKey(d => d.ThemeId)
                    .HasConstraintName("FK__IsMenuSin__Theme__3E1D39E1");
            });

            modelBuilder.Entity<IsNavSinger>(entity =>
            {
                entity.HasKey(e => e.NavbarSingerId)
                    .HasName("PK__IsNavSin__8C8A0DF108CAE878");

                entity.Property(e => e.DateCreate)
                    .HasColumnName("dateCreate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateDelete)
                    .HasColumnName("dateDelete")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdate)
                    .HasColumnName("dateUpdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ImageSinger)
                    .IsRequired()
                    .HasColumnName("imageSinger")
                    .HasMaxLength(100);

                entity.Property(e => e.LinkImage)
                    .IsRequired()
                    .HasColumnName("linkImage")
                    .HasMaxLength(100);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<IsNavbar>(entity =>
            {
                entity.HasKey(e => e.NavbarId)
                    .HasName("PK__IsNavbar__CF5371712EA15389");

                entity.Property(e => e.BoNavBar).HasColumnName("boNavBar");

                entity.Property(e => e.Stt).HasColumnName("stt");

                entity.HasOne(d => d.BoNavBarNavigation)
                    .WithMany(p => p.InverseBoNavBarNavigation)
                    .HasForeignKey(d => d.BoNavBar)
                    .HasConstraintName("FK__IsNavbar__boNavB__3B40CD36");

                entity.HasOne(d => d.NavbarSinger)
                    .WithMany(p => p.IsNavbar)
                    .HasForeignKey(d => d.NavbarSingerId)
                    .HasConstraintName("FK__IsNavbar__Navbar__395884C4");
            });

            modelBuilder.Entity<IsPost>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__IsPost__AA1260188CCFCAD8");

                entity.Property(e => e.AvataIndex)
                    .IsRequired()
                    .HasColumnName("avataIndex")
                    .HasMaxLength(200);

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.DayInPost)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ViewPost).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.IsPost)
                    .HasForeignKey(d => d.SpeciesId)
                    .HasConstraintName("FK__IsPost__SpeciesI__2B0A656D");
            });

            modelBuilder.Entity<IsSpecies>(entity =>
            {
                entity.HasKey(e => e.SpeciesId)
                    .HasName("PK__IsSpecie__A938045FE9E20186");

                entity.Property(e => e.AvatarSpecies)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.IsTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Isname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ThemeDabNavigation)
                    .WithMany(p => p.InverseThemeDabNavigation)
                    .HasForeignKey(d => d.ThemeDab)
                    .HasConstraintName("FK__IsSpecies__Theme__25518C17");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.IsSpecies)
                    .HasForeignKey(d => d.ThemeId)
                    .HasConstraintName("FK__IsSpecies__Theme__245D67DE");
            });

            modelBuilder.Entity<IsTheme>(entity =>
            {
                entity.HasKey(e => e.ThemeId)
                    .HasName("PK__IsTheme__FBB3E4D9AFD89D75");

                entity.Property(e => e.AvatarTheme)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.IsTitle)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Isname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<IsVideo>(entity =>
            {
                entity.HasKey(e => e.VideoId)
                    .HasName("PK__IsVideo__BAE5126AC52B03A6");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.DayInPost)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VideoIndex)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ViewPost).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Species)
                    .WithMany(p => p.IsVideo)
                    .HasForeignKey(d => d.SpeciesId)
                    .HasConstraintName("FK__IsVideo__Species__30C33EC3");
            });

            modelBuilder.Entity<ThanTrang>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("PK__ThanTran__C99ED2302DAFE8DA");

                entity.Property(e => e.BoN).HasColumnName("boN");

                entity.Property(e => e.PatialView)
                    .IsRequired()
                    .HasColumnName("patialView")
                    .HasMaxLength(300);

                entity.Property(e => e.Stt).HasColumnName("stt");

                entity.HasOne(d => d.BoNNavigation)
                    .WithMany(p => p.InverseBoNNavigation)
                    .HasForeignKey(d => d.BoN)
                    .HasConstraintName("FK__ThanTrang__boN__42E1EEFE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
