using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace eBus.WebAPI.Database
{
    public partial class eBusContext : DbContext
    {
        public eBusContext()
        {
        }

        public eBusContext(DbContextOptions<eBusContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autobu> Autobus { get; set; }
     
        public virtual DbSet<Drzava> Drzavas { get; set; }
        public virtual DbSet<Gradovi> Gradovis { get; set; }
        public virtual DbSet<Kartum> Karta { get; set; }
        public virtual DbSet<Korisnici> Korisnicis { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloges { get; set; }
        public virtual DbSet<Notifikacije> Notifikacijes { get; set; }
        public virtual DbSet<Novosti> Novostis { get; set; }
        public virtual DbSet<Ocjena> Ocjenas { get; set; }
        public virtual DbSet<Putnik> Putniks { get; set; }
        public virtual DbSet<PutnikNotifikacije> PutnikNotifikacijes { get; set; }
        public virtual DbSet<RedVoznje> RedVoznjes { get; set; }
        public virtual DbSet<RezervacijaKarte> RezervacijaKartes { get; set; }
        public virtual DbSet<RezervacijaSjedistum> RezervacijaSjedista { get; set; }
        public virtual DbSet<Uloga> Ulogas { get; set; }
        public virtual DbSet<Vozac> Vozacs { get; set; }
        public virtual DbSet<VrstaKarte> VrstaKartes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=eBus;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN");

            modelBuilder.Entity<Autobu>(entity =>
            {
                entity.HasKey(e => e.AutobusId)
                    .HasName("PK_AutobusID");

                entity.Property(e => e.AutobusId).HasColumnName("AutobusID");

                entity.Property(e => e.Klasa).HasMaxLength(20);

                entity.Property(e => e.NazivAutobusa).HasMaxLength(20);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.VozacId).HasColumnName("VozacID");

                entity.HasOne(d => d.Vozac)
                    .WithMany(p => p.Autobus)
                    .HasForeignKey(d => d.VozacId)
                    .HasConstraintName("FK_VozacID");
            });

            //modelBuilder.Entity<Cijena>(entity =>
            //{
            //    entity.ToTable("Cijena");

            //    entity.Property(e => e.CijenaId).HasColumnName("CijenaID");

            //    entity.Property(e => e.Iznos).HasColumnType("decimal(18, 0)");

            //    entity.Property(e => e.Popust).HasColumnType("decimal(18, 0)");

            //    entity.Property(e => e.RedVoznjeId).HasColumnName("RedVoznjeID");

            //    entity.HasOne(d => d.RedVoznje)
            //        .WithMany(p => p.Cijenas)
            //        .HasForeignKey(d => d.RedVoznjeId)
            //        .HasConstraintName("FK_RedVoznjeID");
            //});

            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.ToTable("Drzava");

                entity.Property(e => e.DrzavaId)
                    .ValueGeneratedNever()
                    .HasColumnName("DrzavaID");

                entity.Property(e => e.NazivDrzave).HasMaxLength(30);
            });

            modelBuilder.Entity<Gradovi>(entity =>
            {
                entity.HasKey(e => e.GradId)
                    .HasName("PK_GradiID");

                entity.ToTable("Gradovi");

                entity.Property(e => e.GradId)
                    .ValueGeneratedNever()
                    .HasColumnName("GradID");

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.NazivGrada).HasMaxLength(30);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Gradovis)
                    .HasForeignKey(d => d.DrzavaId)
                    .HasConstraintName("FK_DrzavaID");
            });

            modelBuilder.Entity<Kartum>(entity =>
            {
                entity.HasKey(e => e.KartaId)
                    .HasName("PK_KartaID");

                entity.Property(e => e.KartaId).HasColumnName("KartaID");

                entity.Property(e => e.BrojKarte).HasMaxLength(10);

                entity.Property(e => e.DatumIzdavanja).HasColumnType("datetime");

                entity.Property(e => e.RezervacijaSjedistaId).HasColumnName("RezervacijaSjedistaID");

                entity.Property(e => e.VrijemeDolaska).HasColumnType("datetime");

                entity.Property(e => e.VrijemePolaska).HasColumnType("datetime");

                entity.HasOne(d => d.RezervacijaSjedista)
                    .WithMany(p => p.Karta)
                    .HasForeignKey(d => d.RezervacijaSjedistaId)
                    .HasConstraintName("FK_RezervacijaSjedistaID");
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.HasKey(e => e.KorisnikId)
                    .HasName("PK_KorisnikID");

                entity.ToTable("Korisnici");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime).HasMaxLength(20);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(30);

                entity.Property(e => e.LozinkaHash).HasMaxLength(30);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(30);

                entity.Property(e => e.Prezime).HasMaxLength(30);
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.ToTable("KorisniciUloge");

                entity.Property(e => e.KorisniciUlogeId).HasColumnName("KorisniciUlogeID");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloges)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_Korisnik5Id");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloges)
                    .HasForeignKey(d => d.UlogaId)
                    .HasConstraintName("FK_UlogaId");
            });

            modelBuilder.Entity<Notifikacije>(entity =>
            {
                entity.ToTable("Notifikacije");

                entity.Property(e => e.NotifikacijeId).HasColumnName("NotifikacijeID");

                entity.Property(e => e.DatumSlanja).HasColumnType("datetime");

                entity.Property(e => e.Naslov).HasMaxLength(20);

                entity.Property(e => e.NovostiId).HasColumnName("NovostiID");

                entity.HasOne(d => d.Novosti)
                    .WithMany(p => p.Notifikacijes)
                    .HasForeignKey(d => d.NovostiId)
                    .HasConstraintName("FK_Korisnik3ID");
            });

            modelBuilder.Entity<Novosti>(entity =>
            {
                entity.ToTable("Novosti");

                entity.Property(e => e.NovostiId).HasColumnName("NovostiID");

                entity.Property(e => e.DatumObjave).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Naslov).HasMaxLength(20);

                entity.Property(e => e.Sadrzaj).HasMaxLength(50);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Novostis)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_Korisnik2ID");
            });

            modelBuilder.Entity<Ocjena>(entity =>
            {
                entity.ToTable("Ocjena");

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.Komentar).HasMaxLength(50);

                entity.Property(e => e.Ocjena1).HasColumnName("Ocjena");

                entity.Property(e => e.PutnikId).HasColumnName("PutnikID");

                entity.Property(e => e.RedVoznjeId).HasColumnName("RedVoznjeID");

                entity.HasOne(d => d.Putnik)
                    .WithMany(p => p.Ocjenas)
                    .HasForeignKey(d => d.PutnikId)
                    .HasConstraintName("FK_Putnik3ID");

                entity.HasOne(d => d.RedVoznje)
                    .WithMany(p => p.Ocjenas)
                    .HasForeignKey(d => d.RedVoznjeId)
                    .HasConstraintName("FK_RedVoznje1ID");
            });

            modelBuilder.Entity<Putnik>(entity =>
            {
                entity.ToTable("Putnik");

                entity.Property(e => e.PutnikId).HasColumnName("PutnikID");

                entity.Property(e => e.DatumRegistracije).HasColumnType("date");

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Ime).HasMaxLength(20);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(30);

                entity.Property(e => e.LozinkaHash).HasMaxLength(30);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(30);

                entity.Property(e => e.Prezime).HasMaxLength(30);
            });

            modelBuilder.Entity<PutnikNotifikacije>(entity =>
            {
                entity.ToTable("PutnikNotifikacije");

                entity.Property(e => e.PutnikNotifikacijeId).HasColumnName("PutnikNotifikacijeID");

                entity.Property(e => e.NotifikacijeId).HasColumnName("NotifikacijeID");

                entity.Property(e => e.PutnikId).HasColumnName("PutnikID");

                entity.HasOne(d => d.Notifikacije)
                    .WithMany(p => p.PutnikNotifikacijes)
                    .HasForeignKey(d => d.NotifikacijeId)
                    .HasConstraintName("FK_NotifikacijeID");

                entity.HasOne(d => d.Putnik)
                    .WithMany(p => p.PutnikNotifikacijes)
                    .HasForeignKey(d => d.PutnikId)
                    .HasConstraintName("FK_Putnik2ID");
            });

            modelBuilder.Entity<RedVoznje>(entity =>
            {
                entity.ToTable("RedVoznje");

                entity.Property(e => e.RedVoznjeId).HasColumnName("RedVoznjeID");

                entity.Property(e => e.AutobusId).HasColumnName("AutobusID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DatumVrijemeDolaska).HasColumnType("datetime");

                entity.Property(e => e.DatumVrijemePolaska).HasColumnType("datetime");


                entity.Property(e => e.GradDolaskaId).HasColumnName("GradDolaskaID");


                entity.Property(e => e.GradPolaskaId).HasColumnName("GradPolaskaID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Naziv).HasMaxLength(20);

                entity.HasOne(d => d.Autobus)
                    .WithMany(p => p.RedVoznjes)
                    .HasForeignKey(d => d.AutobusId)
                    .HasConstraintName("FK_Autobus1ID");

                entity.HasOne(d => d.GradDolaskaNavigation)
                    .WithMany(p => p.RedVoznjeGradDolaskaNavigations)
                    .HasForeignKey(d => d.GradDolaskaId)
                    .HasConstraintName("FK_GradDolaskaID");

                entity.HasOne(d => d.GradPolaskaNavigation)
                    .WithMany(p => p.RedVoznjeGradPolaskaNavigations)
                    .HasForeignKey(d => d.GradPolaskaId)
                    .HasConstraintName("FK_GradPolaskaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.RedVoznjes)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK_Korisnik1ID");
            });

            modelBuilder.Entity<RezervacijaKarte>(entity =>
            {
                entity.ToTable("RezervacijaKarte");

                entity.Property(e => e.RezervacijaKarteId).HasColumnName("RezervacijaKarteID");

                entity.Property(e => e.DatumIsteka).HasColumnType("datetime");

                entity.Property(e => e.DatumKreiranja).HasColumnType("datetime");

                entity.Property(e => e.KartaId).HasColumnName("KartaID");

                entity.Property(e => e.PutnikId).HasColumnName("PutnikID");

                entity.Property(e => e.Qrcode).HasMaxLength(50);

                entity.HasOne(d => d.Karta)
                    .WithMany(p => p.RezervacijaKartes)
                    .HasForeignKey(d => d.KartaId)
                    .HasConstraintName("FK_VrstaKarteID");

                entity.HasOne(d => d.Putnik)
                    .WithMany(p => p.RezervacijaKartes)
                    .HasForeignKey(d => d.PutnikId)
                    .HasConstraintName("FK_Putnik1ID");
            });

            modelBuilder.Entity<RezervacijaSjedistum>(entity =>
            {
                entity.HasKey(e => e.RezervacijaSjedistaId)
                    .HasName("PK_RezervacijaSjedistaID");

                entity.Property(e => e.RezervacijaSjedistaId).HasColumnName("RezervacijaSjedistaID");

                entity.Property(e => e.AutobusId).HasColumnName("AutobusID");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Autobus)
                    .WithMany(p => p.RezervacijaSjedista)
                    .HasForeignKey(d => d.AutobusId)
                    .HasConstraintName("FK_AutobusID");
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.ToTable("Uloga");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv).HasMaxLength(30);
            });

            modelBuilder.Entity<Vozac>(entity =>
            {
                entity.ToTable("Vozac");

                entity.Property(e => e.VozacId).HasColumnName("VozacID");

                entity.Property(e => e.Ime).HasMaxLength(20);

                entity.Property(e => e.Prezime).HasMaxLength(20);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Vozacka).HasMaxLength(5);
            });

            modelBuilder.Entity<VrstaKarte>(entity =>
            {
                entity.ToTable("VrstaKarte");

                entity.Property(e => e.VrstaKarteId).HasColumnName("VrstaKarteID");

                entity.Property(e => e.VrstaKarte1)
                    .HasMaxLength(15)
                    .HasColumnName("VrstaKarte");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
