using System;

namespace Lab01.Bai09
{
    // Lop tim max min su dung tham chieu out
    public class ThongKeSoThuc
    {
        // Phuong thuc tra ve ca max va min thong qua tham so out
        public void TimMaxMin(double a, double b, double c, out double max, out double min)
        {
            max = a;
            min = a;

            if (b > max) max = b;
            if (c > max) max = c;

            if (b < min) min = b;
            if (c < min) min = c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 09: THAM CHIEU OUT - TIM MAX VA MIN CUA 3 SO THUC ===");

            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine() ?? "4.5");
            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine() ?? "12.8");
            Console.Write("Nhap so thuc c: ");
            double c = double.Parse(Console.ReadLine() ?? "1.2");

            ThongKeSoThuc tk = new ThongKeSoThuc();
            // Khai bao bien out nhan ket qua
            tk.TimMaxMin(a, b, c, out double max, out double min);

            Console.WriteLine($"Ba so da nhap: a = {a}, b = {b}, c = {c}");
            Console.WriteLine($"Gia tri lon nhat (max): {max}");
            Console.WriteLine($"Gia tri nho nhat (min): {min}");
        }
    }
}
