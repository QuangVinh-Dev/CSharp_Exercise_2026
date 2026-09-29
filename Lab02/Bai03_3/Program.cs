using System;

namespace Lab02.Bai03_3
{
    // Dinh nghia Delegate tong quat de so sanh hai doi tuong
    public delegate int SoSanhDelegate<T>(T a, T b);

    public static class DelegateSorter
    {
        // Phuong thuc sap xep mang tong quat bang Delegate
        public static void SortByDelegate<T>(T[] arr, SoSanhDelegate<T> compare)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    // Goi delegate de xac dinh thu tu
                    if (compare(arr[j], arr[j + 1]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 3.3: SAP XEP MANG TONG QUAT BANG DELEGATE ===");

            int[] arr = { 29, 10, 14, 37, 13 };
            Console.WriteLine("Mang ban dau: " + string.Join(", ", arr));

            // Su dung delegate voi bieu thuc Lambda de sap xep tang dan
            DelegateSorter.SortByDelegate(arr, (x, y) => x.CompareTo(y));
            Console.WriteLine("Sap xep tang dan (Delegate): " + string.Join(", ", arr));

            // Su dung delegate voi bieu thuc Lambda de sap xep giam dan
            DelegateSorter.SortByDelegate(arr, (x, y) => y.CompareTo(x));
            Console.WriteLine("Sap xep giam dan (Delegate): " + string.Join(", ", arr));
        }
    }
}
