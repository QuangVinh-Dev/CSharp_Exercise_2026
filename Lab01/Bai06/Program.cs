using System;

namespace Lab01.Bai06
{
    // Lop chua phuong thuc xu ly toan hoc
    public class PhepToan
    {
        // Phuong thuc tim gia tri lon nhat cua ba so nguyen bang cach return gia tri
        public int TimMax(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 06: RETURN GIA TRI - TIM MAX 3 SO NGUYEN ===");
            
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine() ?? "15");
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine() ?? "42");
            Console.Write("Nhap so thu ba: ");
            int c = int.Parse(Console.ReadLine() ?? "28");

            PhepToan pt = new PhepToan();
            int max = pt.TimMax(a, b, c);

            Console.WriteLine($"Gia tri lon nhat giua {a}, {b}, {c} la: {max}");
        }
    }
}
