using ConsoleApp2.Entites;
using ConsoleApp2.Entites.Enum;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter department's name:");
        string department = Console.ReadLine();

        Console.WriteLine("Enter worker data:");
        Console.Write("Name:");
        string name = Console.ReadLine();

        Console.Write("Level (Junior/MidLevel/Senior):");
        WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());

        Console.Write("Base Salary:");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Department dpt = new Department(department);
        Worker worker = new Worker(name, level, baseSalary, dpt);

        Console.Write("How many contract to this worker?");
        double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter #" + i + " contract data:");
            Console.Write("Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Duration: ");
            int hour = int.Parse(Console.ReadLine());

            HourContract hourContract = new HourContract(date, valuePerHour, hour);
            worker.addContract(hourContract);
        }

        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string monthAndYear = Console.ReadLine();
        int month = int.Parse(monthAndYear.Substring(0, 2));
        int year = int.Parse(monthAndYear.Substring(3));
        Console.WriteLine("Name: " + worker.Name);
        Console.WriteLine("Department: " + worker.Department.Name);
        Console.WriteLine("Income for " + monthAndYear + ": " + worker.income(year, month));
    }
}