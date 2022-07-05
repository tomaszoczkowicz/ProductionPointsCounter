using Microsoft.EntityFrameworkCore;

namespace ProductionPointsCounterAPI.Entities
{
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Oferty> Oferties { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:ProductionConnectionString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oferty>(entity =>
            {
                entity.HasKey(e => e.Indeks)
                    .HasName("PK__oferty__E729A49D7940E202");

                entity.ToTable("oferty");

                entity.HasIndex(e => e.Autok, "Autok");

                entity.HasIndex(e => e.AutokT, "Autok_t");

                entity.HasIndex(e => e.Oferta, "Oferta");

                entity.HasIndex(e => e.OfertaT, "Oferta_t");

                entity.HasIndex(e => e.Optym, "Optym");

                entity.HasIndex(e => e.OptymT, "Optym_t");

                entity.HasIndex(e => e.Status, "Status");

                entity.HasIndex(e => e.Zamow, "Zamow");

                entity.HasIndex(e => e.ZamowT, "Zamow_t");

                entity.HasIndex(e => e.Zlecenie, "Zlecenie");

                entity.HasIndex(e => e.ZlecenieT, "Zlecenie_t");

                entity.HasIndex(e => new { e.Status, e.Realizacja, e.DoArch, e.IlJedn }, "hind_11_695009557__k23_k32_k21_k39");

                entity.HasIndex(e => new { e.Realizacja, e.DoArch }, "hind_11_695009557__k32_k21");

                entity.Property(e => e.Indeks)
                    .ValueGeneratedNever()
                    .HasColumnName("indeks");

                entity.Property(e => e.AdrDostaw).HasColumnName("adr_dostaw");

                entity.Property(e => e.AokUtworz)
                    .HasColumnType("datetime")
                    .HasColumnName("aok_utworz");

                entity.Property(e => e.Autok).HasColumnName("autok");

                entity.Property(e => e.AutokT)
                    .HasMaxLength(25)
                    .HasColumnName("autok_t");

                entity.Property(e => e.Autor)
                    .HasMaxLength(128)
                    .HasColumnName("autor");

                entity.Property(e => e.Bdemontaz)
                    .HasColumnType("numeric(12, 2)")
                    .HasColumnName("bdemontaz");

                entity.Property(e => e.Bmontaz)
                    .HasColumnType("numeric(12, 2)")
                    .HasColumnName("bmontaz");

                entity.Property(e => e.Bwykon)
                    .HasColumnType("numeric(12, 2)")
                    .HasColumnName("bwykon");

                entity.Property(e => e.Caninvdat)
                    .HasColumnType("datetime")
                    .HasColumnName("caninvdat");

                entity.Property(e => e.Caninvoic).HasColumnName("caninvoic");

                entity.Property(e => e.Data)
                    .HasColumnType("image")
                    .HasColumnName("data");

                entity.Property(e => e.DataAlu)
                    .HasColumnType("datetime")
                    .HasColumnName("data_alu");

                entity.Property(e => e.DataBazy)
                    .HasColumnType("datetime")
                    .HasColumnName("data_bazy");

                entity.Property(e => e.DataDodat)
                    .HasColumnType("datetime")
                    .HasColumnName("data_dodat");

                entity.Property(e => e.DataOdb)
                    .HasColumnType("datetime")
                    .HasColumnName("data_odb");

                entity.Property(e => e.DataOrg)
                    .HasColumnType("image")
                    .HasColumnName("data_org");

                entity.Property(e => e.DataTran)
                    .HasColumnType("datetime")
                    .HasColumnName("data_tran");

                entity.Property(e => e.DataUmowy)
                    .HasColumnType("datetime")
                    .HasColumnName("data_umowy");

                entity.Property(e => e.DataZak)
                    .HasColumnType("datetime")
                    .HasColumnName("data_zak");

                entity.Property(e => e.Datakcept)
                    .HasColumnType("datetime")
                    .HasColumnName("datakcept");

                entity.Property(e => e.Dealer)
                    .HasMaxLength(15)
                    .HasColumnName("dealer");

                entity.Property(e => e.Dealerskie).HasColumnName("dealerskie");

                entity.Property(e => e.Deffered).HasColumnName("deffered");

                entity.Property(e => e.Dkolory)
                    .HasMaxLength(128)
                    .HasColumnName("dkolory");

                entity.Property(e => e.DoArch).HasColumnName("do_arch");

                entity.Property(e => e.DoWysylki).HasColumnName("do_wysylki");

                entity.Property(e => e.Docid).HasColumnName("docid");

                entity.Property(e => e.Doplata)
                    .HasColumnType("numeric(12, 2)")
                    .HasColumnName("doplata");

                entity.Property(e => e.Dsystemy)
                    .HasMaxLength(128)
                    .HasColumnName("dsystemy");

                entity.Property(e => e.Dtypy)
                    .HasMaxLength(128)
                    .HasColumnName("dtypy");

                entity.Property(e => e.Dyble)
                    .HasMaxLength(50)
                    .HasColumnName("dyble");

                entity.Property(e => e.Eflags).HasColumnName("eflags");

                entity.Property(e => e.Grupasub)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("grupasub")
                    .IsFixedLength();

                entity.Property(e => e.IlJedn)
                    .HasColumnType("numeric(12, 5)")
                    .HasColumnName("il_jedn");

                entity.Property(e => e.IlJedn1)
                    .HasColumnType("numeric(12, 5)")
                    .HasColumnName("il_jedn1");

                entity.Property(e => e.IlJedn2)
                    .HasColumnType("numeric(12, 5)")
                    .HasColumnName("il_jedn2");

                entity.Property(e => e.IlJedn3)
                    .HasColumnType("numeric(12, 5)")
                    .HasColumnName("il_jedn3");

                entity.Property(e => e.IlJedn4)
                    .HasColumnType("numeric(12, 5)")
                    .HasColumnName("il_jedn4");

                entity.Property(e => e.IlJedn5)
                    .HasColumnType("numeric(12, 5)")
                    .HasColumnName("il_jedn5");

                entity.Property(e => e.IlJedn6)
                    .HasColumnType("numeric(12, 5)")
                    .HasColumnName("il_jedn6");

                entity.Property(e => e.IlJedn7)
                    .HasColumnType("numeric(12, 5)")
                    .HasColumnName("il_jedn7");

                entity.Property(e => e.IlJedn8)
                    .HasColumnType("numeric(12, 5)")
                    .HasColumnName("il_jedn8");

                entity.Property(e => e.IlOsc).HasColumnName("il_osc");

                entity.Property(e => e.IlPoz).HasColumnName("il_poz");

                entity.Property(e => e.IlSkr).HasColumnName("il_skr");

                entity.Property(e => e.IlSzk).HasColumnName("il_szk");

                entity.Property(e => e.Invceddat)
                    .HasColumnType("datetime")
                    .HasColumnName("invceddat");

                entity.Property(e => e.Invdatpay)
                    .HasColumnType("datetime")
                    .HasColumnName("invdatpay");

                entity.Property(e => e.Invoiced).HasColumnName("invoiced");

                entity.Property(e => e.Invoicenr)
                    .HasMaxLength(25)
                    .HasColumnName("invoicenr");

                entity.Property(e => e.Invoipaid).HasColumnName("invoipaid");

                entity.Property(e => e.Kolor).HasColumnName("kolor");

                entity.Property(e => e.KolorOfer)
                    .HasMaxLength(256)
                    .HasColumnName("kolor_ofer");

                entity.Property(e => e.Kontakt).HasColumnName("kontakt");

                entity.Property(e => e.LastCheck)
                    .HasColumnType("datetime")
                    .HasColumnName("last_check");

                entity.Property(e => e.Lastmodyf)
                    .HasMaxLength(128)
                    .HasColumnName("lastmodyf");

                entity.Property(e => e.Modyf)
                    .HasColumnType("datetime")
                    .HasColumnName("modyf");

                entity.Property(e => e.MontazKto)
                    .HasMaxLength(50)
                    .HasColumnName("montaz_kto");

                entity.Property(e => e.NajstWyc)
                    .HasColumnType("datetime")
                    .HasColumnName("najst_wyc");

                entity.Property(e => e.NazwaZew2)
                    .HasMaxLength(25)
                    .HasColumnName("nazwa_zew2");

                entity.Property(e => e.NazwaZewn)
                    .HasMaxLength(25)
                    .HasColumnName("nazwa_zewn");

                entity.Property(e => e.Netto)
                    .HasColumnType("numeric(12, 2)")
                    .HasColumnName("netto");

                entity.Property(e => e.NettoM)
                    .HasColumnType("numeric(12, 2)")
                    .HasColumnName("netto_m");

                entity.Property(e => e.NettoT)
                    .HasColumnType("numeric(12, 2)")
                    .HasColumnName("netto_t");

                entity.Property(e => e.New).HasColumnName("new");

                entity.Property(e => e.Notes)
                    .HasColumnType("image")
                    .HasColumnName("notes");

                entity.Property(e => e.Odbior)
                    .HasColumnType("datetime")
                    .HasColumnName("odbior");

                entity.Property(e => e.Odbiorca).HasColumnName("odbiorca");

                entity.Property(e => e.OdebDat)
                    .HasColumnType("datetime")
                    .HasColumnName("odeb_dat");

                entity.Property(e => e.Oferta).HasColumnName("oferta");

                entity.Property(e => e.OfertaT)
                    .HasMaxLength(25)
                    .HasColumnName("oferta_t");

                entity.Property(e => e.OfrUtworz)
                    .HasColumnType("datetime")
                    .HasColumnName("ofr_utworz");

                entity.Property(e => e.Opiekun)
                    .HasMaxLength(128)
                    .HasColumnName("opiekun");

                entity.Property(e => e.Opis)
                    .HasMaxLength(100)
                    .HasColumnName("opis");

                entity.Property(e => e.OptUtworz)
                    .HasColumnType("datetime")
                    .HasColumnName("opt_utworz");

                entity.Property(e => e.Optym).HasColumnName("optym");

                entity.Property(e => e.OptymT)
                    .HasMaxLength(25)
                    .HasColumnName("optym_t");

                entity.Property(e => e.PierwOdeb)
                    .HasColumnType("datetime")
                    .HasColumnName("pierw_odeb");

                entity.Property(e => e.Planmont)
                    .HasColumnType("datetime")
                    .HasColumnName("planmont");

                entity.Property(e => e.Planprod)
                    .HasColumnType("datetime")
                    .HasColumnName("planprod");

                entity.Property(e => e.Plantran)
                    .HasColumnType("datetime")
                    .HasColumnName("plantran");

                entity.Property(e => e.Podstatus)
                    .HasMaxLength(15)
                    .HasColumnName("podstatus");

                entity.Property(e => e.PomiarKto)
                    .HasMaxLength(50)
                    .HasColumnName("pomiar_kto");

                entity.Property(e => e.Potwierdz).HasColumnName("potwierdz");

                entity.Property(e => e.Priorytet).HasColumnName("priorytet");

                entity.Property(e => e.Projekt).HasColumnName("projekt");

                entity.Property(e => e.ProjektT)
                    .HasMaxLength(25)
                    .HasColumnName("projekt_t");

                entity.Property(e => e.Realizacja)
                    .HasColumnType("datetime")
                    .HasColumnName("realizacja");

                entity.Property(e => e.Recno).HasColumnName("recno");

                entity.Property(e => e.Referencja)
                    .HasMaxLength(100)
                    .HasColumnName("referencja");

                entity.Property(e => e.Replguid)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("replguid")
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(12)
                    .HasColumnName("sign")
                    .IsFixedLength();

                entity.Property(e => e.SkopiowZ)
                    .HasMaxLength(25)
                    .HasColumnName("skopiow_z");

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .HasColumnName("source");

                entity.Property(e => e.Stan)
                    .HasMaxLength(25)
                    .HasColumnName("stan");

                entity.Property(e => e.Statopt).HasColumnName("statopt");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StawkaNpv)
                    .HasMaxLength(4)
                    .HasColumnName("stawka_npv");

                entity.Property(e => e.Step).HasColumnName("step");

                entity.Property(e => e.StepInfo).HasColumnName("step_info");

                entity.Property(e => e.Superopt).HasColumnName("superopt");

                entity.Property(e => e.TMontazu)
                    .HasColumnType("datetime")
                    .HasColumnName("t_montazu");

                entity.Property(e => e.Umowa)
                    .HasMaxLength(25)
                    .HasColumnName("umowa");

                entity.Property(e => e.UwagiTech)
                    .HasMaxLength(512)
                    .HasColumnName("uwagi_tech");

                entity.Property(e => e.UwagiZao1)
                    .HasMaxLength(256)
                    .HasColumnName("uwagi_zao1");

                entity.Property(e => e.UwagiZao2)
                    .HasMaxLength(256)
                    .HasColumnName("uwagi_zao2");

                entity.Property(e => e.UwagiZao3)
                    .HasMaxLength(256)
                    .HasColumnName("uwagi_zao3");

                entity.Property(e => e.UwagiZao4)
                    .HasMaxLength(256)
                    .HasColumnName("uwagi_zao4");

                entity.Property(e => e.Waluta)
                    .HasMaxLength(4)
                    .HasColumnName("waluta")
                    .IsFixedLength();

                entity.Property(e => e.Wartosc)
                    .HasColumnType("numeric(12, 2)")
                    .HasColumnName("wartosc");

                entity.Property(e => e.Waznosc)
                    .HasColumnType("datetime")
                    .HasColumnName("waznosc");

                entity.Property(e => e.Wersjabazy)
                    .HasMaxLength(20)
                    .HasColumnName("wersjabazy");

                entity.Property(e => e.Wgszablonu).HasColumnName("wgszablonu");

                entity.Property(e => e.WyslDat)
                    .HasColumnType("datetime")
                    .HasColumnName("wysl_dat");

                entity.Property(e => e.Wyslane).HasColumnName("wyslane");

                entity.Property(e => e.Wz).HasColumnName("wz");

                entity.Property(e => e.Zalicdat)
                    .HasColumnType("datetime")
                    .HasColumnName("zalicdat");

                entity.Property(e => e.Zaliczka)
                    .HasColumnType("numeric(12, 2)")
                    .HasColumnName("zaliczka");

                entity.Property(e => e.Zalistate).HasColumnName("zalistate");

                entity.Property(e => e.ZamPoOpt).HasColumnName("zam_po_opt");

                entity.Property(e => e.ZamUtworz)
                    .HasColumnType("datetime")
                    .HasColumnName("zam_utworz");

                entity.Property(e => e.Zamow).HasColumnName("zamow");

                entity.Property(e => e.ZamowT)
                    .HasMaxLength(25)
                    .HasColumnName("zamow_t");

                entity.Property(e => e.Zbior).HasColumnName("zbior");

                entity.Property(e => e.ZbiorT)
                    .HasMaxLength(25)
                    .HasColumnName("zbior_t");

                entity.Property(e => e.ZbrUtworz)
                    .HasColumnType("datetime")
                    .HasColumnName("zbr_utworz");

                entity.Property(e => e.Zgody).HasColumnName("zgody");

                entity.Property(e => e.ZlcUtworz)
                    .HasColumnType("datetime")
                    .HasColumnName("zlc_utworz");

                entity.Property(e => e.Zlecenie).HasColumnName("zlecenie");

                entity.Property(e => e.ZlecenieT)
                    .HasMaxLength(25)
                    .HasColumnName("zlecenie_t");

                entity.Property(e => e.Znaczniki)
                    .HasMaxLength(8)
                    .HasColumnName("znaczniki")
                    .IsFixedLength();

                entity.Property(e => e._1zlcwopt).HasColumnName("1zlcwopt");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
