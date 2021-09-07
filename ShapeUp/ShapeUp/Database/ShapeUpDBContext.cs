using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

//#nullable disable

namespace ShapeUp.Database
{
    public partial class ShapeUpDBContext : DbContext
    {
        public ShapeUpDBContext()
        {
        }

        public ShapeUpDBContext(DbContextOptions<ShapeUpDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cilj> Ciljs { get; set; }
        public virtual DbSet<Formular> Formulars { get; set; }
        public virtual DbSet<KategorijaProizvodum> KategorijaProizvoda { get; set; }
        public virtual DbSet<KategorijaTreninga> KategorijaTreningas { get; set; }
        public virtual DbSet<KlijentProizvodOcjena> KlijentProizvodOcjenas { get; set; }
        public virtual DbSet<Mentorstvo> Mentorstvos { get; set; }
        public virtual DbSet<Napredak> Napredaks { get; set; }
        public virtual DbSet<OdgovoriKlijentum> OdgovoriKlijenta { get; set; }
        public virtual DbSet<Pitanja> Pitanjas { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<PlanPrehrane> PlanPrehranes { get; set; }
        public virtual DbSet<Prijava> Prijavas { get; set; }
        public virtual DbSet<Proizvod> Proizvods { get; set; }
        public virtual DbSet<Recenzija> Recenzijas { get; set; }
        public virtual DbSet<Trening> Trenings { get; set; }
        public virtual DbSet<Uplatum> Uplata { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost, 1434;Initial Catalog=ShapeUpDB; user=sa; Password=SqlServer2021");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Cilj>(entity =>
            {
                entity.ToTable("Cilj");

                entity.Property(e => e.Naziv).HasMaxLength(100);
            });

            modelBuilder.Entity<Formular>(entity =>
            {
                entity.ToTable("Formular");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<KategorijaProizvodum>(entity =>
            {
                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<KategorijaTreninga>(entity =>
            {
                entity.ToTable("KategorijaTreninga");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<KlijentProizvodOcjena>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KlijentProizvodOcjena");

                entity.Property(e => e.Ocjena).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Proizvod)
                    .WithMany()
                    .HasForeignKey(d => d.ProizvodId)
                    .HasConstraintName("Proizvod_Ocjena_FK");
            });

            modelBuilder.Entity<Mentorstvo>(entity =>
            {
                entity.ToTable("Mentorstvo");

                entity.Property(e => e.DatumPocetka).HasColumnType("date");

                entity.Property(e => e.DatumZavrsetka).HasColumnType("date");

                entity.HasOne(d => d.Uplata)
                    .WithMany(p => p.Mentorstvos)
                    .HasForeignKey(d => d.UplataId)
                    .HasConstraintName("Mentorstvo_Uplata_FK");
            });

            modelBuilder.Entity<Napredak>(entity =>
            {
                entity.ToTable("Napredak");
            });

            modelBuilder.Entity<OdgovoriKlijentum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Odgovor).HasMaxLength(450);

                entity.HasOne(d => d.Pitanje)
                    .WithMany()
                    .HasForeignKey(d => d.PitanjeId)
                    .HasConstraintName("OdgKlijenta_Pitanje_FK");
            });

            modelBuilder.Entity<Pitanja>(entity =>
            {
                entity.ToTable("Pitanja");

                entity.Property(e => e.Pitanje).HasMaxLength(450);

                entity.HasOne(d => d.Formular)
                    .WithMany(p => p.Pitanjas)
                    .HasForeignKey(d => d.FormularId)
                    .HasConstraintName("Pitanja_Formular_FK");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("Plan");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.HasOne(d => d.Mentorstvo)
                    .WithMany(p => p.Plans)
                    .HasForeignKey(d => d.MentorstvoId)
                    .HasConstraintName("Plan_Mentorstvo_FK");

                entity.HasOne(d => d.PlanPrehrane)
                    .WithMany(p => p.Plans)
                    .HasForeignKey(d => d.PlanPrehraneId)
                    .HasConstraintName("Plan_PlanPrehrane");

                entity.HasOne(d => d.Trening)
                    .WithMany(p => p.Plans)
                    .HasForeignKey(d => d.TreningId)
                    .HasConstraintName("Plan_Trening_FK");
            });

            modelBuilder.Entity<PlanPrehrane>(entity =>
            {
                entity.ToTable("PlanPrehrane");

                entity.Property(e => e.NutritivneVrijednosti).HasMaxLength(450);

                entity.Property(e => e.Opis).HasMaxLength(450);

                entity.HasOne(d => d.Cilj)
                    .WithMany(p => p.PlanPrehranes)
                    .HasForeignKey(d => d.CiljId)
                    .HasConstraintName("PlanPrehrane_Cilj_FK");
            });

            modelBuilder.Entity<Prijava>(entity =>
            {
                entity.ToTable("Prijava");

                entity.Property(e => e.Datum).HasColumnType("date");
            });

            modelBuilder.Entity<Proizvod>(entity =>
            {
                entity.ToTable("Proizvod");

                entity.Property(e => e.Cijena).HasColumnType("money");

                entity.Property(e => e.Naziv).HasMaxLength(450);

                entity.Property(e => e.Opis).HasMaxLength(450);

                entity.Property(e => e.ProsjecnaOcjena).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.KategorijaProizvoda)
                    .WithMany(p => p.Proizvods)
                    .HasForeignKey(d => d.KategorijaProizvodaId)
                    .HasConstraintName("Proizvod_Kategorija_FK");
            });

            modelBuilder.Entity<Recenzija>(entity =>
            {
                entity.ToTable("Recenzija");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Opis).HasMaxLength(250);

                entity.HasOne(d => d.Mentorstvo)
                    .WithMany(p => p.Recenzijas)
                    .HasForeignKey(d => d.MentorstvoId)
                    .HasConstraintName("Recenzija_Mentorstvo_FK");
            });

            modelBuilder.Entity<Trening>(entity =>
            {
                entity.ToTable("Trening");

                entity.Property(e => e.Opis).HasMaxLength(450);

                entity.Property(e => e.VideoUrl).HasMaxLength(150);

                entity.HasOne(d => d.Cilj)
                    .WithMany(p => p.Trenings)
                    .HasForeignKey(d => d.CiljId)
                    .HasConstraintName("Trening_Cilj_FK");

                entity.HasOne(d => d.KategorijaTreninga)
                    .WithMany(p => p.Trenings)
                    .HasForeignKey(d => d.KategorijaTreningaId)
                    .HasConstraintName("Trening_Kategorija_FK");
            });

            modelBuilder.Entity<Uplatum>(entity =>
            {
                entity.Property(e => e.Datum).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
