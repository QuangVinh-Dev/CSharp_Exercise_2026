using System;

namespace Lab01.Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 02: XUAT VA NHAP CHUOI ===");
            
            // Nhap ho ten theo dinh dang yeu cau cua de bai
            Console.Write("Nhap ho ten cua ban: ");
            string? hoTen = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                hoTen = "Tran Anh Minh";
                Console.WriteLine(hoTen);
            }

            // Xuat loi chao theo dung dinh dang: Chao ban Tran Anh Minh!
            Console.WriteLine($"Chao ban {hoTen}!");
        }
    }
}
