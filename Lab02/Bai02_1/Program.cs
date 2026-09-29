using System;
using System.Collections;

namespace Lab02.Bai02_1
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }

    // Lop ArrayPoint luu tru cac Point su dung ArrayList va Indexer
    public class ArrayPoint
    {
        // Field: Mot ArrayList cac Point theo dung de bai
        private ArrayList points;

        public ArrayPoint()
        {
            points = new ArrayList();
        }

        // Indexer cho phep truy cap Point thu i cua ArrayList
        public Point this[int index]
        {
            get
            {
                if (index < 0 || index >= points.Count)
                    throw new IndexOutOfRangeException("Chi so vuot qua gioi han.");
                return (Point)points[index]!;
            }
            set
            {
                if (index < 0 || index >= points.Count)
                    throw new IndexOutOfRangeException("Chi so vuot qua gioi han.");
                points[index] = value;
            }
        }

        public int Count => points.Count;

        public void Add(Point p)
        {
            points.Add(p);
        }

        public void Xuat()
        {
            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine($"Diem thu {i}: {this[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 2.1: LOP ARRAYPOINT VA INDEXER ===");

            ArrayPoint arr = new ArrayPoint();
            arr.Add(new Point(1.2, 3.4));
            arr.Add(new Point(5.0, -2.5));
            arr.Add(new Point(0, 7.8));

            Console.WriteLine("Danh sach cac diem ban dau:");
            arr.Xuat();

            // Minh hoa su dung Indexer de doc va ghi
            Console.WriteLine("\n--- Kiem tra Indexer ---");
            Console.WriteLine($"Gia tri tai index 1 qua indexer: {arr[1]}");

            // Cap nhat toa do diem tai index 1 qua Indexer
            arr[1] = new Point(9.9, 9.9);
            Console.WriteLine($"Sau khi gan arr[1] = (9.9, 9.9): {arr[1]}");

            Console.WriteLine("\nDanh sach sau khi sua doi:");
            arr.Xuat();
        }
    }
}
