using System;

namespace Lab01.Bai04
{
    class Program
    {
        // Phuong thuc nhap so nguyen an toan voi kiem tra hop le
        static int NhapSoNguyen(string thongBao)
        {
            int giaTri;
            while (true)
            {
                Console.Write(thongBao);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out giaTri))
                {
                    return giaTri;
                }
                // Thong bao loi khi du lieu khong phai so nguyen
                Console.WriteLine("Loi: Gia tri nhap vao khong phai la so nguyen hop le. Vui long nhap lai!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 04: NHAP SO NGUYEN CO KIEM TRA LOI ===");

            int x = NhapSoNguyen("Nhap so nguyen x: ");
            int y = NhapSoNguyen("Nhap so nguyen y: ");

            // Tinh x mu y sau khi da kiem tra du lieu dau vao
            double ketQua = Math.Pow(x, y);
            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
        }
    }
}
