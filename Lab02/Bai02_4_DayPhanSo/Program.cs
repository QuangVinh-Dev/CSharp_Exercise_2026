using System;

namespace Lab02.Bai02_4_DayPhanSo
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo(int tu = 0, int mau = 1)
        {
            if (mau == 0) throw new ArgumentException("Mau so phai khac 0.");
            TuSo = tu;
            MauSo = mau;
            RutGon();
        }

        private static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0) { int r = a % b; a = b; b = r; }
            return a;
        }

        public void RutGon()
        {
            int u = UCLN(TuSo, MauSo);
            TuSo /= u;
            MauSo /= u;
            if (MauSo < 0) { TuSo = -TuSo; MauSo = -MauSo; }
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.TuSo * b.MauSo + b.TuSo * a.MauSo, a.MauSo * b.MauSo);
        }

        public override string ToString() => MauSo == 1 ? $"{TuSo}" : $"{TuSo}/{MauSo}";
    }

    // Lop chua n phan so
    public class DayPhanSo
    {
        private PhanSo[] danhSach;

        public DayPhanSo(int n = 0)
        {
            danhSach = new PhanSo[n];
        }

        public DayPhanSo(PhanSo[] arr)
        {
            danhSach = (PhanSo[])arr.Clone();
        }

        // Indexer truy cap phan so thu i
        public PhanSo this[int i]
        {
            get => danhSach[i];
            set => danhSach[i] = value;
        }

        public int Count => danhSach.Length;

        public void Nhap()
        {
            Console.Write("Nhap so luong phan so n: ");
            int.TryParse(Console.ReadLine(), out int n);
            danhSach = new PhanSo[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Phan so thu {i + 1}:");
                Console.Write("  Tu so: ");
                int.TryParse(Console.ReadLine(), out int tu);
                Console.Write("  Mau so: ");
                int.TryParse(Console.ReadLine(), out int mau);
                danhSach[i] = new PhanSo(tu, mau);
            }
        }

        public void Xuat()
        {
            Console.WriteLine("Day phan so: " + string.Join(", ", (object[])danhSach));
        }

        // Tinh tong cua n phan so trong day
        public PhanSo TinhTong()
        {
            PhanSo tong = new PhanSo(0, 1);
            foreach (var ps in danhSach)
            {
                tong = tong + ps;
            }
            return tong;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 2.4 (TRANG 3): DAY PHAN SO VA TINH TONG ===");

            DayPhanSo day = new DayPhanSo(new PhanSo[] {
                new PhanSo(1, 2),
                new PhanSo(1, 3),
                new PhanSo(1, 6)
            });

            day.Xuat();
            PhanSo tong = day.TinhTong();
            Console.WriteLine($"Tong day phan so la: {tong}");
        }
    }
}
