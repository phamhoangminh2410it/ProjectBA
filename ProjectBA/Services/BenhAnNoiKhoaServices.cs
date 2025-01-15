using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBA.Models.Entities;
using System.Data;
using System.Net.NetworkInformation;
using System;

namespace ProjectBA.Services
{
    public interface IBenhAnNoiKhoaServices
    {
        Task<dynamic> ThongTin();
        Task<dynamic> ThemThongTin([FromBody] Benhannoikhoa benhannoikhoa);
        Task<dynamic> CapNhatThongTin([FromBody] Benhannoikhoa x);
        Task<dynamic> Xoa(string mabenhan);
    }

    public class BenhAnNoiKhoaServices : IBenhAnNoiKhoaServices
    {
        private HospitalContext _context;

        public BenhAnNoiKhoaServices(HospitalContext context)
        {
            _context = context;
        }

        public async Task<dynamic> Xoa(string mabenhan)
        {
            try
            {
                var data = await _context.Benhannoikhoas.FindAsync(mabenhan);
                _context.Benhannoikhoas.Remove(data);
                await _context.SaveChangesAsync();
                return new
                {
                    status = 200,
                    message = "Thanh cong"
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    message = ex.Message
                };
            }
        }

        public async Task<dynamic> ThemThongTin([FromBody] Benhannoikhoa benhannoikhoa)
        {
            try
            {
                var data = await _context.Benhannoikhoas.AddAsync(benhannoikhoa);
                await _context.SaveChangesAsync();
                return new
                {
                    data = data
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    message = ex.Message
                };
            }
        }

