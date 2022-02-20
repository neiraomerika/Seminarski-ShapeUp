﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShapeUp.Database;

namespace ShapeUp.Migrations
{
    [DbContext(typeof(ShapeUpDBContext))]
    partial class ShapeUpDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ShapeUp.Database.Cilj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Cilj");
                });

            modelBuilder.Entity("ShapeUp.Database.Formular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Formular");
                });

            modelBuilder.Entity("ShapeUp.Database.KategorijaProizvodum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("KategorijaProizvoda");
                });

            modelBuilder.Entity("ShapeUp.Database.KategorijaTreninga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("KategorijaTreninga");
                });

            modelBuilder.Entity("ShapeUp.Database.KlijentProizvodOcjena", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("KlijentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal?>("Ocjena")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int?>("ProizvodId")
                        .HasColumnType("int");

                    b.HasIndex("KlijentId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("KlijentProizvodOcjena");
                });

            modelBuilder.Entity("ShapeUp.Database.Mentorstvo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPocetka")
                        .HasColumnType("date");

                    b.Property<DateTime>("DatumZavrsetka")
                        .HasColumnType("date");

                    b.Property<string>("NazivKlijenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UplataId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UplataId");

                    b.ToTable("Mentorstvo");
                });

            modelBuilder.Entity("ShapeUp.Database.Models.Klijent", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ShapeUp.Database.Napredak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KlijentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ObimDesneNoge")
                        .HasColumnType("int");

                    b.Property<int?>("ObimDesneRuke")
                        .HasColumnType("int");

                    b.Property<int?>("ObimKukova")
                        .HasColumnType("int");

                    b.Property<int?>("ObimLijeveNoge")
                        .HasColumnType("int");

                    b.Property<int?>("ObimLijeveRuke")
                        .HasColumnType("int");

                    b.Property<int?>("ObimStruka")
                        .HasColumnType("int");

                    b.Property<int?>("Tezina")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KlijentId");

                    b.ToTable("Napredak");
                });

            modelBuilder.Entity("ShapeUp.Database.OdgovoriKlijentum", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("KlijentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Odgovor")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("PitanjeId")
                        .HasColumnType("int");

                    b.HasIndex("KlijentId");

                    b.HasIndex("PitanjeId");

                    b.ToTable("OdgovoriKlijenta");
                });

            modelBuilder.Entity("ShapeUp.Database.Pitanja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FormularId")
                        .HasColumnType("int");

                    b.Property<string>("Pitanje")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FormularId");

                    b.ToTable("Pitanja");
                });

            modelBuilder.Entity("ShapeUp.Database.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("date");

                    b.Property<string>("KlijentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("MentorstvoId")
                        .HasColumnType("int");

                    b.Property<int?>("PlanPrehraneId")
                        .HasColumnType("int");

                    b.Property<int?>("TreningId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KlijentId");

                    b.HasIndex("MentorstvoId");

                    b.HasIndex("PlanPrehraneId");

                    b.HasIndex("TreningId");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("ShapeUp.Database.PlanPrehrane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CiljId")
                        .HasColumnType("int");

                    b.Property<string>("NutritivneVrijednosti")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Opis")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("CiljId");

                    b.ToTable("PlanPrehrane");
                });

            modelBuilder.Entity("ShapeUp.Database.Prijava", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date");

                    b.Property<string>("KlijentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("KlijentId");

                    b.ToTable("Prijava");
                });

            modelBuilder.Entity("ShapeUp.Database.Proizvod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cijena")
                        .HasColumnType("money");

                    b.Property<int>("KategorijaProizvodaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Opis")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("ProsjecnaOcjena")
                        .HasColumnType("decimal(18,0)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategorijaProizvodaId");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("ShapeUp.Database.Recenzija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date");

                    b.Property<int>("MentorstvoId")
                        .HasColumnType("int");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("MentorstvoId");

                    b.ToTable("Recenzija");
                });

            modelBuilder.Entity("ShapeUp.Database.Trening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CiljId")
                        .HasColumnType("int");

                    b.Property<int?>("KategorijaTreningaId")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("VideoUrl")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("CiljId");

                    b.HasIndex("KategorijaTreningaId");

                    b.ToTable("Trening");
                });

            modelBuilder.Entity("ShapeUp.Database.Uplatum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChargeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Datum")
                        .HasColumnType("date");

                    b.Property<decimal>("Iznos")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Placeno")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Uplata");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ShapeUp.Database.Models.Klijent", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ShapeUp.Database.Models.Klijent", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShapeUp.Database.Models.Klijent", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ShapeUp.Database.Models.Klijent", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShapeUp.Database.KlijentProizvodOcjena", b =>
                {
                    b.HasOne("ShapeUp.Database.Models.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentId");

                    b.HasOne("ShapeUp.Database.Proizvod", "Proizvod")
                        .WithMany()
                        .HasForeignKey("ProizvodId")
                        .HasConstraintName("Proizvod_Ocjena_FK");

                    b.Navigation("Klijent");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("ShapeUp.Database.Mentorstvo", b =>
                {
                    b.HasOne("ShapeUp.Database.Uplatum", "Uplata")
                        .WithMany("Mentorstvos")
                        .HasForeignKey("UplataId")
                        .HasConstraintName("Mentorstvo_Uplata_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uplata");
                });

            modelBuilder.Entity("ShapeUp.Database.Napredak", b =>
                {
                    b.HasOne("ShapeUp.Database.Models.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentId");

                    b.Navigation("Klijent");
                });

            modelBuilder.Entity("ShapeUp.Database.OdgovoriKlijentum", b =>
                {
                    b.HasOne("ShapeUp.Database.Models.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentId");

                    b.HasOne("ShapeUp.Database.Pitanja", "Pitanje")
                        .WithMany()
                        .HasForeignKey("PitanjeId")
                        .HasConstraintName("OdgKlijenta_Pitanje_FK");

                    b.Navigation("Klijent");

                    b.Navigation("Pitanje");
                });

            modelBuilder.Entity("ShapeUp.Database.Pitanja", b =>
                {
                    b.HasOne("ShapeUp.Database.Formular", "Formular")
                        .WithMany("Pitanjas")
                        .HasForeignKey("FormularId")
                        .HasConstraintName("Pitanja_Formular_FK");

                    b.Navigation("Formular");
                });

            modelBuilder.Entity("ShapeUp.Database.Plan", b =>
                {
                    b.HasOne("ShapeUp.Database.Models.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentId");

                    b.HasOne("ShapeUp.Database.Mentorstvo", "Mentorstvo")
                        .WithMany("Plans")
                        .HasForeignKey("MentorstvoId")
                        .HasConstraintName("Plan_Mentorstvo_FK");

                    b.HasOne("ShapeUp.Database.PlanPrehrane", "PlanPrehrane")
                        .WithMany("Plans")
                        .HasForeignKey("PlanPrehraneId")
                        .HasConstraintName("Plan_PlanPrehrane");

                    b.HasOne("ShapeUp.Database.Trening", "Trening")
                        .WithMany("Plans")
                        .HasForeignKey("TreningId")
                        .HasConstraintName("Plan_Trening_FK");

                    b.Navigation("Klijent");

                    b.Navigation("Mentorstvo");

                    b.Navigation("PlanPrehrane");

                    b.Navigation("Trening");
                });

            modelBuilder.Entity("ShapeUp.Database.PlanPrehrane", b =>
                {
                    b.HasOne("ShapeUp.Database.Cilj", "Cilj")
                        .WithMany("PlanPrehranes")
                        .HasForeignKey("CiljId")
                        .HasConstraintName("PlanPrehrane_Cilj_FK");

                    b.Navigation("Cilj");
                });

            modelBuilder.Entity("ShapeUp.Database.Prijava", b =>
                {
                    b.HasOne("ShapeUp.Database.Models.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentId");

                    b.Navigation("Klijent");
                });

            modelBuilder.Entity("ShapeUp.Database.Proizvod", b =>
                {
                    b.HasOne("ShapeUp.Database.KategorijaProizvodum", "KategorijaProizvoda")
                        .WithMany("Proizvods")
                        .HasForeignKey("KategorijaProizvodaId")
                        .HasConstraintName("Proizvod_Kategorija_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KategorijaProizvoda");
                });

            modelBuilder.Entity("ShapeUp.Database.Recenzija", b =>
                {
                    b.HasOne("ShapeUp.Database.Mentorstvo", "Mentorstvo")
                        .WithMany("Recenzijas")
                        .HasForeignKey("MentorstvoId")
                        .HasConstraintName("Recenzija_Mentorstvo_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mentorstvo");
                });

            modelBuilder.Entity("ShapeUp.Database.Trening", b =>
                {
                    b.HasOne("ShapeUp.Database.Cilj", "Cilj")
                        .WithMany("Trenings")
                        .HasForeignKey("CiljId")
                        .HasConstraintName("Trening_Cilj_FK");

                    b.HasOne("ShapeUp.Database.KategorijaTreninga", "KategorijaTreninga")
                        .WithMany("Trenings")
                        .HasForeignKey("KategorijaTreningaId")
                        .HasConstraintName("Trening_Kategorija_FK");

                    b.Navigation("Cilj");

                    b.Navigation("KategorijaTreninga");
                });

            modelBuilder.Entity("ShapeUp.Database.Cilj", b =>
                {
                    b.Navigation("PlanPrehranes");

                    b.Navigation("Trenings");
                });

            modelBuilder.Entity("ShapeUp.Database.Formular", b =>
                {
                    b.Navigation("Pitanjas");
                });

            modelBuilder.Entity("ShapeUp.Database.KategorijaProizvodum", b =>
                {
                    b.Navigation("Proizvods");
                });

            modelBuilder.Entity("ShapeUp.Database.KategorijaTreninga", b =>
                {
                    b.Navigation("Trenings");
                });

            modelBuilder.Entity("ShapeUp.Database.Mentorstvo", b =>
                {
                    b.Navigation("Plans");

                    b.Navigation("Recenzijas");
                });

            modelBuilder.Entity("ShapeUp.Database.PlanPrehrane", b =>
                {
                    b.Navigation("Plans");
                });

            modelBuilder.Entity("ShapeUp.Database.Trening", b =>
                {
                    b.Navigation("Plans");
                });

            modelBuilder.Entity("ShapeUp.Database.Uplatum", b =>
                {
                    b.Navigation("Mentorstvos");
                });
#pragma warning restore 612, 618
        }
    }
}
