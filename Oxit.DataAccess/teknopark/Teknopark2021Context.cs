using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Oxit.DataAccess.teknopark
{
    public partial class Teknopark2021Context : DbContext
    {
        public Teknopark2021Context()
        {
        }

        public Teknopark2021Context(DbContextOptions<Teknopark2021Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BankaServi> BankaServis { get; set; } = null!;
        public virtual DbSet<BankaServisHareket> BankaServisHarekets { get; set; } = null!;
        public virtual DbSet<BankaServisToken> BankaServisTokens { get; set; } = null!;
        public virtual DbSet<Bankaexcel> Bankaexcels { get; set; } = null!;
        public virtual DbSet<Bformu> Bformus { get; set; } = null!;
        public virtual DbSet<Bformua> Bformuas { get; set; } = null!;
        public virtual DbSet<Cariler> Carilers { get; set; } = null!;
        public virtual DbSet<EDefterKayitTablosu> EDefterKayitTablosus { get; set; } = null!;
        public virtual DbSet<ESmdbelgeGelirKalemleri> ESmdbelgeGelirKalemleris { get; set; } = null!;
        public virtual DbSet<ESmdbelgeGiderKalemleri> ESmdbelgeGiderKalemleris { get; set; } = null!;
        public virtual DbSet<ESmdgelir> ESmdgelirs { get; set; } = null!;
        public virtual DbSet<ESmdgider> ESmdgiders { get; set; } = null!;
        public virtual DbSet<ESmdlog> ESmdlogs { get; set; } = null!;
        public virtual DbSet<EarsivAktarimHeskodlari> EarsivAktarimHeskodlaris { get; set; } = null!;
        public virtual DbSet<Enf1> Enf1s { get; set; } = null!;
        public virtual DbSet<Enf2> Enf2s { get; set; } = null!;
        public virtual DbSet<Envanay> Envanays { get; set; } = null!;
        public virtual DbSet<Envanter> Envanters { get; set; } = null!;
        public virtual DbSet<Fisbil> Fisbils { get; set; } = null!;
        public virtual DbSet<FisbilEk> FisbilEks { get; set; } = null!;
        public virtual DbSet<Fissil> Fissils { get; set; } = null!;
        public virtual DbSet<Gelirtablosu> Gelirtablosus { get; set; } = null!;
        public virtual DbSet<GelirtablosuTmp> GelirtablosuTmps { get; set; } = null!;
        public virtual DbSet<Gidertablosu> Gidertablosus { get; set; } = null!;
        public virtual DbSet<GidertablosuTmp> GidertablosuTmps { get; set; } = null!;
        public virtual DbSet<Hesapisletgel> Hesapisletgels { get; set; } = null!;
        public virtual DbSet<Hesok> Hesoks { get; set; } = null!;
        public virtual DbSet<Hesplan> Hesplans { get; set; } = null!;
        public virtual DbSet<Hesplancariler> Hesplancarilers { get; set; } = null!;
        public virtual DbSet<Islemkod> Islemkods { get; set; } = null!;
        public virtual DbSet<Kapandsm> Kapandsms { get; set; } = null!;
        public virtual DbSet<Kapaniki> Kapanikis { get; set; } = null!;
        public virtual DbSet<Kapanuc> Kapanucs { get; set; } = null!;
        public virtual DbSet<Kapanuco> Kapanucos { get; set; } = null!;
        public virtual DbSet<KarDagitim> KarDagitims { get; set; } = null!;
        public virtual DbSet<KdvIndirilecek> KdvIndirileceks { get; set; } = null!;
        public virtual DbSet<LogFi> LogFis { get; set; } = null!;
        public virtual DbSet<LogUyari> LogUyaris { get; set; } = null!;
        public virtual DbSet<LogYev> LogYevs { get; set; } = null!;
        public virtual DbSet<Nazim> Nazims { get; set; } = null!;
        public virtual DbSet<Onay> Onays { get; set; } = null!;
        public virtual DbSet<Satmaliyeti> Satmaliyetis { get; set; } = null!;
        public virtual DbSet<Servi> Servis { get; set; } = null!;
        public virtual DbSet<Stokbf> Stokbfs { get; set; } = null!;
        public virtual DbSet<Stokgenm> Stokgenms { get; set; } = null!;
        public virtual DbSet<Stoktar> Stoktars { get; set; } = null!;
        public virtual DbSet<Stopajlar> Stopajlars { get; set; } = null!;
        public virtual DbSet<TbEdefterKontrol> TbEdefterKontrols { get; set; } = null!;
        public virtual DbSet<TbEdefterKontrolDetay> TbEdefterKontrolDetays { get; set; } = null!;
        public virtual DbSet<TbEdefterKontrolDetayFi> TbEdefterKontrolDetayFis { get; set; } = null!;
        public virtual DbSet<TbEdefterKontrolDetayFisYevmiye> TbEdefterKontrolDetayFisYevmiyes { get; set; } = null!;
        public virtual DbSet<TbHesapPlaniCache> TbHesapPlaniCaches { get; set; } = null!;
        public virtual DbSet<TbHesapPlaniGuncellemeListesi> TbHesapPlaniGuncellemeListesis { get; set; } = null!;
        public virtual DbSet<TbHesapPlaniKurFarki> TbHesapPlaniKurFarkis { get; set; } = null!;
        public virtual DbSet<TbInvoiceHead> TbInvoiceHeads { get; set; } = null!;
        public virtual DbSet<TbInvoiceLine> TbInvoiceLines { get; set; } = null!;
        public virtual DbSet<TbInvoiceSourceApp> TbInvoiceSourceApps { get; set; } = null!;
        public virtual DbSet<TbMuhasebelestirIsletmeDefteriAyarlari> TbMuhasebelestirIsletmeDefteriAyarlaris { get; set; } = null!;
        public virtual DbSet<TbMuhasebelestirmeAyarlari> TbMuhasebelestirmeAyarlaris { get; set; } = null!;
        public virtual DbSet<TbMuhasebelestirmeBelgeTuru> TbMuhasebelestirmeBelgeTurus { get; set; } = null!;
        public virtual DbSet<TbStokEslestir> TbStokEslestirs { get; set; } = null!;
        public virtual DbSet<TbVeriTabaniSurumu> TbVeriTabaniSurumus { get; set; } = null!;
        public virtual DbSet<TbYillikAyarlar> TbYillikAyarlars { get; set; } = null!;
        public virtual DbSet<TblBfomuAek> TblBfomuAeks { get; set; } = null!;
        public virtual DbSet<TblBfomuSek> TblBfomuSeks { get; set; } = null!;
        public virtual DbSet<Tbsil> Tbsils { get; set; } = null!;
        public virtual DbSet<TransferIliskiliKisiler> TransferIliskiliKisilers { get; set; } = null!;
        public virtual DbSet<TransferIliskinIslemler> TransferIliskinIslemlers { get; set; } = null!;
        public virtual DbSet<TransferIstirakler> TransferIstiraklers { get; set; } = null!;
        public virtual DbSet<TransferMaliIslemler> TransferMaliIslemlers { get; set; } = null!;
        public virtual DbSet<TransferOrtuluSermaye> TransferOrtuluSermayes { get; set; } = null!;
        public virtual DbSet<TransferYontemler> TransferYontemlers { get; set; } = null!;
        public virtual DbSet<VGetDate> VGetDates { get; set; } = null!;
        public virtual DbSet<YabanciParaPozisyonu> YabanciParaPozisyonus { get; set; } = null!;
        public virtual DbSet<YekTbl> YekTbls { get; set; } = null!;
        public virtual DbSet<Yevmisil> Yevmisils { get; set; } = null!;
        public virtual DbSet<Yevmiye> Yevmiyes { get; set; } = null!;
        public virtual DbSet<ZRaporu> ZRaporus { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Teknopark2021;User Id=sa;Password=yourStrong(!)Password;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Turkish_CI_AS");

            modelBuilder.Entity<BankaServi>(entity =>
            {
                entity.Property(e => e.Banka).HasMaxLength(50);

                entity.Property(e => e.RequestText).HasColumnType("text");

                entity.Property(e => e.ResponseText).HasColumnType("text");

                entity.Property(e => e.Sonuc).HasMaxLength(200);

                entity.Property(e => e.SorguTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<BankaServisHareket>(entity =>
            {
                entity.ToTable("BankaServis_Hareket");

                entity.Property(e => e.Aciklama).HasMaxLength(2000);

                entity.Property(e => e.Banka).HasMaxLength(100);

                entity.Property(e => e.BorcAlacak).HasMaxLength(1);

                entity.Property(e => e.EvrakNo).HasMaxLength(100);

                entity.Property(e => e.HataAciklamasi).HasMaxLength(2000);

                entity.Property(e => e.HesapNo).HasMaxLength(200);

                entity.Property(e => e.IslemKodu).HasMaxLength(50);

                entity.Property(e => e.MusteriNo).HasMaxLength(200);

                entity.Property(e => e.ParaBirimi).HasMaxLength(4);

                entity.Property(e => e.ServisHareketId).HasMaxLength(80);

                entity.Property(e => e.Tarih).HasColumnType("smalldatetime");

                entity.Property(e => e.TcKimlikNo).HasMaxLength(13);

                entity.Property(e => e.Vkn).HasMaxLength(13);
            });

            modelBuilder.Entity<BankaServisToken>(entity =>
            {
                entity.ToTable("BankaServis_Token");

                entity.Property(e => e.Banka).HasMaxLength(50);

                entity.Property(e => e.RequestText).HasColumnType("text");

                entity.Property(e => e.ResponseText).HasColumnType("text");

                entity.Property(e => e.Sonuc).HasMaxLength(200);

                entity.Property(e => e.SorguTarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bankaexcel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bankaexcel");

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.Bankaaciklamasi).HasMaxLength(200);

                entity.Property(e => e.Bora).HasMaxLength(8);

                entity.Property(e => e.Hesapkodu).HasMaxLength(20);

                entity.Property(e => e.Islemkodu).HasMaxLength(200);

                entity.Property(e => e.Muavinaciklamasi).HasMaxLength(200);
            });

            modelBuilder.Entity<Bformu>(entity =>
            {
                entity.HasKey(e => e.Sirano)
                    .HasName("bformus_pk");

                entity.ToTable("bformus");

                entity.HasIndex(e => e.EmId, "bformus_idx_EM_ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Bsayisi).HasMaxLength(4);

                entity.Property(e => e.Donem).HasMaxLength(2);

                entity.Property(e => e.EmId).HasColumnName("EM_ID");

                entity.Property(e => e.Muhadi).HasMaxLength(50);

                entity.Property(e => e.Muhsoyadi).HasMaxLength(50);

                entity.Property(e => e.Muhtcno).HasMaxLength(11);

                entity.Property(e => e.Muhtur).HasMaxLength(5);

                entity.Property(e => e.Muhvergino).HasMaxLength(11);

                entity.Property(e => e.Mukunvan).HasMaxLength(60);

                entity.Property(e => e.Mukvergino).HasMaxLength(11);

                entity.Property(e => e.Sirno).HasMaxLength(5);

                entity.Property(e => e.Sno).HasMaxLength(2);

                entity.Property(e => e.Tcno).HasMaxLength(11);

                entity.Property(e => e.Ukodu).HasMaxLength(3);

                entity.Property(e => e.Unvan).HasMaxLength(60);

                entity.Property(e => e.Vergidairesi).HasMaxLength(30);

                entity.Property(e => e.Vergino).HasMaxLength(11);
            });

            modelBuilder.Entity<Bformua>(entity =>
            {
                entity.HasKey(e => e.Sirano)
                    .HasName("bformua_pk");

                entity.ToTable("bformua");

                entity.HasIndex(e => e.EmId, "bformua_idx_EM_ID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Bsayisi).HasMaxLength(4);

                entity.Property(e => e.Donem).HasMaxLength(2);

                entity.Property(e => e.EmId).HasColumnName("EM_ID");

                entity.Property(e => e.Muhadi).HasMaxLength(50);

                entity.Property(e => e.Muhsoyadi).HasMaxLength(50);

                entity.Property(e => e.Muhtcno).HasMaxLength(11);

                entity.Property(e => e.Muhtur).HasMaxLength(5);

                entity.Property(e => e.Muhvergino).HasMaxLength(11);

                entity.Property(e => e.Mukunvan).HasMaxLength(60);

                entity.Property(e => e.Mukvergino).HasMaxLength(11);

                entity.Property(e => e.Sirno).HasMaxLength(5);

                entity.Property(e => e.Sno).HasMaxLength(2);

                entity.Property(e => e.Tcno).HasMaxLength(11);

                entity.Property(e => e.Ukodu).HasMaxLength(3);

                entity.Property(e => e.Unvan).HasMaxLength(60);

                entity.Property(e => e.Vergidairesi).HasMaxLength(30);

                entity.Property(e => e.Vergino).HasMaxLength(11);
            });

            modelBuilder.Entity<Cariler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cariler");

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.CariPid)
                    .HasMaxLength(80)
                    .HasColumnName("Cari_pid");

                entity.Property(e => e.Cariadi).HasMaxLength(100);

                entity.Property(e => e.Tckimlikno).HasMaxLength(11);

                entity.Property(e => e.Tel).HasMaxLength(20);

                entity.Property(e => e.Ulkekodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vergidairesi).HasMaxLength(40);

                entity.Property(e => e.Vergikimlikno).HasMaxLength(11);

                entity.Property(e => e.Yetkili).HasMaxLength(50);
            });

            modelBuilder.Entity<EDefterKayitTablosu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("eDefter_Kayit_Tablosu");

                entity.Property(e => e.BeratDosyaYeri)
                    .HasMaxLength(250)
                    .HasColumnName("Berat_Dosya_Yeri");

                entity.Property(e => e.DefterAciklamasi)
                    .HasMaxLength(150)
                    .HasColumnName("Defter_Aciklamasi");

                entity.Property(e => e.DefterBaslangicTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("Defter_Baslangic_Tarihi");

                entity.Property(e => e.DefterBitisTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("Defter_Bitis_Tarihi");

                entity.Property(e => e.DefterDurumu)
                    .HasMaxLength(30)
                    .HasColumnName("Defter_Durumu");

                entity.Property(e => e.DefterTuru)
                    .HasMaxLength(20)
                    .HasColumnName("Defter_Turu");

                entity.Property(e => e.DonemAyi).HasColumnName("Donem_Ayi");

                entity.Property(e => e.Donemi).HasMaxLength(20);

                entity.Property(e => e.DosyaSiraNo)
                    .HasMaxLength(6)
                    .HasColumnName("Dosya_Sira_No");

                entity.Property(e => e.KayitEdenKullanici)
                    .HasMaxLength(50)
                    .HasColumnName("Kayit_Eden_Kullanici");

                entity.Property(e => e.KayitTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("Kayit_Tarihi");

                entity.Property(e => e.KontrolNumarasi)
                    .HasMaxLength(20)
                    .HasColumnName("Kontrol_Numarasi");

                entity.Property(e => e.OlusturanKisi)
                    .HasMaxLength(100)
                    .HasColumnName("Olusturan_Kisi");

                entity.Property(e => e.OlusturmaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("Olusturma_Tarihi");

                entity.Property(e => e.PaketDosyaYeri)
                    .HasMaxLength(250)
                    .HasColumnName("Paket_Dosya_Yeri");

                entity.Property(e => e.SilenKullanici)
                    .HasMaxLength(50)
                    .HasColumnName("Silen_Kullanici");

                entity.Property(e => e.SilinmeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("Silinme_Tarihi");

                entity.Property(e => e.Sirano).ValueGeneratedOnAdd();

                entity.Property(e => e.SubeAdi).HasMaxLength(250);

                entity.Property(e => e.SubeNo).HasMaxLength(4);

                entity.Property(e => e.SubeliDefter).HasMaxLength(5);

                entity.Property(e => e.XmlDosyaYeri)
                    .HasMaxLength(250)
                    .HasColumnName("Xml_Dosya_Yeri");

                entity.Property(e => e.ZamanDamgasiVar).HasMaxLength(3);
            });

            modelBuilder.Entity<ESmdbelgeGelirKalemleri>(entity =>
            {
                entity.HasKey(e => e.Ref)
                    .HasName("PK_tbl_eSMDBelgeGelirKalemleriTbl_ID");

                entity.ToTable("eSMDBelgeGelirKalemleri");

                entity.Property(e => e.Ref).HasColumnName("REF");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .HasColumnName("aciklama");

                entity.Property(e => e.AnaRef).HasColumnName("anaRef");

                entity.Property(e => e.Artan)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.BirimFiyat)
                    .HasColumnName("birimFiyat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BirimKodu)
                    .HasMaxLength(50)
                    .HasColumnName("birimKodu");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DigerIadeHakkiKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("digerIadeHakkiKodu");

                entity.Property(e => e.DigerIadeHakkiOrani)
                    .HasColumnName("digerIadeHakkiOrani")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DigerIslemlerKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("digerIslemlerKodu");

                entity.Property(e => e.DigerIslemlerOrani)
                    .HasColumnName("digerIslemlerOrani")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DurumKodu).HasComment("-\"0\" Normal ilk gelen\r\n-\"1\" Değiştirilen Kayıt");

                entity.Property(e => e.EskiAciklama).HasMaxLength(100);

                entity.Property(e => e.EskiKod).HasMaxLength(2);

                entity.Property(e => e.GelirKayitAltTuruKodu)
                    .HasMaxLength(50)
                    .HasColumnName("gelirKayitAltTuruKodu");

                entity.Property(e => e.GelirKayitTuruKodu)
                    .HasMaxLength(50)
                    .HasColumnName("gelirKayitTuruKodu");

                entity.Property(e => e.GercekTutar)
                    .HasColumnName("gercekTutar")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GibGuid)
                    .HasMaxLength(50)
                    .HasColumnName("gibGuid");

                entity.Property(e => e.IadeKismiTevkifatKodu)
                    .HasMaxLength(50)
                    .HasColumnName("iadeKismiTevkifatKodu");

                entity.Property(e => e.IadeKismiTevkifatOrani)
                    .HasColumnName("iadeKismiTevkifatOrani")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IhracKayitliTeslimKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ihracKayitliTeslimKodu");

                entity.Property(e => e.IhracKayitliTeslimOrani)
                    .HasColumnName("ihracKayitliTeslimOrani")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsletmeRef).HasColumnName("isletmeRef");

                entity.Property(e => e.Kdv)
                    .HasColumnName("kdv")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KdvOrani)
                    .HasColumnName("kdvOrani")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KdvsizIslem).HasColumnName("kdvsizIslem");

                entity.Property(e => e.KismiIstisnaKodu)
                    .HasMaxLength(50)
                    .HasColumnName("kismiIstisnaKodu");

                entity.Property(e => e.KismiIstisnaOrani)
                    .HasColumnName("kismiIstisnaOrani")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.KismiTevkifatKodu)
                    .HasMaxLength(20)
                    .HasColumnName("kismiTevkifatKodu");

                entity.Property(e => e.KismiTevkifatOrani)
                    .HasColumnName("kismiTevkifatOrani")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Miktar)
                    .HasColumnName("miktar")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NaceKodu).HasMaxLength(10);

                entity.Property(e => e.NetDefterDegeri)
                    .HasColumnName("netDefterDegeri")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SabitKiymetId)
                    .HasMaxLength(50)
                    .HasColumnName("sabitKiymetId");

                entity.Property(e => e.SatisTuruKodu)
                    .HasMaxLength(50)
                    .HasColumnName("satisTuruKodu");

                entity.Property(e => e.StopajKodu)
                    .HasMaxLength(20)
                    .HasColumnName("stopajKodu");

                entity.Property(e => e.StopajOrani)
                    .HasColumnName("stopajOrani")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StopajTutari)
                    .HasColumnName("stopajTutari")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TamIstisnaKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tamIstisnaKodu");

                entity.Property(e => e.TamIstisnaOrani)
                    .HasColumnName("tamIstisnaOrani")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tutar)
                    .HasColumnName("tutar")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ZrvArtan).HasColumnName("zrvArtan");

                entity.Property(e => e.ZrvGuid)
                    .HasColumnName("zrvGuid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ZrvKodu)
                    .HasMaxLength(2)
                    .HasColumnName("zrvKodu");
            });

            modelBuilder.Entity<ESmdbelgeGiderKalemleri>(entity =>
            {
                entity.HasKey(e => e.Ref)
                    .HasName("PK_tbl_eSMDBelgeGiderKalemleriTbl_REF");

                entity.ToTable("eSMDBelgeGiderKalemleri");

                entity.Property(e => e.Ref).HasColumnName("REF");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(100)
                    .HasColumnName("aciklama");

                entity.Property(e => e.Adi)
                    .HasMaxLength(50)
                    .HasColumnName("adi");

                entity.Property(e => e.AlisTuruKodu)
                    .HasMaxLength(50)
                    .HasColumnName("alisTuruKodu");

                entity.Property(e => e.AmortismanYontemiKodu)
                    .HasMaxLength(50)
                    .HasColumnName("amortismanYontemiKodu");

                entity.Property(e => e.AnaRef).HasColumnName("anaRef");

                entity.Property(e => e.Artan)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.BirimFiyat).HasColumnName("birimFiyat");

                entity.Property(e => e.BirimKodu)
                    .HasMaxLength(50)
                    .HasColumnName("birimKodu");

                entity.Property(e => e.DamgaVergisiKodu)
                    .HasMaxLength(50)
                    .HasColumnName("damgaVergisiKodu");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Donemsellik).HasColumnName("donemsellik");

                entity.Property(e => e.DonemsellikParentGiderId)
                    .HasMaxLength(50)
                    .HasColumnName("donemsellikParentGiderId");

                entity.Property(e => e.DurumKodu).HasComment("-\"0\" Normal ilk gelen\r\n-\"1\" Değiştirilen Kayıt");

                entity.Property(e => e.EskiAciklama).HasMaxLength(100);

                entity.Property(e => e.EskiKod).HasMaxLength(2);

                entity.Property(e => e.GercekTutar).HasColumnName("gercekTutar");

                entity.Property(e => e.GibGuid)
                    .HasMaxLength(50)
                    .HasColumnName("gibGuid");

                entity.Property(e => e.GiderKayitAltTuruKodu)
                    .HasMaxLength(50)
                    .HasColumnName("giderKayitAltTuruKodu")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GiderKayitTuruKodu)
                    .HasMaxLength(50)
                    .HasColumnName("giderKayitTuruKodu");

                entity.Property(e => e.HesaplamaYontemiKodu)
                    .HasMaxLength(50)
                    .HasColumnName("hesaplamaYontemiKodu");

                entity.Property(e => e.Iade)
                    .HasColumnName("iade")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IktisadiKiymetKodu)
                    .HasMaxLength(50)
                    .HasColumnName("iktisadiKiymetKodu");

                entity.Property(e => e.IsletmeRef).HasColumnName("isletmeRef");

                entity.Property(e => e.Kdv).HasColumnName("kdv");

                entity.Property(e => e.KdvOrani).HasColumnName("kdvOrani");

                entity.Property(e => e.KdvsizIslem).HasColumnName("kdvsizIslem");

                entity.Property(e => e.KismiTevkifatKodu)
                    .HasMaxLength(20)
                    .HasColumnName("kismiTevkifatKodu");

                entity.Property(e => e.KismiTevkifatOrani).HasColumnName("kismiTevkifatOrani");

                entity.Property(e => e.Kodu)
                    .HasMaxLength(50)
                    .HasColumnName("kodu");

                entity.Property(e => e.Miktar).HasColumnName("miktar");

                entity.Property(e => e.NaceKodu).HasMaxLength(10);

                entity.Property(e => e.OdemeTuruKodu)
                    .HasMaxLength(50)
                    .HasColumnName("odemeTuruKodu");

                entity.Property(e => e.OzelKodKodu)
                    .HasMaxLength(50)
                    .HasColumnName("ozelKodKodu");

                entity.Property(e => e.Periyot)
                    .HasColumnName("periyot")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SabitKiymetTuruKodu)
                    .HasMaxLength(50)
                    .HasColumnName("sabitKiymetTuruKodu");

                entity.Property(e => e.StopajKodu)
                    .HasMaxLength(20)
                    .HasColumnName("stopajKodu");

                entity.Property(e => e.StopajOrani).HasColumnName("stopajOrani");

                entity.Property(e => e.StopajTutari).HasColumnName("stopajTutari");

                entity.Property(e => e.TevkifatDurumKodu)
                    .HasColumnName("tevkifatDurumKodu")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tutar).HasColumnName("tutar");

                entity.Property(e => e.Updated)
                    .HasColumnName("updated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ZrvArtan).HasColumnName("zrvArtan");

                entity.Property(e => e.ZrvGuid)
                    .HasColumnName("zrvGuid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ZrvKodu)
                    .HasMaxLength(2)
                    .HasColumnName("zrvKodu");
            });

            modelBuilder.Entity<ESmdgelir>(entity =>
            {
                entity.HasKey(e => e.Ref)
                    .HasName("PK_tbl_eSMDBelgeBilgileriTbl_ID");

                entity.ToTable("eSMDGelir");

                entity.Property(e => e.Ref).HasColumnName("REF");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ad");

                entity.Property(e => e.AdresBilgisi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("adresBilgisi");

                entity.Property(e => e.AdresiGuncelleme).HasColumnName("adresiGuncelleme");

                entity.Property(e => e.BelgeAyi)
                    .HasColumnName("belgeAyi")
                    .HasComputedColumnSql("(datepart(month,[belgeTarihi]))", false);

                entity.Property(e => e.BelgeSeriNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("belgeSeriNo");

                entity.Property(e => e.BelgeSiraNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("belgeSiraNo");

                entity.Property(e => e.BelgeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("belgeTarihi");

                entity.Property(e => e.BelgeTutari).HasColumnName("belgeTutari");

                entity.Property(e => e.GelirBelgeTuruKodu)
                    .HasMaxLength(50)
                    .HasColumnName("gelirBelgeTuruKodu");

                entity.Property(e => e.GibGuid)
                    .HasMaxLength(50)
                    .HasColumnName("gibGuid");

                entity.Property(e => e.Iade).HasColumnName("iade");

                entity.Property(e => e.KayitTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("kayitTarihi");

                entity.Property(e => e.KrediKartiTutari)
                    .HasColumnName("krediKartiTutari")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MukellefId)
                    .HasMaxLength(50)
                    .HasColumnName("mukellefId");

                entity.Property(e => e.NihaiTuketici).HasColumnName("nihaiTuketici");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("soyad");

                entity.Property(e => e.SubeNo)
                    .HasColumnName("subeNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TcknVkn)
                    .HasMaxLength(11)
                    .HasColumnName("tcknVkn");

                entity.Property(e => e.TopluKayit)
                    .HasColumnName("topluKayit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VergiDairesiKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vergiDairesiKodu");

                entity.Property(e => e.Versiyon)
                    .HasColumnName("versiyon")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ESmdgider>(entity =>
            {
                entity.HasKey(e => e.Ref)
                    .HasName("PK_GidereSMD_ID");

                entity.ToTable("eSMDGider");

                entity.Property(e => e.Ref).HasColumnName("REF");

                entity.Property(e => e.Ad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ad");

                entity.Property(e => e.AdresBilgisi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("adresBilgisi");

                entity.Property(e => e.AdresiGuncelleme).HasColumnName("adresiGuncelleme");

                entity.Property(e => e.BelgeAdedi)
                    .HasColumnName("belgeAdedi")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BelgeAyi)
                    .HasColumnName("belgeAyi")
                    .HasComputedColumnSql("(datepart(month,[belgeTarihi]))", false);

                entity.Property(e => e.BelgeSeriNo)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("belgeSeriNo");

                entity.Property(e => e.BelgeSiraNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("belgeSiraNo");

                entity.Property(e => e.BelgeTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("belgeTarihi");

                entity.Property(e => e.GibGuid)
                    .HasMaxLength(50)
                    .HasColumnName("gibGuid");

                entity.Property(e => e.GiderBelgeTuruKodu)
                    .HasMaxLength(50)
                    .HasColumnName("giderBelgeTuruKodu");

                entity.Property(e => e.Iade).HasColumnName("iade");

                entity.Property(e => e.KayitTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("kayitTarihi");

                entity.Property(e => e.MukellefId)
                    .HasMaxLength(50)
                    .HasColumnName("mukellefId");

                entity.Property(e => e.Soyad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("soyad");

                entity.Property(e => e.SubeNo)
                    .HasColumnName("subeNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TcknVkn)
                    .HasMaxLength(11)
                    .HasColumnName("tcknVkn");

                entity.Property(e => e.TopluKayit)
                    .HasColumnName("topluKayit")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VergiDairesiKodu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vergiDairesiKodu");

                entity.Property(e => e.Versiyon)
                    .HasColumnName("versiyon")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ESmdlog>(entity =>
            {
                entity.ToTable("eSMDLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RequestTxt).HasColumnType("ntext");

                entity.Property(e => e.ResponseTxt).HasColumnType("ntext");

                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EarsivAktarimHeskodlari>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EARSIV_AKTARIM_HESKODLARI");

                entity.Property(e => e.BorsaHeskod)
                    .HasMaxLength(50)
                    .HasColumnName("BORSA_HESKOD");

                entity.Property(e => e.GelenGiden).HasMaxLength(50);

                entity.Property(e => e.GvHeskod)
                    .HasMaxLength(50)
                    .HasColumnName("GV_HESKOD");

                entity.Property(e => e.IndirimHeskod)
                    .HasMaxLength(50)
                    .HasColumnName("INDIRIM_HESKOD");

                entity.Property(e => e.KapatilacakHeskod)
                    .HasMaxLength(50)
                    .HasColumnName("KAPATILACAK_HESKOD");

                entity.Property(e => e.KdvHeskod1)
                    .HasMaxLength(50)
                    .HasColumnName("KDV_HESKOD_1");

                entity.Property(e => e.KdvHeskod18)
                    .HasMaxLength(50)
                    .HasColumnName("KDV_HESKOD_18");

                entity.Property(e => e.KdvHeskod8)
                    .HasMaxLength(50)
                    .HasColumnName("KDV_HESKOD_8");

                entity.Property(e => e.MatrahHesKod0)
                    .HasMaxLength(50)
                    .HasColumnName("MATRAH_HES_KOD0");

                entity.Property(e => e.MatrahHesKod1)
                    .HasMaxLength(50)
                    .HasColumnName("MATRAH_HES_KOD1");

                entity.Property(e => e.MatrahHesKod18)
                    .HasMaxLength(50)
                    .HasColumnName("MATRAH_HES_KOD18");

                entity.Property(e => e.MatrahHesKod8)
                    .HasMaxLength(50)
                    .HasColumnName("MATRAH_HES_KOD8");

                entity.Property(e => e.MeraHeskod)
                    .HasMaxLength(50)
                    .HasColumnName("MERA_HESKOD");

                entity.Property(e => e.OivHeskod)
                    .HasMaxLength(50)
                    .HasColumnName("OIV_HESKOD");

                entity.Property(e => e.OtvHeskod)
                    .HasMaxLength(50)
                    .HasColumnName("OTV_HESKOD");

                entity.Property(e => e.SgkHeskod)
                    .HasMaxLength(50)
                    .HasColumnName("SGK_HESKOD");

                entity.Property(e => e.TevkifatHeskod)
                    .HasMaxLength(50)
                    .HasColumnName("TEVKIFAT_HESKOD");

                entity.Property(e => e.YuvarlamaHeskod)
                    .HasMaxLength(50)
                    .HasColumnName("YUVARLAMA_HESKOD");
            });

            modelBuilder.Entity<Enf1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("enf1");

                entity.Property(e => e.Acik).HasMaxLength(50);

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.Bat).HasMaxLength(1);

                entity.Property(e => e.Bh).HasMaxLength(1);

                entity.Property(e => e.Detay).HasMaxLength(1);

                entity.Property(e => e.Hek).HasMaxLength(20);

                entity.Property(e => e.Kod).HasMaxLength(20);

                entity.Property(e => e.Nsd).HasMaxLength(1);

                entity.Property(e => e.Parmi).HasMaxLength(1);
            });

            modelBuilder.Entity<Enf2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("enf2");

                entity.Property(e => e.AmortismanaTabimi)
                    .HasMaxLength(1)
                    .HasColumnName("Amortismana Tabimi");

                entity.Property(e => e.ArtışOranı).HasColumnName("Artış Oranı");

                entity.Property(e => e.Birahk).HasMaxLength(20);

                entity.Property(e => e.BirikmişAmortHesapKodu)
                    .HasMaxLength(20)
                    .HasColumnName("Birikmiş Amort#Hesap Kodu");

                entity.Property(e => e.BirikmişAmortismanTutar).HasColumnName("Birikmiş Amortisman Tutar");

                entity.Property(e => e.BorcunKapDönAitTefe).HasColumnName("Borcun Kap#Dön#Ait TEFE");

                entity.Property(e => e.BorcunKapatılıdığıAy).HasColumnName("Borcun Kapatılıdığı Ay");

                entity.Property(e => e.BorcunKapatılıdığıYıl).HasColumnName("Borcun Kapatılıdığı Yıl");

                entity.Property(e => e.BorcunKulDönAitTefe).HasColumnName("Borcun Kul#Dön#Ait TEFE");

                entity.Property(e => e.BorcunKullanıldığıAy).HasColumnName("Borcun Kullanıldığı Ay");

                entity.Property(e => e.BorcunKullanıldığıYıl).HasColumnName("Borcun Kullanıldığı Yıl");

                entity.Property(e => e.DüzeltilecekDeğer).HasColumnName("Düzeltilecek Değer");

                entity.Property(e => e.DüzeltilmişAmortismanDe).HasColumnName("Düzeltilmiş Amortisman De");

                entity.Property(e => e.DüzeltilmişDeğer).HasColumnName("Düzeltilmiş Değer");

                entity.Property(e => e.DüzeltmeKatsayısı).HasColumnName("Düzeltme Katsayısı");

                entity.Property(e => e.DüzeltmeyeEsasDeğer).HasColumnName("Düzeltmeye Esas Değer");

                entity.Property(e => e.DüzeltÖncDönemAyı).HasColumnName("Düzelt#Önc#Dönem Ayı");

                entity.Property(e => e.DüzeltÖncDönemYılı).HasColumnName("Düzelt#Önc#Dönem Yılı");

                entity.Property(e => e.ElimineEdilecekTutar).HasColumnName("Elimine Edilecek Tutar");

                entity.Property(e => e.EnfDüzHeskod)
                    .HasMaxLength(20)
                    .HasColumnName("Enf#Düz#Heskod");

                entity.Property(e => e.EnfDüzeltmeHesapKodu)
                    .HasMaxLength(20)
                    .HasColumnName("Enf#Düzeltme Hesap Kodu");

                entity.Property(e => e.FinansmanMaliyetiTutarı).HasColumnName("Finansman Maliyeti Tutarı");

                entity.Property(e => e.Kod).HasMaxLength(20);

                entity.Property(e => e.MaliTabAitOlAyaAitT).HasColumnName("Mali Tab#Ait Ol#Aya Ait T");

                entity.Property(e => e.OrtTicKrediFaizOranı).HasColumnName("Ort#Tic#Kredi Faiz Oranı");

                entity.Property(e => e.ReelOlmayanFinMali).HasColumnName("Reel Olmayan Fin#Mali#");

                entity.Property(e => e.ReelOlmayanFinMaliyeti)
                    .HasMaxLength(1)
                    .HasColumnName("Reel Olmayan Fin#Maliyeti");

                entity.Property(e => e.RofmİçinOran).HasColumnName("ROFM İçin Oran");

                entity.Property(e => e.Sirano).ValueGeneratedOnAdd();

                entity.Property(e => e.StokDüzeltmeYöntemi)
                    .HasMaxLength(1)
                    .HasColumnName("Stok Düzeltme Yöntemi");

                entity.Property(e => e.TaşımaKatsayısı).HasColumnName("Taşıma Katsayısı");

                entity.Property(e => e.TefeArtışOranı).HasColumnName("Tefe Artış Oranı");

                entity.Property(e => e.TefeOtkfo).HasColumnName("TEFE/OTKFO");

                entity.Property(e => e.TkDk)
                    .HasMaxLength(1)
                    .HasColumnName("Tk/Dk");

                entity.Property(e => e.YenDeğerDemirbaşDeğeri).HasColumnName("Yen#Değer#Demirbaş Değeri");

                entity.Property(e => e.Yöntem).HasMaxLength(1);

                entity.Property(e => e.ÖncDönDüzAmortDeğeri).HasColumnName("Önc#Dön#Düz#Amort#Değeri");

                entity.Property(e => e.ÖncDönDüzeltilmişDeğer).HasColumnName("Önc#Dön#Düzeltilmiş Değer");
            });

            modelBuilder.Entity<Envanay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("envanay");

                entity.Property(e => e.Eyontemi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sno).ValueGeneratedOnAdd();

                entity.Property(e => e.Sta).HasMaxLength(40);

                entity.Property(e => e.Stb).HasMaxLength(8);

                entity.Property(e => e.Stk).HasMaxLength(20);

                entity.Property(e => e.Stt).HasColumnType("smalldatetime");

                entity.Property(e => e.Ticari)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Envanter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("envanter");

                entity.Property(e => e.Eyontemi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sta).HasMaxLength(40);

                entity.Property(e => e.Stb).HasMaxLength(8);

                entity.Property(e => e.Stk).HasMaxLength(20);

                entity.Property(e => e.Ticari)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Fisbil>(entity =>
            {
                entity.HasKey(e => e.Refno);

                entity.ToTable("fisbil");

                entity.Property(e => e.Ekaciklama).HasMaxLength(500);

                entity.Property(e => e.FisGuid).HasColumnName("fis_guid");

                entity.Property(e => e.FisbilPid)
                    .HasMaxLength(18)
                    .HasColumnName("fisbil_pid");

                entity.Property(e => e.Fisekilit).HasMaxLength(1);

                entity.Property(e => e.Fisno).HasMaxLength(9);

                entity.Property(e => e.Fistar).HasColumnType("smalldatetime");

                entity.Property(e => e.Fistur).HasMaxLength(1);

                entity.Property(e => e.Kayittarihi).HasColumnType("datetime");

                entity.Property(e => e.Masrafmerkezi).HasMaxLength(10);

                entity.Property(e => e.Nereden).HasMaxLength(1);

                entity.Property(e => e.Onaylimi).HasMaxLength(1);

                entity.Property(e => e.Ozkod).HasMaxLength(50);

                entity.Property(e => e.Sube).HasMaxLength(2);
            });

            modelBuilder.Entity<FisbilEk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fisbil_ek");

                entity.Property(e => e.Ad).HasMaxLength(20);

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.Deger).HasMaxLength(200);

                entity.Property(e => e.FisbilPid)
                    .HasMaxLength(18)
                    .HasColumnName("fisbil_pid");
            });

            modelBuilder.Entity<Fissil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fissil");

                entity.Property(e => e.Ekaciklama).HasMaxLength(500);

                entity.Property(e => e.FisGuid).HasColumnName("fis_guid");

                entity.Property(e => e.FisbilPid)
                    .HasMaxLength(18)
                    .HasColumnName("fisbil_pid");

                entity.Property(e => e.Fisekilit).HasMaxLength(1);

                entity.Property(e => e.Fisno).HasMaxLength(9);

                entity.Property(e => e.Fistar).HasColumnType("smalldatetime");

                entity.Property(e => e.Fistur).HasMaxLength(1);

                entity.Property(e => e.Kayittarihi).HasColumnType("datetime");

                entity.Property(e => e.Masrafmerkezi).HasMaxLength(10);

                entity.Property(e => e.Nereden).HasMaxLength(1);

                entity.Property(e => e.Onaylimi).HasMaxLength(1);

                entity.Property(e => e.Ozkod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sube).HasMaxLength(2);
            });

            modelBuilder.Entity<Gelirtablosu>(entity =>
            {
                entity.HasKey(e => e.Sirano)
                    .HasName("PK_gelirtablosu_Sirano");

                entity.ToTable("gelirtablosu");

                entity.Property(e => e.Aciklama).HasMaxLength(100);

                entity.Property(e => e.Artan)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.BelgeTuru).HasMaxLength(50);

                entity.Property(e => e.Dahilharic).HasMaxLength(1);

                entity.Property(e => e.DbKayitTarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DB_KayitTarihi");

                entity.Property(e => e.DefterBeyanGuncelle).HasDefaultValueSql("((1))");

                entity.Property(e => e.Faturano).HasMaxLength(16);

                entity.Property(e => e.Faturatarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.GibGuid).HasColumnName("gibGuid");

                entity.Property(e => e.GibRef)
                    .HasMaxLength(50)
                    .HasColumnName("gibRef");

                entity.Property(e => e.Heskod).HasMaxLength(20);

                entity.Property(e => e.Islemetarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.IstisnaKodu).HasMaxLength(50);

                entity.Property(e => e.KayitAltTuru).HasMaxLength(50);

                entity.Property(e => e.KayitTarihi).HasColumnType("datetime");

                entity.Property(e => e.KayitTuru).HasMaxLength(50);

                entity.Property(e => e.KdvsizIslem).HasColumnName("kdvsizIslem");

                entity.Property(e => e.Kod).HasMaxLength(2);

                entity.Property(e => e.Kullanici).HasMaxLength(50);

                entity.Property(e => e.NaceKodu).HasMaxLength(10);

                entity.Property(e => e.RefGuid).HasColumnName("refGuid");

                entity.Property(e => e.SatisTuru).HasMaxLength(50);

                entity.Property(e => e.Stokkodu).HasMaxLength(20);

                entity.Property(e => e.StopajKodu).HasMaxLength(20);

                entity.Property(e => e.StopajOrani).HasColumnName("stopajOrani");

                entity.Property(e => e.TamIstisnaKodu)
                    .HasMaxLength(50)
                    .HasColumnName("tamIstisnaKodu");

                entity.Property(e => e.TevkifatKodu).HasMaxLength(20);

                entity.Property(e => e.Tip).HasMaxLength(1);

                entity.Property(e => e.Torani)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UlkeKodu).HasMaxLength(3);

                entity.Property(e => e.Vergino).HasMaxLength(11);
            });

            modelBuilder.Entity<GelirtablosuTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gelirtablosuTmp");

                entity.Property(e => e.Aciklama).HasMaxLength(100);

                entity.Property(e => e.BelgeTuru).HasMaxLength(50);

                entity.Property(e => e.Dahilharic).HasMaxLength(1);

                entity.Property(e => e.Faturano).HasMaxLength(16);

                entity.Property(e => e.Faturatarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.GibGuid).HasColumnName("gibGuid");

                entity.Property(e => e.GibRef)
                    .HasMaxLength(50)
                    .HasColumnName("gibRef");

                entity.Property(e => e.Heskod).HasMaxLength(20);

                entity.Property(e => e.Islemetarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.IstisnaKodu).HasMaxLength(50);

                entity.Property(e => e.KayitAltTuru).HasMaxLength(50);

                entity.Property(e => e.KayitTuru).HasMaxLength(50);

                entity.Property(e => e.KdvsizIslem).HasColumnName("kdvsizIslem");

                entity.Property(e => e.Kod).HasMaxLength(2);

                entity.Property(e => e.Kullanici).HasMaxLength(50);

                entity.Property(e => e.Ref)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REF");

                entity.Property(e => e.RefGuid).HasColumnName("refGuid");

                entity.Property(e => e.SatisTuru).HasMaxLength(50);

                entity.Property(e => e.Stokkodu).HasMaxLength(20);

                entity.Property(e => e.StopajKodu).HasMaxLength(20);

                entity.Property(e => e.StopajOrani).HasColumnName("stopajOrani");

                entity.Property(e => e.TamIstisnaKodu)
                    .HasMaxLength(50)
                    .HasColumnName("tamIstisnaKodu");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.TevkifatKodu).HasMaxLength(20);

                entity.Property(e => e.Tip).HasMaxLength(1);

                entity.Property(e => e.Torani)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vergino).HasMaxLength(11);
            });

            modelBuilder.Entity<Gidertablosu>(entity =>
            {
                entity.HasKey(e => e.Sirano)
                    .HasName("PK_gidertablosu_Sirano");

                entity.ToTable("gidertablosu");

                entity.Property(e => e.Aciklama).HasMaxLength(100);

                entity.Property(e => e.Artan)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.BelgeTuru).HasMaxLength(50);

                entity.Property(e => e.Dahilharic).HasMaxLength(1);

                entity.Property(e => e.DbKayitTarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DB_KayitTarihi");

                entity.Property(e => e.DefterBeyanGuncelle).HasDefaultValueSql("((1))");

                entity.Property(e => e.Faturano).HasMaxLength(16);

                entity.Property(e => e.Faturatarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.GibGuid).HasColumnName("gibGuid");

                entity.Property(e => e.GibRef)
                    .HasMaxLength(50)
                    .HasColumnName("gibRef");

                entity.Property(e => e.Heskod).HasMaxLength(20);

                entity.Property(e => e.Islemetarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.IstisnaKodu).HasMaxLength(50);

                entity.Property(e => e.KayitAltTuru).HasMaxLength(50);

                entity.Property(e => e.KayitTarihi).HasColumnType("datetime");

                entity.Property(e => e.KayitTuru).HasMaxLength(50);

                entity.Property(e => e.KdvsizIslem).HasColumnName("kdvsizIslem");

                entity.Property(e => e.Kod).HasMaxLength(2);

                entity.Property(e => e.Kullanici).HasMaxLength(50);

                entity.Property(e => e.NaceKodu).HasMaxLength(10);

                entity.Property(e => e.RefGuid).HasColumnName("refGuid");

                entity.Property(e => e.SatisTuru).HasMaxLength(50);

                entity.Property(e => e.Stokkodu).HasMaxLength(20);

                entity.Property(e => e.StopajKodu).HasMaxLength(20);

                entity.Property(e => e.StopajOrani).HasColumnName("stopajOrani");

                entity.Property(e => e.TamIstisnaKodu)
                    .HasMaxLength(50)
                    .HasColumnName("tamIstisnaKodu");

                entity.Property(e => e.TevkifatKodu).HasMaxLength(20);

                entity.Property(e => e.Torani)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UlkeKodu).HasMaxLength(3);

                entity.Property(e => e.Vergino).HasMaxLength(11);
            });

            modelBuilder.Entity<GidertablosuTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gidertablosuTmp");

                entity.Property(e => e.Aciklama).HasMaxLength(100);

                entity.Property(e => e.BelgeTuru).HasMaxLength(50);

                entity.Property(e => e.Dahilharic).HasMaxLength(1);

                entity.Property(e => e.Faturano).HasMaxLength(16);

                entity.Property(e => e.Faturatarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.GibGuid).HasColumnName("gibGuid");

                entity.Property(e => e.GibRef)
                    .HasMaxLength(50)
                    .HasColumnName("gibRef");

                entity.Property(e => e.Heskod).HasMaxLength(20);

                entity.Property(e => e.Islemetarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.IstisnaKodu).HasMaxLength(50);

                entity.Property(e => e.KayitAltTuru).HasMaxLength(50);

                entity.Property(e => e.KayitTuru).HasMaxLength(50);

                entity.Property(e => e.KdvsizIslem).HasColumnName("kdvsizIslem");

                entity.Property(e => e.Kod).HasMaxLength(2);

                entity.Property(e => e.Kullanici).HasMaxLength(50);

                entity.Property(e => e.Ref)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REF");

                entity.Property(e => e.RefGuid).HasColumnName("refGuid");

                entity.Property(e => e.SatisTuru).HasMaxLength(50);

                entity.Property(e => e.Stokkodu).HasMaxLength(20);

                entity.Property(e => e.StopajKodu).HasMaxLength(20);

                entity.Property(e => e.StopajOrani).HasColumnName("stopajOrani");

                entity.Property(e => e.TamIstisnaKodu)
                    .HasMaxLength(50)
                    .HasColumnName("tamIstisnaKodu");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.Property(e => e.TevkifatKodu).HasMaxLength(20);

                entity.Property(e => e.Torani)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vergino).HasMaxLength(11);
            });

            modelBuilder.Entity<Hesapisletgel>(entity =>
            {
                entity.HasKey(e => new { e.Gelorgid, e.Kod });

                entity.ToTable("hesapisletgel");

                entity.Property(e => e.Gelorgid)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Kod).HasMaxLength(20);

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Anakod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BelgeTuru).HasMaxLength(50);

                entity.Property(e => e.Detay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IstisnaKodu).HasMaxLength(50);

                entity.Property(e => e.KayitAltTuru).HasMaxLength(50);

                entity.Property(e => e.KayitTuru).HasMaxLength(50);

                entity.Property(e => e.KdvsizIslem).HasColumnName("kdvsizIslem");

                entity.Property(e => e.SatisTuru).HasMaxLength(50);

                entity.Property(e => e.Stokkodu).HasMaxLength(20);

                entity.Property(e => e.StopajKodu).HasMaxLength(20);

                entity.Property(e => e.StopajOrani).HasColumnName("stopajOrani");

                entity.Property(e => e.TamIstisnaKodu)
                    .HasMaxLength(50)
                    .HasColumnName("tamIstisnaKodu");

                entity.Property(e => e.TevkifatKodu).HasMaxLength(20);
            });

            modelBuilder.Entity<Hesok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hesok");

                entity.Property(e => e.G13).HasMaxLength(25);
            });

            modelBuilder.Entity<Hesplan>(entity =>
            {
                entity.HasKey(e => e.Kod)
                    .HasName("pk_hesplan");

                entity.ToTable("hesplan");

                entity.HasIndex(e => e.Detay, "hesplan_idx_detay");

                entity.Property(e => e.Kod).HasMaxLength(20);

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.Ba1).HasMaxLength(1);

                entity.Property(e => e.Ba2).HasMaxLength(1);

                entity.Property(e => e.Ba3).HasMaxLength(2);

                entity.Property(e => e.Blerdekullan)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Detay).HasMaxLength(1);

                entity.Property(e => e.Diger2Eh)
                    .HasMaxLength(1)
                    .HasColumnName("Diger2EH");

                entity.Property(e => e.Diger3Eh)
                    .HasMaxLength(1)
                    .HasColumnName("Diger3EH");

                entity.Property(e => e.DigerEh)
                    .HasMaxLength(1)
                    .HasColumnName("DigerEH");

                entity.Property(e => e.Grup).HasMaxLength(20);

                entity.Property(e => e.IadeKdvmi)
                    .HasMaxLength(1)
                    .HasColumnName("Iade_KDVmi");

                entity.Property(e => e.IlaveEdilecekKdvmi)
                    .HasMaxLength(1)
                    .HasColumnName("Ilave_Edilecek_KDVmi");

                entity.Property(e => e.Indirimmi).HasMaxLength(1);

                entity.Property(e => e.Kamuorozel).HasMaxLength(1);

                entity.Property(e => e.KdvislemTuru)
                    .HasMaxLength(3)
                    .HasColumnName("KDVislemTuru");

                entity.Property(e => e.KdvislemTuru2)
                    .HasMaxLength(3)
                    .HasColumnName("KDVislemTuru2");

                entity.Property(e => e.KdvislemTuru3)
                    .HasMaxLength(3)
                    .HasColumnName("KDVislemTuru3");

                entity.Property(e => e.KdvislemTuruint).HasColumnName("KDVislemTuruint");

                entity.Property(e => e.KdvislemTuruint2).HasColumnName("KDVislemTuruint2");

                entity.Property(e => e.KdvislemTuruint3).HasColumnName("KDVislemTuruint3");

                entity.Property(e => e.Kod2).HasMaxLength(20);

                entity.Property(e => e.KrediKartiSatisimi)
                    .HasMaxLength(1)
                    .HasColumnName("Kredi_Karti_Satisimi");

                entity.Property(e => e.Kurfarkindakullan).HasMaxLength(1);

                entity.Property(e => e.NormalKdvmi)
                    .HasMaxLength(1)
                    .HasColumnName("Normal_KDVmi");

                entity.Property(e => e.Stokkodu).HasMaxLength(20);

                entity.Property(e => e.StopajEvrakTuru).HasColumnName("Stopaj_evrak_turu");

                entity.Property(e => e.StopajHesKodu)
                    .HasMaxLength(20)
                    .HasColumnName("Stopaj_hes_kodu");

                entity.Property(e => e.StopajOrani).HasColumnName("Stopaj_orani");

                entity.Property(e => e.StopajTurKodu)
                    .HasMaxLength(3)
                    .HasColumnName("Stopaj_tur_kodu");

                entity.Property(e => e.Tckimlikno).HasMaxLength(11);

                entity.Property(e => e.TevHesKodu)
                    .HasMaxLength(20)
                    .HasColumnName("Tev_hes_kodu");

                entity.Property(e => e.TevOrani)
                    .HasMaxLength(5)
                    .HasColumnName("Tev_orani");

                entity.Property(e => e.TevTurKodu)
                    .HasMaxLength(3)
                    .HasColumnName("Tev_tur_kodu");

                entity.Property(e => e.Ulkekodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vergidairesi).HasMaxLength(20);

                entity.Property(e => e.Vergikimlikno).HasMaxLength(11);

                entity.Property(e => e.Yabanci).HasMaxLength(50);
            });

            modelBuilder.Entity<Hesplancariler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hesplancariler");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(200)
                    .HasColumnName("aciklama");

                entity.Property(e => e.Adres1).HasMaxLength(100);

                entity.Property(e => e.Adres2).HasMaxLength(100);

                entity.Property(e => e.Adres3).HasMaxLength(100);

                entity.Property(e => e.Adres4).HasMaxLength(100);

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.Cariadi).HasMaxLength(70);

                entity.Property(e => e.Cep1).HasMaxLength(15);

                entity.Property(e => e.Cep2).HasMaxLength(15);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Email2).HasMaxLength(150);

                entity.Property(e => e.Fax1).HasMaxLength(15);

                entity.Property(e => e.Fax2).HasMaxLength(15);

                entity.Property(e => e.Heskod).HasMaxLength(20);

                entity.Property(e => e.Heskod2).HasMaxLength(20);

                entity.Property(e => e.Il).HasMaxLength(30);

                entity.Property(e => e.Ilce).HasMaxLength(30);

                entity.Property(e => e.Kod).HasMaxLength(20);

                entity.Property(e => e.MusavirAdi)
                    .HasMaxLength(50)
                    .HasColumnName("Musavir_adi");

                entity.Property(e => e.MusavirSicilno)
                    .HasMaxLength(20)
                    .HasColumnName("Musavir_sicilno");

                entity.Property(e => e.MusavirTcno)
                    .HasMaxLength(11)
                    .HasColumnName("Musavir_tcno");

                entity.Property(e => e.MusavirTel)
                    .HasMaxLength(15)
                    .HasColumnName("Musavir_tel");

                entity.Property(e => e.MusavirVergino)
                    .HasMaxLength(11)
                    .HasColumnName("Musavir_vergino");

                entity.Property(e => e.Nereden)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postakodu).HasMaxLength(15);

                entity.Property(e => e.Tckimlikno).HasMaxLength(11);

                entity.Property(e => e.Tel1).HasMaxLength(15);

                entity.Property(e => e.Tel2).HasMaxLength(15);

                entity.Property(e => e.Tel3).HasMaxLength(15);

                entity.Property(e => e.Tel4).HasMaxLength(15);

                entity.Property(e => e.Ulke).HasMaxLength(30);

                entity.Property(e => e.Ulkekodu)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unvan).HasMaxLength(150);

                entity.Property(e => e.VergiDairesiKodu).HasMaxLength(10);

                entity.Property(e => e.Vergidairesi).HasMaxLength(20);

                entity.Property(e => e.Vergikimlikno).HasMaxLength(11);

                entity.Property(e => e.Webadresi).HasMaxLength(150);

                entity.Property(e => e.Yetkili).HasMaxLength(30);

                entity.Property(e => e.Yetkiligorevi).HasMaxLength(50);
            });

            modelBuilder.Entity<Islemkod>(entity =>
            {
                entity.HasKey(e => e.Ref)
                    .HasName("PK__ISLEMKOD__CAFFA0B33EFC4F81");

                entity.ToTable("ISLEMKOD");

                entity.Property(e => e.Ref).HasColumnName("REF");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");

                entity.Property(e => e.Islemkodu).HasColumnName("ISLEMKODU");

                entity.Property(e => e.Modulkodu).HasColumnName("MODULKODU");

                entity.Property(e => e.Sbtbilgisi)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SBTBILGISI");
            });

            modelBuilder.Entity<Kapandsm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kapandsm");

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.Hk).HasMaxLength(20);
            });

            modelBuilder.Entity<Kapaniki>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kapaniki");

                entity.Property(e => e.Khk).HasMaxLength(17);

                entity.Property(e => e.Tip).HasMaxLength(1);

                entity.Property(e => e.Yhk).HasMaxLength(17);
            });

            modelBuilder.Entity<Kapanuc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kapanuc");

                entity.Property(e => e.Khkba).HasMaxLength(20);

                entity.Property(e => e.Khkbi).HasMaxLength(20);

                entity.Property(e => e.Yahk).HasMaxLength(20);

                entity.Property(e => e.Yhk).HasMaxLength(20);
            });

            modelBuilder.Entity<Kapanuco>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kapanuco");

                entity.Property(e => e.Khkba).HasMaxLength(20);

                entity.Property(e => e.Khkbi).HasMaxLength(20);

                entity.Property(e => e.Yahk).HasMaxLength(20);

                entity.Property(e => e.Yhk).HasMaxLength(20);
            });

            modelBuilder.Entity<KarDagitim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KarDagitim");

                entity.Property(e => e.Aciklama).HasMaxLength(100);

                entity.Property(e => e.Isaret)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("isaret")
                    .IsFixedLength();
            });

            modelBuilder.Entity<KdvIndirilecek>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Kdv_indirilecek");

                entity.Property(e => e.Adi).HasMaxLength(30);

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.Cinsi).HasMaxLength(90);

                entity.Property(e => e.FaturaNo)
                    .HasMaxLength(20)
                    .HasColumnName("Fatura_No");

                entity.Property(e => e.FaturaTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("Fatura_Tarihi");

                entity.Property(e => e.Kdv).HasColumnName("KDV");

                entity.Property(e => e.Soyadi).HasMaxLength(30);

                entity.Property(e => e.Tckimlikno).HasMaxLength(11);

                entity.Property(e => e.Vergino).HasMaxLength(10);
            });

            modelBuilder.Entity<LogFi>(entity =>
            {
                entity.HasKey(e => e.Arti);

                entity.Property(e => e.Ekaciklama).HasMaxLength(500);

                entity.Property(e => e.FisGuid).HasColumnName("fis_guid");

                entity.Property(e => e.FisbilPid)
                    .HasMaxLength(18)
                    .HasColumnName("fisbil_pid");

                entity.Property(e => e.Fisekilit).HasMaxLength(1);

                entity.Property(e => e.Fisno).HasMaxLength(9);

                entity.Property(e => e.Fistar).HasColumnType("smalldatetime");

                entity.Property(e => e.Fistur).HasMaxLength(1);

                entity.Property(e => e.Kayittarihi).HasColumnType("datetime");

                entity.Property(e => e.Kullanici).HasMaxLength(150);

                entity.Property(e => e.LogTuru).HasMaxLength(1);

                entity.Property(e => e.Masrafmerkezi).HasMaxLength(10);

                entity.Property(e => e.Nereden).HasMaxLength(1);

                entity.Property(e => e.Onaylimi).HasMaxLength(1);

                entity.Property(e => e.Ozkod).HasMaxLength(50);

                entity.Property(e => e.Sube).HasMaxLength(2);

                entity.Property(e => e.UyariGuid).HasColumnName("UyariGUID");
            });

            modelBuilder.Entity<LogUyari>(entity =>
            {
                entity.ToTable("LogUyari");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Kullanici).HasMaxLength(150);

                entity.Property(e => e.Mesaj).HasMaxLength(250);

                entity.Property(e => e.Sqltar)
                    .HasColumnType("datetime")
                    .HasColumnName("SQLTar");

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            modelBuilder.Entity<LogYev>(entity =>
            {
                entity.HasKey(e => e.Arti);

                entity.ToTable("LogYev");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.BelgeTuru).HasColumnName("Belge_Turu");

                entity.Property(e => e.BelgeTuruAciklamasi)
                    .HasMaxLength(50)
                    .HasColumnName("Belge_Turu_Aciklamasi");

                entity.Property(e => e.Evrakno).HasMaxLength(16);

                entity.Property(e => e.Evraktarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.FInt).HasColumnName("f_int");

                entity.Property(e => e.FIslemkodu).HasColumnName("f_islemkodu");

                entity.Property(e => e.FStr)
                    .HasMaxLength(80)
                    .HasColumnName("f_str");

                entity.Property(e => e.FisGuid).HasColumnName("fis_guid");

                entity.Property(e => e.FisbilPid)
                    .HasMaxLength(18)
                    .HasColumnName("fisbil_pid");

                entity.Property(e => e.Fisno).HasMaxLength(9);

                entity.Property(e => e.Fistar).HasColumnType("smalldatetime");

                entity.Property(e => e.Fistur).HasMaxLength(1);

                entity.Property(e => e.Gmkod).HasMaxLength(20);

                entity.Property(e => e.IsDegisti).HasColumnName("isDegisti");

                entity.Property(e => e.Masrafmerkezi).HasMaxLength(10);

                entity.Property(e => e.OdemeSekli).HasColumnName("Odeme_Sekli");

                entity.Property(e => e.Serino)
                    .HasMaxLength(5)
                    .HasColumnName("serino");

                entity.Property(e => e.SpId)
                    .HasMaxLength(50)
                    .HasColumnName("sp_id");

                entity.Property(e => e.Stk).HasMaxLength(20);

                entity.Property(e => e.Tip).HasMaxLength(1);

                entity.Property(e => e.VadeTarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Vade_Tarihi");

                entity.Property(e => e.Vergino).HasMaxLength(11);
            });

            modelBuilder.Entity<Nazim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nazim");

                entity.Property(e => e.Art).HasMaxLength(1);

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.Kod).HasMaxLength(20);
            });

            modelBuilder.Entity<Onay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Onay");

                entity.Property(e => e.GelirOnay)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Gelir_onay");

                entity.Property(e => e.GiderOnay)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Gider_onay");

                entity.Property(e => e.GmuhOnay)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Gmuh_onay");
            });

            modelBuilder.Entity<Satmaliyeti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("satmaliyeti");

                entity.Property(e => e.Kod).HasMaxLength(3);

                entity.Property(e => e.Mad).HasMaxLength(80);
            });

            modelBuilder.Entity<Servi>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ServisTarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.Tarih).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Stokbf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stokbf");

                entity.Property(e => e.AlyBirimFiyat).HasColumnName("Aly? Birim Fiyat");

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.SatyBirimFiyat).HasColumnName("Saty? Birim Fiyat");

                entity.Property(e => e.Tarih).HasColumnType("smalldatetime");

                entity.Property(e => e.Tarihd).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Stokgenm>(entity =>
            {
                entity.HasKey(e => e.Stk);

                entity.ToTable("stokgenm");

                entity.Property(e => e.Stk).HasMaxLength(20);

                entity.Property(e => e.Eyontemi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ref).ValueGeneratedOnAdd();

                entity.Property(e => e.Sta).HasMaxLength(40);

                entity.Property(e => e.Stb).HasMaxLength(8);

                entity.Property(e => e.Ticari)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Stoktar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stoktar");

                entity.Property(e => e.Dbi).HasMaxLength(2);

                entity.Property(e => e.Evrakno).HasMaxLength(16);

                entity.Property(e => e.Iademi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sno).ValueGeneratedOnAdd();

                entity.Property(e => e.Sta).HasMaxLength(75);

                entity.Property(e => e.Stt).HasColumnType("smalldatetime");

                entity.Property(e => e.Tip).HasMaxLength(1);

                entity.Property(e => e.Tip2).HasMaxLength(2);

                entity.Property(e => e.Tip3).HasMaxLength(1);
            });

            modelBuilder.Entity<Stopajlar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stopajlar");

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Adres).HasMaxLength(250);

                entity.Property(e => e.Ehalt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ehust)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Evrakno).HasMaxLength(30);

                entity.Property(e => e.Sirano).ValueGeneratedOnAdd();

                entity.Property(e => e.Soyadi).HasMaxLength(50);

                entity.Property(e => e.Tarbas).HasColumnType("smalldatetime");

                entity.Property(e => e.Tarbit).HasColumnType("smalldatetime");

                entity.Property(e => e.Tckimlikno).HasMaxLength(11);

                entity.Property(e => e.Tk).HasMaxLength(11);

                entity.Property(e => e.Vkn).HasMaxLength(11);
            });

            modelBuilder.Entity<TbEdefterKontrol>(entity =>
            {
                entity.HasKey(e => e.EdefterKontrolId)
                    .HasName("PK__tbEDefte__FAD0FFAF20EF2BB2");

                entity.ToTable("tbEDefterKontrol");

                entity.Property(e => e.EdefterKontrolId).HasColumnName("EDefterKontrolId");

                entity.Property(e => e.GuncellemeTarihi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KayitTarihi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TbEdefterKontrolDetay>(entity =>
            {
                entity.HasKey(e => e.EdefterKontrolDetayId)
                    .HasName("PK__tbEDefte__408AE856298471B3");

                entity.ToTable("tbEDefterKontrolDetay");

                entity.Property(e => e.EdefterKontrolDetayId).HasColumnName("EDefterKontrolDetayId");

                entity.Property(e => e.EdefterKontrolId).HasColumnName("EDefterKontrolId");

                entity.Property(e => e.KayitTarihi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.EdefterKontrol)
                    .WithMany(p => p.TbEdefterKontrolDetays)
                    .HasForeignKey(d => d.EdefterKontrolId)
                    .HasConstraintName("FK__tbEDefter__EDeft__2D550297");
            });

            modelBuilder.Entity<TbEdefterKontrolDetayFi>(entity =>
            {
                entity.HasKey(e => e.EdefterKontrolDetayFisId)
                    .HasName("PK__tbEDefte__49E04C7F30316F42");

                entity.ToTable("tbEDefterKontrolDetayFis");

                entity.Property(e => e.EdefterKontrolDetayFisId).HasColumnName("EDefterKontrolDetayFisId");

                entity.Property(e => e.EdefterKontrolDetayId).HasColumnName("EDefterKontrolDetayId");

                entity.HasOne(d => d.EdefterKontrolDetay)
                    .WithMany(p => p.TbEdefterKontrolDetayFis)
                    .HasForeignKey(d => d.EdefterKontrolDetayId)
                    .HasConstraintName("FK__tbEDefter__EDeft__3219B7B4");
            });

            modelBuilder.Entity<TbEdefterKontrolDetayFisYevmiye>(entity =>
            {
                entity.HasKey(e => e.EdefterKontrolDetayFisYevmiyeId)
                    .HasName("PK__tbEDefte__244CB81734F6245F");

                entity.ToTable("tbEDefterKontrolDetayFisYevmiye");

                entity.Property(e => e.EdefterKontrolDetayFisYevmiyeId).HasColumnName("EDefterKontrolDetayFisYevmiyeId");

                entity.Property(e => e.EdefterKontrolDetayFisId).HasColumnName("EDefterKontrolDetayFisId");

                entity.HasOne(d => d.EdefterKontrolDetayFis)
                    .WithMany(p => p.TbEdefterKontrolDetayFisYevmiyes)
                    .HasForeignKey(d => d.EdefterKontrolDetayFisId)
                    .HasConstraintName("FK__tbEDefter__EDeft__36DE6CD1");
            });

            modelBuilder.Entity<TbHesapPlaniCache>(entity =>
            {
                entity.HasKey(e => e.Kod)
                    .HasName("PK__tbHesapP__C41FEDBD347EC10E");

                entity.ToTable("tbHesapPlaniCache");

                entity.Property(e => e.Kod).HasMaxLength(20);

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Detay).HasMaxLength(1);

                entity.Property(e => e.UpperAciklama).HasMaxLength(50);

                entity.Property(e => e.UpperKod).HasMaxLength(20);
            });

            modelBuilder.Entity<TbHesapPlaniGuncellemeListesi>(entity =>
            {
                entity.ToTable("tbHesapPlaniGuncellemeListesi");

                entity.Property(e => e.Kod).HasMaxLength(20);
            });

            modelBuilder.Entity<TbHesapPlaniKurFarki>(entity =>
            {
                entity.ToTable("tbHesapPlaniKurFarki");

                entity.Property(e => e.Kod).HasMaxLength(20);

                entity.Property(e => e.KurTuru).HasMaxLength(20);
            });

            modelBuilder.Entity<TbInvoiceHead>(entity =>
            {
                entity.HasKey(e => e.InvoiceHeadId)
                    .HasName("tbInvoiceHead_pk");

                entity.ToTable("tbInvoiceHead", "hub");

                entity.HasIndex(e => e.FisBilRefNo, "tbInvoiceHead_idx_FisBilRefNo");

                entity.HasIndex(e => e.InvoiceSourceAppId, "tbInvoiceHead_idx_InvoiceSourceAppId");

                entity.HasIndex(e => e.SourceCompanyId, "tbInvoiceHead_idx_SourceCompanyId");

                entity.Property(e => e.BankCode).HasMaxLength(20);

                entity.Property(e => e.BranchCode).HasMaxLength(40);

                entity.Property(e => e.CashCode).HasMaxLength(20);

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.DepartmentCode).HasMaxLength(20);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(40);

                entity.Property(e => e.FirmCode).HasMaxLength(100);

                entity.Property(e => e.FirmTaxId).HasMaxLength(20);

                entity.Property(e => e.FirmTitle).HasMaxLength(255);

                entity.Property(e => e.GrandTotalTl).HasColumnName("GrandTotalTL");

                entity.Property(e => e.InvoiceFormat).HasMaxLength(20);

                entity.Property(e => e.InvoiceSourceAppId).HasDefaultValueSql("((1))");

                entity.Property(e => e.InvoiceType).HasMaxLength(10);

                entity.Property(e => e.MongoId).HasMaxLength(40);

                entity.Property(e => e.OtherTaxTl).HasColumnName("OtherTaxTL");

                entity.Property(e => e.RefId)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RejectDescription).HasMaxLength(255);

                entity.Property(e => e.VatTl).HasColumnName("VatTL");

                entity.HasOne(d => d.InvoiceSourceApp)
                    .WithMany(p => p.TbInvoiceHeads)
                    .HasForeignKey(d => d.InvoiceSourceAppId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbInvoice__Invoi__0683B78B");
            });

            modelBuilder.Entity<TbInvoiceLine>(entity =>
            {
                entity.HasKey(e => e.InvoiceLineId)
                    .HasName("PK__tbInvoic__0D760AD958BC2184");

                entity.ToTable("tbInvoiceLine", "hub");

                entity.HasIndex(e => e.InvoiceHeadId, "tbInvoiceLine_idx_InvoiceHeadId");

                entity.Property(e => e.BagkurTl).HasColumnName("BagkurTL");

                entity.Property(e => e.BorsaTl).HasColumnName("BorsaTL");

                entity.Property(e => e.CurrencyCode).HasMaxLength(3);

                entity.Property(e => e.DiscountTl).HasColumnName("DiscountTL");

                entity.Property(e => e.FonTl).HasColumnName("FonTL");

                entity.Property(e => e.HalKomisyon).HasColumnName("halKomisyon");

                entity.Property(e => e.HalKomisyonKdv).HasColumnName("halKomisyonKdv");

                entity.Property(e => e.HalRusum).HasColumnName("halRusum");

                entity.Property(e => e.HalRusumKdv).HasColumnName("halRusumKdv");

                entity.Property(e => e.Hammaliye).HasColumnName("hammaliye");

                entity.Property(e => e.HammaliyeKdv).HasColumnName("hammaliyeKdv");

                entity.Property(e => e.MeraTl).HasColumnName("MeraTL");

                entity.Property(e => e.MusRusum).HasColumnName("musRusum");

                entity.Property(e => e.MusRusumKdv).HasColumnName("musRusumKdv");

                entity.Property(e => e.Navlun).HasColumnName("navlun");

                entity.Property(e => e.NavlunKdv).HasColumnName("navlunKdv");

                entity.Property(e => e.NetAmountTl).HasColumnName("NetAmountTL");

                entity.Property(e => e.OivTl).HasColumnName("OivTL");

                entity.Property(e => e.OtvTl).HasColumnName("OtvTL");

                entity.Property(e => e.PseCode).HasMaxLength(50);

                entity.Property(e => e.PseName).HasMaxLength(255);

                entity.Property(e => e.PseType).HasMaxLength(20);

                entity.Property(e => e.Rehin).HasColumnName("rehin");

                entity.Property(e => e.RehinKdv).HasColumnName("rehinKdv");

                entity.Property(e => e.Sandik).HasColumnName("sandik");

                entity.Property(e => e.SandikKdv).HasColumnName("sandikKdv");

                entity.Property(e => e.Tax0021).HasColumnName("tax0021");

                entity.Property(e => e.Tax0061).HasColumnName("tax0061");

                entity.Property(e => e.Tax1047).HasColumnName("tax1047");

                entity.Property(e => e.Tax1048).HasColumnName("tax1048");

                entity.Property(e => e.Tax4071).HasColumnName("tax4071");

                entity.Property(e => e.Tax8001).HasColumnName("tax8001");

                entity.Property(e => e.Tax8002).HasColumnName("tax8002");

                entity.Property(e => e.Tax8004).HasColumnName("tax8004");

                entity.Property(e => e.Tax8005).HasColumnName("tax8005");

                entity.Property(e => e.Tax8006).HasColumnName("tax8006");

                entity.Property(e => e.Tax8007).HasColumnName("tax8007");

                entity.Property(e => e.Tax8008).HasColumnName("tax8008");

                entity.Property(e => e.Tax9021).HasColumnName("tax9021");

                entity.Property(e => e.TotalTl).HasColumnName("TotalTL");

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.Property(e => e.UnitPriceTl).HasColumnName("UnitPriceTL");

                entity.Property(e => e.VatTl).HasColumnName("VatTL");

                entity.Property(e => e.VatWitholdingRate).HasMaxLength(20);

                entity.Property(e => e.VatWitholdingTl).HasColumnName("VatWitholdingTL");

                entity.Property(e => e.WitholdingTaxTl).HasColumnName("WitholdingTaxTL");

                entity.HasOne(d => d.InvoiceHead)
                    .WithMany(p => p.TbInvoiceLines)
                    .HasForeignKey(d => d.InvoiceHeadId)
                    .HasConstraintName("tbInvoiceLine_fk_tbInvoiceHead");
            });

            modelBuilder.Entity<TbInvoiceSourceApp>(entity =>
            {
                entity.HasKey(e => e.InvoiceSourceAppId)
                    .HasName("PK__tbInvoic__1822517303A74AE0");

                entity.ToTable("tbInvoiceSourceApp", "hub");

                entity.Property(e => e.InvoiceSourceAppId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<TbMuhasebelestirIsletmeDefteriAyarlari>(entity =>
            {
                entity.HasKey(e => e.MuhasebelestirIsletmeDefteriAyarlariId)
                    .HasName("PK__tbMuhase__D34610767C86175C");

                entity.ToTable("tbMuhasebelestirIsletmeDefteriAyarlari");

                entity.Property(e => e.MuhasebelestirIsletmeDefteriAyarlariId).ValueGeneratedNever();

                entity.Property(e => e.EarsivGelirBelgeTuru).HasColumnName("EArsivGelirBelgeTuru");

                entity.Property(e => e.EarsivGelirKayitAltTuru).HasColumnName("EArsivGelirKayitAltTuru");

                entity.Property(e => e.EarsivGelirKayitTuru).HasColumnName("EArsivGelirKayitTuru");

                entity.Property(e => e.EarsivGelirSatisTuru).HasColumnName("EArsivGelirSatisTuru");

                entity.Property(e => e.EarsivGiderBelgeTuru).HasColumnName("EArsivGiderBelgeTuru");

                entity.Property(e => e.EarsivGiderKayitAltTuru).HasColumnName("EArsivGiderKayitAltTuru");

                entity.Property(e => e.EarsivGiderKayitTuru).HasColumnName("EArsivGiderKayitTuru");

                entity.Property(e => e.EarsivGiderSatisTuru).HasColumnName("EArsivGiderSatisTuru");

                entity.Property(e => e.EfaturaGelirBelgeTuru).HasColumnName("EFaturaGelirBelgeTuru");

                entity.Property(e => e.EfaturaGelirKayitAltTuru).HasColumnName("EFaturaGelirKayitAltTuru");

                entity.Property(e => e.EfaturaGelirKayitTuru).HasColumnName("EFaturaGelirKayitTuru");

                entity.Property(e => e.EfaturaGelirSatisTuru).HasColumnName("EFaturaGelirSatisTuru");

                entity.Property(e => e.EfaturaGiderBelgeTuru).HasColumnName("EFaturaGiderBelgeTuru");

                entity.Property(e => e.EfaturaGiderKayitAltTuru).HasColumnName("EFaturaGiderKayitAltTuru");

                entity.Property(e => e.EfaturaGiderKayitTuru).HasColumnName("EFaturaGiderKayitTuru");

                entity.Property(e => e.EfaturaGiderSatisTuru).HasColumnName("EFaturaGiderSatisTuru");
            });

            modelBuilder.Entity<TbMuhasebelestirmeAyarlari>(entity =>
            {
                entity.HasKey(e => e.MuhasebelestirmeAyarlariId)
                    .HasName("PK__tbMuhase__3ADBDA43642DD430");

                entity.ToTable("tbMuhasebelestirmeAyarlari");

                entity.HasIndex(e => e.BelgeTuruId, "tbMuhasebelestirmeAyarlari_idx_BelgeTuruId");

                entity.HasOne(d => d.BelgeTuru)
                    .WithMany(p => p.TbMuhasebelestirmeAyarlaris)
                    .HasForeignKey(d => d.BelgeTuruId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbMuhasebelestirmeAyarlari_fk_tbBelgeTuru");
            });

            modelBuilder.Entity<TbMuhasebelestirmeBelgeTuru>(entity =>
            {
                entity.HasKey(e => e.BelgeTuruId)
                    .HasName("PK__tbMuhase__9AE55FEC5D80D6A1");

                entity.ToTable("tbMuhasebelestirmeBelgeTuru");

                entity.HasIndex(e => e.Aciklama, "UQ__tbMuhase__4815C04F605D434C")
                    .IsUnique();

                entity.Property(e => e.BelgeTuruId).ValueGeneratedNever();

                entity.Property(e => e.Aciklama).HasMaxLength(50);
            });

            modelBuilder.Entity<TbStokEslestir>(entity =>
            {
                entity.HasKey(e => e.FaturaStokKodu)
                    .HasName("tbStokEslestir_pk");

                entity.ToTable("tbStokEslestir", "hub");

                entity.HasIndex(e => e.FaturaStokKodu, "tbStokEslestir_idx_FaturaStokKodu");

                entity.HasIndex(e => e.MuhasebeStokKodu, "tbStokEslestir_idx_MuhasebeStokKodu");

                entity.Property(e => e.FaturaStokKodu).HasMaxLength(50);

                entity.Property(e => e.MuhasebeStokKodu).HasMaxLength(20);
            });

            modelBuilder.Entity<TbVeriTabaniSurumu>(entity =>
            {
                entity.HasKey(e => e.VeriTabaniSurumuId);

                entity.ToTable("tbVeriTabaniSurumu");

                entity.Property(e => e.VeriTabaniSurumuId).ValueGeneratedNever();

                entity.Property(e => e.CalismaZamani).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbYillikAyarlar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbYillikAyarlar");

                entity.Property(e => e.YillikAyarlarId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblBfomuAek>(entity =>
            {
                entity.ToTable("tblBFomuAEk");

                entity.Property(e => e.EbelgeAdedi).HasColumnName("EBelgeAdedi");

                entity.Property(e => e.EbelgeToplami).HasColumnName("EBelgeToplami");
            });

            modelBuilder.Entity<TblBfomuSek>(entity =>
            {
                entity.ToTable("tblBFomuSEk");

                entity.Property(e => e.EbelgeAdedi).HasColumnName("EBelgeAdedi");

                entity.Property(e => e.EbelgeToplami).HasColumnName("EBelgeToplami");
            });

            modelBuilder.Entity<Tbsil>(entity =>
            {
                entity.ToTable("tbsil");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.YeniField)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransferIliskiliKisiler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Transfer_iliskili_kisiler");

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.BulunduguUlke)
                    .HasMaxLength(100)
                    .HasColumnName("Bulundugu_Ulke");

                entity.Property(e => e.TckimlikNo)
                    .HasMaxLength(11)
                    .HasColumnName("TCKimlikNo");

                entity.Property(e => e.VergiNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Vergi_No")
                    .IsFixedLength();

                entity.Property(e => e.YurtDisindaIliskiliKisi)
                    .HasMaxLength(60)
                    .HasColumnName("Yurt_Disinda_iliskili_kisi");

                entity.Property(e => e.YurtIcindeIliskiliKisi)
                    .HasMaxLength(60)
                    .HasColumnName("Yurt_icinde_iliskili_kisi");
            });

            modelBuilder.Entity<TransferIliskinIslemler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Transfer_iliskin_islemler");

                entity.Property(e => e.Aciklama).HasMaxLength(255);

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.Tur).HasMaxLength(100);
            });

            modelBuilder.Entity<TransferIstirakler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Transfer_istirakler");

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.SermayeOrani).HasColumnName("Sermaye_Orani");

                entity.Property(e => e.Ulke).HasMaxLength(100);

                entity.Property(e => e.Unvani).HasMaxLength(60);
            });

            modelBuilder.Entity<TransferMaliIslemler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Transfer_Mali_islemler");

                entity.Property(e => e.Aciklama).HasMaxLength(100);

                entity.Property(e => e.AlimAnaPara).HasColumnName("Alim_Ana_Para");

                entity.Property(e => e.AlimFaiz).HasColumnName("Alim_Faiz");

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();

                entity.Property(e => e.SatimAnaPara).HasColumnName("Satim_Ana_Para");

                entity.Property(e => e.SatimFaiz).HasColumnName("Satim_Faiz");
            });

            modelBuilder.Entity<TransferOrtuluSermaye>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Transfer_Ortulu_Sermaye");

                entity.Property(e => e.Aciklama).HasMaxLength(110);

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TransferYontemler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Transfer_Yontemler");

                entity.Property(e => e.Aciklama).HasMaxLength(100);

                entity.Property(e => e.Arti).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VGetDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_GetDate");

                entity.Property(e => e.GetDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<YabanciParaPozisyonu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Yabanci_Para_Pozisyonu");

                entity.Property(e => e.Aciklama).HasMaxLength(100);
            });

            modelBuilder.Entity<YekTbl>(entity =>
            {
                entity.ToTable("yekTbl");

                entity.HasIndex(e => new { e.Refno, e.Refno2 }, "IX_yekTbl");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.F1)
                    .HasMaxLength(150)
                    .HasColumnName("f1");

                entity.Property(e => e.F10)
                    .HasMaxLength(150)
                    .HasColumnName("f10");

                entity.Property(e => e.F11)
                    .HasMaxLength(150)
                    .HasColumnName("f11");

                entity.Property(e => e.F12)
                    .HasMaxLength(150)
                    .HasColumnName("f12");

                entity.Property(e => e.F13)
                    .HasMaxLength(150)
                    .HasColumnName("f13");

                entity.Property(e => e.F14)
                    .HasMaxLength(150)
                    .HasColumnName("f14");

                entity.Property(e => e.F15)
                    .HasMaxLength(150)
                    .HasColumnName("f15");

                entity.Property(e => e.F16)
                    .HasMaxLength(150)
                    .HasColumnName("f16");

                entity.Property(e => e.F17)
                    .HasMaxLength(150)
                    .HasColumnName("f17");

                entity.Property(e => e.F18)
                    .HasMaxLength(150)
                    .HasColumnName("f18");

                entity.Property(e => e.F19)
                    .HasMaxLength(150)
                    .HasColumnName("f19");

                entity.Property(e => e.F2)
                    .HasMaxLength(150)
                    .HasColumnName("f2");

                entity.Property(e => e.F20)
                    .HasMaxLength(150)
                    .HasColumnName("f20");

                entity.Property(e => e.F21)
                    .HasMaxLength(150)
                    .HasColumnName("f21");

                entity.Property(e => e.F22)
                    .HasMaxLength(150)
                    .HasColumnName("f22");

                entity.Property(e => e.F23)
                    .HasMaxLength(150)
                    .HasColumnName("f23");

                entity.Property(e => e.F24)
                    .HasMaxLength(150)
                    .HasColumnName("f24");

                entity.Property(e => e.F25)
                    .HasMaxLength(150)
                    .HasColumnName("f25");

                entity.Property(e => e.F26)
                    .HasMaxLength(150)
                    .HasColumnName("f26");

                entity.Property(e => e.F27)
                    .HasMaxLength(150)
                    .HasColumnName("f27");

                entity.Property(e => e.F28)
                    .HasMaxLength(150)
                    .HasColumnName("f28");

                entity.Property(e => e.F29)
                    .HasMaxLength(150)
                    .HasColumnName("f29");

                entity.Property(e => e.F3)
                    .HasMaxLength(150)
                    .HasColumnName("f3");

                entity.Property(e => e.F30)
                    .HasMaxLength(150)
                    .HasColumnName("f30");

                entity.Property(e => e.F31)
                    .HasMaxLength(150)
                    .HasColumnName("f31");

                entity.Property(e => e.F32)
                    .HasMaxLength(150)
                    .HasColumnName("f32");

                entity.Property(e => e.F33)
                    .HasMaxLength(150)
                    .HasColumnName("f33");

                entity.Property(e => e.F34)
                    .HasMaxLength(150)
                    .HasColumnName("f34");

                entity.Property(e => e.F35)
                    .HasMaxLength(150)
                    .HasColumnName("f35");

                entity.Property(e => e.F36)
                    .HasMaxLength(150)
                    .HasColumnName("f36");

                entity.Property(e => e.F37)
                    .HasMaxLength(150)
                    .HasColumnName("f37");

                entity.Property(e => e.F38)
                    .HasMaxLength(150)
                    .HasColumnName("f38");

                entity.Property(e => e.F39)
                    .HasMaxLength(150)
                    .HasColumnName("f39");

                entity.Property(e => e.F4)
                    .HasMaxLength(150)
                    .HasColumnName("f4");

                entity.Property(e => e.F40)
                    .HasMaxLength(150)
                    .HasColumnName("f40");

                entity.Property(e => e.F5)
                    .HasMaxLength(150)
                    .HasColumnName("f5");

                entity.Property(e => e.F6)
                    .HasMaxLength(150)
                    .HasColumnName("f6");

                entity.Property(e => e.F7)
                    .HasMaxLength(150)
                    .HasColumnName("f7");

                entity.Property(e => e.F8)
                    .HasMaxLength(150)
                    .HasColumnName("f8");

                entity.Property(e => e.F9)
                    .HasMaxLength(150)
                    .HasColumnName("f9");
            });

            modelBuilder.Entity<Yevmisil>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("yevmisil");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.BelgeTuru).HasColumnName("Belge_Turu");

                entity.Property(e => e.BelgeTuruAciklamasi)
                    .HasMaxLength(50)
                    .HasColumnName("Belge_Turu_Aciklamasi");

                entity.Property(e => e.Evrakno).HasMaxLength(16);

                entity.Property(e => e.Evraktarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.FInt).HasColumnName("f_int");

                entity.Property(e => e.FIslemkodu).HasColumnName("f_islemkodu");

                entity.Property(e => e.FStr)
                    .HasMaxLength(80)
                    .HasColumnName("f_str");

                entity.Property(e => e.FisGuid).HasColumnName("fis_guid");

                entity.Property(e => e.FisbilPid)
                    .HasMaxLength(18)
                    .HasColumnName("fisbil_pid");

                entity.Property(e => e.Fisno).HasMaxLength(9);

                entity.Property(e => e.Fistar).HasColumnType("smalldatetime");

                entity.Property(e => e.Fistur).HasMaxLength(1);

                entity.Property(e => e.Gmkod).HasMaxLength(20);

                entity.Property(e => e.IsDegisti).HasColumnName("isDegisti");

                entity.Property(e => e.Masrafmerkezi).HasMaxLength(10);

                entity.Property(e => e.OdemeSekli).HasColumnName("Odeme_Sekli");

                entity.Property(e => e.Serino)
                    .HasMaxLength(5)
                    .HasColumnName("serino");

                entity.Property(e => e.SpId)
                    .HasMaxLength(50)
                    .HasColumnName("sp_id");

                entity.Property(e => e.Stk).HasMaxLength(20);

                entity.Property(e => e.Tip).HasMaxLength(1);

                entity.Property(e => e.VadeTarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Vade_Tarihi");

                entity.Property(e => e.Vergino).HasMaxLength(11);
            });

            modelBuilder.Entity<Yevmiye>(entity =>
            {
                entity.HasKey(e => new { e.Refno, e.Refno2 });

                entity.ToTable("yevmiye");

                entity.HasIndex(e => new { e.FStr, e.FIslemkodu, e.Refno, e.FInt }, "yevmiyeInx");

                entity.HasIndex(e => e.Gmkod, "yevmiye_idx_Gmkod");

                entity.HasIndex(e => e.Islemtipi, "yevmiye_idx_Islemtipi");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.BelgeTuru).HasColumnName("Belge_Turu");

                entity.Property(e => e.BelgeTuruAciklamasi)
                    .HasMaxLength(50)
                    .HasColumnName("Belge_Turu_Aciklamasi");

                entity.Property(e => e.Evrakno).HasMaxLength(16);

                entity.Property(e => e.Evraktarihi).HasColumnType("smalldatetime");

                entity.Property(e => e.FInt).HasColumnName("f_int");

                entity.Property(e => e.FIslemkodu).HasColumnName("f_islemkodu");

                entity.Property(e => e.FStr)
                    .HasMaxLength(80)
                    .HasColumnName("f_str");

                entity.Property(e => e.FisGuid).HasColumnName("fis_guid");

                entity.Property(e => e.FisbilPid)
                    .HasMaxLength(18)
                    .HasColumnName("fisbil_pid");

                entity.Property(e => e.Fisno).HasMaxLength(9);

                entity.Property(e => e.Fistar).HasColumnType("smalldatetime");

                entity.Property(e => e.Fistur).HasMaxLength(1);

                entity.Property(e => e.Gmkod).HasMaxLength(20);

                entity.Property(e => e.IsDegisti).HasColumnName("isDegisti");

                entity.Property(e => e.Masrafmerkezi).HasMaxLength(10);

                entity.Property(e => e.OdemeSekli).HasColumnName("Odeme_Sekli");

                entity.Property(e => e.Serino)
                    .HasMaxLength(5)
                    .HasColumnName("serino");

                entity.Property(e => e.SpId)
                    .HasMaxLength(50)
                    .HasColumnName("sp_id");

                entity.Property(e => e.Stk).HasMaxLength(20);

                entity.Property(e => e.Tip).HasMaxLength(1);

                entity.Property(e => e.VadeTarihi)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Vade_Tarihi");

                entity.Property(e => e.Vergino).HasMaxLength(11);

                entity.HasOne(d => d.RefnoNavigation)
                    .WithMany(p => p.Yevmiyes)
                    .HasForeignKey(d => d.Refno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_yevmiye_fisbil");
            });

            modelBuilder.Entity<ZRaporu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zRaporu");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Tarih).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
