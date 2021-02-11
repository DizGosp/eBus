using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eBus.WebAPI.Migrations
{
    public partial class DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(type: "int", nullable: false),
                    NazivDrzave = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LozinkaHash = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikID", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "Putnik",
                columns: table => new
                {
                    PutnikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LozinkaHash = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DatumRegistracije = table.Column<DateTime>(type: "date", nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Putnik", x => x.PutnikID);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaID);
                });

            migrationBuilder.CreateTable(
                name: "Vozac",
                columns: table => new
                {
                    VozacID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Vozacka = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozac", x => x.VozacID);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradID = table.Column<int>(type: "int", nullable: false),
                    NazivGrada = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    DrzavaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradiID", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Novosti",
                columns: table => new
                {
                    NovostiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Sadrzaj = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DatumObjave = table.Column<DateTime>(type: "datetime", nullable: true),
                    BrojPregleda = table.Column<int>(type: "int", nullable: true),
                    KorisnikID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novosti", x => x.NovostiID);
                    table.ForeignKey(
                        name: "FK_Korisnik2ID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisniciUlogeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikId = table.Column<int>(type: "int", nullable: true),
                    UlogaId = table.Column<int>(type: "int", nullable: true),
                    DatumIzmjene = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.KorisniciUlogeID);
                    table.ForeignKey(
                        name: "FK_Korisnik5Id",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UlogaId",
                        column: x => x.UlogaId,
                        principalTable: "Uloga",
                        principalColumn: "UlogaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Autobus",
                columns: table => new
                {
                    AutobusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VozacID = table.Column<int>(type: "int", nullable: true),
                    NazivAutobusa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Klasa = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutobusID", x => x.AutobusID);
                    table.ForeignKey(
                        name: "FK_VozacID",
                        column: x => x.VozacID,
                        principalTable: "Vozac",
                        principalColumn: "VozacID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifikacije",
                columns: table => new
                {
                    NotifikacijeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DatumSlanja = table.Column<DateTime>(type: "datetime", nullable: true),
                    Procitano = table.Column<bool>(type: "bit", nullable: true),
                    NovostiID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacije", x => x.NotifikacijeID);
                    table.ForeignKey(
                        name: "FK_Korisnik3ID",
                        column: x => x.NovostiID,
                        principalTable: "Novosti",
                        principalColumn: "NovostiID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RedVoznje",
                columns: table => new
                {
                    RedVoznjeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DatumVrijemePolaska = table.Column<DateTime>(type: "datetime", nullable: true),
                    DatumVrijemeDolaska = table.Column<DateTime>(type: "datetime", nullable: true),
                    Cijena = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    AutobusID = table.Column<int>(type: "int", nullable: true),
                    GradPolaskaID = table.Column<int>(type: "int", nullable: true),
                    GradDolaskaID = table.Column<int>(type: "int", nullable: true),
                    KorisnikID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedVoznje", x => x.RedVoznjeID);
                    table.ForeignKey(
                        name: "FK_Autobus1ID",
                        column: x => x.AutobusID,
                        principalTable: "Autobus",
                        principalColumn: "AutobusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GradDolaskaID",
                        column: x => x.GradDolaskaID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GradPolaskaID",
                        column: x => x.GradPolaskaID,
                        principalTable: "Gradovi",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Korisnik1ID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RezervacijaSjedista",
                columns: table => new
                {
                    RezervacijaSjedistaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutobusID = table.Column<int>(type: "int", nullable: true),
                    Red = table.Column<int>(type: "int", nullable: true),
                    Kolona = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervacijaSjedistaID", x => x.RezervacijaSjedistaID);
                    table.ForeignKey(
                        name: "FK_AutobusID",
                        column: x => x.AutobusID,
                        principalTable: "Autobus",
                        principalColumn: "AutobusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PutnikNotifikacije",
                columns: table => new
                {
                    PutnikNotifikacijeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Procitano = table.Column<bool>(type: "bit", nullable: true),
                    NotifikacijeID = table.Column<int>(type: "int", nullable: true),
                    PutnikID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PutnikNotifikacije", x => x.PutnikNotifikacijeID);
                    table.ForeignKey(
                        name: "FK_NotifikacijeID",
                        column: x => x.NotifikacijeID,
                        principalTable: "Notifikacije",
                        principalColumn: "NotifikacijeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Putnik2ID",
                        column: x => x.PutnikID,
                        principalTable: "Putnik",
                        principalColumn: "PutnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ocjena",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PutnikID = table.Column<int>(type: "int", nullable: true),
                    RedVoznjeID = table.Column<int>(type: "int", nullable: true),
                    Ocjena = table.Column<int>(type: "int", nullable: true),
                    Komentar = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjena", x => x.OcjenaID);
                    table.ForeignKey(
                        name: "FK_Putnik3ID",
                        column: x => x.PutnikID,
                        principalTable: "Putnik",
                        principalColumn: "PutnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RedVoznje1ID",
                        column: x => x.RedVoznjeID,
                        principalTable: "RedVoznje",
                        principalColumn: "RedVoznjeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Karta",
                columns: table => new
                {
                    KartaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezervacijaSjedistaID = table.Column<int>(type: "int", nullable: true),
                    BrojKarte = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DatumIzdavanja = table.Column<DateTime>(type: "datetime", nullable: true),
                    VrijemePolaska = table.Column<DateTime>(type: "datetime", nullable: true),
                    VrijemeDolaska = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KartaID", x => x.KartaID);
                    table.ForeignKey(
                        name: "FK_RezervacijaSjedistaID",
                        column: x => x.RezervacijaSjedistaID,
                        principalTable: "RezervacijaSjedista",
                        principalColumn: "RezervacijaSjedistaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VrstaKarte",
                columns: table => new
                {
                    VrstaKarteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VrstaKarte = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    KartumKartaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaKarte", x => x.VrstaKarteID);
                    table.ForeignKey(
                        name: "FK_VrstaKarte_Karta_KartumKartaId",
                        column: x => x.KartumKartaId,
                        principalTable: "Karta",
                        principalColumn: "KartaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RezervacijaKarte",
                columns: table => new
                {
                    RezervacijaKarteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: true),
                    DatumIsteka = table.Column<DateTime>(type: "datetime", nullable: true),
                    Otkazana = table.Column<bool>(type: "bit", nullable: true),
                    Qrcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KartaID = table.Column<int>(type: "int", nullable: true),
                    PutnikID = table.Column<int>(type: "int", nullable: true),
                    VrstaKartaVrstaKarteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervacijaKarte", x => x.RezervacijaKarteID);
                    table.ForeignKey(
                        name: "FK_KartaID",
                        column: x => x.KartaID,
                        principalTable: "Karta",
                        principalColumn: "KartaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Putnik1ID",
                        column: x => x.PutnikID,
                        principalTable: "Putnik",
                        principalColumn: "PutnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RezervacijaKarte_VrstaKarte_VrstaKartaVrstaKarteId",
                        column: x => x.VrstaKartaVrstaKarteId,
                        principalTable: "VrstaKarte",
                        principalColumn: "VrstaKarteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autobus_VozacID",
                table: "Autobus",
                column: "VozacID");

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaID",
                table: "Gradovi",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Karta_RezervacijaSjedistaID",
                table: "Karta",
                column: "RezervacijaSjedistaID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikId",
                table: "KorisniciUloge",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaId",
                table: "KorisniciUloge",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifikacije_NovostiID",
                table: "Notifikacije",
                column: "NovostiID");

            migrationBuilder.CreateIndex(
                name: "IX_Novosti_KorisnikID",
                table: "Novosti",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_PutnikID",
                table: "Ocjena",
                column: "PutnikID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjena_RedVoznjeID",
                table: "Ocjena",
                column: "RedVoznjeID");

            migrationBuilder.CreateIndex(
                name: "IX_PutnikNotifikacije_NotifikacijeID",
                table: "PutnikNotifikacije",
                column: "NotifikacijeID");

            migrationBuilder.CreateIndex(
                name: "IX_PutnikNotifikacije_PutnikID",
                table: "PutnikNotifikacije",
                column: "PutnikID");

            migrationBuilder.CreateIndex(
                name: "IX_RedVoznje_AutobusID",
                table: "RedVoznje",
                column: "AutobusID");

            migrationBuilder.CreateIndex(
                name: "IX_RedVoznje_GradDolaskaID",
                table: "RedVoznje",
                column: "GradDolaskaID");

            migrationBuilder.CreateIndex(
                name: "IX_RedVoznje_GradPolaskaID",
                table: "RedVoznje",
                column: "GradPolaskaID");

            migrationBuilder.CreateIndex(
                name: "IX_RedVoznje_KorisnikID",
                table: "RedVoznje",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaKarte_KartaID",
                table: "RezervacijaKarte",
                column: "KartaID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaKarte_PutnikID",
                table: "RezervacijaKarte",
                column: "PutnikID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaKarte_VrstaKartaVrstaKarteId",
                table: "RezervacijaKarte",
                column: "VrstaKartaVrstaKarteId");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaSjedista_AutobusID",
                table: "RezervacijaSjedista",
                column: "AutobusID");

            migrationBuilder.CreateIndex(
                name: "IX_VrstaKarte_KartumKartaId",
                table: "VrstaKarte",
                column: "KartumKartaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "Ocjena");

            migrationBuilder.DropTable(
                name: "PutnikNotifikacije");

            migrationBuilder.DropTable(
                name: "RezervacijaKarte");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "RedVoznje");

            migrationBuilder.DropTable(
                name: "Notifikacije");

            migrationBuilder.DropTable(
                name: "Putnik");

            migrationBuilder.DropTable(
                name: "VrstaKarte");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Novosti");

            migrationBuilder.DropTable(
                name: "Karta");

            migrationBuilder.DropTable(
                name: "Drzava");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "RezervacijaSjedista");

            migrationBuilder.DropTable(
                name: "Autobus");

            migrationBuilder.DropTable(
                name: "Vozac");
        }
    }
}