        public async Task<dynamic> CapNhatThongTin([FromBody] Benhannoikhoa x)
        {
            try
            {
                Benhannoikhoa ba = await _context.Benhannoikhoas.FindAsync(x.Mabenhan);
                ba.Macoquanchuquan = x.Macoquanchuquan;
                ba.Tencoquanchuquan = x.Tencoquanchuquan;
                ba.Macosokbcb = x.Macosokbcb;
                ba.Tencosokbcb = x.Tencosokbcb;
                ba.Hovaten = x.Hovaten;
                ba.Ngaysinh = x.Ngaysinh;
                ba.Tuoi = x.Tuoi;
                ba.Gioitinh = x.Gioitinh;
                ba.Dienthoai = x.Dienthoai;
                ba.Nghenghiep = x.Nghenghiep;
                ba.Dantoc = x.Dantoc;
                ba.Madantoc = x.Madantoc;
                ba.Quoctich = x.Quoctich;
                ba.Maquoctich = x.Maquoctich;
                ba.Sonha = x.Sonha;
                ba.Thonpho = x.Thonpho;
                ba.Xaphuong = x.Xaphuong;
                ba.Maxaphuong = x.Maxaphuong;
                ba.Huyen = x.Huyen;
                ba.Mahuyen = x.Mahuyen;
                ba.Thanhpho = x.Thanhpho;
                ba.Mathanhpho = x.Mathanhpho;
                ba.Doituong = x.Doituong;
                ba.Sothebhyt = x.Sothebhyt;
                ba.Cancuoc = x.Cancuoc;
                ba.Hotenthannhan = x.Hotenthannhan;
                ba.Dienthoaithannhan = x.Dienthoaithannhan;
                ba.Thoigianvaovien = x.Thoigianvaovien;
                ba.Tiepnhantu = x.Tiepnhantu;
                ba.Macosokbcbchuyenden = x.Macosokbcbchuyenden;
                ba.Noichuyenden = x.Noichuyenden;
                ba.Vaokhoa = x.Vaokhoa;
                ba.Thoigianvaokhoa = x.Thoigianvaokhoa;
                ba.Songayvaokhoa = x.Songayvaokhoa;
                ba.Chuyenkhoa = x.Chuyenkhoa;
                ba.Thoigianchuyenkhoa = x.Thoigianchuyenkhoa;
                ba.Songaychuyenkhoa = x.Songaychuyenkhoa;
                ba.Tongsongaydieutri = x.Tongsongaydieutri;
                ba.Macosokbcbchuyendi = x.Macosokbcbchuyendi;
                ba.Noichuyendi = x.Noichuyendi;
                ba.Thoigianravien = x.Thoigianravien;
                ba.Lydoravien = x.Lydoravien;
                ba.Machuandoanvaovien = x.Machuandoanvaovien;
                ba.Chuandoanvaovien = x.Chuandoanvaovien;
                ba.Mabenhchinh = x.Mabenhchinh;
                ba.Benhchinh = x.Benhchinh;
                ba.Mabenhkemtheo = x.Mabenhkemtheo;
                ba.Benhkemtheo = x.Benhkemtheo;
                ba.Mabienchung = x.Mabienchung;
                ba.Bienchung = x.Bienchung;
                ba.Ghichuravien = x.Ghichuravien;
                ba.Tinhtrangravien = x.Tinhtrangravien;
                ba.Thoigiantuvong = x.Thoigiantuvong;
                ba.Thoidiemtuvong = x.Thoidiemtuvong;
                ba.Manguyennhanchinhtuvong = x.Manguyennhanchinhtuvong;
                ba.Nguyennhanchinhtuvong = x.Nguyennhanchinhtuvong;
                ba.Thoigiandaidienky = x.Thoigiandaidienky;
                ba.Lanhdaokhoa = x.Lanhdaokhoa;
                ba.Daidiencosokbcb = x.Daidiencosokbcb;
                ba.Lydovaovien = x.Lydovaovien;
                ba.Tinhtrangvao = x.Tinhtrangvao;
                ba.Giothu = x.Giothu;
                ba.Ngaythu = x.Ngaythu;
                ba.Dienbienbenh = x.Dienbienbenh;
                ba.Chuandoanbenhvienkhac = x.Chuandoanbenhvienkhac;
                ba.Motachuandoanbenhvienkhac = x.Motachuandoanbenhvienkhac;
                ba.Diung = x.Diung;
                ba.Diungthuoc = x.Diungthuoc;
                ba.Diunghoachat = x.Diunghoachat;
                ba.Diungthucpham = x.Diungthucpham;
                ba.Diungkhac = x.Diungkhac;
                ba.Thuocdangdung = x.Thuocdangdung;
                ba.Tiensubenh = x.Tiensubenh;
                ba.Tiensubenhtimmach = x.Tiensubenhtimmach;
                ba.Tiensubenhhohap = x.Tiensubenhhohap;
                ba.Tiensubenhtieuhoa = x.Tiensubenhtieuhoa;
                ba.Tiensubenhnoitiet = x.Tiensubenhnoitiet;
                ba.Tiensubenhthankinh = x.Tiensubenhthankinh;
                ba.Tiensubenhthan = x.Tiensubenhthan;
                ba.Tiensubenhxuongkhop = x.Tiensubenhxuongkhop;
                ba.Tiensubenhungthu = x.Tiensubenhungthu;
                ba.Tiensubenhkhac = x.Tiensubenhkhac;
                ba.Tiensuphauthuat = x.Tiensuphauthuat;
                ba.Yeutonguyco = x.Yeutonguyco;
                ba.Yeutonguycothuocla = x.Yeutonguycothuocla;
                ba.Thoigiansudungthuocla = x.Thoigiansudungthuocla;
                ba.Lieuluongsudungthuocla = x.Lieuluongsudungthuocla;
                ba.Yeutonguycothuoclao = x.Yeutonguycothuoclao;
                ba.Thoigiansudungthuoclao = x.Thoigiansudungthuoclao;
                ba.Yeutonguycoruoubia = x.Yeutonguycoruoubia;
                ba.Lieuluongsudungruoubia = x.Lieuluongsudungruoubia;
                ba.Yeutonguycochatgaynghien = x.Yeutonguycochatgaynghien;
                ba.Loaichatgaynghien = x.Loaichatgaynghien;
                ba.Thoigiansudungchatgaynghien = x.Thoigiansudungchatgaynghien;
                ba.Yeutonguycotiepxuchoachat = x.Yeutonguycotiepxuchoachat;
                ba.Loaihoachat = x.Loaihoachat;
                ba.Thoigiantiepxuchoachat = x.Thoigiantiepxuchoachat;
                ba.Yeutonguycokhac = x.Yeutonguycokhac;
                ba.Tiensugiadinh = x.Tiensugiadinh;
                ba.Nguoimac = x.Nguoimac;
                ba.Tenbenh = x.Tenbenh;
                ba.Yeutodichte = x.Yeutodichte;
                ba.Dasongonoitruoctrongkhibenh = x.Dasongonoitruoctrongkhibenh;
                ba.Thoigiandasong = x.Thoigiandasong;
                ba.Benhcaptinhnoisinhsong = x.Benhcaptinhnoisinhsong;
                ba.Moisinh = x.Moisinh;
                ba.Toanthan = x.Toanthan;
                ba.Tiepxuctot = x.Tiepxuctot;
                ba.Nguga = x.Nguga;
                ba.Lomo = x.Lomo;
                ba.Honme = x.Honme;
                ba.Glasgow = x.Glasgow;
                ba.Daniemmac = x.Daniemmac;
                ba.Ketmacmat = x.Ketmacmat;
                ba.Luoi = x.Luoi;
                ba.Longtocmong = x.Longtocmong;
                ba.Tuyengiap = x.Tuyengiap;
                ba.Hachsoduoc = x.Hachsoduoc;
                ba.Vitrihach = x.Vitrihach;
                ba.Soluonghach = x.Soluonghach;
                ba.Duongkinhhach = x.Duongkinhhach;
                ba.Didong = x.Didong;
                ba.Dau = x.Dau;
                ba.Mach = x.Mach;
                ba.Nhietdo = x.Nhietdo;
                ba.Huyetap = x.Huyetap;
                ba.Nhiptho = x.Nhiptho;
                ba.Cannang = x.Cannang;
                ba.Chieucao = x.Chieucao;
                ba.Spo2 = x.Spo2;
                ba.Bmi = x.Bmi;
                ba.Xuathuyetduoida = x.Xuathuyetduoida;
                ba.Vitrixuathuyetduoida = x.Vitrixuathuyetduoida;
                ba.Xuathuyetniemmac = x.Xuathuyetniemmac;
                ba.Vitrixuathuyetniemmac = x.Vitrixuathuyetniemmac;
                ba.Phu = x.Phu;
                ba.Vitriphu = x.Vitriphu;
                ba.Tinhchat = x.Tinhchat;
                ba.Toanthanbenhkhac = x.Toanthanbenhkhac;
                ba.Tuanhoan = x.Tuanhoan;
                ba.Daunguc = x.Daunguc;
                ba.Tinhtrangdaunguc = x.Tinhtrangdaunguc;
                ba.Hoihopdanhtrongnguc = x.Hoihopdanhtrongnguc;
                ba.Nhipnhanh = x.Nhipnhanh;
                ba.Nhipcham = x.Nhipcham;
                ba.Loannhip = x.Loannhip;
                ba.Daplech = x.Daplech;
                ba.Diendaptim = x.Diendaptim;
                ba.Tiengtimmo = x.Tiengtimmo;
                ba.Vitritiengtimmo = x.Vitritiengtimmo;
                ba.Thoitamthu = x.Thoitamthu;
                ba.Vitrithoitamthu = x.Vitrithoitamthu;
                ba.Mucdothoitamthu = x.Mucdothoitamthu;
                ba.Dorungthoitamthu = x.Dorungthoitamthu;
                ba.Thoitamtruong = x.Thoitamtruong;
                ba.Vitrithoitamtruong = x.Vitrithoitamtruong;
                ba.Mucdothoitamtruong = x.Mucdothoitamtruong;
                ba.Dorungthoitamtruong = x.Dorungthoitamtruong;
                ba.Rungtamtruong = x.Rungtamtruong;
                ba.Vitrirungtamtruong = x.Vitrirungtamtruong;
                ba.Mucdorungtamtruong = x.Mucdorungtamtruong;
                ba.Thoilientuc = x.Thoilientuc;
                ba.Vitrithoilientuc = x.Vitrithoilientuc;
                ba.Tiengthoidongmach = x.Tiengthoidongmach;
                ba.Vitritiengthoidongmach = x.Vitritiengthoidongmach;
                ba.Tuanhoankhac = x.Tuanhoankhac;
                ba.Hohap = x.Hohap;
                ba.Khotho = x.Khotho;
                ba.Biendanglongnguc = x.Biendanglongnguc;
                ba.Goo = x.Goo;
                ba.Vitrigo = x.Vitrigo;
                ba.Riraophenang = x.Riraophenang;
                ba.Vitririraophenang = x.Vitririraophenang;
                ba.Rungthanh = x.Rungthanh;
                ba.Vitrirungthanh = x.Vitrirungthanh;
                ba.Rale = x.Rale;
                ba.Tinhtrangrale = x.Tinhtrangrale;
                ba.Hohapkhac = x.Hohapkhac;
                ba.Tieuhoa = x.Tieuhoa;
                ba.Daubung = x.Daubung;
                ba.Vitridaubung = x.Vitridaubung;
                ba.Buonnon = x.Buonnon;
                ba.Non = x.Non;
                ba.Tinhtrangmaunon = x.Tinhtrangmaunon;
                ba.Daitienphancomau = x.Daitienphancomau;
                ba.Tinhtrangdaitienphancomau = x.Tinhtrangdaitienphancomau;
                ba.Tieuchay = x.Tieuchay;
                ba.Solantieuchay = x.Solantieuchay;
                ba.Chuongbung = x.Chuongbung;
                ba.Phanungthanhbung = x.Phanungthanhbung;
                ba.Lach = x.Lach;
                ba.Vitrilach = x.Vitrilach;
                ba.Gan = x.Gan;
                ba.Vitrigan = x.Vitrigan;
                ba.Tieuhoakhac = x.Tieuhoakhac;
                ba.Than = x.Than;
                ba.Mausacnuoctieu = x.Mausacnuoctieu;
                ba.Mausac = x.Mausac;
                ba.Thetich = x.Thetich;
                ba.Tieubuot = x.Tieubuot;
                ba.Tieurat = x.Tieurat;
                ba.Caubangquang = x.Caubangquang;
                ba.Daudiemnieuquan = x.Daudiemnieuquan;
                ba.Vitridaudiemnieuquan = x.Vitridaudiemnieuquan;
                ba.Rungthan = x.Rungthan;
                ba.Thankhac = x.Thankhac;
                ba.Thankinh = x.Thankinh;
                ba.Cocung = x.Cocung;
                ba.Dauhieumangnao = x.Dauhieumangnao;
                ba.Coluc = x.Coluc;
                ba.Vitricoluc = x.Vitricoluc;
                ba.Truonglucco = x.Truonglucco;
                ba.Vitritruonglucco = x.Vitritruonglucco;
                ba.Phanxaganxuong = x.Phanxaganxuong;
                ba.Vitriphanxaganxuong = x.Vitriphanxaganxuong;
                ba.Lietmotphanhainguoiphai = x.Lietmotphanhainguoiphai;
                ba.Lietmotphanhainguoitrai = x.Lietmotphanhainguoitrai;
                ba.Liethaichiduoi = x.Liethaichiduoi;
                ba.Liettuchi = x.Liettuchi;
                ba.Thankinhkhac = x.Thankinhkhac;
                ba.Coxuongkhop = x.Coxuongkhop;
                ba.Dauco = x.Dauco;
                ba.Vitridauco = x.Vitridauco;
                ba.Daukhop = x.Daukhop;
                ba.Vitridaukhop = x.Vitridaukhop;
                ba.Sungdokhop = x.Sungdokhop;
                ba.Vitrisuongdokhop = x.Vitrisuongdokhop;
                ba.Daucotsong = x.Daucotsong;
                ba.Vitridaucotsong = x.Vitridaucotsong;
                ba.Hanchevandongkhop = x.Hanchevandongkhop;
                ba.Vitrihanchevandongkhop = x.Vitrihanchevandongkhop;
                ba.Hattphi = x.Hattphi;
                ba.Vitrihattophi = x.Vitrihattophi;
                ba.Daucungkhopbuoisang = x.Daucungkhopbuoisang;
                ba.Coxuongkhopkhac = x.Coxuongkhopkhac;
                ba.Taimuihong = x.Taimuihong;
                ba.Tai = x.Tai;
                ba.Motatai = x.Motatai;
                ba.Mui = x.Mui;
                ba.Motamui = x.Motamui;
                ba.Hong = x.Hong;
                ba.Motahong = x.Motahong;
                ba.Thanhquan = x.Thanhquan;
                ba.Motathanhquan = x.Motathanhquan;
                ba.Taimuihongkhac = x.Taimuihongkhac;
                ba.Ranghammat = x.Ranghammat;
                ba.Motaranghammat = x.Motaranghammat;
                ba.Ranghammatkhac = x.Ranghammatkhac;
                ba.Mat = x.Mat;
                ba.Motamat = x.Motamat;
                ba.Matkhac = x.Matkhac;
                ba.Noitiet = x.Noitiet;
                ba.Motanoitiet = x.Motanoitiet;
                ba.Anuong = x.Anuong;
                ba.Noitietdinhduongkhac = x.Noitietdinhduongkhac;
                ba.Benhlykhac = x.Benhlykhac;
                ba.Xetnghiemlamsang = x.Xetnghiemlamsang;
                ba.Motaxetnghiemlamsang = x.Motaxetnghiemlamsang;
                ba.Tomtatbenhan = x.Tomtatbenhan;
                ba.Chuandoanlucvaovienkdt = x.Chuandoanlucvaovienkdt;
                ba.Machuandoanlucvaovienkdt = x.Machuandoanlucvaovienkdt;
                ba.Chuandoanphanbiekdt = x.Chuandoanphanbiekdt;
                ba.Machuandoanphanbietkdt = x.Machuandoanphanbietkdt;
                ba.Benhchinhkdt = x.Benhchinhkdt;
                ba.Mabenhchinhkdt = x.Mabenhchinhkdt;
                ba.Benhkemtheokdt = x.Benhkemtheokdt;
                ba.Mabenhkemtheokdt = x.Mabenhkemtheokdt;
                ba.Bienchungkdt = x.Bienchungkdt;
                ba.Mabienchungkdt = x.Mabienchungkdt;
                ba.Tienluonggan = x.Tienluonggan;
                ba.Tienluongxa = x.Tienluongxa;
                ba.Huongdieutritt = x.Huongdieutritt;
                ba.Chedochamsoc = x.Chedochamsoc;
                ba.Chedodinhduong = x.Chedodinhduong;
                ba.Phuchoichucnang = x.Phuchoichucnang;
                ba.Motaphuchoichucnang = x.Motaphuchoichucnang;
                ba.Tuvansuckhoe = x.Tuvansuckhoe;
                ba.Motatuvansuckhoe = x.Motatuvansuckhoe;
                ba.Thoiganbacsilambenhanky = x.Thoiganbacsilambenhanky;
                ba.Bacsilambenhan = x.Bacsilambenhan;
                ba.Tomtatquatrinhbenhly = x.Tomtatquatrinhbenhly;
                ba.Dauhieulamsangchinh = x.Dauhieulamsangchinh;
                ba.Tomtatketquaxetnghiem = x.Tomtatketquaxetnghiem;
                ba.Noikhoa = x.Noikhoa;
                ba.Motanoikhoa = x.Motanoikhoa;
                ba.Phauthuatthuthuat = x.Phauthuatthuthuat;
                ba.Motaphauthuatthuthuat = x.Motaphauthuatthuthuat;
                ba.Tinhtrangravientk = x.Tinhtrangravientk;
                ba.Huongdieutri = x.Huongdieutri;
                ba.Thoigianbacsidieutriky = x.Thoigianbacsidieutriky;
                ba.Bacsidieutri = x.Bacsidieutri;

                _context.Benhannoikhoas.Update(ba);
                await _context.SaveChangesAsync();
                return new
                {
                    data = ba
                };
            }
            catch (Exception ex)
            {
                return new
                {
                    message = ex.Message
                };
            }
        }

