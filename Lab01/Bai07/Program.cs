using System;

namespace Lab01.Bai07
{
    // Lop kiem tra so hoc
    public class KiemTraSoHoc
    {
        // Phuong thuc bool kiem tra so nguyen to
        public bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            // Kiem tra uoc so tu 2 den can bac 2 cua n
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 07: PHUONG THUC BOOL - KIEM TRA SO NGUYEN TO ===");
            
            Console.Write("Nhap so nguyen n can kiem tra: ");
            string? input = Console.ReadLine();
            int n = string.IsNullOrWhiteSpace(input) ? 17 : int.Parse(input);

            KiemTraSoHoc kt = new KiemTraSoHoc();
            bool laSNT = kt.KiemTraNguyenTo(n);

            if (laSNT)
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
        }
    }
}
