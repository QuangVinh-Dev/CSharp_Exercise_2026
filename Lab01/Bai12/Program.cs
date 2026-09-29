using System;

namespace Lab01.Bai12
{
    // Lop bien doi chuoi va dem tu
    public class XuLyVanBan
    {
        // Chuyen sang chu thuong
        public string SangChuThuong(string s) => s.ToLower();

        // Chuyen sang chu hoa
        public string SangChuHoa(string s) => s.ToUpper();

        // Dem so tu trong chuoi
        public int DemSoTu(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0;
            // Tach chuoi theo cac ky tu khoang trang
            string[] tu = s.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return tu.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 12: CHUYEN CHUOI THUONG/HOA VA DEM SO TU ===");

            Console.Write("Nhap chuoi gom nhieu tu: ");
            string input = Console.ReadLine() ?? "Lap trinh huong doi tuong voi CSharp";
            if (string.IsNullOrWhiteSpace(input)) input = "Lap trinh huong doi tuong voi CSharp";

            XuLyVanBan xl = new XuLyVanBan();
            Console.WriteLine($"Chuoi ban dau:    {input}");
            Console.WriteLine($"Sang ky tu thuong: {xl.SangChuThuong(input)}");
            Console.WriteLine($"Sang ky tu hoa:    {xl.SangChuHoa(input)}");
            Console.WriteLine($"So tu trong chuoi: {xl.DemSoTu(input)}");
        }
    }
}
