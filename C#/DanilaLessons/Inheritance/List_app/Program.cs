//using System;
//using System.Collections.Generic;

//class Book
//{
//    public string Title { get; set; }
//    public string Description { get; set; }
//    public string Author { get; set; }
//    public int PublishYear { get; set; }

//    public Book(string title, string description, string author, int publishYear)
//    {
//        Title = title;
//        Description = description;
//        Author = author;
//        PublishYear = publishYear;
//    }

//    public void AddBook(List<Book> books)
//    {
//        Console.Write("Введите название книги: ");
//        string title = Console.ReadLine();

//        Console.Write("Введите автора книги: ");
//        string author = Console.ReadLine();

//        Console.Write("Введите описание книги: ");
//        string description = Console.ReadLine();

//        Console.Write("Введите дату выпуска книги: ");
//        int publishYear = int.Parse(Console.ReadLine());

//        books.Add(new Book(title, description, author, publishYear));
//        Console.WriteLine("Книга успешно добавлена!");
//    }

//    public void ShowBooks(List<Book> books)
//    {
//        Console.WriteLine();
//        Console.WriteLine("====== Список доступных книг ======");

//        if (books.Count == 0)
//        {
//            Console.WriteLine("Книг пока нет.");
//            return;
//        }

//        int i = 1;
//        foreach (var item in books)
//        {
//            Console.WriteLine($"{i}. {item.Title}, Автор: {item.Author}, Год: {item.PublishYear}");
//            i++;
//        }
//        Console.WriteLine();
//    }

//    public void FindBook(List<Book> books)
//    {
//        Console.Write("Введите название книги: ");
//        string searchTitle = Console.ReadLine();

//        foreach (var item in books)
//        {
//            if (item.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase))
//            {
//                Console.WriteLine($"Найдена книга: {item.Title}, Автор: {item.Author}, Год: {item.PublishYear}");
//                return;
//            }
//        }

//        Console.WriteLine("Книга не найдена");
//    }

//    public void RemoveBook(List<Book> books)
//    {
//        Console.Write("Введите название книги: ");
//        string title = Console.ReadLine();

//        for (int i = 0; i < books.Count; i++)
//        {
//            if (books[i].Title.Equals(title, StringComparison.OrdinalIgnoreCase))
//            {
//                books.RemoveAt(i);
//                Console.WriteLine("Книга удалена!");
//                return;
//            }
//        }

//        Console.WriteLine("Книга не найдена!");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        List<Book> books = new List<Book>()
//        {
//            new Book("Война и мир", "Роман о войне 1812 года", "Лев Толстой", 1869),
//            new Book("Преступление и наказание", "Роман о преступлении", "Фёдор Достоевский", 1866),
//            new Book("Мастер и Маргарита", "Мистический роман", "Михаил Булгаков", 1967),
//            new Book("1984", "Антиутопия", "Джордж Оруэлл", 1949),
//            new Book("Гарри Поттер", "Фэнтези", "Дж. К. Роулинг", 1997),
//            new Book("Три товарища", "Роман о дружбе и любви после войны", "Эрих Мария Ремарк", 1936),
//            new Book("Сто лет одиночества", "История нескольких поколений семьи Буэндиа", "Габриэль Гарсиа Маркес", 1967),
//            new Book("Портрет Дориана Грея", "Роман о вечной молодости и цене греха", "Оскар Уайльд", 1890),
//            new Book("Шерлок Холмс: Этюд в багровых тонах", "Первое расследование великого детектива", "Артур Конан Дойл", 1887),
//            new Book("Алхимик", "Философская притча о пути к мечте", "Пауло Коэльо", 1988)

//        };

//        Book manager = new Book("", "", "", 0);

//        while (true)
//        {
//            Console.WriteLine("\n====== МЕНЮ ======");
//            Console.WriteLine("1 - Показать все книги");
//            Console.WriteLine("2 - Добавить книгу");
//            Console.WriteLine("3 - Найти книгу");
//            Console.WriteLine("4 - Удалить книгу");
//            Console.WriteLine("0 - Выход");
//            Console.Write("Выберите действие: ");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    manager.ShowBooks(books);
//                    break;

//                case "2":
//                    manager.AddBook(books);
//                    break;

//                case "3":
//                    manager.FindBook(books);
//                    break;

//                case "4":
//                    manager.RemoveBook(books);
//                    break;

//                case "0":
//                    Console.WriteLine("Выход из программы...");
//                    return;

//                default:
//                    Console.WriteLine("Неверный выбор!");
//                    break;
//            }
//        }
//    }
//}
