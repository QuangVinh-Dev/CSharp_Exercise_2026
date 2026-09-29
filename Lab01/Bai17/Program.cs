using System;
using System.Collections.Generic;

namespace Lab01.Bai17
{
    // Lop quan ly mang hai chieu ngau nhien
    public class MaTranNgauNhien
    {
        private int[,] a = new int[0, 0];
        private int n;
        private int m;

        // Sinh ngau nhien mang A[nxm] trong doan [10, 100]
        public void SinhNgauNhien(int n, int m)
        {
            this.n = n;
            this.m = m;
            a = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Khoi tao ngau nhien tu 10 den 100
                    a[i, j] = rnd.Next(10, 101);
                }
            }
        }

        // In mang hai chieu ra man hinh
        public void InMang()
        {
            Console.WriteLine($"Ma tran A[{n}x{m}]:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i, j],5} ");
                }
                Console.WriteLine();
            }
        }

        // Tra ve hai mang: mang cac so chan va mang cac so le
        public void TachChanLe(out int[] mangChan, out int[] mangLe)
        {
            List<int> chan = new List<int>();
            List<int> le = new List<int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] % 2 == 0) chan.Add(a[i, j]);
                    else le.Add(a[i, j]);
                }
            }

            mangChan = chan.ToArray();
            mangLe = le.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 17: MANG 2 CHIEU NGAU NHIEN VA TACH CHAN LE ===");

            Console.Write("Nhap so dong n: ");
            int n = int.Parse(Console.ReadLine() ?? "3");
            Console.Write("Nhap so cot m: ");
            int m = int.Parse(Console.ReadLine() ?? "4");

            MaTranNgauNhien mt = new MaTranNgauNhien();
            mt.SinhNgauNhien(n, m);
            mt.InMang();

            mt.TachChanLe(out int[] chan, out int[] le);
            Console.WriteLine("\nMang cac so chan: " + string.Join(", ", chan));
            Console.WriteLine("Mang cac so le:   " + string.Join(", ", le));
        }
    }
}
