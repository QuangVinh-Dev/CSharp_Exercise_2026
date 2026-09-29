using System;
using System.Collections.Generic;

namespace Lab02.Bai03_6
{
    // Lop co so ThiSinh
    public class ThiSinh
    {
        public string Sbd { get; set; } = "";
        public string HoTen { get; set; } = "";
        public double Bai1 { get; set; }
        public double Bai2 { get; set; }
        public double Bai3 { get; set; }
        public double TongDiem { get; protected set; }

        public ThiSinh() { }

        public ThiSinh(string sbd, string hoTen, double b1, double b2, double b3)
        {
            Sbd = sbd;
            HoTen = hoTen;
            Bai1 = b1;
            Bai2 = b2;
            Bai3 = b3;
        }

        // Phuong thuc ao tinh tong diem de lop con override
        public virtual double TinhTongDiem()
        {
            TongDiem = Bai1 + Bai2 + Bai3;
            return TongDiem;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap so bao danh (SBD): ");
            Sbd = Console.ReadLine() ?? "";
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine() ?? "";
            Console.Write("Diem bai 1: ");
            double.TryParse(Console.ReadLine(), out double b1); Bai1 = b1;
            Console.Write("Diem bai 2: ");
            double.TryParse(Console.ReadLine(), out double b2); Bai2 = b2;
            Console.Write("Diem bai 3: ");
            double.TryParse(Console.ReadLine(), out double b3); Bai3 = b3;
        }

        public virtual void Xuat()
        {
            Console.Write($"SBD: {Sbd,-6} | Ho ten: {HoTen,-18} | B1: {Bai1,4:F1} | B2: {Bai2,4:F1} | B3: {Bai3,4:F1} ");
        }
    }

    // Thi sinh Chuyen: cong diem thuong Tieng Anh
    public class ThiSinhChuyen : ThiSinh
    {
        public double TiengAnh { get; set; }

        public ThiSinhChuyen() { }

        public ThiSinhChuyen(string sbd, string hoTen, double b1, double b2, double b3, double tiengAnh)
            : base(sbd, hoTen, b1, b2, b3)
        {
            TiengAnh = tiengAnh;
            TinhTongDiem();
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Diem Tieng Anh: ");
            double.TryParse(Console.ReadLine(), out double ta);
            TiengAnh = ta;
            TinhTongDiem();
        }

        // Tinh tong diem thi sinh Chuyen: Tong 3 bai + diem thuong Tieng Anh
        public override double TinhTongDiem()
        {
            double diemThuong = 0;
            if (TiengAnh >= 7 && TiengAnh <= 8) diemThuong = 1.0;
            else if (TiengAnh > 8 && TiengAnh <= 10) diemThuong = 2.0;

            TongDiem = Bai1 + Bai2 + Bai3 + diemThuong;
            return TongDiem;
        }

        public override void Xuat()
        {
            base.Xuat();
            double diemThuong = (TiengAnh >= 7 && TiengAnh <= 8) ? 1.0 : (TiengAnh > 8 && TiengAnh <= 10 ? 2.0 : 0);
            Console.WriteLine($"| Tieng Anh: {TiengAnh,4:F1} (Thuong +{diemThuong}) | Tong: {TongDiem,4:F1} [Chuyen]");
        }
    }

    // Thi sinh Sieu cup: tong 4 bai (3 bai lap trinh + bai CSDL)
    public class ThiSinhSieuCup : ThiSinh
    {
        public double Csdl { get; set; }

        public ThiSinhSieuCup() { }

        public ThiSinhSieuCup(string sbd, string hoTen, double b1, double b2, double b3, double csdl)
            : base(sbd, hoTen, b1, b2, b3)
        {
            Csdl = csdl;
            TinhTongDiem();
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Diem CSDL: ");
            double.TryParse(Console.ReadLine(), out double cs);
            Csdl = cs;
            TinhTongDiem();
        }

        // Tinh tong diem thi sinh Sieu Cup: Tong 4 bai thi
        public override double TinhTongDiem()
        {
            TongDiem = Bai1 + Bai2 + Bai3 + Csdl;
            return TongDiem;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"| CSDL: {Csdl,4:F1}                  | Tong: {TongDiem,4:F1} [Sieu Cup]");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 3.6: KE THUA VA DA HINH - TINH DIEM THI SINH ===");

            List<ThiSinh> cuocThi = new List<ThiSinh>
            {
                new ThiSinhChuyen("C01", "Vo Hoang Yen", 8.0, 7.5, 9.0, 7.5),
                new ThiSinhChuyen("C02", "Dang Van Lam", 6.5, 8.0, 7.0, 9.5),
                new ThiSinhSieuCup("S01", "Nguyen Quang Hai", 9.0, 9.5, 8.5, 9.0),
                new ThiSinhSieuCup("S02", "Do Hung Dung", 8.0, 8.5, 8.0, 7.5)
            };

            Console.WriteLine("\n--- KET QUA CUOC THI TIN HOC ---");
            foreach (var ts in cuocThi)
            {
                ts.TinhTongDiem();
                ts.Xuat();
            }
        }
    }
}
