////public class Program
////{
////    public static void Main(string[] args)
////    {
////        // yield -> iterator
////        // 
////        //for (int i = 0; i < 5; i++)
////        //{
////        //    //cout << i << " ";
////        //    Console.Write($"{i} ");
////        //}

////        /*
////         yield return -> отдай следующий элемент
////         yield break -> досрочно завершить перебор 
////         */


////        foreach (int x in GetNumbers())
////        {
////            Console.WriteLine(x);
////        }
////    }
////    static IEnumerable<int> GetNumbers()
////    {
////        yield return 1;
////        yield return 2;
////        yield return 3;
////        yield return 4;
////    }
////}



//public class Program
//{
//    public static List<string> words = new List<string>();
//    public static void Main(string[] args)
//    {
//        bool run = true;
//        while (run)
//        {
//            Console.WriteLine("====WordApp====");
//            Console.WriteLine("1.Add word");
//            Console.WriteLine("2.Show all words");
//            Console.WriteLine("3.Search (yield)");
//            Console.WriteLine("0.Exit");
//            string choice = Console.ReadLine() ?? "";
//            Console.WriteLine();
//            switch (choice)
//            {
//                case "1":
//                    Console.Write("Word: ");
//                    string w = Console.ReadLine() ?? "";
//                    if (!string.IsNullOrWhiteSpace(w))
//                        words.Add(w);
//                    break;
//                case "2":
//                    if (words.Count == 0) Console.WriteLine("(empty)");
//                    foreach (var x in words)
//                    {
//                        Console.WriteLine(x);
//                    }
//                    break;
//                case "3":
//                    Console.Write("Search text: ");
//                    string q = (Console.ReadLine() ?? "").Trim().ToLower();
//                    bool found = false;
//                    foreach (var item in SearchYield(q))
//                    {
//                        found = true;
//                        Console.WriteLine(item);
//                    }
//                    if (!found) Console.WriteLine("No matches.");
//                    break;
//                case "0":
//                    run = false;
//                    break;
//                default:
//                    Console.WriteLine("Unknown command");
//                    break;
//            }
//        }

//    }
//    public static IEnumerable<string> SearchYield(string q)
//    {
//        if (string.IsNullOrWhiteSpace(q))
//        {
//            yield break;
//        }
//        foreach (var item in words)
//        {
//            if (item.ToLower().Contains(q))
//            {
//                yield return item;
//            }
//        }
//    }
   
//}