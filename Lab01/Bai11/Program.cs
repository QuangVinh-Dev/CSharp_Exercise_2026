using System;
using System.Text;

namespace Lab01.Bai11
{
    // Lop dao nguoc chuoi
    public class DaoChuoiHelper
    {
        // Phuong thuc thanh vien tra ve chuoi la dao cua mot chuoi su dung StringBuilder
        public string DaoChuoi(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            StringBuilder sb = new StringBuilder(s.Length);
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 11: PHUONG THUC TRA VE CHUOI DAO NGUOC ===");

            Console.Write("Nhap chuoi can dao nguoc: ");
            string input = Console.ReadLine() ?? "Hello World";
            if (string.IsNullOrEmpty(input)) input = "Hello World";

            DaoChuoiHelper helper = new DaoChuoiHelper();
            string chuoiDao = helper.DaoChuoi(input);

            Console.WriteLine($"Chuoi ban dau: \"{input}\"");
            Console.WriteLine($"Chuoi dao nguoc: \"{chuoiDao}\"");
        }
    }
}
