//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ClassCollections;

////public class HashTables
////{
////    public static void Main(string[] args)
////    {
////        //Hashtable table = new();

////        //table["name"] = "Danila";
////        //table["age"] = 23;
////        //table["city"] = "Osaka";

////        //Console.WriteLine("HashTable");
////        //foreach (DictionaryEntry item in table)
////        //{
////        //    Console.WriteLine($"{item.Key} = {item.Value}");
////        //}

////        Hashtable dictionary = new Hashtable();

////        dictionary["cat"] = "Кот";
////        dictionary["dog"] = "Псина";
////        dictionary["house"] = "Хата";
////        dictionary["book"] = "Книги";
////        dictionary["apple"] = "Яблоко";
////        dictionary["pear"] = "Груша";

////        Console.WriteLine("Введите английское слово: ");
////        string word = Console.ReadLine();
////        if (dictionary.ContainsKey(word))
////        {
////            Console.WriteLine($"Перевод: {dictionary[word]}");
////        }
////        else
////        {
////            Console.WriteLine("Такого слова нету.");
////        }
////        Console.WriteLine("\nВсе слова в словаре:");
////        foreach (DictionaryEntry item in word)
////        {
////            Console.WriteLine($"{item.Key} - {item.Value}");
////        }
////    }
////}


//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Hashtable dictionary = new Hashtable();

//        dictionary["cat"] = "Кот";
//        dictionary["dog"] = "Псина";
//        dictionary["house"] = "Хата";
//        dictionary["book"] = "Книги";
//        dictionary["apple"] = "Яблоко";
//        dictionary["pear"] = "Груша";

//        while (true)
//        {

//            Console.Write("Введите английское слово: ");
//            string word = Console.ReadLine();
//            if (dictionary.ContainsKey(word))
//            {
//                Console.WriteLine($"Перевод: {dictionary[word]}");
//            }
//            else
//            {
//                Console.WriteLine("Такого слова нету.");
//            }
//            Console.WriteLine("\nВсе слова в словаре:");

//            foreach (DictionaryEntry item in dictionary)
//            {
//                Console.WriteLine($"{item.Key} - {item.Value}");
//            }
//            Console.WriteLine();
//            Console.WriteLine();
//        }
//    }
//}