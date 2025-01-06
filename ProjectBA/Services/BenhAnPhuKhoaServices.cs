using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBA.Models.Entities;

namespace ProjectBA.Services
{
    public interface IBenhAnPhuKhoaServices
    {
        Task<dynamic> ThongTin();
        Task<dynamic> ThemThongTin([FromBody] Benhanphukhoa benhanphukhoa);
    }

    public class BenhAnPhuKhoaServices : IBenhAnPhuKhoaServices
    {
        private HospitalContext _context;

        public BenhAnPhuKhoaServices(HospitalContext context)
        {
            _context = context;
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

        //public async Task<dynamic> CapNhatThongTin([FromBody] Benhanngoaikhoa benhanngoaikhoa)
        //{
        //    try
        //    {
        //        Benhanngoaikhoa ba = await _context.Benhanngoaikhoas.FindAsync(benhanngoaikhoa.Mabenhan);
        //        ba.Macoquanchuquan = benhanngoaikhoa.Macoquanchuquan;

        //        _context.Benhanngoaikhoas.Update(ba);
        //        await _context.SaveChangesAsync();
        //        return new
        //        {
        //            data = ba
        //        };
        //    }
        //}

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
