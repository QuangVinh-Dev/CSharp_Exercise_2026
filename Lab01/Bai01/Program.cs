using System;

namespace Lab01.Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 01: MA NGUON CHUONG TRINH (ILDASM / ILASM) ===");
            
            // Nhap ho ten tu ban phim
            Console.Write("Nhap ho ten cua ban: ");
            string? hoTen = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                hoTen = "Nguyen Van A";
                Console.WriteLine(hoTen);
            }

            // Xuat ho ten ra man hinh console
            Console.WriteLine($"Xin chao: {hoTen}");

            // Huong dan su dung ildasm va ilasm de xem va dich ma MSIL
            Console.WriteLine("\n--- HUONG DAN SU DUNG ILDASM VA ILASM ---");
            Console.WriteLine("B1: Bien dich chuong trinh thanh file PE (.exe hoac .dll):");
            Console.WriteLine("    dotnet build");
            Console.WriteLine("B2: Su dung ildasm.exe de xem ma MSIL va xuat sang file .il:");
            Console.WriteLine("    ildasm Bai01.dll /out=Bai01.il");
            Console.WriteLine("B3: Su dung ilasm.exe de dong goi file .il tro lai file PE:");
            Console.WriteLine("    ilasm Bai01.il /exe /output=Bai01_Rebuilt.exe");
        }
    }
}
