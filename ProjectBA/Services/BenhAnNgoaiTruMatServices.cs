using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBA.Models.Entities;

namespace ProjectBA.Services
{
    public interface IBenhAnNgoaiTruMatServices
    {
        Task<dynamic> ThongTin();
        Task<dynamic> ThemThongTin([FromBody] Benhanngoaitrumat benhanngoaitrumat);
    }

    public class BenhAnNgoaiTruMatServices : IBenhAnNgoaiTruMatServices
    {
        private HospitalContext _context;

        public BenhAnNgoaiTruMatServices(HospitalContext context)
        {
            _context = context;
        }

        public async Task<dynamic> ThemThongTin([FromBody] Benhanngoaitrumat benhanngoaitrumat)
        {
            try
            {
                var data = await _context.Benhanngoaitrumats.AddAsync(benhanngoaitrumat);
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
            var data = await _context.Benhanngoaitrumats
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
                    Bophan = x.Bophan,
                    Hocmatphai = x.Hocmatphai,
                    Motahocmatphai = x.Motahocmatphai,
                    Tinhtrangnhancauphai = x.Tinhtrangnhancauphai,
                    Motatinhtrangnhancauphai = x.Motatinhtrangnhancauphai,
                    Vannhanphai = x.Vannhanphai,
                    Motavannhanphai = x.Motavannhanphai,
                    Ledaophai = x.Ledaophai,
                    Motaledaophai = x.Motaledaophai,
                    Mimatphai = x.Mimatphai,
                    Motamimatphai = x.Motamimatphai,
                    Ketmacphai = x.Ketmacphai,
                    Motaketmacphai = x.Motaketmacphai,
                    Giacmacphai = x.Giacmacphai,
                    Motagiacmacphai = x.Motagiacmacphai,
                    Cungmacphai = x.Cungmacphai,
                    Motacungmacphai = x.Motacungmacphai,
                    Tienphongphai = x.Tienphongphai,
                    Motatienphongphai = x.Motatienphongphai,
                    Mongmatphai = x.Mongmatphai,
                    Motamongmatphai = x.Motamongmatphai,
                    Dongtuphai = x.Dongtuphai,
                    Motadongtuphai = x.Motadongtuphai,
                    Thethuytinhphai = x.Thethuytinhphai,
                    Motathethuytinhphai = x.Motathethuytinhphai,
                    Dichkinhphai = x.Dichkinhphai,
                    Motadichkinhphai = x.Motadichkinhphai,
                    Daymatphai = x.Daymatphai,
                    Motadaymatphai = x.Motadaymatphai,
                    Hocmattrai = x.Hocmattrai,
                    Motahocmattrai = x.Motahocmattrai,
                    Tinhtrangnhancautrai = x.Tinhtrangnhancautrai,
                    Motatinhtrangnhancautrai = x.Motatinhtrangnhancautrai,
                    Vannhantrai = x.Vannhantrai,
                    Motavannhantrai = x.Motavannhantrai,
                    Ledaotrai = x.Ledaotrai,
                    Motaledaotrai = x.Motaledaotrai,
                    Mimattrai = x.Mimattrai,
                    Motamimattrai = x.Motamimattrai,
                    Ketmactrai = x.Ketmactrai,
                    Motaketmactrai = x.Motaketmactrai,
                    Giacmactrai = x.Giacmactrai,
                    Motagiacmactrai = x.Motagiacmactrai,
                    Cungmactrai = x.Cungmactrai,
                    Motacungmactrai = x.Motacungmactrai,
                    Tienphongtrai = x.Tienphongtrai,
                    Motatienphongtrai = x.Motatienphongtrai,
                    Mongmattrai = x.Mongmattrai,
                    Motamongmattrai = x.Motamongmattrai,
                    Dongtutrai = x.Dongtutrai,
                    Motadongtutrai = x.Motadongtutrai,
                    Thethuytinhtrai = x.Thethuytinhtrai,
                    Motathethuytinhtrai = x.Motathethuytinhtrai,
                    Dichkinhtrai = x.Dichkinhtrai,
                    Motadichkinhtrai = x.Motadichkinhtrai,
                    Daymattrai = x.Daymattrai,
                    Motadaymattrai = x.Motadaymattrai,
                    Toanthan = x.Toanthan,
                    Motatoanthan = x.Motatoanthan,
                    Mach = x.Mach,
                    Nhietdo = x.Nhietdo,
                    Huyetap = x.Huyetap,
                    Nhiptho = x.Nhiptho,
                    Cannang = x.Cannang,
                    Chieucao = x.Chieucao,
                    Cacxetnghiem = x.Cacxetnghiem,
                    Motacacxetnghiem = x.Motacacxetnghiem,
                    Tomtatbenhan = x.Tomtatbenhan,
                    Benhchinh = x.Benhchinh,
                    Mabenhchinh = x.Mabenhchinh,
                    Benhkemtheo = x.Benhkemtheo,
                    Mabenhkemtheo = x.Mabenhkemtheo,
                    Bienchung = x.Bienchung,
                    Mabienchung = x.Mabienchung,
                    Tienluonggan = x.Tienluonggan,
                    Tienluongxa = x.Tienluongxa,
                    Huongdieutritieptheo = x.Huongdieutritieptheo,
                    Tuvangiaoduc = x.Tuvangiaoduc,
                    Motatuvangiaoduc = x.Motatuvangiaoduc,
                    Thoigianbacsidieutriky = x.Thoigianbacsidieutriky,
                    Bacsidieutri = x.Bacsidieutri,
                    Thoigiandaidiencskbcbky = x.Thoigiandaidiencskbcbky,
                    Daidiencskbcb = x.Daidiencskbcb,
                    Chuandoankhiravienmp = x.Chuandoankhiravienmp,
                    Chuandoankhiravienmt = x.Chuandoankhiravienmt,
                    Noikhoa = x.Noikhoa,
                    Motanoikhoa = x.Motanoikhoa,
                    Phauthuatthuthuat = x.Phauthuatthuthuat,
                    Motaphauthuatthuthuat = x.Motaphauthuatthuthuat,
                    Toantrang = x.Toantrang,
                    Matphai = x.Matphai,
                    Mattrai = x.Mattrai,
                    Thilucravienmp = x.Thilucravienmp,
                    Thilucravienmt = x.Thilucravienmt,
                    Thilucchinhkinhmp = x.Thilucchinhkinhmp,
                    Thilucchinhkinhmt = x.Thilucchinhkinhmt,
                    Nhanapravienmp = x.Nhanapravienmp,
                    Nhanapravienmt = x.Nhanapravienmt,
                    Huongdieutri = x.Huongdieutri,
                    Thoigianbacsidieutrikytk = x.Thoigianbacsidieutrikytk,
                    Bacsidieutritk = x.Bacsidieutritk
                }).FirstOrDefaultAsync();
            return data;
        }
    }
}
