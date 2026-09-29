using System;
using System.Collections.Generic;

namespace Lab02.Bai02_4
{
    // Lop mang 2 chieu nxm
    public class MangHaiChieu
    {
        private int[,] a;
        private int rows;
        private int cols;

        // a. Default constructor
        public MangHaiChieu()
        {
            rows = 0;
            cols = 0;
            a = new int[0, 0];
        }

        // a. Constructor kich thuoc nxm
        public MangHaiChieu(int n, int m)
        {
            rows = n;
            cols = m;
            a = new int[n, m];
        }

        // a. Copy constructor
        public MangHaiChieu(MangHaiChieu other)
        {
            rows = other.rows;
            cols = other.cols;
            a = (int[,])other.a.Clone();
        }

        public int Rows => rows;
        public int Cols => cols;

        // b. Indexer 2 chieu de truy cap phan tu tai (i, j)
        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= rows || j < 0 || j >= cols)
                    throw new IndexOutOfRangeException("Chi so hang hoac cot vuot ngoai pham vi.");
                return a[i, j];
            }
            set
            {
                if (i < 0 || i >= rows || j < 0 || j >= cols)
                    throw new IndexOutOfRangeException("Chi so hang hoac cot vuot ngoai pham vi.");
                a[i, j] = value;
            }
        }

        // c. Nhap ma tran
        public void Nhap()
        {
            Console.Write("Nhap so hang n: ");
            int.TryParse(Console.ReadLine(), out rows);
            Console.Write("Nhap so cot m: ");
            int.TryParse(Console.ReadLine(), out cols);
            a = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Nhap a[{i},{j}]: ");
                    int.TryParse(Console.ReadLine(), out a[i, j]);
                }
            }
        }

        // c. Xuat ma tran
        public void Xuat()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{a[i, j], 5} ");
                }
                Console.WriteLine();
            }
        }

        // Ham phu kiem tra so nguyen to
        private static bool LaNguyenTo(int x)
        {
            if (x < 2) return false;
            for (int k = 2; k * k <= x; k++)
            {
                if (x % k == 0) return false;
            }
            return true;
        }

        // d. Tim cac so nguyen to trong mang
        public int[] TimCacSoNguyenTo()
        {
            List<int> snt = new List<int>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (LaNguyenTo(a[i, j]))
                    {
                        snt.Add(a[i, j]);
                    }
                }
            }
            return snt.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 2.4: LOP CHUA MANG 2 CHIEU ===");

            MangHaiChieu m = new MangHaiChieu(2, 3);
            m[0, 0] = 3;  m[0, 1] = 4;  m[0, 2] = 5;
            m[1, 0] = 11; m[1, 1] = 15; m[1, 2] = 17;

            Console.WriteLine("Ma tran 2x3:");
            m.Xuat();

            // Minh hoa Indexer
            Console.WriteLine($"\nGia tri m[1, 0] qua Indexer: {m[1, 0]}");

            // Tim so nguyen to
            int[] snt = m.TimCacSoNguyenTo();
            Console.WriteLine("Cac so nguyen to trong ma tran: " + string.Join(", ", snt));
        }
    }
}
