//using System.Text;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        string filepath = "test.txt";

//        using (FileStream fs = new FileStream(filepath, FileMode.Create)) 
//        {
//            using (StreamWriter sw = new StreamWriter(fs,Encoding.Unicode))
//            {
//                Console.Write("Enter the data to write to the file: ");
//                string writeText = Console.ReadLine() ?? "";
               
//                foreach (var item in writeText)
//                {
//                    sw.Write($"{item}");
//                }
//                Console.WriteLine("\nData recorded");
//            }
//        }

//        using (FileStream fs = new FileStream(filepath, FileMode.Open))
//        {
//            using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
//            {
//                Console.WriteLine($"Data read from the file\n:");
//                Console.WriteLine(sr.ReadToEnd());
//            }
//        }
//    }
//}