using Assignment24;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                Id = 07,
                FirstName = "Kishan",
                LastName = "Kumar",
                Salary = 72000.00
            };
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("E:\\Users\\kishan\\source\\repos\\Day 25\\Assignment24\\Employee.cs", FileMode.Create))
            {
                formatter.Serialize(fs, employee);
                Console.WriteLine("Created and Serialized");
                Console.WriteLine(employee.Id);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Salary);

            }
            using (FileStream fs = new FileStream("E:\\Users\\kishan\\source\\repos\\Day 25\\Assignment24\\Employee.cs", FileMode.Open))
            {
                employee = (Employee)formatter.Deserialize(fs);
                Console.WriteLine("De-Serialized");
                Console.WriteLine(employee.Id);
                Console.WriteLine(employee.FirstName);
                Console.WriteLine(employee.LastName);
                Console.WriteLine(employee.Salary);

            }
            Console.ReadKey();
        }
    }
}
