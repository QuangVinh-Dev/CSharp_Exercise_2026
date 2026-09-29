using System;

namespace Lab02.Bai01_1
{
    // Lop SinhVien quan ly ho ten va nam sinh de tinh tuoi
    public class SinhVien
    {
        // Field
        private string hoTen = "";
        private int namSinh;

        // Property
        public string HoTen
        {
            get => hoTen;
            set => hoTen = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        // Constructor mac nhien
        public SinhVien() { }

        // Constructor co tham so
        public SinhVien(string hoTen, int namSinh)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
        }

        // Nhap thong tin sinh vien tu ban phim
        public void Nhap()
        {
            Console.Write("Nhap ho ten sinh vien: ");
            hoTen = Console.ReadLine() ?? "Tran Van Bao";
            Console.Write("Nhap nam sinh: ");
            int.TryParse(Console.ReadLine(), out namSinh);
            if (namSinh <= 0) namSinh = 2004;
        }

        // Tinh tuoi sinh vien dua tren nam hien tai
        public int TinhTuoi(int namHienTai = 2026)
        {
            return namHienTai - namSinh;
        }

        public void Xuat()
        {
            Console.WriteLine($"Ho ten: {hoTen} | Nam sinh: {namSinh} | Tuoi: {TinhTuoi()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 1.1: TINH TUOI 1 SINH VIEN ===");

            SinhVien sv = new SinhVien();
            sv.Nhap();
            Console.WriteLine("\n--- Thong tin va tuoi cua sinh vien ---");
            sv.Xuat();
        }
    }
}
