﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Something;

namespace Something.Migrations
{
    [DbContext(typeof(SubiektContext))]
    partial class SubiektContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Something.Rabat", b =>
                {
                    b.Property<int>("rt_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("rt_Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("rt_Procent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("rt_Rodzaj")
                        .HasColumnType("int");

                    b.HasKey("rt_id");

                    b.ToTable("sl_Rabat");
                });

            modelBuilder.Entity("Something.Towar", b =>
                {
                    b.Property<int>("tw_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Rabatrt_id")
                        .HasColumnType("int");

                    b.Property<int>("rt_id")
                        .HasColumnType("int");

                    b.Property<int>("tw_Akcyza")
                        .HasColumnType("int");

                    b.Property<decimal>("tw_AkcyzaKwota")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("tw_AkcyzaMarkaWyrobow")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_AkcyzaWielkoscProducenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tw_AkcyzaZaznacz")
                        .HasColumnType("int");

                    b.Property<int>("tw_CenaOtwarta")
                        .HasColumnType("int");

                    b.Property<string>("tw_Charakter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tw_CzasDostawy")
                        .HasColumnType("int");

                    b.Property<DateTime>("tw_DataZmianyVatSprzedazy")
                        .HasColumnType("datetime2");

                    b.Property<int>("tw_DniWaznosc")
                        .HasColumnType("int");

                    b.Property<int>("tw_DodawalnyDoZW")
                        .HasColumnType("int");

                    b.Property<int>("tw_DomyslnaKategoria")
                        .HasColumnType("int");

                    b.Property<string>("tw_DostSymbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("tw_Glebokosc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("tw_GrupaJpkVat")
                        .HasColumnType("int");

                    b.Property<int>("tw_IdFundPromocji")
                        .HasColumnType("int");

                    b.Property<int>("tw_IdGrupa")
                        .HasColumnType("int");

                    b.Property<int>("tw_IdKoduWyrobuAkcyzowego")
                        .HasColumnType("int");

                    b.Property<int>("tw_IdKrajuPochodzenia")
                        .HasColumnType("int");

                    b.Property<int>("tw_IdOpakowanie")
                        .HasColumnType("int");

                    b.Property<int>("tw_IdPodstDostawca")
                        .HasColumnType("int");

                    b.Property<int>("tw_IdProducenta")
                        .HasColumnType("int");

                    b.Property<int>("tw_IdRabat")
                        .HasColumnType("int");

                    b.Property<int>("tw_IdTypKodu")
                        .HasColumnType("int");

                    b.Property<int>("tw_IdUJM")
                        .HasColumnType("int");

                    b.Property<int>("tw_IdVatSp")
                        .HasColumnType("int");

                    b.Property<int>("tw_IdVatZak")
                        .HasColumnType("int");

                    b.Property<int>("tw_IsFundPromocji")
                        .HasColumnType("int");

                    b.Property<int>("tw_JMSprzInna")
                        .HasColumnType("int");

                    b.Property<int>("tw_JMZakInna")
                        .HasColumnType("int");

                    b.Property<int>("tw_JakPrzySp")
                        .HasColumnType("int");

                    b.Property<string>("tw_JednMiary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_JednMiarySprz")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_JednMiaryZak")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_JednStanMin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_KodTowaru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_KodUProducenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_Komunikat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tw_KomunikatDokumenty")
                        .HasColumnType("int");

                    b.Property<DateTime>("tw_KomunikatOd")
                        .HasColumnType("datetime2");

                    b.Property<int>("tw_KontrolaTW")
                        .HasColumnType("int");

                    b.Property<int>("tw_Logo")
                        .HasColumnType("int");

                    b.Property<decimal>("tw_Masa")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("tw_MasaNetto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("tw_MechanizmPodzielonejPlatnosci")
                        .HasColumnType("int");

                    b.Property<string>("tw_Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("tw_Objetosc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("tw_ObrotMarza")
                        .HasColumnType("int");

                    b.Property<int>("tw_OdwrotneObciazenie")
                        .HasColumnType("int");

                    b.Property<string>("tw_Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tw_OplCukrowaInneSlodzace")
                        .HasColumnType("int");

                    b.Property<decimal>("tw_OplCukrowaKofeinaKwota")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("tw_OplCukrowaKofeinaPodlega")
                        .HasColumnType("int");

                    b.Property<decimal>("tw_OplCukrowaKwota")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("tw_OplCukrowaKwotaPowyzej")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("tw_OplCukrowaNapojWeglElektr")
                        .HasColumnType("int");

                    b.Property<decimal>("tw_OplCukrowaObj")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("tw_OplCukrowaPodlega")
                        .HasColumnType("int");

                    b.Property<int>("tw_OplCukrowaSok")
                        .HasColumnType("int");

                    b.Property<decimal>("tw_OplCukrowaZawartoscCukru")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("tw_PKWiU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tw_PLU")
                        .HasColumnType("int");

                    b.Property<string>("tw_PodstKodKresk")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_Pole1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_Pole2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_Pole3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_Pole4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_Pole5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_Pole6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_Pole7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_Pole8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tw_ProgKwotowyOO")
                        .HasColumnType("int");

                    b.Property<int>("tw_PrzezWartosc")
                        .HasColumnType("int");

                    b.Property<int>("tw_Rodzaj")
                        .HasColumnType("int");

                    b.Property<string>("tw_SWW")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tw_SerwisAukcyjny")
                        .HasColumnType("int");

                    b.Property<int>("tw_SklepInternet")
                        .HasColumnType("int");

                    b.Property<int>("tw_SprzedazMobilna")
                        .HasColumnType("int");

                    b.Property<decimal>("tw_StanMaks")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("tw_StanMin")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("tw_Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("tw_Szerokosc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("tw_UrzNazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tw_Usuniety")
                        .HasColumnType("int");

                    b.Property<string>("tw_Uwagi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_WWW")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tw_WagaEtykiet")
                        .HasColumnType("int");

                    b.Property<string>("tw_WegielOpisPochodzenia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tw_WegielPodlegaOswiadczeniu")
                        .HasColumnType("int");

                    b.Property<decimal>("tw_Wysokosc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("tw_Zablokowany")
                        .HasColumnType("int");

                    b.Property<int>("tw_ZnakiAkcyzy")
                        .HasColumnType("int");

                    b.Property<string>("tw_bloz_12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_bloz_7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tw_isbn")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tw_Id");

                    b.HasIndex("Rabatrt_id");

                    b.ToTable("tw_Towar");
                });

            modelBuilder.Entity("Something.Towar", b =>
                {
                    b.HasOne("Something.Rabat", "Rabat")
                        .WithMany("tw_Towar")
                        .HasForeignKey("Rabatrt_id");
                });
#pragma warning restore 612, 618
        }
    }
}