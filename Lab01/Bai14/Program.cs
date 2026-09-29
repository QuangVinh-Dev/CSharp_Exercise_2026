using System;

namespace Lab01.Bai14
{
    // Lop dai dien cho 1 nhan vien
    public class NhanVien
    {
        private string hoTen = "";
        private double mucLuong;
        private int soNgayVang;

        // Constructor khoi tao
        public NhanVien(string hoTen, double mucLuong, int soNgayVang)
        {
            this.hoTen = hoTen;
            this.mucLuong = mucLuong;
            this.soNgayVang = soNgayVang;
        }

        public NhanVien() { }

        // Nhap thong tin nhan vien
        public void Nhap()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            hoTen = Console.ReadLine() ?? "Nguyen Van B";
            Console.Write("Nhap muc luong: ");
            double.TryParse(Console.ReadLine(), out mucLuong);
            Console.Write("Nhap so ngay vang: ");
            int.TryParse(Console.ReadLine(), out soNgayVang);
        }

        // Tinh luong thuc lanh voi muc phat 100.000 cho moi ngay vang
        public double TinhLuong()
        {
            double luong = mucLuong - (soNgayVang * 100000);
            return luong > 0 ? luong : 0;
        }

        public void Xuat()
        {
            Console.WriteLine($"Ho ten: {hoTen} | Muc luong goc: {mucLuong:N0} VND | So ngay vang: {soNgayVang} | Luong thuc lanh: {TinhLuong():N0} VND");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 14: TINH LUONG MOT NHAN VIEN ===");
            
            NhanVien nv = new NhanVien();
            nv.Nhap();
            Console.WriteLine("\n--- Ket qua tinh luong ---");
            nv.Xuat();
        }
    }
}
