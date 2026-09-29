using System;

namespace Lab01.Bai13
{
    // Lop sinh vien co ban
    public class SinhVien
    {
        private string maSV = "";
        private string hoTen = "";
        private string diaChi = "";
        private int namThu;

        // Constructor mac nhien
        public SinhVien() { }

        // Constructor co tham so
        public SinhVien(string maSV, string hoTen, string diaChi, int namThu)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.namThu = namThu;
        }

        // Nhap thong tin mot sinh vien
        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien: ");
            maSV = Console.ReadLine() ?? "SV001";
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine() ?? "Nguyen Van A";
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine() ?? "Ha Noi";
            Console.Write("Nhap sinh vien nam thu may: ");
            int.TryParse(Console.ReadLine(), out namThu);
        }

        // Xuat thong tin sinh vien
        public void Xuat()
        {
            Console.WriteLine($"Ma SV: {maSV} | Ho ten: {hoTen} | Dia chi: {diaChi} | Sinh vien nam: {namThu}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 13: XAY DUNG LOP SINH VIEN CO BAN ===");
            
            SinhVien sv = new SinhVien();
            sv.Nhap();
            Console.WriteLine("\n--- Thong tin sinh vien vua nhap ---");
            sv.Xuat();
        }
    }
}
