using MyApp;
using System;
using System.Runtime.InteropServices;
using System.Transactions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //num1
            /*
            Journal journal1 = new Journal();
            journal1.InputData();
            Console.WriteLine("Первый журнал:");
            journal1.Display();

            Journal journal2 = new Journal();
            journal2.InputData();
            Console.WriteLine("Второй журнал:");
            journal2.Display();

            Console.WriteLine("Сравнение количества сотрудников:");
            Console.WriteLine($"journal1 == journal2: {journal1 == journal2}");
            Console.WriteLine($"journal1 != journal2: {journal1 != journal2}");
            Console.WriteLine($"journal1 < journal2: {journal1 < journal2}");
            Console.WriteLine($"journal1 > journal2: {journal1 > journal2}");

            journal1 += 5;
            journal2 -= 2;

            Console.WriteLine("Обновленное количество сотрудников:");
            Console.WriteLine("journal1.NumberOfEmployees: " + journal1.NumberOfEmployees);
            Console.WriteLine("journal2.NumberOfEmployees: " + journal2.NumberOfEmployees);

            Console.ReadLine();
            */
            //num2
            /*
            Shop shop1 = new Shop();
            shop1.InputData();

            Shop shop2 = new Shop();
            shop2.InputData();

            Console.WriteLine("\nИнформация о магазине 1:");
            shop1.Display();

            Console.WriteLine("\nИнформация о магазине 2:");
            shop2.Display();

            Console.WriteLine("\nУвеличение площади магазина 1 на 100:");
            shop1 = shop1 + 100;
            shop1.Display();

            Console.WriteLine("\nУменьшение площади магазина 2 на 50:");
            shop2 = shop2 - 50;
            shop2.Display();

            if (shop1 == shop2)
            {
                Console.WriteLine("\nПлощади магазинов 1 и 2 равны.");
            }
            else if (shop1 > shop2)
            {
                Console.WriteLine("\nПлощадь магазина 1 больше, чем у магазина 2.");
            }
            else if (shop1 < shop2)
            {
                Console.WriteLine("\nПлощадь магазина 1 меньше, чем у магазина 2.");
            }
            else
            {
                Console.WriteLine("\nПлощади магазинов 1 и 2 разные.");
            }

           */
            //num3
            /*
            BookList bookList = new BookList();

            Console.WriteLine("Добро пожаловать в список книг для прочтения!");

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Добавить книгу");
                Console.WriteLine("2. Удалить книгу");
                Console.WriteLine("3. Проверить наличие книги");
                Console.WriteLine("4. Вывести список книг");
                Console.WriteLine("5. Выход");

                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите название книги для добавления: ");
                        string bookToAdd = Console.ReadLine();
                        bookList.AddBook(bookToAdd);
                        break;

                    case "2":
                        Console.Write("Введите название книги для удаления: ");
                        string bookToRemove = Console.ReadLine();
                        bookList.RemoveBook(bookToRemove);
                        break;

                    case "3":
                        Console.Write("Введите название книги для проверки: ");
                        string bookToCheck = Console.ReadLine();
                        if (bookList.ContainsBook(bookToCheck))
                            Console.WriteLine("Книга есть в списке.");
                        else
                            Console.WriteLine("Книга отсутствует в списке.");
                        break;

                    case "4":
                        bookList.show();
                        break;

                    case "5":
                        Console.WriteLine("Выход из программы.");
                        return;

                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
            */
        
        }
    }



    internal class Journal
    {
        private string name;
        private int year;
        private string description;
        private string phone;
        private string email;
        private int numberOfEmployees; 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int NumberOfEmployees
        {
            get { return numberOfEmployees; }
            set { numberOfEmployees = value; }
        }

        public void InputData()
        {
            Console.WriteLine("Введите название журнала:");
            name = Console.ReadLine();

            Console.WriteLine("Введите год основания:");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите описание журнала:");
            description = Console.ReadLine();

            Console.WriteLine("Введите контактный телефон:");
            phone = Console.ReadLine();

            Console.WriteLine("Введите email:");
            email = Console.ReadLine();

            Console.WriteLine("Введите количество сотрудников:");
            numberOfEmployees = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("название журнала: " + name);
            Console.WriteLine("год основания: " + year);
            Console.WriteLine("Описание сайта: " + description);
            Console.WriteLine("контактный телефон: " + phone);
            Console.WriteLine("email: " + email);
            Console.WriteLine("количество сотрудников: " + numberOfEmployees);
        }

        public static Journal operator +(Journal journal, int employees)
        {
            journal.NumberOfEmployees += employees;
            return journal;
        }

        public static Journal operator -(Journal journal, int employees)
        {
            journal.NumberOfEmployees -= employees;
            return journal;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            return journal1.NumberOfEmployees == journal2.NumberOfEmployees;
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return journal1.NumberOfEmployees != journal2.NumberOfEmployees;
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            return journal1.NumberOfEmployees < journal2.NumberOfEmployees;
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1.NumberOfEmployees > journal2.NumberOfEmployees;
        }
    }
    internal class Shop
    {
        private string name;
        private string address;
        private string description;
        private string phone;
        private string email;
        private double area; 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public void InputData()
        {
            Console.WriteLine("Введите название магазина:");
            name = Console.ReadLine();

            Console.WriteLine("Введите адрес:");
            address = Console.ReadLine();

            Console.WriteLine("Введите описание профиля магазина:");
            description = Console.ReadLine();

            Console.WriteLine("Введите контактный телефон:");
            phone = Console.ReadLine();

            Console.WriteLine("Введите email:");
            email = Console.ReadLine();

            Console.WriteLine("Введите площадь магазина:");
            if (double.TryParse(Console.ReadLine(), out double inputArea))
            {
                area = inputArea;
            }
            else
            {
                Console.WriteLine("Некорректный ввод площади.");
            }
        }

        public void Display()
        {
            Console.WriteLine("название магазина: " + name);
            Console.WriteLine("адрес: " + address);
            Console.WriteLine("описание профиля магазина: " + description);
            Console.WriteLine("контактный телефон: " + phone);
            Console.WriteLine("контактный email: " + email);
            Console.WriteLine("площадь магазина: " + area);
        }
        public static Shop operator +(Shop shop, double increase)
        {
            shop.Area += increase;
            return shop;
        }

        public static Shop operator -(Shop shop, double decrease)
        {
            shop.Area -= decrease;
            return shop;
        }

        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1.Area == shop2.Area;
        }

        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return shop1.Area != shop2.Area;
        }

        public static bool operator <(Shop shop1, Shop shop2)
        {
            return shop1.Area < shop2.Area;
        }

        public static bool operator >(Shop shop1, Shop shop2)
        {
            return shop1.Area > shop2.Area;
        }
    }
    class BookList
    {
        private List<string> books = new List<string>();

        public void AddBook(string book)
        {
            books.Add(book);
        }

        public void RemoveBook(string book)
        {
            books.Remove(book);
        }
        public void show()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i]);
            }
        }

        public bool ContainsBook(string book)
        {
            return books.Contains(book);
        }
        public static BookList operator +(BookList bookList, string book)
        {
            bookList.AddBook(book);
            return bookList;
        }

        public static BookList operator -(BookList bookList, string book)
        {
            bookList.RemoveBook(book);
            return bookList;
        }
    }

}