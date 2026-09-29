using System;
using System.Collections.Generic;

namespace Lab02.Bai03_5
{
    // Lop truu tuong NhanVien
    public abstract class NhanVien
    {
        public string MaNV { get; set; } = "";
        public string HoTen { get; set; } = "";

        public NhanVien() { }

        public NhanVien(string maNV, string hoTen)
        {
            MaNV = maNV;
            HoTen = hoTen;
        }

        // Phuong thuc truu tuong tinh luong (da hinh)
        public abstract double TinhLuong();

        public virtual void Nhap()
        {
            Console.Write("Nhap ma nhan vien: ");
            MaNV = Console.ReadLine() ?? "";
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine() ?? "";
        }

        public virtual void Xuat()
        {
            Console.Write($"Ma NV: {MaNV,-6} | Ho ten: {HoTen,-20} ");
        }
    }

    // Nhan vien kinh doanh: Luong = LuongCoBan + SoHopDong * 500.000
    public class NhanVienKinhDoanh : NhanVien
    {
        public double LuongCoBan { get; set; }
        public int SoHopDong { get; set; }

        public NhanVienKinhDoanh() { }

        public NhanVienKinhDoanh(string maNV, string hoTen, double luongCoBan, int soHopDong)
            : base(maNV, hoTen)
        {
            LuongCoBan = luongCoBan;
            SoHopDong = soHopDong;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap luong co ban: ");
            double.TryParse(Console.ReadLine(), out double lcb);
            LuongCoBan = lcb;
            Console.Write("Nhap so hop dong ky ket: ");
            int.TryParse(Console.ReadLine(), out int shd);
            SoHopDong = shd;
        }

        // Override tinh luong da hinh cho nhan vien kinh doanh
        public override double TinhLuong()
        {
            return LuongCoBan + (SoHopDong * 500000);
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"| Bo phan: Kinh doanh | HD: {SoHopDong} | Luong: {TinhLuong():N0} VND");
        }
    }

    // Nhan vien san xuat: Luong = SoSanPham * 1000, neu > 3000 thi thuong 5%
    public class NhanVienSanXuat : NhanVien
    {
        public int SoSanPham { get; set; }

        public NhanVienSanXuat() { }

        public NhanVienSanXuat(string maNV, string hoTen, int soSanPham)
            : base(maNV, hoTen)
        {
            SoSanPham = soSanPham;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so luong san pham: ");
            int.TryParse(Console.ReadLine(), out int sp);
            SoSanPham = sp;
        }

        // Override tinh luong da hinh cho nhan vien san xuat
        public override double TinhLuong()
        {
            double luong = SoSanPham * 1000;
            // Thuong 5% neu tren 3000 san pham
            if (SoSanPham > 3000)
            {
                luong += luong * 0.05;
            }
            return luong;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"| Bo phan: San xuat  | SP: {SoSanPham} | Luong: {TinhLuong():N0} VND");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 3.5: KE THUA VA DA HINH - TINH LUONG NHAN VIEN ===");

            List<NhanVien> congTy = new List<NhanVien>
            {
                new NhanVienKinhDoanh("KD01", "Pham Minh Tuan", 6000000, 5),
                new NhanVienKinhDoanh("KD02", "Hoang Thu Thao", 7000000, 2),
                new NhanVienSanXuat("SX01", "Nguyen Van Hai", 2500),
                new NhanVienSanXuat("SX02", "Tran Dinh Trong", 4000)
            };

            Console.WriteLine("\n--- DANH SACH NHAN VIEN VA TIEN LUONG ---");
            double tongLuong = 0;
            foreach (var nv in congTy)
            {
                nv.Xuat();
                tongLuong += nv.TinhLuong();
            }

            Console.WriteLine($"\nTong luong toan cong ty: {tongLuong:N0} VND");
        }
    }
}
