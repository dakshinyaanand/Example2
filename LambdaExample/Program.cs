using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 9, 3, 4, 5, 7, 2, 4,2, 7, 8, 1, 3, 2 };
            foreach(var a in arr.Where(n => n > 5))
            {
                Console.WriteLine(a);
            }
            string[] cities = { "mumbai", "pune", "chennai", "hyderabad", "kolkatta", "new delhi", "pondicherry" };
            foreach(var c in cities.Where(g => g.StartsWith("p") || g.StartsWith("P")))
            {
                Console.WriteLine(c);
            }
            foreach(var c in cities.Where(x => x.Contains("e")))
            {
                Console.WriteLine(c);
              
            }
            var result = cities.Where(x => x.Contains("e"));
            Console.WriteLine(result.Count());
            List<Employee> emp = new List<Employee> {
                new Employee {Empid=100,Name="MARTIN",Dept="IT",Salary=35000 },
                new Employee {Empid=101,Name="JAMES",Dept="HR",Salary=45000 },
                new Employee {Empid=102,Name="DAVID",Dept="IT",Salary=55000 },
                new Employee {Empid=103,Name="ALWYN",Dept="ACC",Salary=25000 }

            };
            //display values
            foreach (var r in emp)
                Console.WriteLine(r.Empid + " " + r.Name + " " + r.Dept + " " + r.Salary);
            Console.WriteLine("****************************");
            var data = emp.Where(x => x.Empid == 100).SingleOrDefault();

            if (data == null)
                Console.WriteLine("invalid EMpID");
            else
                Console.WriteLine(data.Empid + " " + data.Name + " " + data.Dept + " " + data.Salary);

            Console.WriteLine("****************************");

            var data1 = emp.Where(x => x.Dept == "IT");

            if (data1.Count()==0)
                Console.WriteLine("invalid DEPT");
            else
            {
                foreach (var r in data1)
                { Console.WriteLine(r.Empid + " " + r.Name + " " + r.Dept + " " + r.Salary); }
            }
            Console.WriteLine("****************************");
            var data3 = emp.Where(x => x.Dept == "IT" && x.Salary > 50000);
            foreach(var d in data3)
            {
                Console.WriteLine(d.Empid + " " + d.Name + " " + d.Dept + " " + d.Salary);
            }
            Console.WriteLine("****************************");
            var data4 = emp.OrderBy(x => x.Name).Select(y => y.Name);
            foreach (var g in data4)
                Console.WriteLine(g);
            Console.WriteLine("****************************");
            //Console.WriteLine("****************************");
            var data5 = emp.OrderByDescending(x => x.Name).Select(y => y.Name);
            foreach (var g in data4)
                Console.WriteLine(g);
            Console.WriteLine("****************************");
            //select 
            var data6= emp.Select(x => new { Ename = x.Name, Esalary = x.Salary });

            foreach (var h in data6)
                Console.WriteLine(h.Ename + " " + h.Esalary);
            Console.WriteLine("****************************");
            var data7 = emp.GroupBy(x => x.Dept).Select(x => new { DeptName = x.Key, EmpCount = x.Count(), SumSalary = x.Sum(y => y.Salary) });

            foreach (var h in data7)
                Console.WriteLine(h.DeptName + " " + h.EmpCount+" "+h.SumSalary);
            Console.WriteLine("****************************");
            Console.WriteLine("max salary:" + emp.Max(x => x.Salary));
            Console.WriteLine("****************************");
            Console.WriteLine("min salary:" + emp.Min(x => x.Salary));
            Console.WriteLine("****************************");
            var maxsal = emp.Where(x => x.Salary == emp.Max(y => y.Salary));
            foreach (var r in maxsal)
                Console.WriteLine(r.Empid + " " + r.Name + " " + r.Dept + " " + r.Salary);
            Console.WriteLine("****************************");
            var minsal = emp.Where(x => x.Salary == emp.Min(y => y.Salary));
            foreach (var r in minsal)
                Console.WriteLine(r.Empid + " " + r.Name + " " + r.Dept + " " + r.Salary);
            Console.WriteLine("****************************");
        }
    }
}
