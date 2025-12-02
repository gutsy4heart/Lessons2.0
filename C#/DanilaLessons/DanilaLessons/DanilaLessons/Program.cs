using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace DanilaLessons;

public class Program
{
    public static void Main(string[] args)
    {
        #region Array
        //Arrays arrays = new Arrays();
        //arrays.ArrayPlayWithFor();
        //Console.WriteLine();

        //const int colums = 5; 
        //const int rows = 5;
        //int[,] multArr = new int[rows, colums];

        //        int[,] multArr =
        //{
        //            { 1,2,3,4,5},
        //            { 1,2,3,4,5},
        //            { 1,2,3,4,5},
        //            { 1,2,3,4,5},
        //            { 1,2,3,4,5}
        //        };
        //Random random = new Random();

        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < colums; j++)
        //    {
        //        multArr[i, j] = random.Next(-20, 20);
        //    }
        //}
        //for (int i = 0; i < rows; i++)
        //{
        //    for (int j = 0; j < colums; j++)
        //    {
        //        Console.Write(multArr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}



        //PrintStudents();



        //string[] fruits = { "Apple", "Pear", "Cherry", "Kiwi", "Banana" };

        //foreach (string fruit in fruits)
        //{
        //    Console.WriteLine(fruit);
        //}

        //foreach (string fruit in fruits)
        //{
        //    Console.WriteLine($"{fruit} - {fruit.Length}");
        //}

        //string[] names = { "Murad", "Daniels", "Janis", "Marta" };

        //foreach (string name in names)
        //{
        //    if (name.StartsWith("M"))
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        //foreach (string item in names)
        //{
        //    Console.WriteLine(item.ToUpper());
        //}
        //int[] arr = { 1, 2, 3, 4, 5 };

        //foreach (var item in arr)
        //{
        //    Console.WriteLine(item);            
        //}
        #endregion

        //Employee employee = new Employee();
        //employee.FirstName = "Test";
        //employee.LastName = "Test";
        //employee.Email = "Test@gmail.com";
        //employee.Position = "Backend Dev";
        //Department department = new Department();
        //department.Name = "Backend Developers";
        //Company company = new Company();    
        //company.Name = "Zabka";

        Company company = new Company();
        // class Employee
        company.Employee.FirstName = "Danila";
        company.Employee.LastName = "Butkevich";
        company.Employee.Email = "butkevich@gmail.com";
        company.Employee.Position = "Game dev";
        company.DepartmentName = "Game development";
        company.Name = "Cherry";


        company.Print();


    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
    }

    public class Department
    {
        public string DepartmentName { get; set; }
        public Employee Employee { get; set; }

    }

    public class Company : Department
    {
        public string Name { get; set; }
        public Employee employee { get; set; }
        public void Print()
        {
            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.LastName);
            Console.WriteLine(employee.Email);
            Console.WriteLine(employee.Position);
            Console.WriteLine(DepartmentName);
            Console.WriteLine(Name);
        }
    }

    //public static void PrintStudents()
    //{
    //    Console.OutputEncoding = System.Text.Encoding.UTF8;
    //    Console.Write("How many students you want? ");
    //    int count = Int32.Parse(Console.ReadLine());
    //    string[,] students = new string[count, 4];
    //    for (int i = 0; i < count; i++)
    //    {
    //        Console.WriteLine($"Fill data for student № {i + 1}");
    //        Console.Write($"Enter the name: ");
    //        students[i, 0] = Console.ReadLine();
    //        Console.Write($"Enter the surname: ");
    //        students[i, 1] = Console.ReadLine();
    //        Console.Write($"Enter the age: ");
    //        students[i, 2] = Console.ReadLine();
    //        Console.Write($"Enter the GPA: ");
    //        students[i, 3] = Console.ReadLine();
    //    }

    //    Console.Clear();

    //    // Вывод таблицы студентов
    //    Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
    //    Console.WriteLine("║                        STUDENTS LIST                         ║");
    //    Console.WriteLine("╠══════╦══════════════╦═══════════════╦══════╦═════════════════╣");
    //    Console.WriteLine("║  №   ║     Name     ║    Surname    ║ Age  ║       GPA       ║");
    //    Console.WriteLine("╠══════╬══════════════╬═══════════════╬══════╬═════════════════╣");

    //    for (int i = 0; i < count; i++)
    //    {
    //        Console.WriteLine($"║ {i + 1,-4} ║ {students[i, 0],-12} ║ {students[i, 1],-13} ║ {students[i, 2],-4} ║ {students[i, 3],-15} ║");
    //    }

    //    Console.WriteLine("╚══════╩══════════════╩═══════════════╩══════╩═════════════════╝");
    //}
}
