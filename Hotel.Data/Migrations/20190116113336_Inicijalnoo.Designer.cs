﻿// <auto-generated />
using Hotel.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Hotel.Data.Migrations
{
    [DbContext(typeof(MojContext))]
    [Migration("20190116113336_Inicijalnoo")]
    partial class Inicijalnoo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hotel.Data.Models.DodatneUsluge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Cijena");

                    b.Property<string>("Naziv")
                        .IsRequired();

                    b.Property<string>("Opis")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("DodatneUsluge");
                });

            modelBuilder.Entity("Hotel.Data.Models.DodatneUslugeRezervacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumVrijeme");

                    b.Property<int>("DodatneUslugeID");

                    b.Property<int>("RezervacijaID");

                    b.Property<float>("Trajanje");

                    b.HasKey("Id");

                    b.HasIndex("DodatneUslugeID");

                    b.HasIndex("RezervacijaID");

                    b.ToTable("DodatneUslugeRezervacija");
                });

            modelBuilder.Entity("Hotel.Data.Models.Dogadjaj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Cijena");

                    b.Property<DateTime>("Kraj");

                    b.Property<string>("Naziv")
                        .IsRequired();

                    b.Property<string>("Opis")
                        .IsRequired();

                    b.Property<DateTime>("Pocetak");

                    b.Property<int>("TipDogadjajaID");

                    b.HasKey("Id");

                    b.HasIndex("TipDogadjajaID");

                    b.ToTable("Dogadjaj");
                });

            modelBuilder.Entity("Hotel.Data.Models.Drzava", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("Hotel.Data.Models.Firma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojRacuna");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Firma");
                });

            modelBuilder.Entity("Hotel.Data.Models.Gost", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojTelefona");

                    b.Property<int?>("FirmaID");

                    b.Property<int>("GradID");

                    b.Property<string>("Ime");

                    b.Property<int>("NalogID");

                    b.Property<string>("Prezime");

                    b.Property<string>("Spol");

                    b.HasKey("id");

                    b.HasIndex("FirmaID");

                    b.HasIndex("GradID");

                    b.HasIndex("NalogID");

                    b.ToTable("Gost");
                });

            modelBuilder.Entity("Hotel.Data.Models.Grad", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DrzavaID");

                    b.Property<string>("Naziv")
                        .IsRequired();

                    b.HasKey("id");

                    b.HasIndex("DrzavaID");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("Hotel.Data.Models.Jelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Cijena");

                    b.Property<string>("Naziv")
                        .IsRequired();

                    b.Property<string>("Opis")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Jelo");
                });

            modelBuilder.Entity("Hotel.Data.Models.KorisnickiNalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsAdministrator");

                    b.Property<bool>("IsKlijent");

                    b.Property<bool>("IsUposlenik");

                    b.Property<string>("KorisnickoIme");

                    b.Property<string>("Lozinka");

                    b.HasKey("Id");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("Hotel.Data.Models.Plata", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Iznos");

                    b.Property<int>("ZaposlenikID");

                    b.Property<DateTime>("datum");

                    b.Property<int>("godina");

                    b.Property<int>("mjesec");

                    b.HasKey("id");

                    b.HasIndex("ZaposlenikID");

                    b.ToTable("Plata");
                });

            modelBuilder.Entity("Hotel.Data.Models.Rezervacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Aktivna");

                    b.Property<DateTime>("DatumDolaska");

                    b.Property<DateTime>("DatumOdlska");

                    b.Property<int>("GostID");

                    b.Property<int>("_ZaposlenikId");

                    b.Property<DateTime>("datumRezervacije");

                    b.HasKey("Id");

                    b.HasIndex("GostID");

                    b.HasIndex("_ZaposlenikId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("Hotel.Data.Models.RezervacijaDogadjaj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("dogadjajID");

                    b.Property<int>("rezervacijaID");

                    b.HasKey("Id");

                    b.HasIndex("dogadjajID");

                    b.HasIndex("rezervacijaID");

                    b.ToTable("RezervacijaDogadjaj");
                });

            modelBuilder.Entity("Hotel.Data.Models.RezervacijaJela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRezervacije");

                    b.Property<int>("RezervacijaID");

                    b.HasKey("Id");

                    b.HasIndex("RezervacijaID");

                    b.ToTable("RezervacijaJela");
                });

            modelBuilder.Entity("Hotel.Data.Models.RezervisanaSoba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RezervacijaID");

                    b.Property<int>("SobaID");

                    b.Property<bool>("pusenje");

                    b.HasKey("Id");

                    b.HasIndex("RezervacijaID");

                    b.HasIndex("SobaID");

                    b.ToTable("RezervisanaSoba");
                });

            modelBuilder.Entity("Hotel.Data.Models.SmjeteniGosti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojPasosa");

                    b.Property<int>("GostID");

                    b.Property<int>("RezervisanaSobaID");

                    b.HasKey("Id");

                    b.HasIndex("GostID");

                    b.HasIndex("RezervisanaSobaID");

                    b.ToTable("SmjeteniGosti");
                });

            modelBuilder.Entity("Hotel.Data.Models.Soba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Cijena");

                    b.Property<bool>("Dostupna");

                    b.Property<string>("Naziv")
                        .IsRequired();

                    b.Property<int>("Sprat");

                    b.Property<int>("TipSobeID");

                    b.HasKey("Id");

                    b.HasIndex("TipSobeID");

                    b.ToTable("Soba");
                });

            modelBuilder.Entity("Hotel.Data.Models.StavkeRezervacijeJela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("JeloID");

                    b.Property<int>("Kolicina");

                    b.Property<int>("RezervacijaJelaID");

                    b.HasKey("Id");

                    b.HasIndex("JeloID");

                    b.HasIndex("RezervacijaJelaID");

                    b.ToTable("StavkeRezervacijeJela");
                });

            modelBuilder.Entity("Hotel.Data.Models.TipDogadjaja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("TipDogadjaja");
                });

            modelBuilder.Entity("Hotel.Data.Models.TipSobe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("TipSobe");
                });

            modelBuilder.Entity("Hotel.Data.Models.TipUplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("naziv");

                    b.HasKey("Id");

                    b.ToTable("TipUplate");
                });

            modelBuilder.Entity("Hotel.Data.Models.TipZaposlenika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("TipZaposlenika");
                });

            modelBuilder.Entity("Hotel.Data.Models.Uplata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum");

                    b.Property<int?>("FirmaID");

                    b.Property<double>("Iznos");

                    b.Property<int>("RezervacijaID");

                    b.Property<int>("TipUplateId");

                    b.Property<int>("ZaposlenikID");

                    b.HasKey("Id");

                    b.HasIndex("FirmaID");

                    b.HasIndex("RezervacijaID");

                    b.HasIndex("TipUplateId");

                    b.HasIndex("ZaposlenikID");

                    b.ToTable("Uplata");
                });

            modelBuilder.Entity("Hotel.Data.Models.Zaposlenik", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojTelefona")
                        .IsRequired();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<DateTime>("DatumZaposelenja");

                    b.Property<string>("Email");

                    b.Property<int>("GradID");

                    b.Property<string>("Ime")
                        .IsRequired();

                    b.Property<string>("JMBG")
                        .IsRequired();

                    b.Property<int>("NalogID");

                    b.Property<string>("Prezime")
                        .IsRequired();

                    b.Property<double?>("TekuciRacun");

                    b.Property<int>("TipUposlenikaID");

                    b.HasKey("id");

                    b.HasIndex("GradID");

                    b.HasIndex("NalogID");

                    b.HasIndex("TipUposlenikaID");

                    b.ToTable("Zaposlenik");
                });

            modelBuilder.Entity("Hotel.Data.Models.DodatneUslugeRezervacija", b =>
                {
                    b.HasOne("Hotel.Data.Models.DodatneUsluge", "DodatneUsluge")
                        .WithMany()
                        .HasForeignKey("DodatneUslugeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Data.Models.Rezervacija", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("RezervacijaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Data.Models.Dogadjaj", b =>
                {
                    b.HasOne("Hotel.Data.Models.TipDogadjaja", "TipDogadjaja")
                        .WithMany()
                        .HasForeignKey("TipDogadjajaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Data.Models.Gost", b =>
                {
                    b.HasOne("Hotel.Data.Models.Firma", "Firma")
                        .WithMany()
                        .HasForeignKey("FirmaID");

                    b.HasOne("Hotel.Data.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Data.Models.KorisnickiNalog", "Nalog")
                        .WithMany()
                        .HasForeignKey("NalogID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Data.Models.Grad", b =>
                {
                    b.HasOne("Hotel.Data.Models.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Data.Models.Plata", b =>
                {
                    b.HasOne("Hotel.Data.Models.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Data.Models.Rezervacija", b =>
                {
                    b.HasOne("Hotel.Data.Models.Gost", "Gost")
                        .WithMany()
                        .HasForeignKey("GostID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Hotel.Data.Models.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("_ZaposlenikId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Hotel.Data.Models.RezervacijaDogadjaj", b =>
                {
                    b.HasOne("Hotel.Data.Models.Dogadjaj", "dogadjaj")
                        .WithMany()
                        .HasForeignKey("dogadjajID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Data.Models.Rezervacija", "rezervacija")
                        .WithMany()
                        .HasForeignKey("rezervacijaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Data.Models.RezervacijaJela", b =>
                {
                    b.HasOne("Hotel.Data.Models.Rezervacija", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("RezervacijaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Data.Models.RezervisanaSoba", b =>
                {
                    b.HasOne("Hotel.Data.Models.Rezervacija", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("RezervacijaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Data.Models.Soba", "Soba")
                        .WithMany()
                        .HasForeignKey("SobaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Data.Models.SmjeteniGosti", b =>
                {
                    b.HasOne("Hotel.Data.Models.Gost", "Gost")
                        .WithMany()
                        .HasForeignKey("GostID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Data.Models.RezervisanaSoba", "RezervisanaSoba")
                        .WithMany()
                        .HasForeignKey("RezervisanaSobaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Data.Models.Soba", b =>
                {
                    b.HasOne("Hotel.Data.Models.TipSobe", "TipSobe")
                        .WithMany()
                        .HasForeignKey("TipSobeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Data.Models.StavkeRezervacijeJela", b =>
                {
                    b.HasOne("Hotel.Data.Models.Jelo", "Jelo")
                        .WithMany()
                        .HasForeignKey("JeloID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Data.Models.RezervacijaJela", "RezervacijaJela")
                        .WithMany()
                        .HasForeignKey("RezervacijaJelaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Data.Models.Uplata", b =>
                {
                    b.HasOne("Hotel.Data.Models.Firma", "Firma")
                        .WithMany()
                        .HasForeignKey("FirmaID");

                    b.HasOne("Hotel.Data.Models.Rezervacija", "Rezervacija")
                        .WithMany()
                        .HasForeignKey("RezervacijaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Data.Models.TipUplate", "TipUplate")
                        .WithMany()
                        .HasForeignKey("TipUplateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Data.Models.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Hotel.Data.Models.Zaposlenik", b =>
                {
                    b.HasOne("Hotel.Data.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Data.Models.KorisnickiNalog", "Nalog")
                        .WithMany()
                        .HasForeignKey("NalogID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Hotel.Data.Models.TipZaposlenika", "TipUposlenika")
                        .WithMany()
                        .HasForeignKey("TipUposlenikaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
