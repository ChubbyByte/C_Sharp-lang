using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class Program
    {
        struct Employee
        {
            public int id;
            public string name;
            public double salary;
            public string department;

            public void setData(int idValue, string nameValue, double salaryValue, string departmentValue)
            {
                id = idValue;
                name = nameValue;
                salary = salaryValue;
                department = departmentValue;
            }

            public void showData()
            {
                Console.WriteLine("id: \t\t" + id);
                Console.WriteLine("Name: \t\t" + name);
                Console.WriteLine("Salary: \t" + salary);
                Console.WriteLine("Department: \t" + department + "\n");
            }
        }
        static void Main(string[] args)
        {
            /*Employee emp1;
            emp1.id = 1;
            emp1.name = "John";
            emp1.salary = 10000;
            emp1.department = "IT";
            Console.WriteLine("Employee id: " + emp1.id);*/

            /*Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.setData(1, "John", 10000, "IT");
            emp2.setData(2, "Sam", 14000, "HR");

            emp1.showData();
            emp2.showData();*/

            Employee[] emp = new Employee[2]; // <-- size of array (Arr of Structure)
            emp[0].setData(1, "John", 10000, "IT");
            emp[0].showData();
            emp[1].setData(2, "Sam", 14000, "HR");
            emp[1].showData();
        }
    }
}

