using Microsoft.EntityFrameworkCore;
using SchulIT.SchildExport.Entities;

namespace SchulIT.SchildExport.Data
{
    public partial class SchildNRWContext : DbContext
    {
        public SchildNRWContext()
        {
        }

        public SchildNRWContext(DbContextOptions<SchildNRWContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllgAdrAnsprechpartner> AllgAdrAnsprechpartner { get; set; }
        public virtual DbSet<EigeneSchuleAbtKl> EigeneSchuleAbtKl { get; set; }
        public virtual DbSet<EigeneSchuleAbteilungen> EigeneSchuleAbteilungen { get; set; }
        public virtual DbSet<EigeneSchuleFachklassen> EigeneSchuleFachklassen { get; set; }
        public virtual DbSet<EigeneSchuleFaecher> EigeneSchuleFaecher { get; set; }
        public virtual DbSet<EigeneSchuleJahrgaenge> EigeneSchuleJahrgaenge { get; set; }
        public virtual DbSet<EigeneSchuleKursart> EigeneSchuleKursart { get; set; }
        public virtual DbSet<EigeneSchuleKursartAllg> EigeneSchuleKursartAllg { get; set; }
        public virtual DbSet<EigeneSchuleSchulformen> EigeneSchuleSchulformen { get; set; }
        public virtual DbSet<EigeneSchuleTexte> EigeneSchuleTexte { get; set; }
        public virtual DbSet<EigeneSchuleZertifikate> EigeneSchuleZertifikate { get; set; }
        public virtual DbSet<EigeneSchuleZertifikatsfaecher> EigeneSchuleZertifikatsfaecher { get; set; }
        public virtual DbSet<FachklassenSchwerpunkte> FachklassenSchwerpunkte { get; set; }
        public virtual DbSet<Floskelgruppen> Floskelgruppen { get; set; }
        public virtual DbSet<KAdressart> KAdressart { get; set; }
        public virtual DbSet<KAllgAdresse> KAllgAdresse { get; set; }
        public virtual DbSet<KAnkreuzfloskeln> KAnkreuzfloskeln { get; set; }
        public virtual DbSet<KBeschaeftigungsArt> KBeschaeftigungsArt { get; set; }
        public virtual DbSet<KEinschulungsArt> KEinschulungsArt { get; set; }
        public virtual DbSet<KEinzelleistungen> KEinzelleistungen { get; set; }
        public virtual DbSet<KEntlassGrund> KEntlassGrund { get; set; }
        public virtual DbSet<KErzieherArt> KErzieherArt { get; set; }
        public virtual DbSet<KErzieherFunktion> KErzieherFunktion { get; set; }
        public virtual DbSet<KFahrschuelerArt> KFahrschuelerArt { get; set; }
        public virtual DbSet<KFoerderschwerpunkt> KFoerderschwerpunkt { get; set; }
        public virtual DbSet<KHaltestelle> KHaltestelle { get; set; }
        public virtual DbSet<KKindergarten> KKindergarten { get; set; }
        public virtual DbSet<KKlassenOrgForm> KKlassenOrgForm { get; set; }
        public virtual DbSet<KLehrer> KLehrer { get; set; }
        public virtual DbSet<KOrt> KOrt { get; set; }
        public virtual DbSet<KOrtsteil> KOrtsteil { get; set; }
        public virtual DbSet<KReligion> KReligion { get; set; }
        public virtual DbSet<KSchule> KSchule { get; set; }
        public virtual DbSet<KSchulfunktionen> KSchulfunktionen { get; set; }
        public virtual DbSet<KSchwerpunkt> KSchwerpunkt { get; set; }
        public virtual DbSet<KSportbefreiung> KSportbefreiung { get; set; }
        public virtual DbSet<KStaat> KStaat { get; set; }
        public virtual DbSet<KTelefonArt> KTelefonArt { get; set; }
        public virtual DbSet<KVermerkart> KVermerkart { get; set; }
        public virtual DbSet<KZertifikate> KZertifikate { get; set; }
        public virtual DbSet<Kompetenzen> Kompetenzen { get; set; }
        public virtual DbSet<Kompetenzgruppen> Kompetenzgruppen { get; set; }
        public virtual DbSet<KursKombinationen> KursKombinationen { get; set; }
        public virtual DbSet<KursLehrer> KursLehrer { get; set; }
        public virtual DbSet<Kurse> Kurse { get; set; }
        public virtual DbSet<LehrerAbschnittsdaten> LehrerAbschnittsdaten { get; set; }
        public virtual DbSet<LehrerFotos> LehrerFotos { get; set; }
        public virtual DbSet<LehrerImei> LehrerImei { get; set; }
        public virtual DbSet<NichtMoeglAbiFachKombi> NichtMoeglAbiFachKombi { get; set; }
        public virtual DbSet<Personengruppen> Personengruppen { get; set; }
        public virtual DbSet<PersonengruppenPersonen> PersonengruppenPersonen { get; set; }
        public virtual DbSet<SchildFilter> SchildFilter { get; set; }
        public virtual DbSet<Schueler> Schueler { get; set; }
        public virtual DbSet<SchuelerAbgaenge> SchuelerAbgaenge { get; set; }
        public virtual DbSet<SchuelerAbiFaecher> SchuelerAbiFaecher { get; set; }
        public virtual DbSet<SchuelerAbitur> SchuelerAbitur { get; set; }
        public virtual DbSet<SchuelerAllgAdr> SchuelerAllgAdr { get; set; }
        public virtual DbSet<SchuelerAnkreuzfloskeln> SchuelerAnkreuzfloskeln { get; set; }
        public virtual DbSet<SchuelerBkabschluss> SchuelerBkabschluss { get; set; }
        public virtual DbSet<SchuelerBkfaecher> SchuelerBkfaecher { get; set; }
        public virtual DbSet<SchuelerEinzelleistungen> SchuelerEinzelleistungen { get; set; }
        public virtual DbSet<SchuelerErzAdr> SchuelerErzAdr { get; set; }
        public virtual DbSet<SchuelerErzFunktion> SchuelerErzFunktion { get; set; }
        public virtual DbSet<SchuelerFehlstunden> SchuelerFehlstunden { get; set; }
        public virtual DbSet<SchuelerFhr> SchuelerFhr { get; set; }
        public virtual DbSet<SchuelerFhrfaecher> SchuelerFhrfaecher { get; set; }
        public virtual DbSet<SchuelerFoerderempfehlungen> SchuelerFoerderempfehlungen { get; set; }
        public virtual DbSet<SchuelerFotos> SchuelerFotos { get; set; }
        public virtual DbSet<SchuelerGsdaten> SchuelerGsdaten { get; set; }
        public virtual DbSet<SchuelerLdPsfachBem> SchuelerLdPsfachBem { get; set; }
        public virtual DbSet<SchuelerLeistungsdaten> SchuelerLeistungsdaten { get; set; }
        public virtual DbSet<SchuelerLernabschnittsdaten> SchuelerLernabschnittsdaten { get; set; }
        public virtual DbSet<SchuelerListe> SchuelerListe { get; set; }
        public virtual DbSet<SchuelerListeInhalt> SchuelerListeInhalt { get; set; }
        public virtual DbSet<SchuelerNuesdaten> SchuelerNuesdaten { get; set; }
        public virtual DbSet<SchuelerSprachenfolge> SchuelerSprachenfolge { get; set; }
        public virtual DbSet<SchuelerTelefone> SchuelerTelefone { get; set; }
        public virtual DbSet<SchuelerVermerke> SchuelerVermerke { get; set; }
        public virtual DbSet<SchuelerWiedervorlage> SchuelerWiedervorlage { get; set; }
        public virtual DbSet<SchuelerZuweisungen> SchuelerZuweisungen { get; set; }
        public virtual DbSet<Stundentafel> Stundentafel { get; set; }
        public virtual DbSet<StundentafelFaecher> StundentafelFaecher { get; set; }
        public virtual DbSet<TextExportVorlagen> TextExportVorlagen { get; set; }
        public virtual DbSet<Usergroups> Usergroups { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Versetzung> Versetzung { get; set; }
        public virtual DbSet<ZuordnungReportvorlagen> ZuordnungReportvorlagen { get; set; }

        public virtual DbQuery<LehrerLehramtLehrbef> LehrerLehramtLehrbef { get; set; }

        public virtual DbQuery<EigeneSchule> EigeneSchule { get; set; }

        // Unable to generate entity type for table 'dbo.EigeneSchule_FachTeilleistungen'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EigeneSchule_Merkmale'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EigeneSchule_Teilstandorte'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LehrerAnrechnung'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LehrerEntlastung'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SchuelerMerkmale'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LehrerFunktionen'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SchuelerReportvorlagen'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LehrerLehramt'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LehrerLehramtFachr'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Fach_Gliederungen'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LehrerLehramtLehrbef'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LehrerMehrleistung'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Logins'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PrfSemAbschl'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Schild_Verwaltung'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Floskeln'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.K_Ankreuzdaten'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EigeneSchule'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.K_Verkehrssprachen'. Please see the warning messages.

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AllgAdrAnsprechpartner>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Abteilung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdresseId).HasColumnName("Adresse_ID");

                entity.Property(e => e.Anrede)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GuId)
                    .HasColumnName("GU_ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Titel)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Adresse)
                    .WithMany(p => p.AllgAdrAnsprechpartner)
                    .HasForeignKey(d => d.AdresseId)
                    .HasConstraintName("Ansprechpartner_Adr_FK");
            });

