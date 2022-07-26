using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Something
{
    public partial class OlaContext : DbContext
    {
        public OlaContext()
        {
        }

        public OlaContext(DbContextOptions<OlaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdrEmail> AdrEmail { get; set; }
        public virtual DbSet<AdrEwid> AdrEwid { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Ola;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdrEmail>(entity =>
            {
                entity.HasKey(e => e.AmId);

                entity.ToTable("adr_Email");

                entity.Property(e => e.AmId)
                    .HasColumnName("am_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AmEmail)
                    .IsRequired()
                    .HasColumnName("am_Email")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AmIdAdres).HasColumnName("am_IdAdres");

                entity.Property(e => e.AmPodstawowy).HasColumnName("am_Podstawowy");

                entity.Property(e => e.AmRodzaj)
                    .HasColumnName("am_Rodzaj")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AmIdAdresNavigation)
                    .WithMany(p => p.AdrEmail)
                    .HasForeignKey(d => d.AmIdAdres)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_adr_Email_adr__Ewid");
            });

            modelBuilder.Entity<AdrEwid>(entity =>
            {
                entity.HasKey(e => e.AdrId);

                entity.ToTable("adr__Ewid");

                entity.HasIndex(e => e.AdrMiejscowosc)
                    .HasName("IX_adr__Ewid_Miejscowosc");

                entity.HasIndex(e => new { e.AdrId, e.AdrNip })
                    .HasName("IX_adr__Ewid_1");

                entity.HasIndex(e => new { e.AdrIdObiektu, e.AdrTypAdresu })
                    .HasName("IX_adr__Ewid")
                    .IsUnique();

                entity.HasIndex(e => new { e.AdrNip, e.AdrTypAdresu })
                    .HasName("IX_adr__Ewid_Podmiot");

                entity.Property(e => e.AdrId)
                    .HasColumnName("adr_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdrAdres)
                    .IsRequired()
                    .HasColumnName("adr_Adres")
                    .HasMaxLength(82)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when [adr_NrLokalu]<>'' then ((([adr_Ulica]+' ')+[adr_NrDomu])+'/')+[adr_NrLokalu] else ([adr_Ulica]+' ')+[adr_NrDomu] end)");

                entity.Property(e => e.AdrDataZmiany)
                    .HasColumnName("adr_DataZmiany")
                    .HasColumnType("datetime");

                entity.Property(e => e.AdrFaks)
                    .IsRequired()
                    .HasColumnName("adr_Faks")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrGmina)
                    .IsRequired()
                    .HasColumnName("adr_Gmina")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrIdGminy).HasColumnName("adr_IdGminy");

                entity.Property(e => e.AdrIdObiektu).HasColumnName("adr_IdObiektu");

                entity.Property(e => e.AdrIdPanstwo).HasColumnName("adr_IdPanstwo");

                entity.Property(e => e.AdrIdWersja).HasColumnName("adr_IdWersja");

                entity.Property(e => e.AdrIdWojewodztwo).HasColumnName("adr_IdWojewodztwo");

                entity.Property(e => e.AdrIdZmienil).HasColumnName("adr_IdZmienil");

                entity.Property(e => e.AdrKod)
                    .IsRequired()
                    .HasColumnName("adr_Kod")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrMiejscowosc)
                    .IsRequired()
                    .HasColumnName("adr_Miejscowosc")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrNazwa)
                    .IsRequired()
                    .HasColumnName("adr_Nazwa")
                    .HasMaxLength(51)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrNazwaPelna)
                    .IsRequired()
                    .HasColumnName("adr_NazwaPelna")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrNip)
                    .IsRequired()
                    .HasColumnName("adr_NIP")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrNrDomu)
                    .IsRequired()
                    .HasColumnName("adr_NrDomu")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrNrEori)
                    .IsRequired()
                    .HasColumnName("adr_NrEORI")
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrNrLokalu)
                    .IsRequired()
                    .HasColumnName("adr_NrLokalu")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrNrUrzeduSkarbowego)
                    .HasColumnName("adr_NrUrzeduSkarbowego")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AdrPoczta)
                    .IsRequired()
                    .HasColumnName("adr_Poczta")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrPowiat)
                    .IsRequired()
                    .HasColumnName("adr_Powiat")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrSkrytka)
                    .IsRequired()
                    .HasColumnName("adr_Skrytka")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrSymbol)
                    .IsRequired()
                    .HasColumnName("adr_Symbol")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrTelefon)
                    .IsRequired()
                    .HasColumnName("adr_Telefon")
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdrTypAdresu).HasColumnName("adr_TypAdresu");

                entity.Property(e => e.AdrUlica)
                    .IsRequired()
                    .HasColumnName("adr_Ulica")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
