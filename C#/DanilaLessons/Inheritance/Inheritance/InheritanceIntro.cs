using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance;

interface IEmployee
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    string Position { get; set; }
}

interface IDepartment
{
    string DepartmentName { get; set; }
    IEmployee Employee { get; set; }
}

// Concrete implementations
class Employee : IEmployee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Position { get; set; }
}

class Department : IDepartment
{
    public string DepartmentName { get; set; }
    public IEmployee Employee { get; set; }
}

class Company
{
    public string Name { get; set; }
    public IDepartment Department { get; set; }

    public void Print()
    {
        if (Department?.Employee != null)
        {
            Console.WriteLine(Department.Employee.FirstName);
            Console.WriteLine(Department.Employee.LastName);
            Console.WriteLine(Department.Employee.Email);
            Console.WriteLine(Department.Employee.Position);
            Console.WriteLine(Department.DepartmentName);
            Console.WriteLine(Name);
        }
    }
}
