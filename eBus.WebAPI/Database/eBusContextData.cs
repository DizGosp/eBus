using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBus.WebAPI.Database
{
    public partial class eBusContext
    {
        public static byte[] GenerirajSliku(string slika)
        {
            List<byte> voziloSlika = new List<byte>();
            string hexPart1 = slika.Substring(2);
            for (int i = 0; i < hexPart1.Length / 2; i++)
            {
                string hexNumber = hexPart1.Substring(i * 2, 2);
                voziloSlika.Add((byte)Convert.ToInt32(hexNumber, 16));
            }
            return voziloSlika.ToArray();
        }

        string img = "0x89504E470D0A1A0A0000000D4948445200000020000000200806000000737A7AF4000000097048597300000EC400000EC401952B0E1B000002CE494441545885AD974D48554114C77FCAE3212222D2A2368DB82A08918A900871FAA62C482C22085A4432500BA18412572EC2DAE5621641455F08B648098B165E2A8B76421184AB26C24548894494C8A3C5CCB5ABDE77DFCC7BFE577367CE9CF3BB67E69E995B45A0A4324D400FB01F68020AC02C3009DC8EB4F81CE2AF2A2030401F3008E48B982D01378081488B828FDF6A5F001778282338400EB8060CFB3AF5CA8054A60D784B18F0D1488B895246BE0EAF060607E8F7312A9901A94C0DF013A8090428009B222DBE6719F9BCD5963282C7BE5B7C8C4A694319C16335AE07C062050025E7FA007CAB002073FD7D01BE00F365045F023E540CE02ADACB3200A6222D7E550CE0F4A80C80073E46BE00CF809980E0B3C0E3750370CB702500A03FD2E2CFBA01388871E0BE87E93870CFD76F687DEF217B677F05CE465A783B0C0270691DCF30998CB45808F1199A0180BF196373A1CE426E448DC002167A10B808D4BAE145E00E76A3FE066A7D6A80178054A605E8054E0387222D5EBBFE3AA0DD01BD8BB4F8E1FA5B8137C008301C6991590D8B2E8154A6592A330A4C03E7B0477247C26437B640DD05B627FADB813AE03C302D951993CA6CF30690CA544B65FA804F40F72A9B0389F625A0017B5C0F24FAF7ADF27FDC81DC94CAACB94FAE0070691DC35E3ED32E21BBA432F5AE3D843DEDE681EB6E7E1ED89B322F075C065E496556DC2F9601A432D5C028D099E220561E3808106931053C0126222D5EB8F138FDC5D4063C4F6622998153C0E18CC9B14E38E05AE00CD0E5BE90E5B112DA095C4803D8E13119A0D305EFC4EE811AA05B2A9303BA3C7D2CC7CA253A73298669AAC76ECE6389BE93D81370A3A78FD4A0D301F37A81E6C4733BFF8B928F3EC68DE4123CC4FF146BC56622561E5B177CF414B8153FACA984529923D837ECC07F594AA900BCC7FE338E244FCBA2A5582AD300ECC1BEED566033B6E8C41B2F4D8BD8BA3087BD4DCF609776AAD81FD23F7DAEB246416063D60000000049454E44AE426082";

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Drzava>().HasData(new WebAPI.Database.Drzava()
            {
                DrzavaId = 1,
                NazivDrzave = "Bosna i Hercegovina"
            });

            modelBuilder.Entity<Gradovi>().HasData(new WebAPI.Database.Gradovi()
            {
                GradId = 1,
                NazivGrada = "Maglaj",
                DrzavaId = 1
            });
            modelBuilder.Entity<Gradovi>().HasData(new WebAPI.Database.Gradovi()
            {
                GradId = 2,
                NazivGrada = "Mostar",
                DrzavaId = 1
            });
            modelBuilder.Entity<Gradovi>().HasData(new WebAPI.Database.Gradovi()
            {
                GradId = 3,
                NazivGrada = "Sarajevo",
                DrzavaId = 1
            });
            modelBuilder.Entity<Gradovi>().HasData(new WebAPI.Database.Gradovi()
            {
                GradId = 4,
                NazivGrada = "Zenica",
                DrzavaId = 1
            });

            modelBuilder.Entity<Uloga>().HasData(new WebAPI.Database.Uloga()
            {
                UlogaId = 1,
                Naziv = "Admin"
            });
            modelBuilder.Entity<Uloga>().HasData(new WebAPI.Database.Uloga()
            {
                UlogaId = 2,
                Naziv = "Radnik"
            });

            modelBuilder.Entity<VrstaKarte>().HasData(new WebAPI.Database.VrstaKarte()
            {
                VrstaKarteId = 1,
                VrstaKarte1 = "Obicna"
            });
            modelBuilder.Entity<VrstaKarte>().HasData(new WebAPI.Database.VrstaKarte()
            {
                VrstaKarteId = 2,
                VrstaKarte1 = "Studentska"
            });
            modelBuilder.Entity<VrstaKarte>().HasData(new WebAPI.Database.VrstaKarte()
            {
                VrstaKarteId = 3,
                VrstaKarte1 = "Penzionerska"
            });

            modelBuilder.Entity<Vozac>().HasData(new WebAPI.Database.Vozac()
            {
                VozacId = 1,
                Vozacka = "DE",
                Ime = "Vozac1",
                Prezime = "Vozac1",
                Status = false
            });
            modelBuilder.Entity<Vozac>().HasData(new WebAPI.Database.Vozac()
            {
                VozacId = 2,
                Vozacka = "DE",
                Ime = "Vozac2",
                Prezime = "Vozac2",
                Status = false
            });
            modelBuilder.Entity<Vozac>().HasData(new WebAPI.Database.Vozac()
            {
                VozacId = 3,
                Vozacka = "DE",
                Ime = "Vozac3",
                Prezime = "Vozac3",
                Status = false
            });

            modelBuilder.Entity<Autobu>().HasData(new WebAPI.Database.Autobu()
            {
                AutobusId = 1,
                NazivAutobusa = "Mercedes",
                Klasa = "Veliki",
                Status = false,
                VozacId = 1
            });
            modelBuilder.Entity<Autobu>().HasData(new WebAPI.Database.Autobu()
            {
                AutobusId = 2,
                NazivAutobusa = "Scanic",
                Klasa = "Veliki",
                Status = false,
                VozacId = 2
            });
            modelBuilder.Entity<Autobu>().HasData(new WebAPI.Database.Autobu()
            {
                AutobusId = 3,
                NazivAutobusa = "Volvo",
                Klasa = "Veliki",
                Status = false,
                VozacId = 3
            });

            for (int a = 1; a <= 3; a++)
            {
                if (a == 1)
                {
                    for (int i = 1; i <= ((55 - 5) / 2) + 1; i++)
                    {
                        if (i < 25)
                        {
                            for (int j = 1; j <= 4; j++)
                            {
                                modelBuilder.Entity<RezervacijaSjedistum>().HasData(new WebAPI.Database.RezervacijaSjedistum()
                                {
                                    RezervacijaSjedistaId = i,
                                    Red = i,
                                    Kolona = j,
                                    Status = false,
                                    AutobusId = 1
                                });
                            }
                        }
                        else if (i == 26)
                        {
                            for (int j = 1; j <= 5; j++)
                            {
                                modelBuilder.Entity<RezervacijaSjedistum>().HasData(new WebAPI.Database.RezervacijaSjedistum()
                                {
                                    RezervacijaSjedistaId = i,
                                    Red = i,
                                    Kolona = j,
                                    Status = false,
                                    AutobusId = 1
                                });
                            }
                        }
                    }
                }
                else if (a == 2) 
                {
                    for (int i = 1; i <= ((55 - 5) / 2) + 1; i++)
                    {
                        if (i < 25)
                        {
                            for (int j = 1; j <= 4; j++)
                            {
                                modelBuilder.Entity<RezervacijaSjedistum>().HasData(new WebAPI.Database.RezervacijaSjedistum()
                                {
                                    RezervacijaSjedistaId = i,
                                    Red = i,
                                    Kolona = j,
                                    Status = false,
                                    AutobusId = 2
                                });
                            }
                        }
                        else if (i == 26)
                        {
                            for (int j = 1; j <= 5; j++)
                            {
                                modelBuilder.Entity<RezervacijaSjedistum>().HasData(new WebAPI.Database.RezervacijaSjedistum()
                                {
                                    RezervacijaSjedistaId = i,
                                    Red = i,
                                    Kolona = j,
                                    Status = false,
                                    AutobusId = 2
                                });
                            }
                        }
                    }
                }
                else if (a == 3) 
                {
                    for (int i = 1; i <= ((55 - 5) / 2) + 1; i++)
                    {
                        if (i < 25)
                        {
                            for (int j = 1; j <= 4; j++)
                            {
                                modelBuilder.Entity<RezervacijaSjedistum>().HasData(new WebAPI.Database.RezervacijaSjedistum()
                                {
                                    RezervacijaSjedistaId = i,
                                    Red = i,
                                    Kolona = j,
                                    Status = false,
                                    AutobusId = 3
                                });
                            }
                        }
                        else if (i == 26)
                        {
                            for (int j = 1; j <= 5; j++)
                            {
                                modelBuilder.Entity<RezervacijaSjedistum>().HasData(new WebAPI.Database.RezervacijaSjedistum()
                                {
                                    RezervacijaSjedistaId = i,
                                    Red = i,
                                    Kolona = j,
                                    Status = false,
                                    AutobusId = 3
                                });
                            }
                        }
                    }
                }
            }


            modelBuilder.Entity<Korisnici>().HasData(new WebAPI.Database.Korisnici()
            {
                KorisnikId = 1,
                Ime = "Desktop",
                Prezime = "Desktop",
                Email = "desktop@gmail.com",
                Status = true,
                Slika = GenerirajSliku(img),
                KorisnickoIme = "desktop",
                LozinkaHash = @"eT9Yy8EkOrXjGvwC/ZJ2s2ZenEU=",
                LozinkaSalt = @"gEh7o9ft1vKzOXoQCqm0tQ=="
            });
            modelBuilder.Entity<Korisnici>().HasData(new WebAPI.Database.Korisnici()
            {
                KorisnikId = 1,
                Ime = "Radnik",
                Prezime = "Radnik",
                Email = "radnik@gmail.com",
                Status = true,
                Slika = GenerirajSliku(img),
                KorisnickoIme = "radnik",
                LozinkaHash = @"0loX+gc2xEb/A+/Rl80N1u1zxfs=",
                LozinkaSalt = @"1DeZwxiMZzPQctBrGzPsHA=="
            });

            modelBuilder.Entity<KorisniciUloge>().HasData(new WebAPI.Database.KorisniciUloge()
            {
                KorisniciUlogeId = 1,
                KorisnikId = 1,
                UlogaId = 1
            });
            modelBuilder.Entity<KorisniciUloge>().HasData(new WebAPI.Database.KorisniciUloge()
            {
                KorisniciUlogeId = 2,
                KorisnikId = 2,
                UlogaId = 2
            });


            modelBuilder.Entity<Putnik>().HasData(new WebAPI.Database.Putnik()
            {
                PutnikId = 1,
                Ime = "Mobile",
                Prezime = "Mobile",
                Email = "mobile@gmail.com",
                DatumRegistracije = DateTime.Now,
                DatumRodjenja = DateTime.Now,
                Slika = GenerirajSliku(img),
                KorisnickoIme = "mobile",
                LozinkaHash = @"wLPiq1g6VK+Hn25tqDfjg0iZ1NU=",
                LozinkaSalt = @"sHJcD+qY37p2BrGlLaZW4g=="
            });


            modelBuilder.Entity<RedVoznje>().HasData(new WebAPI.Database.RedVoznje()
            {
                RedVoznjeId = 1,
                Naziv = "Autoprijevoz",
                DatumVrijemePolaska = DateTime.Parse("2021-07-10 08:00:00.000"),
                DatumVrijemeDolaska = DateTime.Parse("2021-07-10 13:00:00.000"),
                Cijena =15,
                AutobusId =1,
                KorisnikId = 1,
                GradPolaskaId = 2,
                GradDolaskaId = 1
            });
            modelBuilder.Entity<RedVoznje>().HasData(new WebAPI.Database.RedVoznje()
            {
                RedVoznjeId = 2,
                Naziv = "Autoprijevoz",
                DatumVrijemePolaska = DateTime.Now.AddHours(2),
                DatumVrijemeDolaska = DateTime.Now.AddHours(4),
                Cijena = 14,
                AutobusId = 1,
                KorisnikId = 1,
                GradPolaskaId = 2,
                GradDolaskaId = 1
            });
            modelBuilder.Entity<RedVoznje>().HasData(new WebAPI.Database.RedVoznje()
            {
                RedVoznjeId = 3,
                Naziv = "AutoPrijevoz",
                DatumVrijemePolaska = DateTime.Now.AddHours(4),
                DatumVrijemeDolaska = DateTime.Now.AddHours(5),
                Cijena = 10,
                AutobusId = 2,
                KorisnikId = 1,
                GradPolaskaId = 1,
                GradDolaskaId = 4
            });
            modelBuilder.Entity<RedVoznje>().HasData(new WebAPI.Database.RedVoznje()
            {
                RedVoznjeId = 4,
                Naziv = "AutoPrijevoz",
                DatumVrijemePolaska = DateTime.Now.AddHours(3),
                DatumVrijemeDolaska = DateTime.Now.AddHours(8),
                Cijena = 20,
                AutobusId = 3,
                KorisnikId = 1,
                GradPolaskaId = 1,
                GradDolaskaId = 2
            });
            modelBuilder.Entity<RedVoznje>().HasData(new WebAPI.Database.RedVoznje()
            {
                RedVoznjeId = 5,
                Naziv = "AutoPrijevoz",
                DatumVrijemePolaska = DateTime.Now.AddHours(3),
                DatumVrijemeDolaska = DateTime.Now.AddHours(8),
                Cijena = 12,
                AutobusId = 1,
                KorisnikId = 1,
                GradPolaskaId = 2,
                GradDolaskaId = 3
            });

            modelBuilder.Entity<Kartum>().HasData(new WebAPI.Database.Kartum()
            {
                KartaId = 1,
                BrojKarte = "259287571",
                VrstaKarteId=1,
                DatumIzdavanja= DateTime.Parse("2021-07-09 08:00:00.000")
            });

            modelBuilder.Entity<RezervacijaKarte>().HasData(new WebAPI.Database.RezervacijaKarte()
            {
                RezervacijaKarteId=1,
                DatumKreiranja=DateTime.Parse("2021-07-09 08:00:00.000"),
                DatumIsteka= DateTime.Parse("2021-07-15 08:00:00.000"),
                Otkazana=false,
                Qrcode="abc123ja892j",
                KartaId=1,
                PutnikId=1,
                RedVoznjeId=1,
                Placeno=true
            });


            modelBuilder.Entity<Novosti>().HasData(new WebAPI.Database.Novosti()
            {
                NovostiId=1,
                Sadrzaj="Ovo je obavijest",
                BrojPregleda=0,
                DatumObjave=DateTime.Now,
                Naslov="Novost",
                KorisnikId=1
            });

            modelBuilder.Entity<Notifikacije>().HasData(new WebAPI.Database.Notifikacije()
            {
                NotifikacijeId = 1,
                Naslov="Ovo je notifikacija!",
                DatumSlanja=DateTime.Now,
                NovostiId=1
            });

            modelBuilder.Entity<PutnikNotifikacije>().HasData(new WebAPI.Database.PutnikNotifikacije()
            {
                PutnikNotifikacijeId = 1,
                NotifikacijeId=1,
                PutnikId=1,
                Procitano=false
            });



            modelBuilder.Entity<Ocjena>().HasData(new WebAPI.Database.Ocjena()
            {
                OcjenaId = 1,
                Ocjena1 = 5,
                Komentar = "Sve pohvale!",
                RedVoznjeId=1,
                PutnikId=1
            });


        }
    }
}
