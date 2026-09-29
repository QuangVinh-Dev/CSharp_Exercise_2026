using System;
using System.Collections.Generic;

namespace Lab01.Bai15
{
    // Lop quan ly mang so nguyen va cac thao tac
    public class MangSoNguyen
    {
        private int[] a = Array.Empty<int>();

        // Nhap mang gom n phan tu
        public void NhapMang()
        {
            Console.Write("Nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine() ?? "5");
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine() ?? "0");
            }
        }

        // In mang ra man hinh
        public void InMang()
        {
            Console.WriteLine("Cac phan tu trong mang: " + string.Join(", ", a));
        }

        // Tim phan tu lon nhat va nho nhat trong mang
        public void TimMaxMin(out int max, out int min)
        {
            if (a.Length == 0)
            {
                max = min = 0;
                return;
            }
            max = a[0];
            min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }
        }

        // Kiem tra mot so co phai la so nguyen to
        private bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Tra ve mang cac so nguyen to co trong mang goc
        public int[] LayCacSoNguyenTo()
        {
            List<int> snt = new List<int>();
            foreach (int x in a)
            {
                if (LaSoNguyenTo(x)) snt.Add(x);
            }
            return snt.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 15: MANG MOT CHIEU SO NGUYEN ===");
            
            MangSoNguyen mang = new MangSoNguyen();
            mang.NhapMang();
            Console.WriteLine("\n--- Ket qua xu ly mang ---");
            mang.InMang();

            mang.TimMaxMin(out int max, out int min);
            Console.WriteLine($"Phan tu lon nhat (Max): {max}");
            Console.WriteLine($"Phan tu nho nhat (Min): {min}");

            int[] mangSNT = mang.LayCacSoNguyenTo();
            Console.WriteLine("Mang cac so nguyen to: " + (mangSNT.Length > 0 ? string.Join(", ", mangSNT) : "Khong co so nguyen to nao"));
        }
    }
}
