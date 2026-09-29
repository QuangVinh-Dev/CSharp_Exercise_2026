using System;
using System.Collections.Generic;

namespace Lab02.Bai02_5_LuongNhanVien
{
    // Lop NhanVien
    public class NhanVien
    {
        public string HoTen { get; set; } = "";
        public double MucLuong { get; set; }
        public int SoNgayVang { get; set; }

        public NhanVien() { }

        public NhanVien(string hoTen, double mucLuong, int soNgayVang)
        {
            HoTen = hoTen;
            MucLuong = mucLuong;
            SoNgayVang = soNgayVang;
        }

        // Tinh luong 1 nhan vien: tru 100.000 VND cho moi ngay vang
        public double TinhLuong()
        {
            double luong = MucLuong - SoNgayVang * 100000;
            return luong > 0 ? luong : 0;
        }

        public void Xuat()
        {
            Console.WriteLine($"Ho ten: {HoTen,-20} | Luong goc: {MucLuong,12:N0} | Vang: {SoNgayVang} | Thuc lanh: {TinhLuong(),12:N0} VND");
        }
    }

    // Lop PhongBan quan ly danh sach n nhan vien
    public class PhongBan
    {
        private List<NhanVien> danhSach = new List<NhanVien>();

        public void Add(NhanVien nv) => danhSach.Add(nv);

        public void Nhap()
        {
            Console.Write("Nhap so nhan vien cua phong ban: ");
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap nhan vien thu {i + 1}:");
                Console.Write("Ho ten: ");
                string ten = Console.ReadLine() ?? "";
                Console.Write("Muc luong: ");
                double.TryParse(Console.ReadLine(), out double luong);
                Console.Write("So ngay vang: ");
                int.TryParse(Console.ReadLine(), out int vang);
                danhSach.Add(new NhanVien(ten, luong, vang));
            }
        }

        public void Xuat()
        {
            Console.WriteLine("\n--- DANH SACH NHAN VIEN PHONG BAN ---");
            foreach (var nv in danhSach)
            {
                nv.Xuat();
            }
        }

        // Tinh tong luong cua ca phong ban
        public double TinhTongLuong()
        {
            double tong = 0;
            foreach (var nv in danhSach)
            {
                tong += nv.TinhLuong();
            }
            return tong;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 2.5: TINH TONG LUONG NHAN VIEN PHONG BAN ===");

            PhongBan pb = new PhongBan();
            pb.Add(new NhanVien("Nguyen Van An", 10000000, 2));
            pb.Add(new NhanVien("Tran Thi Bich", 12000000, 0));
            pb.Add(new NhanVien("Le Van Canh", 9000000, 3));

            pb.Xuat();

            double tongLuong = pb.TinhTongLuong();
            Console.WriteLine($"\nTong luong cua toan bo phong ban: {tongLuong:N0} VND");
        }
    }
}
