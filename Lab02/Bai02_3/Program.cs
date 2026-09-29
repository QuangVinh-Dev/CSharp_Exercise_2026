using System;
using System.Collections.Generic;

namespace Lab02.Bai02_3
{
    // Lop chua mang 1 chieu DaySo
    public class DaySo
    {
        private int[] data;

        // a. Default constructor
        public DaySo()
        {
            data = Array.Empty<int>();
        }

        // a. Constructor co tham so kich thuoc n
        public DaySo(int n)
        {
            data = new int[n < 0 ? 0 : n];
        }

        // a. Constructor tu mang
        public DaySo(int[] arr)
        {
            data = (int[])arr.Clone();
        }

        // a. Copy constructor
        public DaySo(DaySo other)
        {
            data = (int[])other.data.Clone();
        }

        public int Length => data.Length;

        // b. Indexer de truy cap phan tu thu i trong day
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= data.Length)
                    throw new IndexOutOfRangeException("Chi so khong hop le.");
                return data[index];
            }
            set
            {
                if (index < 0 || index >= data.Length)
                    throw new IndexOutOfRangeException("Chi so khong hop le.");
                data[index] = value;
            }
        }

        // c. Nhap day so tu ban phim
        public void Nhap()
        {
            Console.Write("Nhap so phan tu cua day so: ");
            int.TryParse(Console.ReadLine(), out int n);
            data = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu [{i}]: ");
                int.TryParse(Console.ReadLine(), out data[i]);
            }
        }

        // c. Xuat day so
        public void Xuat()
        {
            Console.WriteLine("Day so: " + string.Join(", ", data));
        }

        // d. Tim cac so chan trong day
        public int[] TimSoChan()
        {
            List<int> chan = new List<int>();
            foreach (var x in data)
            {
                if (x % 2 == 0) chan.Add(x);
            }
            return chan.ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 2.3: LOP CHUA MANG 1 CHIEU (DAYSO) ===");

            DaySo ds = new DaySo(new int[] { 12, 5, 8, 19, 24, 7, 30 });
            ds.Xuat();

            // Minh hoa Indexer
            Console.WriteLine($"Phan tu index 2 qua Indexer: {ds[2]}");
            ds[2] = 88;
            Console.WriteLine($"Sau khi gan ds[2] = 88: {ds[2]}");
            ds.Xuat();

            // Tim so chan
            int[] chan = ds.TimSoChan();
            Console.WriteLine("Cac so chan trong day: " + string.Join(", ", chan));
        }
    }
}
