using System;

namespace Lab01.Bai10
{
    // Lop xu ly chuoi
    public class XuLyChuoi
    {
        // Kiem tra chuoi co doi xung (Palindrome) hay khong
        public bool KiemTraDoiXung(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right]) return false;
                left++;
                right--;
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 10: KIEM TRA CHUOI DOI XUNG ===");
            
            Console.Write("Nhap chuoi can kiem tra: ");
            string input = Console.ReadLine() ?? "radar";
            if (string.IsNullOrEmpty(input)) input = "radar";

            XuLyChuoi xl = new XuLyChuoi();
            bool laDoiXung = xl.KiemTraDoiXung(input);

            if (laDoiXung)
            {
                Console.WriteLine($"Chuoi \"{input}\" la chuoi doi xung.");
            }
            else
            {
                Console.WriteLine($"Chuoi \"{input}\" khong phai la chuoi doi xung.");
            }
        }
    }
}
