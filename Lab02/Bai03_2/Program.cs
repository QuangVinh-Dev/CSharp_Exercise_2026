using System;
using System.Collections.Generic;

namespace Lab02.Bai03_2
{
    // Lop mo phong sap xep mang tong quat bang Interface IComparer<T>
    public static class GenericSorter
    {
        // Phuong thuc sap xep mang tong quat su dung thuat toan Bubble Sort qua IComparer<T>
        public static void MySort<T>(T[] arr, IComparer<T> comparer)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    // So sanh 2 phan tu thong qua interface comparer
                    if (comparer.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }

    // Lop thuc thi so sanh giam dan cho so nguyen
    public class GiamDanComparer : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }

    // Lop thuc thi so sanh do dai chuoi
    public class DoDaiChuoiComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            if (x == null && y == null) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            return x.Length.CompareTo(y.Length);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 3.2: SAP XEP MANG TONG QUAT BANG INTERFACE (MO PHONG ARRAY.SORT) ===");

            int[] numbers = { 45, 12, 89, 23, 7, 60 };
            Console.WriteLine("Mang so nguyen ban dau: " + string.Join(", ", numbers));

            // Sap xep giam dan qua interface IComparer<int>
            GenericSorter.MySort(numbers, new GiamDanComparer());
            Console.WriteLine("Sau khi sap xep giam dan (Interface): " + string.Join(", ", numbers));

            string[] words = { "CSharp", "C", "Python", "JavaScript", "Go" };
            Console.WriteLine("\nMang chuoi ban dau: " + string.Join(", ", words));

            // Sap xep theo do dai tang dan qua interface
            GenericSorter.MySort(words, new DoDaiChuoiComparer());
            Console.WriteLine("Sau khi sap xep theo do dai chuoi: " + string.Join(", ", words));
        }
    }
}