            modelBuilder.Entity<EigeneSchuleAbtKl>(entity =>
            {
                entity.ToTable("EigeneSchule_Abt_Kl");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbteilungId).HasColumnName("Abteilung_ID");

                entity.Property(e => e.Klasse)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.HasOne(d => d.Abteilung)
                    .WithMany(p => p.EigeneSchuleAbtKl)
                    .HasForeignKey(d => d.AbteilungId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EigeneSchuleAbtKl_Abteilung_FK");

                entity.HasOne(d => d.KlasseNavigation)
                    .WithMany(p => p.EigeneSchuleAbtKl)
                    .HasPrincipalKey(p => p.Klasse)
                    .HasForeignKey(d => d.Klasse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EigeneSchuleAbtKl_Klasse_FK");
            });

            modelBuilder.Entity<EigeneSchuleAbteilungen>(entity =>
            {
                entity.ToTable("EigeneSchule_Abteilungen");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbteilungsLeiter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Durchwahl)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Raum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.HasOne(d => d.AbteilungsLeiterNavigation)
                    .WithMany(p => p.EigeneSchuleAbteilungen)
                    .HasPrincipalKey(p => p.Kuerzel)
                    .HasForeignKey(d => d.AbteilungsLeiter)
                    .HasConstraintName("EigeneSchule_Abteilungen_Leiter_FK");
            });

