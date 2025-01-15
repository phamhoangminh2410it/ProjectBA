using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBA.Models.Entities;
using System.Net.NetworkInformation;
using System;

namespace ProjectBA.Services
{
    public interface IBenhAnNgoaiTruRHMServices
    {
        Task<dynamic> ThongTin();
        Task<dynamic> ThemThongTin([FromBody] Benhanngoaitrurhm benhanngoaitrurhm);
        Task<dynamic> CapNhatThongTin([FromBody] Benhanngoaitrurhm x);
        Task<dynamic> Xoa(string mabenhan);
    }

    public class BenhAnNgoaiTruRHMServices : IBenhAnNgoaiTruRHMServices
    {
        private HospitalContext _context;

        public BenhAnNgoaiTruRHMServices(HospitalContext context)
        {
            _context = context;
        }

        public async Task<dynamic> Xoa(string mabenhan)
        {
            try
            {
                var data = await _context.Benhanngoaitrurhms.FindAsync(mabenhan);
                _context.Benhanngoaitrurhms.Remove(data);
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

        public async Task<dynamic> CapNhatThongTin([FromBody] Benhanngoaitrurhm x)
        {
            try
            {
                Benhanngoaitrurhm ba = await _context.Benhanngoaitrurhms.FindAsync(x.Mabenhan);
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
                ba.Toanthan = x.Toanthan;
                ba.Motatoanthan = x.Motatoanthan;
                ba.Mach = x.Mach;
                ba.Nhietdo = x.Nhietdo;
                ba.Huyetap = x.Huyetap;
                ba.Nhiptho = x.Nhiptho;
                ba.Cannang = x.Cannang;
                ba.Chieucao = x.Chieucao;
                ba.Ngoaimieng = x.Ngoaimieng;
                ba.Motangoaimieng = x.Motangoaimieng;
                ba.Trongmieng = x.Trongmieng;
                ba.Motatrongmieng = x.Motatrongmieng;
                ba.Xetnghiemlamsang = x.Xetnghiemlamsang;
                ba.Motaxetnghiemlamsang = x.Motaxetnghiemlamsang;
                ba.Tomtatbenhan = x.Tomtatbenhan;
                ba.Benhchinh = x.Benhchinh;
                ba.Mabenhchinh = x.Mabenhchinh;
                ba.Benhkemtheo = x.Benhkemtheo;
                ba.Mabenhkemtheo = x.Mabenhkemtheo;
                ba.Bienchung = x.Bienchung;
                ba.Mabienchung = x.Mabienchung;
                ba.Kehoachdieutri = x.Kehoachdieutri;
                ba.Ngaydieutri = x.Ngaydieutri;
                ba.Dienbienbenh = x.Dienbienbenh;
                ba.Xutri = x.Xutri;
                ba.Ghichu = x.Ghichu;
                ba.Thoigiandieutritungay = x.Thoigiandieutritungay;
                ba.Thoigiandieutridenngay = x.Thoigiandieutridenngay;
                ba.Thoigianbacsidieutriky = x.Thoigianbacsidieutriky;
                ba.Bacsidieutri = x.Bacsidieutri;
                ba.Thoigiandaidiencskbcbky = x.Thoigiandaidiencskbcbky;
                ba.Daidiencskbcb = x.Daidiencskbcb;
                ba.Dienbiemls = x.Dienbiemls;
                ba.Dauhieulamsang = x.Dauhieulamsang;
                ba.Tomtatketquaxetnghiem = x.Tomtatketquaxetnghiem;
                ba.Noikhoa = x.Noikhoa;
                ba.Motanoikhoa = x.Motanoikhoa;
                ba.Phauthuatthuthuat = x.Phauthuatthuthuat;
                ba.Motaphauthuatthuthuat = x.Motaphauthuatthuthuat;
                ba.Tinhtrangravien = x.Tinhtrangravien;
                ba.Huongdieutri = x.Huongdieutri;
                ba.Thoigianbacsidieutrikytk = x.Thoigianbacsidieutrikytk;
                ba.Bacsidieutritk = x.Bacsidieutritk;
                _context.Benhanngoaitrurhms.Update(ba);
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
