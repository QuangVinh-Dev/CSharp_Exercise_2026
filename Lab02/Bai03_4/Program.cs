using System;
using System.Collections.Generic;

namespace Lab02.Bai03_4
{
    // Delegate xu ly su kien chon menu
    public delegate void MenuChooseHandler(int choice);

    // Lop ConsoleMenu tong quat ho tro mo rong bang Event va Ke thua
    public class ConsoleMenu
    {
        protected List<string> menuItems = new List<string>();

        // Event Choose thong bao khi nguoi dung chon chuc nang
        public event MenuChooseHandler? Choose;

        public void AddItem(string item)
        {
            menuItems.Add(item);
        }

        // Hien thi menu va thuc hien chuc nang
        public virtual void Display()
        {
            Console.WriteLine("\n================ MENU ================");
            for (int i = 0; i < menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuItems[i]}");
            }
            Console.WriteLine("0. Thoat chuong trinh");
            Console.WriteLine("======================================");
        }

        // Kich hoat su kien Choose
        protected virtual void OnChoose(int choice)
        {
            Choose?.Invoke(choice);
        }

        public virtual void Run()
        {
            while (true)
            {
                Display();
                Console.Write("Thuc hien: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Lua chon khong hop le!");
                    continue;
                }

                if (choice == 0)
                {
                    Console.WriteLine("Thoat chuong trinh. Tam biet!");
                    break;
                }

                Console.WriteLine($"Ban thuc hien chuc nang {choice}");
                OnChoose(choice);
            }
        }
    }

    // Lop PTBac2Console ke thua tu ConsoleMenu de giai phuong trinh bac 2
    public class PTBac2Console : ConsoleMenu
    {
        private double a;
        private double b;
        private double c;

        public PTBac2Console()
        {
            AddItem("Nhap he so a, b, c");
            AddItem("Giai phuong trinh bac hai ax^2 + bx + c = 0");
            AddItem("Xem he so hien tai");
        }

        // Override OnChoose de xu ly chuc nang theo huong ke thua
        protected override void OnChoose(int choice)
        {
            base.OnChoose(choice);

            switch (choice)
            {
                case 1:
                    NhapHeSo();
                    break;
                case 2:
                    GiaiPT();
                    break;
                case 3:
                    Console.WriteLine($"He so hien tai: a = {a}, b = {b}, c = {c}");
                    break;
                default:
                    Console.WriteLine("Chuc nang khong ton tai!");
                    break;
            }
        }

        private void NhapHeSo()
        {
            Console.Write("Nhap a: ");
            double.TryParse(Console.ReadLine(), out a);
            Console.Write("Nhap b: ");
            double.TryParse(Console.ReadLine(), out b);
            Console.Write("Nhap c: ");
            double.TryParse(Console.ReadLine(), out c);
            Console.WriteLine($"Da luu he so: {a}x^2 + {b}x + {c} = 0");
        }

        // Logic giai phuong trinh bac hai
        private void GiaiPT()
        {
            Console.WriteLine($"\nGiai phuong trinh: {a}x^2 + {b}x + {c} = 0");
            if (a == 0)
            {
                // Phuong trinh tro thanh bac nhat bx + c = 0
                if (b == 0)
                {
                    Console.WriteLine(c == 0 ? "Phuong trinh vo so nghiem." : "Phuong trinh vo nghiem.");
                }
                else
                {
                    Console.WriteLine($"Phuong trinh bac nhat co nghiem: x = {-c / b:F4}");
                }
                return;
            }

            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Delta < 0: Phuong trinh vo nghiem thuc.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Delta = 0: Phuong trinh co nghiem kep x1 = x2 = {x:F4}");
            }
            else
            {
                double sqrtDelta = Math.Sqrt(delta);
                double x1 = (-b + sqrtDelta) / (2 * a);
                double x2 = (-b - sqrtDelta) / (2 * a);
                Console.WriteLine($"Delta > 0: Phuong trinh co 2 nghiem phan biet:");
                Console.WriteLine($"  x1 = {x1:F4}");
                Console.WriteLine($"  x2 = {x2:F4}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 3.4*: LOP CONSOLEMENU TONG QUAT & GIAI PT BAC 2 ===");

            // Khoi tao ung dung menu giai PT bac 2
            PTBac2Console app = new PTBac2Console();

            // Dang ky Event Choose de the hien co che su kien
            app.Choose += (c) =>
            {
                // Event logger giam sat lua chon
            };

            // Chay chuong trinh
            app.Run();
        }
    }
}
