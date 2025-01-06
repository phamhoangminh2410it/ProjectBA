using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectBA.Models.Entities;

public partial class HospitalContext : DbContext
{
    public HospitalContext()
    {
    }

    public HospitalContext(DbContextOptions<HospitalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Benhanngoaikhoa> Benhanngoaikhoas { get; set; }

    public virtual DbSet<Benhanngoaitrumat> Benhanngoaitrumats { get; set; }

    public virtual DbSet<Benhanngoaitrurhm> Benhanngoaitrurhms { get; set; }

    public virtual DbSet<Benhannoikhoa> Benhannoikhoas { get; set; }

    public virtual DbSet<Benhanphukhoa> Benhanphukhoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:Connection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Benhanngoaikhoa>(entity =>
        {
            entity.HasKey(e => e.Mabenhan).HasName("PK__BENHANNG__12DD671627367BBA");

            entity.ToTable("BENHANNGOAIKHOA");

            entity.Property(e => e.Mabenhan)
                .HasMaxLength(10)
                .HasColumnName("MABENHAN");
            entity.Property(e => e.Bacsidieutri)
                .HasMaxLength(255)
                .HasColumnName("BACSIDIEUTRI");
            entity.Property(e => e.Bacsilambenhan)
                .HasMaxLength(255)
                .HasColumnName("BACSILAMBENHAN");
            entity.Property(e => e.Bamtim)
                .HasMaxLength(255)
                .HasColumnName("BAMTIM");
            entity.Property(e => e.Bapbenhthan)
                .HasMaxLength(255)
                .HasColumnName("BAPBENHTHAN");
            entity.Property(e => e.Benhchinh)
                .HasMaxLength(255)
                .HasColumnName("BENHCHINH");
            entity.Property(e => e.Benhchinhkdt)
                .HasMaxLength(255)
                .HasColumnName("BENHCHINHKDT");
            entity.Property(e => e.Benhdongkinh)
                .HasMaxLength(255)
                .HasColumnName("BENHDONGKINH");
            entity.Property(e => e.Benhgout)
                .HasMaxLength(255)
                .HasColumnName("BENHGOUT");
            entity.Property(e => e.Benhhethong)
                .HasMaxLength(255)
                .HasColumnName("BENHHETHONG");
            entity.Property(e => e.Benhkemtheo)
                .HasMaxLength(255)
                .HasColumnName("BENHKEMTHEO");
            entity.Property(e => e.Benhkemtheokdt)
                .HasMaxLength(255)
                .HasColumnName("BENHKEMTHEOKDT");
            entity.Property(e => e.Benhkhac)
                .HasMaxLength(255)
                .HasColumnName("BENHKHAC");
            entity.Property(e => e.Benhlqdenchuyenhoa)
                .HasMaxLength(255)
                .HasColumnName("BENHLQDENCHUYENHOA");
            entity.Property(e => e.Benhlykhac)
                .HasMaxLength(255)
                .HasColumnName("BENHLYKHAC");
            entity.Property(e => e.Benhtimmach)
                .HasMaxLength(255)
                .HasColumnName("BENHTIMMACH");
            entity.Property(e => e.Bienchung)
                .HasMaxLength(255)
                .HasColumnName("BIENCHUNG");
            entity.Property(e => e.Bienchungkdt)
                .HasMaxLength(255)
                .HasColumnName("BIENCHUNGKDT");
            entity.Property(e => e.Biendangcotsong)
                .HasMaxLength(255)
                .HasColumnName("BIENDANGCOTSONG");
            entity.Property(e => e.Biendanghammat)
                .HasMaxLength(255)
                .HasColumnName("BIENDANGHAMMAT");
            entity.Property(e => e.Biendangxuong)
                .HasMaxLength(255)
                .HasColumnName("BIENDANGXUONG");
            entity.Property(e => e.Biendokhop)
                .HasMaxLength(255)
                .HasColumnName("BIENDOKHOP");
            entity.Property(e => e.Bmi)
                .HasMaxLength(255)
                .HasColumnName("BMI");
            entity.Property(e => e.Bungchuong)
                .HasMaxLength(255)
                .HasColumnName("BUNGCHUONG");
            entity.Property(e => e.Bungmem)
                .HasMaxLength(255)
                .HasColumnName("BUNGMEM");
            entity.Property(e => e.Cacnghiemphapkham)
                .HasMaxLength(255)
                .HasColumnName("CACNGHIEMPHAPKHAM");
            entity.Property(e => e.Cacxetnghiem)
                .HasMaxLength(255)
                .HasColumnName("CACXETNGHIEM");
            entity.Property(e => e.Camgiacnongsau)
                .HasMaxLength(255)
                .HasColumnName("CAMGIACNONGSAU");
            entity.Property(e => e.Camungphucmac)
                .HasMaxLength(255)
                .HasColumnName("CAMUNGPHUCMAC");
            entity.Property(e => e.Cancuoc)
                .HasMaxLength(30)
                .HasColumnName("CANCUOC");
            entity.Property(e => e.Candoi)
                .HasMaxLength(255)
                .HasColumnName("CANDOI");
            entity.Property(e => e.Cannang)
                .HasMaxLength(255)
                .HasColumnName("CANNANG");
            entity.Property(e => e.Caubangquang)
                .HasMaxLength(255)
                .HasColumnName("CAUBANGQUANG");
            entity.Property(e => e.Chamthan)
                .HasMaxLength(255)
                .HasColumnName("CHAMTHAN");
            entity.Property(e => e.Chedochamsoc)
                .HasMaxLength(255)
                .HasColumnName("CHEDOCHAMSOC");
            entity.Property(e => e.Chedodinhduong)
                .HasMaxLength(255)
                .HasColumnName("CHEDODINHDUONG");
            entity.Property(e => e.Chieucao)
                .HasMaxLength(255)
                .HasColumnName("CHIEUCAO");
            entity.Property(e => e.Chieudai)
                .HasMaxLength(255)
                .HasColumnName("CHIEUDAI");
            entity.Property(e => e.Chuandoanbenhvienkhac)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANBENHVIENKHAC");
            entity.Property(e => e.Chuandoanlucvaovienkdt)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANLUCVAOVIENKDT");
            entity.Property(e => e.Chuandoanphanbiekdt)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANPHANBIEKDT");
            entity.Property(e => e.Chuandoanvaovien)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANVAOVIEN");
            entity.Property(e => e.Chuyenkhoa)
                .HasMaxLength(255)
                .HasColumnName("CHUYENKHOA");
            entity.Property(e => e.Cocungthanhbung)
                .HasMaxLength(255)
                .HasColumnName("COCUNGTHANHBUNG");
            entity.Property(e => e.Cokhopxuongkhac)
                .HasMaxLength(255)
                .HasColumnName("COKHOPXUONGKHAC");
            entity.Property(e => e.Corut)
                .HasMaxLength(255)
                .HasColumnName("CORUT");
            entity.Property(e => e.Cothathaumon)
                .HasMaxLength(255)
                .HasColumnName("COTHATHAUMON");
            entity.Property(e => e.Cotsong)
                .HasMaxLength(255)
                .HasColumnName("COTSONG");
            entity.Property(e => e.Cotsongkhac)
                .HasMaxLength(255)
                .HasColumnName("COTSONGKHAC");
            entity.Property(e => e.Coxuongkhop)
                .HasMaxLength(255)
                .HasColumnName("COXUONGKHOP");
            entity.Property(e => e.Da)
                .HasMaxLength(255)
                .HasColumnName("DA");
            entity.Property(e => e.Daidiencosokbcb)
                .HasMaxLength(255)
                .HasColumnName("DAIDIENCOSOKBCB");
            entity.Property(e => e.Daithaoduong)
                .HasMaxLength(255)
                .HasColumnName("DAITHAODUONG");
            entity.Property(e => e.Dantoc)
                .HasMaxLength(20)
                .HasColumnName("DANTOC");
            entity.Property(e => e.Dauhieulamsangchinh)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEULAMSANGCHINH");
            entity.Property(e => e.Dauhieulietthankinhso)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEULIETTHANKINHSO");
            entity.Property(e => e.Dauhieulietvandong)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEULIETVANDONG");
            entity.Property(e => e.Dauhieumangnao)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEUMANGNAO");
            entity.Property(e => e.Dauhieumurphy)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEUMURPHY");
            entity.Property(e => e.Dauhieuranbo)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEURANBO");
            entity.Property(e => e.Dauhieuthankinhkhutru)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEUTHANKINHKHUTRU");
            entity.Property(e => e.Dauhieuthankinhngoaibien)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEUTHANKINHNGOAIBIEN");
            entity.Property(e => e.Dauhieuthankinhthucvat)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEUTHANKINHTHUCVAT");
            entity.Property(e => e.Diemdau)
                .HasMaxLength(255)
                .HasColumnName("DIEMDAU");
            entity.Property(e => e.Diemdaucs)
                .HasMaxLength(255)
                .HasColumnName("DIEMDAUCS");
            entity.Property(e => e.Diemdaunieuquan)
                .HasMaxLength(255)
                .HasColumnName("DIEMDAUNIEUQUAN");
            entity.Property(e => e.Dienbienbenh)
                .HasMaxLength(255)
                .HasColumnName("DIENBIENBENH");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(15)
                .HasColumnName("DIENTHOAI");
            entity.Property(e => e.Dienthoaithannhan)
                .HasMaxLength(15)
                .HasColumnName("DIENTHOAITHANNHAN");
            entity.Property(e => e.Diung)
                .HasMaxLength(255)
                .HasColumnName("DIUNG");
            entity.Property(e => e.Diunghoachat)
                .HasMaxLength(255)
                .HasColumnName("DIUNGHOACHAT");
            entity.Property(e => e.Diungkhac)
                .HasMaxLength(255)
                .HasColumnName("DIUNGKHAC");
            entity.Property(e => e.Diungthucpham)
                .HasMaxLength(255)
                .HasColumnName("DIUNGTHUCPHAM");
            entity.Property(e => e.Diungthuoc)
                .HasMaxLength(255)
                .HasColumnName("DIUNGTHUOC");
            entity.Property(e => e.Doituong)
                .HasMaxLength(20)
                .HasColumnName("DOITUONG");
            entity.Property(e => e.Dongkinh)
                .HasMaxLength(255)
                .HasColumnName("DONGKINH");
            entity.Property(e => e.Dotquy)
                .HasMaxLength(255)
                .HasColumnName("DOTQUY");
            entity.Property(e => e.Ganto)
                .HasMaxLength(255)
                .HasColumnName("GANTO");
            entity.Property(e => e.Ghichuravien)
                .HasMaxLength(255)
                .HasColumnName("GHICHURAVIEN");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(3)
                .HasColumnName("GIOITINH");
            entity.Property(e => e.Giothu)
                .HasMaxLength(255)
                .HasColumnName("GIOTHU");
            entity.Property(e => e.Hachngoaivi)
                .HasMaxLength(255)
                .HasColumnName("HACHNGOAIVI");
            entity.Property(e => e.Hammat)
                .HasMaxLength(255)
                .HasColumnName("HAMMAT");
            entity.Property(e => e.Hensuyen)
                .HasMaxLength(255)
                .HasColumnName("HENSUYEN");
            entity.Property(e => e.Hmbiendang)
                .HasMaxLength(255)
                .HasColumnName("HMBIENDANG");
            entity.Property(e => e.Hmdiemdauchoi)
                .HasMaxLength(255)
                .HasColumnName("HMDIEMDAUCHOI");
            entity.Property(e => e.Hmhamieng)
                .HasMaxLength(255)
                .HasColumnName("HMHAMIENG");
            entity.Property(e => e.Hmkhopcan)
                .HasMaxLength(255)
                .HasColumnName("HMKHOPCAN");
            entity.Property(e => e.Hmmatlientuc)
                .HasMaxLength(255)
                .HasColumnName("HMMATLIENTUC");
            entity.Property(e => e.Hmsungnebamtim)
                .HasMaxLength(255)
                .HasColumnName("HMSUNGNEBAMTIM");
            entity.Property(e => e.Hmvandong)
                .HasMaxLength(255)
                .HasColumnName("HMVANDONG");
            entity.Property(e => e.Hohapdaochieu)
                .HasMaxLength(255)
                .HasColumnName("HOHAPDAOCHIEU");
            entity.Property(e => e.Honme)
                .HasMaxLength(255)
                .HasColumnName("HONME");
            entity.Property(e => e.Hotenthannhan)
                .HasMaxLength(255)
                .HasColumnName("HOTENTHANNHAN");
            entity.Property(e => e.Hovaten)
                .HasMaxLength(255)
                .HasColumnName("HOVATEN");
            entity.Property(e => e.Huongdieutri)
                .HasMaxLength(255)
                .HasColumnName("HUONGDIEUTRI");
            entity.Property(e => e.Huongdieutritt)
                .HasMaxLength(255)
                .HasColumnName("HUONGDIEUTRITT");
            entity.Property(e => e.Huyen)
                .HasMaxLength(30)
                .HasColumnName("HUYEN");
            entity.Property(e => e.Huyetap)
                .HasMaxLength(255)
                .HasColumnName("HUYETAP");
            entity.Property(e => e.Khoiu)
                .HasMaxLength(255)
                .HasColumnName("KHOIU");
            entity.Property(e => e.Lachto)
                .HasMaxLength(255)
                .HasColumnName("LACHTO");
            entity.Property(e => e.Lanhdaokhoa)
                .HasMaxLength(255)
                .HasColumnName("LANHDAOKHOA");
            entity.Property(e => e.Lao)
                .HasMaxLength(255)
                .HasColumnName("LAO");
            entity.Property(e => e.Lieuluongsudungruoubia)
                .HasMaxLength(255)
                .HasColumnName("LIEULUONGSUDUNGRUOUBIA");
            entity.Property(e => e.Lieuluongsudungthuocla)
                .HasMaxLength(255)
                .HasColumnName("LIEULUONGSUDUNGTHUOCLA");
            entity.Property(e => e.Loaichatgaynghien)
                .HasMaxLength(255)
                .HasColumnName("LOAICHATGAYNGHIEN");
            entity.Property(e => e.Loaihoachat)
                .HasMaxLength(255)
                .HasColumnName("LOAIHOACHAT");
            entity.Property(e => e.Lomo)
                .HasMaxLength(255)
                .HasColumnName("LOMO");
            entity.Property(e => e.Lydoravien)
                .HasMaxLength(255)
                .HasColumnName("LYDORAVIEN");
            entity.Property(e => e.Lydovaovien)
                .HasMaxLength(255)
                .HasColumnName("LYDOVAOVIEN");
            entity.Property(e => e.Mabenhchinh)
                .HasMaxLength(10)
                .HasColumnName("MABENHCHINH");
            entity.Property(e => e.Mabenhchinhkdt)
                .HasMaxLength(255)
                .HasColumnName("MABENHCHINHKDT");
            entity.Property(e => e.Mabenhkemtheo)
                .HasMaxLength(10)
                .HasColumnName("MABENHKEMTHEO");
            entity.Property(e => e.Mabenhkemtheokdt)
                .HasMaxLength(255)
                .HasColumnName("MABENHKEMTHEOKDT");
            entity.Property(e => e.Mabienchung)
                .HasMaxLength(10)
                .HasColumnName("MABIENCHUNG");
            entity.Property(e => e.Mabienchungkdt)
                .HasMaxLength(255)
                .HasColumnName("MABIENCHUNGKDT");
            entity.Property(e => e.Mach)
                .HasMaxLength(255)
                .HasColumnName("MACH");
            entity.Property(e => e.Machngoaivi)
                .HasMaxLength(255)
                .HasColumnName("MACHNGOAIVI");
            entity.Property(e => e.Machuandoanlucvaovienkdt)
                .HasMaxLength(255)
                .HasColumnName("MACHUANDOANLUCVAOVIENKDT");
            entity.Property(e => e.Machuandoanphanbietkdt)
                .HasMaxLength(255)
                .HasColumnName("MACHUANDOANPHANBIETKDT");
            entity.Property(e => e.Machuandoanvaovien)
                .HasMaxLength(10)
                .HasColumnName("MACHUANDOANVAOVIEN");
            entity.Property(e => e.Macoquanchuquan)
                .HasMaxLength(10)
                .HasColumnName("MACOQUANCHUQUAN");
            entity.Property(e => e.Macosokbcb)
                .HasMaxLength(10)
                .HasColumnName("MACOSOKBCB");
            entity.Property(e => e.Macosokbcbchuyenden)
                .HasMaxLength(10)
                .HasColumnName("MACOSOKBCBCHUYENDEN");
            entity.Property(e => e.Macosokbcbchuyendi)
                .HasMaxLength(10)
                .HasColumnName("MACOSOKBCBCHUYENDI");
            entity.Property(e => e.Madantoc)
                .HasMaxLength(2)
                .HasColumnName("MADANTOC");
            entity.Property(e => e.Mahuyen)
                .HasMaxLength(3)
                .HasColumnName("MAHUYEN");
            entity.Property(e => e.Mangsuondidong)
                .HasMaxLength(255)
                .HasColumnName("MANGSUONDIDONG");
            entity.Property(e => e.Manguyennhanchinhtuvong)
                .HasMaxLength(10)
                .HasColumnName("MANGUYENNHANCHINHTUVONG");
            entity.Property(e => e.Maquoctich)
                .HasMaxLength(3)
                .HasColumnName("MAQUOCTICH");
            entity.Property(e => e.Mat)
                .HasMaxLength(255)
                .HasColumnName("MAT");
            entity.Property(e => e.Mathanhpho)
                .HasMaxLength(2)
                .HasColumnName("MATHANHPHO");
            entity.Property(e => e.Matlientuc)
                .HasMaxLength(255)
                .HasColumnName("MATLIENTUC");
            entity.Property(e => e.Maxaphuong)
                .HasMaxLength(5)
                .HasColumnName("MAXAPHUONG");
            entity.Property(e => e.Moikho)
                .HasMaxLength(255)
                .HasColumnName("MOIKHO");
            entity.Property(e => e.Motabiendangxuong)
                .HasMaxLength(255)
                .HasColumnName("MOTABIENDANGXUONG");
            entity.Property(e => e.Motabiendokhop)
                .HasMaxLength(255)
                .HasColumnName("MOTABIENDOKHOP");
            entity.Property(e => e.Motacacxetnghiem)
                .HasMaxLength(255)
                .HasColumnName("MOTACACXETNGHIEM");
            entity.Property(e => e.Motacamgiacnongsau)
                .HasMaxLength(255)
                .HasColumnName("MOTACAMGIACNONGSAU");
            entity.Property(e => e.Motachieudai)
                .HasMaxLength(255)
                .HasColumnName("MOTACHIEUDAI");
            entity.Property(e => e.Motachuandoanbenhvienkhac)
                .HasMaxLength(255)
                .HasColumnName("MOTACHUANDOANBENHVIENKHAC");
            entity.Property(e => e.Motadauhieulietthankinhso)
                .HasMaxLength(255)
                .HasColumnName("MOTADAUHIEULIETTHANKINHSO");
            entity.Property(e => e.Motadauhieulietvandong)
                .HasMaxLength(255)
                .HasColumnName("MOTADAUHIEULIETVANDONG");
            entity.Property(e => e.Motadauhieumangnao)
                .HasMaxLength(255)
                .HasColumnName("MOTADAUHIEUMANGNAO");
            entity.Property(e => e.Motadauhieuthankinhkhutru)
                .HasMaxLength(255)
                .HasColumnName("MOTADAUHIEUTHANKINHKHUTRU");
            entity.Property(e => e.Motadauhieuthankinhngoaibien)
                .HasMaxLength(255)
                .HasColumnName("MOTADAUHIEUTHANKINHNGOAIBIEN");
            entity.Property(e => e.Motadauhieuthankinhthucvat)
                .HasMaxLength(255)
                .HasColumnName("MOTADAUHIEUTHANKINHTHUCVAT");
            entity.Property(e => e.Motadongkinh)
                .HasMaxLength(255)
                .HasColumnName("MOTADONGKINH");
            entity.Property(e => e.Motadotquy)
                .HasMaxLength(255)
                .HasColumnName("MOTADOTQUY");
            entity.Property(e => e.Motamuivetthuong)
                .HasMaxLength(255)
                .HasColumnName("MOTAMUIVETTHUONG");
            entity.Property(e => e.Motanoikhoa)
                .HasMaxLength(255)
                .HasColumnName("MOTANOIKHOA");
            entity.Property(e => e.Motaphauthuatthuthuat)
                .HasMaxLength(255)
                .HasColumnName("MOTAPHAUTHUATTHUTHUAT");
            entity.Property(e => e.Motaphuchoichucnang)
                .HasMaxLength(255)
                .HasColumnName("MOTAPHUCHOICHUCNANG");
            entity.Property(e => e.Motarale)
                .HasMaxLength(255)
                .HasColumnName("MOTARALE");
            entity.Property(e => e.Motariraophenang)
                .HasMaxLength(255)
                .HasColumnName("MOTARIRAOPHENANG");
            entity.Property(e => e.Motaroiloancamgiac)
                .HasMaxLength(255)
                .HasColumnName("MOTAROILOANCAMGIAC");
            entity.Property(e => e.Motaroiloangiacquan)
                .HasMaxLength(255)
                .HasColumnName("MOTAROILOANGIACQUAN");
            entity.Property(e => e.Motaroiloanthamthan)
                .HasMaxLength(255)
                .HasColumnName("MOTAROILOANTHAMTHAN");
            entity.Property(e => e.Motaroiloanthangbang)
                .HasMaxLength(255)
                .HasColumnName("MOTAROILOANTHANGBANG");
            entity.Property(e => e.Motaroiloantrinho)
                .HasMaxLength(255)
                .HasColumnName("MOTAROILOANTRINHO");
            entity.Property(e => e.Motasungnebamtimvtt)
                .HasMaxLength(255)
                .HasColumnName("MOTASUNGNEBAMTIMVTT");
            entity.Property(e => e.Motasupmi)
                .HasMaxLength(255)
                .HasColumnName("MOTASUPMI");
            entity.Property(e => e.Motataichaymau)
                .HasMaxLength(255)
                .HasColumnName("MOTATAICHAYMAU");
            entity.Property(e => e.Motataivetthuong)
                .HasMaxLength(255)
                .HasColumnName("MOTATAIVETTHUONG");
            entity.Property(e => e.Motatonthuong)
                .HasMaxLength(255)
                .HasColumnName("MOTATONTHUONG");
            entity.Property(e => e.Motatonthuongledao)
                .HasMaxLength(255)
                .HasColumnName("MOTATONTHUONGLEDAO");
            entity.Property(e => e.Motatsphauthuat1)
                .HasMaxLength(255)
                .HasColumnName("MOTATSPHAUTHUAT1");
            entity.Property(e => e.Motatsphauthuat2)
                .HasMaxLength(255)
                .HasColumnName("MOTATSPHAUTHUAT2");
            entity.Property(e => e.Motatsphauthuat3)
                .HasMaxLength(255)
                .HasColumnName("MOTATSPHAUTHUAT3");
            entity.Property(e => e.Motatuvansuckhoe)
                .HasMaxLength(255)
                .HasColumnName("MOTATUVANSUCKHOE");
            entity.Property(e => e.Motavtthanhnguc)
                .HasMaxLength(255)
                .HasColumnName("MOTAVTTHANHNGUC");
            entity.Property(e => e.Muivetthuong)
                .HasMaxLength(255)
                .HasColumnName("MUIVETTHUONG");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Ngaythu)
                .HasMaxLength(255)
                .HasColumnName("NGAYTHU");
            entity.Property(e => e.Nghenghiep)
                .HasMaxLength(255)
                .HasColumnName("NGHENGHIEP");
            entity.Property(e => e.Nguga)
                .HasMaxLength(255)
                .HasColumnName("NGUGA");
            entity.Property(e => e.Nguoimacbenhdaithaoduong)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMACBENHDAITHAODUONG");
            entity.Property(e => e.Nguoimacbenhdongkinh)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMACBENHDONGKINH");
            entity.Property(e => e.Nguoimacbenhgout)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMACBENHGOUT");
            entity.Property(e => e.Nguoimacbenhhensuyen)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMACBENHHENSUYEN");
            entity.Property(e => e.Nguoimacbenhhethong)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMACBENHHETHONG");
            entity.Property(e => e.Nguoimacbenhkhac)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMACBENHKHAC");
            entity.Property(e => e.Nguoimacbenhlao)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMACBENHLAO");
            entity.Property(e => e.Nguoimacbenhlqdenchuyenhoa)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMACBENHLQDENCHUYENHOA");
            entity.Property(e => e.Nguoimacbenhtamthan)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMACBENHTAMTHAN");
            entity.Property(e => e.Nguoimacbenhtanghuyetap)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMACBENHTANGHUYETAP");
            entity.Property(e => e.Nguoimacbenhtimmach)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMACBENHTIMMACH");
            entity.Property(e => e.Nguoimacbenhungthu)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMACBENHUNGTHU");
            entity.Property(e => e.Nguyennhanchinhtuvong)
                .HasMaxLength(255)
                .HasColumnName("NGUYENNHANCHINHTUVONG");
            entity.Property(e => e.Nhietdo)
                .HasMaxLength(255)
                .HasColumnName("NHIETDO");
            entity.Property(e => e.Nhiptho)
                .HasMaxLength(255)
                .HasColumnName("NHIPTHO");
            entity.Property(e => e.Niemmac)
                .HasMaxLength(255)
                .HasColumnName("NIEMMAC");
            entity.Property(e => e.Noichuyenden)
                .HasMaxLength(255)
                .HasColumnName("NOICHUYENDEN");
            entity.Property(e => e.Noichuyendi)
                .HasMaxLength(255)
                .HasColumnName("NOICHUYENDI");
            entity.Property(e => e.Noikhoa)
                .HasMaxLength(255)
                .HasColumnName("NOIKHOA");
            entity.Property(e => e.Phan)
                .HasMaxLength(255)
                .HasColumnName("PHAN");
            entity.Property(e => e.Phanungthanhbung)
                .HasMaxLength(255)
                .HasColumnName("PHANUNGTHANHBUNG");
            entity.Property(e => e.Phanxabatthuong)
                .HasMaxLength(255)
                .HasColumnName("PHANXABATTHUONG");
            entity.Property(e => e.Phauthuatthuthuat)
                .HasMaxLength(255)
                .HasColumnName("PHAUTHUATTHUTHUAT");
            entity.Property(e => e.Phu)
                .HasMaxLength(255)
                .HasColumnName("PHU");
            entity.Property(e => e.Phuchoichucnang)
                .HasMaxLength(255)
                .HasColumnName("PHUCHOICHUCNANG");
            entity.Property(e => e.Quairuotnoi)
                .HasMaxLength(255)
                .HasColumnName("QUAIRUOTNOI");
            entity.Property(e => e.Quoctich)
                .HasMaxLength(15)
                .HasColumnName("QUOCTICH");
            entity.Property(e => e.Rale)
                .HasMaxLength(255)
                .HasColumnName("RALE");
            entity.Property(e => e.Rang)
                .HasMaxLength(255)
                .HasColumnName("RANG");
            entity.Property(e => e.Ranghammat)
                .HasMaxLength(255)
                .HasColumnName("RANGHAMMAT");
            entity.Property(e => e.Riraophenang)
                .HasMaxLength(255)
                .HasColumnName("RIRAOPHENANG");
            entity.Property(e => e.Roiloancamgiac)
                .HasMaxLength(255)
                .HasColumnName("ROILOANCAMGIAC");
            entity.Property(e => e.Roiloancamgiacthankinhtuysong)
                .HasMaxLength(255)
                .HasColumnName("ROILOANCAMGIACTHANKINHTUYSONG");
            entity.Property(e => e.Roiloangiacquan)
                .HasMaxLength(255)
                .HasColumnName("ROILOANGIACQUAN");
            entity.Property(e => e.Roiloantamthan)
                .HasMaxLength(255)
                .HasColumnName("ROILOANTAMTHAN");
            entity.Property(e => e.Roiloanthangbang)
                .HasMaxLength(255)
                .HasColumnName("ROILOANTHANGBANG");
            entity.Property(e => e.Roiloantrinho)
                .HasMaxLength(255)
                .HasColumnName("ROILOANTRINHO");
            entity.Property(e => e.Rungmiu)
                .HasMaxLength(255)
                .HasColumnName("RUNGMIU");
            entity.Property(e => e.Seomocu)
                .HasMaxLength(255)
                .HasColumnName("SEOMOCU");
            entity.Property(e => e.Songaychuyenkhoa).HasColumnName("SONGAYCHUYENKHOA");
            entity.Property(e => e.Songayvaokhoa).HasColumnName("SONGAYVAOKHOA");
            entity.Property(e => e.Sonha)
                .HasMaxLength(5)
                .HasColumnName("SONHA");
            entity.Property(e => e.Sothayu)
                .HasMaxLength(255)
                .HasColumnName("SOTHAYU");
            entity.Property(e => e.Sothebhyt)
                .HasMaxLength(30)
                .HasColumnName("SOTHEBHYT");
            entity.Property(e => e.Spo2)
                .HasMaxLength(255)
                .HasColumnName("SPO2");
            entity.Property(e => e.Sungnebamtim)
                .HasMaxLength(255)
                .HasColumnName("SUNGNEBAMTIM");
            entity.Property(e => e.Sungnebamtimcs)
                .HasMaxLength(255)
                .HasColumnName("SUNGNEBAMTIMCS");
            entity.Property(e => e.Sungnebamtimvtt)
                .HasMaxLength(255)
                .HasColumnName("SUNGNEBAMTIMVTT");
            entity.Property(e => e.Supmi)
                .HasMaxLength(255)
                .HasColumnName("SUPMI");
            entity.Property(e => e.Taichaymau)
                .HasMaxLength(255)
                .HasColumnName("TAICHAYMAU");
            entity.Property(e => e.Taimuihong)
                .HasMaxLength(255)
                .HasColumnName("TAIMUIHONG");
            entity.Property(e => e.Taimuihongkhac)
                .HasMaxLength(255)
                .HasColumnName("TAIMUIHONGKHAC");
            entity.Property(e => e.Taivetthuong)
                .HasMaxLength(255)
                .HasColumnName("TAIVETTHUONG");
            entity.Property(e => e.Tamthan)
                .HasMaxLength(255)
                .HasColumnName("TAMTHAN");
            entity.Property(e => e.Tanghuyetap)
                .HasMaxLength(255)
                .HasColumnName("TANGHUYETAP");
            entity.Property(e => e.Tencoquanchuquan)
                .HasMaxLength(255)
                .HasColumnName("TENCOQUANCHUQUAN");
            entity.Property(e => e.Tencosokbcb)
                .HasMaxLength(255)
                .HasColumnName("TENCOSOKBCB");
            entity.Property(e => e.Than)
                .HasMaxLength(255)
                .HasColumnName("THAN");
            entity.Property(e => e.Thanhpho)
                .HasMaxLength(30)
                .HasColumnName("THANHPHO");
            entity.Property(e => e.Thankinh)
                .HasMaxLength(255)
                .HasColumnName("THANKINH");
            entity.Property(e => e.Thankinhkhac)
                .HasMaxLength(255)
                .HasColumnName("THANKINHKHAC");
            entity.Property(e => e.Thanto)
                .HasMaxLength(255)
                .HasColumnName("THANTO");
            entity.Property(e => e.Thoaivi)
                .HasMaxLength(255)
                .HasColumnName("THOAIVI");
            entity.Property(e => e.Thogangsuc)
                .HasMaxLength(255)
                .HasColumnName("THOGANGSUC");
            entity.Property(e => e.Thoidiemtuvong)
                .HasMaxLength(255)
                .HasColumnName("THOIDIEMTUVONG");
            entity.Property(e => e.Thoiganbacsilambenhanky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGANBACSILAMBENHANKY");
            entity.Property(e => e.Thoigianbacsidieutriky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANBACSIDIEUTRIKY");
            entity.Property(e => e.Thoigianchuyenkhoa)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANCHUYENKHOA");
            entity.Property(e => e.Thoigiandaidienky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANDAIDIENKY");
            entity.Property(e => e.Thoigianravien)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANRAVIEN");
            entity.Property(e => e.Thoigiansudungchatgaynghien)
                .HasMaxLength(255)
                .HasColumnName("THOIGIANSUDUNGCHATGAYNGHIEN");
            entity.Property(e => e.Thoigiansudungthuocla)
                .HasMaxLength(255)
                .HasColumnName("THOIGIANSUDUNGTHUOCLA");
            entity.Property(e => e.Thoigiansudungthuoclao)
                .HasMaxLength(255)
                .HasColumnName("THOIGIANSUDUNGTHUOCLAO");
            entity.Property(e => e.Thoigiantiepxuchoachat)
                .HasMaxLength(255)
                .HasColumnName("THOIGIANTIEPXUCHOACHAT");
            entity.Property(e => e.Thoigiantuvong)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANTUVONG");
            entity.Property(e => e.Thoigianvaokhoa)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANVAOKHOA");
            entity.Property(e => e.Thoigianvaovien)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANVAOVIEN");
            entity.Property(e => e.Thonpho)
                .HasMaxLength(30)
                .HasColumnName("THONPHO");
            entity.Property(e => e.Thuocdangdung)
                .HasMaxLength(255)
                .HasColumnName("THUOCDANGDUNG");
            entity.Property(e => e.Tiengtim)
                .HasMaxLength(255)
                .HasColumnName("TIENGTIM");
            entity.Property(e => e.Tiengtimbatthuong)
                .HasMaxLength(255)
                .HasColumnName("TIENGTIMBATTHUONG");
            entity.Property(e => e.Tiengtimdeu)
                .HasMaxLength(255)
                .HasColumnName("TIENGTIMDEU");
            entity.Property(e => e.Tienluonggan)
                .HasMaxLength(255)
                .HasColumnName("TIENLUONGGAN");
            entity.Property(e => e.Tienluongxa)
                .HasMaxLength(255)
                .HasColumnName("TIENLUONGXA");
            entity.Property(e => e.Tiensubenh)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENH");
            entity.Property(e => e.Tiensubenhhohap)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHHOHAP");
            entity.Property(e => e.Tiensubenhkhac)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHKHAC");
            entity.Property(e => e.Tiensubenhnoitiet)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHNOITIET");
            entity.Property(e => e.Tiensubenhthan)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHTHAN");
            entity.Property(e => e.Tiensubenhthankinh)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHTHANKINH");
            entity.Property(e => e.Tiensubenhtieuhoa)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHTIEUHOA");
            entity.Property(e => e.Tiensubenhtimmach)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHTIMMACH");
            entity.Property(e => e.Tiensubenhungthu)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHUNGTHU");
            entity.Property(e => e.Tiensubenhxuongkhop)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHXUONGKHOP");
            entity.Property(e => e.Tiensugiadinh)
                .HasMaxLength(255)
                .HasColumnName("TIENSUGIADINH");
            entity.Property(e => e.Tiensuphauthuat)
                .HasMaxLength(255)
                .HasColumnName("TIENSUPHAUTHUAT");
            entity.Property(e => e.Tiepnhantu)
                .HasMaxLength(255)
                .HasColumnName("TIEPNHANTU");
            entity.Property(e => e.Tiepxuccham)
                .HasMaxLength(255)
                .HasColumnName("TIEPXUCCHAM");
            entity.Property(e => e.Tiepxuctot)
                .HasMaxLength(255)
                .HasColumnName("TIEPXUCTOT");
            entity.Property(e => e.Tieuhoa)
                .HasMaxLength(255)
                .HasColumnName("TIEUHOA");
            entity.Property(e => e.Tieuhoakhac)
                .HasMaxLength(255)
                .HasColumnName("TIEUHOAKHAC");
            entity.Property(e => e.Tinhchatphan)
                .HasMaxLength(255)
                .HasColumnName("TINHCHATPHAN");
            entity.Property(e => e.Tinhchattinhhoan)
                .HasMaxLength(255)
                .HasColumnName("TINHCHATTINHHOAN");
            entity.Property(e => e.Tinhhoan)
                .HasMaxLength(255)
                .HasColumnName("TINHHOAN");
            entity.Property(e => e.Tinhtrangravien)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGRAVIEN");
            entity.Property(e => e.Tinhtrangravientk)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGRAVIENTK");
            entity.Property(e => e.Tinhtrangvao)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGVAO");
            entity.Property(e => e.Toanthan)
                .HasMaxLength(255)
                .HasColumnName("TOANTHAN");
            entity.Property(e => e.Toanthankhac)
                .HasMaxLength(255)
                .HasColumnName("TOANTHANKHAC");
            entity.Property(e => e.Tomtatbenhan)
                .HasMaxLength(255)
                .HasColumnName("TOMTATBENHAN");
            entity.Property(e => e.Tomtatketquaxetnghiem)
                .HasMaxLength(255)
                .HasColumnName("TOMTATKETQUAXETNGHIEM");
            entity.Property(e => e.Tomtatquatrinhbenhly)
                .HasMaxLength(255)
                .HasColumnName("TOMTATQUATRINHBENHLY");
            entity.Property(e => e.Tongsongaydieutri).HasColumnName("TONGSONGAYDIEUTRI");
            entity.Property(e => e.Tonthuong)
                .HasMaxLength(255)
                .HasColumnName("TONTHUONG");
            entity.Property(e => e.Tonthuongledao)
                .HasMaxLength(255)
                .HasColumnName("TONTHUONGLEDAO");
            entity.Property(e => e.Trankhiduoida)
                .HasMaxLength(255)
                .HasColumnName("TRANKHIDUOIDA");
            entity.Property(e => e.Tuanhoanbanghe)
                .HasMaxLength(255)
                .HasColumnName("TUANHOANBANGHE");
            entity.Property(e => e.Tuanhoanvahohap)
                .HasMaxLength(255)
                .HasColumnName("TUANHOANVAHOHAP");
            entity.Property(e => e.Tuanhoanvahohapkhac)
                .HasMaxLength(255)
                .HasColumnName("TUANHOANVAHOHAPKHAC");
            entity.Property(e => e.Tuicungdouglas)
                .HasMaxLength(255)
                .HasColumnName("TUICUNGDOUGLAS");
            entity.Property(e => e.Tuimatto)
                .HasMaxLength(255)
                .HasColumnName("TUIMATTO");
            entity.Property(e => e.Tuoi).HasColumnName("TUOI");
            entity.Property(e => e.Tuvansuckhoe)
                .HasMaxLength(255)
                .HasColumnName("TUVANSUCKHOE");
            entity.Property(e => e.Tuyengiap)
                .HasMaxLength(255)
                .HasColumnName("TUYENGIAP");
            entity.Property(e => e.Tuyentienliet)
                .HasMaxLength(255)
                .HasColumnName("TUYENTIENLIET");
            entity.Property(e => e.Ungthu)
                .HasMaxLength(255)
                .HasColumnName("UNGTHU");
            entity.Property(e => e.Vandongbinhthuong)
                .HasMaxLength(255)
                .HasColumnName("VANDONGBINHTHUONG");
            entity.Property(e => e.Vaokhoa)
                .HasMaxLength(255)
                .HasColumnName("VAOKHOA");
            entity.Property(e => e.Vetbamtim)
                .HasMaxLength(255)
                .HasColumnName("VETBAMTIM");
            entity.Property(e => e.Vetthuong)
                .HasMaxLength(255)
                .HasColumnName("VETTHUONG");
            entity.Property(e => e.Vetthuongthanhbung)
                .HasMaxLength(255)
                .HasColumnName("VETTHUONGTHANHBUNG");
            entity.Property(e => e.Vetthuongthanhnguc)
                .HasMaxLength(255)
                .HasColumnName("VETTHUONGTHANHNGUC");
            entity.Property(e => e.Vetthuongvungdau)
                .HasMaxLength(255)
                .HasColumnName("VETTHUONGVUNGDAU");
            entity.Property(e => e.Vitriphu)
                .HasMaxLength(255)
                .HasColumnName("VITRIPHU");
            entity.Property(e => e.Vtcamungphucmac)
                .HasMaxLength(255)
                .HasColumnName("VTCAMUNGPHUCMAC");
            entity.Property(e => e.Vtktbiendanghammat)
                .HasMaxLength(255)
                .HasColumnName("VTKTBIENDANGHAMMAT");
            entity.Property(e => e.Vtktivetthuongthanhbung)
                .HasMaxLength(255)
                .HasColumnName("VTKTIVETTHUONGTHANHBUNG");
            entity.Property(e => e.Vtktkhoiu)
                .HasMaxLength(255)
                .HasColumnName("VTKTKHOIU");
            entity.Property(e => e.Vtktseomocu)
                .HasMaxLength(255)
                .HasColumnName("VTKTSEOMOCU");
            entity.Property(e => e.Vtktsungnebamtim)
                .HasMaxLength(255)
                .HasColumnName("VTKTSUNGNEBAMTIM");
            entity.Property(e => e.Vtktvetthuongvungdau)
                .HasMaxLength(255)
                .HasColumnName("VTKTVETTHUONGVUNGDAU");
            entity.Property(e => e.Vtsothayu)
                .HasMaxLength(255)
                .HasColumnName("VTSOTHAYU");
            entity.Property(e => e.Vtthoaivi)
                .HasMaxLength(255)
                .HasColumnName("VTTHOAIVI");
            entity.Property(e => e.Xaphuong)
                .HasMaxLength(30)
                .HasColumnName("XAPHUONG");
            entity.Property(e => e.Xuathuyetduoida)
                .HasMaxLength(255)
                .HasColumnName("XUATHUYETDUOIDA");
            entity.Property(e => e.Yeutonguyco)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCO");
            entity.Property(e => e.Yeutonguycochatgaynghien)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCOCHATGAYNGHIEN");
            entity.Property(e => e.Yeutonguycokhac)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCOKHAC");
            entity.Property(e => e.Yeutonguycoruoubia)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCORUOUBIA");
            entity.Property(e => e.Yeutonguycothuocla)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCOTHUOCLA");
            entity.Property(e => e.Yeutonguycothuoclao)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCOTHUOCLAO");
            entity.Property(e => e.Yeutonguycotiepxuchoachat)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCOTIEPXUCHOACHAT");
        });

        modelBuilder.Entity<Benhanngoaitrumat>(entity =>
        {
            entity.HasKey(e => e.Mabenhan).HasName("PK__BENHANNG__12DD6716DD51237A");

            entity.ToTable("BENHANNGOAITRUMAT");

            entity.Property(e => e.Mabenhan)
                .HasMaxLength(10)
                .HasColumnName("MABENHAN");
            entity.Property(e => e.Bacsidieutri)
                .HasMaxLength(255)
                .HasColumnName("BACSIDIEUTRI");
            entity.Property(e => e.Bacsidieutritk)
                .HasMaxLength(255)
                .HasColumnName("BACSIDIEUTRITK");
            entity.Property(e => e.Banthan)
                .HasMaxLength(255)
                .HasColumnName("BANTHAN");
            entity.Property(e => e.Benhchinh)
                .HasMaxLength(255)
                .HasColumnName("BENHCHINH");
            entity.Property(e => e.Benhkemtheo)
                .HasMaxLength(255)
                .HasColumnName("BENHKEMTHEO");
            entity.Property(e => e.Bienchung)
                .HasMaxLength(255)
                .HasColumnName("BIENCHUNG");
            entity.Property(e => e.Bophan)
                .HasMaxLength(255)
                .HasColumnName("BOPHAN");
            entity.Property(e => e.Cacxetnghiem)
                .HasMaxLength(255)
                .HasColumnName("CACXETNGHIEM");
            entity.Property(e => e.Cancuoc)
                .HasMaxLength(30)
                .HasColumnName("CANCUOC");
            entity.Property(e => e.Cannang)
                .HasMaxLength(255)
                .HasColumnName("CANNANG");
            entity.Property(e => e.Chieucao)
                .HasMaxLength(255)
                .HasColumnName("CHIEUCAO");
            entity.Property(e => e.Chuandoankhiravienmp)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANKHIRAVIENMP");
            entity.Property(e => e.Chuandoankhiravienmt)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANKHIRAVIENMT");
            entity.Property(e => e.Cungmacphai)
                .HasMaxLength(255)
                .HasColumnName("CUNGMACPHAI");
            entity.Property(e => e.Cungmactrai)
                .HasMaxLength(255)
                .HasColumnName("CUNGMACTRAI");
            entity.Property(e => e.Daidiencskbcb)
                .HasMaxLength(255)
                .HasColumnName("DAIDIENCSKBCB");
            entity.Property(e => e.Dantoc)
                .HasMaxLength(20)
                .HasColumnName("DANTOC");
            entity.Property(e => e.Daymatphai)
                .HasMaxLength(255)
                .HasColumnName("DAYMATPHAI");
            entity.Property(e => e.Daymattrai)
                .HasMaxLength(255)
                .HasColumnName("DAYMATTRAI");
            entity.Property(e => e.Dichkinhphai)
                .HasMaxLength(255)
                .HasColumnName("DICHKINHPHAI");
            entity.Property(e => e.Dichkinhtrai)
                .HasMaxLength(255)
                .HasColumnName("DICHKINHTRAI");
            entity.Property(e => e.Dienbienlamsang)
                .HasMaxLength(255)
                .HasColumnName("DIENBIENLAMSANG");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(15)
                .HasColumnName("DIENTHOAI");
            entity.Property(e => e.Dienthoaithannhan)
                .HasMaxLength(15)
                .HasColumnName("DIENTHOAITHANNHAN");
            entity.Property(e => e.Diung)
                .HasMaxLength(255)
                .HasColumnName("DIUNG");
            entity.Property(e => e.Doituong)
                .HasMaxLength(20)
                .HasColumnName("DOITUONG");
            entity.Property(e => e.Dongtuphai)
                .HasMaxLength(255)
                .HasColumnName("DONGTUPHAI");
            entity.Property(e => e.Dongtutrai)
                .HasMaxLength(255)
                .HasColumnName("DONGTUTRAI");
            entity.Property(e => e.Giacmacphai)
                .HasMaxLength(255)
                .HasColumnName("GIACMACPHAI");
            entity.Property(e => e.Giacmactrai)
                .HasMaxLength(255)
                .HasColumnName("GIACMACTRAI");
            entity.Property(e => e.Giadinh)
                .HasMaxLength(255)
                .HasColumnName("GIADINH");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(3)
                .HasColumnName("GIOITINH");
            entity.Property(e => e.Hocmatphai)
                .HasMaxLength(255)
                .HasColumnName("HOCMATPHAI");
            entity.Property(e => e.Hocmattrai)
                .HasMaxLength(255)
                .HasColumnName("HOCMATTRAI");
            entity.Property(e => e.Hotenthannhan)
                .HasMaxLength(255)
                .HasColumnName("HOTENTHANNHAN");
            entity.Property(e => e.Hovaten)
                .HasMaxLength(255)
                .HasColumnName("HOVATEN");
            entity.Property(e => e.Huongdieutri)
                .HasMaxLength(255)
                .HasColumnName("HUONGDIEUTRI");
            entity.Property(e => e.Huongdieutritieptheo)
                .HasMaxLength(255)
                .HasColumnName("HUONGDIEUTRITIEPTHEO");
            entity.Property(e => e.Huyen)
                .HasMaxLength(30)
                .HasColumnName("HUYEN");
            entity.Property(e => e.Huyetap)
                .HasMaxLength(255)
                .HasColumnName("HUYETAP");
            entity.Property(e => e.Ketmacphai)
                .HasMaxLength(255)
                .HasColumnName("KETMACPHAI");
            entity.Property(e => e.Ketmactrai)
                .HasMaxLength(255)
                .HasColumnName("KETMACTRAI");
            entity.Property(e => e.Ledaophai)
                .HasMaxLength(255)
                .HasColumnName("LEDAOPHAI");
            entity.Property(e => e.Ledaotrai)
                .HasMaxLength(255)
                .HasColumnName("LEDAOTRAI");
            entity.Property(e => e.Lydovaovien)
                .HasMaxLength(255)
                .HasColumnName("LYDOVAOVIEN");
            entity.Property(e => e.Mabenhchinh)
                .HasMaxLength(255)
                .HasColumnName("MABENHCHINH");
            entity.Property(e => e.Mabenhkemtheo)
                .HasMaxLength(255)
                .HasColumnName("MABENHKEMTHEO");
            entity.Property(e => e.Mabienchung)
                .HasMaxLength(255)
                .HasColumnName("MABIENCHUNG");
            entity.Property(e => e.Mach)
                .HasMaxLength(255)
                .HasColumnName("MACH");
            entity.Property(e => e.Macoquanchuquan)
                .HasMaxLength(10)
                .HasColumnName("MACOQUANCHUQUAN");
            entity.Property(e => e.Macosokbcb)
                .HasMaxLength(10)
                .HasColumnName("MACOSOKBCB");
            entity.Property(e => e.Madantoc)
                .HasMaxLength(2)
                .HasColumnName("MADANTOC");
            entity.Property(e => e.Mahuyen)
                .HasMaxLength(3)
                .HasColumnName("MAHUYEN");
            entity.Property(e => e.Maquoctich)
                .HasMaxLength(3)
                .HasColumnName("MAQUOCTICH");
            entity.Property(e => e.Mathanhpho)
                .HasMaxLength(2)
                .HasColumnName("MATHANHPHO");
            entity.Property(e => e.Matphai)
                .HasMaxLength(255)
                .HasColumnName("MATPHAI");
            entity.Property(e => e.Mattrai)
                .HasMaxLength(255)
                .HasColumnName("MATTRAI");
            entity.Property(e => e.Maxaphuong)
                .HasMaxLength(5)
                .HasColumnName("MAXAPHUONG");
            entity.Property(e => e.Mimatphai)
                .HasMaxLength(255)
                .HasColumnName("MIMATPHAI");
            entity.Property(e => e.Mimattrai)
                .HasMaxLength(255)
                .HasColumnName("MIMATTRAI");
            entity.Property(e => e.Mongmatphai)
                .HasMaxLength(255)
                .HasColumnName("MONGMATPHAI");
            entity.Property(e => e.Mongmattrai)
                .HasMaxLength(255)
                .HasColumnName("MONGMATTRAI");
            entity.Property(e => e.Motabanthan)
                .HasMaxLength(255)
                .HasColumnName("MOTABANTHAN");
            entity.Property(e => e.Motacacxetnghiem)
                .HasMaxLength(255)
                .HasColumnName("MOTACACXETNGHIEM");
            entity.Property(e => e.Motacungmacphai)
                .HasMaxLength(255)
                .HasColumnName("MOTACUNGMACPHAI");
            entity.Property(e => e.Motacungmactrai)
                .HasMaxLength(255)
                .HasColumnName("MOTACUNGMACTRAI");
            entity.Property(e => e.Motadaymatphai)
                .HasMaxLength(255)
                .HasColumnName("MOTADAYMATPHAI");
            entity.Property(e => e.Motadaymattrai)
                .HasMaxLength(255)
                .HasColumnName("MOTADAYMATTRAI");
            entity.Property(e => e.Motadichkinhphai)
                .HasMaxLength(255)
                .HasColumnName("MOTADICHKINHPHAI");
            entity.Property(e => e.Motadichkinhtrai)
                .HasMaxLength(255)
                .HasColumnName("MOTADICHKINHTRAI");
            entity.Property(e => e.Motadiung)
                .HasMaxLength(255)
                .HasColumnName("MOTADIUNG");
            entity.Property(e => e.Motadongtuphai)
                .HasMaxLength(255)
                .HasColumnName("MOTADONGTUPHAI");
            entity.Property(e => e.Motadongtutrai)
                .HasMaxLength(255)
                .HasColumnName("MOTADONGTUTRAI");
            entity.Property(e => e.Motagiacmacphai)
                .HasMaxLength(255)
                .HasColumnName("MOTAGIACMACPHAI");
            entity.Property(e => e.Motagiacmactrai)
                .HasMaxLength(255)
                .HasColumnName("MOTAGIACMACTRAI");
            entity.Property(e => e.Motagiadinh)
                .HasMaxLength(255)
                .HasColumnName("MOTAGIADINH");
            entity.Property(e => e.Motahocmatphai)
                .HasMaxLength(255)
                .HasColumnName("MOTAHOCMATPHAI");
            entity.Property(e => e.Motahocmattrai)
                .HasMaxLength(255)
                .HasColumnName("MOTAHOCMATTRAI");
            entity.Property(e => e.Motaketmacphai)
                .HasMaxLength(255)
                .HasColumnName("MOTAKETMACPHAI");
            entity.Property(e => e.Motaketmactrai)
                .HasMaxLength(255)
                .HasColumnName("MOTAKETMACTRAI");
            entity.Property(e => e.Motaledaophai)
                .HasMaxLength(255)
                .HasColumnName("MOTALEDAOPHAI");
            entity.Property(e => e.Motaledaotrai)
                .HasMaxLength(255)
                .HasColumnName("MOTALEDAOTRAI");
            entity.Property(e => e.Motamimatphai)
                .HasMaxLength(255)
                .HasColumnName("MOTAMIMATPHAI");
            entity.Property(e => e.Motamimattrai)
                .HasMaxLength(255)
                .HasColumnName("MOTAMIMATTRAI");
            entity.Property(e => e.Motamongmatphai)
                .HasMaxLength(255)
                .HasColumnName("MOTAMONGMATPHAI");
            entity.Property(e => e.Motamongmattrai)
                .HasMaxLength(255)
                .HasColumnName("MOTAMONGMATTRAI");
            entity.Property(e => e.Motanoikhoa)
                .HasMaxLength(255)
                .HasColumnName("MOTANOIKHOA");
            entity.Property(e => e.Motaphauthuatthuthuat)
                .HasMaxLength(255)
                .HasColumnName("MOTAPHAUTHUATTHUTHUAT");
            entity.Property(e => e.Motathethuytinhphai)
                .HasMaxLength(255)
                .HasColumnName("MOTATHETHUYTINHPHAI");
            entity.Property(e => e.Motathethuytinhtrai)
                .HasMaxLength(255)
                .HasColumnName("MOTATHETHUYTINHTRAI");
            entity.Property(e => e.Motatienphongphai)
                .HasMaxLength(255)
                .HasColumnName("MOTATIENPHONGPHAI");
            entity.Property(e => e.Motatienphongtrai)
                .HasMaxLength(255)
                .HasColumnName("MOTATIENPHONGTRAI");
            entity.Property(e => e.Motatinhtrangnhancauphai)
                .HasMaxLength(255)
                .HasColumnName("MOTATINHTRANGNHANCAUPHAI");
            entity.Property(e => e.Motatinhtrangnhancautrai)
                .HasMaxLength(255)
                .HasColumnName("MOTATINHTRANGNHANCAUTRAI");
            entity.Property(e => e.Motatoanthan)
                .HasMaxLength(255)
                .HasColumnName("MOTATOANTHAN");
            entity.Property(e => e.Motatuvangiaoduc)
                .HasMaxLength(255)
                .HasColumnName("MOTATUVANGIAODUC");
            entity.Property(e => e.Motavannhanphai)
                .HasMaxLength(255)
                .HasColumnName("MOTAVANNHANPHAI");
            entity.Property(e => e.Motavannhantrai)
                .HasMaxLength(255)
                .HasColumnName("MOTAVANNHANTRAI");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Nghenghiep)
                .HasMaxLength(255)
                .HasColumnName("NGHENGHIEP");
            entity.Property(e => e.Nhanapravienmp)
                .HasMaxLength(255)
                .HasColumnName("NHANAPRAVIENMP");
            entity.Property(e => e.Nhanapravienmt)
                .HasMaxLength(255)
                .HasColumnName("NHANAPRAVIENMT");
            entity.Property(e => e.Nhietdo)
                .HasMaxLength(255)
                .HasColumnName("NHIETDO");
            entity.Property(e => e.Nhiptho)
                .HasMaxLength(255)
                .HasColumnName("NHIPTHO");
            entity.Property(e => e.Noikhoa)
                .HasMaxLength(255)
                .HasColumnName("NOIKHOA");
            entity.Property(e => e.Phauthuatthuthuat)
                .HasMaxLength(255)
                .HasColumnName("PHAUTHUATTHUTHUAT");
            entity.Property(e => e.Quoctich)
                .HasMaxLength(15)
                .HasColumnName("QUOCTICH");
            entity.Property(e => e.Sonha)
                .HasMaxLength(5)
                .HasColumnName("SONHA");
            entity.Property(e => e.Sothebhyt)
                .HasMaxLength(30)
                .HasColumnName("SOTHEBHYT");
            entity.Property(e => e.Tencoquanchuquan)
                .HasMaxLength(255)
                .HasColumnName("TENCOQUANCHUQUAN");
            entity.Property(e => e.Tencosokbcb)
                .HasMaxLength(255)
                .HasColumnName("TENCOSOKBCB");
            entity.Property(e => e.Thanhpho)
                .HasMaxLength(30)
                .HasColumnName("THANHPHO");
            entity.Property(e => e.Thethuytinhphai)
                .HasMaxLength(255)
                .HasColumnName("THETHUYTINHPHAI");
            entity.Property(e => e.Thethuytinhtrai)
                .HasMaxLength(255)
                .HasColumnName("THETHUYTINHTRAI");
            entity.Property(e => e.Thilucchinhkinhmp)
                .HasMaxLength(255)
                .HasColumnName("THILUCCHINHKINHMP");
            entity.Property(e => e.Thilucchinhkinhmt)
                .HasMaxLength(255)
                .HasColumnName("THILUCCHINHKINHMT");
            entity.Property(e => e.Thilucravienmp)
                .HasMaxLength(255)
                .HasColumnName("THILUCRAVIENMP");
            entity.Property(e => e.Thilucravienmt)
                .HasMaxLength(255)
                .HasColumnName("THILUCRAVIENMT");
            entity.Property(e => e.Thoigianbacsidieutriky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANBACSIDIEUTRIKY");
            entity.Property(e => e.Thoigianbacsidieutrikytk)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANBACSIDIEUTRIKYTK");
            entity.Property(e => e.Thoigiandaidiencskbcbky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANDAIDIENCSKBCBKY");
            entity.Property(e => e.Thonpho)
                .HasMaxLength(30)
                .HasColumnName("THONPHO");
            entity.Property(e => e.Tienluonggan)
                .HasMaxLength(255)
                .HasColumnName("TIENLUONGGAN");
            entity.Property(e => e.Tienluongxa)
                .HasMaxLength(255)
                .HasColumnName("TIENLUONGXA");
            entity.Property(e => e.Tienphongphai)
                .HasMaxLength(255)
                .HasColumnName("TIENPHONGPHAI");
            entity.Property(e => e.Tienphongtrai)
                .HasMaxLength(255)
                .HasColumnName("TIENPHONGTRAI");
            entity.Property(e => e.Tinhtrangnhancauphai)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGNHANCAUPHAI");
            entity.Property(e => e.Tinhtrangnhancautrai)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGNHANCAUTRAI");
            entity.Property(e => e.Toanthan)
                .HasMaxLength(255)
                .HasColumnName("TOANTHAN");
            entity.Property(e => e.Toantrang)
                .HasMaxLength(255)
                .HasColumnName("TOANTRANG");
            entity.Property(e => e.Tomtatbenhan)
                .HasMaxLength(255)
                .HasColumnName("TOMTATBENHAN");
            entity.Property(e => e.Tuoi).HasColumnName("TUOI");
            entity.Property(e => e.Tuvangiaoduc)
                .HasMaxLength(255)
                .HasColumnName("TUVANGIAODUC");
            entity.Property(e => e.Vannhanphai)
                .HasMaxLength(255)
                .HasColumnName("VANNHANPHAI");
            entity.Property(e => e.Vannhantrai)
                .HasMaxLength(255)
                .HasColumnName("VANNHANTRAI");
            entity.Property(e => e.Xaphuong)
                .HasMaxLength(30)
                .HasColumnName("XAPHUONG");
        });

        modelBuilder.Entity<Benhanngoaitrurhm>(entity =>
        {
            entity.HasKey(e => e.Mabenhan).HasName("PK__BENHANNG__12DD6716BE639243");

            entity.ToTable("BENHANNGOAITRURHM");

            entity.Property(e => e.Mabenhan)
                .HasMaxLength(10)
                .HasColumnName("MABENHAN");
            entity.Property(e => e.Bacsidieutri)
                .HasMaxLength(255)
                .HasColumnName("BACSIDIEUTRI");
            entity.Property(e => e.Bacsidieutritk)
                .HasMaxLength(255)
                .HasColumnName("BACSIDIEUTRITK");
            entity.Property(e => e.Banthan)
                .HasMaxLength(255)
                .HasColumnName("BANTHAN");
            entity.Property(e => e.Benhchinh)
                .HasMaxLength(255)
                .HasColumnName("BENHCHINH");
            entity.Property(e => e.Benhkemtheo)
                .HasMaxLength(255)
                .HasColumnName("BENHKEMTHEO");
            entity.Property(e => e.Bienchung)
                .HasMaxLength(255)
                .HasColumnName("BIENCHUNG");
            entity.Property(e => e.Cancuoc)
                .HasMaxLength(30)
                .HasColumnName("CANCUOC");
            entity.Property(e => e.Cannang)
                .HasMaxLength(255)
                .HasColumnName("CANNANG");
            entity.Property(e => e.Chieucao)
                .HasMaxLength(255)
                .HasColumnName("CHIEUCAO");
            entity.Property(e => e.Daidiencskbcb)
                .HasMaxLength(255)
                .HasColumnName("DAIDIENCSKBCB");
            entity.Property(e => e.Dantoc)
                .HasMaxLength(20)
                .HasColumnName("DANTOC");
            entity.Property(e => e.Dauhieulamsang)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEULAMSANG");
            entity.Property(e => e.Dienbiemls)
                .HasMaxLength(255)
                .HasColumnName("DIENBIEMLS");
            entity.Property(e => e.Dienbienbenh)
                .HasMaxLength(255)
                .HasColumnName("DIENBIENBENH");
            entity.Property(e => e.Dienbienlamsang)
                .HasMaxLength(255)
                .HasColumnName("DIENBIENLAMSANG");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(15)
                .HasColumnName("DIENTHOAI");
            entity.Property(e => e.Dienthoaithannhan)
                .HasMaxLength(15)
                .HasColumnName("DIENTHOAITHANNHAN");
            entity.Property(e => e.Diung)
                .HasMaxLength(255)
                .HasColumnName("DIUNG");
            entity.Property(e => e.Doituong)
                .HasMaxLength(20)
                .HasColumnName("DOITUONG");
            entity.Property(e => e.Ghichu)
                .HasMaxLength(255)
                .HasColumnName("GHICHU");
            entity.Property(e => e.Giadinh)
                .HasMaxLength(255)
                .HasColumnName("GIADINH");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(3)
                .HasColumnName("GIOITINH");
            entity.Property(e => e.Hotenthannhan)
                .HasMaxLength(255)
                .HasColumnName("HOTENTHANNHAN");
            entity.Property(e => e.Hovaten)
                .HasMaxLength(255)
                .HasColumnName("HOVATEN");
            entity.Property(e => e.Huongdieutri)
                .HasMaxLength(255)
                .HasColumnName("HUONGDIEUTRI");
            entity.Property(e => e.Huyen)
                .HasMaxLength(30)
                .HasColumnName("HUYEN");
            entity.Property(e => e.Huyetap)
                .HasMaxLength(255)
                .HasColumnName("HUYETAP");
            entity.Property(e => e.Kehoachdieutri)
                .HasMaxLength(255)
                .HasColumnName("KEHOACHDIEUTRI");
            entity.Property(e => e.Lydovaovien)
                .HasMaxLength(255)
                .HasColumnName("LYDOVAOVIEN");
            entity.Property(e => e.Mabenhchinh)
                .HasMaxLength(255)
                .HasColumnName("MABENHCHINH");
            entity.Property(e => e.Mabenhkemtheo)
                .HasMaxLength(255)
                .HasColumnName("MABENHKEMTHEO");
            entity.Property(e => e.Mabienchung)
                .HasMaxLength(255)
                .HasColumnName("MABIENCHUNG");
            entity.Property(e => e.Mach)
                .HasMaxLength(255)
                .HasColumnName("MACH");
            entity.Property(e => e.Macoquanchuquan)
                .HasMaxLength(10)
                .HasColumnName("MACOQUANCHUQUAN");
            entity.Property(e => e.Macosokbcb)
                .HasMaxLength(10)
                .HasColumnName("MACOSOKBCB");
            entity.Property(e => e.Madantoc)
                .HasMaxLength(2)
                .HasColumnName("MADANTOC");
            entity.Property(e => e.Mahuyen)
                .HasMaxLength(3)
                .HasColumnName("MAHUYEN");
            entity.Property(e => e.Maquoctich)
                .HasMaxLength(3)
                .HasColumnName("MAQUOCTICH");
            entity.Property(e => e.Mathanhpho)
                .HasMaxLength(2)
                .HasColumnName("MATHANHPHO");
            entity.Property(e => e.Maxaphuong)
                .HasMaxLength(5)
                .HasColumnName("MAXAPHUONG");
            entity.Property(e => e.Motabanthan)
                .HasMaxLength(255)
                .HasColumnName("MOTABANTHAN");
            entity.Property(e => e.Motadiung)
                .HasMaxLength(255)
                .HasColumnName("MOTADIUNG");
            entity.Property(e => e.Motagiadinh)
                .HasMaxLength(255)
                .HasColumnName("MOTAGIADINH");
            entity.Property(e => e.Motangoaimieng)
                .HasMaxLength(255)
                .HasColumnName("MOTANGOAIMIENG");
            entity.Property(e => e.Motanoikhoa)
                .HasMaxLength(255)
                .HasColumnName("MOTANOIKHOA");
            entity.Property(e => e.Motaphauthuatthuthuat)
                .HasMaxLength(255)
                .HasColumnName("MOTAPHAUTHUATTHUTHUAT");
            entity.Property(e => e.Motatoanthan)
                .HasMaxLength(255)
                .HasColumnName("MOTATOANTHAN");
            entity.Property(e => e.Motatrongmieng)
                .HasMaxLength(255)
                .HasColumnName("MOTATRONGMIENG");
            entity.Property(e => e.Motaxetnghiemlamsang)
                .HasMaxLength(255)
                .HasColumnName("MOTAXETNGHIEMLAMSANG");
            entity.Property(e => e.Ngaydieutri)
                .HasColumnType("datetime")
                .HasColumnName("NGAYDIEUTRI");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Nghenghiep)
                .HasMaxLength(255)
                .HasColumnName("NGHENGHIEP");
            entity.Property(e => e.Ngoaimieng)
                .HasMaxLength(255)
                .HasColumnName("NGOAIMIENG");
            entity.Property(e => e.Nhietdo)
                .HasMaxLength(255)
                .HasColumnName("NHIETDO");
            entity.Property(e => e.Nhiptho)
                .HasMaxLength(255)
                .HasColumnName("NHIPTHO");
            entity.Property(e => e.Noikhoa)
                .HasMaxLength(255)
                .HasColumnName("NOIKHOA");
            entity.Property(e => e.Phauthuatthuthuat)
                .HasMaxLength(255)
                .HasColumnName("PHAUTHUATTHUTHUAT");
            entity.Property(e => e.Quoctich)
                .HasMaxLength(15)
                .HasColumnName("QUOCTICH");
            entity.Property(e => e.Sonha)
                .HasMaxLength(5)
                .HasColumnName("SONHA");
            entity.Property(e => e.Sothebhyt)
                .HasMaxLength(30)
                .HasColumnName("SOTHEBHYT");
            entity.Property(e => e.Tencoquanchuquan)
                .HasMaxLength(255)
                .HasColumnName("TENCOQUANCHUQUAN");
            entity.Property(e => e.Tencosokbcb)
                .HasMaxLength(255)
                .HasColumnName("TENCOSOKBCB");
            entity.Property(e => e.Thanhpho)
                .HasMaxLength(30)
                .HasColumnName("THANHPHO");
            entity.Property(e => e.Thoigianbacsidieutriky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANBACSIDIEUTRIKY");
            entity.Property(e => e.Thoigianbacsidieutrikytk)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANBACSIDIEUTRIKYTK");
            entity.Property(e => e.Thoigiandaidiencskbcbky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANDAIDIENCSKBCBKY");
            entity.Property(e => e.Thoigiandieutridenngay)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANDIEUTRIDENNGAY");
            entity.Property(e => e.Thoigiandieutritungay)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANDIEUTRITUNGAY");
            entity.Property(e => e.Thonpho)
                .HasMaxLength(30)
                .HasColumnName("THONPHO");
            entity.Property(e => e.Tinhtrangravien)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGRAVIEN");
            entity.Property(e => e.Toanthan)
                .HasMaxLength(255)
                .HasColumnName("TOANTHAN");
            entity.Property(e => e.Tomtatbenhan)
                .HasMaxLength(255)
                .HasColumnName("TOMTATBENHAN");
            entity.Property(e => e.Tomtatketquaxetnghiem)
                .HasMaxLength(255)
                .HasColumnName("TOMTATKETQUAXETNGHIEM");
            entity.Property(e => e.Trongmieng)
                .HasMaxLength(255)
                .HasColumnName("TRONGMIENG");
            entity.Property(e => e.Tuoi).HasColumnName("TUOI");
            entity.Property(e => e.Xaphuong)
                .HasMaxLength(30)
                .HasColumnName("XAPHUONG");
            entity.Property(e => e.Xetnghiemlamsang)
                .HasMaxLength(255)
                .HasColumnName("XETNGHIEMLAMSANG");
            entity.Property(e => e.Xutri)
                .HasMaxLength(255)
                .HasColumnName("XUTRI");
        });

        modelBuilder.Entity<Benhannoikhoa>(entity =>
        {
            entity.HasKey(e => e.Mabenhan).HasName("PK__BENHANNO__12DD671698B1E031");

            entity.ToTable("BENHANNOIKHOA");

            entity.Property(e => e.Mabenhan)
                .HasMaxLength(10)
                .HasColumnName("MABENHAN");
            entity.Property(e => e.Anuong)
                .HasMaxLength(255)
                .HasColumnName("ANUONG");
            entity.Property(e => e.Bacsidieutri)
                .HasMaxLength(255)
                .HasColumnName("BACSIDIEUTRI");
            entity.Property(e => e.Bacsilambenhan)
                .HasMaxLength(255)
                .HasColumnName("BACSILAMBENHAN");
            entity.Property(e => e.Benhcaptinhnoisinhsong)
                .HasMaxLength(255)
                .HasColumnName("BENHCAPTINHNOISINHSONG");
            entity.Property(e => e.Benhchinh)
                .HasMaxLength(255)
                .HasColumnName("BENHCHINH");
            entity.Property(e => e.Benhchinhkdt)
                .HasMaxLength(255)
                .HasColumnName("BENHCHINHKDT");
            entity.Property(e => e.Benhkemtheo)
                .HasMaxLength(255)
                .HasColumnName("BENHKEMTHEO");
            entity.Property(e => e.Benhkemtheokdt)
                .HasMaxLength(255)
                .HasColumnName("BENHKEMTHEOKDT");
            entity.Property(e => e.Benhlykhac)
                .HasMaxLength(255)
                .HasColumnName("BENHLYKHAC");
            entity.Property(e => e.Bienchung)
                .HasMaxLength(255)
                .HasColumnName("BIENCHUNG");
            entity.Property(e => e.Bienchungkdt)
                .HasMaxLength(255)
                .HasColumnName("BIENCHUNGKDT");
            entity.Property(e => e.Biendanglongnguc)
                .HasMaxLength(255)
                .HasColumnName("BIENDANGLONGNGUC");
            entity.Property(e => e.Bmi)
                .HasMaxLength(255)
                .HasColumnName("BMI");
            entity.Property(e => e.Buonnon)
                .HasMaxLength(255)
                .HasColumnName("BUONNON");
            entity.Property(e => e.Cancuoc)
                .HasMaxLength(30)
                .HasColumnName("CANCUOC");
            entity.Property(e => e.Cannang)
                .HasMaxLength(255)
                .HasColumnName("CANNANG");
            entity.Property(e => e.Caubangquang)
                .HasMaxLength(255)
                .HasColumnName("CAUBANGQUANG");
            entity.Property(e => e.Chedochamsoc)
                .HasMaxLength(255)
                .HasColumnName("CHEDOCHAMSOC");
            entity.Property(e => e.Chedodinhduong)
                .HasMaxLength(255)
                .HasColumnName("CHEDODINHDUONG");
            entity.Property(e => e.Chieucao)
                .HasMaxLength(255)
                .HasColumnName("CHIEUCAO");
            entity.Property(e => e.Chuandoanbenhvienkhac)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANBENHVIENKHAC");
            entity.Property(e => e.Chuandoanlucvaovienkdt)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANLUCVAOVIENKDT");
            entity.Property(e => e.Chuandoanphanbiekdt)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANPHANBIEKDT");
            entity.Property(e => e.Chuandoanvaovien)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANVAOVIEN");
            entity.Property(e => e.Chuongbung)
                .HasMaxLength(255)
                .HasColumnName("CHUONGBUNG");
            entity.Property(e => e.Chuyenkhoa)
                .HasMaxLength(255)
                .HasColumnName("CHUYENKHOA");
            entity.Property(e => e.Cocung)
                .HasMaxLength(255)
                .HasColumnName("COCUNG");
            entity.Property(e => e.Coluc)
                .HasMaxLength(255)
                .HasColumnName("COLUC");
            entity.Property(e => e.Coxuongkhop)
                .HasMaxLength(255)
                .HasColumnName("COXUONGKHOP");
            entity.Property(e => e.Coxuongkhopkhac)
                .HasMaxLength(255)
                .HasColumnName("COXUONGKHOPKHAC");
            entity.Property(e => e.Daidiencosokbcb)
                .HasMaxLength(255)
                .HasColumnName("DAIDIENCOSOKBCB");
            entity.Property(e => e.Daitienphancomau)
                .HasMaxLength(255)
                .HasColumnName("DAITIENPHANCOMAU");
            entity.Property(e => e.Daniemmac)
                .HasMaxLength(255)
                .HasColumnName("DANIEMMAC");
            entity.Property(e => e.Dantoc)
                .HasMaxLength(20)
                .HasColumnName("DANTOC");
            entity.Property(e => e.Daplech)
                .HasMaxLength(255)
                .HasColumnName("DAPLECH");
            entity.Property(e => e.Dasongonoitruoctrongkhibenh)
                .HasMaxLength(255)
                .HasColumnName("DASONGONOITRUOCTRONGKHIBENH");
            entity.Property(e => e.Dau)
                .HasMaxLength(255)
                .HasColumnName("DAU");
            entity.Property(e => e.Daubung)
                .HasMaxLength(255)
                .HasColumnName("DAUBUNG");
            entity.Property(e => e.Dauco)
                .HasMaxLength(255)
                .HasColumnName("DAUCO");
            entity.Property(e => e.Daucotsong)
                .HasMaxLength(255)
                .HasColumnName("DAUCOTSONG");
            entity.Property(e => e.Daucungkhopbuoisang)
                .HasMaxLength(255)
                .HasColumnName("DAUCUNGKHOPBUOISANG");
            entity.Property(e => e.Daudiemnieuquan)
                .HasMaxLength(255)
                .HasColumnName("DAUDIEMNIEUQUAN");
            entity.Property(e => e.Dauhieulamsangchinh)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEULAMSANGCHINH");
            entity.Property(e => e.Dauhieumangnao)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEUMANGNAO");
            entity.Property(e => e.Daukhop)
                .HasMaxLength(255)
                .HasColumnName("DAUKHOP");
            entity.Property(e => e.Daunguc)
                .HasMaxLength(255)
                .HasColumnName("DAUNGUC");
            entity.Property(e => e.Didong)
                .HasMaxLength(255)
                .HasColumnName("DIDONG");
            entity.Property(e => e.Dienbienbenh)
                .HasMaxLength(255)
                .HasColumnName("DIENBIENBENH");
            entity.Property(e => e.Diendaptim)
                .HasMaxLength(255)
                .HasColumnName("DIENDAPTIM");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(15)
                .HasColumnName("DIENTHOAI");
            entity.Property(e => e.Dienthoaithannhan)
                .HasMaxLength(15)
                .HasColumnName("DIENTHOAITHANNHAN");
            entity.Property(e => e.Diung)
                .HasMaxLength(255)
                .HasColumnName("DIUNG");
            entity.Property(e => e.Diunghoachat)
                .HasMaxLength(255)
                .HasColumnName("DIUNGHOACHAT");
            entity.Property(e => e.Diungkhac)
                .HasMaxLength(255)
                .HasColumnName("DIUNGKHAC");
            entity.Property(e => e.Diungthucpham)
                .HasMaxLength(255)
                .HasColumnName("DIUNGTHUCPHAM");
            entity.Property(e => e.Diungthuoc)
                .HasMaxLength(255)
                .HasColumnName("DIUNGTHUOC");
            entity.Property(e => e.Doituong)
                .HasMaxLength(20)
                .HasColumnName("DOITUONG");
            entity.Property(e => e.Dorungthoitamthu)
                .HasMaxLength(255)
                .HasColumnName("DORUNGTHOITAMTHU");
            entity.Property(e => e.Dorungthoitamtruong)
                .HasMaxLength(255)
                .HasColumnName("DORUNGTHOITAMTRUONG");
            entity.Property(e => e.Duongkinhhach)
                .HasMaxLength(255)
                .HasColumnName("DUONGKINHHACH");
            entity.Property(e => e.Gan)
                .HasMaxLength(255)
                .HasColumnName("GAN");
            entity.Property(e => e.Ghichuravien)
                .HasMaxLength(255)
                .HasColumnName("GHICHURAVIEN");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(3)
                .HasColumnName("GIOITINH");
            entity.Property(e => e.Giothu)
                .HasMaxLength(255)
                .HasColumnName("GIOTHU");
            entity.Property(e => e.Glasgow)
                .HasMaxLength(255)
                .HasColumnName("GLASGOW");
            entity.Property(e => e.Goo)
                .HasMaxLength(255)
                .HasColumnName("GOO");
            entity.Property(e => e.Hachsoduoc)
                .HasMaxLength(255)
                .HasColumnName("HACHSODUOC");
            entity.Property(e => e.Hanchevandongkhop)
                .HasMaxLength(255)
                .HasColumnName("HANCHEVANDONGKHOP");
            entity.Property(e => e.Hattphi)
                .HasMaxLength(255)
                .HasColumnName("HATTPHI");
            entity.Property(e => e.Hohap)
                .HasMaxLength(255)
                .HasColumnName("HOHAP");
            entity.Property(e => e.Hohapkhac)
                .HasMaxLength(255)
                .HasColumnName("HOHAPKHAC");
            entity.Property(e => e.Hoihopdanhtrongnguc)
                .HasMaxLength(255)
                .HasColumnName("HOIHOPDANHTRONGNGUC");
            entity.Property(e => e.Hong)
                .HasMaxLength(255)
                .HasColumnName("HONG");
            entity.Property(e => e.Honme)
                .HasMaxLength(255)
                .HasColumnName("HONME");
            entity.Property(e => e.Hotenthannhan)
                .HasMaxLength(255)
                .HasColumnName("HOTENTHANNHAN");
            entity.Property(e => e.Hovaten)
                .HasMaxLength(255)
                .HasColumnName("HOVATEN");
            entity.Property(e => e.Huongdieutri)
                .HasMaxLength(255)
                .HasColumnName("HUONGDIEUTRI");
            entity.Property(e => e.Huongdieutritt)
                .HasMaxLength(255)
                .HasColumnName("HUONGDIEUTRITT");
            entity.Property(e => e.Huyen)
                .HasMaxLength(30)
                .HasColumnName("HUYEN");
            entity.Property(e => e.Huyetap)
                .HasMaxLength(255)
                .HasColumnName("HUYETAP");
            entity.Property(e => e.Ketmacmat)
                .HasMaxLength(255)
                .HasColumnName("KETMACMAT");
            entity.Property(e => e.Khotho)
                .HasMaxLength(255)
                .HasColumnName("KHOTHO");
            entity.Property(e => e.Lach)
                .HasMaxLength(255)
                .HasColumnName("LACH");
            entity.Property(e => e.Lanhdaokhoa)
                .HasMaxLength(255)
                .HasColumnName("LANHDAOKHOA");
            entity.Property(e => e.Liethaichiduoi)
                .HasMaxLength(255)
                .HasColumnName("LIETHAICHIDUOI");
            entity.Property(e => e.Lietmotphanhainguoiphai)
                .HasMaxLength(255)
                .HasColumnName("LIETMOTPHANHAINGUOIPHAI");
            entity.Property(e => e.Lietmotphanhainguoitrai)
                .HasMaxLength(255)
                .HasColumnName("LIETMOTPHANHAINGUOITRAI");
            entity.Property(e => e.Liettuchi)
                .HasMaxLength(255)
                .HasColumnName("LIETTUCHI");
            entity.Property(e => e.Lieuluongsudungruoubia)
                .HasMaxLength(255)
                .HasColumnName("LIEULUONGSUDUNGRUOUBIA");
            entity.Property(e => e.Lieuluongsudungthuocla)
                .HasMaxLength(255)
                .HasColumnName("LIEULUONGSUDUNGTHUOCLA");
            entity.Property(e => e.Loaichatgaynghien)
                .HasMaxLength(255)
                .HasColumnName("LOAICHATGAYNGHIEN");
            entity.Property(e => e.Loaihoachat)
                .HasMaxLength(255)
                .HasColumnName("LOAIHOACHAT");
            entity.Property(e => e.Loannhip)
                .HasMaxLength(255)
                .HasColumnName("LOANNHIP");
            entity.Property(e => e.Lomo)
                .HasMaxLength(255)
                .HasColumnName("LOMO");
            entity.Property(e => e.Longtocmong)
                .HasMaxLength(255)
                .HasColumnName("LONGTOCMONG");
            entity.Property(e => e.Luoi)
                .HasMaxLength(255)
                .HasColumnName("LUOI");
            entity.Property(e => e.Lydoravien)
                .HasMaxLength(255)
                .HasColumnName("LYDORAVIEN");
            entity.Property(e => e.Lydovaovien)
                .HasMaxLength(255)
                .HasColumnName("LYDOVAOVIEN");
            entity.Property(e => e.Mabenhchinh)
                .HasMaxLength(10)
                .HasColumnName("MABENHCHINH");
            entity.Property(e => e.Mabenhchinhkdt)
                .HasMaxLength(255)
                .HasColumnName("MABENHCHINHKDT");
            entity.Property(e => e.Mabenhkemtheo)
                .HasMaxLength(10)
                .HasColumnName("MABENHKEMTHEO");
            entity.Property(e => e.Mabenhkemtheokdt)
                .HasMaxLength(255)
                .HasColumnName("MABENHKEMTHEOKDT");
            entity.Property(e => e.Mabienchung)
                .HasMaxLength(10)
                .HasColumnName("MABIENCHUNG");
            entity.Property(e => e.Mabienchungkdt)
                .HasMaxLength(255)
                .HasColumnName("MABIENCHUNGKDT");
            entity.Property(e => e.Mach)
                .HasMaxLength(255)
                .HasColumnName("MACH");
            entity.Property(e => e.Machuandoanlucvaovienkdt)
                .HasMaxLength(255)
                .HasColumnName("MACHUANDOANLUCVAOVIENKDT");
            entity.Property(e => e.Machuandoanphanbietkdt)
                .HasMaxLength(255)
                .HasColumnName("MACHUANDOANPHANBIETKDT");
            entity.Property(e => e.Machuandoanvaovien)
                .HasMaxLength(10)
                .HasColumnName("MACHUANDOANVAOVIEN");
            entity.Property(e => e.Macoquanchuquan)
                .HasMaxLength(10)
                .HasColumnName("MACOQUANCHUQUAN");
            entity.Property(e => e.Macosokbcb)
                .HasMaxLength(10)
                .HasColumnName("MACOSOKBCB");
            entity.Property(e => e.Macosokbcbchuyenden)
                .HasMaxLength(10)
                .HasColumnName("MACOSOKBCBCHUYENDEN");
            entity.Property(e => e.Macosokbcbchuyendi)
                .HasMaxLength(10)
                .HasColumnName("MACOSOKBCBCHUYENDI");
            entity.Property(e => e.Madantoc)
                .HasMaxLength(2)
                .HasColumnName("MADANTOC");
            entity.Property(e => e.Mahuyen)
                .HasMaxLength(3)
                .HasColumnName("MAHUYEN");
            entity.Property(e => e.Manguyennhanchinhtuvong)
                .HasMaxLength(10)
                .HasColumnName("MANGUYENNHANCHINHTUVONG");
            entity.Property(e => e.Maquoctich)
                .HasMaxLength(3)
                .HasColumnName("MAQUOCTICH");
            entity.Property(e => e.Mat)
                .HasMaxLength(255)
                .HasColumnName("MAT");
            entity.Property(e => e.Mathanhpho)
                .HasMaxLength(2)
                .HasColumnName("MATHANHPHO");
            entity.Property(e => e.Matkhac)
                .HasMaxLength(255)
                .HasColumnName("MATKHAC");
            entity.Property(e => e.Mausac)
                .HasMaxLength(255)
                .HasColumnName("MAUSAC");
            entity.Property(e => e.Mausacnuoctieu)
                .HasMaxLength(255)
                .HasColumnName("MAUSACNUOCTIEU");
            entity.Property(e => e.Maxaphuong)
                .HasMaxLength(5)
                .HasColumnName("MAXAPHUONG");
            entity.Property(e => e.Moisinh)
                .HasMaxLength(255)
                .HasColumnName("MOISINH");
            entity.Property(e => e.Motachuandoanbenhvienkhac)
                .HasMaxLength(255)
                .HasColumnName("MOTACHUANDOANBENHVIENKHAC");
            entity.Property(e => e.Motahong)
                .HasMaxLength(255)
                .HasColumnName("MOTAHONG");
            entity.Property(e => e.Motamat)
                .HasMaxLength(255)
                .HasColumnName("MOTAMAT");
            entity.Property(e => e.Motamui)
                .HasMaxLength(255)
                .HasColumnName("MOTAMUI");
            entity.Property(e => e.Motanoikhoa)
                .HasMaxLength(255)
                .HasColumnName("MOTANOIKHOA");
            entity.Property(e => e.Motanoitiet)
                .HasMaxLength(255)
                .HasColumnName("MOTANOITIET");
            entity.Property(e => e.Motaphauthuatthuthuat)
                .HasMaxLength(255)
                .HasColumnName("MOTAPHAUTHUATTHUTHUAT");
            entity.Property(e => e.Motaphuchoichucnang)
                .HasMaxLength(255)
                .HasColumnName("MOTAPHUCHOICHUCNANG");
            entity.Property(e => e.Motaranghammat)
                .HasMaxLength(255)
                .HasColumnName("MOTARANGHAMMAT");
            entity.Property(e => e.Motatai)
                .HasMaxLength(255)
                .HasColumnName("MOTATAI");
            entity.Property(e => e.Motathanhquan)
                .HasMaxLength(255)
                .HasColumnName("MOTATHANHQUAN");
            entity.Property(e => e.Motatuvansuckhoe)
                .HasMaxLength(255)
                .HasColumnName("MOTATUVANSUCKHOE");
            entity.Property(e => e.Motaxetnghiemlamsang)
                .HasMaxLength(255)
                .HasColumnName("MOTAXETNGHIEMLAMSANG");
            entity.Property(e => e.Mucdorungtamtruong)
                .HasMaxLength(255)
                .HasColumnName("MUCDORUNGTAMTRUONG");
            entity.Property(e => e.Mucdothoitamthu)
                .HasMaxLength(255)
                .HasColumnName("MUCDOTHOITAMTHU");
            entity.Property(e => e.Mucdothoitamtruong)
                .HasMaxLength(255)
                .HasColumnName("MUCDOTHOITAMTRUONG");
            entity.Property(e => e.Mui)
                .HasMaxLength(255)
                .HasColumnName("MUI");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Ngaythu)
                .HasMaxLength(255)
                .HasColumnName("NGAYTHU");
            entity.Property(e => e.Nghenghiep)
                .HasMaxLength(255)
                .HasColumnName("NGHENGHIEP");
            entity.Property(e => e.Nguga)
                .HasMaxLength(255)
                .HasColumnName("NGUGA");
            entity.Property(e => e.Nguoimac)
                .HasMaxLength(255)
                .HasColumnName("NGUOIMAC");
            entity.Property(e => e.Nguyennhanchinhtuvong)
                .HasMaxLength(255)
                .HasColumnName("NGUYENNHANCHINHTUVONG");
            entity.Property(e => e.Nhietdo)
                .HasMaxLength(255)
                .HasColumnName("NHIETDO");
            entity.Property(e => e.Nhipcham)
                .HasMaxLength(255)
                .HasColumnName("NHIPCHAM");
            entity.Property(e => e.Nhipnhanh)
                .HasMaxLength(255)
                .HasColumnName("NHIPNHANH");
            entity.Property(e => e.Nhiptho)
                .HasMaxLength(255)
                .HasColumnName("NHIPTHO");
            entity.Property(e => e.Noichuyenden)
                .HasMaxLength(255)
                .HasColumnName("NOICHUYENDEN");
            entity.Property(e => e.Noichuyendi)
                .HasMaxLength(255)
                .HasColumnName("NOICHUYENDI");
            entity.Property(e => e.Noikhoa)
                .HasMaxLength(255)
                .HasColumnName("NOIKHOA");
            entity.Property(e => e.Noitiet)
                .HasMaxLength(255)
                .HasColumnName("NOITIET");
            entity.Property(e => e.Noitietdinhduongkhac)
                .HasMaxLength(255)
                .HasColumnName("NOITIETDINHDUONGKHAC");
            entity.Property(e => e.Non)
                .HasMaxLength(255)
                .HasColumnName("NON");
            entity.Property(e => e.Phanungthanhbung)
                .HasMaxLength(255)
                .HasColumnName("PHANUNGTHANHBUNG");
            entity.Property(e => e.Phanxaganxuong)
                .HasMaxLength(255)
                .HasColumnName("PHANXAGANXUONG");
            entity.Property(e => e.Phauthuatthuthuat)
                .HasMaxLength(255)
                .HasColumnName("PHAUTHUATTHUTHUAT");
            entity.Property(e => e.Phu)
                .HasMaxLength(255)
                .HasColumnName("PHU");
            entity.Property(e => e.Phuchoichucnang)
                .HasMaxLength(255)
                .HasColumnName("PHUCHOICHUCNANG");
            entity.Property(e => e.Quoctich)
                .HasMaxLength(15)
                .HasColumnName("QUOCTICH");
            entity.Property(e => e.Rale)
                .HasMaxLength(255)
                .HasColumnName("RALE");
            entity.Property(e => e.Ranghammat)
                .HasMaxLength(255)
                .HasColumnName("RANGHAMMAT");
            entity.Property(e => e.Ranghammatkhac)
                .HasMaxLength(255)
                .HasColumnName("RANGHAMMATKHAC");
            entity.Property(e => e.Riraophenang)
                .HasMaxLength(255)
                .HasColumnName("RIRAOPHENANG");
            entity.Property(e => e.Rungtamtruong)
                .HasMaxLength(255)
                .HasColumnName("RUNGTAMTRUONG");
            entity.Property(e => e.Rungthan)
                .HasMaxLength(255)
                .HasColumnName("RUNGTHAN");
            entity.Property(e => e.Rungthanh)
                .HasMaxLength(255)
                .HasColumnName("RUNGTHANH");
            entity.Property(e => e.Solantieuchay)
                .HasMaxLength(255)
                .HasColumnName("SOLANTIEUCHAY");
            entity.Property(e => e.Soluonghach)
                .HasMaxLength(255)
                .HasColumnName("SOLUONGHACH");
            entity.Property(e => e.Songaychuyenkhoa).HasColumnName("SONGAYCHUYENKHOA");
            entity.Property(e => e.Songayvaokhoa).HasColumnName("SONGAYVAOKHOA");
            entity.Property(e => e.Sonha)
                .HasMaxLength(5)
                .HasColumnName("SONHA");
            entity.Property(e => e.Sothebhyt)
                .HasMaxLength(30)
                .HasColumnName("SOTHEBHYT");
            entity.Property(e => e.Spo2)
                .HasMaxLength(255)
                .HasColumnName("SPO2");
            entity.Property(e => e.Sungdokhop)
                .HasMaxLength(255)
                .HasColumnName("SUNGDOKHOP");
            entity.Property(e => e.Tai)
                .HasMaxLength(255)
                .HasColumnName("TAI");
            entity.Property(e => e.Taimuihong)
                .HasMaxLength(255)
                .HasColumnName("TAIMUIHONG");
            entity.Property(e => e.Taimuihongkhac)
                .HasMaxLength(255)
                .HasColumnName("TAIMUIHONGKHAC");
            entity.Property(e => e.Tenbenh)
                .HasMaxLength(255)
                .HasColumnName("TENBENH");
            entity.Property(e => e.Tencoquanchuquan)
                .HasMaxLength(255)
                .HasColumnName("TENCOQUANCHUQUAN");
            entity.Property(e => e.Tencosokbcb)
                .HasMaxLength(255)
                .HasColumnName("TENCOSOKBCB");
            entity.Property(e => e.Than)
                .HasMaxLength(255)
                .HasColumnName("THAN");
            entity.Property(e => e.Thanhpho)
                .HasMaxLength(30)
                .HasColumnName("THANHPHO");
            entity.Property(e => e.Thanhquan)
                .HasMaxLength(255)
                .HasColumnName("THANHQUAN");
            entity.Property(e => e.Thankhac)
                .HasMaxLength(255)
                .HasColumnName("THANKHAC");
            entity.Property(e => e.Thankinh)
                .HasMaxLength(255)
                .HasColumnName("THANKINH");
            entity.Property(e => e.Thankinhkhac)
                .HasMaxLength(255)
                .HasColumnName("THANKINHKHAC");
            entity.Property(e => e.Thetich)
                .HasMaxLength(255)
                .HasColumnName("THETICH");
            entity.Property(e => e.Thoidiemtuvong)
                .HasMaxLength(255)
                .HasColumnName("THOIDIEMTUVONG");
            entity.Property(e => e.Thoiganbacsilambenhanky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGANBACSILAMBENHANKY");
            entity.Property(e => e.Thoigianbacsidieutriky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANBACSIDIEUTRIKY");
            entity.Property(e => e.Thoigianchuyenkhoa)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANCHUYENKHOA");
            entity.Property(e => e.Thoigiandaidienky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANDAIDIENKY");
            entity.Property(e => e.Thoigiandasong)
                .HasMaxLength(255)
                .HasColumnName("THOIGIANDASONG");
            entity.Property(e => e.Thoigianravien)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANRAVIEN");
            entity.Property(e => e.Thoigiansudungchatgaynghien)
                .HasMaxLength(255)
                .HasColumnName("THOIGIANSUDUNGCHATGAYNGHIEN");
            entity.Property(e => e.Thoigiansudungthuocla)
                .HasMaxLength(255)
                .HasColumnName("THOIGIANSUDUNGTHUOCLA");
            entity.Property(e => e.Thoigiansudungthuoclao)
                .HasMaxLength(255)
                .HasColumnName("THOIGIANSUDUNGTHUOCLAO");
            entity.Property(e => e.Thoigiantiepxuchoachat)
                .HasMaxLength(255)
                .HasColumnName("THOIGIANTIEPXUCHOACHAT");
            entity.Property(e => e.Thoigiantuvong)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANTUVONG");
            entity.Property(e => e.Thoigianvaokhoa)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANVAOKHOA");
            entity.Property(e => e.Thoigianvaovien)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANVAOVIEN");
            entity.Property(e => e.Thoilientuc)
                .HasMaxLength(255)
                .HasColumnName("THOILIENTUC");
            entity.Property(e => e.Thoitamthu)
                .HasMaxLength(255)
                .HasColumnName("THOITAMTHU");
            entity.Property(e => e.Thoitamtruong)
                .HasMaxLength(255)
                .HasColumnName("THOITAMTRUONG");
            entity.Property(e => e.Thonpho)
                .HasMaxLength(30)
                .HasColumnName("THONPHO");
            entity.Property(e => e.Thuocdangdung)
                .HasMaxLength(255)
                .HasColumnName("THUOCDANGDUNG");
            entity.Property(e => e.Tiengthoidongmach)
                .HasMaxLength(255)
                .HasColumnName("TIENGTHOIDONGMACH");
            entity.Property(e => e.Tiengtimmo)
                .HasMaxLength(255)
                .HasColumnName("TIENGTIMMO");
            entity.Property(e => e.Tienluonggan)
                .HasMaxLength(255)
                .HasColumnName("TIENLUONGGAN");
            entity.Property(e => e.Tienluongxa)
                .HasMaxLength(255)
                .HasColumnName("TIENLUONGXA");
            entity.Property(e => e.Tiensubenh)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENH");
            entity.Property(e => e.Tiensubenhhohap)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHHOHAP");
            entity.Property(e => e.Tiensubenhkhac)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHKHAC");
            entity.Property(e => e.Tiensubenhnoitiet)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHNOITIET");
            entity.Property(e => e.Tiensubenhthan)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHTHAN");
            entity.Property(e => e.Tiensubenhthankinh)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHTHANKINH");
            entity.Property(e => e.Tiensubenhtieuhoa)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHTIEUHOA");
            entity.Property(e => e.Tiensubenhtimmach)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHTIMMACH");
            entity.Property(e => e.Tiensubenhungthu)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHUNGTHU");
            entity.Property(e => e.Tiensubenhxuongkhop)
                .HasMaxLength(255)
                .HasColumnName("TIENSUBENHXUONGKHOP");
            entity.Property(e => e.Tiensugiadinh)
                .HasMaxLength(255)
                .HasColumnName("TIENSUGIADINH");
            entity.Property(e => e.Tiensuphauthuat)
                .HasMaxLength(255)
                .HasColumnName("TIENSUPHAUTHUAT");
            entity.Property(e => e.Tiepnhantu)
                .HasMaxLength(255)
                .HasColumnName("TIEPNHANTU");
            entity.Property(e => e.Tiepxuctot)
                .HasMaxLength(255)
                .HasColumnName("TIEPXUCTOT");
            entity.Property(e => e.Tieubuot)
                .HasMaxLength(255)
                .HasColumnName("TIEUBUOT");
            entity.Property(e => e.Tieuchay)
                .HasMaxLength(255)
                .HasColumnName("TIEUCHAY");
            entity.Property(e => e.Tieuhoa)
                .HasMaxLength(255)
                .HasColumnName("TIEUHOA");
            entity.Property(e => e.Tieuhoakhac)
                .HasMaxLength(255)
                .HasColumnName("TIEUHOAKHAC");
            entity.Property(e => e.Tieurat)
                .HasMaxLength(255)
                .HasColumnName("TIEURAT");
            entity.Property(e => e.Tinhchat)
                .HasMaxLength(255)
                .HasColumnName("TINHCHAT");
            entity.Property(e => e.Tinhtrangdaitienphancomau)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGDAITIENPHANCOMAU");
            entity.Property(e => e.Tinhtrangdaunguc)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGDAUNGUC");
            entity.Property(e => e.Tinhtrangmaunon)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGMAUNON");
            entity.Property(e => e.Tinhtrangrale)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGRALE");
            entity.Property(e => e.Tinhtrangravien)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGRAVIEN");
            entity.Property(e => e.Tinhtrangravientk)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGRAVIENTK");
            entity.Property(e => e.Tinhtrangvao)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGVAO");
            entity.Property(e => e.Toanthan)
                .HasMaxLength(255)
                .HasColumnName("TOANTHAN");
            entity.Property(e => e.Toanthanbenhkhac)
                .HasMaxLength(255)
                .HasColumnName("TOANTHANBENHKHAC");
            entity.Property(e => e.Tomtatbenhan)
                .HasMaxLength(255)
                .HasColumnName("TOMTATBENHAN");
            entity.Property(e => e.Tomtatketquaxetnghiem)
                .HasMaxLength(255)
                .HasColumnName("TOMTATKETQUAXETNGHIEM");
            entity.Property(e => e.Tomtatquatrinhbenhly)
                .HasMaxLength(255)
                .HasColumnName("TOMTATQUATRINHBENHLY");
            entity.Property(e => e.Tongsongaydieutri).HasColumnName("TONGSONGAYDIEUTRI");
            entity.Property(e => e.Truonglucco)
                .HasMaxLength(255)
                .HasColumnName("TRUONGLUCCO");
            entity.Property(e => e.Tuanhoan)
                .HasMaxLength(255)
                .HasColumnName("TUANHOAN");
            entity.Property(e => e.Tuanhoankhac)
                .HasMaxLength(255)
                .HasColumnName("TUANHOANKHAC");
            entity.Property(e => e.Tuoi).HasColumnName("TUOI");
            entity.Property(e => e.Tuvansuckhoe)
                .HasMaxLength(255)
                .HasColumnName("TUVANSUCKHOE");
            entity.Property(e => e.Tuyengiap)
                .HasMaxLength(255)
                .HasColumnName("TUYENGIAP");
            entity.Property(e => e.Vaokhoa)
                .HasMaxLength(255)
                .HasColumnName("VAOKHOA");
            entity.Property(e => e.Vitricoluc)
                .HasMaxLength(255)
                .HasColumnName("VITRICOLUC");
            entity.Property(e => e.Vitridaubung)
                .HasMaxLength(255)
                .HasColumnName("VITRIDAUBUNG");
            entity.Property(e => e.Vitridauco)
                .HasMaxLength(255)
                .HasColumnName("VITRIDAUCO");
            entity.Property(e => e.Vitridaucotsong)
                .HasMaxLength(255)
                .HasColumnName("VITRIDAUCOTSONG");
            entity.Property(e => e.Vitridaudiemnieuquan)
                .HasMaxLength(255)
                .HasColumnName("VITRIDAUDIEMNIEUQUAN");
            entity.Property(e => e.Vitridaukhop)
                .HasMaxLength(255)
                .HasColumnName("VITRIDAUKHOP");
            entity.Property(e => e.Vitrigan)
                .HasMaxLength(255)
                .HasColumnName("VITRIGAN");
            entity.Property(e => e.Vitrigo)
                .HasMaxLength(255)
                .HasColumnName("VITRIGO");
            entity.Property(e => e.Vitrihach)
                .HasMaxLength(255)
                .HasColumnName("VITRIHACH");
            entity.Property(e => e.Vitrihanchevandongkhop)
                .HasMaxLength(255)
                .HasColumnName("VITRIHANCHEVANDONGKHOP");
            entity.Property(e => e.Vitrihattophi)
                .HasMaxLength(255)
                .HasColumnName("VITRIHATTOPHI");
            entity.Property(e => e.Vitrilach)
                .HasMaxLength(255)
                .HasColumnName("VITRILACH");
            entity.Property(e => e.Vitriphanxaganxuong)
                .HasMaxLength(255)
                .HasColumnName("VITRIPHANXAGANXUONG");
            entity.Property(e => e.Vitriphu)
                .HasMaxLength(255)
                .HasColumnName("VITRIPHU");
            entity.Property(e => e.Vitririraophenang)
                .HasMaxLength(255)
                .HasColumnName("VITRIRIRAOPHENANG");
            entity.Property(e => e.Vitrirungtamtruong)
                .HasMaxLength(255)
                .HasColumnName("VITRIRUNGTAMTRUONG");
            entity.Property(e => e.Vitrirungthanh)
                .HasMaxLength(255)
                .HasColumnName("VITRIRUNGTHANH");
            entity.Property(e => e.Vitrisuongdokhop)
                .HasMaxLength(255)
                .HasColumnName("VITRISUONGDOKHOP");
            entity.Property(e => e.Vitrithoilientuc)
                .HasMaxLength(255)
                .HasColumnName("VITRITHOILIENTUC");
            entity.Property(e => e.Vitrithoitamthu)
                .HasMaxLength(255)
                .HasColumnName("VITRITHOITAMTHU");
            entity.Property(e => e.Vitrithoitamtruong)
                .HasMaxLength(255)
                .HasColumnName("VITRITHOITAMTRUONG");
            entity.Property(e => e.Vitritiengthoidongmach)
                .HasMaxLength(255)
                .HasColumnName("VITRITIENGTHOIDONGMACH");
            entity.Property(e => e.Vitritiengtimmo)
                .HasMaxLength(255)
                .HasColumnName("VITRITIENGTIMMO");
            entity.Property(e => e.Vitritruonglucco)
                .HasMaxLength(255)
                .HasColumnName("VITRITRUONGLUCCO");
            entity.Property(e => e.Vitrixuathuyetduoida)
                .HasMaxLength(255)
                .HasColumnName("VITRIXUATHUYETDUOIDA");
            entity.Property(e => e.Vitrixuathuyetniemmac)
                .HasMaxLength(255)
                .HasColumnName("VITRIXUATHUYETNIEMMAC");
            entity.Property(e => e.Xaphuong)
                .HasMaxLength(30)
                .HasColumnName("XAPHUONG");
            entity.Property(e => e.Xetnghiemlamsang)
                .HasMaxLength(255)
                .HasColumnName("XETNGHIEMLAMSANG");
            entity.Property(e => e.Xuathuyetduoida)
                .HasMaxLength(255)
                .HasColumnName("XUATHUYETDUOIDA");
            entity.Property(e => e.Xuathuyetniemmac)
                .HasMaxLength(255)
                .HasColumnName("XUATHUYETNIEMMAC");
            entity.Property(e => e.Yeutodichte)
                .HasMaxLength(255)
                .HasColumnName("YEUTODICHTE");
            entity.Property(e => e.Yeutonguyco)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCO");
            entity.Property(e => e.Yeutonguycochatgaynghien)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCOCHATGAYNGHIEN");
            entity.Property(e => e.Yeutonguycokhac)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCOKHAC");
            entity.Property(e => e.Yeutonguycoruoubia)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCORUOUBIA");
            entity.Property(e => e.Yeutonguycothuocla)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCOTHUOCLA");
            entity.Property(e => e.Yeutonguycothuoclao)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCOTHUOCLAO");
            entity.Property(e => e.Yeutonguycotiepxuchoachat)
                .HasMaxLength(255)
                .HasColumnName("YEUTONGUYCOTIEPXUCHOACHAT");
        });

        modelBuilder.Entity<Benhanphukhoa>(entity =>
        {
            entity.HasKey(e => e.Mabenhan).HasName("PK__BENHANPH__12DD67161973447E");

            entity.ToTable("BENHANPHUKHOA");

            entity.Property(e => e.Mabenhan)
                .HasMaxLength(10)
                .HasColumnName("MABENHAN");
            entity.Property(e => e.Bacsidieutri)
                .HasMaxLength(255)
                .HasColumnName("BACSIDIEUTRI");
            entity.Property(e => e.Bacsilambenhan)
                .HasMaxLength(255)
                .HasColumnName("BACSILAMBENHAN");
            entity.Property(e => e.Batdaucokinh)
                .HasMaxLength(255)
                .HasColumnName("BATDAUCOKINH");
            entity.Property(e => e.Benhchinh)
                .HasMaxLength(255)
                .HasColumnName("BENHCHINH");
            entity.Property(e => e.Benhchinhkdt)
                .HasMaxLength(255)
                .HasColumnName("BENHCHINHKDT");
            entity.Property(e => e.Benhkemtheo)
                .HasMaxLength(255)
                .HasColumnName("BENHKEMTHEO");
            entity.Property(e => e.Benhkemtheokdt)
                .HasMaxLength(255)
                .HasColumnName("BENHKEMTHEOKDT");
            entity.Property(e => e.Benhsu)
                .HasMaxLength(255)
                .HasColumnName("BENHSU");
            entity.Property(e => e.Bienchung)
                .HasMaxLength(255)
                .HasColumnName("BIENCHUNG");
            entity.Property(e => e.Bienchungkdt)
                .HasMaxLength(255)
                .HasColumnName("BIENCHUNGKDT");
            entity.Property(e => e.Bienphaptranhthai)
                .HasMaxLength(255)
                .HasColumnName("BIENPHAPTRANHTHAI");
            entity.Property(e => e.Bienphaptranhthaiduoccap)
                .HasMaxLength(255)
                .HasColumnName("BIENPHAPTRANHTHAIDUOCCAP");
            entity.Property(e => e.Cacbenhkhac)
                .HasMaxLength(255)
                .HasColumnName("CACBENHKHAC");
            entity.Property(e => e.Cacbenhphukhoadieutri)
                .HasMaxLength(255)
                .HasColumnName("CACBENHPHUKHOADIEUTRI");
            entity.Property(e => e.Cachthucsinh)
                .HasMaxLength(255)
                .HasColumnName("CACHTHUCSINH");
            entity.Property(e => e.Cacxetnghiemkhac)
                .HasMaxLength(255)
                .HasColumnName("CACXETNGHIEMKHAC");
            entity.Property(e => e.Cancuoc)
                .HasMaxLength(30)
                .HasColumnName("CANCUOC");
            entity.Property(e => e.Chaymau)
                .HasMaxLength(255)
                .HasColumnName("CHAYMAU");
            entity.Property(e => e.Chedochamsoc)
                .HasMaxLength(255)
                .HasColumnName("CHEDOCHAMSOC");
            entity.Property(e => e.Chuandoanbenhvienkhac)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANBENHVIENKHAC");
            entity.Property(e => e.Chuandoanlucvaovienkdt)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANLUCVAOVIENKDT");
            entity.Property(e => e.Chuandoanphanbiekdt)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANPHANBIEKDT");
            entity.Property(e => e.Chuandoanvaovien)
                .HasMaxLength(255)
                .HasColumnName("CHUANDOANVAOVIEN");
            entity.Property(e => e.Chuky)
                .HasMaxLength(255)
                .HasColumnName("CHUKY");
            entity.Property(e => e.Chuyenkhoa)
                .HasMaxLength(255)
                .HasColumnName("CHUYENKHOA");
            entity.Property(e => e.Da)
                .HasMaxLength(255)
                .HasColumnName("DA");
            entity.Property(e => e.Daidiencosokbcb)
                .HasMaxLength(255)
                .HasColumnName("DAIDIENCOSOKBCB");
            entity.Property(e => e.Dantoc)
                .HasMaxLength(20)
                .HasColumnName("DANTOC");
            entity.Property(e => e.Daubung)
                .HasMaxLength(255)
                .HasColumnName("DAUBUNG");
            entity.Property(e => e.Dauhieulamsang)
                .HasMaxLength(255)
                .HasColumnName("DAUHIEULAMSANG");
            entity.Property(e => e.Dienbienbenh)
                .HasMaxLength(255)
                .HasColumnName("DIENBIENBENH");
            entity.Property(e => e.Dienbienlamsang)
                .HasMaxLength(255)
                .HasColumnName("DIENBIENLAMSANG");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(15)
                .HasColumnName("DIENTHOAI");
            entity.Property(e => e.Dienthoaithannhan)
                .HasMaxLength(15)
                .HasColumnName("DIENTHOAITHANNHAN");
            entity.Property(e => e.Dieutrikhac)
                .HasMaxLength(255)
                .HasColumnName("DIEUTRIKHAC");
            entity.Property(e => e.Doituong)
                .HasMaxLength(20)
                .HasColumnName("DOITUONG");
            entity.Property(e => e.Dotdien)
                .HasMaxLength(255)
                .HasColumnName("DOTDIEN");
            entity.Property(e => e.Ghichuravien)
                .HasMaxLength(255)
                .HasColumnName("GHICHURAVIEN");
            entity.Property(e => e.Gioitinh)
                .HasMaxLength(3)
                .HasColumnName("GIOITINH");
            entity.Property(e => e.Giothu)
                .HasMaxLength(255)
                .HasColumnName("GIOTHU");
            entity.Property(e => e.Hotenthannhan)
                .HasMaxLength(255)
                .HasColumnName("HOTENTHANNHAN");
            entity.Property(e => e.Hovaten)
                .HasMaxLength(255)
                .HasColumnName("HOVATEN");
            entity.Property(e => e.Huongdieutri)
                .HasMaxLength(255)
                .HasColumnName("HUONGDIEUTRI");
            entity.Property(e => e.Huongdieutritieptheo)
                .HasMaxLength(255)
                .HasColumnName("HUONGDIEUTRITIEPTHEO");
            entity.Property(e => e.Huyen)
                .HasMaxLength(30)
                .HasColumnName("HUYEN");
            entity.Property(e => e.Huyetap)
                .HasMaxLength(255)
                .HasColumnName("HUYETAP");
            entity.Property(e => e.Khamthucthe)
                .HasMaxLength(255)
                .HasColumnName("KHAMTHUCTHE");
            entity.Property(e => e.Khoetchop)
                .HasMaxLength(255)
                .HasColumnName("KHOETCHOP");
            entity.Property(e => e.Lanhdaokhoa)
                .HasMaxLength(255)
                .HasColumnName("LANHDAOKHOA");
            entity.Property(e => e.Leep)
                .HasMaxLength(255)
                .HasColumnName("LEEP");
            entity.Property(e => e.Lskhac)
                .HasMaxLength(255)
                .HasColumnName("LSKHAC");
            entity.Property(e => e.Lydoravien)
                .HasMaxLength(255)
                .HasColumnName("LYDORAVIEN");
            entity.Property(e => e.Lydovaovien)
                .HasMaxLength(255)
                .HasColumnName("LYDOVAOVIEN");
            entity.Property(e => e.Mabenhchinh)
                .HasMaxLength(10)
                .HasColumnName("MABENHCHINH");
            entity.Property(e => e.Mabenhchinhkdt)
                .HasMaxLength(255)
                .HasColumnName("MABENHCHINHKDT");
            entity.Property(e => e.Mabenhkemtheo)
                .HasMaxLength(10)
                .HasColumnName("MABENHKEMTHEO");
            entity.Property(e => e.Mabenhkemtheokdt)
                .HasMaxLength(255)
                .HasColumnName("MABENHKEMTHEOKDT");
            entity.Property(e => e.Mabienchung)
                .HasMaxLength(10)
                .HasColumnName("MABIENCHUNG");
            entity.Property(e => e.Mabienchungkdt)
                .HasMaxLength(255)
                .HasColumnName("MABIENCHUNGKDT");
            entity.Property(e => e.Mach)
                .HasMaxLength(255)
                .HasColumnName("MACH");
            entity.Property(e => e.Machuandoanlucvaovienkdt)
                .HasMaxLength(255)
                .HasColumnName("MACHUANDOANLUCVAOVIENKDT");
            entity.Property(e => e.Machuandoanphanbietkdt)
                .HasMaxLength(255)
                .HasColumnName("MACHUANDOANPHANBIETKDT");
            entity.Property(e => e.Machuandoanvaovien)
                .HasMaxLength(10)
                .HasColumnName("MACHUANDOANVAOVIEN");
            entity.Property(e => e.Macoquanchuquan)
                .HasMaxLength(10)
                .HasColumnName("MACOQUANCHUQUAN");
            entity.Property(e => e.Macosokbcb)
                .HasMaxLength(10)
                .HasColumnName("MACOSOKBCB");
            entity.Property(e => e.Macosokbcbchuyenden)
                .HasMaxLength(10)
                .HasColumnName("MACOSOKBCBCHUYENDEN");
            entity.Property(e => e.Macosokbcbchuyendi)
                .HasMaxLength(10)
                .HasColumnName("MACOSOKBCBCHUYENDI");
            entity.Property(e => e.Madantoc)
                .HasMaxLength(2)
                .HasColumnName("MADANTOC");
            entity.Property(e => e.Mahuyen)
                .HasMaxLength(3)
                .HasColumnName("MAHUYEN");
            entity.Property(e => e.Manguyennhanchinhtuvong)
                .HasMaxLength(10)
                .HasColumnName("MANGUYENNHANCHINHTUVONG");
            entity.Property(e => e.Maquoctich)
                .HasMaxLength(3)
                .HasColumnName("MAQUOCTICH");
            entity.Property(e => e.Mathanhpho)
                .HasMaxLength(2)
                .HasColumnName("MATHANHPHO");
            entity.Property(e => e.Maxaphuong)
                .HasMaxLength(5)
                .HasColumnName("MAXAPHUONG");
            entity.Property(e => e.Motabienphapkhac)
                .HasMaxLength(255)
                .HasColumnName("MOTABIENPHAPKHAC");
            entity.Property(e => e.Motachuandoanbenhvienkhac)
                .HasMaxLength(255)
                .HasColumnName("MOTACHUANDOANBENHVIENKHAC");
            entity.Property(e => e.Motanoikhoa)
                .HasMaxLength(255)
                .HasColumnName("MOTANOIKHOA");
            entity.Property(e => e.Motaphauthuatthuthuat)
                .HasMaxLength(255)
                .HasColumnName("MOTAPHAUTHUATTHUTHUAT");
            entity.Property(e => e.Motatuvansuckhoe)
                .HasMaxLength(255)
                .HasColumnName("MOTATUVANSUCKHOE");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Ngaythu)
                .HasMaxLength(255)
                .HasColumnName("NGAYTHU");
            entity.Property(e => e.Nghenghiep)
                .HasMaxLength(255)
                .HasColumnName("NGHENGHIEP");
            entity.Property(e => e.Nghiemphapvia)
                .HasMaxLength(255)
                .HasColumnName("NGHIEMPHAPVIA");
            entity.Property(e => e.Nghiemphapvials)
                .HasMaxLength(255)
                .HasColumnName("NGHIEMPHAPVIALS");
            entity.Property(e => e.Nguyennhanchinhtuvong)
                .HasMaxLength(255)
                .HasColumnName("NGUYENNHANCHINHTUVONG");
            entity.Property(e => e.Nhiemtrung)
                .HasMaxLength(255)
                .HasColumnName("NHIEMTRUNG");
            entity.Property(e => e.Nhietdo)
                .HasMaxLength(255)
                .HasColumnName("NHIETDO");
            entity.Property(e => e.Nhiptho)
                .HasMaxLength(255)
                .HasColumnName("NHIPTHO");
            entity.Property(e => e.Niemmac)
                .HasMaxLength(255)
                .HasColumnName("NIEMMAC");
            entity.Property(e => e.Noichuyenden)
                .HasMaxLength(255)
                .HasColumnName("NOICHUYENDEN");
            entity.Property(e => e.Noichuyendi)
                .HasMaxLength(255)
                .HasColumnName("NOICHUYENDI");
            entity.Property(e => e.Noikhoa)
                .HasMaxLength(255)
                .HasColumnName("NOIKHOA");
            entity.Property(e => e.Phauthuatthuthuat)
                .HasMaxLength(255)
                .HasColumnName("PHAUTHUATTHUTHUAT");
            entity.Property(e => e.Phoi)
                .HasMaxLength(255)
                .HasColumnName("PHOI");
            entity.Property(e => e.Phu)
                .HasMaxLength(255)
                .HasColumnName("PHU");
            entity.Property(e => e.Quoctich)
                .HasMaxLength(15)
                .HasColumnName("QUOCTICH");
            entity.Property(e => e.Sieuam)
                .HasMaxLength(255)
                .HasColumnName("SIEUAM");
            entity.Property(e => e.Sieuamls)
                .HasMaxLength(255)
                .HasColumnName("SIEUAMLS");
            entity.Property(e => e.Sinhthiet)
                .HasMaxLength(255)
                .HasColumnName("SINHTHIET");
            entity.Property(e => e.Sinhthietls)
                .HasMaxLength(255)
                .HasColumnName("SINHTHIETLS");
            entity.Property(e => e.Soconsong)
                .HasMaxLength(255)
                .HasColumnName("SOCONSONG");
            entity.Property(e => e.Soicotucung)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("SOICOTUCUNG");
            entity.Property(e => e.Soicotucungls)
                .HasMaxLength(255)
                .HasColumnName("SOICOTUCUNGLS");
            entity.Property(e => e.Solancothai)
                .HasMaxLength(255)
                .HasColumnName("SOLANCOTHAI");
            entity.Property(e => e.Solanphathai)
                .HasMaxLength(255)
                .HasColumnName("SOLANPHATHAI");
            entity.Property(e => e.Solansay)
                .HasMaxLength(255)
                .HasColumnName("SOLANSAY");
            entity.Property(e => e.Solansinh)
                .HasMaxLength(255)
                .HasColumnName("SOLANSINH");
            entity.Property(e => e.Songaychuyenkhoa).HasColumnName("SONGAYCHUYENKHOA");
            entity.Property(e => e.Songaycokinh)
                .HasMaxLength(255)
                .HasColumnName("SONGAYCOKINH");
            entity.Property(e => e.Songayvaokhoa).HasColumnName("SONGAYVAOKHOA");
            entity.Property(e => e.Sonha)
                .HasMaxLength(5)
                .HasColumnName("SONHA");
            entity.Property(e => e.Sot)
                .HasMaxLength(255)
                .HasColumnName("SOT");
            entity.Property(e => e.Sothebhyt)
                .HasMaxLength(30)
                .HasColumnName("SOTHEBHYT");
            entity.Property(e => e.Taibienkhac)
                .HasMaxLength(255)
                .HasColumnName("TAIBIENKHAC");
            entity.Property(e => e.Tencoquanchuquan)
                .HasMaxLength(255)
                .HasColumnName("TENCOQUANCHUQUAN");
            entity.Property(e => e.Tencosokbcb)
                .HasMaxLength(255)
                .HasColumnName("TENCOSOKBCB");
            entity.Property(e => e.Than)
                .HasMaxLength(255)
                .HasColumnName("THAN");
            entity.Property(e => e.Thanhpho)
                .HasMaxLength(30)
                .HasColumnName("THANHPHO");
            entity.Property(e => e.Thieumau)
                .HasMaxLength(255)
                .HasColumnName("THIEUMAU");
            entity.Property(e => e.Thoidiemtuvong)
                .HasMaxLength(255)
                .HasColumnName("THOIDIEMTUVONG");
            entity.Property(e => e.Thoiganbacsilambenhanky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGANBACSILAMBENHANKY");
            entity.Property(e => e.Thoigianbacsidieutriky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANBACSIDIEUTRIKY");
            entity.Property(e => e.Thoigianchuyenkhoa)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANCHUYENKHOA");
            entity.Property(e => e.Thoigiandaidienky)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANDAIDIENKY");
            entity.Property(e => e.Thoigianravien)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANRAVIEN");
            entity.Property(e => e.Thoigiantuvong)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANTUVONG");
            entity.Property(e => e.Thoigianvaokhoa)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANVAOKHOA");
            entity.Property(e => e.Thoigianvaovien)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANVAOVIEN");
            entity.Property(e => e.Thonpho)
                .HasMaxLength(30)
                .HasColumnName("THONPHO");
            entity.Property(e => e.Tienluong)
                .HasMaxLength(255)
                .HasColumnName("TIENLUONG");
            entity.Property(e => e.Tiensunoingoaikhoa)
                .HasMaxLength(255)
                .HasColumnName("TIENSUNOINGOAIKHOA");
            entity.Property(e => e.Tiepnhantu)
                .HasMaxLength(255)
                .HasColumnName("TIEPNHANTU");
            entity.Property(e => e.Tim)
                .HasMaxLength(255)
                .HasColumnName("TIM");
            entity.Property(e => e.Tinhtrangravien)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGRAVIEN");
            entity.Property(e => e.Tinhtrangravientk)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGRAVIENTK");
            entity.Property(e => e.Tinhtrangvao)
                .HasMaxLength(255)
                .HasColumnName("TINHTRANGVAO");
            entity.Property(e => e.Tomtatbenhan)
                .HasMaxLength(255)
                .HasColumnName("TOMTATBENHAN");
            entity.Property(e => e.Tongsongaydieutri).HasColumnName("TONGSONGAYDIEUTRI");
            entity.Property(e => e.Tuoi).HasColumnName("TUOI");
            entity.Property(e => e.Tuvansuckhoe)
                .HasMaxLength(255)
                .HasColumnName("TUVANSUCKHOE");
            entity.Property(e => e.Vaokhoa)
                .HasMaxLength(255)
                .HasColumnName("VAOKHOA");
            entity.Property(e => e.Xaphuong)
                .HasMaxLength(30)
                .HasColumnName("XAPHUONG");
            entity.Property(e => e.Xetnghiemdongmau)
                .HasMaxLength(255)
                .HasColumnName("XETNGHIEMDONGMAU");
            entity.Property(e => e.Xetnghiemhpv)
                .HasMaxLength(255)
                .HasColumnName("XETNGHIEMHPV");
            entity.Property(e => e.Xetnghiemhpvls)
                .HasMaxLength(255)
                .HasColumnName("XETNGHIEMHPVLS");
            entity.Property(e => e.Xetnghiemmaungoaivi)
                .HasMaxLength(255)
                .HasColumnName("XETNGHIEMMAUNGOAIVI");
            entity.Property(e => e.Xetnghiemsinhhoamau)
                .HasMaxLength(255)
                .HasColumnName("XETNGHIEMSINHHOAMAU");
            entity.Property(e => e.Xetnghiemtebaocotucung)
                .HasMaxLength(255)
                .HasColumnName("XETNGHIEMTEBAOCOTUCUNG");
            entity.Property(e => e.Xetnghiemtebaocotucungls)
                .HasMaxLength(255)
                .HasColumnName("XETNGHIEMTEBAOCOTUCUNGLS");
            entity.Property(e => e.Xuathuyet)
                .HasMaxLength(255)
                .HasColumnName("XUATHUYET");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
