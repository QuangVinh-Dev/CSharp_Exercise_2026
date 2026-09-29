using System;

namespace Lab01.Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            bool daNhap = false;
            bool dangChay = true;

            while (dangChay)
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");

                string? luaChon = Console.ReadLine();
                switch (luaChon)
                {
                    case "1":
                        // Nhap hai so thuc x va y
                        Console.Write("Nhap x: ");
                        while (!double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.Write("Gia tri khong hop le. Nhap lai x: ");
                        }

                        Console.Write("Nhap y: ");
                        while (!double.TryParse(Console.ReadLine(), out y))
                        {
                            Console.Write("Gia tri khong hop le. Nhap lai y: ");
                        }
                        daNhap = true;
                        Console.WriteLine($"Da luu x = {x}, y = {y}");
                        break;

                    case "2":
                        if (!daNhap)
                        {
                            Console.WriteLine("Vui long nhap x va y truoc (chon 1).");
                            break;
                        }
                        // Tinh luy thua x^y
                        double luyThua = Math.Pow(x, y);
                        Console.WriteLine($"Ket qua {x}^{y} = {luyThua}");
                        break;

                    case "3":
                        if (!daNhap)
                        {
                            Console.WriteLine("Vui long nhap x va y truoc (chon 1).");
                            break;
                        }
                        // Tinh can bac 2 cua x va y kem kiem tra dieu kien khong am
                        if (x < 0)
                            Console.WriteLine($"x = {x} < 0, khong co can bac 2 trong tap so thuc.");
                        else
                            Console.WriteLine($"Can bac 2 cua x ({x}) la: {Math.Sqrt(x)}");

                        if (y < 0)
                            Console.WriteLine($"y = {y} < 0, khong co can bac 2 trong tap so thuc.");
                        else
                            Console.WriteLine($"Can bac 2 cua y ({y}) la: {Math.Sqrt(y)}");
                        break;

                    case "4":
                        Console.WriteLine("Tam biet!");
                        dangChay = false;
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long chon tu 1 den 4.");
                        break;
                }
            }
        }
    }
}
