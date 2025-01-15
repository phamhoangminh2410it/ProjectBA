using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBA.Models.Entities;
using System.Data;
using System.Net.NetworkInformation;
using System;

namespace ProjectBA.Services
{
    public interface IBenhAnNgoaiKhoaServices
    {
        Task<dynamic> ThongTin();
        Task<dynamic> ThemThongTin([FromBody] Benhanngoaikhoa benhanngoaikhoa);
        Task<dynamic> CapNhatThongTin([FromBody] Benhanngoaikhoa x);
        Task<dynamic> Xoa(string mabenhan);
    }

    public class BenhAnNgoaiKhoaServices : IBenhAnNgoaiKhoaServices
    {
        private HospitalContext _context;

        public BenhAnNgoaiKhoaServices(HospitalContext context)
        {
            _context = context;
        }

        public async Task<dynamic> Xoa(string mabenhan)
        {
            try
            {
                var data = await _context.Benhanngoaikhoas.FindAsync(mabenhan);
                _context.Benhanngoaikhoas.Remove(data);
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

        public async Task <dynamic> ThemThongTin([FromBody] Benhanngoaikhoa benhanngoaikhoa)
        {
            try
            {
                var data = await _context.Benhanngoaikhoas.AddAsync(benhanngoaikhoa);
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

        /*public async Task <dynamic> XoaThongTin()*/

        public async Task<dynamic> CapNhatThongTin([FromBody] Benhanngoaikhoa x)
        {
            try
            {
                Benhanngoaikhoa ba = await _context.Benhanngoaikhoas.FindAsync(x.Mabenhan);
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
                ba.Motatsphauthuat1 = x.Motatsphauthuat1;
                ba.Motatsphauthuat2 = x.Motatsphauthuat2;
                ba.Motatsphauthuat3 = x.Motatsphauthuat3;
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
                ba.Benhtimmach = x.Benhtimmach;
                ba.Nguoimacbenhtimmach = x.Nguoimacbenhtimmach;
                ba.Tanghuyetap = x.Tanghuyetap;
                ba.Nguoimacbenhtanghuyetap = x.Nguoimacbenhtanghuyetap;
                ba.Tamthan = x.Tamthan;
                ba.Nguoimacbenhtamthan = x.Nguoimacbenhtamthan;
                ba.Benhgout = x.Benhgout;
                ba.Nguoimacbenhgout = x.Nguoimacbenhgout;
                ba.Benhhethong = x.Benhhethong;
                ba.Nguoimacbenhhethong = x.Nguoimacbenhhethong;
                ba.Ungthu = x.Ungthu;
                ba.Nguoimacbenhungthu = x.Nguoimacbenhungthu;
                ba.Lao = x.Lao;
                ba.Nguoimacbenhlao = x.Nguoimacbenhlao;
                ba.Hensuyen = x.Hensuyen;
                ba.Nguoimacbenhhensuyen = x.Nguoimacbenhhensuyen;
                ba.Daithaoduong = x.Daithaoduong;
                ba.Nguoimacbenhdaithaoduong = x.Nguoimacbenhdaithaoduong;
                ba.Benhdongkinh = x.Benhdongkinh;
                ba.Nguoimacbenhdongkinh = x.Nguoimacbenhdongkinh;
                ba.Benhlqdenchuyenhoa = x.Benhlqdenchuyenhoa;
                ba.Nguoimacbenhlqdenchuyenhoa = x.Nguoimacbenhlqdenchuyenhoa;
                ba.Benhkhac = x.Benhkhac;
                ba.Nguoimacbenhkhac = x.Nguoimacbenhkhac;
                ba.Toanthan = x.Toanthan;
                ba.Mach = x.Mach;
                ba.Nhietdo = x.Nhietdo;
                ba.Huyetap = x.Huyetap;
                ba.Nhiptho = x.Nhiptho;
                ba.Cannang = x.Cannang;
                ba.Chieucao = x.Chieucao;
                ba.Spo2 = x.Spo2;
                ba.Bmi = x.Bmi;
                ba.Tiepxuctot = x.Tiepxuctot;
                ba.Tiepxuccham = x.Tiepxuccham;
                ba.Nguga = x.Nguga;
                ba.Lomo = x.Lomo;
                ba.Honme = x.Honme;
                ba.Da = x.Da;
                ba.Niemmac = x.Niemmac;
                ba.Moikho = x.Moikho;
                ba.Tuyengiap = x.Tuyengiap;
                ba.Hachngoaivi = x.Hachngoaivi;
                ba.Phu = x.Phu;
                ba.Vitriphu = x.Vitriphu;
                ba.Xuathuyetduoida = x.Xuathuyetduoida;
                ba.Toanthankhac = x.Toanthankhac;
                ba.Tuanhoanvahohap = x.Tuanhoanvahohap;
                ba.Candoi = x.Candoi;
                ba.Corut = x.Corut;
                ba.Bamtim = x.Bamtim;
                ba.Hohapdaochieu = x.Hohapdaochieu;
                ba.Mangsuondidong = x.Mangsuondidong;
                ba.Thogangsuc = x.Thogangsuc;
                ba.Vetthuongthanhnguc = x.Vetthuongthanhnguc;
                ba.Motavtthanhnguc = x.Motavtthanhnguc;
                ba.Trankhiduoida = x.Trankhiduoida;
                ba.Rungmiu = x.Rungmiu;
                ba.Tiengtim = x.Tiengtim;
                ba.Tiengtimdeu = x.Tiengtimdeu;
                ba.Tiengtimbatthuong = x.Tiengtimbatthuong;
                ba.Riraophenang = x.Riraophenang;
                ba.Motariraophenang = x.Motariraophenang;
                ba.Rale = x.Rale;
                ba.Motarale = x.Motarale;
                ba.Tuanhoanvahohapkhac = x.Tuanhoanvahohapkhac;
                ba.Tieuhoa = x.Tieuhoa;
                ba.Bungchuong = x.Bungchuong;
                ba.Seomocu = x.Seomocu;
                ba.Vtktseomocu = x.Vtktseomocu;
                ba.Tuanhoanbanghe = x.Tuanhoanbanghe;
                ba.Quairuotnoi = x.Quairuotnoi;
                ba.Dauhieuranbo = x.Dauhieuranbo;
                ba.Vetbamtim = x.Vetbamtim;
                ba.Vetthuongthanhbung = x.Vetthuongthanhbung;
                ba.Vtktivetthuongthanhbung = x.Vtktivetthuongthanhbung;
                ba.Bungmem = x.Bungmem;
                ba.Camungphucmac = x.Camungphucmac;
                ba.Vtcamungphucmac = x.Vtcamungphucmac;
                ba.Phan = x.Phan;
                ba.Tinhchatphan = x.Tinhchatphan;
                ba.Sothayu = x.Sothayu;
                ba.Vtsothayu = x.Vtsothayu;
                ba.Tuicungdouglas = x.Tuicungdouglas;
                ba.Cothathaumon = x.Cothathaumon;
                ba.Phanungthanhbung = x.Phanungthanhbung;
                ba.Cocungthanhbung = x.Cocungthanhbung;
                ba.Diemdau = x.Diemdau;
                ba.Ganto = x.Ganto;
                ba.Tuimatto = x.Tuimatto;
                ba.Dauhieumurphy = x.Dauhieumurphy;
                ba.Lachto = x.Lachto;
                ba.Khoiu = x.Khoiu;
                ba.Vtktkhoiu = x.Vtktkhoiu;
                ba.Thoaivi = x.Thoaivi;
                ba.Vtthoaivi = x.Vtthoaivi;
                ba.Tieuhoakhac = x.Tieuhoakhac;
                ba.Than = x.Than;
                ba.Thanto = x.Thanto;
                ba.Diemdaunieuquan = x.Diemdaunieuquan;
                ba.Caubangquang = x.Caubangquang;
                ba.Tinhhoan = x.Tinhhoan;
                ba.Tinhchattinhhoan = x.Tinhchattinhhoan;
                ba.Tuyentienliet = x.Tuyentienliet;
                ba.Chamthan = x.Chamthan;
                ba.Bapbenhthan = x.Bapbenhthan;
                ba.Thankinh = x.Thankinh;
                ba.Vetthuongvungdau = x.Vetthuongvungdau;
                ba.Vtktvetthuongvungdau = x.Vtktvetthuongvungdau;
                ba.Sungnebamtim = x.Sungnebamtim;
                ba.Vtktsungnebamtim = x.Vtktsungnebamtim;
                ba.Biendanghammat = x.Biendanghammat;
                ba.Vtktbiendanghammat = x.Vtktbiendanghammat;
                ba.Dauhieuthankinhkhutru = x.Dauhieuthankinhkhutru;
                ba.Motadauhieuthankinhkhutru = x.Motadauhieuthankinhkhutru;
                ba.Dauhieuthankinhthucvat = x.Dauhieuthankinhthucvat;
                ba.Motadauhieuthankinhthucvat = x.Motadauhieuthankinhthucvat;
                ba.Dauhieuthankinhngoaibien = x.Dauhieuthankinhngoaibien;
                ba.Motadauhieuthankinhngoaibien = x.Motadauhieuthankinhngoaibien;
                ba.Dauhieulietthankinhso = x.Dauhieulietthankinhso;
                ba.Motadauhieulietthankinhso = x.Motadauhieulietthankinhso;
                ba.Dauhieulietvandong = x.Dauhieulietvandong;
                ba.Motadauhieulietvandong = x.Motadauhieulietvandong;
                ba.Dauhieumangnao = x.Dauhieumangnao;
                ba.Motadauhieumangnao = x.Motadauhieumangnao;
                ba.Roiloancamgiac = x.Roiloancamgiac;
                ba.Motaroiloancamgiac = x.Motaroiloancamgiac;
                ba.Roiloangiacquan = x.Roiloangiacquan;
                ba.Motaroiloangiacquan = x.Motaroiloangiacquan;
                ba.Roiloanthangbang = x.Roiloanthangbang;
                ba.Motaroiloanthangbang = x.Motaroiloanthangbang;
                ba.Roiloantrinho = x.Roiloantrinho;
                ba.Motaroiloantrinho = x.Motaroiloantrinho;
                ba.Roiloantamthan = x.Roiloantamthan;
                ba.Motaroiloanthamthan = x.Motaroiloanthamthan;
                ba.Dongkinh = x.Dongkinh;
                ba.Motadongkinh = x.Motadongkinh;
                ba.Dotquy = x.Dotquy;
                ba.Motadotquy = x.Motadotquy;
                ba.Thankinhkhac = x.Thankinhkhac;
                ba.Cotsong = x.Cotsong;
                ba.Biendangcotsong = x.Biendangcotsong;
                ba.Sungnebamtimcs = x.Sungnebamtimcs;
                ba.Diemdaucs = x.Diemdaucs;
                ba.Roiloancamgiacthankinhtuysong = x.Roiloancamgiacthankinhtuysong;
                ba.Phanxabatthuong = x.Phanxabatthuong;
                ba.Cacnghiemphapkham = x.Cacnghiemphapkham;
                ba.Cotsongkhac = x.Cotsongkhac;
                ba.Coxuongkhop = x.Coxuongkhop;
                ba.Biendangxuong = x.Biendangxuong;
                ba.Motabiendangxuong = x.Motabiendangxuong;
                ba.Vetthuong = x.Vetthuong;
                ba.Sungnebamtimvtt = x.Sungnebamtimvtt;
                ba.Motasungnebamtimvtt = x.Motasungnebamtimvtt;
                ba.Matlientuc = x.Matlientuc;
                ba.Machngoaivi = x.Machngoaivi;
                ba.Vandongbinhthuong = x.Vandongbinhthuong;
                ba.Camgiacnongsau = x.Camgiacnongsau;
                ba.Motacamgiacnongsau = x.Motacamgiacnongsau;
                ba.Chieudai = x.Chieudai;
                ba.Motachieudai = x.Motachieudai;
                ba.Biendokhop = x.Biendokhop;
                ba.Motabiendokhop = x.Motabiendokhop;
                ba.Cokhopxuongkhac = x.Cokhopxuongkhac;
                ba.Ranghammat = x.Ranghammat;
                ba.Hammat = x.Hammat;
                ba.Hmsungnebamtim = x.Hmsungnebamtim;
                ba.Hmbiendang = x.Hmbiendang;
                ba.Hmdiemdauchoi = x.Hmdiemdauchoi;
                ba.Hmmatlientuc = x.Hmmatlientuc;
                ba.Hmvandong = x.Hmvandong;
                ba.Hmhamieng = x.Hmhamieng;
                ba.Hmkhopcan = x.Hmkhopcan;
                ba.Rang = x.Rang;
                ba.Mat = x.Mat;
                ba.Tonthuong = x.Tonthuong;
                ba.Motatonthuong = x.Motatonthuong;
                ba.Supmi = x.Supmi;
                ba.Motasupmi = x.Motasupmi;
                ba.Tonthuongledao = x.Tonthuongledao;
                ba.Motatonthuongledao = x.Motatonthuongledao;
                ba.Taimuihong = x.Taimuihong;
                ba.Muivetthuong = x.Muivetthuong;
                ba.Motamuivetthuong = x.Motamuivetthuong;
                ba.Taivetthuong = x.Taivetthuong;
                ba.Motataivetthuong = x.Motataivetthuong;
                ba.Taichaymau = x.Taichaymau;
                ba.Motataichaymau = x.Motataichaymau;
                ba.Taimuihongkhac = x.Taimuihongkhac;
                ba.Benhlykhac = x.Benhlykhac;
                ba.Cacxetnghiem = x.Cacxetnghiem;
                ba.Motacacxetnghiem = x.Motacacxetnghiem;
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
                _context.Benhanngoaikhoas.Update(ba);
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

        public async Task <dynamic> ThongTin()
        {
            var data = await _context.Benhanngoaikhoas
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
                    Motatsphauthuat1 = x.Motatsphauthuat1,
                    Motatsphauthuat2 = x.Motatsphauthuat2,
                    Motatsphauthuat3 = x.Motatsphauthuat3,
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
                    Benhtimmach = x.Benhtimmach,
                    Nguoimacbenhtimmach = x.Nguoimacbenhtimmach,
                    Tanghuyetap = x.Tanghuyetap,
                    Nguoimacbenhtanghuyetap = x.Nguoimacbenhtanghuyetap,
                    Tamthan = x.Tamthan,
                    Nguoimacbenhtamthan = x.Nguoimacbenhtamthan,
                    Benhgout = x.Benhgout,
                    Nguoimacbenhgout = x.Nguoimacbenhgout,
                    Benhhethong = x.Benhhethong,
                    Nguoimacbenhhethong = x.Nguoimacbenhhethong,
                    Ungthu = x.Ungthu,
                    Nguoimacbenhungthu = x.Nguoimacbenhungthu,
                    Lao = x.Lao,
                    Nguoimacbenhlao = x.Nguoimacbenhlao,
                    Hensuyen = x.Hensuyen,
                    Nguoimacbenhhensuyen = x.Nguoimacbenhhensuyen,
                    Daithaoduong = x.Daithaoduong,
                    Nguoimacbenhdaithaoduong = x.Nguoimacbenhdaithaoduong,
                    Benhdongkinh = x.Benhdongkinh,
                    Nguoimacbenhdongkinh = x.Nguoimacbenhdongkinh,
                    Benhlqdenchuyenhoa = x.Benhlqdenchuyenhoa,
                    Nguoimacbenhlqdenchuyenhoa = x.Nguoimacbenhlqdenchuyenhoa,
                    Benhkhac = x.Benhkhac,
                    Nguoimacbenhkhac = x.Nguoimacbenhkhac,
                    Toanthan = x.Toanthan,
                    Mach = x.Mach,
                    Nhietdo = x.Nhietdo,
                    Huyetap = x.Huyetap,
                    Nhiptho = x.Nhiptho,
                    Cannang = x.Cannang,
                    Chieucao = x.Chieucao,
                    Spo2 = x.Spo2,
                    Bmi = x.Bmi,
                    Tiepxuctot = x.Tiepxuctot,
                    Tiepxuccham = x.Tiepxuccham,
                    Nguga = x.Nguga,
                    Lomo = x.Lomo,
                    Honme = x.Honme,
                    Da = x.Da,
                    Niemmac = x.Niemmac,
                    Moikho = x.Moikho,
                    Tuyengiap = x.Tuyengiap,
                    Hachngoaivi = x.Hachngoaivi,
                    Phu = x.Phu,
                    Vitriphu = x.Vitriphu,
                    Xuathuyetduoida = x.Xuathuyetduoida,
                    Toanthankhac = x.Toanthankhac,
                    Tuanhoanvahohap = x.Tuanhoanvahohap,
                    Candoi = x.Candoi,
                    Corut = x.Corut,
                    Bamtim = x.Bamtim,
                    Hohapdaochieu = x.Hohapdaochieu,
                    Mangsuondidong = x.Mangsuondidong,
                    Thogangsuc = x.Thogangsuc,
                    Vetthuongthanhnguc = x.Vetthuongthanhnguc,
                    Motavtthanhnguc = x.Motavtthanhnguc,
                    Trankhiduoida = x.Trankhiduoida,
                    Rungmiu = x.Rungmiu,
                    Tiengtim = x.Tiengtim,
                    Tiengtimdeu = x.Tiengtimdeu,
                    Tiengtimbatthuong = x.Tiengtimbatthuong,
                    Riraophenang = x.Riraophenang,
                    Motariraophenang = x.Motariraophenang,
                    Rale = x.Rale,
                    Motarale = x.Motarale,
                    Tuanhoanvahohapkhac = x.Tuanhoanvahohapkhac,
                    Tieuhoa = x.Tieuhoa,
                    Bungchuong = x.Bungchuong,
                    Seomocu = x.Seomocu,
                    Vtktseomocu = x.Vtktseomocu,
                    Tuanhoanbanghe = x.Tuanhoanbanghe,
                    Quairuotnoi = x.Quairuotnoi,
                    Dauhieuranbo = x.Dauhieuranbo,
                    Vetbamtim = x.Vetbamtim,
                    Vetthuongthanhbung = x.Vetthuongthanhbung,
                    Vtktivetthuongthanhbung = x.Vtktivetthuongthanhbung,
                    Bungmem = x.Bungmem,
                    Camungphucmac = x.Camungphucmac,
                    Vtcamungphucmac = x.Vtcamungphucmac,
                    Phan = x.Phan,
                    Tinhchatphan = x.Tinhchatphan,
                    Sothayu = x.Sothayu,
                    Vtsothayu = x.Vtsothayu,
                    Tuicungdouglas = x.Tuicungdouglas,
                    Cothathaumon = x.Cothathaumon,
                    Phanungthanhbung = x.Phanungthanhbung,
                    Cocungthanhbung = x.Cocungthanhbung,
                    Diemdau = x.Diemdau,
                    Ganto = x.Ganto,
                    Tuimatto = x.Tuimatto,
                    Dauhieumurphy = x.Dauhieumurphy,
                    Lachto = x.Lachto,
                    Khoiu = x.Khoiu,
                    Vtktkhoiu = x.Vtktkhoiu,
                    Thoaivi = x.Thoaivi,
                    Vtthoaivi = x.Vtthoaivi,
                    Tieuhoakhac = x.Tieuhoakhac,
                    Than = x.Than,
                    Thanto = x.Thanto,
                    Diemdaunieuquan = x.Diemdaunieuquan,
                    Caubangquang = x.Caubangquang,
                    Tinhhoan = x.Tinhhoan,
                    Tinhchattinhhoan = x.Tinhchattinhhoan,
                    Tuyentienliet = x.Tuyentienliet,
                    Chamthan = x.Chamthan,
                    Bapbenhthan = x.Bapbenhthan,
                    Thankinh = x.Thankinh,
                    Vetthuongvungdau = x.Vetthuongvungdau,
                    Vtktvetthuongvungdau = x.Vtktvetthuongvungdau,
                    Sungnebamtim = x.Sungnebamtim,
                    Vtktsungnebamtim = x.Vtktsungnebamtim,
                    Biendanghammat = x.Biendanghammat,
                    Vtktbiendanghammat = x.Vtktbiendanghammat,
                    Dauhieuthankinhkhutru = x.Dauhieuthankinhkhutru,
                    Motadauhieuthankinhkhutru = x.Motadauhieuthankinhkhutru,
                    Dauhieuthankinhthucvat = x.Dauhieuthankinhthucvat,
                    Motadauhieuthankinhthucvat = x.Motadauhieuthankinhthucvat,
                    Dauhieuthankinhngoaibien = x.Dauhieuthankinhngoaibien,
                    Motadauhieuthankinhngoaibien = x.Motadauhieuthankinhngoaibien,
                    Dauhieulietthankinhso = x.Dauhieulietthankinhso,
                    Motadauhieulietthankinhso = x.Motadauhieulietthankinhso,
                    Dauhieulietvandong = x.Dauhieulietvandong,
                    Motadauhieulietvandong = x.Motadauhieulietvandong,
                    Dauhieumangnao = x.Dauhieumangnao,
                    Motadauhieumangnao = x.Motadauhieumangnao,
                    Roiloancamgiac = x.Roiloancamgiac,
                    Motaroiloancamgiac = x.Motaroiloancamgiac,
                    Roiloangiacquan = x.Roiloangiacquan,
                    Motaroiloangiacquan = x.Motaroiloangiacquan,
                    Roiloanthangbang = x.Roiloanthangbang,
                    Motaroiloanthangbang = x.Motaroiloanthangbang,
                    Roiloantrinho = x.Roiloantrinho,
                    Motaroiloantrinho = x.Motaroiloantrinho,
                    Roiloanthamthan = x.Roiloantamthan,
                    Motaroiloanthamthan = x.Motaroiloanthamthan,
                    Dongkinh = x.Dongkinh,
                    Motadongkinh = x.Motadongkinh,
                    Dotquy = x.Dotquy,
                    Motadotquy = x.Motadotquy,
                    Thankinhkhac = x.Thankinhkhac,
                    Cotsong = x.Cotsong,
                    Biendangcotsong = x.Biendangcotsong,
                    Sungnebamtimcs = x.Sungnebamtimcs,
                    Diemdaucs = x.Diemdaucs,
                    Roiloancamgiacthankinhtuysong = x.Roiloancamgiacthankinhtuysong,
                    Phanxabatthuong = x.Phanxabatthuong,
                    Cacnghiemphapkham = x.Cacnghiemphapkham,
                    Cotsongkhac = x.Cotsongkhac,
                    Coxuongkhop = x.Coxuongkhop,
                    Biendangxuong = x.Biendangxuong,
                    Motabiendangxuong = x.Motabiendangxuong,
                    Vetthuong = x.Vetthuong,
                    Sungnebamtimvtt = x.Sungnebamtimvtt,
                    Motasungnebamtimvtt = x.Motasungnebamtimvtt,
                    Matlientuc = x.Matlientuc,
                    Machngoaivi = x.Machngoaivi,
                    Vandongbinhthuong = x.Vandongbinhthuong,
                    Camgiacnongsau = x.Camgiacnongsau,
                    Motacamgiacnongsau = x.Motacamgiacnongsau,
                    Chieudai = x.Chieudai,
                    Motachieudai = x.Motachieudai,
                    Biendokhop = x.Biendokhop,
                    Motabiendokhop = x.Motabiendokhop,
                    Cokhopxuongkhac = x.Cokhopxuongkhac,
                    Ranghammat = x.Ranghammat,
                    Hammat = x.Hammat,
                    Hmsungnebamtim = x.Hmsungnebamtim,
                    Hmbiendang = x.Hmbiendang,
                    Hmdiemdauchoi = x.Hmdiemdauchoi,
                    Hmmatlientuc = x.Hmmatlientuc,
                    Hmvandong = x.Hmvandong,
                    Hmhamieng = x.Hmhamieng,
                    Hmkhopcan = x.Hmkhopcan,
                    Rang = x.Rang,
                    Mat = x.Mat,
                    Tonthuong = x.Tonthuong,
                    Motatonthuong = x.Motatonthuong,
                    Supmi = x.Supmi,
                    Motasupmi = x.Motasupmi,
                    Tonthuongledao = x.Tonthuongledao,
                    Motatonthuongledao = x.Motatonthuongledao,
                    Taimuihong = x.Taimuihong,
                    Muivetthuong = x.Muivetthuong,
                    Motamuivetthuong = x.Motamuivetthuong,
                    Taivetthuong = x.Taivetthuong,
                    Motataivetthuong = x.Motataivetthuong,
                    Taichaymau = x.Taichaymau,
                    Motataichaymau = x.Motataichaymau,
                    Taimuihongkhac = x.Taimuihongkhac,
                    Benhlykhac = x.Benhlykhac,
                    Cacxetnghiem = x.Cacxetnghiem,
                    Motacacxetnghiem = x.Motacacxetnghiem,
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
