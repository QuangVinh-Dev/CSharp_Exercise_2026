using System;
using System.Collections.Generic;

namespace Lab02.Bai02_2
{
    public class Person
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public int Yob { get; set; }
        public int Yod { get; set; }

        public Person() { }

        public Person(string id, string name, int yob, int yod)
        {
            Id = id;
            Name = name;
            Yob = yob;
            Yod = yod;
        }

        public Person(Person other)
        {
            Id = other.Id;
            Name = other.Name;
            Yob = other.Yob;
            Yod = other.Yod;
        }

        public bool IsLiving() => Yod == 0;

        public void Input()
        {
            Console.Write("Nhap ID: ");
            Id = Console.ReadLine() ?? "";
            Console.Write("Nhap Ten: ");
            Name = Console.ReadLine() ?? "";
            Console.Write("Nhap Nam sinh: ");
            int.TryParse(Console.ReadLine(), out int y);
            Yob = y;
            Console.Write("Nhap Nam mat (0 neu con song): ");
            int.TryParse(Console.ReadLine(), out int d);
            Yod = d;
        }

        public void Output()
        {
            string tt = IsLiving() ? "Con song" : $"Da mat nam {Yod}";
            Console.WriteLine($"ID: {Id,-5} | Ten: {Name,-20} | Nam sinh: {Yob} | {tt}");
        }
    }

    // Lop PersonList quan ly nhieu nguoi
    public class PersonList
    {
        private List<Person> list;

        // Default constructor
        public PersonList()
        {
            list = new List<Person>();
        }

        // Copy constructor
        public PersonList(PersonList other)
        {
            list = new List<Person>();
            foreach (var p in other.list)
            {
                list.Add(new Person(p));
            }
        }

        // Them mot Person vao danh sach
        public void Add(Person x)
        {
            list.Add(x);
        }

        // Nhap danh sach nguoi
        public void Input()
        {
            Console.Write("Nhap so luong nguoi can them vao danh sach: ");
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhap nguoi thu {i + 1}:");
                Person p = new Person();
                p.Input();
                list.Add(p);
            }
        }

        // Xuat danh sach
        public void Output()
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Output();
            }
        }

        // Tra ve mot PersonList nhung nguoi con song
        public PersonList LivingPeople()
        {
            PersonList living = new PersonList();
            foreach (var p in list)
            {
                if (p.IsLiving())
                {
                    living.Add(new Person(p));
                }
            }
            return living;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BAI 2.2: LOP PERSONLIST QUAN LY NHAN KHAU ===");

            PersonList ds = new PersonList();
            ds.Add(new Person("P01", "Nguyen Van An", 1990, 0));
            ds.Add(new Person("P02", "Tran Thi Binh", 1930, 2015));
            ds.Add(new Person("P03", "Pham Van Cuong", 2002, 0));
            ds.Add(new Person("P04", "Hoang Thi Dao", 1945, 2020));

            Console.WriteLine("Danh sach toan bo nguoi trong dia phuong:");
            ds.Output();

            // Loc danh sach nhung nguoi con song
            PersonList dsConSong = ds.LivingPeople();
            Console.WriteLine("\n--- Danh sach nhung nguoi con song (LivingPeople) ---");
            dsConSong.Output();
        }
    }
}
