using Course;
using System.Globalization;


namespace AumentoSalario {
    class Program {
        static void Main(string[] args) {
            int n = 0;
            int id;
            string name;
            double salary;
            CultureInfo CI = CultureInfo.InvariantCulture;
            List<Employee> list = new List<Employee>();

            do {
                Console.Write("How many employees will be register? ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > 10);

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i}:");

                do {
                    Console.Write("Id: ");
                    id = int.Parse(Console.ReadLine());
                } while (n <= 0);

                do {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                } while (name == null || name.Length < 3);

                do {
                    Console.Write("Salary: ");
                    salary = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
                } while (n <= 0);


                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}