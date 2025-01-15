using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBA.Models.Entities;

namespace ProjectBA.Services
{
    public interface IBenhAnPhuKhoaServices
    {
        Task<dynamic> ThongTin();
        Task<dynamic> ThemThongTin([FromBody] Benhanphukhoa benhanphukhoa);
        Task<dynamic> CapNhatThongTin([FromBody] Benhanphukhoa x);
        Task<dynamic> Xoa(string mabenhan);
    }

    public class BenhAnPhuKhoaServices : IBenhAnPhuKhoaServices
    {
        private HospitalContext _context;

        public BenhAnPhuKhoaServices(HospitalContext context)
        {
            _context = context;
        }

        public async Task<dynamic> Xoa(string mabenhan)
        {
            try
            {
                var data = await _context.Benhanphukhoas.FindAsync(mabenhan);
                _context.Benhanphukhoas.Remove(data);
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

        public async Task<dynamic> ThemThongTin([FromBody] Benhanphukhoa benhanphukhoa)
        {
            try
            {
                var data = await _context.Benhanphukhoas.AddAsync(benhanphukhoa);
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

        public async Task<dynamic> CapNhatThongTin([FromBody] Benhanphukhoa x)
        {
            try
            {
                Benhanphukhoa ba = await _context.Benhanphukhoas.FindAsync(x.Mabenhan);
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
                ba.Batdaucokinh = x.Batdaucokinh;
                ba.Chuky = x.Chuky;
                ba.Songaycokinh = x.Songaycokinh;
                ba.Cacbenhphukhoadieutri = x.Cacbenhphukhoadieutri;
                ba.Solancothai = x.Solancothai;
                ba.Solansay = x.Solansay;
                ba.Solanphathai = x.Solanphathai;
                ba.Solansinh = x.Solansinh;
                ba.Cachthucsinh = x.Cachthucsinh;
                ba.Soconsong = x.Soconsong;
                ba.Tiensunoingoaikhoa = x.Tiensunoingoaikhoa;
                ba.Benhsu = x.Benhsu;
                ba.Da = x.Da;
                ba.Niemmac = x.Niemmac;
                ba.Phu = x.Phu;
                ba.Xuathuyet = x.Xuathuyet;
                ba.Mach = x.Mach;
                ba.Nhietdo = x.Nhietdo;
                ba.Huyetap = x.Huyetap;
                ba.Nhiptho = x.Nhiptho;
                ba.Tim = x.Tim;
                ba.Phoi = x.Phoi;
                ba.Than = x.Than;
                ba.Thieumau = x.Thieumau;
                ba.Cacbenhkhac = x.Cacbenhkhac;
                ba.Khamthucthe = x.Khamthucthe;
                ba.Xetnghiemmaungoaivi = x.Xetnghiemmaungoaivi;
                ba.Xetnghiemdongmau = x.Xetnghiemdongmau;
                ba.Xetnghiemsinhhoamau = x.Xetnghiemsinhhoamau;
                ba.Sieuam = x.Sieuam;
                ba.Sinhthiet = x.Sinhthiet;
                ba.Xetnghiemhpv = x.Xetnghiemhpv;
                ba.Xetnghiemtebaocotucung = x.Xetnghiemtebaocotucung;
                ba.Nghiemphapvia = x.Nghiemphapvia;
                ba.Soicotucung = x.Soicotucung;
                ba.Cacxetnghiemkhac = x.Cacxetnghiemkhac;
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
                ba.Tienluong = x.Tienluong;
                ba.Huongdieutritieptheo = x.Huongdieutritieptheo;
                ba.Bienphaptranhthai = x.Bienphaptranhthai;
                ba.Bienphaptranhthaiduoccap = x.Bienphaptranhthaiduoccap;
                ba.Motabienphapkhac = x.Motabienphapkhac;
                ba.Chedochamsoc = x.Chedochamsoc;
                ba.Tuvansuckhoe = x.Tuvansuckhoe;
                ba.Motatuvansuckhoe = x.Motatuvansuckhoe;
                ba.Thoiganbacsilambenhanky = x.Thoiganbacsilambenhanky;
                ba.Bacsilambenhan = x.Bacsilambenhan;
                ba.Dienbienlamsang = x.Dienbienlamsang;
                ba.Dauhieulamsang = x.Dauhieulamsang;
                ba.Xetnghiemhpvls = x.Xetnghiemhpvls;
                ba.Xetnghiemtebaocotucungls = x.Xetnghiemtebaocotucungls;
                ba.Nghiemphapvials = x.Nghiemphapvials;
                ba.Sieuamls = x.Sieuamls;
                ba.Soicotucungls = x.Soicotucungls;
                ba.Sinhthietls = x.Sinhthietls;
                ba.Lskhac = x.Lskhac;
                ba.Noikhoa = x.Noikhoa;
                ba.Motanoikhoa = x.Motanoikhoa;
                ba.Phauthuatthuthuat = x.Phauthuatthuthuat;
                ba.Motaphauthuatthuthuat = x.Motaphauthuatthuthuat;
                ba.Dotdien = x.Dotdien;
                ba.Khoetchop = x.Khoetchop;
                ba.Leep = x.Leep;
                ba.Dieutrikhac = x.Dieutrikhac;
                ba.Chaymau = x.Chaymau;
                ba.Nhiemtrung = x.Nhiemtrung;
                ba.Sot = x.Sot;
                ba.Daubung = x.Daubung;
                ba.Taibienkhac = x.Taibienkhac;
                ba.Tinhtrangravientk = x.Tinhtrangravientk;
                ba.Huongdieutri = x.Huongdieutri;
                ba.Thoigianbacsidieutriky = x.Thoigianbacsidieutriky;
                ba.Bacsidieutri = x.Bacsidieutri;
                _context.Benhanphukhoas.Update(ba);
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
                    message = ex.Message,
                };
            }
        }

        public async Task<dynamic> ThongTin()
        {
            var data = await _context.Benhanphukhoas
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
                    Batdaucokinh = x.Batdaucokinh,
                    Chuky = x.Chuky,
                    Songaycokinh = x.Songaycokinh,
                    Cacbenhphukhoadieutri = x.Cacbenhphukhoadieutri,
                    Solancothai = x.Solancothai,
                    Solansay = x.Solansay,
                    Solanphathai = x.Solanphathai,
                    Solansinh = x.Solansinh,
                    Cachthucsinh = x.Cachthucsinh,
                    Soconsong = x.Soconsong,
                    Tiensunoingoaikhoa = x.Tiensunoingoaikhoa,
                    Benhsu = x.Benhsu,
                    Da = x.Da,
                    Niemmac = x.Niemmac,
                    Phu = x.Phu,
                    Xuathuyet = x.Xuathuyet,
                    Mach = x.Mach,
                    Nhietdo = x.Nhietdo,
                    Huyetap = x.Huyetap,
                    Nhiptho = x.Nhiptho,
                    Tim = x.Tim,
                    Phoi = x.Phoi,
                    Than = x.Than,
                    Thieumau = x.Thieumau,
                    Cacbenhkhac = x.Cacbenhkhac,
                    Khamthucthe = x.Khamthucthe,
                    Xetnghiemmaungoaivi = x.Xetnghiemmaungoaivi,
                    Xetnghiemdongmau = x.Xetnghiemdongmau,
                    Xetnghiemsinhhoamau = x.Xetnghiemsinhhoamau,
                    Sieuam = x.Sieuam,
                    Sinhthiet = x.Sinhthiet,
                    Xetnghiemhpv = x.Xetnghiemhpv,
                    Xetnghiemtebaocotucung = x.Xetnghiemtebaocotucung,
                    Nghiemphapvia = x.Nghiemphapvia,
                    Soicotucung = x.Soicotucung,
                    Cacxetnghiemkhac = x.Cacxetnghiemkhac,
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
                    Tienluong = x.Tienluong,
                    Huongdieutritieptheo = x.Huongdieutritieptheo,
                    Bienphaptranhthai = x.Bienphaptranhthai,
                    Bienphaptranhthaiduoccap = x.Bienphaptranhthaiduoccap,
                    Motabienphapkhac = x.Motabienphapkhac,
                    Chedochamsoc = x.Chedochamsoc,
                    Tuvansuckhoe = x.Tuvansuckhoe,
                    Motatuvansuckhoe = x.Motatuvansuckhoe,
                    Thoiganbacsilambenhanky = x.Thoiganbacsilambenhanky,
                    Bacsilambenhan = x.Bacsilambenhan,
                    Dienbienlamsang = x.Dienbienlamsang,
                    Dauhieulamsang = x.Dauhieulamsang,
                    Xetnghiemhpvls = x.Xetnghiemhpvls,
                    Xetnghiemtebaocotucungls = x.Xetnghiemtebaocotucungls,
                    Nghiemphapvials = x.Nghiemphapvials,
                    Sieuamls = x.Sieuamls,
                    Soicotucungls = x.Soicotucungls,
                    Sinhthietls = x.Sinhthietls,
                    Lskhac = x.Lskhac,
                    Noikhoa = x.Noikhoa,
                    Motanoikhoa = x.Motanoikhoa,
                    Phauthuatthuthuat = x.Phauthuatthuthuat,
                    Motaphauthuatthuthuat = x.Motaphauthuatthuthuat,
                    Dotdien = x.Dotdien,
                    Khoetchop = x.Khoetchop,
                    Leep = x.Leep,
                    Dieutrikhac = x.Dieutrikhac,
                    Chaymau = x.Chaymau,
                    Nhiemtrung = x.Nhiemtrung,
                    Sot = x.Sot,
                    Daubung = x.Daubung,
                    Taibienkhac = x.Taibienkhac,
                    Tinhtrangravientk = x.Tinhtrangravientk,
                    Huongdieutri = x.Huongdieutri,
                    Thoigianbacsidieutriky = x.Thoigianbacsidieutriky,
                    Bacsidieutri = x.Bacsidieutri
                }).FirstOrDefaultAsync();
            return data;
        }
    }
}