        public async Task<dynamic> ThongTin()
        {
            var data = await _context.Benhannoikhoas
                .Select(x => new
                {
                    Mabenhan = x.Mabenhan,
                    Macoquanchuquan = x.Macoquanchuquan,
                    Tencoquanchuquan = x.Tencoquanchuquan,
                    Macosokbcb = x.Macosokbcb,
                    Tencosokbcb = x.Tencosokbcb,
                    Hovaten = x.Hovaten,
                    Ngaysinh = x.Ngaysinh,
                    Tuoi = x.Tuoi,
                    Gioitinh = x.Gioitinh,
                    Dienthoai = x.Dienthoai,
                    Nghenghiep = x.Nghenghiep,
                    Dantoc = x.Dantoc,
                    Madantoc = x.Madantoc,
                    Quoctich = x.Quoctich,
                    Maquoctich = x.Maquoctich,
                    Sonha = x.Sonha,
                    Thonpho = x.Thonpho,
                    Xaphuong = x.Xaphuong,
                    Maxaphuong = x.Maxaphuong,
                    Huyen = x.Huyen,
                    Mahuyen = x.Mahuyen,
                    Thanhpho = x.Thanhpho,
                    Mathanhpho = x.Mathanhpho,
                    Doituong = x.Doituong,
                    Sothebhyt = x.Sothebhyt,
                    Cancuoc = x.Cancuoc,
                    Hotenthannhan = x.Hotenthannhan,
                    Dienthoaithannhan = x.Dienthoaithannhan,
                    Thoigianvaovien = x.Thoigianvaovien,
                    Tiepnhantu = x.Tiepnhantu,
                    Macosokbcbchuyenden = x.Macosokbcbchuyenden,
                    Noichuyenden = x.Noichuyenden,
                    Vaokhoa = x.Vaokhoa,
                    Thoigianvaokhoa = x.Thoigianvaokhoa,
                    Songayvaokhoa = x.Songayvaokhoa,
                    Chuyenkhoa = x.Chuyenkhoa,
                    Thoigianchuyenkhoa = x.Thoigianchuyenkhoa,
                    Songaychuyenkhoa = x.Songaychuyenkhoa,
                    Tongsongaydieutri = x.Tongsongaydieutri,
                    Macosokbcbchuyendi = x.Macosokbcbchuyendi,
                    Noichuyendi = x.Noichuyendi,
                    Thoigianravien = x.Thoigianravien,
                    Lydoravien = x.Lydoravien,
                    Machuandoanvaovien = x.Machuandoanvaovien,
                    Chuandoanvaovien = x.Chuandoanvaovien,
                    Mabenhchinh = x.Mabenhchinh,
                    Benhchinh = x.Benhchinh,
                    Mabenhkemtheo = x.Mabenhkemtheo,
                    Benhkemtheo = x.Benhkemtheo,
                    Mabienchung = x.Mabienchung,
                    Bienchung = x.Bienchung,
                    Ghichuravien = x.Ghichuravien,
                    Tinhtrangravien = x.Tinhtrangravien,
                    Thoigiantuvong = x.Thoigiantuvong,
                    Thoidiemtuvong = x.Thoidiemtuvong,
                    Manguyennhanchinhtuvong = x.Manguyennhanchinhtuvong,
                    Nguyennhanchinhtuvong = x.Nguyennhanchinhtuvong,
                    Thoigiandaidienky = x.Thoigiandaidienky,
                    Lanhdaokhoa = x.Lanhdaokhoa,
                    Daidiencosokbcb = x.Daidiencosokbcb,
                    Lydovaovien = x.Lydovaovien,
                    Tinhtrangvao = x.Tinhtrangvao,
                    Giothu = x.Giothu,
                    Ngaythu = x.Ngaythu,
                    Dienbienbenh = x.Dienbienbenh,
                    Chuandoanbenhvienkhac = x.Chuandoanbenhvienkhac,
                    Motachuandoanbenhvienkhac = x.Motachuandoanbenhvienkhac,
                    Diung = x.Diung,
                    Diungthuoc = x.Diungthuoc,
                    Diunghoachat = x.Diunghoachat,
                    Diungthucpham = x.Diungthucpham,
                    Diungkhac = x.Diungkhac,
                    Thuocdangdung = x.Thuocdangdung,
                    Tiensubenh = x.Tiensubenh,
                    Tiensubenhtimmach = x.Tiensubenhtimmach,
                    Tiensubenhhohap = x.Tiensubenhhohap,
                    Tiensubenhtieuhoa = x.Tiensubenhtieuhoa,
                    Tiensubenhnoitiet = x.Tiensubenhnoitiet,
                    Tiensubenhthankinh = x.Tiensubenhthankinh,
                    Tiensubenhthan = x.Tiensubenhthan,
                    Tiensubenhxuongkhop = x.Tiensubenhxuongkhop,
                    Tiensubenhungthu = x.Tiensubenhungthu,
                    Tiensubenhkhac = x.Tiensubenhkhac,
                    Tiensuphauthuat = x.Tiensuphauthuat,
                    Yeutonguyco = x.Yeutonguyco,
                    Yeutonguycothuocla = x.Yeutonguycothuocla,
                    Thoigiansudungthuocla = x.Thoigiansudungthuocla,
                    Lieuluongsudungthuocla = x.Lieuluongsudungthuocla,
                    Yeutonguycothuoclao = x.Yeutonguycothuoclao,
                    Thoigiansudungthuoclao = x.Thoigiansudungthuoclao,
                    Yeutonguycoruoubia = x.Yeutonguycoruoubia,
                    Lieuluongsudungruoubia = x.Lieuluongsudungruoubia,
                    Yeutonguycochatgaynghien = x.Yeutonguycochatgaynghien,
                    Loaichatgaynghien = x.Loaichatgaynghien,
                    Thoigiansudungchatgaynghien = x.Thoigiansudungchatgaynghien,
                    Yeutonguycotiepxuchoachat = x.Yeutonguycotiepxuchoachat,
                    Loaihoachat = x.Loaihoachat,
                    Thoigiantiepxuchoachat = x.Thoigiantiepxuchoachat,
                    Yeutonguycokhac = x.Yeutonguycokhac,
                    Tiensugiadinh = x.Tiensugiadinh,
                    Nguoimac = x.Nguoimac,
                    Tenbenh = x.Tenbenh,
                    Yeutodichte = x.Yeutodichte,
                    Dasongonoitruoctrongkhibenh = x.Dasongonoitruoctrongkhibenh,
                    Thoigiandasong = x.Thoigiandasong,
                    Benhcaptinhnoisinhsong = x.Benhcaptinhnoisinhsong,
                    Moisinh = x.Moisinh,
                    Toanthan = x.Toanthan,
                    Tiepxuctot = x.Tiepxuctot,
                    Nguga = x.Nguga,
                    Lomo = x.Lomo,
                    Honme = x.Honme,
                    Glasgow = x.Glasgow,
                    Daniemmac = x.Daniemmac,
                    Ketmacmat = x.Ketmacmat,
                    Luoi = x.Luoi,
                    Longtocmong = x.Longtocmong,
                    Tuyengiap = x.Tuyengiap,
                    Hachsoduoc = x.Hachsoduoc,
                    Vitrihach = x.Vitrihach,
                    Soluonghach = x.Soluonghach,
                    Duongkinhhach = x.Duongkinhhach,
                    Didong = x.Didong,
                    Dau = x.Dau,
                    Mach = x.Mach,
                    Nhietdo = x.Nhietdo,
                    Huyetap = x.Huyetap,
                    Nhiptho = x.Nhiptho,
                    Cannang = x.Cannang,
                    Chieucao = x.Chieucao,
                    Spo2 = x.Spo2,
                    Bmi = x.Bmi,
                    Xuathuyetduoida = x.Xuathuyetduoida,
                    Vitrixuathuyetduoida = x.Vitrixuathuyetduoida,
                    Xuathuyetniemmac = x.Xuathuyetniemmac,
                    Vitrixuathuyetniemmac = x.Vitrixuathuyetniemmac,
                    Phu = x.Phu,
                    Vitriphu = x.Vitriphu,
                    Tinhchat = x.Tinhchat,
                    Toanthanbenhkhac = x.Toanthanbenhkhac,
                    Tuanhoan = x.Tuanhoan,
                    Daunguc = x.Daunguc,
                    Tinhtrangdaunguc = x.Tinhtrangdaunguc,
                    Hoihopdanhtrongnguc = x.Hoihopdanhtrongnguc,
                    Nhipnhanh = x.Nhipnhanh,
                    Nhipcham = x.Nhipcham,
                    Loannhip = x.Loannhip,
                    Daplech = x.Daplech,
                    Diendaptim = x.Diendaptim,
                    Tiengtimmo = x.Tiengtimmo,
                    Vitritiengtimmo = x.Vitritiengtimmo,
                    Thoitamthu = x.Thoitamthu,
                    Vitrithoitamthu = x.Vitrithoitamthu,
                    Mucdothoitamthu = x.Mucdothoitamthu,
                    Dorungthoitamthu = x.Dorungthoitamthu,
                    Thoitamtruong = x.Thoitamtruong,
                    Vitrithoitamtruong = x.Vitrithoitamtruong,
                    Mucdothoitamtruong = x.Mucdothoitamtruong,
                    Dorungthoitamtruong = x.Dorungthoitamtruong,
                    Rungtamtruong = x.Rungtamtruong,
                    Vitrirungtamtruong = x.Vitrirungtamtruong,
                    Mucdorungtamtruong = x.Mucdorungtamtruong,
                    Thoilientuc = x.Thoilientuc,
                    Vitrithoilientuc = x.Vitrithoilientuc,
                    Tiengthoidongmach = x.Tiengthoidongmach,
                    Vitritiengthoidongmach = x.Vitritiengthoidongmach,
                    Tuanhoankhac = x.Tuanhoankhac,
                    Hohap = x.Hohap,
                    Khotho = x.Khotho,
                    Biendanglongnguc = x.Biendanglongnguc,
                    Goo = x.Goo,
                    Vitrigo = x.Vitrigo,
                    Riraophenang = x.Riraophenang,
                    Vitririraophenang = x.Vitririraophenang,
                    Rungthanh = x.Rungthanh,
                    Vitrirungthanh = x.Vitrirungthanh,
                    Rale = x.Rale,
                    Tinhtrangrale = x.Tinhtrangrale,
                    Hohapkhac = x.Hohapkhac,
                    Tieuhoa = x.Tieuhoa,
                    Daubung = x.Daubung,
                    Vitridaubung = x.Vitridaubung,
                    Buonnon = x.Buonnon,
                    Non = x.Non,
                    Tinhtrangmaunon = x.Tinhtrangmaunon,
                    Daitienphancomau = x.Daitienphancomau,
                    Tinhtrangdaitienphancomau = x.Tinhtrangdaitienphancomau,
                    Tieuchay = x.Tieuchay,
                    Solantieuchay = x.Solantieuchay,
                    Chuongbung = x.Chuongbung,
                    Phanungthanhbung = x.Phanungthanhbung,
                    Lach = x.Lach,
                    Vitrilach = x.Vitrilach,
                    Gan = x.Gan,
                    Vitrigan = x.Vitrigan,
                    Tieuhoakhac = x.Tieuhoakhac,
                    Than = x.Than,
                    Mausacnuoctieu = x.Mausacnuoctieu,
                    Mausac = x.Mausac,
                    Thetich = x.Thetich,
                    Tieubuot = x.Tieubuot,
                    Tieurat = x.Tieurat,
                    Caubangquang = x.Caubangquang,
                    Daudiemnieuquan = x.Daudiemnieuquan,
                    Vitridaudiemnieuquan = x.Vitridaudiemnieuquan,
                    Rungthan = x.Rungthan,
                    Thankhac = x.Thankhac,
                    Thankinh = x.Thankinh,
                    Cocung = x.Cocung,
                    Dauhieumangnao = x.Dauhieumangnao,
                    Coluc = x.Coluc,
                    Vitricoluc = x.Vitricoluc,
                    Truonglucco = x.Truonglucco,
                    Vitritruonglucco = x.Vitritruonglucco,
                    Phanxaganxuong = x.Phanxaganxuong,
                    Vitriphanxaganxuong = x.Vitriphanxaganxuong,
                    Lietmotphanhainguoiphai = x.Lietmotphanhainguoiphai,
                    Lietmotphanhainguoitrai = x.Lietmotphanhainguoitrai,
                    Liethaichiduoi = x.Liethaichiduoi,
                    Liettuchi = x.Liettuchi,
                    Thankinhkhac = x.Thankinhkhac,
                    Coxuongkhop = x.Coxuongkhop,
                    Dauco = x.Dauco,
                    Vitridauco = x.Vitridauco,
                    Daukhop = x.Daukhop,
                    Vitridaukhop = x.Vitridaukhop,
                    Sungdokhop = x.Sungdokhop,
                    Vitrisuongdokhop = x.Vitrisuongdokhop,
                    Daucotsong = x.Daucotsong,
                    Vitridaucotsong = x.Vitridaucotsong,
                    Hanchevandongkhop = x.Hanchevandongkhop,
                    Vitrihanchevandongkhop = x.Vitrihanchevandongkhop,
                    Hattphi = x.Hattphi,
                    Vitrihattophi = x.Vitrihattophi,
                    Daucungkhopbuoisang = x.Daucungkhopbuoisang,
                    Coxuongkhopkhac = x.Coxuongkhopkhac,
                    Taimuihong = x.Taimuihong,
                    Tai = x.Tai,
                    Motatai = x.Motatai,
                    Mui = x.Mui,
                    Motamui = x.Motamui,
                    Hong = x.Hong,
                    Motahong = x.Motahong,
                    Thanhquan = x.Thanhquan,
                    Motathanhquan = x.Motathanhquan,
                    Taimuihongkhac = x.Taimuihongkhac,
                    Ranghammat = x.Ranghammat,
                    Motaranghammat = x.Motaranghammat,
                    Ranghammatkhac = x.Ranghammatkhac,
                    Mat = x.Mat,
                    Motamat = x.Motamat,
                    Matkhac = x.Matkhac,
                    Noitiet = x.Noitiet,
                    Motanoitiet = x.Motanoitiet,
                    Anuong = x.Anuong,
                    Noitietdinhduongkhac = x.Noitietdinhduongkhac,
                    Benhlykhac = x.Benhlykhac,
                    Xetnghiemlamsang = x.Xetnghiemlamsang,
                    Motaxetnghiemlamsang = x.Motaxetnghiemlamsang,
                    Tomtatbenhan = x.Tomtatbenhan,
                    Chuandoanlucvaovienkdt = x.Chuandoanlucvaovienkdt,
                    Machuandoanlucvaovienkdt = x.Machuandoanlucvaovienkdt,
                    Chuandoanphanbiekdt = x.Chuandoanphanbiekdt,
                    Machuandoanphanbietkdt = x.Machuandoanphanbietkdt,
                    Benhchinhkdt = x.Benhchinhkdt,
                    Mabenhchinhkdt = x.Mabenhchinhkdt,
                    Benhkemtheokdt = x.Benhkemtheokdt,
                    Mabenhkemtheokdt = x.Mabenhkemtheokdt,
                    Bienchungkdt = x.Bienchungkdt,
                    Mabienchungkdt = x.Mabienchungkdt,
                    Tienluonggan = x.Tienluonggan,
                    Tienluongxa = x.Tienluongxa,
                    Huongdieutritt = x.Huongdieutritt,
                    Chedochamsoc = x.Chedochamsoc,
                    Chedodinhduong = x.Chedodinhduong,
                    Phuchoichucnang = x.Phuchoichucnang,
                    Motaphuchoichucnang = x.Motaphuchoichucnang,
                    Tuvansuckhoe = x.Tuvansuckhoe,
                    Motatuvansuckhoe = x.Motatuvansuckhoe,
                    Thoiganbacsilambenhanky = x.Thoiganbacsilambenhanky,
                    Bacsilambenhan = x.Bacsilambenhan,
                    Tomtatquatrinhbenhly = x.Tomtatquatrinhbenhly,
                    Dauhieulamsangchinh = x.Dauhieulamsangchinh,
                    Tomtatketquaxetnghiem = x.Tomtatketquaxetnghiem,
                    Noikhoa = x.Noikhoa,
                    Motanoikhoa = x.Motanoikhoa,
                    Phauthuatthuthuat = x.Phauthuatthuthuat,
                    Motaphauthuatthuthuat = x.Motaphauthuatthuthuat,
                    Tinhtrangravientk = x.Tinhtrangravientk,
                    Huongdieutri = x.Huongdieutri,
                    Thoigianbacsidieutriky = x.Thoigianbacsidieutriky,
                    Bacsidieutri = x.Bacsidieutri
                }).FirstOrDefaultAsync();
            return data;
        }
    }
}
