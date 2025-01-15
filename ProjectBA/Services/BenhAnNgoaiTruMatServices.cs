using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBA.Models.Entities;
using System.Net.NetworkInformation;

namespace ProjectBA.Services
{
    public interface IBenhAnNgoaiTruMatServices
    {
        Task<dynamic> ThongTin();
        Task<dynamic> ThemThongTin([FromBody] Benhanngoaitrumat benhanngoaitrumat);
        Task<dynamic> CapNhatThongTin([FromBody] Benhanngoaitrumat x);
        Task<dynamic> Xoa(string mabenhan);
    }

    public class BenhAnNgoaiTruMatServices : IBenhAnNgoaiTruMatServices
    {
        private HospitalContext _context;

        public BenhAnNgoaiTruMatServices(HospitalContext context)
        {
            _context = context;
        }

        public async Task<dynamic> Xoa(string mabenhan)
        {
            try
            {
                var data = await _context.Benhanngoaitrumats.FindAsync(mabenhan);
                _context.Benhanngoaitrumats.Remove(data);
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

        public async Task<dynamic> CapNhatThongTin([FromBody] Benhanngoaitrumat x)
        {
            try
            {
                Benhanngoaitrumat ba = await _context.Benhanngoaitrumats.FindAsync(x.Mabenhan);
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
                ba.Lydovaovien = x.Lydovaovien;
                ba.Dienbienlamsang = x.Dienbienlamsang;
                ba.Diung = x.Diung;
                ba.Motadiung = x.Motadiung;
                ba.Banthan = x.Banthan;
                ba.Motabanthan = x.Motabanthan;
                ba.Giadinh = x.Giadinh;
                ba.Motagiadinh = x.Motagiadinh;
                ba.Bophan = x.Bophan;
                ba.Hocmatphai = x.Hocmatphai;
                ba.Motahocmatphai = x.Motahocmatphai;
                ba.Tinhtrangnhancauphai = x.Tinhtrangnhancauphai;
                ba.Motatinhtrangnhancauphai = x.Motatinhtrangnhancauphai;
                ba.Vannhanphai = x.Vannhanphai;
                ba.Motavannhanphai = x.Motavannhanphai;
                ba.Ledaophai = x.Ledaophai;
                ba.Motaledaophai = x.Motaledaophai;
                ba.Mimatphai = x.Mimatphai;
                ba.Motamimatphai = x.Motamimatphai;
                ba.Ketmacphai = x.Ketmacphai;
                ba.Motaketmacphai = x.Motaketmacphai;
                ba.Giacmacphai = x.Giacmacphai;
                ba.Motagiacmacphai = x.Motagiacmacphai;
                ba.Cungmacphai = x.Cungmacphai;
                ba.Motacungmacphai = x.Motacungmacphai;
                ba.Tienphongphai = x.Tienphongphai;
                ba.Motatienphongphai = x.Motatienphongphai;
                ba.Mongmatphai = x.Mongmatphai;
                ba.Motamongmatphai = x.Motamongmatphai;
                ba.Dongtuphai = x.Dongtuphai;
                ba.Motadongtuphai = x.Motadongtuphai;
                ba.Thethuytinhphai = x.Thethuytinhphai;
                ba.Motathethuytinhphai = x.Motathethuytinhphai;
                ba.Dichkinhphai = x.Dichkinhphai;
                ba.Motadichkinhphai = x.Motadichkinhphai;
                ba.Daymatphai = x.Daymatphai;
                ba.Motadaymatphai = x.Motadaymatphai;
                ba.Hocmattrai = x.Hocmattrai;
                ba.Motahocmattrai = x.Motahocmattrai;
                ba.Tinhtrangnhancautrai = x.Tinhtrangnhancautrai;
                ba.Motatinhtrangnhancautrai = x.Motatinhtrangnhancautrai;
                ba.Vannhantrai = x.Vannhantrai;
                ba.Motavannhantrai = x.Motavannhantrai;
                ba.Ledaotrai = x.Ledaotrai;
                ba.Motaledaotrai = x.Motaledaotrai;
                ba.Mimattrai = x.Mimattrai;
                ba.Motamimattrai = x.Motamimattrai;
                ba.Ketmactrai = x.Ketmactrai;
                ba.Motaketmactrai = x.Motaketmactrai;
                ba.Giacmactrai = x.Giacmactrai;
                ba.Motagiacmactrai = x.Motagiacmactrai;
                ba.Cungmactrai = x.Cungmactrai;
                ba.Motacungmactrai = x.Motacungmactrai;
                ba.Tienphongtrai = x.Tienphongtrai;
                ba.Motatienphongtrai = x.Motatienphongtrai;
                ba.Mongmattrai = x.Mongmattrai;
                ba.Motamongmattrai = x.Motamongmattrai;
                ba.Dongtutrai = x.Dongtutrai;
                ba.Motadongtutrai = x.Motadongtutrai;
                ba.Thethuytinhtrai = x.Thethuytinhtrai;
                ba.Motathethuytinhtrai = x.Motathethuytinhtrai;
                ba.Dichkinhtrai = x.Dichkinhtrai;
                ba.Motadichkinhtrai = x.Motadichkinhtrai;
                ba.Daymattrai = x.Daymattrai;
                ba.Motadaymattrai = x.Motadaymattrai;
                ba.Toanthan = x.Toanthan;
                ba.Motatoanthan = x.Motatoanthan;
                ba.Mach = x.Mach;
                ba.Nhietdo = x.Nhietdo;
                ba.Huyetap = x.Huyetap;
                ba.Nhiptho = x.Nhiptho;
                ba.Cannang = x.Cannang;
                ba.Chieucao = x.Chieucao;
                ba.Cacxetnghiem = x.Cacxetnghiem;
                ba.Motacacxetnghiem = x.Motacacxetnghiem;
                ba.Tomtatbenhan = x.Tomtatbenhan;
                ba.Benhchinh = x.Benhchinh;
                ba.Mabenhchinh = x.Mabenhchinh;
                ba.Benhkemtheo = x.Benhkemtheo;
                ba.Mabenhkemtheo = x.Mabenhkemtheo;
                ba.Bienchung = x.Bienchung;
                ba.Mabienchung = x.Mabienchung;
                ba.Tienluonggan = x.Tienluonggan;
                ba.Tienluongxa = x.Tienluongxa;
                ba.Huongdieutritieptheo = x.Huongdieutritieptheo;
                ba.Tuvangiaoduc = x.Tuvangiaoduc;
                ba.Motatuvangiaoduc = x.Motatuvangiaoduc;
                ba.Thoigianbacsidieutriky = x.Thoigianbacsidieutriky;
                ba.Bacsidieutri = x.Bacsidieutri;
                ba.Thoigiandaidiencskbcbky = x.Thoigiandaidiencskbcbky;
                ba.Daidiencskbcb = x.Daidiencskbcb;
                ba.Chuandoankhiravienmp = x.Chuandoankhiravienmp;
                ba.Chuandoankhiravienmt = x.Chuandoankhiravienmt;
                ba.Noikhoa = x.Noikhoa;
                ba.Motanoikhoa = x.Motanoikhoa;
                ba.Phauthuatthuthuat = x.Phauthuatthuthuat;
                ba.Motaphauthuatthuthuat = x.Motaphauthuatthuthuat;
                ba.Toantrang = x.Toantrang;
                ba.Matphai = x.Matphai;
                ba.Mattrai = x.Mattrai;
                ba.Thilucravienmp = x.Thilucravienmp;
                ba.Thilucravienmt = x.Thilucravienmt;
                ba.Thilucchinhkinhmp = x.Thilucchinhkinhmp;
                ba.Thilucchinhkinhmt = x.Thilucchinhkinhmt;
                ba.Nhanapravienmp = x.Nhanapravienmp;
                ba.Nhanapravienmt = x.Nhanapravienmt;
                ba.Huongdieutri = x.Huongdieutri;
                ba.Thoigianbacsidieutrikytk = x.Thoigianbacsidieutrikytk;
                ba.Bacsidieutritk = x.Bacsidieutritk;

                _context.Benhanngoaitrumats.Update(ba);
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
