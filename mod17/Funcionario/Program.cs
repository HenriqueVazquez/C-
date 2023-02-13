using Funcionario.Entities;
using System.Collections.Generic;
using System.Globalization;

class Program {
    static void Print<T>(string message, IEnumerable<T> collection) {
        Console.WriteLine(message);
        foreach (T obj in collection) {
            Console.WriteLine(obj);
        }
        Console.WriteLine();
    }

    static void Main(string[] args) {
        CultureInfo CI = CultureInfo.InvariantCulture;

        Console.Write("Enter full file path: ");
        string path = Console.ReadLine();

        List<Employee> employeeList = new List<Employee>();

        try {
            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CI);
                    employeeList.Add(new Employee(name, email, salary));
                }
            }
            Console.Write("Email of people whose salary is more than: ");
            double salaryFilter = double.Parse(Console.ReadLine().Replace(',', '.'), CI);


            var emails = employeeList.Where(e => e.Salary > salaryFilter).OrderBy(e => e.Email).Select(e => e.Email);

            var sumOfSalary = employeeList.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

            Print("", emails);

            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sumOfSalary.ToString("F2", CI));
            
        }
        catch (IOException e) {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}
