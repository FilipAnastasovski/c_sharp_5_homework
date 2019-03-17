using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_5_homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee bob = new Employee() { FirstName = "bob", LastName = "bobsky", Salary = 600, Role = Role.Other };
            SalesPerson mark = new SalesPerson("mark", "markov", 1000);
            mark.ExtendSuccessSaleRevenue(2000);
            Manager ivanIvanovski = new Manager("ivan", "ivanovski", 1500);
            Manager jackJack = new Manager("jack", "jack", 200);
            Contractor contractor1 = new Contractor("dexter", "abc", 40, 9, ivanIvanovski);
            Contractor contractor2 = new Contractor("tomato", "potato", 60, 11, jackJack);



            CEO bigCheese = new CEO("big", "cheese", 560);
            bigCheese.employees = new List<Employee> { bob, mark, ivanIvanovski, jackJack, contractor1, contractor2 };
            Console.WriteLine("CEO");
            bigCheese.PrintInfo();
            bigCheese.AddSharesPrice(186);
            Console.WriteLine($"Salary of the CEO is: {bigCheese.GetSalary()}");
            Console.WriteLine("Employees");
            bigCheese.PrintEmployees();

            Console.ReadLine();
        }
    }
}