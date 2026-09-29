using System;

namespace Lab01.Bai16
{
    // Lop quan ly mang ho ten
    public class DanhSachHoTen
    {
        private string[] ds = Array.Empty<string>();

        // Nhap vao mot mang ho ten cua n nguoi
        public void Nhap()
        {
            Console.Write("Nhap so luong nguoi n: ");
            int n = int.Parse(Console.ReadLine() ?? "4");
            ds = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap ho ten nguoi thu {i + 1}: ");
                ds[i] = Console.ReadLine() ?? $"Nguoi {i + 1}";
            }
        }

        // Sap xep mang ho ten theo thu tu tang dan
        public void SapXepTangDan()
        {
            Array.Sort(ds);
        }

        public void Xuat()
        {
            for (int i = 0; i < ds.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {ds[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 16: MANG HO TEN VA SAP XEP TANG DAN ===");
            
            DanhSachHoTen ql = new DanhSachHoTen();
            ql.Nhap();

            Console.WriteLine("\n--- Danh sach truoc khi sap xep ---");
            ql.Xuat();

            // Thuc hien sap xep tang dan theo alphabet
            ql.SapXepTangDan();

            Console.WriteLine("\n--- Danh sach sau khi sap xep tang dan ---");
            ql.Xuat();
        }
    }
}
