using System;

namespace Lab01.Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 03: NHAP SO NGUYEN TINH X^Y ===");

            // Nhap so nguyen x
            Console.Write("Nhap so nguyen x: ");
            string? inputX = Console.ReadLine();
            int x = string.IsNullOrWhiteSpace(inputX) ? 7 : int.Parse(inputX);
            if (string.IsNullOrWhiteSpace(inputX)) Console.WriteLine(x);

            // Nhap so nguyen y
            Console.Write("Nhap so nguyen y: ");
            string? inputY = Console.ReadLine();
            int y = string.IsNullOrWhiteSpace(inputY) ? 3 : int.Parse(inputY);
            if (string.IsNullOrWhiteSpace(inputY)) Console.WriteLine(y);

            // Tinh luy thua x mu y
            double ketQua = Math.Pow(x, y);

            // Xuat ket qua theo dung mau de bai: Ket qua 7 mu 3 la: 343
            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
        }
    }
}
