using System;

namespace Lab01.Bai08
{
    // Lop chua phuong thuc hoan vi
    public class HoanViSoThuc
    {
        // Su dung tham chieu ref de hoan vi gia tri hai bien thuc
        public void HoanVi(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 08: THAM CHIEU REF - HOAN VI HAI SO THUC ===");
            
            Console.Write("Nhap so thuc a: ");
            double a = double.Parse(Console.ReadLine() ?? "3.14");
            Console.Write("Nhap so thuc b: ");
            double b = double.Parse(Console.ReadLine() ?? "9.81");

            Console.WriteLine($"Truoc khi hoan vi: a = {a}, b = {b}");

            HoanViSoThuc hv = new HoanViSoThuc();
            // Goi phuong thuc voi tu khoa ref
            hv.HoanVi(ref a, ref b);

            Console.WriteLine($"Sau khi hoan vi:  a = {a}, b = {b}");
        }
    }
}
