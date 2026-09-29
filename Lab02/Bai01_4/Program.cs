using System;

namespace Lab02.Bai01_4
{
    // Lop PhanSo bieu dien va tinh toan phan so
    public class PhanSo
    {
        // Field
        private int tuSo;
        private int mauSo;

        // Property
        public int TuSo { get => tuSo; set => tuSo = value; }
        public int MauSo
        {
            get => mauSo;
            set
            {
                if (value == 0) throw new ArgumentException("Mau so khong the bang 0.");
                mauSo = value;
            }
        }

        // Constructor mac nhien (0/1)
        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }

        // Constructor co tham so
        public PhanSo(int tu, int mau)
        {
            if (mau == 0) throw new ArgumentException("Mau so khong the bang 0.");
            this.tuSo = tu;
            this.mauSo = mau;
            RutGon();
        }

        // Constructor sao chep
        public PhanSo(PhanSo other)
        {
            this.tuSo = other.tuSo;
            this.mauSo = other.mauSo;
        }

        // Tim uoc chung lon nhat bang thuat toan Euclid
        private static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        // Rut gon phan so ve dang toi gian
        public void RutGon()
        {
            int u = UCLN(tuSo, mauSo);
            tuSo /= u;
            mauSo /= u;
            if (mauSo < 0)
            {
                tuSo = -tuSo;
                mauSo = -mauSo;
            }
        }

        // Override ToString() de xuat phan so
        public override string ToString()
        {
            if (mauSo == 1) return tuSo.ToString();
            if (tuSo == 0) return "0";
            return $"{tuSo}/{mauSo}";
        }

        // Overload toan tu mot ngoi: Duong (+) va Am (-)
        public static PhanSo operator +(PhanSo a) => new PhanSo(a.tuSo, a.mauSo);
        public static PhanSo operator -(PhanSo a) => new PhanSo(-a.tuSo, a.mauSo);

        // Overload toan tu hai ngoi: +, -, *, /
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tuSo * b.mauSo + b.tuSo * a.mauSo, a.mauSo * b.mauSo);
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tuSo * b.mauSo - b.tuSo * a.mauSo, a.mauSo * b.mauSo);
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            return new PhanSo(a.tuSo * b.tuSo, a.mauSo * b.mauSo);
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            if (b.tuSo == 0) throw new DivideByZeroException("Khong the chia cho phan so bang 0.");
            return new PhanSo(a.tuSo * b.mauSo, a.mauSo * b.tuSo);
        }

        // Overload toan tu so sanh: >, <, >=, <=, ==, !=
        public static bool operator >(PhanSo a, PhanSo b) => a.tuSo * b.mauSo > b.tuSo * a.mauSo;
        public static bool operator <(PhanSo a, PhanSo b) => a.tuSo * b.mauSo < b.tuSo * a.mauSo;
        public static bool operator >=(PhanSo a, PhanSo b) => a.tuSo * b.mauSo >= b.tuSo * a.mauSo;
        public static bool operator <=(PhanSo a, PhanSo b) => a.tuSo * b.mauSo <= b.tuSo * a.mauSo;
        public static bool operator ==(PhanSo a, PhanSo b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.tuSo * b.mauSo == b.tuSo * a.mauSo;
        }
        public static bool operator !=(PhanSo a, PhanSo b) => !(a == b);

        public override bool Equals(object? obj)
        {
            if (obj is PhanSo p) return this == p;
            return false;
        }

        public override int GetHashCode() => (tuSo, mauSo).GetHashCode();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 1.4: THIET KE LOP PHAN SO VA OVERLOAD TOAN TU ===");

            PhanSo p1 = new PhanSo(1, 2);
            PhanSo p2 = new PhanSo(3, 4);

            Console.WriteLine($"Phan so p1: {p1}");
            Console.WriteLine($"Phan so p2: {p2}");

            Console.WriteLine("\n--- Phep toan mot ngoi ---");
            Console.WriteLine($"+p1 = {+p1}");
            Console.WriteLine($"-p1 = {-p1}");

            Console.WriteLine("\n--- Phep toan hai ngoi ---");
            Console.WriteLine($"{p1} + {p2} = {p1 + p2}");
            Console.WriteLine($"{p1} - {p2} = {p1 - p2}");
            Console.WriteLine($"{p1} * {p2} = {p1 * p2}");
            Console.WriteLine($"{p1} / {p2} = {p1 / p2}");

            Console.WriteLine("\n--- Phep toan so sanh ---");
            Console.WriteLine($"{p1} > {p2}  : {p1 > p2}");
            Console.WriteLine($"{p1} < {p2}  : {p1 < p2}");
            Console.WriteLine($"{p1} == {p2} : {p1 == p2}");
            Console.WriteLine($"{p1} != {p2} : {p1 != p2}");
        }
    }
}
