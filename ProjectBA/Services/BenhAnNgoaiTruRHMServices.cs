using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBA.Models.Entities;

namespace ProjectBA.Services
{
    public interface IBenhAnNgoaiTruRHMServices
    {
        Task<dynamic> ThongTin();
        Task<dynamic> ThemThongTin([FromBody] Benhanngoaitrurhm benhanngoaitrurhm);
    }

    public class BenhAnNgoaiTruRHMServices : IBenhAnNgoaiTruRHMServices
    {
        private HospitalContext _context;

        public BenhAnNgoaiTruRHMServices(HospitalContext context)
        {
            _context = context;
        }

        public async Task<dynamic> ThemThongTin([FromBody] Benhanngoaitrurhm benhanngoaitrurhm)
        {
            try
            {
                var data = await _context.Benhanngoaitrurhms.AddAsync(benhanngoaitrurhm);
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
            var data = await _context.Benhanngoaitrurhms
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
                    Lydovaovien = x.Lydovaovien,
                    Dienbienlamsang = x.Dienbienlamsang,
                    Diung = x.Diung,
                    Motadiung = x.Motadiung,
                    Banthan = x.Banthan,
                    Motabanthan = x.Motabanthan,
                    Giadinh = x.Giadinh,
                    Motagiadinh = x.Motagiadinh,
                    Toanthan = x.Toanthan,
                    Motatoanthan = x.Motatoanthan,
                    Mach = x.Mach,
                    Nhietdo = x.Nhietdo,
                    Huyetap = x.Huyetap,
                    Nhiptho = x.Nhiptho,
                    Cannang = x.Cannang,
                    Chieucao = x.Chieucao,
                    Ngoaimieng = x.Ngoaimieng,
                    Motangoaimieng = x.Motangoaimieng,
                    Trongmieng = x.Trongmieng,
                    Motatrongmieng = x.Motatrongmieng,
                    Xetnghiemlamsang = x.Xetnghiemlamsang,
                    Motaxetnghiemlamsang = x.Motaxetnghiemlamsang,
                    Tomtatbenhan = x.Tomtatbenhan,
                    Benhchinh = x.Benhchinh,
                    Mabenhchinh = x.Mabenhchinh,
                    Benhkemtheo = x.Benhkemtheo,
                    Mabenhkemtheo = x.Mabenhkemtheo,
                    Bienchung = x.Bienchung,
                    Mabienchung = x.Mabienchung,
                    Kehoachdieutri = x.Kehoachdieutri,
                    Ngaydieutri = x.Ngaydieutri,
                    Dienbienbenh = x.Dienbienbenh,
                    Xutri = x.Xutri,
                    Ghichu = x.Ghichu,
                    Thoigiandieutritungay = x.Thoigiandieutritungay,
                    Thoigiandieutridenngay = x.Thoigiandieutridenngay,
                    Thoigianbacsidieutriky = x.Thoigianbacsidieutriky,
                    Bacsidieutri = x.Bacsidieutri,
                    Thoigiandaidiencskbcbky = x.Thoigiandaidiencskbcbky,
                    Daidiencskbcb = x.Daidiencskbcb,
                    Dienbiemls = x.Dienbiemls,
                    Dauhieulamsang = x.Dauhieulamsang,
                    Tomtatketquaxetnghiem = x.Tomtatketquaxetnghiem,
                    Noikhoa = x.Noikhoa,
                    Motanoikhoa = x.Motanoikhoa,
                    Phauthuatthuthuat = x.Phauthuatthuthuat,
                    Motaphauthuatthuthuat = x.Motaphauthuatthuthuat,
                    Tinhtrangravien = x.Tinhtrangravien,
                    Huongdieutri = x.Huongdieutri,
                    Thoigianbacsidieutrikytk = x.Thoigianbacsidieutrikytk,
                    Bacsidieutritk = x.Bacsidieutritk
                }).FirstOrDefaultAsync();
            return data;
        }
    }
}
