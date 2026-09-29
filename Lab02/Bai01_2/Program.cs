using System;

namespace Lab02.Bai01_2
{
    // Lop Point bieu dien toa do diem trong mat phang 2D
    public class Point
    {
        // Field
        private double x;
        private double y;

        // Property
        public double X
        {
            get => x;
            set => x = value;
        }

        public double Y
        {
            get => y;
            set => y = value;
        }

        // Default constructor khoi tao gia tri ban dau bang 0
        public Point()
        {
            x = 0;
            y = 0;
        }

        // Constructor co tham so
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Copy constructor
        public Point(Point other)
        {
            this.x = other.x;
            this.y = other.y;
        }

        // Nhap toa do diem
        public void Input()
        {
            Console.Write("Nhap hoanh do x: ");
            double.TryParse(Console.ReadLine(), out x);
            Console.Write("Nhap tung do y: ");
            double.TryParse(Console.ReadLine(), out y);
        }

        // Xuat toa do diem
        public void Output()
        {
            Console.WriteLine(ToString());
        }

        // Override ham ToString()
        public override string ToString()
        {
            return $"({x}, {y})";
        }

        // Operator overloading: Lay am mot ngoi (-)
        public static Point operator -(Point p)
        {
            return new Point(-p.x, -p.y);
        }

        // Operator overloading: Cong hai diem (+)
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        // Operator overloading: Tru hai diem (-)
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }

        // (a) Khoang cach giua 2 diem: Phuong thuc thanh vien
        public double Distance(Point b)
        {
            double dx = this.x - b.x;
            double dy = this.y - b.y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // (a) Khoang cach giua 2 diem: Phuong thuc tinh
        public static double Distance(Point a, Point b)
        {
            return a.Distance(b);
        }

        // (b) Trung diem cua 2 diem: Phuong thuc thanh vien
        public Point Midpoint(Point b)
        {
            return new Point((this.x + b.x) / 2.0, (this.y + b.y) / 2.0);
        }

        // (b) Trung diem cua 2 diem: Phuong thuc tinh
        public static Point Midpoint(Point a, Point b)
        {
            return a.Midpoint(b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 1.2: THIET KE LOP POINT ===");

            Console.WriteLine("Nhap toa do diem A:");
            Point a = new Point();
            a.Input();

            Console.WriteLine("Nhap toa do diem B:");
            Point b = new Point();
            b.Input();

            Console.WriteLine($"\nDiem A: {a}");
            Console.WriteLine($"Diem B: {b}");
            Console.WriteLine($"Lay am diem A (-A): {-a}");
            Console.WriteLine($"Tong hai diem (A + B): {a + b}");
            Console.WriteLine($"Hieu hai diem (A - B): {a - b}");

            // Tinh khoang cach theo 2 cach
            Console.WriteLine("\n--- (a) Tinh khoang cach ---");
            Console.WriteLine($"Khoang cach (phuong thuc thanh vien A.Distance(B)): {a.Distance(b):F4}");
            Console.WriteLine($"Khoang cach (phuong thuc tinh Point.Distance(A, B)): {Point.Distance(a, b):F4}");

            // Tinh trung diem theo 2 cach
            Console.WriteLine("\n--- (b) Xac dinh trung diem ---");
            Console.WriteLine($"Trung diem (phuong thuc thanh vien A.Midpoint(B)): {a.Midpoint(b)}");
            Console.WriteLine($"Trung diem (phuong thuc tinh Point.Midpoint(A, B)): {Point.Midpoint(a, b)}");
        }
    }
}
