using System;
using System.Text;

namespace Lab02.Bai02_3_DaThuc
{
    // Lop DonThuc thanh phan
    public class DonThuc
    {
        public double HeSo { get; set; }
        public int SoMu { get; set; }

        public DonThuc(double heSo, int soMu)
        {
            HeSo = heSo;
            SoMu = soMu;
        }

        public double TinhGiaTri(double x) => HeSo * Math.Pow(x, SoMu);
    }

    // Lop DaThuc gom n+1 don thuc tu bac 0 den bac n
    public class DaThuc
    {
        private DonThuc[] donThucs;
        private int bac;

        // a. Constructor mac nhien
        public DaThuc()
        {
            bac = 0;
            donThucs = new DonThuc[] { new DonThuc(0, 0) };
        }

        // a. Constructor bac n
        public DaThuc(int n)
        {
            bac = n < 0 ? 0 : n;
            donThucs = new DonThuc[bac + 1];
            for (int i = 0; i <= bac; i++)
            {
                donThucs[i] = new DonThuc(0, i);
            }
        }

        // a. Copy constructor
        public DaThuc(DaThuc other)
        {
            this.bac = other.bac;
            this.donThucs = new DonThuc[other.donThucs.Length];
            for (int i = 0; i <= bac; i++)
            {
                this.donThucs[i] = new DonThuc(other.donThucs[i].HeSo, other.donThucs[i].SoMu);
            }
        }

        public int Bac => bac;

        // b. Indexer de truy cap don thuc thu i
        public DonThuc this[int i]
        {
            get
            {
                if (i < 0 || i > bac)
                    throw new IndexOutOfRangeException("Bac khong hop le.");
                return donThucs[i];
            }
            set
            {
                if (i < 0 || i > bac)
                    throw new IndexOutOfRangeException("Bac khong hop le.");
                donThucs[i] = value;
            }
        }

        // c. Nhap da thuc tu ban phim
        public void Nhap()
        {
            Console.Write("Nhap bac cua da thuc n: ");
            int.TryParse(Console.ReadLine(), out bac);
            if (bac < 0) bac = 0;
            donThucs = new DonThuc[bac + 1];
            for (int i = 0; i <= bac; i++)
            {
                Console.Write($"Nhap he so a[{i}] cua x^{i}: ");
                double.TryParse(Console.ReadLine(), out double a);
                donThucs[i] = new DonThuc(a, i);
            }
        }

        // c. Xuat da thuc
        public void Xuat()
        {
            StringBuilder sb = new StringBuilder();
            bool first = true;
            for (int i = 0; i <= bac; i++)
            {
                double a = donThucs[i].HeSo;
                if (a == 0 && bac > 0) continue;

                if (!first && a > 0) sb.Append(" + ");
                else if (!first && a < 0) sb.Append(" - ");
                else if (first && a < 0) sb.Append("-");

                double absA = Math.Abs(a);
                if (i == 0) sb.Append(absA);
                else if (i == 1) sb.Append(absA == 1 ? "x" : $"{absA}x");
                else sb.Append(absA == 1 ? $"x^{i}" : $"{absA}x^{i}");

                first = false;
            }
            Console.WriteLine(sb.Length > 0 ? sb.ToString() : "0");
        }

        // d. Tinh gia tri cua da thuc tai x
        public double TinhGiaTri(double x)
        {
            double sum = 0;
            for (int i = 0; i <= bac; i++)
            {
                sum += donThucs[i].TinhGiaTri(x);
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 2.3 (TRANG 2): LOP DA THUC ===");

            DaThuc dt = new DaThuc(2);
            // P(x) = 3 + 2x + 5x^2
            dt[0] = new DonThuc(3, 0);
            dt[1] = new DonThuc(2, 1);
            dt[2] = new DonThuc(5, 2);

            Console.Write("Da thuc P(x) = ");
            dt.Xuat();

            double x = 2.0;
            Console.WriteLine($"Gia tri P({x}) = {dt.TinhGiaTri(x)}");
        }
    }
}
