//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Dictionary<string, int> menu = new Dictionary<string, int>();
//        int choice;

//        do
//        {
//            Console.WriteLine("Menu");
//            Console.WriteLine("1. Add meal");
//            Console.WriteLine("2. Show all meals");
//            Console.WriteLine("3. Update meal price");
//            Console.WriteLine("4. Delete meal");
//            Console.WriteLine("5. Exit");

//            int.TryParse(Console.ReadLine(), out choice);

//            switch (choice)
//            {
//                case 1:
//                    AddDish(menu);
//                    break;

//                case 2:
//                    ShowMenu(menu);
//                    break;

//                case 3:
//                    UpdateDish(menu);
//                    break;

//                case 4:
//                    RemoveDish(menu);
//                    break;

//                case 5:
//                    Console.WriteLine("Exiting...");
//                    break;

//                default:
//                    Console.WriteLine("Invalid choice");
//                    break;
//            }

//        } while (choice != 5);
//    }


//    static void AddDish(Dictionary<string, int> menu)
//    {
//        Console.Write("Введите название блюда: ");
//        string name = Console.ReadLine();

//        if (menu.ContainsKey(name))
//        {
//            Console.WriteLine("Такое блюдо уже существует");
//            return;
//        }

//        Console.Write("Введите цену: ");
//        int price = int.Parse(Console.ReadLine());
//        menu.Add(name, price);

//        Console.WriteLine("Блюдо добавлено!");
//    }


//    static void ShowMenu(Dictionary<string, int> menu)
//    {
//        if (menu.Count == 0)
//        {
//            Console.WriteLine("Меню пустое :(");
//            return;
//        }

//        Console.WriteLine("Menu:");
//        foreach (var item in menu)
//        {
//            Console.WriteLine($"{item.Key}: {item.Value}$");
//        }
//    }


//    static void UpdateDish(Dictionary<string, int> menu)
//    {
//        Console.Write("Введите название блюда для изменения: ");
//        string name = Console.ReadLine();

//        if (!menu.ContainsKey(name))
//        {
//            Console.WriteLine("Блюдо не найдено");
//            return;
//        }

//        Console.Write("Введите новую цену: ");
//        int price = int.Parse(Console.ReadLine());
//        menu[name] = price;

//        Console.WriteLine("Цена обновлена!");
//    }


//    static void RemoveDish(Dictionary<string, int> menu)
//    {
//        Console.Write("Введите название блюда для удаления: ");
//        string name = Console.ReadLine();

//        if (menu.Remove(name))
//        {
//            Console.WriteLine("Блюдо было удалено!");
//        }
//        else
//        {
//            Console.WriteLine("Такого блюда нет.");
//        }
//    }
//}
