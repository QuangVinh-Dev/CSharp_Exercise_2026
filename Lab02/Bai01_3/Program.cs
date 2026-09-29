using System;

namespace Lab02.Bai01_3
{
    // Lop Person quan ly thong tin nhan than
    public class Person
    {
        // Field
        private string id = "";
        private string name = "";
        private int yob;
        private int yod;

        // Default Constructor
        public Person()
        {
            id = "";
            name = "";
            yob = 0;
            yod = 0;
        }

        // Parameterized Constructor
        public Person(string id, string name, int yob, int yod)
        {
            this.id = id;
            this.name = name;
            this.yob = yob;
            this.yod = yod;
        }

        // Copy constructor
        public Person(Person other)
        {
            this.id = other.id;
            this.name = other.name;
            this.yob = other.yob;
            this.yod = other.yod;
        }

        // Property
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Yob { get => yob; set => yob = value; }
        public int Yod { get => yod; set => yod = value; }

        // Nhap thong tin nguoi dung
        public void Input()
        {
            Console.Write("Nhap ma dinh danh (ID): ");
            id = Console.ReadLine() ?? "P01";
            Console.Write("Nhap ho va ten: ");
            name = Console.ReadLine() ?? "Le Thi B";
            Console.Write("Nhap nam sinh (YOB): ");
            int.TryParse(Console.ReadLine(), out yob);
            Console.Write("Nhap nam mat (YOD, nhap 0 neu con song): ");
            int.TryParse(Console.ReadLine(), out yod);
        }

        // Xuat thong tin nguoi dung
        public void Output()
        {
            string trangThai = IsLiving() ? "Con song" : $"Da mat nam {yod}";
            Console.WriteLine($"ID: {id, -6} | Ho ten: {name, -20} | Nam sinh: {yob} | Trang thai: {trangThai}");
        }

        // Kiem tra nguoi do con song hay khong (yod bang 0 la con song)
        public bool IsLiving()
        {
            return yod == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 1.3: LOP PERSON VA KIEM TRA TRANG THAI CON SONG ===");

            Person p1 = new Person();
            Console.WriteLine("Nhap thong tin nguoi thu nhat:");
            p1.Input();

            // Minh hoa Copy constructor
            Person p2 = new Person(p1);
            p2.Id = p1.Id + "_COPY";
            p2.Name = p1.Name + " (Sao chep)";

            Console.WriteLine("\n--- Thong tin nguoi thu nhat ---");
            p1.Output();

            Console.WriteLine("\n--- Thong tin nguoi duoc sao chep bang Copy Constructor ---");
            p2.Output();
        }
    }
}
