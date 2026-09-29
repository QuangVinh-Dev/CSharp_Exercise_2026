using System;

namespace Lab02.Bai03_1
{
    // Lop SinhVien cai dat IComparable de sap xep bang Array.Sort
    public class SinhVien : IComparable<SinhVien>
    {
        public string MaSV { get; set; } = "";
        public string HoTen { get; set; } = "";
        public double DiemTB { get; set; }

        public SinhVien(string maSV, string hoTen, double diemTB)
        {
            MaSV = maSV;
            HoTen = hoTen;
            DiemTB = diemTB;
        }

        // Cai dat phuong thuc CompareTo cua interface IComparable<SinhVien>
        // Sap xep theo diem trung binh tang dan
        public int CompareTo(SinhVien? other)
        {
            if (other is null) return 1;
            return this.DiemTB.CompareTo(other.DiemTB);
        }

        public override string ToString() => $"Ma SV: {MaSV,-8} | Ho ten: {HoTen,-20} | Diem TB: {DiemTB,4:F1}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 3.1: DUNG PHUONG THUC TINH ARRAY.SORT QUA ICOMPARABLE ===");

            SinhVien[] danhSach = new SinhVien[]
            {
                new SinhVien("SV03", "Tran Van Chien", 7.5),
                new SinhVien("SV01", "Nguyen Van An", 8.8),
                new SinhVien("SV04", "Pham Thi Dung", 6.2),
                new SinhVien("SV02", "Le Thi Binh", 9.1)
            };

            Console.WriteLine("Danh sach truoc khi sap xep:");
            foreach (var sv in danhSach) Console.WriteLine(sv);

            // Su dung phuong thuc tinh Array.Sort(...) de sap xep
            Array.Sort(danhSach);

            Console.WriteLine("\nDanh sach sau khi sap xep tang dan theo DiemTB bang Array.Sort():");
            foreach (var sv in danhSach) Console.WriteLine(sv);
        }
    }
}
