using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanilaLessons;

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
