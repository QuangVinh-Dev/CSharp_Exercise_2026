using System;

namespace Lab02.Bai01_5
{
    // Lop DonThuc bieu dien P(x) = a * x^n
    public class DonThuc
    {
        // Field
        private double heSo;
        private int soMu;

        // Property
        public double HeSo { get => heSo; set => heSo = value; }
        public int SoMu
        {
            get => soMu;
            set
            {
                if (value < 0) throw new ArgumentException("So mu phai la so nguyen khong am.");
                soMu = value;
            }
        }

        // Constructor mac nhien
        public DonThuc()
        {
            heSo = 0;
            soMu = 0;
        }

        // Constructor co tham so
        public DonThuc(double heSo, int soMu)
        {
            this.heSo = heSo;
            this.soMu = soMu < 0 ? 0 : soMu;
        }

        // Nhap don thuc
        public void Nhap()
        {
            Console.Write("Nhap he so a: ");
            double.TryParse(Console.ReadLine(), out heSo);
            Console.Write("Nhap so mu n (>= 0): ");
            int.TryParse(Console.ReadLine(), out soMu);
            if (soMu < 0) soMu = 0;
        }

        // (a) Tinh gia tri don thuc P(x) voi x cho truoc
        public double TinhGiaTri(double x)
        {
            return heSo * Math.Pow(x, soMu);
        }

        // (b) Dao ham don thuc Q(x) = P'(x) = a * n * x^(n-1)
        public DonThuc DaoHam()
        {
            if (soMu == 0)
            {
                // Dao ham cua hang so bang 0
                return new DonThuc(0, 0);
            }
            return new DonThuc(heSo * soMu, soMu - 1);
        }

        public override string ToString()
        {
            if (heSo == 0) return "0";
            if (soMu == 0) return $"{heSo}";
            if (soMu == 1) return $"{heSo}x";
            return $"{heSo}x^{soMu}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 1.5: XAY DUNG LOP DON THUC ===");

            DonThuc dt = new DonThuc();
            dt.Nhap();

            Console.WriteLine($"\nDon thuc vua nhap: P(x) = {dt}");

            // (a) Tinh gia tri tai x cho truoc
            Console.Write("Nhap gia tri x de tinh P(x): ");
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine($"Gia tri P({x}) = {dt.TinhGiaTri(x)}");

            // (b) Dao ham don thuc
            DonThuc dh = dt.DaoHam();
            Console.WriteLine($"Dao ham Q(x) = P'(x) = {dh}");
        }
    }
}