            modelBuilder.Entity<EigeneSchuleFachklassen>(entity =>
            {
                entity.ToTable("EigeneSchule_Fachklassen");

                entity.HasIndex(e => new { e.BkindexTyp, e.Fks, e.Ap })
                    .HasName("EigeneSchule_Fachklassen_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Ap)
                    .HasColumnName("AP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BeschreibungW)
                    .HasColumnName("Beschreibung_W")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bkindex).HasColumnName("BKIndex");

                entity.Property(e => e.BkindexTyp)
                    .HasColumnName("BKIndexTyp")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DqrNiveau).HasColumnName("DQR_Niveau");

                entity.Property(e => e.Ebene1Klartext)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ebene2Klartext)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ebene3Klartext)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Fks)
                    .HasColumnName("FKS")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FksApSim)
                    .HasColumnName("FKS_AP_SIM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Kennung)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lernfelder).HasColumnType("text");

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EigeneSchuleFaecher>(entity =>
            {
                entity.ToTable("EigeneSchule_Faecher");

                entity.HasIndex(e => e.FachKrz)
                    .HasName("EigeneSchule_Faecher_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbgeschlFaecherHolen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.AbiMoegl)
                    .HasColumnName("Abi_Moegl")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.AlsNeueFsinSii)
                    .HasColumnName("AlsNeueFSinSII")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AufZeugnis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Aufgabenfeld)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BasisFach)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.E1)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.E1S)
                    .HasColumnName("E1_S")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.E1Wze).HasColumnName("E1_WZE");

                entity.Property(e => e.E2)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.E2S)
                    .HasColumnName("E2_S")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.E2Wze).HasColumnName("E2_WZE");

                entity.Property(e => e.FachKrz)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FachgruppeId).HasColumnName("Fachgruppe_ID");

                entity.Property(e => e.Gewichtung).HasDefaultValueSql("((1))");

                entity.Property(e => e.GewichtungFhr).HasColumnName("GewichtungFHR");

                entity.Property(e => e.IstSchriftlich)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IstSchriftlichBa)
                    .HasColumnName("IstSchriftlichBA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IstSprache)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Leitfach2Id).HasColumnName("Leitfach2_ID");

                entity.Property(e => e.LeitfachId).HasColumnName("Leitfach_ID");

                entity.Property(e => e.Lernfelder).HasColumnType("ntext");

                entity.Property(e => e.LkMoegl)
                    .HasColumnName("LK_Moegl")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NachprErlaubt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.NurMuendlich)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Q1)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Q2)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Q3)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Q4)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QWze).HasColumnName("Q_WZE");

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.SortierungS2).HasDefaultValueSql("((32000))");

                entity.Property(e => e.StatistikKrz)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UeZeugnisBez)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Unterichtssprache)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZeugnisBez)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EigeneSchuleJahrgaenge>(entity =>
            {
                entity.ToTable("EigeneSchule_Jahrgaenge");

                entity.HasIndex(e => e.InternKrz)
                    .HasName("EigeneSchule_Jahrgaenge_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Asdbezeichnung)
                    .HasColumnName("ASDBezeichnung")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Asdjahrgang)
                    .HasColumnName("ASDJahrgang")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FolgejahrgangId).HasColumnName("Folgejahrgang_ID");

                entity.Property(e => e.InternKrz)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IstChronologisch)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.SekStufe)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Sgl)
                    .HasColumnName("SGL")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.Spaltentitel)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EigeneSchuleKursart>(entity =>
            {
                entity.ToTable("EigeneSchule_Kursart");

                entity.HasIndex(e => new { e.Kursart, e.KursartAllg })
                    .HasName("EigeneSchule_Kursart_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.InternBez)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kursart)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.KursartAllg)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<EigeneSchuleKursartAllg>(entity =>
            {
                entity.ToTable("EigeneSchule_KursartAllg");

                entity.HasIndex(e => e.KursartAllg)
                    .HasName("EigeneSchule_KursartAllg_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.InternBez)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KursartAllg)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.KursartAsd)
                    .HasColumnName("KursartASD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<EigeneSchuleSchulformen>(entity =>
            {
                entity.ToTable("EigeneSchule_Schulformen");

                entity.HasIndex(e => e.Sgl)
                    .HasName("EigeneSchule_Schulformen_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bkindex).HasColumnName("BKIndex");

                entity.Property(e => e.DoppelQualifikation)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Schulform)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Schulform2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SfSgl)
                    .HasColumnName("SF_SGL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Sgl)
                    .HasColumnName("SGL")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<EigeneSchuleTexte>(entity =>
            {
                entity.ToTable("EigeneSchule_Texte");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Inhalt)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Kuerzel)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EigeneSchuleZertifikate>(entity =>
            {
                entity.ToTable("EigeneSchule_Zertifikate");

                entity.HasIndex(e => new { e.SchulnrEigner, e.Kuerzel })
                    .HasName("EigeneSchule_Zertifikate_IX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fach)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Formatvorlage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Kuerzel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EigeneSchuleZertifikatsfaecher>(entity =>
            {
                entity.HasKey(e => new { e.SchulnrEigner, e.Kuerzel })
                    .HasName("EigeneSchule_ZF_PK");

                entity.ToTable("EigeneSchule_Zertifikatsfaecher");

                entity.Property(e => e.Kuerzel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Klartext)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lernfelder).HasColumnType("text");

                entity.Property(e => e.ZertifikatId).HasColumnName("Zertifikat_ID");
            });

            modelBuilder.Entity<FachklassenSchwerpunkte>(entity =>
            {
                entity.HasKey(e => new { e.SchulnrEigner, e.FachklasseId, e.SchwerpunktId })
                    .HasName("Fachklassen_Schwerpunkte_PK");

                entity.ToTable("Fachklassen_Schwerpunkte");

                entity.Property(e => e.FachklasseId).HasColumnName("Fachklasse_ID");

                entity.Property(e => e.SchwerpunktId).HasColumnName("Schwerpunkt_ID");

                entity.HasOne(d => d.Fachklasse)
                    .WithMany(p => p.FachklassenSchwerpunkte)
                    .HasForeignKey(d => d.FachklasseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fachklassen_Schwerpunkte_Fachkl_FK");

                entity.HasOne(d => d.Schwerpunkt)
                    .WithMany(p => p.FachklassenSchwerpunkte)
                    .HasForeignKey(d => d.SchwerpunktId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fachklassen_Schwerpunkte_Schwerp_FK");
            });

            modelBuilder.Entity<Floskelgruppen>(entity =>
            {
                entity.HasKey(e => new { e.SchulnrEigner, e.Kuerzel })
                    .HasName("Floskelgruppen_PK");

                entity.Property(e => e.Kuerzel)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hauptgruppe)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KAdressart>(entity =>
            {
                entity.ToTable("K_Adressart");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_Adressart_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KAllgAdresse>(entity =>
            {
                entity.ToTable("K_AllgAdresse");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.AllgAdrAdressArt)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AllgAdrAusbildungsBetrieb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.AllgAdrBemerkungen)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AllgAdrBietetPraktika)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.AllgAdrBranche)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AllgAdrEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AllgAdrFax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllgAdrName1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AllgAdrName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AllgAdrPlz)
                    .HasColumnName("AllgAdrPLZ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AllgAdrStrasse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AllgAdrTelefon1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllgAdrTelefon2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AllgAdrZusatz1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AllgAdrZusatz2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BelehrungIsg)
                    .HasColumnName("BelehrungISG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ErwFuehrungszeugnis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ExtId)
                    .HasColumnName("ExtID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GuId)
                    .HasColumnName("GU_ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Massnahmentraeger)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.HasOne(d => d.AllgAdrAdressArtNavigation)
                    .WithMany(p => p.KAllgAdresse)
                    .HasPrincipalKey(p => p.Bezeichnung)
                    .HasForeignKey(d => d.AllgAdrAdressArt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("K_AllgAdresse_AdressArt_FK");
            });

            modelBuilder.Entity<KAnkreuzfloskeln>(entity =>
            {
                entity.ToTable("K_Ankreuzfloskeln");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FachId).HasColumnName("Fach_ID");

                entity.Property(e => e.Floskeltext)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Jahrgang)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KBeschaeftigungsArt>(entity =>
            {
                entity.ToTable("K_BeschaeftigungsArt");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_BeschaeftigungsArt_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KEinschulungsArt>(entity =>
            {
                entity.ToTable("K_EinschulungsArt");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_EinschulungsArt_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KEinzelleistungen>(entity =>
            {
                entity.ToTable("K_Einzelleistungen");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KEntlassGrund>(entity =>
            {
                entity.ToTable("K_EntlassGrund");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_EntlassGrund_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KErzieherArt>(entity =>
            {
                entity.ToTable("K_ErzieherArt");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_ErzieherArt_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ExportBez)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KErzieherFunktion>(entity =>
            {
                entity.ToTable("K_ErzieherFunktion");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_ErzieherFunktion_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KFahrschuelerArt>(entity =>
            {
                entity.ToTable("K_FahrschuelerArt");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_FahrschuelerArt_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KFoerderschwerpunkt>(entity =>
            {
                entity.ToTable("K_Foerderschwerpunkt");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_Foerderschwerpunkt_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.StatistikKrz)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KHaltestelle>(entity =>
            {
                entity.ToTable("K_Haltestelle");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_Haltestelle_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KKindergarten>(entity =>
            {
                entity.ToTable("K_Kindergarten");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ort)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Plz)
                    .HasColumnName("PLZ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Strasse)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KKlassenOrgForm>(entity =>
            {
                entity.ToTable("K_KlassenOrgForm");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_KlassenOrgForm_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.StatistikKrz)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KLehrer>(entity =>
            {
                entity.ToTable("K_Lehrer");

                entity.HasIndex(e => e.Kuerzel)
                    .HasName("K_Lehrer_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Amtsbezeichnung)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Anrede)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Antwort1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Antwort2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Beschaeftigungsart)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DatumAbgang).HasColumnType("smalldatetime");

                entity.Property(e => e.DatumZugang).HasColumnType("smalldatetime");

                entity.Property(e => e.Einsatzstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDienstlich)
                    .HasColumnName("EMailDienstlich")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Faecher)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FuerExport)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Geburtsdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.Geschlecht)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.GrundAbgang)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrundZugang)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GuId)
                    .HasColumnName("GU_ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Handy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdentNr1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.KennwortTools)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.KennwortToolsAktuell)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Kuerzel)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lbvnr)
                    .HasColumnName("LBVNr")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Lidkrz)
                    .HasColumnName("LIDKrz")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Lpassword)
                    .HasColumnName("LPassword")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nachname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Panr)
                    .HasColumnName("PANr")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonTyp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('LEHRKRAFT')");

                entity.Property(e => e.Plz)
                    .HasColumnName("PLZ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pwaktuell)
                    .HasColumnName("PWAktuell")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-;5')");

                entity.Property(e => e.Rechtsverhaeltnis)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SchIldwebConfig)
                    .HasColumnName("SchILDweb_Config")
                    .HasColumnType("text");

                entity.Property(e => e.SchIldwebFl)
                    .HasColumnName("SchILDweb_FL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.SchIldwebKl)
                    .HasColumnName("SchILDweb_KL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.SchulFunktion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SerNr)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.StaatKrz)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StammschulNr)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Statistik)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Strasse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Titel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vschluessel)
                    .HasColumnName("VSchluessel")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KOrt>(entity =>
            {
                entity.ToTable("K_Ort");

                entity.HasIndex(e => e.Plz)
                    .HasName("K_Ort_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kreis)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Land)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Plz)
                    .IsRequired()
                    .HasColumnName("PLZ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((3200))");
            });

            modelBuilder.Entity<KOrtsteil>(entity =>
            {
                entity.ToTable("K_Ortsteil");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_Ortsteil_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrtsteilSchluessel)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Plz)
                    .HasColumnName("PLZ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KReligion>(entity =>
            {
                entity.ToTable("K_Religion");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_Religion_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ExportBez)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.StatistikKrz)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ZeugnisBezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KSchule>(entity =>
            {
                entity.ToTable("K_Schule");

                entity.HasIndex(e => e.SchulNr)
                    .HasName("K_Schule_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Kuerzel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.KurzBez)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ort)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plz)
                    .HasColumnName("PLZ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SchulNr)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SchulNrSim)
                    .HasColumnName("SchulNr_SIM")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SchulformBez)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchulformKrz)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SchulformNr)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Schulleiter)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.Strasse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KSchulfunktionen>(entity =>
            {
                entity.ToTable("K_Schulfunktionen");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KSchwerpunkt>(entity =>
            {
                entity.ToTable("K_Schwerpunkt");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_Schwerpunkt_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KSportbefreiung>(entity =>
            {
                entity.ToTable("K_Sportbefreiung");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_Sportbefreiung_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KStaat>(entity =>
            {
                entity.ToTable("K_Staat");

                entity.HasIndex(e => e.StatistikKrz)
                    .HasName("K_Staat_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Bezeichnung2)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ExportBez)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.StatistikKrz)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KTelefonArt>(entity =>
            {
                entity.ToTable("K_TelefonArt");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_TelefonArt_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KVermerkart>(entity =>
            {
                entity.ToTable("K_Vermerkart");

                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("K_Vermerkart_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aenderbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<KZertifikate>(entity =>
            {
                entity.HasKey(e => new { e.Kuerzel, e.SchulnrEigner })
                    .HasName("K_Zertifikate_PK");

                entity.ToTable("K_Zertifikate");

                entity.Property(e => e.Kuerzel)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kompetenzen>(entity =>
            {
                entity.HasKey(e => new { e.KoId, e.KoGruppe })
                    .HasName("Kompetenzen_PK");

                entity.Property(e => e.KoId).HasColumnName("KO_ID");

                entity.Property(e => e.KoGruppe).HasColumnName("KO_Gruppe");

                entity.Property(e => e.KoBezeichnung)
                    .IsRequired()
                    .HasColumnName("KO_Bezeichnung")
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kompetenzgruppen>(entity =>
            {
                entity.HasKey(e => new { e.KgSpalte, e.KgZeile, e.KgId, e.KgBezeichnung })
                    .HasName("Kompetenzgruppen_PK");

                entity.Property(e => e.KgSpalte).HasColumnName("KG_Spalte");

                entity.Property(e => e.KgZeile).HasColumnName("KG_Zeile");

                entity.Property(e => e.KgId).HasColumnName("KG_ID");

                entity.Property(e => e.KgBezeichnung)
                    .HasColumnName("KG_Bezeichnung")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KursKombinationen>(entity =>
            {
                entity.HasKey(e => new { e.Kurs1Id, e.Kurs2Id })
                    .HasName("KursKombi_PK");

                entity.Property(e => e.Kurs1Id).HasColumnName("Kurs1_ID");

                entity.Property(e => e.Kurs2Id).HasColumnName("Kurs2_ID");
            });

            modelBuilder.Entity<KursLehrer>(entity =>
            {
                entity.HasKey(e => new { e.KursId, e.LehrerId })
                    .HasName("PrimaryKey");

                entity.Property(e => e.KursId).HasColumnName("Kurs_ID");

                entity.Property(e => e.LehrerId).HasColumnName("Lehrer_ID");

                entity.HasOne(d => d.Kurs)
                    .WithMany(p => p.KursLehrer)
                    .HasForeignKey(d => d.KursId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("KursLehrer_Kurs_FK");

                entity.HasOne(d => d.Lehrer)
                    .WithMany(p => p.KursLehrer)
                    .HasForeignKey(d => d.LehrerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("KursLehrer_Lehrer_FK");
            });

            modelBuilder.Entity<Kurse>(entity =>
            {
                entity.HasIndex(e => new { e.Jahr, e.Abschnitt, e.KurzBez, e.FachId, e.Asdjahrgang, e.KursartAllg, e.Wochenstd, e.LehrerKrz })
                    .HasName("Kurse_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Asdjahrgang)
                    .HasColumnName("ASDJahrgang")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EpochU)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.FachId).HasColumnName("Fach_ID");

                entity.Property(e => e.Fortschreibungsart)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Jahrgaenge)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JahrgangId).HasColumnName("Jahrgang_ID");

                entity.Property(e => e.KursartAllg)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.KurzBez)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LehrerKrz)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Schienen)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.WochenstdKl).HasColumnName("WochenstdKL");

                entity.Property(e => e.Zeugnisbez)
                    .HasMaxLength(130)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LehrerAbschnittsdaten>(entity =>
            {
                entity.HasKey(e => new { e.LehrerId, e.Jahr, e.Abschnitt })
                    .HasName("LehrerAbschnittsdaten_PK");

                entity.Property(e => e.LehrerId).HasColumnName("Lehrer_ID");

                entity.Property(e => e.Beschaeftigungsart)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Einsatzstatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rechtsverhaeltnis)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Lehrer)
                    .WithMany(p => p.LehrerAbschnittsdaten)
                    .HasForeignKey(d => d.LehrerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LehrerAbschnitte_Lehrer_FK");
            });

            modelBuilder.Entity<LehrerFotos>(entity =>
            {
                entity.HasKey(e => e.LehrerId)
                    .HasName("LehrerFotos_PK");

                entity.Property(e => e.LehrerId)
                    .HasColumnName("Lehrer_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Foto).HasColumnType("image");
            });

            modelBuilder.Entity<LehrerImei>(entity =>
            {
                entity.ToTable("Lehrer_IMEI");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Imei)
                    .HasColumnName("IMEI")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LehrerId).HasColumnName("Lehrer_ID");

                entity.HasOne(d => d.Lehrer)
                    .WithMany(p => p.LehrerImei)
                    .HasForeignKey(d => d.LehrerId)
                    .HasConstraintName("Lehrer_IMEI_Lehrer_FK");
            });

            modelBuilder.Entity<NichtMoeglAbiFachKombi>(entity =>
            {
                entity.HasKey(e => e.Pk)
                    .HasName("NichtMoeglAbiFachKombi_PK");

                entity.Property(e => e.Pk)
                    .HasColumnName("PK")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Fach1Id).HasColumnName("Fach1_ID");

                entity.Property(e => e.Fach2Id).HasColumnName("Fach2_ID");

                entity.Property(e => e.Kursart1)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Kursart2)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Phase)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Typ)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Personengruppen>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GruppenArt)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gruppenname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SammelEmail)
                    .HasColumnName("SammelEMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Xmlexport)
                    .HasColumnName("XMLExport")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Zusatzinfo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonengruppenPersonen>(entity =>
            {
                entity.ToTable("Personengruppen_Personen");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GruppeId).HasColumnName("Gruppe_ID");

                entity.Property(e => e.PersonAkadGrad)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PersonAnrede)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersonArt)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PersonEmail)
                    .HasColumnName("PersonEMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersonId).HasColumnName("Person_ID");

                entity.Property(e => e.PersonMobil)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonOrt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonPlz)
                    .HasColumnName("PersonPLZ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersonStrasse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonTelefon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonVorname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ZusatzInfo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SchildFilter>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("SchildFilter_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Art)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bedingung).HasColumnType("ntext");

                entity.Property(e => e.BedingungKlartext).HasColumnType("ntext");

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tabellen)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ZusatzTabellen)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schueler>(entity =>
            {
                entity.HasIndex(e => e.GuId)
                    .HasName("Schueler_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbschlussDatum)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AnmeldeDatum).HasColumnType("smalldatetime");

                entity.Property(e => e.Anschreibdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.Aosf)
                    .HasColumnName("AOSF")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Asdjahrgang)
                    .HasColumnName("ASDJahrgang")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Asdschulform)
                    .HasColumnName("ASDSchulform")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Aufnahmedatum).HasColumnType("smalldatetime");

                entity.Property(e => e.Aussiedler)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Ausweisnummer)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Autist)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AvLeist).HasColumnName("AV_Leist");

                entity.Property(e => e.AvSelbst).HasColumnName("AV_Selbst");

                entity.Property(e => e.AvZuv).HasColumnName("AV_Zuv");

                entity.Property(e => e.Bafoeg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.BeginnBildungsgang).HasColumnType("smalldatetime");

                entity.Property(e => e.Bemerkungen).HasColumnType("ntext");

                entity.Property(e => e.Beruf)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Berufsabschluss)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Berufsqualifikation)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BerufsschulpflErf)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BilingualerZweig)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bkazvo).HasColumnName("BKAZVO");

                entity.Property(e => e.DauerKindergartenbesuch)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Dokumentenverzeichnis)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DsnFhrText)
                    .HasColumnName("DSN_FHR_Text")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DsnText)
                    .HasColumnName("DSN_Text")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Duplikat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Durchschnitt)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DurchschnittsNote)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DurchschnittsnoteFhr)
                    .HasColumnName("DurchschnittsnoteFHR")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EinschulungsartAsd)
                    .HasColumnName("EinschulungsartASD")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EinschulungsartId).HasColumnName("Einschulungsart_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndeAnschlussfoerderung).HasColumnType("smalldatetime");

                entity.Property(e => e.EndeEingliederung).HasColumnType("smalldatetime");

                entity.Property(e => e.Entlassart)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Entlassdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.Entlassgrund)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Entlassjahrgang)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EntlassjahrgangId).HasColumnName("Entlassjahrgang_ID");

                entity.Property(e => e.Epjahre)
                    .HasColumnName("EPJahre")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.ErsteSchulformSi)
                    .HasColumnName("ErsteSchulform_SI")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExterneSchulnr)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FachklasseId).HasColumnName("Fachklasse_ID");

                entity.Property(e => e.FachklasseNsjId).HasColumnName("FachklasseNSJ_ID");

                entity.Property(e => e.FahrschuelerId).HasColumnName("Fahrschueler_ID");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Foerderschwerpunkt2Id).HasColumnName("Foerderschwerpunkt2_ID");

                entity.Property(e => e.FoerderschwerpunktId).HasColumnName("Foerderschwerpunkt_ID");

                entity.Property(e => e.FotoVorhanden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Geburtsdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.GeburtslandMutter)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GeburtslandSchueler)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GeburtslandVater)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Geburtsname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Geburtsort)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Geloescht)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Gesperrt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.GuId)
                    .HasColumnName("GU_ID")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.HaltestelleAbk)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HaltestelleId).HasColumnName("Haltestelle_ID");

                entity.Property(e => e.HatBerufsausbildung)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Hausnr)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HausnrZusatz)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Idext)
                    .HasColumnName("IDext")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JahrWechselSi).HasColumnName("JahrWechsel_SI");

                entity.Property(e => e.JahrWechselSii).HasColumnName("JahrWechsel_SII");

                entity.Property(e => e.JahrgangId).HasColumnName("Jahrgang_ID");

                entity.Property(e => e.Jva)
                    .HasColumnName("JVA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.KeineAuskunft)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.KindergartenId).HasColumnName("Kindergarten_ID");

                entity.Property(e => e.Klasse)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Klassenart)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.KonfDruck)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Land)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Lehrer)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LetzterAllgAbschluss)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LetzterBerufsAbschluss)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Lsbemerkung)
                    .HasColumnName("LSBemerkung")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LsentlassArt)
                    .HasColumnName("LSEntlassArt")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Lsentlassgrund)
                    .HasColumnName("LSEntlassgrund")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LsfachklKennung)
                    .HasColumnName("LSFachklKennung")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LsfachklSim)
                    .HasColumnName("LSFachklSIM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Lsjahrgang)
                    .HasColumnName("LSJahrgang")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Lsklassenart)
                    .HasColumnName("LSKlassenart")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LsrefPaed)
                    .HasColumnName("LSRefPaed")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LsschulNr)
                    .HasColumnName("LSSchulNr")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LsschulentlassDatum)
                    .HasColumnName("LSSchulentlassDatum")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Lsschulform)
                    .HasColumnName("LSSchulform")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LsschulformSim)
                    .HasColumnName("LSSchulformSIM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lssgl)
                    .HasColumnName("LSSGL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LssglSim)
                    .HasColumnName("LSSGL_SIM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lsversetzung)
                    .HasColumnName("LSVersetzung")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Markiert)
                    .HasMaxLength(21)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.MeisterBafoeg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Migrationshintergrund)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiziertAm).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiziertVon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnlineAnmeldung)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.OrgFormKrz)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrtAbk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrtsteilId).HasColumnName("Ortsteil_ID");

                entity.Property(e => e.Plz)
                    .HasColumnName("PLZ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PruefOrdnung)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RefPaed)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReligionAbk)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReligionId).HasColumnName("Religion_ID");

                entity.Property(e => e.Religionsabmeldung).HasColumnType("smalldatetime");

                entity.Property(e => e.Religionsanmeldung).HasColumnType("smalldatetime");

                entity.Property(e => e.SchulEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Schulbuchgeldbefreit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SchulpflichtErf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.SchulwechselNr)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Schulwechseldatum).HasColumnType("smalldatetime");

                entity.Property(e => e.Schwerbehinderung)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.SchwerpunktId).HasColumnName("Schwerpunkt_ID");

                entity.Property(e => e.SportbefreiungId).HasColumnName("Sportbefreiung_ID");

                entity.Property(e => e.SrcId).HasColumnName("SrcID");

                entity.Property(e => e.StaatAbk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaatAbk2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaatKrz)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StaatKrz2)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StatusNsj).HasColumnName("StatusNSJ");

                entity.Property(e => e.Strasse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Strassenname)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SvKonfl).HasColumnName("SV_Konfl");

                entity.Property(e => e.SvKoop).HasColumnName("SV_Koop");

                entity.Property(e => e.SvVerant).HasColumnName("SV_Verant");

                entity.Property(e => e.TeilnahmeSprachfoerderkurs)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UebergangsempfehlungJg5)
                    .HasColumnName("Uebergangsempfehlung_JG5")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VerkehrsspracheFamilie)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.VerpflichtungSprachfoerderkurs)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Volljaehrig)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Vorname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WechselBestaetigt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.ZieldifferentesLernen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Zusatz)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ZusatzNachname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ZustimmungFoto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.HasOne(d => d.Einschulungsart)
                    .WithMany(p => p.Schueler)
                    .HasForeignKey(d => d.EinschulungsartId)
                    .HasConstraintName("Schueler_Einschulungsart_FK");

                entity.HasOne(d => d.Fahrschueler)
                    .WithMany(p => p.Schueler)
                    .HasForeignKey(d => d.FahrschuelerId)
                    .HasConstraintName("Schueler_Fahrschueler_FK");

                entity.HasOne(d => d.Foerderschwerpunkt)
                    .WithMany(p => p.Schueler)
                    .HasForeignKey(d => d.FoerderschwerpunktId)
                    .HasConstraintName("Schueler_Foerderschwerpunkt_FK");

                entity.HasOne(d => d.Haltestelle)
                    .WithMany(p => p.Schueler)
                    .HasForeignKey(d => d.HaltestelleId)
                    .HasConstraintName("Schueler_Haltestelle_FK");

                entity.HasOne(d => d.KlasseNavigation)
                    .WithMany(p => p.Schueler)
                    .HasPrincipalKey(p => p.Klasse)
                    .HasForeignKey(d => d.Klasse)
                    .HasConstraintName("Schueler_Versetzung_FK");

                entity.HasOne(d => d.Ortsteil)
                    .WithMany(p => p.Schueler)
                    .HasForeignKey(d => d.OrtsteilId)
                    .HasConstraintName("Schueler_Ortsteil_FK");

                entity.HasOne(d => d.PlzNavigation)
                    .WithMany(p => p.Schueler)
                    .HasPrincipalKey(p => p.Plz)
                    .HasForeignKey(d => d.Plz)
                    .HasConstraintName("Schueler_Ort_FK");

                entity.HasOne(d => d.Religion)
                    .WithMany(p => p.Schueler)
                    .HasForeignKey(d => d.ReligionId)
                    .HasConstraintName("Schueler_Religion_FK");

                entity.HasOne(d => d.Sportbefreiung)
                    .WithMany(p => p.Schueler)
                    .HasForeignKey(d => d.SportbefreiungId)
                    .HasConstraintName("Schueler_Sportbefreiung_FK");

                entity.HasOne(d => d.StaatKrzNavigation)
                    .WithMany(p => p.Schueler)
                    .HasPrincipalKey(p => p.StatistikKrz)
                    .HasForeignKey(d => d.StaatKrz)
                    .HasConstraintName("Schueler_Staat_FK");
            });

            modelBuilder.Entity<SchuelerAbgaenge>(entity =>
            {
                entity.HasIndex(e => new { e.SchuelerId, e.LsschulEntlassDatum })
                    .HasName("SchuelerAbgaenge_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbgangsBeschreibung)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AbgangsSchulNr)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AbgangsSchule)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AbgangsSchuleAnschr)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AbgangsSchulform)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BemerkungIntern)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FuerSimexport)
                    .HasColumnName("FuerSIMExport")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.LsbeginnDatum)
                    .HasColumnName("LSBeginnDatum")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LsbeginnJahrgang)
                    .HasColumnName("LSBeginnJahrgang")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LsentlassArt)
                    .HasColumnName("LSEntlassArt")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LsfachklKennung)
                    .HasColumnName("LSFachklKennung")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LsfachklSim)
                    .HasColumnName("LSFachklSIM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Lsjahrgang)
                    .HasColumnName("LSJahrgang")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LsschulEntlassDatum)
                    .HasColumnName("LSSchulEntlassDatum")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LsschulformSim)
                    .HasColumnName("LSSchulformSIM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Lssgl)
                    .HasColumnName("LSSGL")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Lsversetzung)
                    .HasColumnName("LSVersetzung")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrganisationsformKrz)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerAbgaenge)
                    .HasForeignKey(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerAbgaenge_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerAbiFaecher>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbiFach)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FachId).HasColumnName("Fach_ID");

                entity.Property(e => e.FachKrz)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fachlehrer)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fsortierung).HasColumnName("FSortierung");

                entity.Property(e => e.Gekoppelt)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.H121).HasColumnName("H12_1");

                entity.Property(e => e.H122).HasColumnName("H12_2");

                entity.Property(e => e.H131).HasColumnName("H13_1");

                entity.Property(e => e.H132).HasColumnName("H13_2");

                entity.Property(e => e.KursId).HasColumnName("Kurs_ID");

                entity.Property(e => e.KursartAllg)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MdlBestPruefung)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MdlFreiwPruefung)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.MdlPflichtPruefung)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.P111)
                    .HasColumnName("P11_1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.P112)
                    .HasColumnName("P11_2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.P121)
                    .HasColumnName("P12_1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.P122)
                    .HasColumnName("P12_2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.P131)
                    .HasColumnName("P13_1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.P132)
                    .HasColumnName("P13_2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PFa)
                    .HasColumnName("P_FA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.R121)
                    .HasColumnName("R12_1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.R122)
                    .HasColumnName("R12_2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.R131)
                    .HasColumnName("R13_1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.R132)
                    .HasColumnName("R13_2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.RFa)
                    .HasColumnName("R_FA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.S111)
                    .HasColumnName("S11_1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.S112)
                    .HasColumnName("S11_2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.S121)
                    .HasColumnName("S12_1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.S122)
                    .HasColumnName("S12_2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.S131)
                    .HasColumnName("S13_1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.S132)
                    .HasColumnName("S13_2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.Property(e => e.W121).HasColumnName("W12_1");

                entity.Property(e => e.W122).HasColumnName("W12_2");

                entity.Property(e => e.W131).HasColumnName("W13_1");

                entity.Property(e => e.W132).HasColumnName("W13_2");

                entity.HasOne(d => d.Fach)
                    .WithMany(p => p.SchuelerAbiFaecher)
                    .HasForeignKey(d => d.FachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerAbiFaecher_Fach_FK");

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerAbiFaecher)
                    .HasForeignKey(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerAbiFaecher_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerAbitur>(entity =>
            {
                entity.HasIndex(e => e.SchuelerId)
                    .HasName("SchuelerAbitur_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnzDefGk).HasColumnName("AnzDefGK");

                entity.Property(e => e.AnzDefLk).HasColumnName("AnzDefLK");

                entity.Property(e => e.AnzRelGk).HasColumnName("AnzRelGK");

                entity.Property(e => e.AnzRelLk).HasColumnName("AnzRelLK");

                entity.Property(e => e.AnzRelOk).HasColumnName("AnzRelOK");

                entity.Property(e => e.AnzahlKurse0).HasColumnName("AnzahlKurse_0");

                entity.Property(e => e.BesondereLernleistung)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.BllArt)
                    .HasColumnName("BLL_Art")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('K')");

                entity.Property(e => e.BllPunkte).HasColumnName("BLL_Punkte");

                entity.Property(e => e.DefiziteI).HasColumnName("Defizite_I");

                entity.Property(e => e.DefiziteIi).HasColumnName("Defizite_II");

                entity.Property(e => e.DurchschnittI).HasColumnName("Durchschnitt_I");

                entity.Property(e => e.FaFach)
                    .HasColumnName("FA_Fach")
                    .HasMaxLength(130)
                    .IsUnicode(false);

                entity.Property(e => e.FaPunkte).HasColumnName("FA_Punkte");

                entity.Property(e => e.FranzBilingual)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Fs2SekIManuell)
                    .HasColumnName("FS2_SekI_manuell")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Graecum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Hebraicum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.KlLatinum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.KurseI).HasColumnName("Kurse_I");

                entity.Property(e => e.Latinum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.LkDefiziteI).HasColumnName("LK_Defizite_I");

                entity.Property(e => e.LkDefiziteIi).HasColumnName("LK_Defizite_II");

                entity.Property(e => e.Note)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PruefungBestanden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.PunktsummeI).HasColumnName("Punktsumme_I");

                entity.Property(e => e.PunktsummeIi).HasColumnName("Punktsumme_II");

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.Property(e => e.SummeGk).HasColumnName("SummeGK");

                entity.Property(e => e.SummeLk).HasColumnName("SummeLK");

                entity.Property(e => e.SummenOk).HasColumnName("SummenOK");

                entity.Property(e => e.ThemaBll)
                    .HasColumnName("Thema_BLL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ThemaPjk)
                    .HasColumnName("Thema_PJK")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UFehlStd).HasColumnName("uFehlStd");

                entity.Property(e => e.Zugelassen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.HasOne(d => d.Schueler)
                    .WithOne(p => p.SchuelerAbitur)
                    .HasForeignKey<SchuelerAbitur>(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerAbitur_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerAllgAdr>(entity =>
            {
                entity.ToTable("Schueler_AllgAdr");

                entity.HasIndex(e => e.SchuelerId)
                    .HasName("Schueler_AllgAdr_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdresseId).HasColumnName("Adresse_ID");

                entity.Property(e => e.AllgAdrAnschreiben)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.AnsprechpartnerId).HasColumnName("Ansprechpartner_ID");

                entity.Property(e => e.Ausbilder)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BetreuungslehrerId).HasColumnName("Betreuungslehrer_ID");

                entity.Property(e => e.Praktikum)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.Property(e => e.VertragsartId).HasColumnName("Vertragsart_ID");

                entity.Property(e => e.Vertragsbeginn).HasColumnType("smalldatetime");

                entity.Property(e => e.Vertragsende).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Adresse)
                    .WithMany(p => p.SchuelerAllgAdr)
                    .HasForeignKey(d => d.AdresseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerAllgAdr_Adresse_FK");

                entity.HasOne(d => d.Ansprechpartner)
                    .WithMany(p => p.SchuelerAllgAdr)
                    .HasForeignKey(d => d.AnsprechpartnerId)
                    .HasConstraintName("SchuelerAllgAdr_Ansprech_FK");

                entity.HasOne(d => d.Schueler)
                    .WithOne(p => p.SchuelerAllgAdr)
                    .HasForeignKey<SchuelerAllgAdr>(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerAllgAdr_Schueler_FK");

                entity.HasOne(d => d.Vertragsart)
                    .WithMany(p => p.SchuelerAllgAdr)
                    .HasForeignKey(d => d.VertragsartId)
                    .HasConstraintName("SchuelerAllgAdr_Beschaeftigungsart_FK");
            });

            modelBuilder.Entity<SchuelerAnkreuzfloskeln>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FloskelId).HasColumnName("Floskel_ID");

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.Property(e => e.Stufe1)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Stufe2)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Stufe3)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Stufe4)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Stufe5)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerAnkreuzfloskeln)
                    .HasForeignKey(d => d.SchuelerId)
                    .HasConstraintName("SchuelerAKF_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerBkabschluss>(entity =>
            {
                entity.HasKey(e => e.SchuelerId)
                    .HasName("SchuelerBKAbschluss_PK");

                entity.ToTable("SchuelerBKAbschluss");

                entity.Property(e => e.SchuelerId)
                    .HasColumnName("Schueler_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BapVorhanden)
                    .HasColumnName("BAP_Vorhanden")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bestanden)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BestandenBa)
                    .HasColumnName("BestandenBA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BestandenErwBk)
                    .HasColumnName("BestandenErwBK")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NoteFachpraxis)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NoteKolloquium)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PraktPrfNote)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ThemaAbschlussarbeit).HasColumnType("ntext");

                entity.Property(e => e.ZertifikatBk)
                    .HasColumnName("ZertifikatBK")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Zeugnis)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Zulassung)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZulassungBa)
                    .HasColumnName("ZulassungBA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ZulassungErwBk)
                    .HasColumnName("ZulassungErwBK")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Schueler)
                    .WithOne(p => p.SchuelerBkabschluss)
                    .HasForeignKey<SchuelerBkabschluss>(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerBKAbschl_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerBkfaecher>(entity =>
            {
                entity.ToTable("SchuelerBKFaecher");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FachId).HasColumnName("Fach_ID");

                entity.Property(e => e.FachKrz)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FachSchriftlich)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FachSchriftlichBa)
                    .HasColumnName("FachSchriftlichBA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fachlehrer)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fsortierung).HasColumnName("FSortierung");

                entity.Property(e => e.MdlPruefung)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MdlPruefungFw)
                    .HasColumnName("MdlPruefungFW")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NoteAbschluss)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NoteAbschlussBa)
                    .HasColumnName("NoteAbschlussBA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NoteMuendlich)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NotePrfGesamt)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NoteSchriftlich)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.Property(e => e.Vornote)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Fach)
                    .WithMany(p => p.SchuelerBkfaecher)
                    .HasForeignKey(d => d.FachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerBKFaecher_Fach_FK");

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerBkfaecher)
                    .HasForeignKey(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerBKFaecher_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerEinzelleistungen>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArtId).HasColumnName("Art_ID");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datum).HasColumnType("smalldatetime");

                entity.Property(e => e.LehrerId).HasColumnName("Lehrer_ID");

                entity.Property(e => e.LeistungId).HasColumnName("Leistung_ID");

                entity.Property(e => e.NotenKrz)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Art)
                    .WithMany(p => p.SchuelerEinzelleistungen)
                    .HasForeignKey(d => d.ArtId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SchuelerEL_Art_FK");
            });

            modelBuilder.Entity<SchuelerErzAdr>(entity =>
            {
                entity.HasIndex(e => e.SchuelerId)
                    .HasName("SchuelerErzAdr_IDX1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Anrede1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Anrede2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bemerkungen).HasColumnType("text");

                entity.Property(e => e.Erz1StaatKrz)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Erz1ZusatzNachname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Erz2StaatKrz)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Erz2ZusatzNachname)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ErzAdrZusatz)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErzAnschreiben)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.ErzBemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ErzEmail)
                    .HasColumnName("ErzEMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ErzEmail2)
                    .HasColumnName("ErzEMail2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ErzOrtsteilId).HasColumnName("ErzOrtsteil_ID");

                entity.Property(e => e.ErzPlz)
                    .HasColumnName("ErzPLZ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ErzStrasse)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErzieherArtId).HasColumnName("ErzieherArt_ID");

                entity.Property(e => e.Name1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.Property(e => e.Titel1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Titel2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Vorname2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ErzOrtsteil)
                    .WithMany(p => p.SchuelerErzAdr)
                    .HasForeignKey(d => d.ErzOrtsteilId)
                    .HasConstraintName("SchuelerErzAdr_Ortsteil_FK");

                entity.HasOne(d => d.ErzPlzNavigation)
                    .WithMany(p => p.SchuelerErzAdr)
                    .HasPrincipalKey(p => p.Plz)
                    .HasForeignKey(d => d.ErzPlz)
                    .HasConstraintName("SchuelerErzAdr_Ort_FK");

                entity.HasOne(d => d.ErzieherArt)
                    .WithMany(p => p.SchuelerErzAdr)
                    .HasForeignKey(d => d.ErzieherArtId)
                    .HasConstraintName("SchuelerErzAdr_ErzieherArt_FK");

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerErzAdr)
                    .HasForeignKey(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerErzAdr_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerErzFunktion>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErzieherId).HasColumnName("Erzieher_ID");

                entity.Property(e => e.FunktionId).HasColumnName("Funktion_ID");

                entity.Property(e => e.Klasse)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Erzieher)
                    .WithMany(p => p.SchuelerErzFunktion)
                    .HasForeignKey(d => d.ErzieherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerErzFunktion_Erzieher_FK");

                entity.HasOne(d => d.Funktion)
                    .WithMany(p => p.SchuelerErzFunktion)
                    .HasForeignKey(d => d.FunktionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerErzFunktion_Funktion_FK");
            });

            modelBuilder.Entity<SchuelerFehlstunden>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbschnittId).HasColumnName("Abschnitt_ID");

                entity.Property(e => e.Datum).HasColumnType("smalldatetime");

                entity.Property(e => e.Entschuldigt)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FachId).HasColumnName("Fach_ID");

                entity.Property(e => e.LehrerId).HasColumnName("Lehrer_ID");

                entity.HasOne(d => d.Abschnitt)
                    .WithMany(p => p.SchuelerFehlstunden)
                    .HasForeignKey(d => d.AbschnittId)
                    .HasConstraintName("SchuelerFehlstunden_Abschnitt_FK");
            });

            modelBuilder.Entity<SchuelerFhr>(entity =>
            {
                entity.ToTable("SchuelerFHR");

                entity.HasIndex(e => e.SchuelerId)
                    .HasName("SchuelerFHR_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnzDefGk).HasColumnName("AnzDefGK");

                entity.Property(e => e.AnzDefLk).HasColumnName("AnzDefLK");

                entity.Property(e => e.AnzDefOk).HasColumnName("AnzDefOK");

                entity.Property(e => e.AnzRelGk).HasColumnName("AnzRelGK");

                entity.Property(e => e.AnzRelLk).HasColumnName("AnzRelLK");

                entity.Property(e => e.AnzRelOk).HasColumnName("AnzRelOK");

                entity.Property(e => e.Asii21).HasColumnName("ASII_2_1");

                entity.Property(e => e.Asii21W).HasColumnName("ASII_2_1_W");

                entity.Property(e => e.Asii22).HasColumnName("ASII_2_2");

                entity.Property(e => e.Asii22W).HasColumnName("ASII_2_2_W");

                entity.Property(e => e.Asii31).HasColumnName("ASII_3_1");

                entity.Property(e => e.Asii31W).HasColumnName("ASII_3_1_W");

                entity.Property(e => e.Asii32).HasColumnName("ASII_3_2");

                entity.Property(e => e.Asii32W).HasColumnName("ASII_3_2_W");

                entity.Property(e => e.Fhrerreicht)
                    .HasColumnName("FHRErreicht")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Jsii21).HasColumnName("JSII_2_1");

                entity.Property(e => e.Jsii21W).HasColumnName("JSII_2_1_W");

                entity.Property(e => e.Jsii22).HasColumnName("JSII_2_2");

                entity.Property(e => e.Jsii22W).HasColumnName("JSII_2_2_W");

                entity.Property(e => e.Jsii31).HasColumnName("JSII_3_1");

                entity.Property(e => e.Jsii31W).HasColumnName("JSII_3_1_W");

                entity.Property(e => e.Jsii32).HasColumnName("JSII_3_2");

                entity.Property(e => e.Jsii32W).HasColumnName("JSII_3_2_W");

                entity.Property(e => e.Note)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.Property(e => e.SummeGk).HasColumnName("SummeGK");

                entity.Property(e => e.SummeLk).HasColumnName("SummeLK");

                entity.Property(e => e.SummenOk).HasColumnName("SummenOK");

                entity.Property(e => e.Wsii21)
                    .HasColumnName("WSII_2_1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Wsii21W)
                    .HasColumnName("WSII_2_1_W")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Wsii22)
                    .HasColumnName("WSII_2_2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Wsii22W)
                    .HasColumnName("WSII_2_2_W")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Wsii31)
                    .HasColumnName("WSII_3_1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Wsii31W)
                    .HasColumnName("WSII_3_1_W")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Wsii32)
                    .HasColumnName("WSII_3_2")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Wsii32W)
                    .HasColumnName("WSII_3_2_W")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Schueler)
                    .WithOne(p => p.SchuelerFhr)
                    .HasForeignKey<SchuelerFhr>(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerFHR_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerFhrfaecher>(entity =>
            {
                entity.ToTable("SchuelerFHRFaecher");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FachId).HasColumnName("Fach_ID");

                entity.Property(e => e.FachKrz)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fsortierung).HasColumnName("FSortierung");

                entity.Property(e => e.Hsii21).HasColumnName("HSII_2_1");

                entity.Property(e => e.Hsii21W).HasColumnName("HSII_2_1_W");

                entity.Property(e => e.Hsii22).HasColumnName("HSII_2_2");

                entity.Property(e => e.Hsii22W).HasColumnName("HSII_2_2_W");

                entity.Property(e => e.Hsii31).HasColumnName("HSII_3_1");

                entity.Property(e => e.Hsii31W).HasColumnName("HSII_3_1_W");

                entity.Property(e => e.Hsii32).HasColumnName("HSII_3_2");

                entity.Property(e => e.Hsii32W).HasColumnName("HSII_3_2_W");

                entity.Property(e => e.Ksii21)
                    .HasColumnName("KSII_2_1")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ksii21W)
                    .HasColumnName("KSII_2_1_W")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ksii22)
                    .HasColumnName("KSII_2_2")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ksii22W)
                    .HasColumnName("KSII_2_2_W")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ksii31)
                    .HasColumnName("KSII_3_1")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ksii31W)
                    .HasColumnName("KSII_3_1_W")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ksii32)
                    .HasColumnName("KSII_3_2")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ksii32W)
                    .HasColumnName("KSII_3_2_W")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.KursartAllg)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Psii21)
                    .HasColumnName("PSII_2_1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Psii21W)
                    .HasColumnName("PSII_2_1_W")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Psii22)
                    .HasColumnName("PSII_2_2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Psii22W)
                    .HasColumnName("PSII_2_2_W")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Psii31)
                    .HasColumnName("PSII_3_1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Psii31W)
                    .HasColumnName("PSII_3_1_W")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Psii32)
                    .HasColumnName("PSII_3_2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Psii32W)
                    .HasColumnName("PSII_3_2_W")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Rsii21)
                    .HasColumnName("RSII_2_1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Rsii21W)
                    .HasColumnName("RSII_2_1_W")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Rsii22)
                    .HasColumnName("RSII_2_2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Rsii22W)
                    .HasColumnName("RSII_2_2_W")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Rsii31)
                    .HasColumnName("RSII_3_1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Rsii31W)
                    .HasColumnName("RSII_3_1_W")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Rsii32)
                    .HasColumnName("RSII_3_2")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Rsii32W)
                    .HasColumnName("RSII_3_2_W")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.HasOne(d => d.Fach)
                    .WithMany(p => p.SchuelerFhrfaecher)
                    .HasForeignKey(d => d.FachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerFHRFaecher_Fach_FK");

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerFhrfaecher)
                    .HasForeignKey(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerFHRFaecher_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerFoerderempfehlungen>(entity =>
            {
                entity.HasKey(e => e.GuId)
                    .HasName("SchuelerFoerderempfehlungen_PK");

                entity.Property(e => e.GuId)
                    .HasColumnName("GU_ID")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Abgeschlossen)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.DatumAenderungSchild).HasColumnType("smalldatetime");

                entity.Property(e => e.DatumAenderungSchildWeb).HasColumnType("smalldatetime");

                entity.Property(e => e.DatumAngelegt).HasColumnType("smalldatetime");

                entity.Property(e => e.EingabeFertig)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.FachId).HasColumnName("Fach_ID");

                entity.Property(e => e.Faecher)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InhaltlProzessbezKomp)
                    .HasColumnName("Inhaltl_Prozessbez_Komp")
                    .HasColumnType("text");

                entity.Property(e => e.Klasse)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Kurs)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KursId).HasColumnName("Kurs_ID");

                entity.Property(e => e.LehrerId).HasColumnName("Lehrer_ID");

                entity.Property(e => e.LeistungId).HasColumnName("Leistung_ID");

                entity.Property(e => e.LernArbeitsverhalten)
                    .HasColumnName("Lern_Arbeitsverhalten")
                    .HasColumnType("text");

                entity.Property(e => e.MassnInhaltlProzessbezKomp)
                    .HasColumnName("Massn_Inhaltl_Prozessbez_Komp")
                    .HasColumnType("text");

                entity.Property(e => e.MassnLernArbeitsverhalten)
                    .HasColumnName("Massn_Lern_Arbeitsverhalten")
                    .HasColumnType("text");

                entity.Property(e => e.MassnMethodischeKomp)
                    .HasColumnName("Massn_Methodische_Komp")
                    .HasColumnType("text");

                entity.Property(e => e.MethodischeKomp)
                    .HasColumnName("Methodische_Komp")
                    .HasColumnType("text");

                entity.Property(e => e.NaechstesBeratungsgespraech)
                    .HasColumnName("Naechstes_Beratungsgespraech")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.Property(e => e.UeberpruefungDatum)
                    .HasColumnName("Ueberpruefung_Datum")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.VerantwortlichkeitEltern)
                    .HasColumnName("Verantwortlichkeit_Eltern")
                    .HasColumnType("text");

                entity.Property(e => e.VerantwortlichkeitSchueler)
                    .HasColumnName("Verantwortlichkeit_Schueler")
                    .HasColumnType("text");

                entity.Property(e => e.ZeitrahmenBisDatum)
                    .HasColumnName("Zeitrahmen_bis_Datum")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ZeitrahmenVonDatum)
                    .HasColumnName("Zeitrahmen_von_Datum")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerFoerderempfehlungen)
                    .HasForeignKey(d => d.SchuelerId)
                    .HasConstraintName("SchuelerFE_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerFotos>(entity =>
            {
                entity.HasKey(e => e.SchuelerId)
                    .HasName("SchuelerFotos_PK");

                entity.Property(e => e.SchuelerId)
                    .HasColumnName("Schueler_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.HasOne(d => d.Schueler)
                    .WithOne(p => p.SchuelerFotos)
                    .HasForeignKey<SchuelerFotos>(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerFotos_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerGsdaten>(entity =>
            {
                entity.HasKey(e => e.SchuelerId)
                    .HasName("SchuelerGSDaten_PK");

                entity.ToTable("SchuelerGSDaten");

                entity.Property(e => e.SchuelerId)
                    .HasColumnName("Schueler_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnredeKlassenlehrer)
                    .HasColumnName("Anrede_Klassenlehrer")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bemerkungen).HasColumnType("text");

                entity.Property(e => e.DurchschnittsnoteEinfach).HasColumnName("Durchschnittsnote_Einfach");

                entity.Property(e => e.DurchschnittsnoteGewichtet).HasColumnName("Durchschnittsnote_Gewichtet");

                entity.Property(e => e.DurchschnittsnoteSprache).HasColumnName("Durchschnittsnote_Sprache");

                entity.Property(e => e.Geschwisterkind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.GsKlasse)
                    .HasColumnName("GS_Klasse")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NachnameKlassenlehrer)
                    .HasColumnName("Nachname_Klassenlehrer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoteEnglisch).HasColumnName("Note_Englisch");

                entity.Property(e => e.NoteKunstTextil).HasColumnName("Note_KunstTextil");

                entity.Property(e => e.NoteLesen).HasColumnName("Note_Lesen");

                entity.Property(e => e.NoteMathematik).HasColumnName("Note_Mathematik");

                entity.Property(e => e.NoteMusik).HasColumnName("Note_Musik");

                entity.Property(e => e.NoteRechtschreiben).HasColumnName("Note_Rechtschreiben");

                entity.Property(e => e.NoteReligion).HasColumnName("Note_Religion");

                entity.Property(e => e.NoteSachunterricht).HasColumnName("Note_Sachunterricht");

                entity.Property(e => e.NoteSport).HasColumnName("Note_Sport");

                entity.Property(e => e.NoteSprachgebrauch).HasColumnName("Note_Sprachgebrauch");
            });

            modelBuilder.Entity<SchuelerLdPsfachBem>(entity =>
            {
                entity.ToTable("SchuelerLD_PSFachBem");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbschnittId).HasColumnName("Abschnitt_ID");

                entity.Property(e => e.Asv)
                    .HasColumnName("ASV")
                    .HasColumnType("ntext");

                entity.Property(e => e.Esf)
                    .HasColumnName("ESF")
                    .HasColumnType("ntext");

                entity.Property(e => e.Lels)
                    .HasColumnName("LELS")
                    .HasColumnType("ntext");

                entity.HasOne(d => d.Abschnitt)
                    .WithMany(p => p.SchuelerLdPsfachBem)
                    .HasForeignKey(d => d.AbschnittId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerLD_PSFachBem_Abschnitt_FK");
            });

            modelBuilder.Entity<SchuelerLeistungsdaten>(entity =>
            {
                entity.HasIndex(e => new { e.AbschnittId, e.FachId, e.Kursart, e.KursId })
                    .HasName("SchuelerLeistungsdaten_IDX2")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbiFach)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AbiZeugnis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.AbschlussJahrgang)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AbschnittId).HasColumnName("Abschnitt_ID");

                entity.Property(e => e.AufZeugnis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.FachId).HasColumnName("Fach_ID");

                entity.Property(e => e.FachLehrer)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Gekoppelt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Gewichtung).HasDefaultValueSql("((1))");

                entity.Property(e => e.HochrechnungStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KursId).HasColumnName("Kurs_ID");

                entity.Property(e => e.Kursart)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.KursartAllg)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Lernentw).HasColumnType("ntext");

                entity.Property(e => e.NoteAbschlussBa)
                    .HasColumnName("NoteAbschlussBA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NotenKrz)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Prf10Fach)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Prognose)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.UFehlstd).HasColumnName("uFehlstd");

                entity.Property(e => e.VorherAbgeschl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Warndatum).HasColumnType("smalldatetime");

                entity.Property(e => e.Warnung)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Zusatzkraft)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Abschnitt)
                    .WithMany(p => p.SchuelerLeistungsdaten)
                    .HasForeignKey(d => d.AbschnittId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerLeistungsdaten_Abschnitt_FK");

                entity.HasOne(d => d.Fach)
                    .WithMany(p => p.SchuelerLeistungsdaten)
                    .HasForeignKey(d => d.FachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerLeistungsdaten_Fach_FK");

                entity.HasOne(d => d.Kurs)
                    .WithMany(p => p.SchuelerLeistungsdaten)
                    .HasForeignKey(d => d.KursId)
                    .HasConstraintName("SchuelerLeistungsdaten_Kurs_FK");
            });

            modelBuilder.Entity<SchuelerLernabschnittsdaten>(entity =>
            {
                entity.HasIndex(e => new { e.SchuelerId, e.Jahr, e.Abschnitt, e.Bildungsgang, e.WechselNr })
                    .HasName("SchuelerLernabschnittsdaten_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbschlIstPrognose)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.Abschluss)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AbschlussB)
                    .HasColumnName("Abschluss_B")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Asdjahrgang)
                    .HasColumnName("ASDJahrgang")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Asdschulgliederung)
                    .HasColumnName("ASDSchulgliederung")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AvLeist).HasColumnName("AV_Leist");

                entity.Property(e => e.AvSelbst).HasColumnName("AV_Selbst");

                entity.Property(e => e.AvZuv).HasColumnName("AV_Zuv");

                entity.Property(e => e.Bildungsgang)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DatumBis).HasColumnType("smalldatetime");

                entity.Property(e => e.DatumFhr)
                    .HasColumnName("DatumFHR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatumVon).HasColumnType("smalldatetime");

                entity.Property(e => e.Dsnote)
                    .HasColumnName("DSNote")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FachklasseId).HasColumnName("Fachklasse_ID");

                entity.Property(e => e.Foerderschwerpunkt2Id).HasColumnName("Foerderschwerpunkt2_ID");

                entity.Property(e => e.FoerderschwerpunktId).HasColumnName("Foerderschwerpunkt_ID");

                entity.Property(e => e.Folgeklasse)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GesamtnoteGs).HasColumnName("Gesamtnote_GS");

                entity.Property(e => e.GesamtnoteNw).HasColumnName("Gesamtnote_NW");

                entity.Property(e => e.JahrgangId).HasColumnName("Jahrgang_ID");

                entity.Property(e => e.Klasse)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.KlassenLehrer)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Klassenart)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.KnLehrer)
                    .HasColumnName("KN_Lehrer")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Konferenzdatum).HasColumnType("smalldatetime");

                entity.Property(e => e.MoeglNpfaecher)
                    .HasColumnName("MoeglNPFaecher")
                    .HasColumnType("ntext");

                entity.Property(e => e.NpaaDatum)
                    .HasColumnName("NPAA_Datum")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NpaaFachId).HasColumnName("NPAA_Fach_ID");

                entity.Property(e => e.NpaaNoteKrz)
                    .HasColumnName("NPAA_NoteKrz")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NpbqDatum)
                    .HasColumnName("NPBQ_Datum")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NpbqFachId).HasColumnName("NPBQ_Fach_ID");

                entity.Property(e => e.NpbqNoteKrz)
                    .HasColumnName("NPBQ_NoteKrz")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NpvDatum)
                    .HasColumnName("NPV_Datum")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NpvFachId).HasColumnName("NPV_Fach_ID");

                entity.Property(e => e.NpvNoteKrz)
                    .HasColumnName("NPV_NoteKrz")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrgFormKrz)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PruefAlgoErgebnis).HasColumnType("text");

                entity.Property(e => e.PruefOrdnung)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RefPaed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.Property(e => e.Schwerbehinderung)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.SchwerpunktId).HasColumnName("Schwerpunkt_ID");

                entity.Property(e => e.SemesterWertung)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.StvKlassenlehrerId).HasColumnName("StvKlassenlehrer_ID");

                entity.Property(e => e.SvKonfl).HasColumnName("SV_Konfl");

                entity.Property(e => e.SvKoop).HasColumnName("SV_Koop");

                entity.Property(e => e.SvVerant).HasColumnName("SV_Verant");

                entity.Property(e => e.VersetzungKrz)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Wiederholung)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Zertifikate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ZeugnisBem).HasColumnType("ntext");

                entity.Property(e => e.ZeugnisDatum).HasColumnType("smalldatetime");

                entity.Property(e => e.Zeugnisart)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Fachklasse)
                    .WithMany(p => p.SchuelerLernabschnittsdaten)
                    .HasForeignKey(d => d.FachklasseId)
                    .HasConstraintName("SchuelerLernabschnittsdaten_Fachklasse_FK");

                entity.HasOne(d => d.Foerderschwerpunkt)
                    .WithMany(p => p.SchuelerLernabschnittsdaten)
                    .HasForeignKey(d => d.FoerderschwerpunktId)
                    .HasConstraintName("SchuelerLernabschnittsdaten_Foerderschwerpunkt_FK");

                entity.HasOne(d => d.JahrgangNavigation)
                    .WithMany(p => p.SchuelerLernabschnittsdaten)
                    .HasForeignKey(d => d.JahrgangId)
                    .HasConstraintName("SchuelerLernabschnittsdaten_Jahrgang_FK");

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerLernabschnittsdaten)
                    .HasForeignKey(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerLernabschnittsdaten_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerListe>(entity =>
            {
                entity.HasIndex(e => e.Bezeichnung)
                    .HasName("SchuelerListe_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Erzeuger)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Privat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");
            });

            modelBuilder.Entity<SchuelerListeInhalt>(entity =>
            {
                entity.HasKey(e => new { e.ListeId, e.SchuelerId })
                    .HasName("SchuelerListeInhalt_PK");

                entity.ToTable("SchuelerListe_Inhalt");

                entity.Property(e => e.ListeId).HasColumnName("Liste_ID");

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.HasOne(d => d.Liste)
                    .WithMany(p => p.SchuelerListeInhalt)
                    .HasForeignKey(d => d.ListeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerListeInhalt_Liste_FK");

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerListeInhalt)
                    .HasForeignKey(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerListeInhalt_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerNuesdaten>(entity =>
            {
                entity.ToTable("SchuelerNUESDaten");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Hauptmerkmal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JahrgangIst)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Nebenmerkmal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerNuesdaten)
                    .HasForeignKey(d => d.SchuelerId)
                    .HasConstraintName("SchuelerNUESDaten_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerSprachenfolge>(entity =>
            {
                entity.HasIndex(e => new { e.SchuelerId, e.FachId })
                    .HasName("SchuelerSprachenfolge_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FachId).HasColumnName("Fach_ID");

                entity.Property(e => e.Referenzniveau)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Reihenfolge)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.HasOne(d => d.Fach)
                    .WithMany(p => p.SchuelerSprachenfolge)
                    .HasForeignKey(d => d.FachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerSprachenfolge_Fach_FK");

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerSprachenfolge)
                    .HasForeignKey(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerSprachenfolge_Schueler_FK");
            });

            modelBuilder.Entity<SchuelerTelefone>(entity =>
            {
                entity.HasIndex(e => e.SchuelerId)
                    .HasName("SchuelerTelefone_IDX1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gesperrt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.TelefonArtId).HasColumnName("TelefonArt_ID");

                entity.Property(e => e.Telefonnummer)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerTelefone)
                    .HasForeignKey(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerTelefone_Schueler_FK");

                entity.HasOne(d => d.TelefonArt)
                    .WithMany(p => p.SchuelerTelefone)
                    .HasForeignKey(d => d.TelefonArtId)
                    .HasConstraintName("SchuelerTelefone_Telefonart_FK");
            });

            modelBuilder.Entity<SchuelerVermerke>(entity =>
            {
                entity.HasIndex(e => e.SchuelerId)
                    .HasName("SchuelerVermerke_IDX1");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AngelegtVon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Bemerkung).HasColumnType("ntext");

                entity.Property(e => e.Datum).HasColumnType("smalldatetime");

                entity.Property(e => e.GeaendertVon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.Property(e => e.VermerkArtId).HasColumnName("VermerkArt_ID");

                entity.HasOne(d => d.Schueler)
                    .WithMany(p => p.SchuelerVermerke)
                    .HasForeignKey(d => d.SchuelerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SchuelerVermerke_Schueler_FK");

                entity.HasOne(d => d.VermerkArt)
                    .WithMany(p => p.SchuelerVermerke)
                    .HasForeignKey(d => d.VermerkArtId)
                    .HasConstraintName("SchuelerVermerke_VermerkArt_FK");
            });

            modelBuilder.Entity<SchuelerWiedervorlage>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AngelegtAm).HasColumnType("smalldatetime");

                entity.Property(e => e.Bemerkung)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ErledigtAm).HasColumnType("smalldatetime");

                entity.Property(e => e.NichtLoeschen)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SchuelerId).HasColumnName("Schueler_ID");

                entity.Property(e => e.Sekretariat)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Typ)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.WiedervorlageAm).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SchuelerZuweisungen>(entity =>
            {
                entity.HasKey(e => new { e.AbschnittId, e.FachId })
                    .HasName("SchuelerZuweisungen_PK");

                entity.Property(e => e.AbschnittId).HasColumnName("Abschnitt_ID");

                entity.Property(e => e.FachId).HasColumnName("Fach_ID");

                entity.Property(e => e.Kursart)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Abschnitt)
                    .WithMany(p => p.SchuelerZuweisungen)
                    .HasForeignKey(d => d.AbschnittId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Zuweisungen_Abschnitt_FK");
            });

            modelBuilder.Entity<Stundentafel>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Asdjahrgang)
                    .HasColumnName("ASDJahrgang")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Bezeichnung)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FachklasseId).HasColumnName("Fachklasse_ID");

                entity.Property(e => e.JahrgangId).HasColumnName("Jahrgang_ID");

                entity.Property(e => e.Klasse)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Sgl)
                    .HasColumnName("SGL")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");
            });

            modelBuilder.Entity<StundentafelFaecher>(entity =>
            {
                entity.ToTable("Stundentafel_Faecher");

                entity.HasIndex(e => new { e.StundentafelId, e.FachId })
                    .HasName("Stundentafel_Faecher_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EpochenUnterricht)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.FachId).HasColumnName("Fach_ID");

                entity.Property(e => e.Gewichtung).HasDefaultValueSql("((1))");

                entity.Property(e => e.KursartAllg)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LehrerKrz)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.StundentafelId).HasColumnName("Stundentafel_ID");

                entity.HasOne(d => d.Fach)
                    .WithMany(p => p.StundentafelFaecher)
                    .HasForeignKey(d => d.FachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("StundentafelFaecher_Faecher_FK");

                entity.HasOne(d => d.Stundentafel)
                    .WithMany(p => p.StundentafelFaecher)
                    .HasForeignKey(d => d.StundentafelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("StundentafelFaecher_Stdtafel_FK");
            });

            modelBuilder.Entity<TextExportVorlagen>(entity =>
            {
                entity.HasKey(e => new { e.SchulnrEigner, e.VorlageName })
                    .HasName("TextExportVorlagen_PK");

                entity.Property(e => e.VorlageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Daten).HasColumnType("text");
            });

            modelBuilder.Entity<Usergroups>(entity =>
            {
                entity.HasKey(e => e.UgId)
                    .HasName("Usergroups_PK");

                entity.HasIndex(e => e.UgBezeichnung)
                    .HasName("Usergroups_IX1")
                    .IsUnique();

                entity.Property(e => e.UgId)
                    .HasColumnName("UG_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.UgBezeichnung)
                    .HasColumnName("UG_Bezeichnung")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.UgKompetenzen)
                    .HasColumnName("UG_Kompetenzen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UgNr).HasColumnName("UG_Nr");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.UsLoginName)
                    .HasName("Users_IX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailName)
                    .HasColumnName("EMailName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSignature)
                    .HasColumnName("EMailSignature")
                    .HasColumnType("text");

                entity.Property(e => e.Smtppassword)
                    .HasColumnName("SMTPPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Smtpusername)
                    .HasColumnName("SMTPUsername")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsLoginName)
                    .IsRequired()
                    .HasColumnName("US_LoginName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsName)
                    .IsRequired()
                    .HasColumnName("US_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsPassword)
                    .HasColumnName("US_Password")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsPasswordHash)
                    .HasColumnName("US_PasswordHash")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UsPrivileges)
                    .HasColumnName("US_Privileges")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UsUserGroups)
                    .HasColumnName("US_UserGroups")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Versetzung>(entity =>
            {
                entity.HasIndex(e => e.Klasse)
                    .HasName("Versetzung_IDX1")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdrMerkmal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Ankreuzzeugnisse)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Asdklasse)
                    .HasColumnName("ASDKlasse")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AsdschulformNr)
                    .HasColumnName("ASDSchulformNr")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Bezeichnung)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FachklasseId).HasColumnName("Fachklasse_ID");

                entity.Property(e => e.Fklasse)
                    .HasColumnName("FKlasse")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.JahrgangId).HasColumnName("Jahrgang_ID");

                entity.Property(e => e.Klasse)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Klassenart)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.KlassenlehrerKrz)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.KoopKlasse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.NotenGesperrt)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrgFormKrz)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PruefOrdnung)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sichtbar)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('+')");

                entity.Property(e => e.SommerSem)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sortierung).HasDefaultValueSql("((32000))");

                entity.Property(e => e.StvKlassenlehrerKrz)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vklasse)
                    .HasColumnName("VKlasse")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WebNotenGesperrt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-')");

                entity.HasOne(d => d.KlassenlehrerKrzNavigation)
                    .WithMany(p => p.Versetzung)
                    .HasPrincipalKey(p => p.Kuerzel)
                    .HasForeignKey(d => d.KlassenlehrerKrz)
                    .HasConstraintName("Versetzung_Lehrer_FK");
            });

            modelBuilder.Entity<ZuordnungReportvorlagen>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Abschluss)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AbschlussBb)
                    .HasColumnName("AbschlussBB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Beschreibung)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FachklasseId).HasColumnName("Fachklasse_ID");

                entity.Property(e => e.Gruppe)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JahrgangId).HasColumnName("Jahrgang_ID");

                entity.Property(e => e.Reportvorlage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VersetzungKrz)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Zeugnisart)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Query<LehrerLehramtLehrbef>();
            modelBuilder.Query<EigeneSchule>();
        }
    }
}
