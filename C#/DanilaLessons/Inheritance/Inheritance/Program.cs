using System;

namespace Inheritance;


class Program
{
    static void Main(string[] args)
    {
        #region InheritanceIntro
        //Company company = new Company();

        //// Create department and employee
        //IDepartment department = new Department();
        //IEmployee employee = new Employee();

        //// Set employee properties
        //employee.FirstName = "Danila";
        //employee.LastName = "Butkevich";
        //employee.Email = "butkevich@gmail.com";
        //employee.Position = "Game dev";

        //// Set department properties
        //department.DepartmentName = "Game development";
        //department.Employee = employee;

        //// Assign to company
        //company.Department = department;
        //company.Name = "Cherry";

        //company.Print();
        #endregion

        #region InheritanceTasks
        Car car = new Car("Toyota", 270, "Бензин");
        Bicycle bike = new Bicycle("Trek", 20, true);
        Bus bus = new Bus("Mercedes", 270, 75);

        Console.WriteLine("=== Информация о транспорте ===");
        car.ShowInfo();
        Console.WriteLine();

        bike.ShowInfo();
        Console.WriteLine();

        bus.ShowInfo();
        #endregion
    }
}